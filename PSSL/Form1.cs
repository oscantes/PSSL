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

    }
}