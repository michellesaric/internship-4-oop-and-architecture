using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4
{
    class Witch : Character
    {
        public void ChangeCharacterStatus(int level)
        {
            this.CharacterName = "Witch";
            this.MaxHealthPoints = 15 + 2 * level;
            this.HealthPoints = this.MaxHealthPoints;
            this.MaxExperiencePoints = 20 + 1 * level;
            this.Damage = 5 + 3 * level;
        }
        public override double DealtDamage(Character hero, List<Character> list, int index)
        {
            var random = new Random();
            var chanceOfDumbus = random.Next(100);
            if (chanceOfDumbus < 10 + this.Level)
            {
                    
                hero.HealthPoints = random.Next((int)hero.MaxHealthPoints) + 1;
                for (var i = index; i < list.Count; i++)
                {
                    list[i].HealthPoints = random.Next((int)list[i].MaxHealthPoints) + 1;
                }
                Console.WriteLine("Đumbus!");
                return 0;
            }
            Console.WriteLine("The Witch has dealt " + this.Damage + " damage!");
            return this.Damage;
        }
    }
}
