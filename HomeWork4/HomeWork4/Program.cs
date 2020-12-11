using HomeWork4;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4
{
	class Program
	{
		static void Main(string[] args)
		{
			var willYouPlayAgain = "yes";
			do
			{
				Console.WriteLine("Welcome to the D&D dungeon, where you will attempt to beat it with your character, or die trying...");
				Console.Write("Choose the class your character has:\n1 = ranger\n2 = warrior\n3 = mage\nYour choice: ");
				var choice = ChoosingNumber(1, 3);
				Console.Write("Choose the name of your mighty champion: ");
				switch (choice)
				{
					case 1:
						var ranger = new Ranger();
						ranger.CharacterName = Console.ReadLine();
						CourseOfTheAdventure(ranger);
						break;
					case 2:
						var warrior = new Warrior();
						warrior.CharacterName = Console.ReadLine();
						CourseOfTheAdventure(warrior);
						break;
					case 3:
						var mage = new Mage();
						mage.CharacterName = Console.ReadLine();
						CourseOfTheAdventure(mage);
						break;
					default:
						break;
				}
                Console.WriteLine("Type yes to play again: ");
				willYouPlayAgain = Console.ReadLine();
			} while (willYouPlayAgain.ToLower() == "yes");
			Console.WriteLine("ty for playing my game! UwU");
			Console.ReadLine();
		}

		public static int ChoosingNumber(int min, int max)
		{
			var number = 0;
            while (!int.TryParse(Console.ReadLine(),out number));
			return Math.Clamp(number, min, max);
		}

		public static void CourseOfTheAdventure(Character hero)
		{
			Console.WriteLine("You are going on your adventure!");
			var i = 0;
			var listOfEnemies = new List<Character>();
            FillingUpTheListOfEnemies(listOfEnemies);
			hero.ChangeCharacterStatus();
			for (i = 0; i < listOfEnemies.Count-1; i++)
			{
				if ((listOfEnemies[i]).GetType() != (new Minion()).GetType())
				{
					Console.Write("\t\t\t\t\t\t\t\t\tType i for stats:");
					if ((Console.ReadLine()).ToLower() == "i")
					{
						Console.WriteLine("Here are your current stats!:\n" + hero.ToString());

					}
					hero = Fight(hero, listOfEnemies, i);
				}
				else { }
				if (hero.HealthPoints <= 0)
					break;
			}
			if (i == listOfEnemies.Count) Console.WriteLine("\n\nCongrats you beat the game! ");
			else Console.WriteLine("\n\nYou died... ");
			Console.WriteLine("You passed {0} enemies.", i);
			
        }
		public static void FillingUpTheListOfEnemies(List<Character> list) 
		{
			Random random = new Random();
			for (var i = 0; i < 11; i++)
            {
				var level = random.Next(5) + 1;
				var chance = random.Next(100);
				if(chance > 90)
                {
					var witch = new Witch();
					witch.ChangeCharacterStatus(level);
					list.Add(witch);
					var minion1 = new Minion();
					minion1.ChangeCharacterStatus(level);
					list.Add(minion1);
					var minion2 = new Minion();
					minion2.ChangeCharacterStatus(level);
					list.Add(minion2);

				} 
				else if(chance > 50)
                {
					var brute = new Brute();
					brute.ChangeCharacterStatus(level);
					list.Add(brute);
                }
				else
                {
					var goblin = new Goblin();
					goblin.ChangeCharacterStatus(level);
					list.Add(goblin);
                }

            }
		}
		public static Character Fight(Character hero, List<Character> list, int indexOfEnemy)
        {
			var random = new Random();
			Console.WriteLine("\n\nYou spot a {0}. Its an enemy creature.", list[indexOfEnemy].CharacterName);
			while(hero.HealthPoints>0)
			{
				Console.WriteLine("Enemy has {0} health remaining, and you have {1} health remaining", (int)list[indexOfEnemy].HealthPoints, (int)hero.HealthPoints);
				Console.WriteLine("Possible attacks:");
				Console.WriteLine("1 - Direct attack\n2 - Attack from the side\n3 - Counterattack\n");
				Console.Write("Choose your attack: ");
				var choice = ChoosingNumber(1, 3);
				var number = random.Next(3) + 1;
                Console.WriteLine();
				if (choice == number)
				{
					Console.WriteLine("You both tripped, nothing happens!");
				}
				else if ((choice == 1 && number == 2) || (choice == 2 && number == 3) || (choice == 3 && number == 1))
				{
					Console.WriteLine("The enemy outsmarted you and deals damage...");
					hero.ChangeHealthPoints(-list[indexOfEnemy].DealtDamage(hero, list, indexOfEnemy));
				}
				else
				{
					Console.WriteLine("You have outsmarted the enemy and you deal damage...");
					list[indexOfEnemy].ChangeHealthPoints(-hero.DealtDamage());
				}
				if (hero.HealthPoints <= 0)
				{
					Console.WriteLine("\n");
					break;
				}
				if (list[indexOfEnemy].HealthPoints <= 0)
				{
                    Console.WriteLine("You killed the enemy!\n\n");
					if ((list[indexOfEnemy + 1]).GetType() != (new Minion()).GetType())
					{
						break;
					}
					else
					{
						hero = Fight(hero, list, indexOfEnemy + 1);
						break;
					}
				}
			}

			if (hero.HealthPoints <= 0)
				hero.HealthPoints = 0;
			else if (list[indexOfEnemy].HealthPoints <= 0)
			{
				hero.ChangeHealthPoints(0.25 * hero.MaxHealthPoints);
				hero.GetExperience(list[indexOfEnemy].MaxExperiencePoints);
			}
			return hero;
		}
	}
}


