using System;
using System.Collections.Generic;

namespace HomeWork4
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
            if(experience>0)
				Console.WriteLine("You recieve " + experience + " experience.");
			if (this.ExperiencePoints + experience < this.MaxExperiencePoints)
				this.ExperiencePoints += experience;
			else
			{
				this.Level++;
				this.MaxHealthPoints += 5;
				this.Damage += 2;
				this.HealthPoints = this.MaxHealthPoints;
				var leftoverExperience = (this.ExperiencePoints + experience) - this.MaxExperiencePoints;
				var experienceTillNextLevelUp = 0;
				this.MaxExperiencePoints += (this.Level-1) * 5;
				if (this.MaxExperiencePoints > leftoverExperience)
					experienceTillNextLevelUp = this.MaxExperiencePoints-leftoverExperience;
				else
					experienceTillNextLevelUp = 0;
				Console.WriteLine("You leveled up! You are now level " + Level + ". " +
					"Exp required until next level-up: " + experienceTillNextLevelUp + ".");
				this.GetExperience(leftoverExperience);
			}
		}

		virtual public void ChangeHealthPoints(double healthPointsChange)
		{
			if (this.HealthPoints + healthPointsChange > this.MaxHealthPoints)
				this.HealthPoints = this.MaxHealthPoints;
			else if (this.HealthPoints + healthPointsChange < 0)
				this.HealthPoints = 0;
			else
			{
				this.HealthPoints += healthPointsChange;
			}
		}
		virtual public double DealtDamage(Character hero, List<Character> list, int index)
        {
			return 0;
        }
		virtual public double DealtDamage()
		{
			return 0;
		}
		virtual public void ChangeCharacterStatus()
        {
			this.Damage = 8;
			this.HealthPoints = 20;
			this.MaxHealthPoints = 20;
			this.Level = 1;
			this.ExperiencePoints = 0;
			this.MaxExperiencePoints = 10;
		}

		public override string ToString()
        {
			return $"Character name: {CharacterName}\nHP:{HealthPoints}/{MaxHealthPoints} \t LVL:{Level} XP:{ExperiencePoints}/{MaxExperiencePoints} \t ATT:{Damage} ";
        }
    }
}
