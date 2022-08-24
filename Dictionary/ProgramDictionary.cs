using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTest
{
    public class ProgramDictionary
    {
        public static Dictionary<int, string> DataDictionary(int n)
        {
            Random random = new Random();

            Dictionary<int, string> numbers = new Dictionary<int, string>();

            for (int counter = 0; counter < n; counter++)
            {
                int number = random.Next(1, n + 1);
                if (numbers.ContainsKey(number))
                {
                    counter--;
                    continue;
                }
                numbers.Add(number, "!" + number + "!");
            }
            return numbers;
        }

        public static void Search(Dictionary<int, string> numbers)
        {
            Console.Write("Enter key: ");
            int key = Convert.ToInt32(Console.ReadLine());
            if (!numbers.ContainsKey(key))
            {
                Console.WriteLine("No key");
            }
            else
            {
                Console.WriteLine($"Key: {key}, values: {SearchKey(numbers, key)}");
            }
        }
        public static string SearchKey(Dictionary<int, string> numbers, int key)
        {

            string values = numbers[key];
            return values;
        }
    }
}
