using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApp4
{
    internal class Knihovna
    {
        class Knihy_prvni
        {
            public string Jmeno1 { get; set; }
            public string Autor1 { get; set; }
            public int Rok1 { get; set; }
            public string status1 { get; set; }


            public string Jmeno2 { get; set; }
            public string Autor2 { get; set; }
            public int Rok2 { get; set; }
            public string status2 { get; set; }


            public string Jmeno3 { get; set; }
            public string Autor3 { get; set; }
            public int Rok3 { get; set; }
            public string status3 { get; set; }


            public string Jmeno4 { get; set; }
            public string Autor4 { get; set; }
            public int Rok4 { get; set; }
            public string status4 { get; set; }
        }


        class Program
        {
            static void Main(string[] args)
            {
                List<Knihy_prvni> prvni = new List<Knihy_prvni>();

                prvni.Add(new Knihy_prvni { Jmeno1 = "Dorian Gray", Autor1 = "Oscar Wilde", Rok1 = 1890 });
                prvni.Add(new Knihy_prvni { Jmeno1 = "Lakomec", Autor1 = "Moliér", Rok1 = 1668 });
                prvni.Add(new Knihy_prvni { Jmeno1 = "Maryša", Autor1 = "Alois Mrštík a Vilém Mrštík", Rok1 = 1894 });


                string text = "Vítejte v knihovně přečtené/naplánované literatury!\n\n\n\n";

                for (int i = 0; i <= text.Length; i++)
                {
                    Console.Clear();
                    Console.SetCursorPosition(Console.WindowWidth / 2 - i / 2, Console.WindowHeight / 5);
                    Console.Write(text.Substring(0, i));
                    Thread.Sleep(100); 
                }

                string line = new string('/', Console.WindowWidth);
                Console.WriteLine(line);
                Console.WriteLine(" ");

                bool running = true;

                while (running)
                {

                    Thread.Sleep(1000);
                    Console.WriteLine(" ");
                    Console.SetCursorPosition(49, 15);
                    Console.WriteLine("1. Seznam knih");
                    Console.SetCursorPosition(49, 17);
                    Console.WriteLine("2. Konec");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.Write("Z jakého ročníku knihu chceš?: ");
                            string odpoved = Console.ReadLine();
                            switch(odpoved)
                            {
                                case "1":
                                    foreach (var book in prvni)
                                    {
                                        Console.WriteLine($"{book.Jmeno1} - {book.Autor1} ({book.Rok1})");
                                    }
                                    break;

                                case "2":
                                    foreach (var book2 in prvni)
                                    {
                                        Console.WriteLine($"{book2.Jmeno2} - {book2.Autor2} ({book2.Rok2})");
                                    }
                                    break;
                                case "3":
                                    foreach (var book3 in prvni)
                                    {
                                        Console.WriteLine($"{book3.Jmeno3} - {book3.Autor3} ({book3.Rok3})");
                                    }
                                    break;

                                case "4":
                                    foreach (var book4 in prvni)
                                    {
                                        Console.WriteLine($"{book4.Jmeno4} - {book4.Autor4} ({book4.Rok4})");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Neplatná volba. Zkuste to znovu.");
                                    break;

                            }
                            break;

                        case "2":
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Neplatná volba. Zkuste to znovu.");
                            break;
                    }
                }


            }
        }
    }

}