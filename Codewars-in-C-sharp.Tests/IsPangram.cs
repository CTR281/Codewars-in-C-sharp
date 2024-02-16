using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Codewars_in_C_sharp.IsPangram;

namespace Codewars_in_C_sharp.Tests.IsPangram;

[TestFixture]
public class Tests
{
    [Test]
    public void SampleTests()
    {
        Assert.AreEqual(true, Kata.IsPangram("The quick brown fox jumps over the lazy dog."));
        Assert.That(Kata.IsPangram("OK"), Is.EqualTo(false));
    }
}

