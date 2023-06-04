using PasswordManager.Services;

namespace PasswordManager
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            pm_description = new Label();
            pm_header = new Label();
            panel3 = new Panel();
            label1 = new Label();
            login_side = new Panel();
            linkLabel3 = new LinkLabel();
            visible = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label10 = new Label();
            panel7 = new Panel();
            panel6 = new Panel();
            label9 = new Label();
            label8 = new Label();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            login_btn = new Panel();
            login = new Label();
            panel_pass = new Panel();
            password = new TextBox();
            panel_email = new Panel();
            email = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            login_side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visible).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            login_btn.SuspendLayout();
            panel_pass.SuspendLayout();
            panel_email.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 129, 179);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pm_description);
            panel1.Controls.Add(pm_header);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 564);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(99, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("CaskaydiaCove Nerd Font", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(255, 393);
            label7.Name = "label7";
            label7.Size = new Size(166, 28);
            label7.TabIndex = 8;
            label7.Text = "Manager App";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 7.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(287, 535);
            label6.Name = "label6";
            label6.Size = new Size(62, 12);
            label6.TabIndex = 6;
            label6.Text = "Melis Ölmez";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 7.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(285, 519);
            label5.Name = "label5";
            label5.Size = new Size(116, 12);
            label5.TabIndex = 5;
            label5.Text = "Muhammet Emin Özkan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(214, 497);
            label4.Name = "label4";
            label4.Size = new Size(94, 17);
            label4.TabIndex = 4;
            label4.Text = "Developed by:";
            // 
            // panel2
            // 
            panel2.Location = new Point(519, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(523, 523);
            panel2.TabIndex = 2;
            // 
            // pm_description
            // 
            pm_description.AutoSize = true;
            pm_description.Font = new Font("CaskaydiaCove Nerd Font", 18F, FontStyle.Bold, GraphicsUnit.Point);
            pm_description.ForeColor = SystemColors.Control;
            pm_description.Location = new Point(101, 357);
            pm_description.Name = "pm_description";
            pm_description.Size = new Size(320, 28);
            pm_description.TabIndex = 1;
            pm_description.Text = "Phoenix - The Password";
            // 
            // pm_header
            // 
            pm_header.AutoSize = true;
            pm_header.Font = new Font("CaskaydiaCove Nerd Font", 18F, FontStyle.Bold, GraphicsUnit.Point);
            pm_header.ForeColor = SystemColors.Control;
            pm_header.Location = new Point(213, 321);
            pm_header.Name = "pm_header";
            pm_header.Size = new Size(208, 28);
            pm_header.TabIndex = 0;
            pm_header.Text = "Welcome to the";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Aqua;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(956, 35);
            panel3.TabIndex = 4;
            panel3.MouseDown += panel_tab_MouseDown;
            panel3.MouseMove += panel_tab_MouseMove;
            panel3.MouseUp += panel_tab_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Cascadia Mono SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(929, 4);
            label1.Name = "label1";
            label1.Size = new Size(23, 25);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // login_side
            // 
            login_side.BackColor = Color.FromArgb(210, 217, 215);
            login_side.Controls.Add(linkLabel3);
            login_side.Controls.Add(visible);
            login_side.Controls.Add(pictureBox3);
            login_side.Controls.Add(pictureBox2);
            login_side.Controls.Add(label10);
            login_side.Controls.Add(panel7);
            login_side.Controls.Add(panel6);
            login_side.Controls.Add(label9);
            login_side.Controls.Add(label8);
            login_side.Controls.Add(linkLabel2);
            login_side.Controls.Add(linkLabel1);
            login_side.Controls.Add(login_btn);
            login_side.Controls.Add(panel_pass);
            login_side.Controls.Add(panel_email);
            login_side.ImeMode = ImeMode.Off;
            login_side.Location = new Point(427, 0);
            login_side.Name = "login_side";
            login_side.Size = new Size(529, 564);
            login_side.TabIndex = 3;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel3.Location = new Point(217, 467);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(104, 20);
            linkLabel3.TabIndex = 14;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Verify Account";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // visible
            // 
            visible.BackgroundImage = (Image)resources.GetObject("visible.BackgroundImage");
            visible.BackgroundImageLayout = ImageLayout.Stretch;
            visible.Cursor = Cursors.Hand;
            visible.Location = new Point(415, 255);
            visible.Name = "visible";
            visible.Size = new Size(15, 14);
            visible.TabIndex = 13;
            visible.TabStop = false;
            visible.Visible = false;
            visible.Click += visible_Click;
            visible.MouseDown += visible_MouseDown;
            visible.MouseUp += visible_MouseUp;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(82, 237);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(49, 47);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.email;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(82, 169);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 47);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("CaskaydiaCove Nerd Font", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(23, 129, 179);
            label10.Location = new Point(124, 91);
            label10.Name = "label10";
            label10.Size = new Size(306, 28);
            label10.TabIndex = 9;
            label10.Text = "Login to your account";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(290, 440);
            panel7.Name = "panel7";
            panel7.Size = new Size(130, 2);
            panel7.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(124, 440);
            panel6.Name = "panel6";
            panel6.Size = new Size(130, 2);
            panel6.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(210, 217, 215);
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(23, 129, 179);
            label9.Location = new Point(260, 429);
            label9.Name = "label9";
            label9.Size = new Size(24, 20);
            label9.TabIndex = 8;
            label9.Text = "or";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(23, 129, 179);
            label8.Location = new Point(141, 393);
            label8.Name = "label8";
            label8.Size = new Size(169, 20);
            label8.TabIndex = 7;
            label8.Text = "Don't have an account?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.Location = new Point(313, 393);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(99, 20);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Register now!";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(140, 320);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(125, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(23, 129, 179);
            login_btn.Controls.Add(login);
            login_btn.Cursor = Cursors.Hand;
            login_btn.Location = new Point(310, 301);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(116, 48);
            login_btn.TabIndex = 4;
            login_btn.Click += login_btn_Click;
            // 
            // login
            // 
            login.AutoSize = true;
            login.Cursor = Cursors.Hand;
            login.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            login.ForeColor = SystemColors.Control;
            login.Location = new Point(25, 9);
            login.Name = "login";
            login.Size = new Size(69, 30);
            login.TabIndex = 0;
            login.Text = "Login";
            login.Click += login_btn_Click;
            // 
            // panel_pass
            // 
            panel_pass.BackColor = Color.White;
            panel_pass.Controls.Add(password);
            panel_pass.Location = new Point(137, 237);
            panel_pass.Name = "panel_pass";
            panel_pass.Size = new Size(275, 47);
            panel_pass.TabIndex = 3;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(4, 9);
            password.Name = "password";
            password.PlaceholderText = "Password";
            password.Size = new Size(269, 26);
            password.TabIndex = 0;
            password.UseSystemPasswordChar = true;
            password.TextChanged += password_TextChanged;
            // 
            // panel_email
            // 
            panel_email.BackColor = Color.White;
            panel_email.Controls.Add(email);
            panel_email.Location = new Point(136, 169);
            panel_email.Name = "panel_email";
            panel_email.Size = new Size(275, 47);
            panel_email.TabIndex = 2;
            // 
            // email
            // 
            email.BorderStyle = BorderStyle.None;
            email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(5, 10);
            email.Name = "email";
            email.PlaceholderText = "Email";
            email.Size = new Size(269, 26);
            email.TabIndex = 1;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(955, 564);
            Controls.Add(panel3);
            Controls.Add(login_side);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Manager";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            login_side.ResumeLayout(false);
            login_side.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)visible).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            login_btn.ResumeLayout(false);
            login_btn.PerformLayout();
            panel_pass.ResumeLayout(false);
            panel_pass.PerformLayout();
            panel_email.ResumeLayout(false);
            panel_email.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label pm_description;
        private Label pm_header;
        private Label label1;
        private Panel panel2;
        private Panel login_side;
        private Panel panel_email;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel_pass;
        private TextBox password;
        private Panel login_btn;
        private Label login;
        private Panel panel6;
        private Label label9;
        private Label label8;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Panel panel7;
        private Label label7;
        private Label label10;
        private Panel panel3;
        private PictureBox pictureBox1;
        private TextBox email;
        private PictureBox visible;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private LinkLabel linkLabel3;
    }
}