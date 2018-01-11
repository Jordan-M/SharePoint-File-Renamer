using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharepointFileRenamer
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        private void uxOpenFileButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog()
            {
                Description = "Select a folder to copy."
            };

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = folderBrowser.SelectedPath;
                uxSourceTextbox.Text = sourcePath;
            }

        }

        private void CopyDir(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                // Replace the invalid text
                Regex replacePattern = new Regex("[$&@# ]");
                string cleanFileName = file.Name;
                cleanFileName = replacePattern.Replace(cleanFileName, "_");
                string temppath = Path.Combine(destDirName, cleanFileName);
                bool fileExisted = false;


                try
                {
                    file.MoveTo(temppath);
                }
                catch(IOException)
                {
                    string path = Path.Combine(destDirName, TimeStampFile(cleanFileName, file));
                    try
                    {
                        file.MoveTo(path);
                    }
                    catch(Exception)
                    {
                        if (this.InvokeRequired)
                        {
                            this.BeginInvoke(new Action(() => uxLog.AppendText("Critical Error: " + file.FullName + " was not copied!!\n", Color.Red)));
                        }
                        
                    }

                    fileExisted = true;
                }
                catch (Exception)
                {
                    uxLog.AppendText(file.Name + " was not copied!", Color.Red);
                }


                string logText = file.Name + " -> " + cleanFileName + "\n";
                if (fileExisted)
                {
                    if (this.InvokeRequired)
                    {
                        this.BeginInvoke(new Action(() => uxLog.AppendText(logText, Color.Blue)));
                    }
                }
                else
                {   if (this.InvokeRequired)
                    this.BeginInvoke(new Action(() => uxLog.AppendText(logText, Color.Green)));
                }
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    CopyDir(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private string LogLine(int numDashes)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < numDashes; i++)
            {
                sb.Append("--");
            }
            sb.Append('\n');
            return sb.ToString();
        }

        private void uxCopyFolder_Click(object sender, EventArgs e)
        {
            if (uxSourceTextbox.Text != String.Empty && uxDestTextbox.Text != String.Empty)
            {
                uxLog.Text = "";
                uxLog.AppendText("Copying " + uxSourceTextbox.Text + " to " + uxDestTextbox.Text + "\n");
                string destPath = "";

                if (IsRoot(uxSourceTextbox.Text))
                {
                   destPath = uxDestTextbox.Text + "\\" + uxSourceTextbox.Text[0];
                }
                else
                {
                   destPath = uxDestTextbox.Text + "\\" + uxSourceTextbox.Text.Substring(uxSourceTextbox.Text.LastIndexOf("\\") + 1);
                }
                
                DirectoryInfo dir = new DirectoryInfo(destPath);
                if (!dir.Exists)
                {
                    Directory.CreateDirectory(dir.FullName);
                    Task.Factory.StartNew(() => CopyDir(uxSourceTextbox.Text, dir.FullName, true)).ContinueWith(task => MessageBox.Show("Files copied!"));
                }
                else
                {
                    MessageBox.Show("Could not copy files, folder " + dir.Name + " already exists!");
                }
            }
        }

        private void uxOpenDestButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog()
            {
                Description = "Select a destination to copy to."
            };

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = folderBrowser.SelectedPath;
                uxDestTextbox.Text = sourcePath;
            }
        }

        private bool IsRoot(string path)
        {
            return path.Substring(path.LastIndexOf("\\") + 1) == "";
        }

        private string TimeStampFile(string path, FileInfo file)
        {
            // If we get an IOException try to rename the file and write it again.
            string fileWithoutExt = path.Substring(0, path.IndexOf('.'));
            string fileTime = file.CreationTime.Month + "." + file.CreationTime.Day + "." + file.CreationTime.Year + "_" + file.CreationTime.Hour + "." + file.CreationTime.Minute + "." + file.CreationTime.Second + "." + file.CreationTime.Millisecond;
            return fileWithoutExt + " (" + fileTime + ")" + path.Substring(path.IndexOf('.'));
        }
    }
}
