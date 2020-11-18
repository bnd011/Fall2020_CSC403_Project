using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    partial class FrmLevel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevel));
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemyMove = new System.Windows.Forms.Timer(this.components);
            this.picEnemy1 = new System.Windows.Forms.PictureBox();
            this.picEnemy2 = new System.Windows.Forms.PictureBox();
            this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
            this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
            this.picBossKoolAid = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fog_upper = new System.Windows.Forms.PictureBox();
            this.fog_left = new System.Windows.Forms.PictureBox();
            this.fog_lower = new System.Windows.Forms.PictureBox();
            this.fog_right = new System.Windows.Forms.PictureBox();
            this.level1 = new System.Windows.Forms.PictureBox();
            this.level2 = new System.Windows.Forms.PictureBox();
            this.level3 = new System.Windows.Forms.PictureBox();
            this.level4 = new System.Windows.Forms.PictureBox();
            this.level5 = new System.Windows.Forms.PictureBox();
            this.level6 = new System.Windows.Forms.PictureBox();
            this.level7 = new System.Windows.Forms.PictureBox();
            this.level8 = new System.Windows.Forms.PictureBox();
            this.level9 = new System.Windows.Forms.PictureBox();
            this.level10 = new System.Windows.Forms.PictureBox();
            this.level11 = new System.Windows.Forms.PictureBox();
            this.level12 = new System.Windows.Forms.PictureBox();
            this.level13 = new System.Windows.Forms.PictureBox();
            this.level14 = new System.Windows.Forms.PictureBox();
            this.level15 = new System.Windows.Forms.PictureBox();
            this.level18 = new System.Windows.Forms.PictureBox();
            this.level17 = new System.Windows.Forms.PictureBox();
            this.level16 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fog_upper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fog_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fog_lower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fog_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level16)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInGameTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime.Location = new System.Drawing.Point(2, 2);
            this.lblInGameTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(48, 20);
            this.lblInGameTime.TabIndex = 2;
            this.lblInGameTime.Text = "label1";
            this.lblInGameTime.Click += new System.EventHandler(this.lblInGameTime_Click);
            // 
            // tmrUpdateInGameTime
            // 
            this.tmrUpdateInGameTime.Enabled = true;
            this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // tmrEnemyMove
            // 
            this.tmrEnemyMove.Enabled = true;
            this.tmrEnemyMove.Interval = 10;
            this.tmrEnemyMove.Tick += new System.EventHandler(this.tmrEnemyMove_Tick);
            // 
            // picEnemyCheeto
            // 
            this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyCheeto.Location = new System.Drawing.Point(425, 117);
            this.picEnemyCheeto.Margin = new System.Windows.Forms.Padding(2);
            this.picEnemyCheeto.Name = "picEnemyCheeto";
            this.picEnemyCheeto.Size = new System.Drawing.Size(48, 87);
            this.picEnemyCheeto.TabIndex = 5;
            this.picEnemyCheeto.TabStop = false;
            // 
            // picEnemyPoisonPacket
            // 
            this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket_fw;
            this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyPoisonPacket.Location = new System.Drawing.Point(239, 349);
            this.picEnemyPoisonPacket.Margin = new System.Windows.Forms.Padding(2);
            this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
            this.picEnemyPoisonPacket.Size = new System.Drawing.Size(47, 78);
            this.picEnemyPoisonPacket.TabIndex = 4;
            this.picEnemyPoisonPacket.TabStop = false;
            // 
            // picBossKoolAid
            // 
            this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
            this.picBossKoolAid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBossKoolAid.BackgroundImage")));
            this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossKoolAid.Location = new System.Drawing.Point(909, 307);
            this.picBossKoolAid.Margin = new System.Windows.Forms.Padding(2);
            this.picBossKoolAid.Name = "picBossKoolAid";
            this.picBossKoolAid.Size = new System.Drawing.Size(145, 158);
            this.picBossKoolAid.TabIndex = 1;
            this.picBossKoolAid.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPlayer.Location = new System.Drawing.Point(139, 285);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(30, 65);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            this.picPlayer.Click += new System.EventHandler(this.picPlayer_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Nice_Image_Of_Mr_Kool_Aid;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(1130, 665);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(72, 130);
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.koolaid;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(511, 452);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 106);
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket_fw;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(1130, 665);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 130);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.grape_packet;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(531, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 106);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.grape_packet;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1130, 665);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 130);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // fog_upper
            // 
            this.fog_upper.BackColor = System.Drawing.Color.Black;
            this.fog_upper.Location = new System.Drawing.Point(-569, -567);
            this.fog_upper.Name = "fog_upper";
            this.fog_upper.Size = new System.Drawing.Size(2346, 588);
            this.fog_upper.TabIndex = 18;
            this.fog_upper.TabStop = false;
            // 
            // fog_left
            // 
            this.fog_left.BackColor = System.Drawing.Color.Black;
            this.fog_left.Location = new System.Drawing.Point(70, 711);
            this.fog_left.Name = "fog_left";
            this.fog_left.Size = new System.Drawing.Size(1034, 294);
            this.fog_left.TabIndex = 20;
            this.fog_left.TabStop = false;
            // 
            // fog_lower
            // 
            this.fog_lower.BackColor = System.Drawing.Color.Black;
            this.fog_lower.Location = new System.Drawing.Point(-433, 711);
            this.fog_lower.Name = "fog_lower";
            this.fog_lower.Size = new System.Drawing.Size(2346, 533);
            this.fog_lower.TabIndex = 19;
            this.fog_lower.TabStop = false;
            // 
            // fog_right
            // 
            this.fog_right.BackColor = System.Drawing.Color.Black;
            this.fog_right.Location = new System.Drawing.Point(1160, 229);
            this.fog_right.Name = "fog_right";
            this.fog_right.Size = new System.Drawing.Size(1014, 294);
            this.fog_right.TabIndex = 21;
            this.fog_right.TabStop = false;
            // 
            // level1
            // 
            this.level1.BackColor = System.Drawing.Color.Transparent;
            this.level1.Location = new System.Drawing.Point(95, -65);
            this.level1.Margin = new System.Windows.Forms.Padding(2);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(891, 87);
            this.level1.TabIndex = 22;
            this.level1.TabStop = false;
            // 
            // level2
            // 
            this.level2.BackColor = System.Drawing.Color.Transparent;
            this.level2.Location = new System.Drawing.Point(95, 682);
            this.level2.Margin = new System.Windows.Forms.Padding(2);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(891, 89);
            this.level2.TabIndex = 23;
            this.level2.TabStop = false;
            // 
            // level3
            // 
            this.level3.BackColor = System.Drawing.Color.Transparent;
            this.level3.Location = new System.Drawing.Point(-4, 10);
            this.level3.Margin = new System.Windows.Forms.Padding(2);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(80, 570);
            this.level3.TabIndex = 24;
            this.level3.TabStop = false;
            // 
            // level4
            // 
            this.level4.BackColor = System.Drawing.Color.Transparent;
            this.level4.Location = new System.Drawing.Point(1085, 80);
            this.level4.Margin = new System.Windows.Forms.Padding(2);
            this.level4.Name = "level4";
            this.level4.Size = new System.Drawing.Size(80, 554);
            this.level4.TabIndex = 25;
            this.level4.TabStop = false;
            // 
            // level5
            // 
            this.level5.BackColor = System.Drawing.Color.Transparent;
            this.level5.Location = new System.Drawing.Point(337, 441);
            this.level5.Margin = new System.Windows.Forms.Padding(2);
            this.level5.Name = "level5";
            this.level5.Size = new System.Drawing.Size(57, 193);
            this.level5.TabIndex = 26;
            this.level5.TabStop = false;
            this.level5.Click += new System.EventHandler(this.level5_Click);
            // 
            // level6
            // 
            this.level6.BackColor = System.Drawing.Color.Transparent;
            this.level6.Location = new System.Drawing.Point(353, 338);
            this.level6.Margin = new System.Windows.Forms.Padding(2);
            this.level6.Name = "level6";
            this.level6.Size = new System.Drawing.Size(169, 62);
            this.level6.TabIndex = 27;
            this.level6.TabStop = false;
            // 
            // level7
            // 
            this.level7.BackColor = System.Drawing.Color.Transparent;
            this.level7.Location = new System.Drawing.Point(641, 137);
            this.level7.Margin = new System.Windows.Forms.Padding(2);
            this.level7.Name = "level7";
            this.level7.Size = new System.Drawing.Size(56, 368);
            this.level7.TabIndex = 28;
            this.level7.TabStop = false;
            // 
            // level8
            // 
            this.level8.BackColor = System.Drawing.Color.Transparent;
            this.level8.Location = new System.Drawing.Point(641, 272);
            this.level8.Margin = new System.Windows.Forms.Padding(2);
            this.level8.Name = "level8";
            this.level8.Size = new System.Drawing.Size(56, 67);
            this.level8.TabIndex = 29;
            this.level8.TabStop = false;
            this.level8.Click += new System.EventHandler(this.level8_Click);
            // 
            // level9
            // 
            this.level9.BackColor = System.Drawing.Color.Transparent;
            this.level9.Location = new System.Drawing.Point(25, 584);
            this.level9.Margin = new System.Windows.Forms.Padding(2);
            this.level9.Name = "level9";
            this.level9.Size = new System.Drawing.Size(65, 72);
            this.level9.TabIndex = 30;
            this.level9.TabStop = false;
            // 
            // level10
            // 
            this.level10.BackColor = System.Drawing.Color.Transparent;
            this.level10.Location = new System.Drawing.Point(110, 479);
            this.level10.Margin = new System.Windows.Forms.Padding(2);
            this.level10.Name = "level10";
            this.level10.Size = new System.Drawing.Size(57, 57);
            this.level10.TabIndex = 31;
            this.level10.TabStop = false;
            // 
            // level11
            // 
            this.level11.BackColor = System.Drawing.Color.Transparent;
            this.level11.Location = new System.Drawing.Point(641, 39);
            this.level11.Margin = new System.Windows.Forms.Padding(2);
            this.level11.Name = "level11";
            this.level11.Size = new System.Drawing.Size(281, 62);
            this.level11.TabIndex = 32;
            this.level11.TabStop = false;
            // 
            // level12
            // 
            this.level12.BackColor = System.Drawing.Color.Transparent;
            this.level12.Location = new System.Drawing.Point(902, 82);
            this.level12.Margin = new System.Windows.Forms.Padding(2);
            this.level12.Name = "level12";
            this.level12.Size = new System.Drawing.Size(65, 78);
            this.level12.TabIndex = 33;
            this.level12.TabStop = false;
            // 
            // level13
            // 
            this.level13.BackColor = System.Drawing.Color.Transparent;
            this.level13.Location = new System.Drawing.Point(1026, 512);
            this.level13.Margin = new System.Windows.Forms.Padding(2);
            this.level13.Name = "level13";
            this.level13.Size = new System.Drawing.Size(65, 93);
            this.level13.TabIndex = 34;
            this.level13.TabStop = false;
            // 
            // level14
            // 
            this.level14.BackColor = System.Drawing.Color.Transparent;
            this.level14.Location = new System.Drawing.Point(131, 552);
            this.level14.Margin = new System.Windows.Forms.Padding(2);
            this.level14.Name = "level14";
            this.level14.Size = new System.Drawing.Size(112, 63);
            this.level14.TabIndex = 35;
            this.level14.TabStop = false;
            // 
            // level15
            // 
            this.level15.BackColor = System.Drawing.Color.Transparent;
            this.level15.Location = new System.Drawing.Point(181, 72);
            this.level15.Margin = new System.Windows.Forms.Padding(2);
            this.level15.Name = "level15";
            this.level15.Size = new System.Drawing.Size(170, 61);
            this.level15.TabIndex = 36;
            this.level15.TabStop = false;
            // 
            // level18
            // 
            this.level18.BackColor = System.Drawing.Color.Transparent;
            this.level18.Location = new System.Drawing.Point(681, 131);
            this.level18.Margin = new System.Windows.Forms.Padding(2);
            this.level18.Name = "level18";
            this.level18.Size = new System.Drawing.Size(56, 73);
            this.level18.TabIndex = 37;
            this.level18.TabStop = false;
            // 
            // level17
            // 
            this.level17.BackColor = System.Drawing.Color.Transparent;
            this.level17.Location = new System.Drawing.Point(867, 584);
            this.level17.Margin = new System.Windows.Forms.Padding(2);
            this.level17.Name = "level17";
            this.level17.Size = new System.Drawing.Size(184, 63);
            this.level17.TabIndex = 38;
            this.level17.TabStop = false;
            // 
            // level16
            // 
            this.level16.BackColor = System.Drawing.Color.Transparent;
            this.level16.Location = new System.Drawing.Point(65, 106);
            this.level16.Margin = new System.Windows.Forms.Padding(2);
            this.level16.Name = "level16";
            this.level16.Size = new System.Drawing.Size(62, 73);
            this.level16.TabIndex = 39;
            this.level16.TabStop = false;
            // 
            // FrmLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.layout4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 726);
            this.Controls.Add(this.fog_right);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.fog_left);
            this.Controls.Add(this.fog_lower);
            this.Controls.Add(this.fog_upper);
            this.Controls.Add(this.level16);
            this.Controls.Add(this.level17);
            this.Controls.Add(this.level18);
            this.Controls.Add(this.level15);
            this.Controls.Add(this.level14);
            this.Controls.Add(this.level13);
            this.Controls.Add(this.level12);
            this.Controls.Add(this.level11);
            this.Controls.Add(this.level10);
            this.Controls.Add(this.level9);
            this.Controls.Add(this.level8);
            this.Controls.Add(this.level7);
            this.Controls.Add(this.level6);
            this.Controls.Add(this.level5);
            this.Controls.Add(this.level4);
            this.Controls.Add(this.level3);
            this.Controls.Add(this.level2);
            this.Controls.Add(this.level1);
            this.Controls.Add(this.picEnemyCheeto);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picEnemyPoisonPacket);
            this.Controls.Add(this.picBossKoolAid);
            this.Controls.Add(this.picPlayer);
            this.DoubleBuffered = true;
            this.Name = "FrmLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLevel_FormClosing);
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fog_upper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fog_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fog_lower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fog_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void level8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void level5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void picPlayer_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picBossKoolAid;
        private System.Windows.Forms.PictureBox picEnemy1;
        private System.Windows.Forms.PictureBox picEnemy2;
        private System.Windows.Forms.Label lblInGameTime;
        private System.Windows.Forms.Timer tmrUpdateInGameTime;
        private System.Windows.Forms.Timer tmrPlayerMove;
        private System.Windows.Forms.Timer tmrEnemyMove;
        private System.Windows.Forms.PictureBox picEnemyPoisonPacket;
        private System.Windows.Forms.PictureBox picEnemyCheeto;
        private System.Windows.Forms.PictureBox fog_upper;
        private System.Windows.Forms.PictureBox fog_left;
        private System.Windows.Forms.PictureBox fog_lower;
        private System.Windows.Forms.PictureBox fog_right;
        private System.Windows.Forms.PictureBox level1;
        private System.Windows.Forms.PictureBox level2;
        private System.Windows.Forms.PictureBox level3;
        private System.Windows.Forms.PictureBox level4;
        private System.Windows.Forms.PictureBox level5;
        private System.Windows.Forms.PictureBox level6;
        private System.Windows.Forms.PictureBox level7;
        private System.Windows.Forms.PictureBox level8;
        private System.Windows.Forms.PictureBox level9;
        private System.Windows.Forms.PictureBox level10;
        private System.Windows.Forms.PictureBox level11;
        private System.Windows.Forms.PictureBox level12;
        private System.Windows.Forms.PictureBox level13;
        private System.Windows.Forms.PictureBox level14;
        private System.Windows.Forms.PictureBox level15;
        private System.Windows.Forms.PictureBox level18;
        private System.Windows.Forms.PictureBox level17;
        private System.Windows.Forms.PictureBox level16;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

