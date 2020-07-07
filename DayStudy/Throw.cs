using System;

namespace Throw
{
  class MainClass 
  {
    static void DoSonething(int arg) 
    {
      if(arg<10)
        Console.WriteLine($"arg : {arg}");
      else
        throw new Exception("arg가 10보다 큽니다.");
    }
    static void Main (string[] args)
    {
      try
      {
        DoSonething(1);
        DoSonething(3);
        DoSonething(9);
        DoSonething(11);    //Exception
        DoSonething(13);      //Exception
      }
      catch(Exception e)
      {
        Console.WriteLine(e.Message);
      }
    } 
  }
}

