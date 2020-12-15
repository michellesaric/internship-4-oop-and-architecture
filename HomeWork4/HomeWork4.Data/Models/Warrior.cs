using System;
using System.Collections.Generic;
using System.Text;
using HomeWork4.Domain.Helper;
using HomeWork4.Domain.Service;

namespace HomeWork4.Data.Models
{
	public class Warrior : Character
	{
		public override double DealtDamage()
		{
			var damage = (int)(base.DealtDamage() * Damage);
			Console.WriteLine("Possible attacks:");
			Console.Write("1 - regular attack\t  2 - Rage attack\nYour choice: ");
			switch (Choice.ChoosingNumber(1, 2))
			{
				case 1:
					Console.Write("You deal ");
					PrintingFunction.DRed("" + damage);
					Console.WriteLine(" damage.");
					return damage;
				case 2:
					ChangeHealthPoints(-0.15 * MaxHealthPoints);
					Console.Write("You suffer ");
					PrintingFunction.Red("" + (int)(0.15 * MaxHealthPoints));
					Console.Write(" and deal ");
					PrintingFunction.DRed("" + (damage * 2) + 0.15 * MaxHealthPoints);
					Console.WriteLine("damage.");
					return (damage * 2) + 0.15 * MaxHealthPoints;
				default:
					return 0;
			}
		}

		public override void ChangeCharacterStatus()
		{
			base.ChangeCharacterStatus();
			MaxHealthPoints *= 3;
			HealthPoints = MaxHealthPoints;
		}
		public override string ToString()
		{
			return $"{base.ToString()} \nSpecial attack: Sacrificing " + (0.15 * MaxHealthPoints) + " hp for " + Damage + (0.15 * MaxHealthPoints) + " bonus damage.";
		}
		public override void PrintStats()
		{
			base.PrintStats();
			Console.Write("     Special attack: Sacrificing ");
			PrintingFunction.Red("" + (0.15 * MaxHealthPoints));
			Console.Write(" hp for ");
			PrintingFunction.DRed("" + (Damage + (0.15 * MaxHealthPoints)));
			Console.WriteLine(" bonus damage.");
		}
	}
}
