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
                        Console.WriteLine("Cate note doriti sa introduceti pentru anul 1: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        string note = "";

                        for (int i = 0; i < n; i++)
                        {
                            note += Console.ReadLine() + " ";
                        }
                        note += " , ";

                        Console.WriteLine("Cate note doriti sa introduceti pentru anul 2: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            note += Console.ReadLine() + " ";
                        }
                        note += " , ";

                        Console.WriteLine("Cate note doriti sa introduceti pentru anul 3: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            note += Console.ReadLine() + " ";
                        }
                        note += " , ";

                        Console.WriteLine("Cate note doriti sa introduceti pentru anul 4: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            note += Console.ReadLine() + " ";
                        }

                        s.SetNote(note);
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
