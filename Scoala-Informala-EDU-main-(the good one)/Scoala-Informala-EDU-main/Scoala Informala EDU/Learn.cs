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
        List<PageData> pageData = new List<PageData>() {
            new PageData(){
                MainImage = Properties.Resources.GetStarted,
                MoreInfoLink = "https://www.google.ro"
        },
            new PageData(){
                MainImage = Properties.Resources.hmm,
                MoreInfoLink = "yahoo.com"
        }
            };

        int currentPage = 0;

        public Learn()
        {
            InitializeComponent();

            List<LinkLabel> linkList = new List<LinkLabel>();

            //linkList.Add(new LinkLabel() { Lin})
            //linkList.Add(new LinkLabel((

            //linkLbl.Links.Add(new LinkLabel.Link( "https://www.google.ro/",,);




        }

        private void LinkClickedEvent(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(pageData[currentPage].MoreInfoLink);
        }

        private void NextClickEvent(object sender, EventArgs e)
        {
            currentPage++;
            LoadPage();
        }

        private void Learn_Load(object sender, EventArgs e)
        {
            LoadPage();
        }

        private void LoadPage()
        {
            pictureBoxLearn.Image = pageData[currentPage].MainImage;
            btnPrev.Visible = currentPage > 0;
            btnNext.Visible = currentPage < pageData.Count - 1;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            currentPage--;
            LoadPage();

        }
    }
}

