using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;

    private Enemy enemy1;
    private Enemy bossKoolaid;
    private Enemy enemy2;
    private Character[] walls;

    private DateTime timeBegin;
    private FrmBattle frmBattle;


        static class Globals
        {
            public static int m;
        }

        public FrmLevel() {
      InitializeComponent();


        }


      private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;
      Random rnd = new Random();
      Globals.m = rnd.Next(1, 5);


            if (Globals.m == 1)
            {
                player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
                bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
                enemy1 = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
                enemy2 = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));

                bossKoolaid.Img = picBossKoolAid.BackgroundImage;
                enemy1.Img = picEnemyPoisonPacket.BackgroundImage;
                enemy2.Img = picEnemyCheeto.BackgroundImage;

                bossKoolaid.Color = Color.Green;
                enemy1.Color = Color.Red;
                enemy2.Color = Color.FromArgb(255, 245, 161);

                pictureBox1.Dispose();
                pictureBox2.Dispose();
                pictureBox3.Dispose();
                pictureBox4.Dispose();
                pictureBox5.Dispose();
            }
      if (Globals.m == 2)
            {
                player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
                bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
                enemy1 = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
                enemy2 = new Enemy(CreatePosition(pictureBox1), CreateCollider(pictureBox1, PADDING));

                bossKoolaid.Img = picBossKoolAid.BackgroundImage;
                enemy1.Img = picEnemyPoisonPacket.BackgroundImage;
                enemy2.Img = pictureBox1.BackgroundImage;

                bossKoolaid.Color = Color.Green;
                enemy1.Color = Color.Red;
                enemy2.Color = Color.FromArgb(255, 245, 161);

                picEnemyCheeto.Dispose();
                pictureBox2.Dispose();
                pictureBox3.Dispose();
                pictureBox4.Dispose();
                pictureBox5.Dispose();
            }

            if (Globals.m == 3)
            {
                player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
                bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
                enemy1 = new Enemy(CreatePosition(pictureBox2), CreateCollider(pictureBox2, PADDING));
                enemy2 = new Enemy(CreatePosition(pictureBox3), CreateCollider(pictureBox3, PADDING));

                bossKoolaid.Img = picBossKoolAid.BackgroundImage;
                enemy1.Img = pictureBox2.BackgroundImage;
                enemy2.Img = pictureBox3.BackgroundImage;

                bossKoolaid.Color = Color.Green;
                enemy1.Color = Color.Red;
                enemy2.Color = Color.FromArgb(255, 245, 161);

                pictureBox1.Dispose();
                picEnemyPoisonPacket.Dispose();
                picEnemyCheeto.Dispose();
                pictureBox4.Dispose();
                pictureBox5.Dispose();

            }

            if (Globals.m == 4)
            {
                player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
                bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
                enemy1 = new Enemy(CreatePosition(pictureBox4), CreateCollider(pictureBox4, PADDING));
                enemy2 = new Enemy(CreatePosition(pictureBox5), CreateCollider(pictureBox5, PADDING));

                bossKoolaid.Img = picBossKoolAid.BackgroundImage;
                enemy1.Img = pictureBox4.BackgroundImage;
                enemy2.Img = pictureBox5.BackgroundImage;

                bossKoolaid.Color = Color.Green;
                enemy1.Color = Color.Red;
                enemy2.Color = Color.FromArgb(255, 245, 161);

                pictureBox1.Dispose();
                picEnemyPoisonPacket.Dispose();
                picEnemyCheeto.Dispose();
                pictureBox2.Dispose();
                pictureBox3.Dispose();
            }



            walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      Game.player = player;
      timeBegin = DateTime.Now;
    }

    private Vector2 CreatePosition(PictureBox pic) {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    private Collider CreateCollider(PictureBox pic, int padding) {
      Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
      return new Collider(rect);
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      player.ResetMoveSpeed();
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      TimeSpan span = DateTime.Now - timeBegin;
      string time = span.ToString(@"hh\:mm\:ss");
      lblInGameTime.Text = "Time: " + time.ToString();
    }

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
      // move player
      player.Move();

      // check collision with walls
      if (HitAWall(player)) {
        player.MoveBack();
      }

      // check collision with enemies
      if (HitAChar(player, enemy1)) {
        Fight(enemy1);
      }
      else if (HitAChar(player, enemy2)) {
        Fight(enemy2);
      }
      if (HitAChar(player, bossKoolaid)) {
        Fight(bossKoolaid);
      }

      // update player's picture box
      picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
    }


        private bool HitAWall(Character c) {
      bool hitAWall = false;
      for (int w = 0; w < walls.Length; w++) {
        if (c.Collider.Intersects(walls[w].Collider)) {
          hitAWall = true;
          break;
        }
      }
      return hitAWall;
    }

    private bool HitAChar(Character you, Character other) {
      return you.Collider.Intersects(other.Collider);
    }

    private void Fight(Enemy enemy) {
      player.ResetMoveSpeed();
      player.MoveBack();
      frmBattle = FrmBattle.GetInstance(enemy);
      frmBattle.Show();

      if (enemy == bossKoolaid) {
        frmBattle.SetupForBossBattle();
      }
    }

    private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
      switch (e.KeyCode) {
        case Keys.Left:
          player.GoLeft();
          break;

        case Keys.Right:
          player.GoRight();
          break;

        case Keys.Up:
          player.GoUp();
          break;

        case Keys.Down:
          player.GoDown();
          break;

        default:
          player.ResetMoveSpeed();
          break;
      }
    }

    private void lblInGameTime_Click(object sender, EventArgs e) {

    }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
