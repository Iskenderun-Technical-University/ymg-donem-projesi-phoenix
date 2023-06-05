namespace PasswordManager.Forms
{
    partial class PasswordManagerMain
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordManagerMain));
            panel3 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            passwordList1 = new DataGridView();
            passwordList = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            title = new TextBox();
            username = new TextBox();
            password = new TextBox();
            url = new TextBox();
            notes = new TextBox();
            label2 = new Label();
            save_text = new Label();
            update_text = new Label();
            delete_text = new Label();
            cancel_text = new Label();
            cancel_btn = new Panel();
            save_btn = new Panel();
            newPassword = new Panel();
            generate = new Label();
            panel2 = new Panel();
            refresh = new Label();
            button1 = new Button();
            generate_exit = new Label();
            generatedPassword = new Label();
            label3 = new Label();
            trackBar1 = new TrackBar();
            special = new CheckBox();
            num = new CheckBox();
            lower = new CheckBox();
            upper = new CheckBox();
            exit = new LinkLabel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordList1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            cancel_btn.SuspendLayout();
            save_btn.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Aqua;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(-2, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1094, 35);
            panel3.TabIndex = 5;
            panel3.MouseDown += panel_tab_MouseDown;
            panel3.MouseMove += panel_tab_MouseMove;
            panel3.MouseUp += panel_tab_MouseUp;
            // 
            // panel1
            // 
            panel1.Location = new Point(290, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 41);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Cascadia Mono SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1068, 4);
            label1.Name = "label1";
            label1.Size = new Size(23, 25);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // passwordList1
            // 
            passwordList1.AllowUserToAddRows = false;
            passwordList1.AllowUserToDeleteRows = false;
            passwordList1.AllowUserToResizeColumns = false;
            passwordList1.AllowUserToResizeRows = false;
            passwordList1.BackgroundColor = Color.FromArgb(85, 45, 166);
            passwordList1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            passwordList1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(85, 45, 166);
            dataGridViewCellStyle1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(196, 245, 240);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(85, 45, 166);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(196, 245, 240);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            passwordList1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            passwordList1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            passwordList1.Columns.AddRange(new DataGridViewColumn[] { passwordList });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(216, 111, 232);
            dataGridViewCellStyle3.Font = new Font("Cascadia Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(161, 240, 240);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(109, 131, 242);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            passwordList1.DefaultCellStyle = dataGridViewCellStyle3;
            passwordList1.EnableHeadersVisualStyles = false;
            passwordList1.Location = new Point(-2, 33);
            passwordList1.MultiSelect = false;
            passwordList1.Name = "passwordList1";
            passwordList1.ReadOnly = true;
            passwordList1.RowTemplate.Height = 35;
            passwordList1.RowTemplate.ReadOnly = true;
            passwordList1.RowTemplate.Resizable = DataGridViewTriState.False;
            passwordList1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            passwordList1.Size = new Size(289, 589);
            passwordList1.TabIndex = 6;
            passwordList1.Click += passwordList1_Click;
            // 
            // passwordList
            // 
            passwordList.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            passwordList.DefaultCellStyle = dataGridViewCellStyle2;
            passwordList.FillWeight = 200F;
            passwordList.HeaderText = "Password List";
            passwordList.Name = "passwordList";
            passwordList.ReadOnly = true;
            // 
            // title
            // 
            title.BackColor = Color.FromArgb(237, 237, 237);
            title.BorderStyle = BorderStyle.None;
            title.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(594, 166);
            title.Name = "title";
            title.Size = new Size(197, 28);
            title.TabIndex = 7;
            // 
            // username
            // 
            username.BackColor = Color.FromArgb(237, 237, 237);
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(594, 233);
            username.Name = "username";
            username.Size = new Size(197, 28);
            username.TabIndex = 8;
            // 
            // password
            // 
            password.BackColor = Color.FromArgb(237, 237, 237);
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(592, 299);
            password.Name = "password";
            password.Size = new Size(197, 28);
            password.TabIndex = 9;
            password.UseSystemPasswordChar = true;
            // 
            // url
            // 
            url.BackColor = Color.FromArgb(237, 237, 237);
            url.BorderStyle = BorderStyle.None;
            url.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            url.Location = new Point(592, 365);
            url.Name = "url";
            url.Size = new Size(197, 28);
            url.TabIndex = 10;
            // 
            // notes
            // 
            notes.BackColor = Color.FromArgb(237, 237, 237);
            notes.BorderStyle = BorderStyle.None;
            notes.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            notes.Location = new Point(593, 430);
            notes.Name = "notes";
            notes.Size = new Size(197, 28);
            notes.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(814, 304);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 12;
            label2.Text = "👁️";
            label2.MouseDown += label2_MouseDown;
            label2.MouseUp += label2_MouseUp;
            // 
            // save_text
            // 
            save_text.AutoSize = true;
            save_text.BackColor = Color.Transparent;
            save_text.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            save_text.Location = new Point(32, 9);
            save_text.Name = "save_text";
            save_text.Size = new Size(46, 21);
            save_text.TabIndex = 14;
            save_text.Text = "Save";
            save_text.Click += save_btn_Click;
            // 
            // update_text
            // 
            update_text.AutoSize = true;
            update_text.BackColor = Color.Transparent;
            update_text.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            update_text.Location = new Point(20, 9);
            update_text.Name = "update_text";
            update_text.Size = new Size(66, 21);
            update_text.TabIndex = 15;
            update_text.Text = "Update";
            update_text.Click += save_btn_Click;
            // 
            // delete_text
            // 
            delete_text.AutoSize = true;
            delete_text.BackColor = Color.Transparent;
            delete_text.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            delete_text.ForeColor = Color.WhiteSmoke;
            delete_text.Location = new Point(25, 8);
            delete_text.Name = "delete_text";
            delete_text.Size = new Size(60, 21);
            delete_text.TabIndex = 16;
            delete_text.Text = "Delete";
            delete_text.Click += cancel_btn_Click;
            // 
            // cancel_text
            // 
            cancel_text.AutoSize = true;
            cancel_text.BackColor = Color.Transparent;
            cancel_text.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cancel_text.ForeColor = Color.WhiteSmoke;
            cancel_text.Location = new Point(24, 9);
            cancel_text.Name = "cancel_text";
            cancel_text.Size = new Size(61, 21);
            cancel_text.TabIndex = 17;
            cancel_text.Text = "Cancel";
            cancel_text.Click += cancel_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.Transparent;
            cancel_btn.Controls.Add(cancel_text);
            cancel_btn.Controls.Add(delete_text);
            cancel_btn.Cursor = Cursors.Hand;
            cancel_btn.Location = new Point(698, 513);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(107, 39);
            cancel_btn.TabIndex = 18;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // save_btn
            // 
            save_btn.BackColor = Color.Transparent;
            save_btn.Controls.Add(update_text);
            save_btn.Controls.Add(save_text);
            save_btn.Cursor = Cursors.Hand;
            save_btn.Location = new Point(845, 513);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(107, 39);
            save_btn.TabIndex = 19;
            save_btn.Click += save_btn_Click;
            // 
            // newPassword
            // 
            newPassword.BackColor = Color.Transparent;
            newPassword.Cursor = Cursors.Hand;
            newPassword.Location = new Point(939, 36);
            newPassword.Name = "newPassword";
            newPassword.Size = new Size(150, 35);
            newPassword.TabIndex = 20;
            newPassword.Click += newPassword_Click;
            // 
            // generate
            // 
            generate.AutoSize = true;
            generate.BackColor = Color.Transparent;
            generate.Cursor = Cursors.Hand;
            generate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            generate.Location = new Point(836, 303);
            generate.Name = "generate";
            generate.Size = new Size(33, 21);
            generate.TabIndex = 21;
            generate.Text = "🔄";
            generate.Click += generate_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(42, 130, 127);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(refresh);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(generate_exit);
            panel2.Controls.Add(generatedPassword);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(trackBar1);
            panel2.Controls.Add(special);
            panel2.Controls.Add(num);
            panel2.Controls.Add(lower);
            panel2.Controls.Add(upper);
            panel2.Location = new Point(863, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 250);
            panel2.TabIndex = 22;
            panel2.Visible = false;
            // 
            // refresh
            // 
            refresh.AutoSize = true;
            refresh.BackColor = Color.Transparent;
            refresh.Cursor = Cursors.Hand;
            refresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            refresh.Location = new Point(159, 40);
            refresh.Name = "refresh";
            refresh.Size = new Size(33, 21);
            refresh.TabIndex = 23;
            refresh.Text = "🔄";
            refresh.Click += refresh_Click;
            // 
            // button1
            // 
            button1.Location = new Point(73, 215);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Use";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // generate_exit
            // 
            generate_exit.AutoSize = true;
            generate_exit.Cursor = Cursors.Hand;
            generate_exit.Font = new Font("Cascadia Mono SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            generate_exit.Location = new Point(193, 0);
            generate_exit.Name = "generate_exit";
            generate_exit.Size = new Size(23, 25);
            generate_exit.TabIndex = 8;
            generate_exit.Text = "X";
            generate_exit.Click += generate_exit_Click;
            // 
            // generatedPassword
            // 
            generatedPassword.AutoSize = true;
            generatedPassword.Location = new Point(5, 192);
            generatedPassword.Name = "generatedPassword";
            generatedPassword.Size = new Size(0, 15);
            generatedPassword.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(78, 156);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Uzunluk :";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(16, 118);
            trackBar1.Maximum = 25;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(200, 45);
            trackBar1.TabIndex = 4;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // special
            // 
            special.AutoSize = true;
            special.ForeColor = Color.White;
            special.Location = new Point(15, 92);
            special.Name = "special";
            special.Size = new Size(76, 19);
            special.TabIndex = 3;
            special.Text = "!@#$%^&*";
            special.UseVisualStyleBackColor = true;
            // 
            // num
            // 
            num.AutoSize = true;
            num.ForeColor = Color.White;
            num.Location = new Point(15, 65);
            num.Name = "num";
            num.Size = new Size(43, 19);
            num.TabIndex = 2;
            num.Text = "0-9";
            num.UseVisualStyleBackColor = true;
            // 
            // lower
            // 
            lower.AutoSize = true;
            lower.ForeColor = Color.White;
            lower.Location = new Point(15, 40);
            lower.Name = "lower";
            lower.Size = new Size(42, 19);
            lower.TabIndex = 1;
            lower.Text = "a-z";
            lower.UseVisualStyleBackColor = true;
            // 
            // upper
            // 
            upper.AutoSize = true;
            upper.ForeColor = Color.White;
            upper.Location = new Point(16, 15);
            upper.Name = "upper";
            upper.Size = new Size(46, 19);
            upper.TabIndex = 0;
            upper.Text = "A-Z";
            upper.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.BackColor = Color.Transparent;
            exit.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            exit.Location = new Point(1018, 592);
            exit.Name = "exit";
            exit.Size = new Size(68, 20);
            exit.TabIndex = 23;
            exit.TabStop = true;
            exit.Text = "Log out?";
            exit.LinkClicked += exit_LinkClicked;
            // 
            // PasswordManagerMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.main_frame_background;
            ClientSize = new Size(1092, 620);
            Controls.Add(exit);
            Controls.Add(panel2);
            Controls.Add(generate);
            Controls.Add(newPassword);
            Controls.Add(save_btn);
            Controls.Add(cancel_btn);
            Controls.Add(label2);
            Controls.Add(notes);
            Controls.Add(url);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(title);
            Controls.Add(passwordList1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PasswordManagerMain";
            Text = "PasswordManagerMain";
            Load += PasswordManagerMain_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwordList1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            cancel_btn.ResumeLayout(false);
            cancel_btn.PerformLayout();
            save_btn.ResumeLayout(false);
            save_btn.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private Label label1;
        private DataGridView passwordList1;
        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn passwordList;
        private Panel panel1;
        private TextBox title;
        private TextBox username;
        private TextBox password;
        private TextBox url;
        private TextBox notes;
        private Label label2;
        private Label save_text;
        private Label update_text;
        private Label delete_text;
        private Label cancel_text;
        private Panel cancel_btn;
        private Panel save_btn;
        private Panel newPassword;
        private Label generate;
        private Panel panel2;
        private CheckBox special;
        private CheckBox num;
        private CheckBox lower;
        private CheckBox upper;
        private Label generate_exit;
        private Label generatedPassword;
        private Label label3;
        private TrackBar trackBar1;
        private Button button1;
        private Label refresh;
        private LinkLabel exit;
    }
}