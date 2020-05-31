using System;

namespace Return
{
  class MainClass 
  {
    static int Fibonacci(int n)
    {
      if(n<2)
        return n;
      else
        return Fibonacci(n-1)+Fibonacci(n-2);
    }
    static void PrintProfile(string name, string phone)
    {
      if(name=="")
      {
        Console.WriteLine("Input your name");
        return;
      }
      Console.WriteLine($"Name : {name}, phone : {phone}");
    }

    static void Main (string[] args) 
    {
     Console.WriteLine ($"10th Fibonacci Number : {Fibonacci(10)}");

     PrintProfile("", "741-852");    //Input your name
     PrintProfile("Charlie", "123-456");
    }
  }
}

