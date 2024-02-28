
namespace SortingAlgorithm
{
    /// <summary>
    /// Contatins Sorting Algorithms for Int type array. <br/>
    /// - BubbleSort <br/>
    /// - SelectionSort <br/>
    /// - InsertionSort <br/>
    /// - MergeSort(Top-Down) <br/>
    /// </summary>
    /// <remarks>
    /// To be added more sorting algorithms
    /// </remarks>
    public static class SortingAlgorithms
    {
        /// <summary>
        /// BubbleSort Algorithm <br/>
        /// Receives an Int type array as an input parameter <br/>
        /// and returns a sorted array.
        /// </summary>
        /// <param name="InputArray">
        ///  A Int type array <br/>
        ///  It may be sorted, or it may not be sorted.
        /// </param>
        /// <returns>
        /// A sorted Int type array
        /// </returns>
        /// <remarks>
        /// Time complexity: <br/>
        /// Worst : N(n^2) <br/>
        /// Average : N(n^2) <br/>
        /// Best : N(n) <br/>
        /// <br/>
        /// Memory : 1 <br/>
        /// Stable : Yes
        /// </remarks>
        public static int[] BubbleSort(int[] InputArray)
        {
            bool isSwap = true;
            while (isSwap)
            {
                isSwap = false;
                for (int i = 0; i < InputArray.Length - 1; i++)
                {
                    if (InputArray[i] > InputArray[i + 1])
                    {

                        InputArray[i + 1] ^= InputArray[i];
                        InputArray[i] ^= InputArray[i + 1];
                        InputArray[i + 1] ^= InputArray[i];
                        isSwap = true;
                    }
                }
            }
            return InputArray;
        }

        /// <summary>
        /// SelectionSort Algorithm <br/>
        /// Receives an Int type array as an input parameter <br/>
        /// and returns a sorted array.
        /// </summary>
        /// <param name="InputArray">
        ///  A Int type array <br/>
        ///  It may be sorted, or it may not be sorted.
        /// </param>
        /// <returns>
        /// A sorted Int type array
        /// </returns>
        /// <remarks>
        /// Time complexity: <br/>
        /// Worst : N(n^2) <br/>
        /// Average : N(n^2) <br/>
        /// Best : N(n) <br/>
        /// <br/>
        /// Memory : 1 <br/>
        /// Stable : Yes
        /// </remarks>
        public static int[] SelectionSort(int[] InputArray)
        {
            int tmp = 0;
            int SmallestNumberIndex = 0;
            for (int i = 0; i < InputArray.Length; i++)
            {
                SmallestNumberIndex = i;
                for (int k = i; k < InputArray.Length; k++)
                {
                    if (InputArray[k] < InputArray[SmallestNumberIndex])
                    {
                        SmallestNumberIndex = k;
                    }
                }
                tmp = InputArray[SmallestNumberIndex];
                InputArray[SmallestNumberIndex] = InputArray[i];
                InputArray[i] = tmp;
            }
            return InputArray;
        }

