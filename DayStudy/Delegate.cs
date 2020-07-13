using System;

namespace Delegate
{
  delegate int MyDelegate(int a, int b);  //Delegate

  class Calculator
  {
    public int Plus(int a, int b)   //Reference delegate instance 
    {
      return a+b;
    }

    public static int Minus(int a, int b)   //Delegate is reference to static method
    {
      return a-b;
    }
  }

  class MainClass 
  {
    static void Main (string[] args) 
    {
      Calculator Calc=new Calculator();
      MyDelegate Callback;

      Callback=new MyDelegate(Calc.Plus);
      Console.WriteLine(Callback(3,4));

      Callback = new MyDelegate(Calculator.Minus);
      Console.WriteLine(Callback(7,5));      
    }
  }
}

