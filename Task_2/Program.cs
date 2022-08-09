using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var table = new List<string> { "Cat", "Dog", "Alifan", "Bird" };
            foreach (string s in table)
            {
                if (s == "Dog")
                    Console.WriteLine(true);
                else
                    Console.WriteLine(false);
            }
            Console.ReadKey();
        }          
    }
}
