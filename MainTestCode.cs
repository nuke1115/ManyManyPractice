using ShuffleAlgorithm;
using SortingAlgorithm;
using System.Diagnostics;
using Bitfuck;
using aSimpleStack;

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

            SimpleStack<string> testStack1 = new SimpleStack<string>();
            testStack1.Push("a");
            testStack1.Push("b");
            testStack1.Push("c");

            SimpleStack<int[]> simpleStack1 = new SimpleStack<int[]>();
            simpleStack1.Push(a);
            simpleStack1.Push(b);
            simpleStack1.Push(c);

            Console.WriteLine(testStack1.Peek());
            Console.WriteLine(testStack1.Pop());
            Console.WriteLine(testStack1.Count);
            Console.WriteLine(testStack1.Peek());

            //asdf

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