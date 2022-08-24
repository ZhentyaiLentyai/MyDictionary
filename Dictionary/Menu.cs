using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTest
{
    public class MainMenu
    {
        public static void Menu(Dictionary<int, string> numbers)
        {
            bool flag = true;
            while (flag)
            {
                string choice = Table();

                switch (choice)
                {
                    case "1":
                        ProgramDictionary.Search(numbers);
                        break;
                    case "0":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Error: enter a valid number");
                        Menu(numbers);
                        break;
                }
            }
        }
        public static string Table()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1. Search by key");
            Console.WriteLine("0. Exit");
            Console.WriteLine("-----------------------------------");
            Console.Write("-> ");
            string choice = Console.ReadLine();
            Console.WriteLine("-----------------------------------");
            return choice;
        }
    }
}
