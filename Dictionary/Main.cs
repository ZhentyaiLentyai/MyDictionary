using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> numbers = new Dictionary<int, string>();
            int n = 100;
            numbers = ProgramDictionary.DataDictionary(n);

            MainMenu.Menu(numbers);
        }
    }
}
