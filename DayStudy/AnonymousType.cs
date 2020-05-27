using System;

namespace AnonymousType
{
  class MainClass 
  {
    static void Main (string[] args) 
    {
      var a=new {Name="charlie", Age=123};
      Console.WriteLine ($"Name:{a.Name}, Age:{a.Age}");
      var b= new {Subject="Math", Scores=new int[]{90, 80, 70, 60}};
      Console.Write($"Subject : {b.Subject}, Scores : ");
      foreach(var score in b.Scores)
        Console.Write($"{score} ");

      Console.WriteLine();
    }
  }
}
