using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type C to continue");
            String SpecialChar = Convert.ToString(Console.ReadLine());

           if (SpecialChar == "C")
            {
              
                string line = "";
                using (StreamReader sr = new StreamReader("myapp.log"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }


                    
                     Console.ReadLine();
                }
            }
           
        }
    }
}
