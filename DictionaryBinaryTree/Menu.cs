using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryBinaryTree
{
    internal class Menu
    {
        public static void ProgramMenu(BinaryTree tree)
        {
            bool flag = true;
            while (flag)
            {
                string choice = Table();

                switch (choice)
                {
                    case "1":
                        tree.Output(tree);
                        break;
                    case "2":
                        tree.Search(tree);
                        break;
                    case "3":
                        tree.AddKey(tree);
                        break;
                    case "4":
                        tree.RemoveKey();
                        break;
                    case "0":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Error: enter a valid number");
                        ProgramMenu(tree);
                        break;
                }
            }
        }
        public static string Table()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1. Output keys with values");
            Console.WriteLine("2. Search by key");
            Console.WriteLine("3. Add key and value");
            Console.WriteLine("4. Delete key");
            Console.WriteLine("0. Exit");
            Console.WriteLine("-----------------------------------");
            Console.Write("-> ");
            string choice = Console.ReadLine();
            Console.WriteLine("-----------------------------------");
            return choice;
        }
    }
}
