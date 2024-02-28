namespace a
{
    class f
    {
        public int fibor(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }

            return fibor(n - 1) + fibor(n - 2);
        }

        public int[] fibos(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = fibor(i);
            }
            return arr;
        }
    }
}