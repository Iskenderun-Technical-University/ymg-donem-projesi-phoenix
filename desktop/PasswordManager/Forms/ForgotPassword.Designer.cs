namespace PasswordManager.Forms
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            panel3 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            panel5 = new Panel();
            password1 = new TextBox();
            reset_password = new Button();
            label4 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            password_r = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            code = new TextBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Aqua;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, -2);
            panel3.Name = "panel3";
            panel3.Size = new Size(591, 36);
            panel3.TabIndex = 5;
            panel3.MouseDown += panel_tab_MouseDown;
            panel3.MouseMove += panel_tab_MouseMove;
            panel3.MouseUp += panel_tab_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Cascadia Mono SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(527, 6);
            label1.Name = "label1";
            label1.Size = new Size(23, 25);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(111, 128, 199);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(reset_password);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 595);
            panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.visible;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(426, 375);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 21);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.MouseDown += pictureBox2_MouseDown;
            pictureBox2.MouseUp += pictureBox2_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.visible;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(426, 271);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 21);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(54, 226);
            label5.Name = "label5";
            label5.Size = new Size(125, 21);
            label5.TabIndex = 7;
            label5.Text = "New Password:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(password1);
            panel5.Location = new Point(162, 263);
            panel5.Name = "panel5";
            panel5.Size = new Size(258, 38);
            panel5.TabIndex = 6;
            // 
            // password1
            // 
            password1.BorderStyle = BorderStyle.None;
            password1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password1.Location = new Point(3, 8);
            password1.Name = "password1";
            password1.Size = new Size(255, 22);
            password1.TabIndex = 0;
            password1.UseSystemPasswordChar = true;
            // 
            // reset_password
            // 
            reset_password.ForeColor = SystemColors.ActiveCaptionText;
            reset_password.Location = new Point(209, 480);
            reset_password.Name = "reset_password";
            reset_password.Size = new Size(166, 41);
            reset_password.TabIndex = 5;
            reset_password.Text = "Reset Password";
            reset_password.UseVisualStyleBackColor = true;
            reset_password.Click += reset_password_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(182, 50);
            label4.Name = "label4";
            label4.Size = new Size(205, 32);
            label4.TabIndex = 4;
            label4.Text = "Forgot Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(52, 328);
            label3.Name = "label3";
            label3.Size = new Size(186, 21);
            label3.TabIndex = 3;
            label3.Text = "New Password (Again):";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(password_r);
            panel4.Location = new Point(162, 365);
            panel4.Name = "panel4";
            panel4.Size = new Size(258, 38);
            panel4.TabIndex = 2;
            // 
            // password_r
            // 
            password_r.BorderStyle = BorderStyle.None;
            password_r.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password_r.Location = new Point(0, 9);
            password_r.Name = "password_r";
            password_r.Size = new Size(255, 22);
            password_r.TabIndex = 1;
            password_r.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(54, 125);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 1;
            label2.Text = "Reset Code:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(code);
            panel2.Location = new Point(162, 162);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 38);
            panel2.TabIndex = 0;
            // 
            // code
            // 
            code.BorderStyle = BorderStyle.None;
            code.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            code.Location = new Point(3, 8);
            code.Name = "code";
            code.Size = new Size(255, 22);
            code.TabIndex = 0;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 617);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ForgotPassword";
            Text = "ForgotPasswor";
            Load += ForgotPasswor_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label1;
        private Panel panel1;
        private Button reset_password;
        private Label label4;
        private Label label3;
        private Panel panel4;
        private TextBox password_r;
        private Label label2;
        private Panel panel2;
        private TextBox code;
        private Label label5;
        private Panel panel5;
        private TextBox password1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}