using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._04_dz
{
    internal class Task5
    {
        public static void task5()
        {
            int[] arr = { -14, -14, 21, -35, 3, -28 };
            int count = arr.Count(x =>
            {
                int i = 0;
                if (x > 0) return false;
                foreach(var item in arr)
                {
                    if (item == x) i++;
                }
                if (i == 1) return true;
                return false;
            }); // лямбда-вираз
            Console.WriteLine($"Кількість унікальних негативних чисел: {count}");
        }
    }
}
