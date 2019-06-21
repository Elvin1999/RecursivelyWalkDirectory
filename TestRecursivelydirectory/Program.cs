using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRecursivelydirectory
{
    class Program
    {
        static void DirSearch(string sDir)
        {
            string data = String.Empty;
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        Console.WriteLine(f);
                        Console.WriteLine("__________________________________________");
                        if (f.Contains(".txt"))
                        {
                            using (StreamReader sr = new StreamReader(f))
                            {

                                data = sr.ReadToEnd();
                            }
                            Console.WriteLine(data);
                            var hasWord = data.Contains("heyva");
                            if (hasWord)
                            {
                                Console.WriteLine("Yes");
                            }
                            else
                            {
                                Console.WriteLine("No");
                            }
                        }

                    }
                    DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
        static void Main(string[] args)
        {
            DirSearch(@"C:\Users\Jama_yw17\source\repos\TestRecursivelydirectory\TestRecursivelydirectory\bin");


        }
    }
}
