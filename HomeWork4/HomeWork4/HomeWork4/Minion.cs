using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4
{
    class Minion : Character
    {
        public void ChangeCharacterStatus(int level)
        {
            CharacterName = "Minion";
            MaxHealthPoints = 5 + 4 * level;
            HealthPoints = MaxHealthPoints;
            MaxExperiencePoints = 0;
            Damage = 1 + 2 * level;
        }
        public override double DealtDamage(Character hero, List<Character> list, int index)
        {
            Console.Write(CharacterName + " attacks to avenge master with ");
            PrintingFunction.DRed("" + (int)(base.DealtDamage() * Damage));
            Console.WriteLine(" damage.");
            return (int)(base.DealtDamage() * Damage);
        }

        public override void Portrait()
        {
            Console.WriteLine("                                 -:+oo-                                        ");
            Console.WriteLine("                             `:+sooooos/`           .oo-                       ");
            Console.WriteLine("                          -/osoooooooooos/        `smmmmh/`                    ");
            Console.WriteLine("                        +dhhoooooooooooooy+     `ommmy++ymd+                   ");
            Console.WriteLine("                      `ymmdsoooooooooosydd.    /dmmmmy/:-dmy:                  ");
            Console.WriteLine("                     `hmmmdhsoooossooyhhhs   .hmmmmmhdmdmmms+                  ");
            Console.WriteLine("                    .dmmmmmmmdhhhhhhdhhhdy+:sNNmmmmy:-ommmmos                  ");
            Console.WriteLine("                   `dmmmmmmmmmmmmddhhhhhdyydmNNNNNmmsohmmmhos-                 ");
            Console.WriteLine("                   +mmmmmmmmmmmmmhhhhhhdyooooosymm/+dNNNNNyoo/                 ");
            Console.WriteLine("               `/+sdmmmmmmmmmmmmhhhhhhhdyyssosssymyoyNNNNmhsyo                 ");
            Console.WriteLine("              :++syymmmmmmmmmmdhhhhhhhdmhhhhhhhhhhmNNNNNNdhhhs                 ");
            Console.WriteLine("            .+///syydmmmmmmmmdhhhhhhhhmmmhhhhhhhhhhmNNNNmhhhho                 ");
            Console.WriteLine("           :+/++osoo+odmmmmmdhhhhhhhhhdmmmddhhhhhhdNNNNmhhhhh/                 ");
            Console.WriteLine("          -+/o+///++///ohmmdhhhhhhhhhhhmmmmmmmmddmNNNNNddhhhdo                 ");
            Console.WriteLine("          o+o///////+++oohyhhyyyyyyssyhhhdmmddddmdsyyhhddddddy/                ");
            Console.WriteLine("          oh+///////yys///////++++/:--/yyyydhhdddhs-...-shddosy-               ");
            Console.WriteLine("          oys+//+++yy+//////////////+::/syy/+shdmmdho-...:hhy/s+               ");
            Console.WriteLine("          syyyo/-..-/+//////////////o////y--..-/ydmdss-...:hy+/o               ");
            Console.WriteLine("          /sh+-------.:o/////////////+/++-:-.ys-/`smds/----sy+//+.             ");
            Console.WriteLine("           yh:/::------:o/////////++osoyooos+mhho sydds----+y///o-+-           ");
            Console.WriteLine("          :h+ ``.+:---:ohyssssssyyyyydhdysssodmdddhhhhy:---.y//o+-+`-.         ");
            Console.WriteLine("          yh` `--``o+shhyyyyyyyyyydddmdddmhssydmmmmmmdysso/+ys+ysoo-.-.        ");
            Console.WriteLine("          yy`:syhyyyyyyhyyyyyyyyyydmmmmmmmmmyohhhyyhhdmddhdddyy`.-:            ");
            Console.WriteLine("          +yyyyhdyyyyyhyyysyyyyyyhdmmmmmmNmmmhsysysssyddhyyyyy:                ");
            Console.WriteLine("          :oyyydsoooooosyyyyddddmmmmmmmmmmmmmmhysysyydymmdhyy+                 ");
            Console.WriteLine("           /syhoooooooooosyyhddmmmmmmmmmmmmmmmmdyhhhhhmmmdhy/                  ");
            Console.WriteLine("            -ohoooooooooooshyhhmdmmmmmmmmmmmmmmmmmmmmmmmmdd.                   ");
            Console.WriteLine("              sooooooooooooyyydmhmmmmmmmmmmmmmmmmmmmmNmmmmds                   ");
            Console.WriteLine("              sooooooooooooyhhmdddmmmmmmmmmmmmmmmmmmmmmysooo-                  ");
            Console.WriteLine("              ysosooooossssdhddddddmmmmmmmmmmmmmmmdhyyysooo++                  ");
            Console.WriteLine("             -sssssossosyyhmyyyyhhhhhhddmdmmdddhhyysooooooo/+                  ");
            Console.WriteLine("             ooooossssshhhs`-/+ssyyyyyys+: `../sosooooooooo/                   ");
            Console.WriteLine("            `sooooooosyhh/       ``          `sssssosssoos/:-                  ");
            Console.WriteLine("            /ooossooosssdo-                   :/++ssso/s:``  --                ");
            Console.WriteLine("            .+yo/:----:+dyy+                       `...-/.....-.               ");
            Console.WriteLine("               -:`   `--                                `                      ");
            Console.WriteLine("                 ....-                                                         ");
            Console.WriteLine("");
        }
    }
}
