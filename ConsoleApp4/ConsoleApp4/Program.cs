﻿using System;
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
                prvni.Add(new Knihy_prvni { Jmeno1 = "Maryša", Autor1 = "Alois a Vilém Mrštík", Rok1 = 1894 });


                string text = "Welcome to your bookshelf!\n\n\n\n";

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
                    Console.WriteLine("1. | Distribution of books by grade of school");
                    Console.SetCursorPosition(49, 17);
                    Console.WriteLine("2. | The whole list");
                    Console.SetCursorPosition(49, 19);
                    Console.WriteLine("3  | Add book");
                    Console.SetCursorPosition(49, 21);
                    Console.WriteLine("4. | Exit");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.Write("What hight school grade do you want the book from?(1, 2, 3, 4): ");
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
                                    Console.WriteLine("Invalid choice. Try it again.");
                                    break;

                            }
                            break;

                        case "2":
                            Console.Clear();
                            foreach (var book in prvni)
                            {

                               Console.WriteLine($"1. grade: {book.Jmeno1} - {book.Autor1} ({book.Rok1})");
                               Console.WriteLine($"2. grade: {book.Jmeno2} - {book.Autor2} ({book.Rok2})");
                               Console.WriteLine($"3. grade: {book.Jmeno3} - {book.Autor3} ({book.Rok3})");
                               Console.WriteLine($"4. grade: {book.Jmeno4} - {book.Autor4} ({book.Rok4})");
                            }
                            break;

                        case "3":
                            Console.Clear();
                            Console.Write("What grade do you want to add the book to?: ");
                            string odpoved_rocnik = Console.ReadLine();

                                switch(odpoved_rocnik)
                            {
                                case "1":

                                    Console.Write("Name of the book: ");
                                    string jmeno_1 = Console.ReadLine();

                                    Console.Write("Name of the author: ");
                                    string autor_1 = Console.ReadLine();

                                    Console.Write("Year publication: ");
                                    int rok_1 =  Convert.ToInt32(Console.ReadLine());

                                    prvni.Add(new Knihy_prvni { Jmeno1 = jmeno_1, Autor1 = autor_1, Rok1 = rok_1 });

                                    Console.WriteLine("Kniha byla přidáná: Name:" + jmeno_1, "autor: " + autor_1, "Year: " + rok_1);

                                    break; 
                                case "2":

                                    Console.Write("Name of the book: ");
                                    string jmeno_2 = Console.ReadLine();

                                    Console.Write("Name of the author: ");
                                    string autor_2 = Console.ReadLine();

                                    Console.Write("Year publication: ");
                                    int rok_2 = Convert.ToInt32(Console.ReadLine());

                                    prvni.Add(new Knihy_prvni { Jmeno2 = jmeno_2, Autor2 = autor_2, Rok2 = rok_2 });

                                    Console.WriteLine("Book was added: Name:" + jmeno_2, "autor: " + autor_2, "Year: " + rok_2);

                                    break; 
                                
                                case "3":

                                    Console.Write("Name of the book: ");
                                    string jmeno_3 = Console.ReadLine();

                                    Console.Write("Name of the author: ");
                                    string autor_3 = Console.ReadLine();

                                    Console.Write("Year publication: ");
                                    int rok_3 = Convert.ToInt32(Console.ReadLine());

                                    prvni.Add(new Knihy_prvni { Jmeno3 = jmeno_3, Autor3 = autor_3, Rok3 = rok_3 });

                                    Console.WriteLine("Book was added: Name:" + jmeno_3, "autor: " + autor_3, "Year: " + rok_3);

                                    break;

                                case "4":

                                    Console.Write("Name of the book: ");
                                    string jmeno_4 = Console.ReadLine();

                                    Console.Write("Name of the author: ");
                                    string autor_4 = Console.ReadLine();

                                    Console.Write("Year publication: ");
                                    int rok_4 = Convert.ToInt32(Console.ReadLine());

                                    prvni.Add(new Knihy_prvni { Jmeno4 = jmeno_4, Autor4 = autor_4, Rok4 = rok_4 });

                                    Console.WriteLine("Book was added: Name:" + jmeno_4, "autor: " + autor_4, "Year: " + rok_4);

                                    break;

                                default:
                                    Console.WriteLine("Invalid choice. Try it again.");
                                    break;                                
                            }
                            break;

                        case "4":
                            running = false; 
                            break;


                        default:
                            Console.WriteLine("Invalid choice. Try it again.");
                            break;

                    }
                }


            }
        }
    }

}