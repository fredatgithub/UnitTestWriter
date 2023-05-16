using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestWriter.Model
{
  internal class UnitTest
  {
    public string ReturnType { get; set; }
    public List<string> ListOfArguments { get; set; }

    public UnitTest() { }
    public UnitTest(string name) { }

  }
}
