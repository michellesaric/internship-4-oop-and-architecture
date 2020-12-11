using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4
{
    class Mage : Character
    {
		public int Mana { get; set; }
		public int MaxMana { get; set; }

		public bool ExtraLife = true;
		public override double DealtDamage()
		{
            Console.WriteLine("Possible actions:");
            Console.Write("1 - Attack without using mana\t2 - Attack with mana\t3 - Healing with mana\n Your choice: ");

			switch (Program.ChoosingNumber(1, 3))
			{
				case 1:
					return this.Damage;
				case 2:
					if (this.Mana == 0)
						return 0;
					this.Mana--;
					return 2 * this.Damage;
				case 3:
					if (this.Mana == 0)
						return 0;
                    Console.WriteLine("You have " + this.Mana + " mana.");
                    Console.WriteLine("How much mana do you want to use?");
					this.ChangeHealthPoints(10*Program.ChoosingNumber(1, this.Mana));
					return 0;
				default:
					return 0;
			}
		}

	    public override void ChangeCharacterStatus()
		{
			base.ChangeCharacterStatus();
			this.MaxHealthPoints /= 2;
			this.Damage = this.Damage *= 1.5;
			this.HealthPoints = this.MaxHealthPoints;
			this.Mana = 4;
			this.MaxMana = 4;
		}

		public override void GetExperience(int experience)
		{
			var level = this.Level;
			base.GetExperience(experience);
			if (level != this.Level)
			{
				this.MaxMana *= 2;
				this.Mana = this.MaxMana;
			}
		}

		public override void ChangeHealthPoints(double healthPointsChange)
		{
			base.ChangeHealthPoints(healthPointsChange);
			if (this.HealthPoints == 0 && this.ExtraLife)
			{
				var random = new Random();
				if (random.Next(2) < 1)
				{
					Console.WriteLine("Unfortunatelly you died... BUT YOU LIVED");
					this.ExtraLife = false;
					this.HealthPoints = this.MaxHealthPoints;
					this.Mana = this.MaxMana;
				}
			}
		}
            public override string ToString()
			{            
				return $"{base.ToString()} \n MP{Mana}/{MaxMana} \tMana usage: Extra damage or heal.";
			}
    }
}
