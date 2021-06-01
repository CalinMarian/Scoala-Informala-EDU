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
    public partial class Tips : Form
    {
        string greeting = " Hi and welcome to this section of the program! We hope you will find useful information here. ";

        public Tips()
        {
            InitializeComponent();
        }

        private void Greeting()
        {
           
        }

        private void Tips_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(greeting);
        }

        private void btnInterview_Click(object sender, EventArgs e)
        {
            MessageBox.Show(greeting);
        }

        private void btnIS_Click(object sender, EventArgs e)
        {
            MessageBox.Show(greeting);
        }
    }
}
