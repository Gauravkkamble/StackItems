using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Stack<int> myStack = new Stack<int>();

             Stack<string> Stack = new Stack<string>();
            
            Stack.Push("G");
            Stack.Push("A");
            Stack.Push("U");
            Stack.Push("R");
            Stack.Push("A");
            Stack.Push("V");
            Console.WriteLine("Current stack: ");
            foreach (String c in Stack)
            {
                Console.WriteLine(c + ",");
            }
                

            /*Console.ReadKey();
            Console.Write("Number of element is Stack", myStack.Count);

            while (myStack.Count > 0)
                Console.Write(myStack.Pop() + ",");
            Console.ReadKey();

            Console.Write("Number of element is Stack", myStack.Count);
            */
            Console.ReadKey();
            Console.WriteLine("Poppable item: ",Stack.Pop());
            Console.WriteLine("Current Stack Items: ");
            foreach (String c in Stack)
            {
                Console.WriteLine(c + ",");
            }
            Console.WriteLine("Removing two items:");
            Stack.Pop();
            Stack.Pop();
            Stack.Push("Kamble");
            Stack.Push("");
            Console.WriteLine("Latest Stack: ");
          
            foreach (String c in Stack)
            {
                Console.WriteLine(c + ",");
            }
            Console.WriteLine("element at index of {1}" + Stack.ElementAt(1));
           
            Stack.Clear();
            Console.WriteLine("Removed All items: ");
            Console.ReadKey();
        }
    }
    
}
