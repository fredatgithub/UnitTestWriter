using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestWriter.Model
{
  public class MethodSignature
  {
    public string MethodSig { get; set; } = string.Empty;
    public string Modifier { get; set; } = string.Empty;
    public bool IsStatic { get; set; } = false;
    public Type ReturnType { get; set; }
    public int NumberOfArguments { get; set; } = 0;
    public MethodSignature()
    {
      MethodSig = string.Empty;
    }

    public MethodSignature(string signature)
    {
      MethodSig = signature;
    }

    public void SetModifier()
    {
      if (MethodSig == string.Empty)
      {
        Modifier = string.Empty;
        return;
      }

      var firstWord = MethodSig.Split(' ')[0];
      switch (firstWord)
      {
        case "public":
          Modifier = "public";
          break;

        case "private":
          Modifier = "private";
          break;

        case "internal":
          Modifier = "internal";
          break;

        default:
          Modifier = string.Empty;
          break;
      }
    }

    public void SetStatic()
    {
      if (MethodSig.Contains("static"))
      {
        IsStatic = true;
      }
      else
      {
        IsStatic = false;
      }
    }

  }
}
