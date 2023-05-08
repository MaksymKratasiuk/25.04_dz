using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._04_dz
{
    internal class Task1
    {
        public static void task1()
        {
            string color = "green";

            // Анонімний метод для отримання RGB значення кольору веселки
            Func<string, string> getRGB =  (string c) =>
            {
                switch (c.ToLower())
                {
                    case "red":
                        return "255, 0, 0";
                    case "orange":
                        return "255, 165, 0";
                    case "yellow":
                        return "255, 255, 0";
                    case "green":
                        return "0, 128, 0";
                    case "blue":
                        return "0, 0, 255";
                    case "indigo":
                        return "75, 0, 130";
                    case "violet":
                        return "238, 130, 238";
                    default:
                        return "Invalid color";
                }
            };

            // Виведення RGB значення кольору веселки
            Console.WriteLine("The RGB value for {0} is: {1}", color, getRGB(color));

            Console.ReadLine();
        }
    }
}
