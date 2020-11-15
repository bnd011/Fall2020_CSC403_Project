using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Player : BattleCharacter {
    public Player(Vector2 initPos, Collider collider, string charName, string charAttackName) : base(initPos, collider, charName, charAttackName)
    {
    }

    //processing when the player loses in battle has not been confirmed yet with project owner. For now, simply close the game entirely
    public override void HandleLostInBattle()
    {

    }
  }
}
