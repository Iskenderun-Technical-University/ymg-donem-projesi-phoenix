using System.Drawing.Drawing2D;

namespace PasswordManager
{
    public partial class LoginPage : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _startPoint = new Point(0, 0);
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void LoginPage_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(143, 59, 7), 1);

            Rectangle area = new Rectangle(login_side.Location.X, login_side.Location.Y, login_side.Width - 1, login_side.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(143, 59, 7), Color.FromArgb(199, 150, 119), LinearGradientMode.Vertical);
            g.FillRectangle(lgb, area);
            g.DrawRectangle(pen, area);
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login button clicked.");
        }
    }
}