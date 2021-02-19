using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K,V>
    {
        List<K> key;
        List<V> value;

        public MyDictionary()
        {
            key = new List<K>();
            value = new List<V>();
        }

        public void Add(K new_key, V new_value)
        {
            if (!key.Contains(new_key))
            {
                key.Add(new_key);
                value.Add(new_value);
            }
        }

        public bool ContainsKey(K new_key)
        {
            if (key.Contains(new_key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ContainsValue(V new_value)
        {
            if (value.Contains(new_value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Key(K new_key)
        {
            Console.WriteLine(value[key.IndexOf(new_key)]);
        }

        public void Value(V new_value)
        {
            Console.WriteLine(key[value.IndexOf(new_value)]);
        }

    }
}
