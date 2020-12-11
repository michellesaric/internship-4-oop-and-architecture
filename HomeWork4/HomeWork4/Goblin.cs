using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4
{
    class Goblin : Character
    {
        public void ChangeCharacterStatus(int level)
        {
            this.CharacterName = "Goblin";
            this.MaxHealthPoints = 5 + 3*level;
            this.HealthPoints = this.MaxHealthPoints;
            this.MaxExperiencePoints = 5 + 1 * level;
            this.Damage = 1 + level;
        }
        public override double DealtDamage(Character hero, List<Character> list, int index)
        {
            Console.WriteLine(this.CharacterName + " attacks, he deals " + this.Damage + " damage.");
            return this.Damage;
        }
    }
}
