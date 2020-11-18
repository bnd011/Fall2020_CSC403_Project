using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            else if (Globals.m == 2)
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

        private DateTime timeBegin;
        private FrmBattle frmBattle;
        private static int[] fog_upper_offset = { -1161, -668 };
        private static int[] fog_lower_offset = { -1176, 163 };
        private static int[] fog_left_offset = { -1139, -102 };
        private static int[] fog_right_offset = { 146, -102 };

        private List<PictureBox> level_layout_pictureBoxes;
        private List<LayoutCollider> level_layout_colliders;

        public FrmLevel()
        {
            InitializeComponent();
        }

        // simple class to associate a layout collider object with its corresponding pictureBox
        internal class LayoutCollider
        {
            public PictureBox pBox;
            public Collider collider;
            public LayoutCollider(PictureBox pBox)
            {
                this.pBox = pBox;
            }
        }

        // Class that contains the necessary information to define a level layout
        internal class LevelLayout
        {
            // level layout's background image
            public Image form_bg;
            // sprite positions: player, boss, enemy1, enemy2
            public List<Point> spritePos;
            public List<Point> layoutColliderPos;
            public List<Size> layoutColliderSize;

            public LevelLayout(Image image, List<Point> spritePos, List<Point> layoutColliderPos, List<Size> vs)
            {
                this.form_bg = image;
                this.spritePos = spritePos;
                this.layoutColliderPos = layoutColliderPos;
                this.layoutColliderSize = vs;
            }
        }

        private List<LevelLayout> LoadLevelLayouts()
        {
            List<LevelLayout> layouts = new List<LevelLayout>
            {
                new LevelLayout(
                    global::Fall2020_CSC403_Project.Properties.Resources.layout1,
                    new List<Point> { new Point(132, 539), new Point(881, 111), new Point(132, 111), new Point(831, 497) },
                    new List<Point> { new Point(-7, -6), new Point(-7, 628), new Point(-6, 68), new Point(1077, 78), new Point(477, 403), new Point(552, 64), new Point(777, 327), new Point(74, 402), new Point(252, 176) },
                    new List<Size> { new Size(1188, 107), new Size(1188, 107), new Size(107, 585), new Size(107, 585), new Size(149, 253), new Size(224, 188), new Size(320, 148), new Size(253, 74), new Size(149, 151) }),
                new LevelLayout(
                    global::Fall2020_CSC403_Project.Properties.Resources.layout0,
                    new List<Point> { new Point(837, 211), new Point(92, 438), new Point(313, 200), new Point(648, 403) },
                    new List<Point> { new Point(-7, -6), new Point(-7, 702), new Point(-6, 12), new Point(1152, 32) },
                    new List<Size> { new Size(1188, 32), new Size(1188, 33), new Size(31, 702), new Size(32, 682) }),
                new LevelLayout(
                    global::Fall2020_CSC403_Project.Properties.Resources.layout2,
                    new List<Point> { new Point(86, 65), new Point(944, 493), new Point(218, 427), new Point(1047, 50) },
                    new List<Point> { new Point(-7, -6), new Point(-6, 12), new Point(-7, 702), new Point(1152, 32), new Point(853, 326), new Point(853, 175), new Point(626, 477), new Point(476, 175), new Point(325, 174), new Point(15, 174), new Point(12, 549) },
                    new List<Size> { new Size(1188, 32), new Size(31, 702), new Size(1188, 33), new Size(32, 682), new Size(319, 150), new Size(148, 300), new Size(300, 75), new Size(226, 150), new Size(152, 378), new Size(161, 227), new Size(164, 155) }),
                new LevelLayout(
                    global::Fall2020_CSC403_Project.Properties.Resources.layout3,
                    new List<Point> { new Point(124, 294), new Point(869, 345), new Point(445, 522), new Point(626, 230) },
                    new List<Point> { new Point(-6, 12), new Point(-7, 702), new Point(1152, 32), new Point(-7, -6), new Point(26, 251), new Point(100, 402), new Point(176, 251), new Point(252, 176), new Point(326, 628), new Point(251, 25), new Point(401, 99), new Point(543, 100), new Point(777, 161), new Point(1077, 25), new Point(1077, 402), new Point(551, 626), new Point(627, 402), new Point(777, 326) },
                    new List<Size> { new Size(31, 702), new Size(1188, 33), new Size(32, 682), new Size(1188, 32), new Size(75, 184), new Size(77, 75), new Size(150, 379), new Size(74, 75), new Size(74, 75), new Size(902, 76), new Size(150, 378), new Size(309, 76), new Size(75, 90), new Size(87, 301), new Size(87, 301), new Size(547, 77), new Size(150, 244), new Size(76, 310) }),
                new LevelLayout(
                    global::Fall2020_CSC403_Project.Properties.Resources.layout4,
                    new List<Point> { new Point(146, 337), new Point(794, 266), new Point(528, 131), new Point(431, 425) },
                    new List<Point> { new Point(-7, -6), new Point(-7, 626), new Point(-6, 12), new Point(1077, 32), new Point(93, 161), new Point(89, 477), new Point(176, 553), new Point(175, 101), new Point(327, 169), new Point(326, 392), new Point(326, 326), new Point(626, 99), new Point(702, 161), new Point(627, 99), new Point(1001, 156), new Point(1002, 475), new Point(852, 552) },
                    new List<Size> { new Size(1188, 107), new Size(1188, 109), new Size(107, 702), new Size(107, 682), new Size(83, 90), new Size(87, 88), new Size(150, 77), new Size(227, 75), new Size(75, 83), new Size(76, 238), new Size(225, 76), new Size(75, 453), new Size(75, 90), new Size(375, 76), new Size(87, 96), new Size(87, 115), new Size(245, 77) })
            };
            return layouts;
        }

        private void SetupLevel()
        {
            List<LevelLayout> layouts = LoadLevelLayouts();

            Random random = new Random();
            LevelLayout chosenLayout = layouts[random.Next(layouts.Count)];

            this.BackgroundImage = chosenLayout.form_bg;
            player.pictureBox.Location = chosenLayout.spritePos[0];
            player.Position = CreatePosition(player.pictureBox);
            player.Collider = CreateCollider(player.pictureBox, 7);
            bossKoolaid.pictureBox.Location = chosenLayout.spritePos[1];
            bossKoolaid.Position = CreatePosition(bossKoolaid.pictureBox);
            bossKoolaid.Collider = CreateCollider(bossKoolaid.pictureBox, 7);
            enemy1.pictureBox.Location = chosenLayout.spritePos[2];
            enemy1.Position = CreatePosition(enemy1.pictureBox);
            enemy1.Collider = CreateCollider(enemy1.pictureBox, 7);
            enemy2.pictureBox.Location = chosenLayout.spritePos[3];
            enemy2.Position = CreatePosition(enemy2.pictureBox);
            enemy2.Collider = CreateCollider(enemy2.pictureBox, 7);

            level_layout_pictureBoxes = new List<PictureBox> { level1, level2, level3, level4, level5, level6, level7, level8, level9, level10, level11, level12, level13, level14, level15, level16, level17, level18 };

            // Remove excess layout colliders based on the randomly chosen layout
            if (level_layout_pictureBoxes.Count > chosenLayout.layoutColliderPos.Count)
            {
                for (int i = chosenLayout.layoutColliderPos.Count; i < level_layout_pictureBoxes.Count; i++)
                    level_layout_pictureBoxes[i].Dispose();
                level_layout_pictureBoxes.RemoveRange(chosenLayout.layoutColliderPos.Count, level_layout_pictureBoxes.Count - chosenLayout.layoutColliderPos.Count);
            }

            // update layout collider locations and sizes based on randomly chosen layout
            for (int i = 0; i < level_layout_pictureBoxes.Count; i++)
            {
                level_layout_pictureBoxes[i].Location = chosenLayout.layoutColliderPos[i];
                level_layout_pictureBoxes[i].Size = chosenLayout.layoutColliderSize[i];
            }

            // actually create the collider objects
            level_layout_colliders = level_layout_pictureBoxes.ConvertAll<LayoutCollider>(pBox => new LayoutCollider(pBox));

            foreach (LayoutCollider layoutCollider in level_layout_colliders)
            {
                layoutCollider.collider = CreateCollider(layoutCollider.pBox, 0);
            }
        }

        private void FrmLevel_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            Random rnd = new Random();
            Globals.m = rnd.Next(1, 5);

            //the player is always mr peanut, and the final boss is the koolaid man, but the other two enemies are randomized
            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING), "Mr. Peanut", "Nutty Whack", picPlayer);
            bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING), "THE KOOLAID MAN", "OH YEAAAAHHHHHHH", picBossKoolAid);
            bossKoolaid.Img = picBossKoolAid.BackgroundImage;
            bossKoolaid.Color = Color.Green;

            //given the randomly selected value, setup data for the two corresponding enemy units and dispose all other unneeded enemy units
            if (Globals.m == 1)
            {
                enemy1 = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING), "Corosive Man", "Poison Slice", picEnemyPoisonPacket);
                enemy2 = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING), "Chester Cheeto", "CHEEEEEESE", picEnemyPoisonPacket);

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
                enemy1 = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING), "Corosive Man", "Poison Slice", picEnemyPoisonPacket);
                enemy2 = new Enemy(CreatePosition(pictureBox1), CreateCollider(pictureBox1, PADDING), "Grape Koolaid", "Fruity Blitz", pictureBox1);

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
                enemy1 = new Enemy(CreatePosition(pictureBox2), CreateCollider(pictureBox2, PADDING), "Grape Man", "Graple", pictureBox2);
                enemy2 = new Enemy(CreatePosition(pictureBox3), CreateCollider(pictureBox3, PADDING), "Poisonous Pouch", "Toxic Strike", pictureBox3);

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
                enemy1 = new Enemy(CreatePosition(pictureBox4), CreateCollider(pictureBox4, PADDING), "Mini Koolaid", "Tiny Jab", pictureBox4);
                enemy2 = new Enemy(CreatePosition(pictureBox5), CreateCollider(pictureBox5, PADDING), "Thrower", "Throw-aid", pictureBox5);

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

            SetupLevel();

            Game.player = player;
            timeBegin = DateTime.Now;

            Enemy.EnemyLostInBattle += UpdateLevelAfterEnemyLostInBattle;
        }

        private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
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
            // check for intersections with the layout colliders on the level
            foreach (LayoutCollider layoutCollider in level_layout_colliders)
            {
                if (c.Collider.Intersects(layoutCollider.collider))
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
