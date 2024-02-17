using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_in_C_sharp.FindEvenIndex;

public class Kata
{
    public static int FindEvenIndex(int[] arr)
    {
        int n = arr.Length;
        int[] prefixSumLeft = new int[n];
        for (int k = 0; k < n - 1; k++)
        {
            prefixSumLeft[k + 1] = prefixSumLeft[k] + arr[k];
        }

        int[] prefixSumRight = new int[n];
        for (int k = n - 2; k >= 0; k--)
        {
            prefixSumRight[k] = prefixSumRight[k + 1] + arr[k + 1];
        }

        for (int k = 0; k < n; k++)
        {
            if (prefixSumLeft[k] == prefixSumRight[k]) return k;
        }
        return -1;
    }
}
