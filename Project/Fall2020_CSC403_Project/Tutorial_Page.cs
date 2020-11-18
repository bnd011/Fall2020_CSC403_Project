using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{// will be displayed after tutorial button is clicked
    public partial class Tutorial_Page : Form
    {
        public Tutorial_Page()
        {
            InitializeComponent();
            
        }

        private void Tutorial_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Start_Menu start = new Start_Menu();
            this.Hide();
            start.Show();

        }

        private void backbutton_MouseHover(object sender, EventArgs e)
        {
            backbutton.Image = Properties.Resources.backbuttonhovering;
        }

        private void backbutton_MouseLeave(object sender, EventArgs e)
        {
            backbutton.Image = Properties.Resources.backbutton;
        }
    }
}
