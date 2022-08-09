using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите количество целых чисел");
            //int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[7] {3, 9, 7, 5, 12, 17, 19};
            //Random rand = new Random();
            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = rand.Next(1,15);
            //    Console.Write("{0} ",array[i]);
            //}
            //Console.WriteLine();
            List<int> list = new List<int>();
            list.AddRange(array);
            int firstElement = list[0];
            for (int i = 1; i < list.Count; i++)
            {
               if (list[i]%firstElement == 0 )
                {
                    list.Remove(list[i]);
                }
                Console.Write("{0} ", list[i]);
            }
            Console.ReadKey();
        }
    }
}
