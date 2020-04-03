using LibrarieEntitati;
using System;


namespace ManagementStudenti
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Dascaliuc Adi");

            while (true)
            {
                Console.WriteLine("S: Citeste note de la tastatura ca un sir de caractere\n" +
                    "T: Citeste note de la tastatura (cate o nota pe rand)\n" +
                    "C: Citeste note din linia de comanda\n" +
                    "A: Afisare note\n" +
                    "I: Info autor\n" +
                    "X: Iesire");
                switch (Console.ReadLine().ToLower())
                {
                    case "s":
                        string sir = Console.ReadLine();
                        string[] date = sir.Split(',');

                        int an1 = date[0].Length / 2;
                        int an2 = date[1].Length / 2;
                        int an3 = date[2].Length / 2;
                        int an4 = date[3].Length / 2;
                        s.SetNote(sir, an1, an2, an3, an4);
                        break;

                    case "t":
                        Console.WriteLine("Cate note doriti sa introduceti pentru anul 1: ");
                        an1 = Convert.ToInt32(Console.ReadLine());
                        string note = "";

                        for (int i = 0; i < an1; i++)
                        {
                            note += Console.ReadLine() + " ";
                        }
                        note += ", ";

                        Console.WriteLine("Cate note doriti sa introduceti pentru anul 2: ");
                        an2 = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < an2; i++)
                        {
                            note += Console.ReadLine() + " ";
                        }
                        note += ", ";

                        Console.WriteLine("Cate note doriti sa introduceti pentru anul 3: ");
                        an3 = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < an3; i++)
                        {
                            note += Console.ReadLine() + " ";
                        }
                        note += ", ";

                        Console.WriteLine("Cate note doriti sa introduceti pentru anul 4: ");
                        an4 = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < an4; i++)
                        {
                            note += Console.ReadLine() + " ";
                        }

                        s.SetNote(note, an1, an2, an3 ,an4);
                        break;

                    case "c":
                        sir = "";

                        
                       foreach (string nota in args)
                       {
                           sir += nota + " ";
                       }
                        
                        date = sir.Split(',');

                        an1 = date[0].Length / 2;
                        an2 = date[1].Length / 2;
                        an3 = date[2].Length / 2;
                        an4 = date[3].Length / 2;

                        s.SetNote(sir, an1, an2, an3, an4);
                        break;

                    case "a":
                        Console.WriteLine(s.ConversieLaSir());
                        break;

                    case "i":
                        Console.WriteLine("|===============|\n" +
                                          "| Dascaliuc Adi |\n" +
                                          "|===============|");
                        break;

                    case "x":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta!!!\n" +
                            "Reintroduceti o optiune valida: ");
                        break;
                }
            }
        }
    }
}
