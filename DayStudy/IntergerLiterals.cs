using System;

namespace IntergerLiterals
{
  class MainClass 
  {
    static void Main (string[] args) 
    {
      byte a=240;   //Decimal
      Console.WriteLine($"a={a}");

      byte b=0b111_0000; //Binary
      Console.WriteLine($"b={b}");

      byte c=0XF0;  //Hexadecimal
      Console.WriteLine($"c={c}");

      uint d=0X1234_abcd; //Hexadecimal
      Console.WriteLine($"d={d}");
    }
  }
}
