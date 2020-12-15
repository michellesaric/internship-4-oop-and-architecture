using HomeWork4.Domain.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4.Data.Models
{
    public class Goblin : Character
    {
        public void ChangeCharacterStatus(int level)
        {
            CharacterName = "Goblin";
            MaxHealthPoints = 5 + 2 * level;
            HealthPoints = MaxHealthPoints;
            MaxExperiencePoints = 2 + 1 * level;
            Damage = 1 + level;
        }
        public override double DealtDamage(Character hero, List<Character> list, int index)
        {
            var damage = (int)(base.DealtDamage() * Damage);
            Console.Write(CharacterName + " deals ");
            PrintingFunction.DRed("" + (int)(base.DealtDamage() * Damage));
            Console.WriteLine(" damage.");
            return damage;
        }

        public override void Portrait()
        {
            Console.WriteLine("                               .`-/:/++//-`     `.`                            ");
            Console.WriteLine("                      -:-`   .:/oosssoossss/ .:+++.`                           ");
            Console.WriteLine("                       +//:.:/osss//++/oyhsy++ossssy-                          ");
            Console.WriteLine("                       -o:+o-ooysy+//y+oyssso+syssssy.                         ");
            Console.WriteLine("                       .++/s:hdsoss:+ysoosss/+oo+++s+`                         ");
            Console.WriteLine("                    ``  :+/o+oh:+osso+o+/oyy/:.:oso+                           ");
            Console.WriteLine("                   :+sso-:o//+s+oyyysshsosyy:`  .s+                            ");
            Console.WriteLine("                  -oshsss``./osoooosssssyyys+//-.oo-                           ");
            Console.WriteLine("                  -o//o+o:   `-+ss+ossyso++ss/++s/++                           ");
            Console.WriteLine("                   ` `--/+:.` `/o+oooo++++oss `-:/+.                           ");
            Console.WriteLine("                         ./+++++-++++///++shy                                  ");
            Console.WriteLine("                          `-:/-` .ysooosyhdmm/                                 ");
            Console.WriteLine("                                -sdddddmmmNNNNy`                               ");
            Console.WriteLine("                              -ydddddmmmmNNNNNNh`                              ");
            Console.WriteLine("                             `oydyshhyhyhyhyhmyyo                              ");
            Console.WriteLine("                             .+y/  ``       `/+oy                              ");
            Console.WriteLine("                             `+oy            /+s+                              ");
            Console.WriteLine("                              `+y`           `/s.                              ");
            Console.WriteLine("                               .+-            .s`                              ");
            Console.WriteLine("                           ``.-:+s.          `++/-``                           ");
            Console.WriteLine("                        -::/+++ss:````````````:/+++/:/-.`                      ");
            Console.WriteLine("                        ./+osoo+`               -/++osy+`                      ");
            Console.WriteLine("                            ```                   .--.`                        ");
            Console.WriteLine();
        }
    }
}
