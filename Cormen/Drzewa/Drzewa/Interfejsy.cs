using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drzewa
{
    interface IDynamicSet<K,V> where K : IComparable
    {
        bool IsKey(K Key);
        V Search(K key);
        V Minimum();
        K MinKey();
        V Maximum();
        K MaxKey();
        V Predecessor(K key);
        K PrevKey(K key);
        V Successor(K key);
        K NextKey(K key);
        void Insert(K key, V value);
        void Delete(K key);
    }
}
