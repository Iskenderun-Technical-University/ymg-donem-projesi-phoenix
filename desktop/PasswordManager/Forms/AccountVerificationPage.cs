using PasswordManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Forms
{
    internal partial class AccountVerificationPage : Form
    {

        private bool _dragging = false;
        private Point _offset;
        private Point _startPoint = new Point(0, 0);


        public AccountVerificationPage()
        {
            InitializeComponent();
        }

        private void panel_tab_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void panel_tab_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - this._startPoint.X, point.Y - this._startPoint.Y);
            }
        }

        private void panel_tab_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer.Value <= 119)
            {
                timer_text.Text = (120 - timer.Value).ToString();
                timer.Value += 1;
            }
            else
            {
                this.Hide();
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codeText = code.Text;
            string response = UserService.VerifyAccount(codeText);
            if (response.Contains("verificated"))
            {
                MessageBox.Show(response, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show(response,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
