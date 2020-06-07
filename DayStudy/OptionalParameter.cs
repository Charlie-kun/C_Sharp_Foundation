using System;

namespace OptionalParameter
{
  class MainClass 
  {
    static void pRintProfile(string name, string phone="")
    {
      Console.WriteLine($"Name:{name}, Phone:{phone}");
    }
    
    public static void Main (string[] args) 
    {
      pRintProfile("chalire");
      pRintProfile("charlie", "123-456-789");
    }
  }
}
