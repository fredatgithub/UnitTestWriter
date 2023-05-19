using System;
using System.Collections.Generic;

namespace UnitTestWriter.Model
{
  internal class UnitTest
  {
    public string Method { get; set; } = string.Empty;

    public UnitTest()
    {
      Method = "[TestMethod]" + Environment.NewLine;
      Method += "public void TestMethod";
      Method += "{" + Environment.NewLine;
      Method += "var source = " + Environment.NewLine;
    }

    public void AddUnitTestName(string name)
    {
      Method += $"_{name}(){Environment.NewLine}";
    }

    public void AddExpectedHeader()
    {
      Method += "var expected = ";
    }

    public void AddResultHeader()
    {
      Method += "var result = ";
    }

    public void AddAssertAreEqual()
    {
      Method += "Assert.AreEqual(expected, result);";
    }

    public void CloseParenthesis()
    {
      Method += "}" + Environment.NewLine;
    }
  }
}
