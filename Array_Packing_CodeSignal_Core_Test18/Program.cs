using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Packing_CodeSignal_Core_Test18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 24, 85, 0 };
            int x = 0;
            Console.WriteLine(x = arrayPacking(array));
            
            
        }

        static int arrayPacking(int[] a)
        {
            return a.Reverse().Aggregate((t, n) => (t << 8) + n);
        }

    }
}
