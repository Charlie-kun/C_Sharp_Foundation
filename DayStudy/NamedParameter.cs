using System;

namespace NamedParameter
{
  class MainClass 
  {
    static void PrintProfile(string name, string phone)
    {
      Console.WriteLine ($"Name : {name}, Phone : {phone}");
    }
    static void Main (string[] args) 
    {
      PrintProfile(name : "Charlie", phone : "012-456-789");
      PrintProfile(phone : "042-2002-2002", name : "Charlie");
      PrintProfile("Krystal", phone : "082-4004-1004");
      //PrintProfile("042-2002-2002", name : "Charlie");  //Can't display
      //PrintProfile("042-2002-2002", "Charlie");    //Wrong display
    }
  }
}

