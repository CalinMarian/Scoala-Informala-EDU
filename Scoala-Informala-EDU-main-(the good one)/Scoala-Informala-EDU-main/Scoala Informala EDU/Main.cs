using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scoala_Informala_EDU
{
    public partial class Main : Form
    {
        private readonly System.Media.SoundPlayer mediaSoundPlayer = new();
        private int x = 1000;
        private readonly int y = 1;

        public Main()
        {
            InitializeComponent();
        }

        private void QuizClickEvent(object sender, EventArgs e)
        {
            Form frm = new Quiz();
            frm.ShowDialog();
        }

        private void LearnClickEvent(object sender, EventArgs e)
        {
            Form frm = new Learn();
            frm.ShowDialog();
        }

        private void JobClickEvent(object sender, EventArgs e)
        {
            Form frm = new Job();
            frm.ShowDialog();
        }

        private void AboutClickEvent(object sender, EventArgs e)
        {
            Form frm = new About();
            frm.ShowDialog();
        }

        private void QuitClickEvent(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SoundOnEvent(object sender, EventArgs e)
        {
            btnSoundOFF.Visible = true;
            btnSoundON.Visible = false;
            mediaSoundPlayer.Stop();
        }

        private void SoundOffEvent(object sender, EventArgs e)
        {
            btnSoundON.Visible = true;
            btnSoundOFF.Visible = false;
            mediaSoundPlayer.Stream = Properties.Resources.myMusic_wav;
            mediaSoundPlayer.PlayLooping();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            TextScrolling.Text = "C# Programming - courses and quizzes";
            TextScrolling.Font = new Font("", 18, FontStyle.Bold);
            timer.Interval = 1;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TextScrolling.SetBounds(x, y, 1, 1);
            x--;
            if (x <= -400)
            {
                x = 1000;
            }
        }

    }
}
