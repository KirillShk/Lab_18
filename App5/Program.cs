using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10000;
            int[] array = new int[n]; //{2,3,2,4};
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 10);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Stopwatch stopWatch1 = new Stopwatch();
            stopWatch1.Start();
            Console.WriteLine("Метод List");
            List1 list1 = new List1(array);
            list1.GetList(array);
            stopWatch1.Stop();
            Console.WriteLine();

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            Console.WriteLine("Метод LinkedList");
            LinkedList1 linkedlist1 = new LinkedList1(array);
            linkedlist1.GetLinkedList(array);
            stopwatch2.Stop();

            Console.WriteLine();
            Console.WriteLine("Время работы List_1 ={0}", stopWatch1.ElapsedMilliseconds);
            Console.WriteLine("Время работы LinkedList_1 ={0}", stopwatch2.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
