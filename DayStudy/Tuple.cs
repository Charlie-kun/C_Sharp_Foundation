using System;

namespace Tuple
{
  class MainClass
  {
    static void Main (string[] args) 
    {
      //No named Tuple
      var a=("Superman", 9999);
     Console.WriteLine ($"{a.Item1}, {a.Item2}");

       //Named Tuple
       var b=(Name : "Krystal", Age : 16);
       Console.WriteLine($"{b.Name}, {b.Age}");

       //Decomposition
       var(name,age)=b;  //(var name, var age)=b;
       Console.WriteLine($"{name},{age}");

       // Named Tuple=No named Tuple
       b=a;
       Console.WriteLine($"{b.Name},{b.Age}");
    }
  }
}
