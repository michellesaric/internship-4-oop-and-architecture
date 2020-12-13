using System;
using HomeWork4.Domain.Helper;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4.Data.Models
{
    public class Ranger : Character
    {
        public override double DealtDamage()
        {
            var random = new Random();
            var totalDamage = base.DealtDamage() * Damage;
            var criticalChance = random.Next(100);
            var stunChance = random.Next(100);
            var newAttack = 0.0;
            if (criticalChance < (Level * 5) % 100)
            {
                Console.WriteLine("Critical success!! You deal {0}x the normal damage!", 2 + (Level * 5) / 100);
                totalDamage = base.DealtDamage() * Damage * (2 + (Level * 5) / 100);
            }
            Console.Write("You deal ");
            PrintingFunction.DRed("" + (int)(totalDamage));
            Console.WriteLine(" damage.");
            if (stunChance < Level + 2)
            {
                Console.WriteLine("You stunned the enemy, you get an extra attack!");
                newAttack = DealtDamage();
                totalDamage += newAttack;
            }
            return (int)totalDamage;
        }
        public override void ChangeCharacterStatus()
        {
            base.ChangeCharacterStatus();
            Damage *= 1.5;
            MaxHealthPoints *= 1.5;
            HealthPoints = MaxHealthPoints;
        }
        public override string ToString()
        {
            return $"{base.ToString()} \nCritChance: {Level * 5} \t StunChance: {Level + 2}";
        }
        public override void PrintStats()
        {
            base.PrintStats();
            Console.Write("     CritChance: ");
            PrintingFunction.Magenta("" + (Level * 5));
            Console.Write("\t StunChance: ");
            PrintingFunction.DMagenta("" + (Level + 2));
            Console.WriteLine("");
        }
    }
}
