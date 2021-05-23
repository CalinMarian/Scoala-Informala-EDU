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
        private System.Media.SoundPlayer mediaSoundPlayer = new System.Media.SoundPlayer();
        int x = 255, y = 1;
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


        private void btnRadioEvent(object sender, EventArgs e)
        {
            if (RadioBtnMusic.Checked)
            {
                mediaSoundPlayer.Stream = Properties.Resources.myMusic_wav;
                mediaSoundPlayer.PlayLooping();
            }
            else
                mediaSoundPlayer.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TextScrolling.SetBounds(x, y, 1, 1);
            x--;
            if (x<=1)
            {
                x = 250;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            TextScrolling.Text = "C# Programming - courses and quizzes";
            TextScrolling.Font = new Font("", 18, FontStyle.Bold);
            timer1.Interval = 1;
            timer1.Start();
        }
    }
}
