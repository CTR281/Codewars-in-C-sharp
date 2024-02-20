using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_in_C_sharp.Tests.MaxSequence;

using NUnit.Framework;
using System;
using Codewars_in_C_sharp.MaxSequence;

[TestFixture]
public class SolutionTest
{
    [Test]
    public void Test0()
    {
        Assert.AreEqual(0, Kata.MaxSequence(new int[0]));
    }
    [Test]
    public void Test1()
    {
        Assert.AreEqual(6, Kata.MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
    }
}