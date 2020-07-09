using System;

namespace Finally
{
  class MainClass 
  {
    static int Divide(int divisor, int dividend)
    {
      try
      {
        Console.WriteLine("Divide() Start");
        return divisor/dividend;
      }
      catch(DivideByZeroException e)
      {
        Console.WriteLine("Divide() Exception");
        throw e;
      }
      finally
      {
        Console.WriteLine("Divide() End");
      }
    }

    static void Main (string[] args) 
    {
      try
      {
        Console.Write("input Number : ");
        String temp=Console.ReadLine();
        int divisor = Convert.ToInt32(temp);

        Console.Write("input Number : ");
        temp=Console.ReadLine();
        int dividend=Convert.ToInt32(temp);

        Console.WriteLine("{0}/{1} = {2}", divisor, dividend, Divide(divisor, dividend));
      }
      catch(FormatException e)
      {
        Console.WriteLine("Error : " +e.Message);
      }
      catch(DivideByZeroException e)
      {
        Console.WriteLine("Error : " +e.Message);
      }
      finally
      {
        Console.WriteLine("Program shutdown");
      }
    }
  }
}

