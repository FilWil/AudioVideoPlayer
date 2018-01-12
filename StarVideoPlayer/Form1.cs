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
using System.Diagnostics;

namespace StarVideoPlayer
{
    public partial class Form1 : Form
    {
        //ZMIENNE GLOBALNE
        bool moveFlag = false;                                      //flaga, która sprawdza czy wciśnięto za pomocą myszki panel do przenoszenia okna
        int mousePositionX, mousePositionY;                         //koordynaty myszki
        bool panelMaximized = false;                                //flaga sprawdzająca czy okno zostało zmaksymalizowane

        private Video video;                                        //prywatna zmienna pobierająca aktualnie wybrane video
        private Audio audio;                                        //prywatna zmienna pobierająca aktualnie wybrane audio

        //private List<Tuple<Video, Audio>> filesPaths = new List<Tuple<Video, Audio>>();
        private List<Object> mediaFile = new List<Object>();
        //private Object multimediaFile;
        //private List<Object> filesPaths = new List<Object>();

        private int selectedIndex = 0;
       //CO TO W OGOLE JEST PREVIOUS INDEX XDDDDDDD i na co to komu
        private Size formSize;
        private Size pnlSize;
        
        public Form1() { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e)
        {
            formSize = new Size(this.Width, this.Height);
            pnlSize = new Size(playerPanel.Width, playerPanel.Height);
        }

        //PRZYCISK ZAMYKANIA - CLOSE APPLICATION
        private void ExitButton_Click(object sender, EventArgs e)
        {
            CloseApplication(sender, e);
        }

        //ZAMYKANIE APLIKACJI
        private void CloseApplication(Object sender, EventArgs e) { Application.Exit(); }


        //PRZYCISK MINIMALIZACJI
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            Minimize(sender, e);
        }

        //MINIMALIZOWANIE OKNA
        private void Minimize(Object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }


        //PRZYCISK NASTĘPNEGO ITEMU
        private void FastForwardButton_Click(object sender, EventArgs e)
        {
            NextItem();
        }

        //PRZYCISK POPRZEDNIEGO ITEMU
        private void RewindButton_Click(object sender, EventArgs e)
        {
            PreviousVideo();
        }

        //REAKCJA NA PRZYCISK NASTĘPNEGO ITEMU
        private void NextItem()
        {
            DiscardFile(mediaFile[selectedIndex]);
            if (mediaFile.Count > 0 && selectedIndex < mediaFile.Count - 1)
            {
                selectedIndex++;
                Player(mediaFile[selectedIndex]);
            }

            if (panelMaximized)
            {
                playerPanel.Size = new Size(Width, Height);
            }
            else
            {
                playerPanel.Size = new Size(819, 610);
            }
        }

        //REAKCJA NA PRZYCISK POPRZEDNIEGO ITEMU
        private void PreviousVideo()
        {
            DiscardFile(mediaFile[selectedIndex]);
            if (mediaFile.Count > 0 && selectedIndex != 0)
            {
                selectedIndex--;
                Player(mediaFile[selectedIndex]);
            }
            
            if (panelMaximized)
            {
                playerPanel.Size = new Size(Width, Height);
            }
            else
            {
                playerPanel.Size = new Size(819, 610);
            }
        }

        //public delegate void DiscardedFileEventHandler(object o, EventArgs e); //Delegat do funkcji DiscardFile() 
        //public DiscardedFileEventHandler DiscardedFile;

        //protected virtual void OnDiscardedVideo(Object fileProvided)
        //{
        //    DiscardedFile?.Invoke(this, EventArgs.Empty);
        //}

        private void DiscardFile(Object fileProvided)
        {
            try
            {
                if (fileProvided.GetType() == typeof(Video))
                {
                    video = (Video)fileProvided;
                    video.Stop();
                    Panel panel = new Panel();
                    video.Owner = panel;
                }
                else if (fileProvided.GetType() == typeof(Audio))
                {
                    audio = (Audio)fileProvided;
                    audio.Stop();
                }
            }
            catch { }
        }
        private void StopPlaying(Object fileProvided)
        {
            if(fileProvided.GetType() == typeof(Video))
            {
                if (!video.Playing)
                {
                    video.Play();
                }
                else if (video.Playing)
                {
                    video.Pause();
                }
            }
            else if(fileProvided.GetType() == typeof(Audio))
            {
                if (!audio.Playing)
                {
                    audio.Play();
                }
                else if (audio.Playing)
                {
                    audio.Pause();
                }
            }
        }

