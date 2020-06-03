using System;

namespace UsingOut
{
  class MainClass 
  {
    static void Divide(int a, int b, out int quotient, out int remainder)
    {
      quotient=a/b;
      remainder=a%b;
    }

    public static void Main (string[] args) 
    {
      int a=20;
      int b=3;
      
      Divide(a,b, out int c, out int d );  //"out" is output parameter only.

      Console.WriteLine ($"a : {a}, b : {b}, a/b : {c}, a%b : {d}");
    }
  }

}

