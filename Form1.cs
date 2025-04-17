using System.Diagnostics;
using Microsoft.Win32;

namespace PCleaner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void githubButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://github.com/MartinLXXX6/PCleaner") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("We couldnt open the url (Only for Windows url):\n" + ex.Message);
            }
        }

        private void tempButton_Click(object sender, EventArgs e)
        {
            DeleteAllFilesAndFoldersFromPath("C:\\Windows\\Temp");
            DeleteAllFilesAndFoldersFromPath("C:\\Windows\\Prefetch");
            DeleteAllFilesAndFoldersFromPath(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Temp");
            MessageBox.Show("Temp Files & Folders Deleted!!");
        }

        private void cleanupButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("C:\\Windows\\System32\\cleanmgr.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldnt start Windows Disk Cleanup App:\n" + ex.Message);
            }
        }

        private void startupButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("ms-settings:startupapps") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldnt start startup apps Settings page:\n" + ex.Message);
            }
        }

        private void servicesButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("C:\\Windows\\System32\\msconfig.exe", "/3"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldnt start Windows System Configuration App:\n" + ex.Message);
            }
        }

        private void UWPButton_Click(object sender, EventArgs e)
        {
            try
            {
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications", "GlobalUserDisabled", 1);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error, couldnt edit the Registry Editor:\n" + ex.Message);
            }
        }

        private void featuresButton_Click(object sender, EventArgs e)
        {
            Process.Start("optionalfeatures");
        }

        private void DeleteAllFilesAndFoldersFromPath(string path)
        {
            string[] files;
            try
            {
                files = System.IO.Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting files, probably need to run as admin priviliges:\n" + ex.Message);
                return;
            }

            for (int i = 0; i < files.Length; i++)
            {
                try { System.IO.File.Delete(files[i]); }
                catch { }
            }


            string[] folders;
            try
            {
                folders = System.IO.Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting files, probably need to run as admin priviliges:\n" + ex.Message);
                return;
            }

            for (int j = 0; j < folders.Length; j++)
            {
                try { System.IO.Directory.Delete(folders[j], recursive: true); }
                catch { }
            }
        }
    }
}