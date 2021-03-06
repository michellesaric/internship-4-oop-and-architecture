﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4
{
	class Warrior : Character
	{
		public override double DealtDamage()
		{
			Console.WriteLine("Possible attacks:");
			Console.Write("1 - regular attack\t  2 - Rage attack\nYour choice: ");
			switch (Program.ChoosingNumber(1, 2))
			{
				case 1:
					Console.Write("You deal ");
					PrintingFunction.DRed("" + (int)(base.DealtDamage() * Damage));
					Console.WriteLine(" damage.");
					return (int)(base.DealtDamage() * Damage);
				case 2:
					ChangeHealthPoints(-0.15 * MaxHealthPoints);
					Console.Write("You suffer ");
					PrintingFunction.Red("" + (int)(0.15 * MaxHealthPoints));
					Console.Write(" and deal ");
					PrintingFunction.DRed("" + (int)((base.DealtDamage() * 2 * Damage) + 0.15 * MaxHealthPoints));
					Console.WriteLine("damage.");
					return (int)(base.DealtDamage() * 2 * Damage) + 0.15 * MaxHealthPoints;
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
