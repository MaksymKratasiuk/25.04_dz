using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._04_dz
{
    internal class Task6
    {
        public static void task5()
        {
            string text = "Це текст для перевірки.";
            string word = "для";

            Func<string, string, bool> containsWord = (text, word) => text.Contains(word, StringComparison.OrdinalIgnoreCase);

            bool contains = containsWord(text, word);

            if (contains)
            {
                Console.WriteLine($"Текст містить слово '{word}'.");
            }
            else
            {
                Console.WriteLine($"Текст не містить слово '{word}'.");
            }

        }
    }
}
