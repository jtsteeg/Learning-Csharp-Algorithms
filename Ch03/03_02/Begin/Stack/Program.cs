using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack(4);
            myStack.push("star wars");
            myStack.push("the goonies");
            myStack.push("The Godfather");
            myStack.push("home alone 7: the loneliest home");
            myStack.push("jaws");

            Console.WriteLine("--------------------- lets take a peek: " +myStack.peek());

            Console.WriteLine("--------------------- The stack contains ");
            while (!myStack.isEmpty())
            {
                string movie = myStack.pop();
                Console.WriteLine(movie);
            }
            string f = Console.ReadLine();
        }
    }

    public class Stack
    {
        private int maxSize;
        private string[] stackArray;
        private int top;

        public Stack(int sizeInput)
        {
            maxSize = sizeInput;
            stackArray = new string[maxSize];
            top = -1;
        }

        public void push(string inputString)
        {
            if (isFull())
            {
                Console.WriteLine("the stack is full");
            }
            else
            {
                top++;
                stackArray[top] = inputString;
            }
        }

        private bool isFull()
        {
            return (maxSize - 1 == top);
        }

        public string pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("The stack is empty");
                return "--";
            }
            else
            {
                int oldTop = top;
                top--;
                return stackArray[oldTop];
            }
        }

        public bool isEmpty()
        {
            return (top == -1);
        }

        public string peek()
        {
            return stackArray[top];
        }
    }
}
