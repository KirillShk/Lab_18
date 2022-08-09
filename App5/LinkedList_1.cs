using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    internal class LinkedList1
    {
        public LinkedList1(params int[] array)
        {
            int[] Array = array;
        }
        public void GetLinkedList(int[] Array)
        {
            LinkedList<int> linkedlist1 = new LinkedList<int>(Array);
            int firstElenemnt = linkedlist1.First();
            int b = linkedlist1.Count;
            LinkedListNode<int> node = linkedlist1.First;
            node = node.Next;
            while (1< b)
            {
                var next = node?.Next;
                if (node.Value % firstElenemnt == 0)
                {
                    linkedlist1.Remove(node.Value);
                }
                node = next;
                b--;

            }
            foreach (int c in linkedlist1)
            {
                Console.Write("{0} ", c);
            }
        }
    }
}
