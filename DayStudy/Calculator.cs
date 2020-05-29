using System;

namespace method 
{
  class Calculator
  {
    public static int Plus(int a, int b)
    {
      return a+b;
    }
    public static int Minus(int a, int b)
    {
      return a-b;
    }
  }
  class MainClass 
  {
    public static void Main (string[] args) 
    {
      int result =Calculator.Plus(3,4);
      Console.WriteLine(result);

      result =Calculator.Minus(5,3);
      Console.WriteLine(result);
    }
  }
}

