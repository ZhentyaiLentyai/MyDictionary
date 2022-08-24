using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryBinaryTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            DataBase start = new DataBase();
            BinaryTree tree = start.TreeLoading(n);
            Menu.ProgramMenu(tree);
        }
    }
}