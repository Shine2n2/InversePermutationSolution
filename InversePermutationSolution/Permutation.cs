using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversePermutationSolution
{
    public class Permutation
    {               
           public int[] InversePermutation(int[] arr, int size)
            {
                int i, j;
                int[] result = new int[size];

                for (i = 0; i < size; i++)
                    {
                        for (j = 0; j < size; j++)
                        {                        
                            if (arr[j] == i + 1)
                            {
                                int items  = j + 1;
                                result[i] = items;                        
                            }
                        }
                    }            
                
                return result; 
            }
    }
}


