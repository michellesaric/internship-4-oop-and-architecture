using HomeWork4.Domain.Helper;
using System;
using HomeWork4.Domain.Service;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4.Data.Models
{
    public class Mage : Character
    {
		public int Mana { get; set; }
		public int MaxMana { get; set; }

		public bool ExtraLife = true;

		public override double DealtDamage()
		{
			var damage = 0.0;
			Console.WriteLine("Possible actions:");
			Console.Write("1 - Attack without using mana\t2 - Attack with mana\t3 - Healing with mana\n Your choice: ");
			switch (Choice.ChoosingNumber(1, 3))
			{
				case 1:
					Console.Write("You deal ");
					damage = (int)(base.DealtDamage() * Damage);
					PrintingFunction.DRed("" + damage);
					Console.WriteLine(" damage.");
					return damage;
				case 2:
					if (Mana == 0)
					{
						Console.WriteLine("You spend the turn gathering mana.");
                        Mana = MaxMana;
						return 0;
					}
					Mana--;
					Console.Write("You deal ");
					PrintingFunction.DRed("" + 2 * Damage);
					Console.WriteLine(" damage.");
					return 2 * Damage;
				case 3:
					if (Mana == 0)
					{
						Console.WriteLine("You spend the turn gathering mana.");
						Mana = MaxMana;
						return 0;
					}
					Console.Write("You have ");
					PrintingFunction.Blue("" + Mana);
					Console.Write(" mana.How much mana do you want to use:");
					var health = HealthPoints;
					var heal = (int)(base.DealtDamage() * (10 * Choice.ChoosingNumber(1, Mana)));
					ChangeHealthPoints(heal);
					Console.Write("You got healed by ");
					PrintingFunction.Red("" + (int)(HealthPoints - health));
					Console.WriteLine(" points.");
					return 0;
				default:
					return 0;
			}
		}

		public override void ChangeCharacterStatus()
		{
			base.ChangeCharacterStatus();
			Damage *= 3;
			Mana = 4;
			MaxMana = 4;
		}

		public override void GetExperience(int experience)
		{
			var level = Level;
			base.GetExperience(experience);
			if (level != Level)
			{
				MaxMana *= 2;
				Mana = MaxMana;
			}
			Damage += 2;
		}

		public override void ChangeHealthPoints(double healthPointsChange)
		{
			base.ChangeHealthPoints(healthPointsChange);
			if (HealthPoints == 0 && ExtraLife)
			{
				var random = new Random();
				if (random.Next(2) < 1)
				{
					Console.WriteLine("Unfortunatelly you died... BUT YOU LIVED");
					ExtraLife = false;
					HealthPoints = MaxHealthPoints;
					Mana = MaxMana;
				}
			}
		}
		public override string ToString()
		{
			return $"{base.ToString()} \n MP: {Mana}/{MaxMana} \tMana usage: Extra damage or heal.";
		}

		public override void PrintStats()
		{
			base.PrintStats();
			Console.Write("    ");
			PrintingFunction.BlueB("  MP: " + Mana + "/" + MaxMana + "  ");
			Console.Write("\t  Mana uses: ");
			PrintingFunction.Blue("Extra damage");
			Console.Write(" or ");
			PrintingFunction.Blue("heal");
			Console.WriteLine(".");
		}
	}
}
