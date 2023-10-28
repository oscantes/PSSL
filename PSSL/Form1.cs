using System.Diagnostics;

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
        //made a change to test reverting back to a previous version
        //git revert is different from git reset
        //when revert is done, it doesn't edit history but adds to it
        //plus it changes files to the reverted branch and you can sync project right after
        //reset however deletes history and reverts branch to the desired one
        //additionally "git push -f" has to be done from vs > git > cmd otherwise you can't push project to remote
    }
}