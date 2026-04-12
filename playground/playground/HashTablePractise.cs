using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace playground
{
    internal class HashTablePractise
    {
        Hashtable myHash = new Hashtable();
        internal void createHashTable(string[] value)
        {
            int counter = 0;
            foreach (string data in value) {
                counter++;
                myHash.Add(counter, data);
            }
        }
        internal void showHashTable() {
            foreach (DictionaryEntry h in myHash)
            {
                Console.WriteLine($"{h.Key} <-> {h.Value}");
            }
        }
        // add
        // remove  -> ht.Remove("id");
        // ContainsKey -> bool exists = ht.ContainsKey("id");
        // ContainsValue -> bool exists = ht.ContainsValue(101);
        // to access a value in hashtable -> ht["id"]; 
        // to update a valuye in hashtable -> ht["id"] = 400;
        // ht.Clear(); -> remove all elements;
        // Number of elements -> int count = ht.Count;
        // Get All Keys  -->  foreach (var key in ht.Keys) Console.WriteLine(key);
        // Get All values  -->  foreach (var val in ht.Values) Console.WriteLine(val);
        // Enumerator

        internal void showDataUsingEnumerator() { 
            IDictionaryEnumerator en = myHash.GetEnumerator();
            Console.WriteLine("############ ENUMERATOR #############");
            while (en.MoveNext()) {
                Console.WriteLine(en.Key + " --- " + en.Value);
            }
        }
    }
}
