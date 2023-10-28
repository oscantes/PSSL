using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace PSSL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo cmdwindow = new("cmd.exe");
            Process.Start(cmdwindow);
        }

        private void buttontaskmgr_Click(object sender, EventArgs e)
        {
            ProcessStartInfo taskmgrwindow = new("taskmgr.exe");
            Process.Start(taskmgrwindow);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello {usernamebox.Text}, you can use your computer {computernamebox.Text}");
        }

        private void buttondevmgmt_Click(object sender, EventArgs e)
        {
            var process = new ProcessStartInfo();
            process.UseShellExecute = true;
            //proc1.Verb = "runas";

            process.WorkingDirectory = @"C:\Windows\System32";
            process.FileName = @"C:\Windows\System32\cmd.exe";
            process.UserName = "system";
            string anyCommand = "devmgmt.msc";
            process.Arguments = "/c " + anyCommand;
            process.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(process);
        }

        //made a change to test reverting back to a previous version
        //git revert is different from git reset
        //when revert is done, it doesn't edit history but adds to it
        //plus it changes files to the reverted branch and you can sync project right after
        //reset however deletes history and reverts branch to the desired one
        //additionally "git push -f" has to be done from vs > git > cmd otherwise you can't push project to remote
    }
}