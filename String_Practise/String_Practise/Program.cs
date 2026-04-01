using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "Canada";
            Console.WriteLine(name.Length);


            string city = "Toronto";
            Console.WriteLine(city.ToUpper());
            Console.WriteLine(city.ToLower());


            string text = "   Hello World   ";
            Console.WriteLine(text.Trim());
            Console.WriteLine(text.TrimStart());
            Console.WriteLine(text.TrimEnd());


            string sentence = "I live in Canada";
            Console.WriteLine(sentence.Contains("Canada"));


            string file = "report.pdf";
            Console.WriteLine(file.StartsWith("report"));
            Console.WriteLine(file.EndsWith(".pdf"));


            string greet = "Hello World";
            Console.WriteLine(greet.IndexOf("World"));


            string text2 = "one two one two";
            Console.WriteLine(text2.LastIndexOf("one"));


            string textSub = "Programming";
            Console.WriteLine(textSub.Substring(3));
            Console.WriteLine(textSub.Substring(3, 4));



            string text3 = "I like Java";
            string result = text3.Replace("Java", "C#");
            Console.WriteLine(result);

            string data = "apple,banana,orange";

            string[] fruits = data.Split(',');
            foreach (string f in fruits)
            {
                Console.WriteLine(f);
            }

            ///////////////////////////////////////////////
            string res = String.Join("-", fruits);
            Console.WriteLine(result);
            ///////////////////////////////////////////////


            string a = "hello";
            string b = "hello";

            Console.WriteLine(a.Equals(b));


            string text4 = "";
            Console.WriteLine(String.IsNullOrEmpty(text4)); //True

            string text5 = "   ";
            Console.WriteLine(String.IsNullOrWhiteSpace(text5)); // True


            string result2 = String.Concat("Hello", " ", "World");

            Console.WriteLine(result2); // Hello World

            string text6 = "HelloWorld";

            Console.WriteLine(text6.Remove(5)); // Hello
        }
    }
}
