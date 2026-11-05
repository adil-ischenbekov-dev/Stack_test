using System;
using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Security;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace Stack_test
{
    class Program3
    {

        static void Main(string[] args)
        {
            Stack<char> stapel = new Stack<char>();
            string text = "anna";
            foreach (char c in text)
            {
                stapel.Push(c);
            }

            string umgedreht = "";
            while (stapel.TryPop(out char item))
            {
                umgedreht = umgedreht + item;

            }
            if (umgedreht == text)
            {
                Console.WriteLine("Ist Palindrom");
            }
            else
            {
                Console.WriteLine("Keine Palindrom");
            }
        }
    }
}
