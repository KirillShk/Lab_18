using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    internal class List1
    {
        public List1 (params int[] array)
        {
            int[] Array = array;
        }
        public void GetList(int[] Array)
        {
            List<int> list = new List<int>(Array);
            int firstElement = list[0];
            int countElement = list.Count;
            while (1<countElement)
            {

                if (list[countElement-1]% firstElement == 0)
                {
                    list.RemoveAt(countElement-1);
                }
                countElement--;
            }
            foreach(int a in list)
            {
                Console.Write("{0} ", a);
            }
            Console.ReadKey();
        }
    }
}
