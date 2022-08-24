using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryBinaryTree
{
    public class BinaryTree
    {
        public BinaryTree parent, left, right;
        private int key;
        private string val;

        public BinaryTree(int key, BinaryTree parent, string val)
        {
            this.key = key;
            this.parent = parent;
            this.val = val;
        }

        //Добавление ключа и числа
        public void Add(int key, string val)
        {
            if (key.CompareTo(this.key) < 0)
            {
                if (this.left == null)
                {
                    this.left = new BinaryTree(key, this, val);
                }
                else if (this.left != null)
                    this.left.Add(key, val);
            }
            else
            {
                if (this.right == null)
                {
                    this.right = new BinaryTree(key, this, val);
                }
                else if (this.right != null)
                    this.right.Add(key, val);
            }
        }

        //Вывод отсортированного по ключу дерева с числами
        public void Output(BinaryTree tree)
        {
            if (tree == null) return;
            Output(tree.left);
            Console.WriteLine($"Key: {tree.key}\t Value: {tree.val}");
            if (tree.right != null)
                Output(tree.right);
        }

        //Поиск по ключу
        public void Search(BinaryTree tree)
        {
            Console.Write("Enter key: ");
            int key = Convert.ToInt32(Console.ReadLine());

            tree = SearchKey(this, key);
            if (tree == null)
            {
                Console.WriteLine("There is no such key");
                return;
            }

            Console.WriteLine($"Key {key}, contains values:{tree.val}");
        }
        public BinaryTree SearchKey(BinaryTree tree, int key)
        {
            if (tree == null)
            {
                return null;
            }
            switch (key.CompareTo(tree.key))
            {
                case 1:
                    return SearchKey(tree.right, key);
                case -1:
                    return SearchKey(tree.left, key);
                case 0:
                    return tree;
                default:
                    return null;
            }
        }

        //Добавление ключа с числом
        public void AddKey(BinaryTree tree)
        {
            Console.Write("Enter key: ");
            int key = Convert.ToInt32(Console.ReadLine());
            string value = "!" + key + "!";
            tree.Add(key, value);
        }

        //Удаление
        public void RemoveKey()
        {
            Console.Write("Enter the key to delete: ");
            int key = Convert.ToInt32(Console.ReadLine());
            Remove(key);
        }
        public bool Remove(int key)
        {
            BinaryTree tree = SearchKey(this, key);
            if (tree == null)
            {
                //Если узла не существует, вернем false
                Console.WriteLine("No such key");
                return false;
            }
            BinaryTree curTree;

            //Если удаляем корень
            if (tree == this)
            {
                if (tree.right != null)
                {
                    curTree = tree.right;
                }
                else curTree = tree.left;

                while (curTree.left != null)
                {
                    curTree = curTree.left;
                }
                int temp = curTree.key;
                this.Remove(temp);
                tree.key = temp;

                return true;
            }

            //Удаление листьев
            if (tree.left == null && tree.right == null && tree.parent != null)
            {
                if (tree == tree.parent.left)
                    tree.parent.left = null;
                else
                {
                    tree.parent.right = null;
                }
                return true;
            }

            //Если поддерево есть слева, а справа нет
            if (tree.left != null && tree.right == null && tree.parent != null)
            {
                if (tree == tree.parent.left)
                {
                    tree.parent.left = tree.left;
                }
                else
                {
                    tree.parent.right = tree.left;
                }
                return true;
            }

            //Если поддерево есть справа, а слева нет
            if (tree.left == null && tree.right != null && tree.parent != null)
            {
                if (tree == tree.parent.left)
                {
                    tree.parent.left = tree.right;
                }
                else
                {
                    tree.parent.right = tree.right;
                }
                return true;
            }

            //Если поддеревья с обеих сторон
            if (tree.right != null && tree.left != null && tree.parent != null)
            {
                curTree = tree.right;

                while (curTree.left != null)
                {
                    curTree = curTree.left;
                }

                //Если самый левый элемент является первым потомком
                if (curTree.parent == tree)
                {
                    curTree.left = tree.left;
                    tree.left.parent = curTree;
                    curTree.parent = tree.parent;
                    if (tree == tree.parent.left)
                    {
                        tree.parent.left = curTree;
                    }
                    else if (tree == tree.parent.right)
                    {
                        tree.parent.right = curTree;
                    }
                    return true;
                }
                //Если самый левый элемент НЕ является первым потомком
                else
                {
                    if (curTree.right != null)
                    {
                        curTree.right.parent = curTree.parent;
                    }
                    curTree.parent.left = curTree.right;
                    curTree.right = tree.right;
                    curTree.left = tree.left;
                    tree.left.parent = curTree;
                    tree.right.parent = curTree;
                    curTree.parent = tree.parent;
                    if (tree == tree.parent.left)
                    {
                        tree.parent.left = curTree;
                    }
                    else if (tree == tree.parent.right)
                    {
                        tree.parent.right = curTree;
                    }

                    return true;
                }
            }
            return false;
        }
    }
}
