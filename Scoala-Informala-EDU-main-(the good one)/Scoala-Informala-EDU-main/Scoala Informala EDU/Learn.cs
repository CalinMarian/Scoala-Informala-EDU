using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Scoala_Informala_EDU
{
    public partial class Learn : Form
    {

        //readonly List<LinkLabel> links = new
        //{
        //    https://www.google.ro/,
        //    https://www.microsoft.com/ro-ro,
        //    https://ro.yahoo.com/?p=us&guccounter=1
        //};
        



        public Learn()
        {
            InitializeComponent();
            InitialPage();

        }

        private void InitialPage()
        {
            btnPrev.Visible = false;
            pictureBoxLearn.Image = Properties.Resources.LearnPicture_Intro;
        }


        private void LinkClickedEvent(object sender, LinkLabelLinkClickedEventArgs e)
        {
           

        }

        private void NextClickEvent(object sender, EventArgs e)
        {

            pictureBoxLearn.Image = Properties.Resources.GetStarted;
            btnPrev.Visible = true;
        }
    }
}

