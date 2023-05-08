using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._04_dz
{
    internal class Task3
    {
        public static void task3()
        {
            int[] arr = { 14, 7, 21, 35, 3, 28 };
            int count = arr.Count(x => x % 7 == 0); // лямбда-вираз
            Console.WriteLine($"Кількість чисел, кратних 7: {count}");
        }
    }
}
