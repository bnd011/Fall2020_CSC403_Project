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
      this.pictureBox5 = new System.Windows.Forms.PictureBox();
      this.pictureBox4 = new System.Windows.Forms.PictureBox();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.fog_right = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.fog_left = new System.Windows.Forms.PictureBox();
      this.picWall11 = new System.Windows.Forms.PictureBox();
      this.picWall2 = new System.Windows.Forms.PictureBox();
      this.picWall8 = new System.Windows.Forms.PictureBox();
      this.picWall7 = new System.Windows.Forms.PictureBox();
      this.picWall1 = new System.Windows.Forms.PictureBox();
      this.picWall0 = new System.Windows.Forms.PictureBox();
      this.picWall10 = new System.Windows.Forms.PictureBox();
      this.picWall9 = new System.Windows.Forms.PictureBox();
      this.picWall6 = new System.Windows.Forms.PictureBox();
      this.picWall12 = new System.Windows.Forms.PictureBox();
      this.picWall4 = new System.Windows.Forms.PictureBox();
      this.picWall5 = new System.Windows.Forms.PictureBox();
      this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
      this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
      this.picWall3 = new System.Windows.Forms.PictureBox();
      this.picBossKoolAid = new System.Windows.Forms.PictureBox();
      this.picPlayer = new System.Windows.Forms.PictureBox();
      this.fog_lower = new System.Windows.Forms.PictureBox();
      this.fog_upper = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fog_right)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fog_left)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall11)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall10)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall9)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall12)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fog_lower)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fog_upper)).BeginInit();
      this.SuspendLayout();
      // 
      // lblInGameTime
      // 
      this.lblInGameTime.AutoSize = true;
      this.lblInGameTime.BackColor = System.Drawing.Color.Black;
      this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblInGameTime.ForeColor = System.Drawing.Color.White;
      this.lblInGameTime.Location = new System.Drawing.Point(16, 11);
      this.lblInGameTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblInGameTime.Name = "lblInGameTime";
      this.lblInGameTime.Size = new System.Drawing.Size(60, 24);
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
      this.pictureBox4.Location = new System.Drawing.Point(159, 121);
      this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.Size = new System.Drawing.Size(72, 130);
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
      // fog_right
      // 
      this.fog_right.BackColor = System.Drawing.Color.Black;
      this.fog_right.Location = new System.Drawing.Point(1017, 266);
      this.fog_right.Margin = new System.Windows.Forms.Padding(4);
      this.fog_right.Name = "fog_right";
      this.fog_right.Size = new System.Drawing.Size(1271, 362);
      this.fog_right.TabIndex = 21;
      this.fog_right.TabStop = false;
      // 
      // pictureBox2
      // 
      this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.grape_packet;
      this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pictureBox2.Location = new System.Drawing.Point(159, 121);
      this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(72, 130);
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
      // fog_left
      // 
      this.fog_left.BackColor = System.Drawing.Color.Black;
      this.fog_left.Location = new System.Drawing.Point(-603, 266);
      this.fog_left.Margin = new System.Windows.Forms.Padding(4);
      this.fog_left.Name = "fog_left";
      this.fog_left.Size = new System.Drawing.Size(1271, 362);
      this.fog_left.TabIndex = 20;
      this.fog_left.TabStop = false;
      // 
      // picWall11
      // 
      this.picWall11.BackColor = System.Drawing.Color.Transparent;
      this.picWall11.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
      this.picWall11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall11.Location = new System.Drawing.Point(735, 523);
      this.picWall11.Margin = new System.Windows.Forms.Padding(4);
      this.picWall11.Name = "picWall11";
      this.picWall11.Size = new System.Drawing.Size(219, 286);
      this.picWall11.TabIndex = 17;
      this.picWall11.TabStop = false;
      // 
      // picWall2
      // 
      this.picWall2.BackColor = System.Drawing.Color.Transparent;
      this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
      this.picWall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall2.Location = new System.Drawing.Point(735, 1);
      this.picWall2.Margin = new System.Windows.Forms.Padding(4);
      this.picWall2.Name = "picWall2";
      this.picWall2.Size = new System.Drawing.Size(625, 82);
      this.picWall2.TabIndex = 16;
      this.picWall2.TabStop = false;
      // 
      // picWall8
      // 
      this.picWall8.BackColor = System.Drawing.Color.Transparent;
      this.picWall8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
      this.picWall8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall8.Location = new System.Drawing.Point(1457, 337);
      this.picWall8.Margin = new System.Windows.Forms.Padding(4);
      this.picWall8.Name = "picWall8";
      this.picWall8.Size = new System.Drawing.Size(109, 553);
      this.picWall8.TabIndex = 15;
      this.picWall8.TabStop = false;
      // 
      // picWall7
      // 
      this.picWall7.BackColor = System.Drawing.Color.Transparent;
      this.picWall7.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
      this.picWall7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall7.Location = new System.Drawing.Point(952, 807);
      this.picWall7.Margin = new System.Windows.Forms.Padding(4);
      this.picWall7.Name = "picWall7";
      this.picWall7.Size = new System.Drawing.Size(507, 82);
      this.picWall7.TabIndex = 14;
      this.picWall7.TabStop = false;
      // 
      // picWall1
      // 
      this.picWall1.BackColor = System.Drawing.Color.Transparent;
      this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
      this.picWall1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall1.Location = new System.Drawing.Point(111, 1);
      this.picWall1.Margin = new System.Windows.Forms.Padding(4);
      this.picWall1.Name = "picWall1";
      this.picWall1.Size = new System.Drawing.Size(625, 82);
      this.picWall1.TabIndex = 13;
      this.picWall1.TabStop = false;
      // 
      // picWall0
      // 
      this.picWall0.BackColor = System.Drawing.Color.Transparent;
      this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
      this.picWall0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall0.Location = new System.Drawing.Point(3, 1);
      this.picWall0.Margin = new System.Windows.Forms.Padding(4);
      this.picWall0.Name = "picWall0";
      this.picWall0.Size = new System.Drawing.Size(109, 478);
      this.picWall0.TabIndex = 12;
      this.picWall0.TabStop = false;
      // 
      // picWall10
      // 
      this.picWall10.BackColor = System.Drawing.Color.Transparent;
      this.picWall10.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
      this.picWall10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall10.Location = new System.Drawing.Point(871, 110);
      this.picWall10.Margin = new System.Windows.Forms.Padding(4);
      this.picWall10.Name = "picWall10";
      this.picWall10.Size = new System.Drawing.Size(304, 199);
      this.picWall10.TabIndex = 11;
      this.picWall10.TabStop = false;
      // 
      // picWall9
      // 
      this.picWall9.BackColor = System.Drawing.Color.Transparent;
      this.picWall9.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
      this.picWall9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall9.Location = new System.Drawing.Point(355, 190);
      this.picWall9.Margin = new System.Windows.Forms.Padding(4);
      this.picWall9.Name = "picWall9";
      this.picWall9.Size = new System.Drawing.Size(263, 145);
      this.picWall9.TabIndex = 10;
      this.picWall9.TabStop = false;
      // 
      // picWall6
      // 
      this.picWall6.BackColor = System.Drawing.Color.Transparent;
      this.picWall6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
      this.picWall6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall6.Location = new System.Drawing.Point(476, 807);
      this.picWall6.Margin = new System.Windows.Forms.Padding(4);
      this.picWall6.Name = "picWall6";
      this.picWall6.Size = new System.Drawing.Size(477, 82);
      this.picWall6.TabIndex = 9;
      this.picWall6.TabStop = false;
      // 
      // picWall12
      // 
      this.picWall12.BackColor = System.Drawing.Color.Transparent;
      this.picWall12.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
      this.picWall12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall12.Location = new System.Drawing.Point(1187, 489);
      this.picWall12.Margin = new System.Windows.Forms.Padding(4);
      this.picWall12.Name = "picWall12";
      this.picWall12.Size = new System.Drawing.Size(271, 139);
      this.picWall12.TabIndex = 8;
      this.picWall12.TabStop = false;
      // 
      // picWall4
      // 
      this.picWall4.BackColor = System.Drawing.Color.Transparent;
      this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
      this.picWall4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall4.Location = new System.Drawing.Point(3, 559);
      this.picWall4.Margin = new System.Windows.Forms.Padding(4);
      this.picWall4.Name = "picWall4";
      this.picWall4.Size = new System.Drawing.Size(109, 250);
      this.picWall4.TabIndex = 7;
      this.picWall4.TabStop = false;
      // 
      // picWall5
      // 
      this.picWall5.BackColor = System.Drawing.Color.Transparent;
      this.picWall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
      this.picWall5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall5.Location = new System.Drawing.Point(3, 807);
      this.picWall5.Margin = new System.Windows.Forms.Padding(4);
      this.picWall5.Name = "picWall5";
      this.picWall5.Size = new System.Drawing.Size(477, 82);
      this.picWall5.TabIndex = 6;
      this.picWall5.TabStop = false;
      // 
      // picEnemyCheeto
      // 
      this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
      this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
      this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picEnemyCheeto.Location = new System.Drawing.Point(1117, 665);
      this.picEnemyCheeto.Margin = new System.Windows.Forms.Padding(4);
      this.picEnemyCheeto.Name = "picEnemyCheeto";
      this.picEnemyCheeto.Size = new System.Drawing.Size(85, 132);
      this.picEnemyCheeto.TabIndex = 5;
      this.picEnemyCheeto.TabStop = false;
      // 
      // picEnemyPoisonPacket
      // 
      this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.Transparent;
      this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
      this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picEnemyPoisonPacket.Location = new System.Drawing.Point(147, 121);
      this.picEnemyPoisonPacket.Margin = new System.Windows.Forms.Padding(4);
      this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
      this.picEnemyPoisonPacket.Size = new System.Drawing.Size(84, 118);
      this.picEnemyPoisonPacket.TabIndex = 4;
      this.picEnemyPoisonPacket.TabStop = false;
      // 
      // picWall3
      // 
      this.picWall3.BackColor = System.Drawing.Color.Transparent;
      this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
      this.picWall3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picWall3.Location = new System.Drawing.Point(3, 478);
      this.picWall3.Margin = new System.Windows.Forms.Padding(4);
      this.picWall3.Name = "picWall3";
      this.picWall3.Size = new System.Drawing.Size(477, 82);
      this.picWall3.TabIndex = 3;
      this.picWall3.TabStop = false;
      // 
      // picBossKoolAid
      // 
      this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
      this.picBossKoolAid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBossKoolAid.BackgroundImage")));
      this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picBossKoolAid.Location = new System.Drawing.Point(1295, 91);
      this.picBossKoolAid.Margin = new System.Windows.Forms.Padding(4);
      this.picBossKoolAid.Name = "picBossKoolAid";
      this.picBossKoolAid.Size = new System.Drawing.Size(257, 239);
      this.picBossKoolAid.TabIndex = 1;
      this.picBossKoolAid.TabStop = false;
      // 
      // picPlayer
      // 
      this.picPlayer.BackColor = System.Drawing.Color.Transparent;
      this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
      this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picPlayer.Location = new System.Drawing.Point(805, 385);
      this.picPlayer.Margin = new System.Windows.Forms.Padding(4);
      this.picPlayer.Name = "picPlayer";
      this.picPlayer.Size = new System.Drawing.Size(72, 130);
      this.picPlayer.TabIndex = 0;
      this.picPlayer.TabStop = false;
      // 
      // fog_lower
      // 
      this.fog_lower.BackColor = System.Drawing.Color.Black;
      this.fog_lower.Location = new System.Drawing.Point(-745, 592);
      this.fog_lower.Margin = new System.Windows.Forms.Padding(4);
      this.fog_lower.Name = "fog_lower";
      this.fog_lower.Size = new System.Drawing.Size(3128, 615);
      this.fog_lower.TabIndex = 19;
      this.fog_lower.TabStop = false;
      // 
      // fog_upper
      // 
      this.fog_upper.BackColor = System.Drawing.Color.Black;
      this.fog_upper.Location = new System.Drawing.Point(-725, -338);
      this.fog_upper.Margin = new System.Windows.Forms.Padding(4);
      this.fog_upper.Name = "fog_upper";
      this.fog_upper.Size = new System.Drawing.Size(3128, 615);
      this.fog_upper.TabIndex = 18;
      this.fog_upper.TabStop = false;
      // 
      // FrmLevel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1568, 894);
      this.Controls.Add(this.fog_upper);
      this.Controls.Add(this.fog_lower);
      this.Controls.Add(this.fog_right);
      this.Controls.Add(this.lblInGameTime);
      this.Controls.Add(this.fog_left);
      this.Controls.Add(this.picWall11);
      this.Controls.Add(this.picWall2);
      this.Controls.Add(this.picWall8);
      this.Controls.Add(this.picWall7);
      this.Controls.Add(this.picWall1);
      this.Controls.Add(this.picWall0);
      this.Controls.Add(this.picWall10);
      this.Controls.Add(this.picWall9);
      this.Controls.Add(this.picWall6);
      this.Controls.Add(this.picWall12);
      this.Controls.Add(this.picWall4);
      this.Controls.Add(this.picWall5);
      this.Controls.Add(this.picWall3);
      this.Controls.Add(this.picPlayer);
      this.Controls.Add(this.pictureBox5);
      this.Controls.Add(this.pictureBox3);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.picEnemyCheeto);
      this.Controls.Add(this.picBossKoolAid);
      this.Controls.Add(this.pictureBox4);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.picEnemyPoisonPacket);
      this.DoubleBuffered = true;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "FrmLevel";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Explore";
      this.TransparencyKey = System.Drawing.Color.Transparent;
      this.Load += new System.EventHandler(this.FrmLevel_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fog_right)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fog_left)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall11)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall10)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall9)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall12)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fog_lower)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fog_upper)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picBossKoolAid;
        private System.Windows.Forms.Label lblInGameTime;
        private System.Windows.Forms.Timer tmrUpdateInGameTime;
        private System.Windows.Forms.Timer tmrPlayerMove;
        private System.Windows.Forms.PictureBox picWall3;
        private System.Windows.Forms.PictureBox picEnemyPoisonPacket;
        private System.Windows.Forms.PictureBox picEnemyCheeto;
        private System.Windows.Forms.PictureBox picWall5;
        private System.Windows.Forms.PictureBox picWall4;
        private System.Windows.Forms.PictureBox picWall12;
        private System.Windows.Forms.PictureBox picWall6;
        private System.Windows.Forms.PictureBox picWall9;
        private System.Windows.Forms.PictureBox picWall10;
        private System.Windows.Forms.PictureBox picWall0;
        private System.Windows.Forms.PictureBox picWall7;
        private System.Windows.Forms.PictureBox picWall8;
        private System.Windows.Forms.PictureBox picWall1;
        private System.Windows.Forms.PictureBox picWall2;
        private System.Windows.Forms.PictureBox picWall11;
        private System.Windows.Forms.PictureBox fog_upper;
        private System.Windows.Forms.PictureBox fog_lower;
        private System.Windows.Forms.PictureBox fog_left;
        private System.Windows.Forms.PictureBox fog_right;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.PictureBox pictureBox4;
    private System.Windows.Forms.PictureBox pictureBox5;
  }
}

