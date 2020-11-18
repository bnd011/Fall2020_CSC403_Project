using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.code {
  /// <summary>
  /// This is the class for an enemy
  /// </summary>
  public class Enemy : BattleCharacter {
    /// <summary>
    /// THis is the image for an enemy
    /// </summary>
    public Image Img { get; set; }

    /// <summary>
    /// this is the background color for the fight form for this enemy
    /// </summary>
    public Color Color { get; set; }
        public Point Location { get; set; }

        //observer pattern event to notify systems when an enemy was removed
        public delegate void TriggerEnemyLostInBattle(Enemy defeatedEnemy);
    public static event TriggerEnemyLostInBattle EnemyLostInBattle;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="initPos">this is the initial position of the enemy</param>
    /// <param name="collider">this is the collider for the enemy</param>
    /// <param name="charName">the name of this character</param>
    /// <param name="charAttackName">each char has one move, this is its name</param>
    public Enemy(Vector2 initPos, Collider collider, string charName, string charAttackName, PictureBox pictureBox) : base(initPos, collider, charName, charAttackName, pictureBox) {
    }

    //when an enemy loses in battle, that instance should be removed and an event triggered to notify other systems
    public override void HandleLostInBattle()
    {
      EnemyLostInBattle?.Invoke(this);
      RemoveCharacterFromView();
    }
  }
}
