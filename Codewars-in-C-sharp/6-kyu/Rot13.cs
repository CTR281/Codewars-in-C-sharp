using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_in_C_sharp.Rot13;

public static class Kata
{
    public static string Rot13(string message) // 'd' -> (char)('a' + ('d' - 'a' + 13) % 26)
    {
        return message
            .Aggregate(
            new StringBuilder(), 
            (sb, next) =>
                {
                    if (!char.IsLetter(next)) return sb.Append(next);
                    if (char.IsLower(next)) return sb.Append((char)('a' + (next - 'a' + 13) % 26));
                    else return sb.Append((char)('A' + (next - 'A' + 13) % 26));
                }, 
            final => final.ToString());
    }
}
