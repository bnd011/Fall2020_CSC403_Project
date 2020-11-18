using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : Form {
    private static int baseMillisecondDelay = 1200;
    public static FrmBattle instance = null;
    private Enemy enemy;
    private Player player;
    public string vcontrol = Sound_Page.igvolcontrol; // Will be used to turn sound on/off

        private FrmBattle() {
      InitializeComponent();
      player = Game.player;
    }

    public void Setup() {
      // update for this enemy
      picEnemy.BackgroundImage = enemy.Img;
      picEnemy.Refresh();
      BackColor = enemy.Color;
      picBossBattle.Visible = false;

      // Observer pattern
      enemy.AttackEvent += PlayerDamage;
      player.AttackEvent += EnemyDamage;

      // show health
      UpdateHealthBars();
    }

    public void SetupForBossBattle() {
      picBossBattle.Location = Point.Empty;
      picBossBattle.Size = ClientSize;
      picBossBattle.Visible = true;

      SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
      // if igvolume variable changed to OFF from the sound page, then sound will not play.
      if (vcontrol.Equals("ON"))
        {
             simpleSound.Play();
        }


            tmrFinalBattle.Enabled = true;
    }

    public static FrmBattle GetInstance(Enemy enemy) {
      if (instance == null) {
        instance = new FrmBattle();
        instance.enemy = enemy;
        instance.Setup();
      }
      return instance;
    }

    private void UpdateHealthBars() {
      float playerHealthPer = player.Health / (float)player.MaxHealth;
      float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

      const int MAX_HEALTHBAR_WIDTH = 226;
      lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
      lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

      lblPlayerHealthFull.Text = player.Health.ToString();
      lblEnemyHealthFull.Text = enemy.Health.ToString();
    }

    private void btnAttack_Click(object sender, EventArgs e)
    {
      //disable the button until processing is complete. Anything other than a button as sender is invalid
      if(sender is Button)
      {
        var button = (Button)sender;
        button.Enabled = false;
        
        //the attack events will handle the changing of the health, GUI, and displaying text about the attack
        player.OnAttack(-4);
        if (enemy.Health > 0)
        {
          enemy.OnAttack(-2);
          //player is defeated
          if (player.Health <= 0)
          {
            BattleEndSequence(false);
          }
        }
        //enemy is defeated
        else
        {
          BattleEndSequence(true);
        }
        button.Enabled = true;
      }
    }

    //display text in box for a specified amount of time before removing it
    private void TriggerTimedTextBoxUpdate(string text, int millisecondsDelay)
    {
      SetBattleInfoTextBox(text);
      TriggerBattleTimeDelay(millisecondsDelay);
      SetBattleInfoTextBox("");
    }

    private void TriggerBattleTimeDelay(int milliseconds)
    {
      Task.Delay(milliseconds).Wait();
    }

    //text used when initiating an attack
    private string AttackUsedText(bool playerAttacking)
    {
      return (playerAttacking ? player.CharacterName : enemy.CharacterName) + " used the " 
                + (playerAttacking ? player.AttackName : enemy.AttackName) + " attack!";
    }

    //text used upon damage beign dealt after attack is used
    private string DamageTakenText(bool playerDamaged, int damageAmount)
    {
      //damage amount will always be a negative amount, but should be worded as a positive
      return (playerDamaged ? player.CharacterName : enemy.CharacterName) + " lost " + (-1 * damageAmount) + " health points.";
    }

    //while processing the damage for the enemy/player to take, display text for the attack being used and then the damage dealt
    //with appropriate delays to allow the user to read the text before it proceeds
    private void EnemyDamage(int amount) {
      TriggerTimedTextBoxUpdate(AttackUsedText(true), baseMillisecondDelay);
      enemy.AlterHealth(amount);
      UpdateHealthBars();
      TriggerTimedTextBoxUpdate(DamageTakenText(false, amount), baseMillisecondDelay);
    }

    private void PlayerDamage(int amount) {
      TriggerTimedTextBoxUpdate(AttackUsedText(false), baseMillisecondDelay);
      player.AlterHealth(amount);
      UpdateHealthBars();
      TriggerTimedTextBoxUpdate(DamageTakenText(true, amount), baseMillisecondDelay);
    }

    private void tmrFinalBattle_Tick(object sender, EventArgs e) {
      picBossBattle.Visible = false;
      tmrFinalBattle.Enabled = false;
    }

    //hanlde processing for the battle ending to trigger appropriate event based on winner and close out of battle properly
    private void BattleEndSequence(bool playerWon)
    {
      //events need to be removed at end. Else EVERY instance of player and enemy made will acculumalte across battles
      enemy.AttackEvent -= PlayerDamage;
      player.AttackEvent -= EnemyDamage;

      if (playerWon)
      {
        enemy.HandleLostInBattle();
      }
      else
      {
        player.HandleLostInBattle();
      }

      TriggerTimedTextBoxUpdate((playerWon ? player.CharacterName : enemy.CharacterName) + " won the battle.", baseMillisecondDelay);
      instance = null;
      Close();
    }
  }
}
