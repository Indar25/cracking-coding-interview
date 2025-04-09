namespace DSA.Array
{
    internal class ArrayProblem
    {
        public List<int> CommonNumbers(int[] arr1, int[] arr2)
        {
            List<int> result = new List<int>();
            int p1 = 0;
            int p2 = 0;

            while (p1 < arr1.Length && p2 < arr2.Length)
            {
                if (arr1[p1] < arr2[p2])
                {
                    p1++;
                }
                else if (arr1[p1] > arr2[p2])
                {
                    p2++;
                }
                else
                {
                    result.Add(arr1[p1]);
                    p1++;
                    p2++;
                }
            }

            return result;
        }
    }
}
