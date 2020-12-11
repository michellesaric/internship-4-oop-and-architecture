using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4
{
    class Ranger : Character
    {
        public override double DealtDamage()
        {
            var random = new Random();
            var totalDamage = this.Damage;
            var criticalChance = random.Next(100);
            var stunChance = random.Next(100);
            var newAttack = 0.0;
            if (criticalChance < this.Level*5)
            {
                Console.WriteLine("Critical success!! You deal double the normal damage!");
                totalDamage = this.Damage * 2;
            }
            if (stunChance < this.Level + 2)
            {
                Console.WriteLine("You stunned the enemy, you get an extra attack!");
                newAttack=this.DealtDamage();
                totalDamage += newAttack;
            }
            Console.WriteLine("You deal {0} damage!", totalDamage- newAttack);
            return totalDamage;
        }
        public override void ChangeCharacterStatus()
        {
            base.ChangeCharacterStatus();
        }
        public override string ToString()
        {
            return $"{base.ToString()} \nCritChance: {this.Level * 5} \t StunChance: {this.Level + 2}";
        }
    }
}
