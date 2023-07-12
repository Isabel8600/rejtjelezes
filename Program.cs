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
            List<int> wordn = new List<int>();
            List<int> keyn = new List<int>();
            int l;
            int ll;
            string karakterek = "abcdefghijklmnopqrstuvwxyz";
            //word from here
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < karakterek.Length; j++)
                {
                    if (word[i] == karakterek[j])
                    {
                        //int sorsz = karakterek.IndexOf(karakterek.Substring(j));
                        //Console.Write(sorsz);
                        //Console.Write(j);
                        
                        //int m = karakterek.IndexOf(karakterek.Substring(j));
                        
                        Console.Write(karakterek[j]);
                        Console.Write(" --> ");
                        if (j > 26)
                        {
                            l = j % 27;
                            Console.WriteLine(j%27);
                        }
                        else
                        {
                            Console.WriteLine(j);
                            l = j;
                        }
                        wordn.Add(l);
                        
                        break;
                    }
                }
            }
            Console.WriteLine("A szó átalakítva.");
            //key from here
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < karakterek.Length; j++)
                {
                    if (key[i] == karakterek[j])
                    {
                        //int m = karakterek.IndexOf(karakterek.Substring(j));

                        Console.Write(karakterek[j]);
                        Console.Write(" --> ");
                        if (j > 26)
                        {
                            ll = j % 27;
                            Console.WriteLine(j % 27);
                        }
                        else
                        {
                            Console.WriteLine(j);
                            ll = j;
                        }
                        keyn.Add(ll);

                        break;
                    }
                }
            }
            Console.WriteLine("A kulcs átalakítva.");


            /*foreach (int a in lettersn)
            {
                Console.WriteLine(a);
            } //for test only
            */

            /*int a = 0;
            while (a != wordn.Count)
            {
                for (int b = 0; b < keyn.Count; b++)
                {

                }
            }*/

            Console.Write("A rejtjelezett üzenet kódja: ");

            int b = 0;
            for (int a = 0; a < wordn.Count; a++)
            {
                while (b != keyn.Count)
                {
                    int encryption = wordn[a] + keyn[b];
                    if (encryption > 26)
                    {
                        Console.WriteLine(encryption % 27);
                    }
                    else
                    {
                        Console.WriteLine(encryption);
                    }
                    b++;
                    break;
                }
            }

            




            //Console.WriteLine(karakterek);
            #endregion


            Console.ReadKey();


        }
    }
}
