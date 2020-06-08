using System;

namespace LocalFunction
{
  class MainClass 
  {
    static string ToLowerString(string input)
    {
      var arr=input.ToCharArray();
      for(int i=0;i<arr.Length; i++)
      {
        arr[i]=ToLowerChar(i);
      }

      char ToLowerChar(int i) //local method
      {
        if(arr[i]<65||arr[i]>90)  //ASCII value at A~Z : 65~96
        {
          return arr[i];
        }else    //ASCII value at a~z : 97~122
        {
          return (char)(arr[i]+32);   //Used local value arr in ToLowerString() method.
        }
      }

      return new string(arr);
    }
    static void Main (string[] args) 
    {
      Console.WriteLine(ToLowerString("Hello!"));
      Console.WriteLine(ToLowerString("Good Morning"));
      Console.WriteLine(ToLowerString("THIS IS C#."));
    }
  }
}

