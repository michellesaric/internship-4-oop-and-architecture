using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4
{
    class Brute : Character
    {
        public override double DealtDamage(Character hero, List<Character> list, int index)
        {
            var random = new Random();
            var percentageDamageChance = random.Next(100);
            if (percentageDamageChance < Level * 5)
            {
                Console.Write("  Bonus fixed damage!! ");
                Console.Write(CharacterName + " deals ");
                PrintingFunction.DRed("" + (int)(base.DealtDamage() * Damage + hero.MaxHealthPoints * 0.25));
                Console.WriteLine(" damage.");
                return (int)(base.DealtDamage() * Damage + hero.MaxHealthPoints * 0.25);
            }

            Console.Write(CharacterName + " deals ");
            PrintingFunction.DRed("" + (int)(base.DealtDamage() * Damage));
            Console.WriteLine(" damage.");
            return (int)(base.DealtDamage() * Damage);
        }

        public void ChangeCharacterStatus(int level)
        {
            CharacterName = "Brute";
            MaxHealthPoints = 15 + 5 * level;
            HealthPoints = MaxHealthPoints;
            MaxExperiencePoints = 10 + 3 * level;
            Damage = 2 + 3 * level;
        }

        public override void Portrait()
        {
            Console.WriteLine("                                      ```                                      ");
            Console.WriteLine("                                   `/+++oo:`                                   ");
            Console.WriteLine("                                   shddddmdy                                   ");
            Console.WriteLine("                                  -hhyhsdmmd-                                  ");
            Console.WriteLine("                                  /yyysymmdd/                                  ");
            Console.WriteLine("                               `:sdhdyyydmh+`                                  ");
            Console.WriteLine("                           `-/shddhsmdmddmm:``                                 ");
            Console.WriteLine("                      ``-:oyyysshhhhdshmmdNmmhso+-`                            ");
            Console.WriteLine("                    `..oso++ssyyhhhdyssshhhyydddmmy+.                          ");
            Console.WriteLine("                      ./+/syhdhhhhdmyoo+yhsyooyhmmmmd+                         ");
            Console.WriteLine("                    `odhyyys//sdhhyhdh:/+yoso-+ydNmmmm+                        ");
            Console.WriteLine("                 `.-/syyhhs++oymmhhdhds/+hdoyo/odNNNmdh+                       ");
            Console.WriteLine("                 `.``+y++/:-/ydNNdmdhddhdNmoohddmNMNNmddo                      ");
            Console.WriteLine("                   -oys:/+//oydmMdNmdmmNNmo::/ydNMMNNhys+:.                    ");
            Console.WriteLine("                 `+oddo:/hddddmNNmmmmmNNm+:-:/sohNMNNhsooso:`                  ");
            Console.WriteLine("                 :dshdhyoymhsNNmmmmddmmNhoo+osyddmMMNmmhyysys`                 ");
            Console.WriteLine("                  -ddssyhdNdsmMNMNmmddmNddhhddmNNMMMhhdyysyyy.                 ");
            Console.WriteLine("                   .ymmmNNNmNdmNNNmmmdmNmddhhyddmMMMmmNNmmhs-                  ");
            Console.WriteLine("                     -smNNNdmmNdddmmNdmmyssyshdmmNMMNNmNNNm/                   ");
            Console.WriteLine("                       :symNNmddsoydmmmmmyhmdNNMMMMNhhmMNso `                  ");
            Console.WriteLine("                      `::  -odNhysssohNNNNhNdNNNNNMNmmmm- :                    ");
            Console.WriteLine("                     .-..     hddshhdhdmdmmdhNMM+NMNNNNs  `                    ");
            Console.WriteLine("                    `` `     +NNmmddNNNmNNmNNmNmsNMMNN+`                       ");
            Console.WriteLine("                            `dmdmNNNNMNdmNNNdsddNmMMNN-                        ");
            Console.WriteLine("                           -sodhdNNNNmNNNmNdohdmNNNNNNm.                       ");
            Console.WriteLine("                           -o++dhmNmmNNmNNyosmdmNmmNNMNs                       ");
            Console.WriteLine("                          +do+osmNMNNNmmNhosmNdNNmmNNNNm`                      ");
            Console.WriteLine("                        `+NddmmMNNNNNmddhoodNNhNNNmmNNMN:                      ");
            Console.WriteLine("                       `hdmmNNMNNddmmyhd+osNNNhNmmmmNNMNs                      ");
            Console.WriteLine("                      -ymmmNNNNmdyhmsydhoyhNMmyNNmmmNNNNd                      ");
            Console.WriteLine("                     :dmmNMNNmNmhhdyyddshhmNMmhddmdmNNNNm-                     ");
            Console.WriteLine("                    /mhdNMNNNdmhhdmsyhdydmNNMdmdddmdNNNNm+                     ");
            Console.WriteLine("                  `+hmmdNNNNmddyymmshhdddmNMNhmdddmmmmNNNo                     ");
            Console.WriteLine("                 `smmysmdNmddhyshmyodddmmmNMmmmdhdmmdmNNNd                     ");
            Console.WriteLine("                -ydm+-mmhdhddyshdmysdmmdmmNMdmmmydmmddmmNm/                    ");
            Console.WriteLine("              `:yds. -ddysdh++sdNNdhddNdNNMMmNNhymNNdmmmNNd                    ");
            Console.WriteLine("            `:ohy:   `ddddmdsyydmmyddmNmNNMNmNdhdNNddNNNNNy                    ");
            Console.WriteLine("         -:/oo/.      hNNNNmdmdmhyydmNNmhomdNNNNMMNNNMMNmy`                    ");
            Console.WriteLine("           `          /NMMMNNmmdmddmmhyo. ohNMMMMMMMMMMh.                      ");
            Console.WriteLine("                     `hNNMMMMMMMMmyoo`    o`-hMMMMMMMMMo                       ");
            Console.WriteLine("                     +mmmMMMMMMMN-       .-  sMMMNNMMMN+                       ");
            Console.WriteLine("                     .smdNNMMMNMy       `-`  -dMNNNMMMo`                       ");
            Console.WriteLine("                      -NNNmNNNNm:             :MMNNNNN.                        ");
            Console.WriteLine("                      :NmdmNNN/.              -MMNmmmd                         ");
            Console.WriteLine("                      /NddNMNo                /MNdhdNy                         ");
            Console.WriteLine("                     .hdhdNNN-                dMNddmNh                         ");
            Console.WriteLine("                     omdhdmNs                 mNmdmhmN/                        ");
            Console.WriteLine("                     yNyhddN:                -MMMMNmhdm+`                      ");
            Console.WriteLine("                    .NyymNNN`                 ohmNNNmmmNms-`                   ");
            Console.WriteLine("                    /NddmNNN-                   `--ydmmmdmmho`                 ");
            Console.WriteLine("                    :mmdmNNNo                        .:+syhhs:                 ");
            Console.WriteLine("                     -smNNNh.                                                  ");
            Console.WriteLine("                        --.                                                    ");
            Console.WriteLine();
        }
    }
}
