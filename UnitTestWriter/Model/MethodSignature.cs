using System;
using System.Collections.Generic;

namespace UnitTestWriter.Model
{
  public class MethodSignature
  {
    public string Name { get; set; } = string.Empty;
    public string MethodSig { get; set; } = string.Empty;
    public string Modifier { get; set; } = string.Empty;
    public bool IsStatic { get; set; } = false;
    public Type ReturnType { get; set; }
    public int NumberOfArguments { get; set; } = 0;
    public List<Type> ListOfArgumentsType { get; set; } = new List<Type>();
    public List<string> ListOfArgumentsName { get; set; } = new List<string>();

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

    public void SetName()
    {
      if (MethodSig == string.Empty)
      {
        NumberOfArguments = 0;
        return;
      }

      var arguments = MethodSig.Split('(');
      var name = arguments[0].Split(' ');
      Name = name[name.Length - 1];
    }

    public void SetNumberOfArguments()
    {
      if (MethodSig == string.Empty)
      {
        NumberOfArguments = 0;
        return;
      }

      var arguments = MethodSig.Split('(');
      var argumentList = arguments[1].Split(' ');
      if (argumentList.Length % 2 == 0)
      {
        NumberOfArguments = argumentList.Length / 2;
        return;
      }
    }

    public void SetReturnType()
    {
      var arguments = MethodSig.Split('(');
      var name = arguments[0].Split(' ');
      var returnType = name[name.Length - 2];
      ReturnType = Helper.GetType(returnType);
    }

    public void SetArgumentsType()
    {
      
    }

    public void SetArgumentNames()
    {
      if (MethodSig == string.Empty)
      {
        NumberOfArguments = 0;
        return;
      }

      var arguments = MethodSig.Split('(');
      var names = arguments[1].Split(' ');
      var firstArgumentTypeString = names[0];
      var firstArgumentType = Helper.GetType(firstArgumentTypeString);
      ListOfArgumentsName.Add(firstArgumentTypeString.ToString());
      ListOfArgumentsType.Add(firstArgumentType);
    }
  }
}
