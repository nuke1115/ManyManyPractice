using ShuffleAlgorithm;
using SortingAlgorithm;
using System.Diagnostics;
using Bitfuck;
using aSimpleStack;
using aSImpleQueue;
using System;

namespace NonNonN
{
    public class NoName
    {
        
        public static void Main()
        {
            NoName nn = new NoName();
            nn.start();
        }
        public void start()
        {
            //BitPrac.BitSwapTest();
            //BitPrac.BitMaskTest();
            //BitPrac.BitTest();



            int[] a = { 1, 2, 3, 4 };
            int[] b = { 1, 2, 3, 4 };
            int[] c = { 1, 2, 3, 4 };

            LinkedList<int> l = new LinkedList<int>();

           
            SimpleQueue<int> simpleQueue = new SimpleQueue<int>();

            Console.WriteLine(simpleQueue.GetItemCount);
            Console.WriteLine(simpleQueue.GetItemType);
            Console.WriteLine("=====");
            simpleQueue.Enqueue(1);
            Console.WriteLine(simpleQueue.GetItemCount);
            simpleQueue.Enqueue(2);
            Console.WriteLine(simpleQueue.GetItemCount);
            simpleQueue.Enqueue(3);
            Console.WriteLine(simpleQueue.GetItemCount);
            Console.WriteLine("=====");
            Console.WriteLine(simpleQueue.GetItemCount);
            Console.WriteLine("=====");
            Console.WriteLine(simpleQueue.Peek());
            Console.WriteLine(simpleQueue.GetItemCount);
            Console.WriteLine(simpleQueue.Dequeue());
            Console.WriteLine(simpleQueue.GetItemCount);
            Console.WriteLine(simpleQueue.Dequeue());
            Console.WriteLine(simpleQueue.GetItemCount);
            Console.WriteLine("=====");
            Console.WriteLine(simpleQueue.Contains(1));
            Console.WriteLine(simpleQueue.Contains(3));














            //asdf
            Stack<int> stack = new Stack<int>();
            SimpleStack<int> simpleStack = new SimpleStack<int>();
        }







        public void Print(int[] TestArray)
        {
            foreach (int i in TestArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("============");
        }
    }
}