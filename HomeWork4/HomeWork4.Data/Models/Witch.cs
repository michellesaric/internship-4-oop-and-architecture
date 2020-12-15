using HomeWork4.Domain.Helper;
using System;
using System.Collections.Generic;

namespace HomeWork4.Data.Models
{
    public class Witch : Character
    {
        public void ChangeCharacterStatus(int level)
        {
            CharacterName = "Witch";
            MaxHealthPoints = 15 + 3 * level;
            HealthPoints = MaxHealthPoints;
            MaxExperiencePoints = 20 + 5 * level;
            Damage = 5 + 3 * level;
        }
        public override double DealtDamage(Character hero, List<Character> list, int index)
        {
            var random = new Random();
            var chanceOfDumbus = random.Next(100);
            if (chanceOfDumbus < 10 + Level)
            {

                hero.HealthPoints = random.Next((int)hero.MaxHealthPoints) + 1;
                for (var i = index; i < list.Count; i++)
                {
                    list[i].HealthPoints = random.Next((int)list[i].MaxHealthPoints) + 1;
                }
                PrintingFunction.Yellow("Đ");
                PrintingFunction.Red("U");
                PrintingFunction.Magenta("M");
                PrintingFunction.Blue("B");
                PrintingFunction.Green("U");
                PrintingFunction.Cyan("S");
                PrintingFunction.Yellow("!\n");
                return 0;
            }
            var damage = (int)(base.DealtDamage() * Damage);
            Console.Write(CharacterName + " deals ");
            PrintingFunction.DRed("" + damage);
            Console.WriteLine(" damage.");
            return damage;
        }

        public override void Portrait()
        {
            Console.WriteLine("                                      /-                                       ");
            Console.WriteLine("                                      /No`                                     ");
            Console.WriteLine("                                      `mNNo.                                   ");
            Console.WriteLine("                                       .mNNNdo-                                ");
            Console.WriteLine("                                        .dNNNmmh-                              ");
            Console.WriteLine("                                         hMNNNNNN+                             ");
            Console.WriteLine("                                         :MNNNNNNNs                            ");
            Console.WriteLine("                                         `MNNNNNNNNy                           ");
            Console.WriteLine("                                         /NNNNNNNNNNh                          ");
            Console.WriteLine("                                        +NNNNNNNNNNNNh`                        ");
            Console.WriteLine("                                        oNNNNNNNNNNNNMNNMMMMMNNmho.            ");
            Console.WriteLine("                                      `-sNNNNNNMMm+/+mMMm+..`                  ");
            Console.WriteLine("                                  -+ymMMMMMMMMMMNhso+///h/`                    ");
            Console.WriteLine("                               `sNMmdyo/NMMMMmNdyss+oy--/`                     ");
            Console.WriteLine("                              `+dmdyo+:oMMMMNysos+:++/--`--:`                  ");
            Console.WriteLine("                             `sNMMNNNMMMMMMMMm+/:yo//+s//-.`/                  ");
            Console.WriteLine("                            +NNMNNNMMMMMMMMMhs+++MddN/`  -/-/                  ");
            Console.WriteLine("                       `.  /+`hNNMMMMMMMMMMMo+++::/+o/.   `.                   ");
            Console.WriteLine("                       h-  ..`NMMMMMMMMMMMMmhohds/-:/o                         ");
            Console.WriteLine("                       hh.`-/hMMNMMMMMMNNNNNdy:.`:+o+:                         ");
            Console.WriteLine("                       .yddmMMNs/dNMMMMMNNNNNy                                 ");
            Console.WriteLine("                           ++:omMMMMMMMMMMNmmmd:                               ");
            Console.WriteLine("                             yMMMMMMMMMMMMMMNNmmh+`                            ");
            Console.WriteLine("                             hMMMMMMMMMMMNh:-odNNmmh+:`                        ");
            Console.WriteLine("                             oMMMMMMMMoNMM/    `/ymNNNNmhso/:-.`           `-:/");
            Console.WriteLine("                             .MMMMMMMd..mMMs       -odNNNNNNmNNmhs//:--:/+ssys+");
            Console.WriteLine("                            :oMMMMMMMMm/.NMMd.        .omNNNNddoooymhhyso+:-   ");
            Console.WriteLine("                            :MMMMMMMMMMNs:MMMN/      `-:/hmhyhddhhdy.`         ");
            Console.WriteLine("                           :NMMMNNNNNNNNmdmNNMMh/:+osssss+/-. `++:.            ");
            Console.WriteLine("                          -MMMNMdhmmmmmmmmmmmmmmdmdmNm+`                       ");
            Console.WriteLine("                          oMMMNMMNmmNNNNmmmmmmmmmmNNNMMd                       ");
            Console.WriteLine("  -:://::::::::::ooy/-    .ymNmNNNMMMMMNNNNNNNmNNNNNNNNs                       ");
            Console.WriteLine("`:dmhsooo++//+++oosyhysshmyysyyohMMMMMMMMMMMMMMNMNNNNNMd`                      ");
            Console.WriteLine(":dyso////++++++++oosssyhmds:.  +MMMMMMMMMMMMMMMMMMMMMMo                        ");
            Console.WriteLine("/ddyso+/////:////:++syyho    .hMMMMMMMMMMMMMMMMMMMMMy.                         ");
            Console.WriteLine("-yhs+:/++/++/::/+o+oss+/`  .sMMMMMMMMMMMMMMMMMMMMMy.                           ");
            Console.WriteLine(".ymyyys+///:+o+o++++/.  `/hMMMMMMMMMMMMMMMMMMMMMh-                             ");
            Console.WriteLine(" .yhyso+++/+++///+/. `+hMMMMMMMMMMMMMMMMMMMMMMy-                               ");
            Console.WriteLine("   /ddys+/o+o++/- .+dMMMMMMMMMMMMMMMMMMMMMMMy.                                 ");
            Console.WriteLine("   `+dhyyhss/-``+dMMMMMMMMMMMMMMMMMMMMMMMMy.                                   ");
            Console.WriteLine("     .:/y+-   oNMMMMMMMMMMMMyNMMMMMMMMMms.                                     ");
            Console.WriteLine("              dMMMMMMMMMMNy-:++++//:-.                                         ");
            Console.WriteLine("             +MMMMNMmy+--                                                      ");
            Console.WriteLine("              hMo .`                                                           ");
            Console.WriteLine();
        }
    }
}
