using System;
using System.Collections.Generic;
using System.Text;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int, string> products = new MyDictonary<int, string>();
            products.Add(1, "masa");
            products.Add(2, "bilgisayar");
            products.Add(3, "koltuk");

            Console.WriteLine(products.Count);

        }
    }

    class MyDictonary<K, V>
    {
        K[] key;
        V[] value;

        public MyDictonary()
        {
            key = new K[0];
            value = new V[0];
        }

        public void Add(K keys, V values)
        {
            K[] tempKey = key;
            key = new K[key.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                key[i] = tempKey[i];
            }

            key[key.Length - 1] = keys;

            V[] tempValue = value;
            value = new V[value.Length + 1];
            for (int j = 0; j < tempValue.Length; j++)
            {
                value[j] = tempValue[j];
            }
            value[value.Length - 1] = values;

        }
        public int Count
        {
            get { return key.Length; }
        }
    }


}