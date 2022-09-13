using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace DictionaryBinaryTreeLib
{
    public class BinaryTree<TKey, TValue> : IDictionary<TKey, TValue>
    {
        public BinaryTree<TKey, TValue> parent, left, right;
        public int Key { get; private set; }
        public TValue Val { get; private set; }

        public ICollection<TKey> Keys => throw new NotImplementedException();

        public ICollection<TValue> Values => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public TValue this[TKey key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public BinaryTree(int key, BinaryTree<TKey, TValue> parent, TValue val)
        {
            Key = key;
            this.parent = parent;
            Val = val;
        }

        //Добавление ключа и числа
        public void Add(TKey key, TValue val)
        {
            var normalizeKey = key.GetHashCode();
            if (normalizeKey.CompareTo(Key) < 0)
            {
                if (this.left == null)
                {
                    this.left = new BinaryTree<TKey, TValue>(normalizeKey, this, val);
                }
                else if (this.left != null)
                    this.left.Add(key, val);
            }
            else
            {
                if (this.right == null)
                {
                    this.right = new BinaryTree<TKey, TValue>(normalizeKey, this, val);
                }
                else if (this.right != null)
                    this.right.Add(key, val);
            }
        }

        //Поиск по ключу
        public TValue Search(int key)
        {
            return SearchKey(this, key);
        }

        private TValue SearchKey(BinaryTree<TKey, TValue> tree, int key)
        {
            if (tree == null)
            {
                throw new Exception("no such element");
            }
            switch (key.CompareTo(tree.Key))
            {
                case 1:
                    return SearchKey(tree.right, key);
                case -1:
                    return SearchKey(tree.left, key);
                case 0:
                    return tree.Val;
                default:
                    throw new Exception("no such element");
            }
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            Add(item.Key, item.Value);
        }

        public bool ContainsKey(TKey key)
        {
            if(Search(key.GetHashCode()) == null)
            {
                return false;
            }
            else
            {
                return true;
            } 
        }

        public bool Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}