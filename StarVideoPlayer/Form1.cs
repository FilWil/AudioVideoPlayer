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
        bool moveFlag = false; //flaga, która sprawdza czy wciśnięto za pomocą myszki panel do przenoszenia okna
        int mousePositionX, mousePositionY; //koordynaty myszki
        bool panelMaximized = false; //flaga sprawdzająca czy okno zostało zmaksymalizowane

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

        private void FastForwardButton_Click(object sender, EventArgs e)
        {
            NextVideo();
        }


        private void RewindButton_Click(object sender, EventArgs e)
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

            video = new Video(videoPaths[selectedIndex], false)
            {
                Owner = playerPanel
            };
            playerPanel.Size = pnlSize;
            video.Play();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            VideoPlayer();
        }

        private void HeadPanel_MouseDown(object sender, MouseEventArgs e)
        {
            moveFlag = true; //jeśli naciśnięto za pomocą myszki na panel, to flaga ustawia się na true
            //ustawia koordynaty myszki na obecne jej położenie
            mousePositionX = Cursor.Position.X - Left;
            mousePositionY = Cursor.Position.Y - Top;
        }

        private void HeadPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(moveFlag) 
            {
                Top = Cursor.Position.Y - mousePositionY;
                Left = Cursor.Position.X - mousePositionX;
            }
            Cursor = Cursors.Default;
        }

        private void PlayerPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MaximizeWindowSize();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            MaximizeWindowSize();
        }

        private void MaximizeWindowSize()
        {
            //logika, która pozwala maksymalizowac okno, jeśli jest niezmaksymalizowane oraz wracać do wyjściowego stanu, jeśli było zmaksymalizowane
            //po dwukrotnym wciśnięciu myszy
            if (panelMaximized == false)
            {
                panelMaximized = true;
            }
            else
            {
                panelMaximized = false;
            }

            if (panelMaximized)
            {
                WindowState = FormWindowState.Maximized; //maksymalizuje całe okno
                playerPanel.Size = new Size(Width, Height); //ustawia panel na maksymalny mozliwy rozmiar w oknie
            }
            else
            {
                WindowState = FormWindowState.Normal; //okno wraca do początkowych rozmiarów
            }
        }

        private void HeadPanel_MouseUp(object sender, MouseEventArgs e)
        {
            moveFlag = false; //jeśli oderwano myszkę od panela, to flaga ustawia się na false
        }

        
    }
}
