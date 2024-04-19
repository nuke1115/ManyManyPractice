using ShuffleAlgorithm;
using SortingAlgorithm;
using System.Diagnostics;
using Bitfuck;
using aSimpleStack;
using aSImpleQueue;
using System;
using aQueue;
using System.ComponentModel;
using System.Numerics;

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

            CircularQueue<int> circularQueue = new CircularQueue<int>(3);
            
            circularQueue.Enqueue(1);
            Console.WriteLine(circularQueue.Dequeue());

			circularQueue.Enqueue(2);
			Console.WriteLine(circularQueue.Dequeue());

			circularQueue.Enqueue(3);
			Console.WriteLine(circularQueue.Dequeue());

			circularQueue.Enqueue(4);
			Console.WriteLine(circularQueue.Dequeue());

			circularQueue.Enqueue(5);
			Console.WriteLine(circularQueue.Dequeue());

			circularQueue.Enqueue(6);
			Console.WriteLine(circularQueue.Dequeue());

			circularQueue.Enqueue(7);
			Console.WriteLine(circularQueue.Dequeue());


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

