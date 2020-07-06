using System;

namespace TryCatch
{
  class MainClass 
  {
    static void Main (string[] args) 
    {
      int[] arr={1,2,3};

      try
      {
        for(int i=0;i<5;i++)
        {
          Console.WriteLine (arr[i]);
        }
      }catch(IndexOutOfRangeException e)
      {
        Console.WriteLine($"Show event for exception : {e.Message}");
      }

      Console.WriteLine("Quit");
    }
  }  
}

