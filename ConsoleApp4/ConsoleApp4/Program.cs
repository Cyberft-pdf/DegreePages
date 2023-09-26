using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Knihovna
    {
        static void Main(string[] args)
        {

            String[] Knihy = new String[4];

            Knihy[0] = "Obraz Doriana Graye";
            Knihy[1] = "Obraz Doriana Graye";
            Knihy[2] = "Romeo a Julie";
            Knihy[3] = "Lakomec";


            for (int i = 0; i < Knihy.Length; i++)
            {
                Console.WriteLine(Knihy[i]);
            }

            Console.ReadKey();

        }

        static void Knihy1()
        {
            
            String[] Knihy1 = new String[4];

            Knihy1[0] = "Harry Poter";
            Knihy1[1] = "Obraz Doriana Graye";
            Knihy1[2] = "Romeo a Julie";
            Knihy1[3] = "Lakomec";


            for (int i = 0; i < Knihy1.Length; i++)
            {
                Console.WriteLine(Knihy1[i]);
            }

            Console.ReadKey();

        }
        static void Knihy2()
        {

            String[] Knihy2 = new String[4];

            Knihy2[0] = "Romeo Julie a tma";
            Knihy2[1] = "Mariša";
            Knihy2[2] = "";

        }

        static void Knihy3()
        {

            String[] Knihy3 = new String[4];

            Knihy3[0] = "Romeo Julie a tma";
            Knihy3[1] = "Mariša";
            Knihy3[2] = "";

        }

        static void Knihy4()
        {

            String[] Knihy4 = new String[4];

            Knihy4[0] = "Romeo Julie a tma";
            Knihy4[1] = "Mariša";
            Knihy4[2] = "";



        }
    }
}
