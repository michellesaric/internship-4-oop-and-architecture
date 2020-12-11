using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4
{
    class Brute : Character
    {
        public override double DealtDamage(Character hero, List<Character> list, int index)
        {
            var random = new Random();
            var percentageDamageChance = random.Next(100);
            if (percentageDamageChance < this.Level * 5)
            {
                Console.WriteLine("Brute does critical damage!!");
                Console.WriteLine(this.CharacterName + " deals " + hero.MaxHealthPoints * 0.25 + " damage.");
                return hero.MaxHealthPoints * 0.25;
            }
            Console.WriteLine(this.CharacterName + " attacks, he deals " + this.Damage + " damage.");
            return this.Damage;
        }

        public void ChangeCharacterStatus(int level)
        {
            this.CharacterName = "Brute";
            this.MaxHealthPoints = 10 + 5 * level;
            this.HealthPoints = this.MaxHealthPoints;
            this.MaxExperiencePoints = 15 + 5 * level;
            this.Damage = 2 + 2 * level;
        }
    }
}
