using System.Drawing;

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
            this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
            this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
            this.picBossKoolAid = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
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
            this.lblInGameTime.Location = new System.Drawing.Point(3, 3);
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
            // picEnemyCheeto
            // 
            this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyCheeto.Location = new System.Drawing.Point(528, 131);
            this.picEnemyCheeto.Name = "picEnemyCheeto";
            this.picEnemyCheeto.Size = new System.Drawing.Size(64, 107);
            this.picEnemyCheeto.TabIndex = 5;
            this.picEnemyCheeto.TabStop = false;
            // 
            // picEnemyPoisonPacket
            // 
            this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyPoisonPacket.Location = new System.Drawing.Point(431, 425);
            this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
            this.picEnemyPoisonPacket.Size = new System.Drawing.Size(63, 96);
            this.picEnemyPoisonPacket.TabIndex = 4;
            this.picEnemyPoisonPacket.TabStop = false;
            // 
            // picBossKoolAid
            // 
            this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
            this.picBossKoolAid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBossKoolAid.BackgroundImage")));
            this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossKoolAid.Location = new System.Drawing.Point(794, 266);
            this.picBossKoolAid.Name = "picBossKoolAid";
            this.picBossKoolAid.Size = new System.Drawing.Size(193, 194);
            this.picBossKoolAid.TabIndex = 1;
            this.picBossKoolAid.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPlayer.Location = new System.Drawing.Point(146, 337);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(30, 65);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            this.picPlayer.Click += new System.EventHandler(this.picPlayer_Click);
            // 
            // fog_upper
            // 
            this.fog_upper.BackColor = System.Drawing.Color.Black;
            this.fog_upper.Location = new System.Drawing.Point(-34, -556);
            this.fog_upper.Name = "fog_upper";
            this.fog_upper.Size = new System.Drawing.Size(2346, 575);
            this.fog_upper.TabIndex = 18;
            this.fog_upper.TabStop = false;
            // 
            // fog_left
            // 
            this.fog_left.BackColor = System.Drawing.Color.Black;
            this.fog_left.Location = new System.Drawing.Point(15, 710);
            this.fog_left.Name = "fog_left";
            this.fog_left.Size = new System.Drawing.Size(1032, 294);
            this.fog_left.TabIndex = 20;
            this.fog_left.TabStop = false;
            // 
            // fog_lower
            // 
            this.fog_lower.BackColor = System.Drawing.Color.Black;
            this.fog_lower.Location = new System.Drawing.Point(-467, 713);
            this.fog_lower.Name = "fog_lower";
            this.fog_lower.Size = new System.Drawing.Size(2346, 565);
            this.fog_lower.TabIndex = 19;
            this.fog_lower.TabStop = false;
            // 
            // fog_right
            // 
            this.fog_right.BackColor = System.Drawing.Color.Black;
            this.fog_right.Location = new System.Drawing.Point(17, -276);
            this.fog_right.Name = "fog_right";
            this.fog_right.Size = new System.Drawing.Size(1066, 294);
            this.fog_right.TabIndex = 21;
            this.fog_right.TabStop = false;
            // 
            // level1
            // 
            this.level1.BackColor = System.Drawing.Color.Transparent;
            this.level1.Location = new System.Drawing.Point(-7, -6);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(1188, 107);
            this.level1.TabIndex = 22;
            this.level1.TabStop = false;
            // 
            // level2
            // 
            this.level2.BackColor = System.Drawing.Color.Transparent;
            this.level2.Location = new System.Drawing.Point(-7, 626);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(1188, 109);
            this.level2.TabIndex = 23;
            this.level2.TabStop = false;
            // 
            // level3
            // 
            this.level3.BackColor = System.Drawing.Color.Transparent;
            this.level3.Location = new System.Drawing.Point(-6, 12);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(107, 702);
            this.level3.TabIndex = 24;
            this.level3.TabStop = false;
            // 
            // level4
            // 
            this.level4.BackColor = System.Drawing.Color.Transparent;
            this.level4.Location = new System.Drawing.Point(1077, 32);
            this.level4.Name = "level4";
            this.level4.Size = new System.Drawing.Size(107, 682);
            this.level4.TabIndex = 25;
            this.level4.TabStop = false;
            // 
            // level5
            // 
            this.level5.BackColor = System.Drawing.Color.Transparent;
            this.level5.Location = new System.Drawing.Point(326, 392);
            this.level5.Name = "level5";
            this.level5.Size = new System.Drawing.Size(76, 238);
            this.level5.TabIndex = 26;
            this.level5.TabStop = false;
            this.level5.Click += new System.EventHandler(this.level5_Click);
            // 
            // level6
            // 
            this.level6.BackColor = System.Drawing.Color.Transparent;
            this.level6.Location = new System.Drawing.Point(326, 326);
            this.level6.Name = "level6";
            this.level6.Size = new System.Drawing.Size(225, 76);
            this.level6.TabIndex = 27;
            this.level6.TabStop = false;
            // 
            // level7
            // 
            this.level7.BackColor = System.Drawing.Color.Transparent;
            this.level7.Location = new System.Drawing.Point(626, 99);
            this.level7.Name = "level7";
            this.level7.Size = new System.Drawing.Size(75, 453);
            this.level7.TabIndex = 28;
            this.level7.TabStop = false;
            // 
            // level8
            // 
            this.level8.BackColor = System.Drawing.Color.Transparent;
            this.level8.Location = new System.Drawing.Point(327, 169);
            this.level8.Name = "level8";
            this.level8.Size = new System.Drawing.Size(75, 83);
            this.level8.TabIndex = 29;
            this.level8.TabStop = false;
            this.level8.Click += new System.EventHandler(this.level8_Click);
            // 
            // level9
            // 
            this.level9.BackColor = System.Drawing.Color.Transparent;
            this.level9.Location = new System.Drawing.Point(89, 477);
            this.level9.Name = "level9";
            this.level9.Size = new System.Drawing.Size(87, 88);
            this.level9.TabIndex = 30;
            this.level9.TabStop = false;
            // 
            // level10
            // 
            this.level10.BackColor = System.Drawing.Color.Transparent;
            this.level10.Location = new System.Drawing.Point(213, 451);
            this.level10.Name = "level10";
            this.level10.Size = new System.Drawing.Size(76, 70);
            this.level10.TabIndex = 31;
            this.level10.TabStop = false;
            // 
            // level11
            // 
            this.level11.BackColor = System.Drawing.Color.Transparent;
            this.level11.Location = new System.Drawing.Point(627, 99);
            this.level11.Name = "level11";
            this.level11.Size = new System.Drawing.Size(375, 76);
            this.level11.TabIndex = 32;
            this.level11.TabStop = false;
            // 
            // level12
            // 
            this.level12.BackColor = System.Drawing.Color.Transparent;
            this.level12.Location = new System.Drawing.Point(1001, 156);
            this.level12.Name = "level12";
            this.level12.Size = new System.Drawing.Size(87, 96);
            this.level12.TabIndex = 33;
            this.level12.TabStop = false;
            // 
            // level13
            // 
            this.level13.BackColor = System.Drawing.Color.Transparent;
            this.level13.Location = new System.Drawing.Point(1002, 475);
            this.level13.Name = "level13";
            this.level13.Size = new System.Drawing.Size(87, 115);
            this.level13.TabIndex = 34;
            this.level13.TabStop = false;
            // 
            // level14
            // 
            this.level14.BackColor = System.Drawing.Color.Transparent;
            this.level14.Location = new System.Drawing.Point(176, 553);
            this.level14.Name = "level14";
            this.level14.Size = new System.Drawing.Size(150, 77);
            this.level14.TabIndex = 35;
            this.level14.TabStop = false;
            // 
            // level15
            // 
            this.level15.BackColor = System.Drawing.Color.Transparent;
            this.level15.Location = new System.Drawing.Point(175, 101);
            this.level15.Name = "level15";
            this.level15.Size = new System.Drawing.Size(227, 75);
            this.level15.TabIndex = 36;
            this.level15.TabStop = false;
            // 
            // level18
            // 
            this.level18.BackColor = System.Drawing.Color.Transparent;
            this.level18.Location = new System.Drawing.Point(702, 161);
            this.level18.Name = "level18";
            this.level18.Size = new System.Drawing.Size(75, 90);
            this.level18.TabIndex = 37;
            this.level18.TabStop = false;
            // 
            // level17
            // 
            this.level17.BackColor = System.Drawing.Color.Transparent;
            this.level17.Location = new System.Drawing.Point(852, 552);
            this.level17.Name = "level17";
            this.level17.Size = new System.Drawing.Size(245, 77);
            this.level17.TabIndex = 38;
            this.level17.TabStop = false;
            // 
            // level16
            // 
            this.level16.BackColor = System.Drawing.Color.Transparent;
            this.level16.Location = new System.Drawing.Point(93, 161);
            this.level16.Name = "level16";
            this.level16.Size = new System.Drawing.Size(83, 90);
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
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.fog_right);
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
            this.Controls.Add(this.picEnemyPoisonPacket);
            this.Controls.Add(this.picBossKoolAid);
            this.Controls.Add(this.picPlayer);
            this.DoubleBuffered = true;
            this.Name = "FrmLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
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

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picBossKoolAid;
        private System.Windows.Forms.Label lblInGameTime;
        private System.Windows.Forms.Timer tmrUpdateInGameTime;
        private System.Windows.Forms.Timer tmrPlayerMove;
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
    }
}

