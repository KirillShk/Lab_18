using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    internal class LinkedList
    {
        public LinkedList(params int[] array)
        {
            int[] Array =array;
        }
        
        public void GetLinkedList(int[] Array)
        {
            LinkedList<int> link1 = new LinkedList<int>(Array);
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
        }
    }
}
