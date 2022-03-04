using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Score.Models;

namespace Score.Tests
{
  [TestClass]
  public class ValueTests 
  {

    [TestMethod]
    public void ScrabbleScore_GetOneLetterScore_1()
    {
      Assert.AreEqual(1, Value.ScrabbleScore("a"));
    }
    [TestMethod]
    public void ScrabbleScore_GetThreeLetterScore_5()
    {
      Assert.AreEqual(5, Value.ScrabbleScore("Cat"));
    }
    [TestMethod]
    public void ScrabbleScore_GetLargeWordScore_22()
    {
      Assert.AreEqual(22, Value.ScrabbleScore("expectation"));
    }
  }
}