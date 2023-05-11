namespace PasswordManager.Forms
{
    partial class AccountVerificationPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountVerificationPage));
            code = new MaskedTextBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            timer = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            timer_text = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // code
            // 
            code.BorderStyle = BorderStyle.FixedSingle;
            code.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            code.Location = new Point(124, 137);
            code.Mask = "000000";
            code.Name = "code";
            code.Size = new Size(140, 43);
            code.TabIndex = 0;
            code.TextAlign = HorizontalAlignment.Center;
            code.ValidatingType = typeof(int);
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 24);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel_tab_MouseDown;
            panel1.MouseMove += panel_tab_MouseMove;
            panel1.MouseUp += panel_tab_MouseUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(370, 4);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 0;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(100, 48);
            label1.Name = "label1";
            label1.Size = new Size(182, 21);
            label1.TabIndex = 2;
            label1.Text = "Enter Verification Code:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(124, 202);
            button1.Name = "button1";
            button1.Size = new Size(140, 53);
            button1.TabIndex = 3;
            button1.Text = "Confirm Verification";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer
            // 
            timer.Location = new Point(124, 91);
            timer.Maximum = 120;
            timer.Name = "timer";
            timer.Size = new Size(140, 31);
            timer.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer_text
            // 
            timer_text.AutoSize = true;
            timer_text.Location = new Point(270, 100);
            timer_text.Name = "timer_text";
            timer_text.Size = new Size(0, 15);
            timer_text.TabIndex = 5;
            // 
            // AccountVerificationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(393, 330);
            Controls.Add(timer_text);
            Controls.Add(timer);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(code);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AccountVerificationPage";
            Text = "AccountVerificationPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox code;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private ProgressBar timer;
        private System.Windows.Forms.Timer timer1;
        private Label timer_text;
        private Label label2;
    }
}