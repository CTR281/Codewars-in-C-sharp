using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_in_C_sharp.MaxSequence;

public static class Kata
{
    public static int MaxSequence(int[] arr)
    {
        if (arr.Length == 0) return 0;
        int[] dp = new int[arr.Length];
        dp[0] = arr[0];
        int result = 0;
        for (int k = 1; k < arr.Length; k++)
        {
            dp[k] = Math.Max(arr[k] + dp[k - 1], arr[k]);
            result = Math.Max(result, dp[k]);
        }
        return result;
    }
}