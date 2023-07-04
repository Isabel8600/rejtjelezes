using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace rejtjelezes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kezdés");
            
            #region beolvasás
            try
            {
                List<string> list = new List<string>();
                StreamReader sr = new StreamReader("words.txt", Encoding.Default); //azért nincs elérési út, mert a bin-->Debug-->netcoreapp3.1 mappába bemásoltam a beolvasandó dokumentumot
                while (sr.EndOfStream == false)
                {
                    string s = sr.ReadLine();
                    if (s.Trim().Length ==0)
                    {
                        continue;
                    }
                    list.Add(s);
                    //Console.WriteLine(s); //test
                }
            }
            catch 
            {
                throw;
            }
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Fájl eltárolva.");
            #endregion
            #region bekérés
            Console.Write("Adja meg a titkosítani kívánt szavat: ");
            string word = Console.ReadLine();
            Console.Write("Adja meg a kulcsot: ");
            string key = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                int n = word.IndexOf(word.Substring(i));
                Console.Write(n);
            }
            Console.WriteLine();

            #endregion
            #region karakterek
            List<string> kar = new List<string>();
            string karakterek = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < karakterek.Length; j++)
                {
                    if (word[i] == karakterek[j])
                    {
                        //int sorsz = karakterek.IndexOf(karakterek.Substring(j));
                        //Console.Write(sorsz);
                        Console.Write(j);
                    }
                }
            }

            //Console.WriteLine(karakterek);
            #endregion






            Console.ReadKey();
        }
    }
}
