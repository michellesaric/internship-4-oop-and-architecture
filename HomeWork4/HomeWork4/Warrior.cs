using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4
{
	class Warrior : Character
	{
		public override double DealtDamage()
		{
			Console.WriteLine("Possible attacks:");
			Console.Write("For a regular attack, choose 1, and for the Rage attack, choose 2: ");
			switch (Program.ChoosingNumber(1, 2))
			{
				case 1:
					return this.Damage;
				case 2:
					this.ChangeHealthPoints(-0.15 * MaxHealthPoints);
					return 2 * this.Damage + (0.15 * MaxHealthPoints);
				default:
					return 0;
			}
		}

		public override void ChangeCharacterStatus()
		{
			base.ChangeCharacterStatus();
			this.MaxHealthPoints *= 2;
			this.Damage /= 2;
			this.HealthPoints = this.MaxHealthPoints;
		}
		public override string ToString()
		{
			return $"{base.ToString()} \nExtra option for attack: Sacrificing hp for extra damage.";
		}
	}
}
