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
            Console.WriteLine("Let's get started!");
            
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
                    //Console.WriteLine(s); //teszt
                }
            }
            catch 
            {
                throw;
            }
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Done. The file is stored.");
            #endregion
          







            Console.ReadKey();
        }
    }
}
