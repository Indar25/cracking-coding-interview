namespace DSA.String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringProblem problem = new StringProblem();
            //Console.WriteLine(problem.GetPermutations("abbc", "cbabadcbbabbcbabaabccbabc"));

            //Console.WriteLine(problem.IsUnique("abcdf"));

            //Console.WriteLine(problem.IsPermutation("abcdf", "abcdf"));

            Console.WriteLine(problem.URLify("Mr John Smith    ".ToCharArray(), 13));


            Console.ReadKey();
        }
    }
}
