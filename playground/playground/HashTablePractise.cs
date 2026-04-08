using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playground
{
    internal class HashTablePractise
    {
        Hashtable myHash = new Hashtable();
        internal void createHashTable(int[] value)
        {
            int counter = 0;
            foreach (int key in value) {
                counter++;
                myHash.Add(counter, value);
            }
        }
        internal void showHashTable() {
            foreach (DictionaryEntry h in myHash)
            {
                Console.WriteLine($"{h.Key} <-> {h.Value}");
            }
        }
    }
}
