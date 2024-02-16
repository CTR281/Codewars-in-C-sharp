using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_in_C_sharp.IsPangram;

public static class Kata
{
    public static bool IsPangram(string str)
    {
        return str.
        Aggregate(
            new HashSet<char>(),
            (alphabet, next) =>
            {
                if (char.IsLetter(next)) alphabet.Add(char.ToLower(next));
                return alphabet;
            },
            alphabet => alphabet.Count == 26
        );
    }
}

