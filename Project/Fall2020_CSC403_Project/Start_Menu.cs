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
{
    // Form will be used as start menu before going in to game
    public partial class Start_Menu : Form
    {
        System.Media.SoundPlayer for_exit;   // used for exit button  
        Sound_Page sound = new Sound_Page();
        public Start_Menu()
        {
            
            InitializeComponent();
            
        }

        

        private void start_button_MouseHover(object sender, EventArgs e)
        {
            start_button.Image = Properties.Resources.startgamehover;
            System.Media.SoundPlayer hover_sound = new System.Media.SoundPlayer(Properties.Resources.sreload);
            hover_sound.Play();
        }

        private void start_button_MouseLeave(object sender, EventArgs e)
        {
            start_button.Image = Properties.Resources.startgame;
            
        }

        private void start_button_Click(object sender, EventArgs e)
        { 
            FrmLevel start_level = new FrmLevel();
            System.Media.SoundPlayer click_sound = new System.Media.SoundPlayer(Properties.Resources.shotgun);
            click_sound.Play();
            Thread.Sleep(3000); // wait 3 seconds before entering game
            this.Hide();
            start_level.Show();
            

        }
        // All of the ...Form_Closing() functions are needed to close application once red x in upper right
        // is clicked. If we did not have them, there would be running processes from previous still open when
        // you open up the program again, which in that case the program would not run. 
        private void Start_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        // For each button in start menu, there is a sound effect that plays. 
        private void tutorial_button_MouseHover(object sender, EventArgs e)
        {
            tutorial_button.Image = Properties.Resources.tutorialhover;
            System.Media.SoundPlayer hover_sound = new System.Media.SoundPlayer(Properties.Resources.drawsword);
            hover_sound.Play();
        }

        private void tutorial_button_MouseLeave(object sender, EventArgs e)
        {
            tutorial_button.Image = Properties.Resources.tutorial;
        }

        private void sound_button_MouseHover(object sender, EventArgs e)
        {
            sound_button.Image = Properties.Resources.soundhover;
            System.Media.SoundPlayer hover_sound = new System.Media.SoundPlayer(Properties.Resources.grenade);
            hover_sound.Play(); 
            
        }

        private void sound_button_MouseLeave(object sender, EventArgs e)
        {
            sound_button.Image = Properties.Resources.sound;
            

        }

        private void exit_button_MouseHover(object sender, EventArgs e)
        {
            exit_button.Image = Properties.Resources.exitgamehover;
            for_exit = new System.Media.SoundPlayer(Properties.Resources.helicopter);
            for_exit.PlayLooping();


        }

        private void exit_button_MouseLeave(object sender, EventArgs e)
        {
            exit_button.Image = Properties.Resources.exitgame;
            for_exit.Stop();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click_sound = new System.Media.SoundPlayer(Properties.Resources.helileaving);
            click_sound.Play();
            Thread.Sleep(5000); // wait 5 seconds before exiting application
            Application.Exit();
        }

        private void tutorial_button_Click(object sender, EventArgs e)
        {
            Tutorial_Page tutorial = new Tutorial_Page();
            this.Hide();
            tutorial.Show();
        }

        private void sound_button_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            sound.Show();
        }
    }
}
