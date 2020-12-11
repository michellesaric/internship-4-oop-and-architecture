using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4
{
    class Minion : Character
    {
        public void ChangeCharacterStatus(int level)
        {
            this.CharacterName = "Minion";
            this.MaxHealthPoints = 5 + 3 * level;
            this.HealthPoints = this.MaxHealthPoints;
            this.MaxExperiencePoints = 0;
            this.Damage = 1 + 1 * level;
        }
        public override double DealtDamage(Character hero, List<Character> list, int index)
        {
            Console.WriteLine(this.CharacterName + " attacks with his weak little hands, he deals " + this.Damage + " damage.");
            return this.Damage;
        }
    }
}
