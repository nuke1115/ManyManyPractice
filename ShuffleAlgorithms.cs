

namespace ShuffleAlgorithm
{
    public static class ShuffleAlgorithms
    {
        public static int[] FisherYates(int[] InputArray)
        {
            int tmp;
            Random random = new Random();
            for (int i = 0; i < InputArray.Length; i++)
            {
                int randnum = random.Next(i, InputArray.Length);
                tmp = InputArray[i];
                InputArray[i] = InputArray[randnum];
                InputArray[randnum] = tmp;
            }
            return InputArray;
        }
    }
}
