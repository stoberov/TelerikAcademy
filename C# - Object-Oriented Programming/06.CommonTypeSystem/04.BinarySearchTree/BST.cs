// Solution help from Andon Andonov from the forum

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

internal class BST<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, ICloneable where TKey : IComparable<TKey>
{
    private TreeNode root = null;

    public ICollection<TKey> Keys
    {
        get
        {
            ICollection<TKey> keys = new List<TKey>();
            this.InorderTreeWalk(this.root, x => keys.Add(x.Key));
            return keys;
        }
    }

    public ICollection<TValue> Values
    {
        get
        {
            ICollection<TValue> values = new List<TValue>();
            this.InorderTreeWalk(this.root, x => values.Add(x.Value));
            return values;
        }
    }

    public TValue this[TKey key]
    {
        get
        {
            TreeNode searchResult = this.Search(this.root, key);
            if (searchResult == null)
            {
                throw new KeyNotFoundException();
            }

            return searchResult.Value;
        }

        set
        {
            TreeNode searchResult = this.Search(this.root, key);
            if (searchResult == null)
            {
                throw new KeyNotFoundException();
            }

            searchResult.Value = value;
        }
    }

    public void Add(TKey key, TValue value)
    {
        TreeNode newNode = new TreeNode(key, value, null, null, null);
        this.Insert(newNode);
    }

    public bool Remove(TKey key)
    {
        TreeNode node = this.Search(this.root, key);
        if (node == null)
        {
            return false;
        }

        this.Delete(node);

        return true;
    }

    public void Clear()
    {
        this.root = null;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        this.InorderTreeWalk(this.root, x => sb.AppendFormat("[K: {0}; V: {1}] ", x.Key, x.Value));
        return sb.ToString();
    }

    public override int GetHashCode()
    {
        int hash = 0;
        this.InorderTreeWalk(this.root, x => hash ^= x.GetHashCode());
        return hash;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }

        BST<TKey, TValue> tree = obj as BST<TKey, TValue>;
        if ((object)tree == null)
        {
            return false;
        }

        ICollection<TKey> thisKeys = this.Keys;
        ICollection<TKey> otherKeys = tree.Keys;

        if (thisKeys.Count != otherKeys.Count)
        {
            return false;
        }

        for (int i = 0; i < thisKeys.Count; i++)
        {
            if (thisKeys.ElementAt(i).CompareTo(otherKeys.ElementAt(i)) != 0)
            {
                return false;
            }
        }

        return true;
    }

    // IEnumerable Methods -----------------------------
    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        IList<KeyValuePair<TKey, TValue>> elems = new List<KeyValuePair<TKey, TValue>>();
        this.InorderTreeWalk(this.root, x => elems.Add(new KeyValuePair<TKey, TValue>(x.Key, x.Value)));

        foreach (var elem in elems)
        {
            yield return elem;
        }
    }

    public BST<TKey, TValue> Clone()
    {
        BST<TKey, TValue> newTree = new BST<TKey, TValue>();
        this.PreorderTreeWalk(this.root, x => newTree.Add(x.Key, x.Value));
        return newTree;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    // ICloneable Methods -----------------------------
    object ICloneable.Clone()
    {
        return this.Clone();
    }

    // Private Methods --------------------------------
    private void InorderTreeWalk(TreeNode node, Action<TreeNode> action)
    {
        if (node != null)
        {
            this.InorderTreeWalk(node.Left, action);
            action(node);
            this.InorderTreeWalk(node.Right, action);
        }
    }

    private void PreorderTreeWalk(TreeNode node, Action<TreeNode> action)
    {
        if (node != null)
        {
            action(node);
            this.PreorderTreeWalk(node.Left, action);
            this.PreorderTreeWalk(node.Right, action);
        }
    }

    private TreeNode Search(TreeNode node, TKey key)
    {
        int cmp = key.CompareTo(node.Key);

        if (node == null || cmp == 0)
        {
            return node;
        }

        if (cmp < 0)
        {
            return this.Search(node.Left, key);
        }
        else
        {
            return this.Search(node.Right, key);
        }
    }

    private void Insert(TreeNode newNode)
    {
        TreeNode parentNode = null;
        TreeNode currentNode = this.root;

        while (currentNode != null)
        {
            parentNode = currentNode;
            if (newNode.Key.CompareTo(currentNode.Key) < 0)
            {
                currentNode = currentNode.Left;
            }
            else
            {
                currentNode = currentNode.Right;
            }
        }

        newNode.Parent = parentNode;

        if (parentNode == null)
        {
            this.root = newNode;
        }
        else if (newNode.Key.CompareTo(parentNode.Key) < 0)
        {
            parentNode.Left = newNode;
        }
        else if (newNode.Key.CompareTo(parentNode.Key) > 0)
        {
            parentNode.Right = newNode;
        }
        else
        {
            parentNode.Value = newNode.Value;
        }
    }

    private void Delete(TreeNode node)
    {
        if (node.Left == null)
        {
            this.Transplant(node, node.Right);
        }
        else if (node.Right == null)
        {
            this.Transplant(node, node.Left);
        }
        else
        {
            TreeNode y = this.Minimum(node.Right);
            if (!y.Parent.Equals(node))
            {
                this.Transplant(y, y.Right);
                y.Right = node.Right;
                y.Right.Parent = y;
            }

            this.Transplant(node, y);
            y.Left = node.Left;
            y.Left.Parent = y;
        }
    }

    private void Transplant(TreeNode u, TreeNode v)
    {
        if (u.Parent == null)
        {
            this.root = v;
        }
        else if (u.Equals(u.Parent.Left))
        {
            u.Parent.Left = v;
        }
        else 
        {
            u.Parent.Right = v;
        }

        if (v != null)
        {
            v.Parent = u.Parent;
        }
    }

    private TreeNode Minimum(TreeNode node)
    {
        while (node.Left != null)
        {
            node = node.Left;
        }

        return node;
    }

    public static bool operator ==(BST<TKey, TValue> first, BST<TKey, TValue> second)
    {
        return first.Equals(second);
    }

    public static bool operator !=(BST<TKey, TValue> first, BST<TKey, TValue> second)
    {
        return !(first == second);
    }

    private class TreeNode
    {
        public TreeNode(TKey key, TValue val, TreeNode left, TreeNode right, TreeNode parent)
        {
            this.Key = key;
            this.Value = val;
            this.Left = left;
            this.Right = right;
            this.Parent = parent;
        }

        public TKey Key { get; set; }

        public TValue Value { get; set; }

        public TreeNode Left { get; set; }

        public TreeNode Right { get; set; }

        public TreeNode Parent { get; set; }

        public override int GetHashCode()
        {
            return this.Key.GetHashCode() ^ this.Value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            TreeNode node = obj as TreeNode;
            if ((object)node == null)
            {
                return false;
            }

            return this.Key.CompareTo(node.Key) == 0;
        }
    }
}