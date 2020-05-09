using System;
using MyExtension;

namespace MyExtension
{
  public static class IntergerExtension
  {
    public static int Square(this int myInt)    //extension method
    {
      return myInt*myInt;
    }

    public static int Power(this int myInt, int exponent)
    {
      int result=myInt;
      for(int i =1; i<exponent; i++)
          result=result*myInt; 

          return result;
    }
  }
}

namespace ExtensionMethod
{
  class MainClass 
  {
    static void Main (string[] args) 
    {
      Console.WriteLine ($"3^2 : {3.Square()}");    //3 is int myInt
      Console.WriteLine ($"3^4 : {3.Power(4)}");
      Console.WriteLine ($"2^10 : {2.Power(10)}");
    }
  }
}
