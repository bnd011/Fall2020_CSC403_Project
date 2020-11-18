namespace Fall2020_CSC403_Project
{
    partial class Sound_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.note = new System.Windows.Forms.RichTextBox();
            this.fire_cross2 = new System.Windows.Forms.PictureBox();
            this.fire_cross3 = new System.Windows.Forms.PictureBox();
            this.in_game_vol = new System.Windows.Forms.PictureBox();
            this.ON1 = new System.Windows.Forms.PictureBox();
            this.backbutton = new System.Windows.Forms.PictureBox();
            this.Sound = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fire_cross2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire_cross3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_game_vol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ON1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sound)).BeginInit();
            this.SuspendLayout();
            // 
            // note
            // 
            this.note.BackColor = System.Drawing.Color.Black;
            this.note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.note.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note.ForeColor = System.Drawing.Color.DarkGray;
            this.note.Location = new System.Drawing.Point(415, 612);
            this.note.Name = "note";
            this.note.ReadOnly = true;
            this.note.Size = new System.Drawing.Size(772, 217);
            this.note.TabIndex = 18;
            this.note.Text = "*NOTE: If you revisit the sound page, \nthe previous choice you picked is saved,\n " +
    "but button will always show \"ON\" \n(does not reset your previous option). ";
            // 
            // fire_cross2
            // 
            this.fire_cross2.Image = global::Fall2020_CSC403_Project.Properties.Resources.fire_crossbones;
            this.fire_cross2.Location = new System.Drawing.Point(40, 512);
            this.fire_cross2.Name = "fire_cross2";
            this.fire_cross2.Size = new System.Drawing.Size(314, 296);
            this.fire_cross2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fire_cross2.TabIndex = 17;
            this.fire_cross2.TabStop = false;
            // 
            // fire_cross3
            // 
            this.fire_cross3.Image = global::Fall2020_CSC403_Project.Properties.Resources.fire_crossbones;
            this.fire_cross3.Location = new System.Drawing.Point(1193, 512);
            this.fire_cross3.Name = "fire_cross3";
            this.fire_cross3.Size = new System.Drawing.Size(314, 296);
            this.fire_cross3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fire_cross3.TabIndex = 16;
            this.fire_cross3.TabStop = false;
            // 
            // in_game_vol
            // 
            this.in_game_vol.Image = global::Fall2020_CSC403_Project.Properties.Resources.IN_GAME_VOL;
            this.in_game_vol.Location = new System.Drawing.Point(267, 300);
            this.in_game_vol.Name = "in_game_vol";
            this.in_game_vol.Size = new System.Drawing.Size(468, 110);
            this.in_game_vol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.in_game_vol.TabIndex = 14;
            this.in_game_vol.TabStop = false;
            // 
            // ON1
            // 
            this.ON1.Image = global::Fall2020_CSC403_Project.Properties.Resources.ON;
            this.ON1.Location = new System.Drawing.Point(851, 300);
            this.ON1.Name = "ON1";
            this.ON1.Size = new System.Drawing.Size(253, 119);
            this.ON1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ON1.TabIndex = 13;
            this.ON1.TabStop = false;
            this.ON1.Click += new System.EventHandler(this.ON1_Click);
            // 
            // backbutton
            // 
            this.backbutton.Image = global::Fall2020_CSC403_Project.Properties.Resources.backbutton;
            this.backbutton.Location = new System.Drawing.Point(12, 12);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(111, 60);
            this.backbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backbutton.TabIndex = 12;
            this.backbutton.TabStop = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            this.backbutton.MouseLeave += new System.EventHandler(this.backbutton_MouseLeave);
            this.backbutton.MouseHover += new System.EventHandler(this.backbutton_MouseHover);
            // 
            // Sound
            // 
            this.Sound.Image = global::Fall2020_CSC403_Project.Properties.Resources.soundpage;
            this.Sound.Location = new System.Drawing.Point(152, 1);
            this.Sound.Name = "Sound";
            this.Sound.Size = new System.Drawing.Size(1154, 215);
            this.Sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Sound.TabIndex = 2;
            this.Sound.TabStop = false;
            // 
            // Sound_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1884, 953);
            this.Controls.Add(this.note);
            this.Controls.Add(this.fire_cross2);
            this.Controls.Add(this.fire_cross3);
            this.Controls.Add(this.in_game_vol);
            this.Controls.Add(this.ON1);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.Sound);
            this.Name = "Sound_Page";
            this.Text = "Sound ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sound_Page_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.fire_cross2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire_cross3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_game_vol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ON1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Sound;
        private System.Windows.Forms.PictureBox backbutton;
        private System.Windows.Forms.PictureBox ON1;
        private System.Windows.Forms.PictureBox in_game_vol;
        private System.Windows.Forms.PictureBox fire_cross3;
        private System.Windows.Forms.PictureBox fire_cross2;
        private System.Windows.Forms.RichTextBox note;
    }
}