using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n]; 
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1,10);
            }
            LinkedList<int> link1 = new LinkedList<int>(array);
            link1.AddFirst(2);
            link1.AddLast(20);
            link1.AddLast(15);
            link1.AddLast(18);
            foreach (int a in link1)
            {
                Console.Write("{0} ", a);
            }
          //  GetLinkedList(link1);
            GetList(link1);
            Console.ReadKey();
        } 
        static void GetLinkedList(LinkedList<int> link1)
        {
            LinkedListNode<int> node = link1.First;
            node = node.Next;
            for (int i = 1; i < link1.Count - 1; i++)
            {
                if (node?.Previous.Value % 2 == 0 && node?.Next.Value % 2 == 0)
                {
                    node.Value = 0;
                }
                node = node.Next;
            }
            Console.WriteLine();
            foreach (int a in link1)
            {
                Console.Write("{0} ", a);
            }
        }

        static void GetList(LinkedList<int> link1)
        {
            Console.WriteLine();
            LinkedListNode<int> node = link1.First;
            int b = link1.Count;
            while (0 < b)
            {
                var next = node.Next;
                if (node.Value % 2 == 0)
                {
                    link1.Remove(node);
                }
                node = next;
                b--;

            }
            foreach (int c in link1)
            {
                Console.Write("{0} ", c);
            }
        }
    }
} 
 