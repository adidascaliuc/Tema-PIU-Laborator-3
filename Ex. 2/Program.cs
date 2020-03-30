using System;


namespace Ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In linia de comanda aveti: " + args.Length + " cuvinte.");
            string[][] cuvinte = new string[30][];
       
            for(int i=0; i<cuvinte.GetLength(0); i++)
           {
                cuvinte[i] = new string[1];
            }

            
            foreach(string cuvant in args)
            {                     
                try
                {   
                    int firstLetter = Convert.ToInt32(cuvant[0] - 'a');
                    cuvinte[ firstLetter ][0] += cuvant + " ";
                }
                catch
                {
                    int firstLetter = Convert.ToInt32(cuvant[0] - 'A');
                    cuvinte[ firstLetter ][0] += cuvant + " ";
                }               
            }

            int temp = 0;
            for (int i = 0; i < cuvinte.Length; i++)
            {   
                if( cuvinte[i][0] != null)
                   Console.Write("\n" + (char)('A' + i) + ": ");
             
                for (int j = 0; j < cuvinte[i].Length; j++)
                {
                    if (cuvinte[i][j] != null)
                    {
                        Console.Write(cuvinte[i][j]);
                    }
                    temp = j;
                }
            }
        }
    }
}
