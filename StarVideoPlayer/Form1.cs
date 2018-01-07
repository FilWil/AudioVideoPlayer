using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StarVideoPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CloseApplication(Object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize(Object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ButtonExit_MouseClick(object sender, MouseEventArgs e)
        {
            CloseApplication(sender, e);
        }

        private void ButtonMaximize_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void ButtonMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            Minimize(sender, e);
        }


    }
}
