using System;
using static System.Console;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQueue = new Queue(5);
            myQueue.insert(5);
            myQueue.insert(6);
            myQueue.insert(7);
            myQueue.insert(8);
            myQueue.insert(9);
            myQueue.view();

            WriteLine("front of the queue is: " + myQueue.peek());
            myQueue.remove();
            WriteLine("after removing one element, the front of the queue is now: " + myQueue.peek());

            string f = ReadLine();
        }
    }

    public class Queue
    {
        private int maxSize;
        private long[] myQueue;
        private int front;
        private int rear;
        private int items;

        public Queue(int sizeInput)
        {
            maxSize = sizeInput;
            myQueue = new long[sizeInput];
            front = 0;
            rear = -1;
            items = 0;
        }

        public void insert(long insertedLong)
        {
            if (isFull())
            {
                WriteLine("the queue is full.");
            }
            if (rear == maxSize - 1)
            {
                rear = -1;
            }
            rear++;
            myQueue[rear] = insertedLong;
            items++;
        }

        public long remove()
        {
            long temp = myQueue[front];
            front++;
            if (front == maxSize)
            {
                front = 0;
            }
            return temp;
        }

        public long peek()
        {
            return myQueue[front];
        }

        public bool isEmpty()
        {
            return (items == 0);
        }

        private bool isFull()
        {
            return (items == maxSize);
        }

        public void view()
        {
            Write("[");
            for (int i = 0; i < myQueue.Length; i++)
            {
                Write(myQueue[i]+", ");
            }
            WriteLine("]");
        }
    }
}
