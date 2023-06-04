namespace PasswordManager.Forms
{
    partial class ForgotPasswordRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordRequest));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            email = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 24);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(396, 4);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 0;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 89);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Email:";
            // 
            // email
            // 
            email.Location = new Point(71, 86);
            email.Name = "email";
            email.Size = new Size(309, 23);
            email.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(144, 129);
            button1.Name = "button1";
            button1.Size = new Size(131, 31);
            button1.TabIndex = 5;
            button1.Text = "Reset Password";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ForgotPasswordRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(414, 186);
            Controls.Add(button1);
            Controls.Add(email);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ForgotPasswordRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPasswordRequest";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox email;
        private Button button1;
    }
}