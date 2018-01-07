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
using Microsoft.DirectX.AudioVideoPlayback;

namespace StarVideoPlayer
{
    public partial class Form1 : Form
    {
        private Video video;
        private string[] videoPaths;
        private string folderPath = @"C:\vidia\";
        private int selectedIndex = 0;
        private Size formSize;
        private Size pnlSize;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formSize = new Size(this.Width, this.Height);
            pnlSize = new Size(playerPanel.Width, playerPanel.Height);

            videoPaths = Directory.GetFiles(folderPath, "*.wmv");

            if (videoPaths != null)
            {
                foreach (string path in videoPaths)
                {
                    Console.WriteLine(path);
                }
            }
        }

        private void CloseApplication(Object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize(Object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            CloseApplication(sender, e);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            Minimize(sender, e);
        }

        private void fastForwardButton_Click(object sender, EventArgs e)
        {
            NextVideo();
        }


        private void rewindButton_Click(object sender, EventArgs e)
        {
            PreviousVideo();
        }

        private void NextVideo()
        {
            int index = selectedIndex;
            index++;
            if (index > videoPaths.Length - 1) index = 0;
            selectedIndex = index;
            VideoPlayer();
        }

        private void PreviousVideo()
        {
            int index = selectedIndex;
            index--;
            if (index == -1) index = videoPaths.Length - 1;
            selectedIndex = index;
            VideoPlayer();
        }

        private void VideoPlayer()
        {
            try
            {
                video.Stop();
                video.Dispose();
            }
            catch { }

            video = new Video(videoPaths[selectedIndex], false);
            video.Owner = playerPanel;
            playerPanel.Size = pnlSize;
            video.Play();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            VideoPlayer();
        }
    }
}
