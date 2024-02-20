using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_in_C_sharp.Tests.Likes;

using NUnit.Framework;
using Codewars_in_C_sharp.Likes;

[TestFixture]
public class Tests
{
    [Test, Description("It should return correct text")]
    public void SampleTest()
    {
        Assert.AreEqual("no one likes this", Kata.Likes(new string[0]));
        Assert.AreEqual("Peter likes this", Kata.Likes(new string[] { "Peter" }));
        Assert.AreEqual("Jacob and Alex like this", Kata.Likes(new string[] { "Jacob", "Alex" }));
        Assert.AreEqual("Max, John and Mark like this", Kata.Likes(new string[] { "Max", "John", "Mark" }));
        Assert.AreEqual("Alex, Jacob and 2 others like this", Kata.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
    }
}
