using System;

namespace HomeWork4.Domain.Service
{
	public class Choice
    {
		public static int ChoosingNumber(int min, int max)
		{
			var number = 0;
			while (!int.TryParse(Console.ReadLine(), out number));
			return Math.Min(Math.Max(number, min), max);
		}
		public static string StringThatIsntNull()
		{
			var word = "";
			do
			{
				word = Console.ReadLine();
			}
			while (String.IsNullOrEmpty(word));
			return word;
		}
	}
}
