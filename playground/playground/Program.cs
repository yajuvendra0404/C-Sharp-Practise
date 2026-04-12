using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playground
{

    internal class LifeCycle
    {
        static int breathCount;

        static LifeCycle() // Static constructor to initialize static members
        {
            breathCount = 0;
            LifeCycle.Breath();
        }
        internal void Eat( string feedback = "Good food!")
        {
            try
            {
                LifeCycle.breathCount++;
                LifeCycle.Breath();
                if(!feedback.ToLower().Contains("good")) throw new Exception("Food is not good!");
                Console.WriteLine("Eating food...");
            }
            catch (Exception e) { 
                Console.WriteLine(e.Message);
            }
            
        }

        internal void Sleep()
        {
            LifeCycle.breathCount++;
            LifeCycle.Breath();
            Console.WriteLine("Sleeping");
        }

        internal static void Breath() { 

            Console.WriteLine("#### ...Breathing... ####");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //LifeCycle life = new LifeCycle();
            //life.Eat("bad");
            //life.Sleep();
            //LifeCycle.Breath();

            //Console.WriteLine(" ################################################# ");

            //CollectionsPractise cp = new CollectionsPractise();
            //cp.AddToList(new int[] { 1, 2, 3, 4, 5 });
            //cp.PrintArrayList();
            //cp.ReverseAList();
            //cp.PrintArrayList();
            //cp.RemoveFromList(3);
            //cp.PrintArrayList();
            //Console.WriteLine(" ################################################## ");
            
            HashTablePractise hp = new HashTablePractise();
            hp.createHashTable(new string[] { "apple", "orange", "grape", "tomato", "potato" });
            hp.showHashTable();
            hp.showDataUsingEnumerator();


        }
    }

}
