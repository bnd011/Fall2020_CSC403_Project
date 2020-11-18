using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Dynamic;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel : Form
    {
      private Player player;

      private Enemy enemy1;
      private Enemy bossKoolaid;
      private Enemy enemy2;
      //because enemies are hardcoded into the game, this variable is also hard coded. Once enemies are setup in a different way,
      //this vairble can be initialized when the game starts and recognizes the number of enemies present in the level
      private int numEnemiesRemaining = 3;

      static class Globals
      {
        public static int m;
      }



      private void UpdateLevelAfterEnemyLostInBattle(Enemy defeatedEnemy)
      {
        //koolaid man final boss is hard coded into the game
        if (defeatedEnemy == bossKoolaid)
        {
          picBossKoolAid.Dispose();
        }

        //delete the image for enmey 1 or 2 corresponding to the correct one from the global randomly chosen enemy
        if (Globals.m == 1)
        {
          if (defeatedEnemy == enemy1)
          {
            picEnemyPoisonPacket.Dispose();
          }
          else
          {
            picEnemyCheeto.Dispose();
          }
        }
        else if(Globals.m == 2)
        {
          if (defeatedEnemy == enemy1)
          {
            picEnemyPoisonPacket.Dispose();
          }
          else
          {
            pictureBox1.Dispose();
          }
        }
        else if (Globals.m == 3)
        {
          if (defeatedEnemy == enemy1)
          {
            pictureBox2.Dispose();
          }
          else
          {
            pictureBox3.Dispose();
          }
        }
        else if (Globals.m == 4)
        {
          if (defeatedEnemy == enemy1)
          {
            pictureBox4.Dispose();
          }
          else
          {
            pictureBox5.Dispose();
          }
        }

        if (--numEnemiesRemaining <= 0)
        {
          GameWonSequence();
        }
    }

        private Character[] walls;

        private DateTime timeBegin;
        private FrmBattle frmBattle;
        private static int[] fog_upper_offset = { -1148, -588 };
        private static int[] fog_lower_offset = { -1148, 168 };
        private static int[] fog_left_offset = { -1056, -97 };
        private static int[] fog_right_offset = { 159, -97 };

        public FrmLevel()
        {
            InitializeComponent();
            SetupLevel();
        }

    private void FrmLevel_Load(object sender, EventArgs e)
    {
      const int PADDING = 7;
      const int NUM_WALLS = 13;
      Random rnd = new Random();
      Globals.m = rnd.Next(1, 5);

      //the player is always mr peanut, and the final boss is the koolaid man, but the other two enemies are randomized
      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING), "Mr. Peanut", "Nutty Whack");
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING), "THE KOOLAID MAN", "OH YEAAAAHHHHHHH");
      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      bossKoolaid.Color = Color.Green;

      //given the randomly selected value, setup data for the two corresponding enemy units and dispose all other unneeded enemy units
      if (Globals.m == 1)
      {
        enemy1 = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING), "Corosive Man", "Poison Slice");
        enemy2 = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING), "Chester Cheeto", "CHEEEEEESE");

        enemy1.Img = picEnemyPoisonPacket.BackgroundImage;
        enemy2.Img = picEnemyCheeto.BackgroundImage;

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
        enemy1 = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING), "Corosive Man", "Poison Slice");
        enemy2 = new Enemy(CreatePosition(pictureBox1), CreateCollider(pictureBox1, PADDING), "Grape Koolaid", "Fruity Blitz");

        enemy1.Img = picEnemyPoisonPacket.BackgroundImage;
        enemy2.Img = pictureBox1.BackgroundImage;

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
        enemy1 = new Enemy(CreatePosition(pictureBox2), CreateCollider(pictureBox2, PADDING), "Grape Man", "Graple");
        enemy2 = new Enemy(CreatePosition(pictureBox3), CreateCollider(pictureBox3, PADDING), "Poisonous Pouch", "Toxic Strike");

        enemy1.Img = pictureBox2.BackgroundImage;
        enemy2.Img = pictureBox3.BackgroundImage;

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
        enemy1 = new Enemy(CreatePosition(pictureBox4), CreateCollider(pictureBox4, PADDING), "Mini Koolaid", "Tiny Jab");
        enemy2 = new Enemy(CreatePosition(pictureBox5), CreateCollider(pictureBox5, PADDING), "Thrower", "Throw-aid");

        enemy1.Img = pictureBox4.BackgroundImage;
        enemy2.Img = pictureBox5.BackgroundImage;

        enemy1.Color = Color.Red;
        enemy2.Color = Color.FromArgb(255, 245, 161);

        pictureBox1.Dispose();
        picEnemyPoisonPacket.Dispose();
        picEnemyCheeto.Dispose();
        pictureBox2.Dispose();
        pictureBox3.Dispose();
      }

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++)
      {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      Game.player = player;
      timeBegin = DateTime.Now;
      Player.PlayerLost += GameLostSequence;
      Enemy.EnemyLostInBattle += UpdateLevelAfterEnemyLostInBattle;
    }

    private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }


        private void SetupLevel()
        {
            picPlayer.Location = new Point(picPlayer.Location.X - 514, picPlayer.Location.Y + 227);
        }

        private Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }

        private void FrmLevel_KeyUp(object sender, KeyEventArgs e)
        {
            player.ResetMoveSpeed();
        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            // move player
            player.Move();

            // check collision with walls
            if (HitAWall(player))
            {
                player.MoveBack();
            }

            // check collision with enemies
            if (HitAChar(player, enemy1))
            {
                Fight(enemy1);
            }
            else if (HitAChar(player, enemy2))
            {
                Fight(enemy2);
            }
            if (HitAChar(player, bossKoolaid))
            {
                Fight(bossKoolaid);
            }

            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);

            // Update the pictureboxes that make up the "fog of war" based on the new player location
            fog_upper.Location = new Point((int)player.Position.x + fog_upper_offset[0], (int)player.Position.y + fog_upper_offset[1]);
            fog_lower.Location = new Point((int)player.Position.x + fog_lower_offset[0], (int)player.Position.y + fog_lower_offset[1]);
            fog_left.Location = new Point((int)player.Position.x + fog_left_offset[0], (int)player.Position.y + fog_left_offset[1]);
            fog_right.Location = new Point((int)player.Position.x + fog_right_offset[0], (int)player.Position.y + fog_right_offset[1]);
        }

        private bool HitAWall(Character c)
        {
            bool hitAWall = false;
            for (int w = 0; w < walls.Length; w++)
            {
                if (c.Collider.Intersects(walls[w].Collider))
                {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
        }

        private bool HitAChar(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider);
        }

        private void Fight(Enemy enemy)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            frmBattle = FrmBattle.GetInstance(enemy);
            frmBattle.Show();

            if (enemy == bossKoolaid)
            {
                frmBattle.SetupForBossBattle();
            }
        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
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

        private void lblInGameTime_Click(object sender, EventArgs e)
        {

        }

        private void fog_lower_Click(object sender, EventArgs e)
        {

        }


        private void GameWonSequence()
        {
            MessageBox.Show("Congratulations! You Win!");
            Application.Exit();
        }
        private void GameLostSequence()
        {
          MessageBox.Show("Big Oof! You Lost!");
          Application.Exit();
        }

        private void FrmLevel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
