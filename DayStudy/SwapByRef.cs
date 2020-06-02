using System;

namespace SwapByValue
{
  class MainClass 
  {
    public static void Swap(ref int a, ref int b) 
    {
      int temp=b;
      b=a;
      a=temp;
    }

    public static void Main (string[] args) 
    {
      int x=3;
      int y=4;

      Console.WriteLine ($"x:{x}, y:{y}");

      Swap(ref x,ref y);  //pass by reference

      Console.WriteLine ($"x:{x}, y:{y}");
    }
  }
}