        private void Player(Object fileProvided)
        {
                if (mediaFile != null)
                {
                    if (fileProvided.GetType() == typeof(Video))
                    {
                        video = (Video)fileProvided;
                        video.Owner = playerPanel;
                        playerPanel.Size = pnlSize;
                        video.Ending += Ending_Actions;
                        video.Play();
                    }
                    else if (fileProvided.GetType() == typeof(Audio))
                    {
                        audio = (Audio)fileProvided;
                        audio.Ending += Ending_Actions;
                        audio.Play();
                    }
                }

        }
        //PO ZAKOŃCZENIU ODTWARZANIA
        private void Ending_Actions(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(1000);

                if (InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        NextItem();
                    }));
                }
            });
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if(mediaFile.Count != 0) Player(mediaFile[selectedIndex]);
        }

        private void FilesDialogButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Video files (*.avi, *.flv, *.wmv, *.divX, *.xvid, *.mpeg, *.mpg)|*.avi;*.flv;*.wmv;*.divX;*.xvid;*.mpeg;*.mpg|Audio files (*.wav)|*.wav",
                Multiselect = true,
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofd.FileNames)
                {
                    try
                    {
                        if (ofd.FilterIndex == 1) //dla plików video
                        {
                            mediaFile.Add(new Video(file, false));
                        }
                        else //dla plików audio
                        {
                            mediaFile.Add(new Audio(file, false));
                        }
                    }
                    catch { }
                    finally
                    {

                    }
                }
            }
        }

        //Przycisk stop - pauza i kontynuowanie filmu po porzednim zatrzymaniu
        private void StopButton_Click(object sender, EventArgs e)
        {
           if(mediaFile.Count != 0) StopPlaying(mediaFile[selectedIndex]);
        }

        private void VolumeControl_Scroll(object sender, EventArgs e)
        {
            if (video.Playing && (video != null)) video.Audio.Volume = volumeControl.Value; //Audio.Volume jest z zakresu (-10000, 0), gdzie 0 to maksymalna głośność - im mniejsza wartość tym bardziej jest wyciszone
            else if (audio.Playing && (audio != null)) audio.Volume = volumeControl.Value;
            else volumeControl.Value = -1500;
        }


        private void ControlFileProgress(Object fileProvided)
        {
            if (fileProvided.GetType() == typeof(Video))
            {
                videoProgressControl.Maximum = Convert.ToInt32(video.Duration); //ustawia maksymalną wartość paska na długość filmu
                video.CurrentPosition = videoProgressControl.Value; //sterowanie czasem filmu za pomocą suwaka
            }
            else if (fileProvided.GetType() == typeof(Audio))
            {
                videoProgressControl.Maximum = Convert.ToInt32(audio.Duration); //ustawia maksymalną wartość paska na długość filmu
                audio.CurrentPosition = videoProgressControl.Value; //sterowanie czasem filmu za pomocą suwaka
            }
        }

        //Funkcja, która pozwala przewijać aktualnie odtwarzany plik w czasie za pomocą suwaka
        private void VideoProgressControl_Scroll(object sender, EventArgs e)
        {
            if (mediaFile.Count != 0) ControlFileProgress(mediaFile[selectedIndex]);

        }

        private void UpdateLabelsText(Object fileProvided)
        {
            if (fileProvided.GetType() == typeof(Video))
            {
                //if (!timer.Enabled) timer.Enabled = true;
                fileDurationLabel.Text = Convert.ToInt32(video.Duration).ToString(); //pokazuje obecny czas, w którym znajduje się film na labelu
                fileCurrentPositionLabel.Text = Convert.ToInt32(video.CurrentPosition).ToString(); //pokazuje długość trwania filmu w labelu
            }
            else if (fileProvided.GetType() == typeof(Audio))
            {
                //if (!timer.Enabled) timer.Enabled = true;
                fileDurationLabel.Text = Convert.ToInt32(audio.Duration).ToString(); //pokazuje obecny czas, w którym znajduje się film na labelu
                fileCurrentPositionLabel.Text = Convert.ToInt32(audio.CurrentPosition).ToString(); //pokazuje długość trwania filmu w labelu
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //if (mediaFile.Count != 0) UpdateLabelsText(mediaFile[selectedIndex]);
        }


        /// <summary>
        /// RESZTA PONIŻEJ (COŚ, CO NIE WYMAGA PLAYERA ANI INTERACKJI Z NIM)
        /// </summary>



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
                playerPanel.Size = new Size(819, 610); //panel wraca do pierwotnych rozmiarów
            }
        }

        //Jeśli myszka najedzie na przycisk z dźwiękiem to pojawi się suwak głośności
        private void VolumeButton_MouseHover(object sender, EventArgs e)
        {
            volumeControl.Visible = true;
        }

        //Jeśli myszka opuści suwak z dźwiękiem, to zniknie
        private void VolumeControl_MouseLeave(object sender, EventArgs e)
        {
            volumeControl.Visible = false;
        }

        private void HeadPanel_MouseUp(object sender, MouseEventArgs e)
        {
            moveFlag = false; //jeśli oderwano myszkę od panela, to flaga ustawia się na false
        }
    }
}
