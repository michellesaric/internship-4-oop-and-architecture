using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace HomeWork4.Domain.Helper
{
    public static class PrintingFunction
    {
        public static void Red(string inputString)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(inputString);
            Console.ResetColor();
        }

        public static void Cyan(string inputString)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(inputString);
            Console.ResetColor();
        }

        public static void Magenta(string inputString)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(inputString);
            Console.ResetColor();
        }

        public static void DMagenta(string inputString)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(inputString);
            Console.ResetColor();
        }

        public static void DRed(string inputString)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(inputString);
            Console.ResetColor();
        }

        public static void RedB(string inputString)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(inputString);
            Console.ResetColor();
        }

        public static void Blue(string inputString)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(inputString);
            Console.ResetColor();
        }
        public static void BlueB(string inputString)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(inputString);
            Console.ResetColor();
        }

        public static void Yellow(string inputString)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(inputString);
            Console.ResetColor();
        }

        public static void YellowB(string inputString)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(inputString);
            Console.ResetColor();
        }

        public static void DYellow(string inputString)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(inputString);
            Console.ResetColor();
        }

        public static void Green(string inputString)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(inputString);
            Console.ResetColor();
        }

        public static void WhiteLinePrint()
        {
            string empty = "";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(empty.PadRight(Console.WindowWidth - 1));
            Console.ResetColor();
        }
    }
}
