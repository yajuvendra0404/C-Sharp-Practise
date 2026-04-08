using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace playground
{
    /*
     * Arraylist practise
    */
    internal class CollectionsPractise
    { 
        
        ArrayList myList = new ArrayList();

        internal void AddToList(int [] ele) {
            try {
                if (myList.Contains(ele)) throw new Exception("Element is already present in the list!");
                Console.WriteLine("Element added...");
                myList.AddRange(ele);
            }
            catch (Exception e) { 
                Console.WriteLine(e.Message);
            }
        }
        internal void RemoveFromList(int ele)
        {
            try
            {
                if(myList.Count <= 0) throw new Exception("List is empty!");
                if(!myList.Contains(ele)) throw new Exception("Element not found in the list!");
                Console.WriteLine("Element removed...");
                myList.Remove(ele);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        void InsertTolist() {
            // implementation pending
        }
        internal void ReverseAList(){
            try
            {
                if(myList.Count <= 0) throw new Exception("List is empty!");
                Console.WriteLine("Array reversed...");
                myList.Reverse();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            
        }
        internal void InsertRangeToList(int[] arr,int location) {
            Console.WriteLine("inserting New elements...");

            myList.InsertRange(location, arr);

        }
        internal void PrintArrayList() {
            foreach (int ele in myList) { 
                Console.WriteLine("\n --> "+ele);
            }
        }
        // AddRange
        // InsertRange
        // RemoveRange
        // Contains
        // IndexOf
        // Reverse
        // Count
        // Capacity

    }
}
