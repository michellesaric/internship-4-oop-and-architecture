using HomeWork4;
using HomeWork4.Data.Models;
using HomeWork4.Domain.Helper;
using HomeWork4.Domain.Service;
using System;
using System.Collections.Generic;

namespace HomeWork4.Presentation
{
    class Program
	{
		static int TimesRun = 0;
		static void Main(string[] args)
		{
			var willYouPlayAgain = "yes";
			do
			{
				Console.WriteLine("Welcome to the D&D dungeon, where you will attempt to beat it with your character, or die trying...");
				Console.Write("Choose the class your character has:\n1 = ranger\n2 = warrior\n3 = mage\nYour choice: ");
				var choice = Choice.ChoosingNumber(1, 3);
				Console.Write("Choose the name of your mighty champion: ");
				switch (choice)
				{
					case 1:
						var ranger = new Ranger
						{
							CharacterName = Choice.StringThatIsntNull()
						};
						CourseOfTheAdventure(ranger);
						break;
					case 2:
						var warrior = new Warrior
						{
							CharacterName = Choice.StringThatIsntNull()
						};
						CourseOfTheAdventure(warrior);
						break;
					case 3:
						var mage = new Mage
						{
							CharacterName = Choice.StringThatIsntNull()
						};
						CourseOfTheAdventure(mage);
						break;
					default:
						break;
				}
				Console.WriteLine("Type yes to play again: ");
				willYouPlayAgain = Console.ReadLine();
			} while (willYouPlayAgain.ToLower() == "yes");
			Console.WriteLine("ty for playing my game!");
			Console.ReadLine();
			Environment.Exit(1);
		}

		public static void CourseOfTheAdventure(Character hero)
		{
			var i = 0;
			var listOfEnemies = new List<Character>();
			Console.Write("Choose the number of enemies you want to beat: ");
			var numberOfEnemies = Choice.ChoosingNumber(1, int.MaxValue);
			FillingUpTheListOfEnemies(listOfEnemies, numberOfEnemies);
			Console.WriteLine("You are going on your adventure!");
			hero.ChangeCharacterStatus();
			for (i = 0; i < listOfEnemies.Count; i++)
			{
				if ((listOfEnemies[i]).GetType() != (new Minion()).GetType())
				{
					Domain.Helper.PrintingFunction.WhiteLinePrint();
					Console.Write("\t\t\t\t\t\t\tType i for stats:");
					if ((Console.ReadLine()).ToLower() == "i")
					{
						Console.WriteLine("Here are your current stats!:\n");
						hero.PrintStats();
						Console.ReadLine();
						PrintingFunction.WhiteLinePrint();
					}
					hero = Fight(hero, listOfEnemies, i);
				}
				else { }
				if (hero.HealthPoints <= 0)
					break;
			}
			if (i == listOfEnemies.Count)
				Console.WriteLine("\n\nCongrats you beat the game! ");
			else
				Console.WriteLine("\n\nYou died... ");
			Console.WriteLine("You defeated {0} enemies, {1} of which were summons.", i - TimesRun, (i - TimesRun) - numberOfEnemies);
			if (TimesRun == 0)
				Console.WriteLine("You never ran, if there was a gold medal for playing the game you would have it!!");

		}
		public static void FillingUpTheListOfEnemies(List<Character> list, int numberOfEnemies)
		{
			Random random = new Random();
			for (var i = 0; i < numberOfEnemies; i++)
			{
				var level = random.Next((int)(i * 2 / 3)) + 1;
				var chance = random.Next(100);
				if (chance > 90)
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
				else if (chance > 60)
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
			var choice = 0;
			Console.WriteLine("\nYou spot a {0}. Its an enemy creature.\n", list[indexOfEnemy].CharacterName);
			list[indexOfEnemy].Portrait();
			while (hero.HealthPoints > 0)
			{
				Console.Write("Enemy has ");
				PrintingFunction.RedB("" + (int)list[indexOfEnemy].HealthPoints);
				Console.Write(" health remaining, and you have ");
				PrintingFunction.RedB("" + (int)hero.HealthPoints);
				Console.WriteLine(" health remaining.\nPossible attacks:");
				if ((list[indexOfEnemy]).GetType() == (new Minion()).GetType())
				{
					Console.WriteLine("1 - Direct attack\t2 - Attack from the side\t3 - Counterattack");
					Console.Write("Choose your attack: ");
					choice = Choice.ChoosingNumber(1, 3);
				}
				else
				{
					Console.WriteLine("1 - Direct attack\t2 - Attack from the side\t3 - Counterattack\t4 - Run");
					Console.Write("Choose your attack: ");
					choice = Choice.ChoosingNumber(1, 4);
				}
				if (choice == 4)
				{
					Console.Write("Enemy tries to attack you... ");
					if (random.Next(100) < 50)
					{
						Console.WriteLine("Attack was unfortunately successful. ");
						hero.ChangeHealthPoints(-list[indexOfEnemy].DealtDamage(hero, list, indexOfEnemy));
					}
					else
					{
						Console.WriteLine("And it failed.");
					}
					Console.WriteLine("The same monster awaits later down your journey...");
					list.Add(list[indexOfEnemy]);
					TimesRun++;
					return hero;
				}
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
					try
					{
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
					catch
					{
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


