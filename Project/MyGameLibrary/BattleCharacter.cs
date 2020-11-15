using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code {
  public abstract class BattleCharacter : Character {
    public int Health { get; private set; }
    public int MaxHealth { get; private set; }
    private float strength;
    private string characterName;
    public string CharacterName { get => characterName; }
    private string attackName;
    public string AttackName{get => attackName; }

    public event Action<int> AttackEvent;

    public BattleCharacter(Vector2 initPos, Collider collider, string charName, string charAttackName) : base(initPos, collider) {
      MaxHealth = 20;
      strength = 2;
      Health = MaxHealth;
      characterName = charName;
      attackName = charAttackName;
    }

    //character processing when a character loses in battle depends on the character type (player or enemy)
    public abstract void HandleLostInBattle();

    public void OnAttack(int amount) {
      AttackEvent((int)(amount * strength));
    }

    public void AlterHealth(int amount) {
      Health += amount;
    }
  }
}
