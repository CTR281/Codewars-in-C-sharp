using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_in_C_sharp.Tests.Rot13;

using NUnit.Framework;
using System;
using Codewars_in_C_sharp.Rot13;

[TestFixture]
public class Tests
{
    [Test, Description("test")]
    public void testTest()
    {
        Assert.AreEqual("grfg", Kata.Rot13("test"), String.Format("Input: test, Expected Output: grfg, Actual Output: {0}", Kata.Rot13("test")));
    }

    [Test, Description("Test")]
    public void TestTest()
    {
        Assert.AreEqual("Grfg", Kata.Rot13("Test"), String.Format("Input: Test, Expected Output: Grfg, Actual Output: {0}", Kata.Rot13("Test")));
    }

    [Test, Description("Test")]
    public void TestSpecialCharacters()
    {
        Assert.AreEqual("10+2 vf gjryir.", Kata.Rot13("10+2 is twelve."), String.Format("Input: 10+2 is twelve., Expected Output: 10+2 vf gjryir., Actual Output: {0}", Kata.Rot13("10+2 is twelve.")));
        Assert.AreEqual("P# vf pbby!", Kata.Rot13("C# is cool!"), String.Format("Input: C# is cool!, Expected Output: P# vf pbby!, Actual Output: {0}", Kata.Rot13("C# is cool!")));
    }
}
