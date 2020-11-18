using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Player : BattleCharacter {

    public delegate void TriggerPlayerLost();
    public static event TriggerPlayerLost PlayerLost;
    public Player(Vector2 initPos, Collider collider, string charName, string charAttackName, System.Windows.Forms.PictureBox pictureBox) : base(initPos, collider, charName, charAttackName, pictureBox)
    {
    }

    //processing when the player loses in battle has not been confirmed yet with project owner. For now, simply close the game entirely
    public override void HandleLostInBattle()
    {
      PlayerLost?.Invoke();
    }
  }
}
