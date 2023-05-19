using System;

namespace UnitTestWriter
{
  public static class Helper
  {
    public static Type GetType(string name)
    {
      switch (name)
      {
        case "string":
          return typeof(string);

        case "bool":
          return typeof(bool);

        case "int":
          return typeof(int);

        case "long":
          return typeof(long);

        case "ulong":
          return typeof(ulong);

        case "uint":
          return typeof(uint);

        case "float":
          return typeof(float);

        case "double":
          return typeof(double);

        case "decimal":
          return typeof(decimal);

        default:
          return typeof(object);
      }
    }
  }
}
