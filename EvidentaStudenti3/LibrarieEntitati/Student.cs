using System;

namespace LibrarieEntitati
{
    public class Student
    {
        // date membre private
        string nume;
        int[][] note;
        bool noteIntroduse = false;

        // contructor implicit
        public Student()
        {
        }

        // constructor cu parametri
        public Student(string _nume)
        {
            nume = _nume;
        }

        public void SetNote()
        {
            noteIntroduse = true;
            note = new int[4][];

            Console.WriteLine("Cate materii ati studiat in primul an?\nIntrodu: ");
            int an1 = Int32.Parse(Console.ReadLine());
            note[0] = new int[an1];

            Console.WriteLine("Cate materii ati studiat in al doilea an?\nIntrodu: ");
            int an2 = Int32.Parse(Console.ReadLine());
            note[1] = new int[an2];

            Console.WriteLine("Cate materii ati studiat in al treilea an?\nIntrodu: ");
            int an3 = Int32.Parse(Console.ReadLine());
            note[2] = new int[an3];

            Console.WriteLine("Cate materii ati studiat in al patrulea an?\nIntrodu: ");
            int an4 = Int32.Parse(Console.ReadLine());
            note[3] = new int[an4];


            Console.WriteLine("Anul 1: ");
            for (int i = 0; i < an1; i++)
            {
               
                Console.WriteLine("Nota {0}", i+1);
                note[0][i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Anul 2: ");
            for (int i = 0; i < an2; i++)
            {   
                Console.WriteLine("Nota {0}", i+1);
                note[1][i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Anul 3: ");
            for (int i = 0; i < an3; i++)
            {
                
                Console.WriteLine("Nota {0}", i+1);
                note[2][i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Anul 4: ");
            for (int i = 0; i < an4; i++)
            {
                
                Console.WriteLine("Nota {0}", i+1);
                note[3][i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public string ConversieLaSir()
        { string buffer = "";
            for (int i = 0; i < 4; i++)
            {
                buffer += "Notele din anul " + (i + 1) + " sunt: ";
                for (int j = 0; j < note[i].Length; j++)
                {
                    if (note[i][j] != 0)
                    {
                        buffer += note[i][j] + " ";
                    }
                }
                buffer += "\n";
            }
            return buffer;
        }
    }
}