        /// <summary>
        /// SelectionSort Algorithm <br/>
        /// Receives an Int type array as an input parameter <br/>
        /// and returns a sorted array.
        /// </summary>
        /// <param name="InputArray">
        ///  A Int type array <br/>
        ///  It may be sorted, or it may not be sorted.
        /// </param>
        /// <returns>
        /// A sorted Int type array
        /// </returns>
        /// <remarks>
        /// Time complexity: <br/>
        /// Worst : N(n^2) <br/>
        /// Average : N(n^2) <br/>
        /// Best : N(n^2) <br/>
        /// <br/>
        /// Memory : 1 <br/>
        /// Stable : No
        /// </remarks>
        public static int[] InsertionSort(int[] InputArray)
        {
            int k = 0;
            for (int i = 1; i < InputArray.Length; i++)
            {
                k = i;
                while (InputArray[k] < InputArray[k - 1])
                {

                    InputArray[k - 1] ^= InputArray[k];
                    InputArray[k] ^= InputArray[k - 1];
                    InputArray[k - 1] ^= InputArray[k];

                    if (k > 1) { k--; }
                }
            }
            return InputArray;
        }



        
        private static int[] Merge(int[] FirstArray, int[] SecondArray)//A part of MergeSort
        {
            int[] SortedArray = new int[FirstArray.Length + SecondArray.Length];
            int FirstArrayCounter = 0;
            int SecondArrayCounter = 0;
            int SortedArrayCounter = 0;

            while (FirstArrayCounter < FirstArray.Length && SecondArrayCounter < SecondArray.Length)
            {
                if (FirstArray[FirstArrayCounter] < SecondArray[SecondArrayCounter])
                {
                    SortedArray[SortedArrayCounter] = FirstArray[FirstArrayCounter];
                    FirstArrayCounter++;
                }
                else if (SecondArray[SecondArrayCounter] < FirstArray[FirstArrayCounter])
                {
                    SortedArray[SortedArrayCounter] = SecondArray[SecondArrayCounter];
                    SecondArrayCounter++;
                }
                else
                {
                    SortedArray[SortedArrayCounter] = FirstArray[FirstArrayCounter];
                    SortedArrayCounter++;
                    SortedArray[SortedArrayCounter] = SecondArray[SecondArrayCounter];
                    FirstArrayCounter++;
                    SecondArrayCounter++;
                }
                SortedArrayCounter++;
            }

            while (FirstArrayCounter < FirstArray.Length)
            {
                SortedArray[SortedArrayCounter] = FirstArray[FirstArrayCounter];
                FirstArrayCounter++;
                SortedArrayCounter++;
            }

            while (SecondArrayCounter < SecondArray.Length)
            {
                SortedArray[SortedArrayCounter] = SecondArray[SecondArrayCounter];
                SecondArrayCounter++;
                SortedArrayCounter++;
            }

            return SortedArray;
        }

        /// <summary>
        /// MergeSort Algorithm(Top-Down) <br/>
        /// Receives an Int type array as an input parameter <br/>
        /// and returns a sorted array.
        /// </summary>
        /// <param name="InputArray">
        ///  A Int type array <br/>
        ///  It may be sorted, or it may not be sorted.
        /// </param>
        /// <returns>
        /// A sorted Int type array
        /// </returns>
        /// <remarks>
        /// Time complexity: <br/>
        /// Worst : N(n log n) <br/>
        /// Average : N(n log n) <br/>
        /// Best : N(n log n) <br/>
        /// <br/>
        /// Memory : n <br/>
        /// Stable : Yes
        /// </remarks>
        public static int[] MergeSort(int[] InputArray)
        {
            int LastPoint = InputArray.Length;
            

            if (LastPoint <= 1)
            {
                return InputArray;
            }
            int MiddlePoint = LastPoint/ 2;

            int[] LeftArray = new int[MiddlePoint];
            int[] RightArray = new int[LastPoint - MiddlePoint];
            Array.Copy(InputArray, 0, LeftArray, 0, MiddlePoint);
            Array.Copy(InputArray, MiddlePoint, RightArray, 0, LastPoint - MiddlePoint);

            return Merge(MergeSort(LeftArray) , MergeSort(RightArray));
        }























//==================================================== 이 아레부터는 chatgpt가 짠거

        public static int[] TMergeSort(int[] array)
        {
            if (array == null || array.Length <= 1)
            {
                return array;
            }
            int[] tempArray = new int[array.Length];
            TMergeSort(array, tempArray, 0, array.Length - 1);
            return array;
        }

        private static void TMergeSort(int[] array, int[] tempArray, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                TMergeSort(array, tempArray, left, mid);
                TMergeSort(array, tempArray, mid + 1, right);
                TMerge(array, tempArray, left, mid, right);
            }
        }

        private static void TMerge(int[] array, int[] tempArray, int left, int mid, int right)
        {
            // Copy both parts into the temporary array
            for (int vvv = left; vvv <= right; vvv++)
            {
                tempArray[vvv] = array[vvv];
            }

            int i = left;
            int j = mid + 1;
            int k = left;

            // Merge the temporary arrays
            while (i <= mid && j <= right)
            {
                if (tempArray[i] <= tempArray[j])
                {
                    array[k] = tempArray[i];
                    i++;
                }
                else
                {
                    array[k] = tempArray[j];
                    j++;
                }
                k++;
            }

            // Copy the rest of the left side of the array into the target array
            while (i <= mid)
            {
                array[k] = tempArray[i];
                k++;
                i++;
            }
        }
    }
}