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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void QuizClickEvent(object sender, EventArgs e)
        {
            Form frm = new Form3();
            frm.ShowDialog();
        }

        private void LearnClickEvent(object sender, EventArgs e)
        {
            Form frm = new Form2();
            frm.ShowDialog();
        }

        private void JobClickEvent(object sender, EventArgs e)
        {
            Form frm = new Form4();
            frm.ShowDialog();
        }

        private void AboutClickEvent(object sender, EventArgs e)
        {
            Form frm = new Form5();
            frm.ShowDialog();
        }

        private void QuitClickEvent(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
