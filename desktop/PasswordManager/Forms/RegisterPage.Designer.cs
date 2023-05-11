namespace PasswordManager.Forms
{
    partial class RegisterPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            panel3 = new Panel();
            label1 = new Label();
            login_side = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            visible = new PictureBox();
            panel4 = new Panel();
            email = new TextBox();
            label10 = new Label();
            label8 = new Label();
            linkLabel2 = new LinkLabel();
            login_btn = new Panel();
            register = new Label();
            panel_pass = new Panel();
            password = new TextBox();
            panel_email = new Panel();
            name = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            pm_description = new Label();
            pm_header = new Label();
            panel3.SuspendLayout();
            login_side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visible).BeginInit();
            panel4.SuspendLayout();
            login_btn.SuspendLayout();
            panel_pass.SuspendLayout();
            panel_email.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Aqua;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(955, 35);
            panel3.TabIndex = 7;
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
            login_side.Controls.Add(pictureBox4);
            login_side.Controls.Add(pictureBox3);
            login_side.Controls.Add(pictureBox2);
            login_side.Controls.Add(visible);
            login_side.Controls.Add(panel4);
            login_side.Controls.Add(label10);
            login_side.Controls.Add(label8);
            login_side.Controls.Add(linkLabel2);
            login_side.Controls.Add(login_btn);
            login_side.Controls.Add(panel_pass);
            login_side.Controls.Add(panel_email);
            login_side.Location = new Point(427, 0);
            login_side.Name = "login_side";
            login_side.Size = new Size(528, 564);
            login_side.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(91, 174);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 47);
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(91, 302);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 47);
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.email;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(91, 237);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 47);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // visible
            // 
            visible.BackgroundImage = (Image)resources.GetObject("visible.BackgroundImage");
            visible.BackgroundImageLayout = ImageLayout.Stretch;
            visible.Location = new Point(421, 319);
            visible.Name = "visible";
            visible.Size = new Size(15, 14);
            visible.TabIndex = 14;
            visible.TabStop = false;
            visible.Visible = false;
            visible.MouseDown += visible_MouseDown;
            visible.MouseUp += visible_MouseUp;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(email);
            panel4.Location = new Point(140, 237);
            panel4.Name = "panel4";
            panel4.Size = new Size(275, 47);
            panel4.TabIndex = 3;
            // 
            // email
            // 
            email.BorderStyle = BorderStyle.None;
            email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(3, 11);
            email.Name = "email";
            email.PlaceholderText = " Email";
            email.Size = new Size(266, 26);
            email.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("CaskaydiaCove Nerd Font", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(23, 129, 179);
            label10.Location = new Point(210, 101);
            label10.Name = "label10";
            label10.Size = new Size(124, 28);
            label10.TabIndex = 9;
            label10.Text = "Register";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(23, 129, 179);
            label8.Location = new Point(142, 485);
            label8.Name = "label8";
            label8.Size = new Size(185, 20);
            label8.TabIndex = 7;
            label8.Text = "Already have an account?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.Location = new Point(327, 485);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(82, 20);
            linkLabel2.TabIndex = 10000;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Login now!";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(23, 129, 179);
            login_btn.Controls.Add(register);
            login_btn.Cursor = Cursors.Hand;
            login_btn.Location = new Point(218, 373);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(116, 48);
            login_btn.TabIndex = 4;
            login_btn.Click += register_Click;
            // 
            // register
            // 
            register.AutoSize = true;
            register.Cursor = Cursors.Hand;
            register.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            register.ForeColor = SystemColors.Control;
            register.Location = new Point(11, 9);
            register.Name = "register";
            register.Size = new Size(94, 30);
            register.TabIndex = 0;
            register.Text = "Register";
            register.Click += register_Click;
            // 
            // panel_pass
            // 
            panel_pass.BackColor = Color.White;
            panel_pass.Controls.Add(password);
            panel_pass.Location = new Point(140, 302);
            panel_pass.Name = "panel_pass";
            panel_pass.Size = new Size(275, 47);
            panel_pass.TabIndex = 3;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(4, 11);
            password.Name = "password";
            password.PlaceholderText = " Password";
            password.Size = new Size(266, 26);
            password.TabIndex = 1000;
            password.UseSystemPasswordChar = true;
            // 
            // panel_email
            // 
            panel_email.BackColor = Color.White;
            panel_email.Controls.Add(name);
            panel_email.Location = new Point(142, 174);
            panel_email.Name = "panel_email";
            panel_email.Size = new Size(275, 47);
            panel_email.TabIndex = 2;
            // 
            // name
            // 
            name.BorderStyle = BorderStyle.None;
            name.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(3, 12);
            name.Name = "name";
            name.PlaceholderText = " Name";
            name.Size = new Size(266, 26);
            name.TabIndex = 100;
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
            panel1.TabIndex = 5;
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
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 564);
            Controls.Add(panel3);
            Controls.Add(login_side);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterPage";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            login_side.ResumeLayout(false);
            login_side.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)visible).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            login_btn.ResumeLayout(false);
            login_btn.PerformLayout();
            panel_pass.ResumeLayout(false);
            panel_pass.PerformLayout();
            panel_email.ResumeLayout(false);
            panel_email.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label1;
        private Panel login_side;
        private Label label10;
        private Label label8;
        private LinkLabel linkLabel2;
        private Panel login_btn;
        private Label register;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private Label pm_description;
        private Label pm_header;
        private PictureBox visible;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Panel panel4;
        private TextBox email;
        private Panel panel_pass;
        private TextBox password;
        private Panel panel_email;
        private TextBox name;
    }
}