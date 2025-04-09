using Azure;
using Azure.Storage;
using Azure.Storage.Blobs;

namespace DSA.Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayProblem problem = new ArrayProblem();

            int[] arr1 = { 13, 27, 35, 40, 49, 55, 59 };
            int[] arr2 = { 17, 35, 39, 40, 55, 58, 60 };

            var result = problem.CommonNumbers(arr1, arr2);

            Console.WriteLine("Hello, World!");
        }
    }
}
