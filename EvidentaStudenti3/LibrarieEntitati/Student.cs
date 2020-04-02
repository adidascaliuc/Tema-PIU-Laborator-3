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


        public void SetNote(string sirNote, int an1, int an2, int an3, int an4)
        {
            noteIntroduse = true;
            // initializare vector cu note
            note = new int[4][];
            note[0] = new int[an1];
            note[1] = new int[an2];
            note[2] = new int[an3];
            note[3] = new int[an4];
            // DE IMPLEMENTAT:
            // extrage note din sir si adauga in vectorul note
            string[] noteSep = sirNote.Split(' ');
            int i = 0;
            int j = 0;

            
            foreach (string nota in noteSep)
            {

                if (nota == "," || nota == "")
                {
                    i++;
                    j = 0;
                }
                else
                {
                    note[i][j] = Convert.ToInt32(nota);
                    j++;
                }
            }

        }


        public string ConversieLaSir()
        { string buffer = "";
            if (noteIntroduse == false)
            {
                return string.Format("Nu ati introdus note!");
            }
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
