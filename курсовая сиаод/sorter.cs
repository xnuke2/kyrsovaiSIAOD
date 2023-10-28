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
        public static long ShellSortingMethodOfDividingInHalf(SinglyLlinkedList list)
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
        public static long ShellSortingMethodVirt(SinglyLlinkedList list)
        {
            int gap = list.Length / 2;
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
                gap = (gap - 1) / 2;
            }
            sw.Stop();
            //return array;
            return sw.ElapsedMilliseconds;

        }
        public static long ShellSortingMethodKnyt(SinglyLlinkedList list)
        {

            int gap =(int) Math.Log(list.Length,3);
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
                gap = gap / 3;
            }
            sw.Stop();
            //return array;
            return sw.ElapsedMilliseconds;

        }

    }
}
