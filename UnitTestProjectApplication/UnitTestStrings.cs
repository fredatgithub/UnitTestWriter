using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectApplication
{
  [TestClass]
  public class UnitTestStrings
  {
    [TestMethod]
    public void TestMethod_test1()
    {
      var source = string.Empty;
      var expected = string.Empty;
      var result = "";
      Assert.AreEqual(expected, result);
    }
  }
}
