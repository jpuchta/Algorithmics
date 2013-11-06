using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drzewa
{
    public abstract class DrzewoBST<K,V> : IDynamicSet<K,V> where K:IComparable
    {
        protected class Node<Ka, Vi>
        {
            public Ka Key { get; set; }
            public Vi Value { get; set; }
            public Node<Ka, Vi> Parent { get; set; }
            public Node<Ka, Vi> Left { get; set; }
            public Node<Ka, Vi> Right { get; set; }

            public Node(Ka key, Vi value, Node<Ka,Vi> par=null, Node<Ka,Vi> l=null,Node<Ka,Vi> r=null)
            {
                this.Key = key;
                this.Value = value;
                this.Parent = par;
                this.Left = l;
                this.Right = r;
            }
        }
        protected Node<K,V> Root;

        static public List<V> InorderTree2List(DrzewoBST<K,V> Tree)
        {
            return InorderSubTree2List(Tree.Root);
        }
        protected static List<V> InorderSubTree2List(Node<K,V> N)
        {
            if (N == null)
            return new List<V>();
            else
            {
                List<V> Result= InorderSubTree2List(N.Left);
                Result.Add(N.Value);
                Result.AddRange(InorderSubTree2List(N.Right));
                return Result;
            }
        }

        #region Funkcje pomocnicze dla interfejsu
        protected static Node<K, V> Search(K key, Node<K,V> N)
        {
            if (N == null || key.CompareTo(N.Key)==0)
                return N;
            else
            {
                if (key.CompareTo(N.Key) < 0)
                {
                    return Search(key, N.Left);
                }
                else
                {
                    return Search(key, N.Right);
                }
            }
        }

        protected static Node<K, V> SubTreeMin(Node<K, V> N)
        {
            if (N.Left != null)
                return SubTreeMin(N.Left);
            else return N;
        }
        protected static Node<K, V> SubTreeMax(Node<K, V> N)
        {
            if (N.Right != null)
                return SubTreeMin(N.Right);
            else return N;
        }

        protected static Node<K, V> Predecessor(Node<K, V> N)
        {
            if (N.Left != null)
                return SubTreeMax(N.Left);
            else
            {
                Node<K, V> y = N.Parent;
                Node<K, V> x = N;
                while (y != null && y.Left == x)
                {
                    x = y;
                    y = y.Parent;
                }
                return y;
            }
        }
        protected static Node<K, V> Successor(Node<K, V> N)
        {
            if (N.Right != null)
                return SubTreeMin(N.Right);
            else
            {
                Node<K, V> y = N.Parent;
                Node<K,V> x=N;
                while (y != null && y.Right == x)
                {
                    x = y;
                    y = y.Parent;
                }
                return y;
            }
        }
        #endregion


        #region Implementacja interfejsu IDynamicSet
        public bool IsKey(K Key)
        {
            return (Search(Key, this.Root) != null);
        }

        public V Search(K key)
        {// dodac obsluge tego, ze nie znalazl
            return Search(key, this.Root).Value;
        }

        public V Minimum()
        {
            return SubTreeMin(this.Root).Value; //zaimplementowac wyjatek dla pustego drzewa
        }

        public K MinKey()
        {
            return SubTreeMin(this.Root).Key; //zaimplementowac wyjatek dla pustego drzewa
        }

        public V Maximum()
        {
            return SubTreeMax(this.Root).Value; //zaimplementowac wyjatek dla pustego drzewa
        }

        public K MaxKey()
        {
            return SubTreeMax(this.Root).Key; //zaimplementowac wyjatek dla pustego drzewa
        }

        public V Predecessor(K key)
        {
            return Predecessor(Search(key, this.Root)).Value;
        }

        public K PrevKey(K key)
        {
            return Predecessor(Search(key, this.Root)).Key ;
        }

        public V Successor(K key)
        {
            return Successor(Search(key, this.Root)).Value;
        }

        public K NextKey(K key)
        {
            return Successor(Search(key, this.Root)).Key;
        }

        public void Insert(K key, V value)
        {
            Node<K, V> x, y;
            y = null; x = this.Root;
            while (x != null)
            {
                y = x;
                if (key.CompareTo(x.Key) < 0)
                    x = x.Left;
                else
                    x = x.Right;
            }
            Node<K,V> z=new Node<K,V>(key,value,y);
            if (y == null)
                this.Root = z;
            else
            {
                if (key.CompareTo(y.Key) < 0)
                    y.Left = z;
                else
                    y.Right = z;
            }

        }

        public void Delete(K key)
        {
            Node<K,V> z=Search(key,this.Root); //zaimplementowac obsluge pustego
            Node<K, V> x, y;

            if (z.Left == null || z.Right == null)
                y = z;
            else
                y = Successor(z);

            if (y.Left != null)
                x = y.Left;
            else
                x = y.Right;

            if (x != null)
                x.Parent = y.Parent;

            if (y.Parent == null)
            {
                this.Root = x;
            }
            else
            {
                if (y == y.Parent.Left)
                    y.Parent.Left = x;
                else
                    y.Parent.Right = x;
            }

            if (y != z)
            {
                z.Key = y.Key;
                z.Value = y.Value;
            }

        }
        #endregion
    }
}
