using HomeWork4.Domain.Helper;
using System;
using System.Collections.Generic;

namespace HomeWork4.Data.Models
{
    public class Character
    {
        public string CharacterName { get; set; }

        public double HealthPoints { get; set; }
        public double MaxHealthPoints { get; set; }

        public int ExperiencePoints { get; set; }
        public int MaxExperiencePoints { get; set; }

        public int Level { get; set; }

        public double Damage { get; set; }

		virtual public void GetExperience(int experience)
		{
			if (experience > 0)
			{
				Console.Write("You recieve ");
				PrintingFunction.Yellow("" + experience);
				Console.WriteLine(" experience.");
			}
			if (ExperiencePoints + experience < MaxExperiencePoints)
				ExperiencePoints += experience;
			else
			{
				Level++;
                MaxHealthPoints += 5;
				Damage += 2;
				HealthPoints = MaxHealthPoints;
				var leftoverExperience = (ExperiencePoints + experience) - MaxExperiencePoints;
				var experienceTillNextLevelUp = 0;
				MaxExperiencePoints += (Level - 1) * 5;
				if (MaxExperiencePoints > leftoverExperience)
					experienceTillNextLevelUp = MaxExperiencePoints - leftoverExperience;
				else
					experienceTillNextLevelUp = 0;
				PrintingFunction.Yellow("You leveled up!");
				Console.Write(" You are now level ");
				PrintingFunction.YellowB(" " + Level + " ");
				Console.Write(". Exp required until next level-up: ");
				PrintingFunction.Yellow(" " + experienceTillNextLevelUp);
				Console.WriteLine(".");

				GetExperience(leftoverExperience);
			}
		}

		virtual public void ChangeHealthPoints(double healthPointsChange)
		{
			if (HealthPoints + healthPointsChange > MaxHealthPoints)
				HealthPoints = MaxHealthPoints;
			else if (HealthPoints + healthPointsChange < 0)
				HealthPoints = 0;
			else
			{
				HealthPoints += healthPointsChange;
			}
		}
		virtual public double DealtDamage(Character hero, List<Character> list, int index)
		{
			var random = new Random();
			return (random.NextDouble() / 2 + 1 / 2);
		}
		virtual public double DealtDamage()
		{
			var random = new Random();
			return random.NextDouble() / 2 + 0.5;
		}
		virtual public void ChangeCharacterStatus()
		{
			Damage = 8;
			HealthPoints = 20;
			MaxHealthPoints = 20;
			Level = 1;
			ExperiencePoints = 0;
			MaxExperiencePoints = 10;
		}

		public override string ToString()
		{
			return $"Character name: {CharacterName}\nHP:{HealthPoints}/{MaxHealthPoints} \t LVL:{Level} XP:{ExperiencePoints}/{MaxExperiencePoints} \t ATT:{Damage} ";
		}
		public virtual void PrintStats()
		{
			Console.Write($"Character name: ");
			PrintingFunction.Yellow(CharacterName + "\n    ");
			PrintingFunction.RedB("  HP: " + HealthPoints + "/" + MaxHealthPoints + "  ");
			Console.Write("\t   ");
			PrintingFunction.YellowB("  LVL: " + Level + "  ");
			PrintingFunction.Yellow("   XP: " + ExperiencePoints + "/" + MaxExperiencePoints + "\t   ");
			PrintingFunction.DRed("ATT: " + Damage);
			Console.WriteLine();
		}

		public virtual void Portrait()
		{
		}
	}
}
