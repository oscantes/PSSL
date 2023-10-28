namespace PSSL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox1 = new TextBox();
            richTextBox2 = new RichTextBox();
            usernamebox = new TextBox();
            richTextBox1 = new RichTextBox();
            button5 = new Button();
            button4 = new Button();
            buttondevmgmt = new Button();
            buttontaskmgr = new Button();
            button1 = new Button();
            label3 = new Label();
            computernamebox = new TextBox();
            label2 = new Label();
            listBox1 = new ListBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            listBox3 = new ListBox();
            label5 = new Label();
            tab2usernamebox = new TextBox();
            listBox2 = new ListBox();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 544);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightYellow;
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(richTextBox2);
            tabPage1.Controls.Add(usernamebox);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(buttondevmgmt);
            tabPage1.Controls.Add(buttontaskmgr);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(computernamebox);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 516);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(365, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 23);
            textBox1.TabIndex = 13;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(259, 255);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(269, 152);
            richTextBox2.TabIndex = 12;
            richTextBox2.Text = "";
            // 
            // usernamebox
            // 
            usernamebox.Location = new Point(259, 226);
            usernamebox.Name = "usernamebox";
            usernamebox.Size = new Size(269, 23);
            usernamebox.TabIndex = 11;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 255);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(247, 152);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // button5
            // 
            button5.Location = new Point(259, 165);
            button5.Name = "button5";
            button5.Size = new Size(100, 30);
            button5.TabIndex = 9;
            button5.Text = "process starter";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(259, 129);
            button4.Name = "button4";
            button4.Size = new Size(100, 30);
            button4.TabIndex = 8;
            button4.Text = "Hello";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // buttondevmgmt
            // 
            buttondevmgmt.Location = new Point(259, 93);
            buttondevmgmt.Name = "buttondevmgmt";
            buttondevmgmt.Size = new Size(100, 30);
            buttondevmgmt.TabIndex = 7;
            buttondevmgmt.Text = "Device Manager";
            buttondevmgmt.UseVisualStyleBackColor = true;
            buttondevmgmt.Click += buttondevmgmt_Click;
            // 
            // buttontaskmgr
            // 
            buttontaskmgr.Location = new Point(259, 57);
            buttontaskmgr.Name = "buttontaskmgr";
            buttontaskmgr.Size = new Size(100, 30);
            buttontaskmgr.TabIndex = 6;
            buttontaskmgr.Text = "Task Manager";
            buttontaskmgr.UseVisualStyleBackColor = true;
            buttontaskmgr.Click += buttontaskmgr_Click;
            // 
            // button1
            // 
            button1.Location = new Point(259, 21);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 5;
            button1.Text = "cmd";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(259, 208);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // computernamebox
            // 
            computernamebox.Location = new Point(6, 226);
            computernamebox.Name = "computernamebox";
            computernamebox.Size = new Size(247, 23);
            computernamebox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 208);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 2;
            label2.Text = "Computername or IP";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "create_mistlog", "delete_Anka_cache", "delete_Jabber_cache", "get_OS_info", "get_User_info", "prep_for_PSExec", "get_installed_programs", "get_Administrators", "VPN_query", "INTF_get_computername_from_DW", "INTF_query_session" });
            listBox1.Location = new Point(6, 21);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(247, 184);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "İşlem Menüsü";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listBox3);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(tab2usernamebox);
            tabPage2.Controls.Add(listBox2);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 516);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kayıt Oluşturucu";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Items.AddRange(new object[] { "asd", "asd", "asd", "a", "sd" });
            listBox3.Location = new Point(315, 62);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(120, 94);
            listBox3.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(131, 44);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 3;
            label5.Text = "Template";
            // 
            // tab2usernamebox
            // 
            tab2usernamebox.Location = new Point(25, 62);
            tab2usernamebox.Name = "tab2usernamebox";
            tab2usernamebox.Size = new Size(100, 23);
            tab2usernamebox.TabIndex = 2;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "asd", "asd", "asd", "a", "sd" });
            listBox2.Location = new Point(131, 62);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(178, 94);
            listBox2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 44);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 0;
            label4.Text = "Username";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 568);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Button button5;
        private Button button4;
        private Button buttondevmgmt;
        private Button buttontaskmgr;
        private Button button1;
        private Label label3;
        private TextBox computernamebox;
        private RichTextBox richTextBox2;
        private TextBox usernamebox;
        private RichTextBox richTextBox1;
        private Label label4;
        private ListBox listBox2;
        private TextBox tab2usernamebox;
        private ListBox listBox3;
        private Label label5;
        private TextBox textBox1;
    }
}