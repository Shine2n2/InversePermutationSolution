using System;

namespace InversePermutationSolution
{
    public class Program
    {
        static void Main(string[] args)
        {   
            //To test
            Permutation per = new Permutation();    
            int[] arr = { 1, 4, 3, 2 };
            int size = 4;
            var output = per.InversePermutation(arr, size);
                        
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

        }
    }
}
