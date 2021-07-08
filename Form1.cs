using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AnıtArayüz
{
    public partial class Form1 : Form
    {
        int mov;
        int movX;
        int movY;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        
        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse
         );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLog.Height;
            pnlNav.Top = btnLog.Top;
            btnLog.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnParameters_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnParameters.Height;
            pnlNav.Top = btnParameters.Top;
            btnParameters.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnIO_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnIO.Height;
            pnlNav.Top = btnIO.Top;
            btnIO.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnLog_Leave(object sender, EventArgs e)
        {
            btnLog.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnParameters_Leave(object sender, EventArgs e)
        {
            btnParameters.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnIO_Leave(object sender, EventArgs e)
        {
            btnIO.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            btnHome.PerformClick();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
