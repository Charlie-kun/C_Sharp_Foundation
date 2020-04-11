using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    /*
    //BoxingUnboxing
    int a=123;
    object b=(object)a;
    int c= (int)b;

    Console.WriteLine (a);
    Console.WriteLine (b);
    Console.WriteLine (c);
    double x=3.1414213;
    object y=x;
    double z=(double)y;

    Console.WriteLine (x);
    Console.WriteLine (y);
    Console.WriteLine (z);
    */
    /*
    //IntegralConversion
    sbyte a=127;
    Console.WriteLine (a);

    int b=(int)a;
    Console.WriteLine (b);

    int x=128;     //sbyte maximum value 127 plus 1
    Console.WriteLine (x);

    sbyte y=(sbyte)x;    //make a overflow
    Console.WriteLine (y);
    */

    //FloatConversion

    float a =69.6875f;
    Console.WriteLine("a : {0}", a);

    double b=(double)a;
    Console.WriteLine("b : {0}", b);

    Console.WriteLine("69.6875 == b : {0}", 69.6875 ==b);

    float x=0.1f;
    Console.WriteLine("x:{0}", x);

    double y =(double)x;
    Console.WriteLine("y : {0}", y);
    
    Console.WriteLine("0.1 ==y : {0}",0.1==y);

  }
}
