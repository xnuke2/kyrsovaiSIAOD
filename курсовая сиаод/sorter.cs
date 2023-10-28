using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая_сиаод
{
    internal static class sorter
    {
        static long ShellSorting(SinglyLlinkedList list)
        {
            var gap = list.Length / 2;
            var sw = new Stopwatch();
            sw.Start();
            while (gap >= 1)
            {
                for (var i = gap; i < list.Length; i++)
                {
                    var j = i;
                    while ((j >= gap) && (list.GetNode(j - gap).data > list.GetNode(j).data))
                    {
                        list.swap(j, j - gap);
                        j = j - gap;
                    }
                }
                gap = gap / 2;
            }
            sw.Stop();
            //return array;
            return sw.ElapsedMilliseconds;
        }
    }
}
