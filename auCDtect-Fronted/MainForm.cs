using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace auCDtect_Fronted
{
    public partial class MainForm : Form 
    {
        private const string programName = @"tools/auCDtect.exe";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            if (!(File.Exists(programName)))
            {
                MessageBox.Show("auCDtect.exe is not found, auCDtect-frontend can't be used without it. Please place auCDtect.exe in tools directory", "auCDtect.exe not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void btnAddFilesClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in openFileDialog.FileNames)
                {
                    AddFileToList(file);
                }
            }
        }

        private void btnExitClick(object sender, EventArgs e)
        {
            this.Close();
        }


        private void lstbxFilesDragDrop(object sender, DragEventArgs e)
        {
            string[] fileDropList = (string[]) e.Data.GetData(DataFormats.FileDrop);
          
            foreach (string fileDropItem in fileDropList)
            {
                // Check whether dropped item is directory
                if (Directory.Exists(fileDropItem))
                {
                     //find all files in that directory
                     foreach(string fileDropDirItem in Directory.GetFiles(fileDropItem, "*.*", SearchOption.AllDirectories))
                     {
                        AddFileToList(fileDropDirItem);   
                     }
                }
                else 
                {
                    AddFileToList(fileDropItem);                   
                }
            }
        }
		
		private void lstbxFilesDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
		
        private void AddFileToList(string fullFileName)
        {
            string extension = Path.GetExtension(fullFileName);
            if (extension == ".wav")
            {               
                lstbxFiles.Items.Add(fullFileName);
            }
        }

        private void btnAboutClick(object sender, EventArgs e)
        {
            MessageBox.Show("auCDtect Frontend v1.0, using auCDtect 0.8.2", "auCDtect Frontend version info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHelpClick(object sender, EventArgs e)
        {
            MessageBox.Show("Place your mouse pointer over an option to get more information", "auCDtect Fronted Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemoveFileClick(object sender, EventArgs e)
        {
            /*
            for (int i = lstbxFiles.SelectedItems.Count - 1; i > -1; i--)
            {
                lstbxFiles.Items.Remove(lstbxFiles.SelectedItems[i]);
            }
            */
            while (lstbxFiles.SelectedItems.Count > 0)
            {
                lstbxFiles.Items.Remove(lstbxFiles.SelectedItems[0]);
            }
        }

        private void btnClearListClick(object sender, EventArgs e)
        {
            lstbxFiles.Items.Clear();
        }

        private void btnAnalizeFilesClick(object sender, EventArgs e)
        {
            string format, percent;
            
            foreach(string fullFileName in lstbxFiles.Items)
            {
                AnalyzeFile(fullFileName, out format, out percent);
                ApendTextToOutputControl(fullFileName, format, percent);
            }
        }


        private void ApendTextToOutputControl(string fullFileName, string format, string percent)
        {
            string fileName = Path.GetFileName(fullFileName);
            Color color;
            switch (format)
            {
                case "CDDA":
                    color = Color.Green;
                    break;
                case "MPEG":
                    color = Color.Red;
                    break;
                case "UNKN":
                    color = Color.Yellow;
                    break;
                default:
                    color = Color.Black;
                    break;
            }
            AppendColorTextToOutputControl(fileName + " => " + format + " [" + percent + "]" + Environment.NewLine, color);
        }

        private void AppendColorTextToOutputControl(string text, Color color)
        {
            rtxtbxOutput.SelectionStart = rtxtbxOutput.TextLength;
            rtxtbxOutput.SelectionLength = 0;
            rtxtbxOutput.SelectionColor = color;
            rtxtbxOutput.AppendText(text);
            rtxtbxOutput.SelectionColor = rtxtbxOutput.ForeColor;
        }

        private static void AnalyzeFile(string fileName, out string format, out string percent)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = programName;
                process.StartInfo.Arguments += "-m0 ";
                process.StartInfo.Arguments += "\"";
                process.StartInfo.Arguments += fileName;
                process.StartInfo.Arguments += "\"";

                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                process.WaitForExit();
               
                string processOutput = process.StandardOutput.ReadToEnd();
                ParseOutput(processOutput, out format, out percent);
                process.Close();
            }
        }

        private static void ParseOutput(string text, out string format, out string percent)
        {
            int startIndex, length;
            string keyword1 = "looks like", keyword2 = "with", keyword3 = "probability";

            startIndex = text.IndexOf(keyword1) + keyword1.Length + 1;
            length = text.IndexOf(keyword2, startIndex) - startIndex - 1;

            format = text.Substring(startIndex, length);

            startIndex = text.IndexOf(keyword3, startIndex + length) + keyword3.Length + 1;
            length = text.IndexOf("%", startIndex) - startIndex + 1;

            percent = text.Substring(startIndex, length);
        }
    }
}
