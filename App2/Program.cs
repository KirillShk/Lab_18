using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7] { 3, 9, 7, 5, 12, 17, 19 };
            List<int> list1 = new List<int>(array);
            list1.Add(4);
            list1.Add(3);
            list1.Add(8);
            for (int i = 1; i < list1.Count-1; i++)
            {
                if(list1?[i-1]%2 != 0 && list1?[i+1]%2 !=0)
                {
                    list1[i] = 0;
                }
            }
            foreach(int a in list1)
            {
                Console.Write("{0} ", a);
            }

            Console.ReadKey();

        }
    }
}
