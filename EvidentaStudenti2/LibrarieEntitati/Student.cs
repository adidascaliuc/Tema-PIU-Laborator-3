using System;
namespace LibrarieEntitati
{
    public class Student
    {
        // date membre private
        string nume;
        int[,] note;
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
            noteIntroduse= true;

            note = new int[4,15];
            

            Console.WriteLine("Cate note doriti sa introduceti pentru anul 1: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                note[0,i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Cate note doriti sa introduceti pentru anul 2: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                note[1,i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Cate note doriti sa introduceti pentru anul 3: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                note[2,i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Cate note doriti sa introduceti pentru anul 4: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                note[3,i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void SetNote(string sirNote)
        {
            noteIntroduse = true;
            // initializare vector cu note
            note = new int[4,15];
            

            // DE IMPLEMENTAT:
            // extrage note din sir si adauga in vectorul note
            string[] noteSep = sirNote.Split(' ');
            int i = 0;
            int j = 0;
            foreach(string nota in noteSep)
            {
                if (nota == "," || nota == "")
                {
                    i++;
                    j = 0;
                }
                else
                {
                    note[i, j] = Convert.ToInt32(nota);
                    j++;
                }
            }
     
        }
        public string ConversieLaSir()
        {
            string buff = "";
            if (noteIntroduse == false)
            {
                buff += "Nu au fost introduse notele! ";
                return buff;
            }

            for (int i = 0; i < 4; i++)
                {
                
                    buff += "Notele din anul " + (i + 1) + " sunt: ";
                    for (int j = 0; j < note.GetLength(1); j++)
                    {
                        if (note[i,j] != 0)
                        {
                            buff += note[i,j] + " ";
                        }
                    }
                buff += "\n";   
            }
                
            return buff;
        }
    }
}
