using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Fall2020_CSC403_Project
{   // will be displayed after sound button is clicked
    public partial class Sound_Page : Form
    {
        public static string igvolcontrol = "ON"; // will be used for changing of sound button
        public Sound_Page()
        {
            InitializeComponent();
           
            
        }

        private void Sound_Page_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ON1_Click(object sender, EventArgs e)
        {
            if (igvolcontrol.Equals("ON"))
            {
                igvolcontrol = "OFF"; // turn sound "off" in FrmBattle boss sequence
                ON1.Image = Properties.Resources.OFF; // change picture from on to off
            }

            else if (igvolcontrol.Equals("OFF"))
            {
                igvolcontrol = "ON";  // turn sound "on" in FrmBattle boss sequence
                ON1.Image = Properties.Resources.ON; // change picture from off to on

            }
        }
    }
}
