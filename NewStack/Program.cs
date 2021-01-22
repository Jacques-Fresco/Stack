using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewStack.Model;

namespace NewStack
{
    class Program
    {
        static void Main(string[] args)
        {
            NStack<int> newStack = new NStack<int>();

            newStack.Push(1);
            newStack.Push(2);
            newStack.Push(3);

            int item1 = newStack.Pop();
            int item2 = newStack.Peek();

            Console.WriteLine(item1);
            Console.WriteLine(item2);
            Console.ReadLine();

            LinkedStack<int> linkedStack = new LinkedStack<int>();
            linkedStack.Push(10);
            linkedStack.Push(20);
            linkedStack.Push(30);
            linkedStack.Push(40);
            linkedStack.Push(50);

            Console.WriteLine(linkedStack.Peek()); // 50
            Console.WriteLine(linkedStack.Pop()); // 50
            Console.WriteLine(linkedStack.Pop()); // 40
            Console.WriteLine(linkedStack.Peek()); // 30
            Console.ReadLine();

            ArrayStack<int> arrayStack = new ArrayStack<int>(5);
            arrayStack.Push(100);
            arrayStack.Push(200);
            arrayStack.Push(300);
            arrayStack.Push(400);

            Console.WriteLine(arrayStack.Peek()); 
            Console.WriteLine(arrayStack.Pop()); 
            Console.WriteLine(arrayStack.Pop()); 
            Console.WriteLine(arrayStack.Peek());

            Console.ReadLine();
        }
    }
}
