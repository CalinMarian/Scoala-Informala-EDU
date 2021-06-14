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
        readonly List<PageData> pageData = new()
        {
            new PageData()
            {
                MainImage = Properties.Resources.LearnPicture_Intro,
                MoreInfoLink = "https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/"
            },
            new PageData()
            {
                MainImage = Properties.Resources.LearnPicture_PrimitiveDataType,
                MoreInfoLink = "https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types"
            },
            new PageData()
            {
                MainImage = Properties.Resources.LearnPicture_Strings,
                MoreInfoLink = "https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/"
            },
            new PageData()
            {
                MainImage = Properties.Resources.LearnPicture_Methods,
                MoreInfoLink = "https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods"
            },
            new PageData()
            {
                MainImage = Properties.Resources.LearnPicture_Classes,
                MoreInfoLink = "https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/classes"
            },
            new PageData()
            {
                MainImage = Properties.Resources.LearnPicture_GenericCollections,
                MoreInfoLink = "https://docs.microsoft.com/en-us/dotnet/standard/collections/when-to-use-generic-collections"
            },
            new PageData()
            {
                MainImage = Properties.Resources.LearnPicture_OOP,
                MoreInfoLink = "https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop"
            },
        };

        int currentPage = 0;

        public Learn()
        {
            InitializeComponent();
        }

        private void LinkClickedEvent(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process process = new();
            process.StartInfo.FileName = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
            process.StartInfo.Arguments = pageData[currentPage].MoreInfoLink + " --new-window";
            process.Start();
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
        private void NextClickEvent(object sender, EventArgs e)
        {
            currentPage++;
            LoadPage();
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            currentPage--;
            LoadPage();
        }
    }
}

