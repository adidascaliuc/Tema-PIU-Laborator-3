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
                Console.WriteLine("S: Citeste note de la tastatura ca un sir de caractere\n"+
                    "T: Citeste note de la tastatura (cate o nota pe rand)\n"+
                    "C: Citeste note din linia de comanda\n"+
                    "A: Afisare note\n"+
                    "I: Info autor\n"+
                    "X: Iesire");
                switch (Console.ReadLine().ToLower())
                {
                    case "s":
                        s.SetNote(Console.ReadLine());
                        break;

                    case "t":
                        s.SetNote();
                        break;

                    case "c":
                        string sir = "";
                        
                        foreach(string nota in args)
                        {
                            sir += nota + " ";
                        }
                        s.SetNote(sir);
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
                }
            }
        }
    }
}
