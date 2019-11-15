using System;
using System.Collections.Generic;
using System.Linq;

namespace lab5___hashtables
{

    public struct KeyValue<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }
    }

    public class HashTable<K, V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;

        // this.size should be initialized as the new size
        // the linked list holding the hashtable items should be of init size == size
        public HashTable(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K,V>>[size];
        }

        // return position in array based on key.
        // use object.GetHashCode() to calculate the hashcode
        // you might have to do a Math.Abs() over the result ;)
        protected int GetArrayPosition(K key)
        {
            var pos = Math.Abs(key.GetHashCode()) % this.size;
            return pos;
        }

        // if the linked list already exists, return it
        // otherwise, create a new linkedlist, insert it in the array at position
        // then return it
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            if (items[position] == null) {
                items[position] = new LinkedList<KeyValue<K, V>>();
            }
            return items[position];
        }

        // get the linked list in the array
        // iterate through the items
        // and return item only if it's key is equal to the key of the element == key
        public V Find(K key)
        {
            var lookUpList = GetLinkedList(GetArrayPosition(key));
            return lookUpList.Where(elem => elem.Key.Equals(key)).FirstOrDefault().Value;
        }

        // get the array position
        // get the linkedlist at position
        // insert item in linked list (you may use .AddLast)
        public void Add(K key, V value)
        {
            var lookUpList = GetLinkedList(GetArrayPosition(key));
            lookUpList.Append(new KeyValue<K, V>() {Key = key, Value = value});
        }

        // no instructions.
        // this is a challenge
        public void Remove(K key)
        {
            var lookUpList = GetLinkedList(GetArrayPosition(key));
            foreach (var elem in lookUpList.Where(elem => elem.Key.Equals(key)).ToList())
            {
                lookUpList.Remove(elem);
            }
        }
    }
    class Program {
        static void Main(string[] args)
        {
            HashTable<int, string> hash = new HashTable<int, string>(20);

            hash.Add(1, "item 1");
            hash.Add(3, "item 2");
            hash.Add(2, "sadsadsadsad");

            string one = hash.Find(3);
            string two = hash.Find(5);
            string test = hash.Find(99);

            hash.Remove(3);
            hash.Remove(99);
        }
    }

}
