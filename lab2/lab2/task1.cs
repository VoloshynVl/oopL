namespace lab2
{
    public static class ArrayExtensions
    {
        public static void FindMinMax(this int[] array, out int min, out int max)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array is empty or null.");
            }

            min = array[0];
            max = array[0];

            foreach (var num in array)
            {
                if (num < min)
                {
                    min = num;
                }

                if (num > max)
                {
                    max = num;
                }
            }
        }
    }
}