using System;
using System.Linq;

namespace From
{
  class MainClass 
  {
    static void Main (string[] args) 
    {
      int[] numbers={9,2,6,4,5,3,7,8,1,10};

      var result =from n in numbers
        where n%2==0    //Filter Condition
        orderby n   //Sort data
        select n;   //Display a result of 'where'

      foreach(int n in result)
        Console.WriteLine ($"Even number : {n}");
    }
}
}

