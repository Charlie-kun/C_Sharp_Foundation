using System;

namespace BoxingUnboxing
{
  class MainClass 
  {
    static void Main (string[] args) 
    {
      int a=123;
      object b=(object)a;     //Value "a", boxing and save "heap" area
      int c=(int)b;   //Value "b", unboxing and save "stack" area

      Console.WriteLine (a);
      Console.WriteLine (b);
      Console.WriteLine (c);

      double x=3.1414213;
      object y=x;
      double z=(double)y;

      Console.WriteLine(x);
      Console.WriteLine(y);
      Console.WriteLine(z);
    }
  }
}

