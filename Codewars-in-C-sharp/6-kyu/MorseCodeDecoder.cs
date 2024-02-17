using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_in_C_sharp.MorseCodeDecoder;

public interface MorseCode
{
    string Get(string code);
}
public static class Kata
{
    public static string Decode(string morseCode, MorseCode MorseCode)
    {
        return morseCode.
            Trim().
            Aggregate((new StringBuilder(), new StringBuilder()), ((StringBuilder, StringBuilder) acc, char next) =>
            {
                (StringBuilder nextMorseChar, StringBuilder nextStringChar) = acc;
                if (char.IsWhiteSpace(next))
                {
                    if (nextMorseChar.Length > 0)
                    {
                        if (!char.IsWhiteSpace(nextMorseChar[0]))
                        {
                            nextStringChar.Append(MorseCode.Get(nextMorseChar.ToString()));
                            nextMorseChar.Clear();
                        }
                        else
                        {
                            nextMorseChar.Append(next);
                            if (nextMorseChar.Length == 2)
                            {
                                nextStringChar.Append(next);
                                nextMorseChar.Clear();
                            }
                        }
                    }
                    else
                    {
                        nextMorseChar.Append(next);
                    }
                } else nextMorseChar.Append(next);
                return (nextMorseChar, nextStringChar);
            }, final =>
            {
                (StringBuilder nextMorseChar, StringBuilder nextStringChar) = final;
                return nextStringChar.Append(MorseCode.Get(nextMorseChar.ToString())).ToString();
            });
    }
}
