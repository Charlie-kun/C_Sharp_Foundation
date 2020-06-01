using System;

namespace SwapByValue
{
  class MainClass 
  {
    public static void Swap(int a, int b)
    {
      int temp =b;    //Just copied data "temp" to "b" . not change
      b=a;
      a=temp;  //Just copied data x to "a" . not change
    }
    
    static void Main (string[] args) 
    {
     int x=3;
     int y=4;

     Console.WriteLine ($"x : {x}, y : {y}");

     Swap(x,y);
     Console.WriteLine ($"x : {x}, y : {y}");    //Didn't Change x, y value
    }
  }
}

