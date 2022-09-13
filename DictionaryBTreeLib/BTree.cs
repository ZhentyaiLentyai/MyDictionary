using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace DictionaryBTreeLib
{
    public class BTree<TKey,TValue> : IDictionary<TKey, TValue>
    {
        int _nodeBatchSize;
        BTreeNode<TValue> root;

        public BTree(int nodeBatchSize)
        {
            root = null;
            _nodeBatchSize = nodeBatchSize;
        }

        public TValue this[TKey key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ICollection<TKey> Keys => throw new NotImplementedException();

        public ICollection<TValue> Values => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(TKey key, TValue val)
        {
            var normalizedKey = key.GetHashCode();
            if (root == null)
            {
                root = new BTreeNode<TValue>(_nodeBatchSize, true);
                root.keys[0] = normalizedKey;
                root.values[0] = val;
                root.n = 1;
            }
            else
            {
                if (root.n == 2 * _nodeBatchSize - 1)
                {
                    BTreeNode<TValue> childeNode = new BTreeNode<TValue>(_nodeBatchSize, false);

                    childeNode.branches[0] = root;

                    childeNode.SplitChild(0, root);

                    int i = 0;
                    if (childeNode.keys[0] < normalizedKey)
                        i++;

                    childeNode.branches[i].InsertNonFull(normalizedKey, val);

                    root = childeNode;
                }
                else
                    root.InsertNonFull(normalizedKey, val);
            }
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            Add(item.Key, item.Value);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(TKey key)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public TValue Search(TKey key)
        {
           return root.SearchKey(key.GetHashCode());
        }

        public bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
        {
            value = default(TValue);
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}