using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Sort1
{
    public static class ArraySort
    {
        public static int[] RandomArray(int length)
        {
            int[] a = new int[length];
            Random r = new Random();
            for (int i = 0; i < length; i++)
                a[i] = r.Next(10, 99);
            return a;
        }
    }
}
