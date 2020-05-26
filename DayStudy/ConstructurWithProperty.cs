using System;

namespace ConstructurWithProperty
{
  class BirthdayInfo
  {
    public string Name
    {
      get;
      set;
    }

    public DateTime Birthday
    {
      get;
      set;
    }

    public int Age
    {
      get
      {
        return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
      }
    }
  }
  class MainClass 
  {
    static void Main (string[] args) 
    {
      BirthdayInfo birth=new BirthdayInfo
      {
        Name="charlie",    //Warning!! Property
        Birthday=new DateTime(1994,10,24)
      };
      Console.WriteLine ($"Name : {birth.Name}");
      Console.WriteLine ($"Birthday : {birth.Birthday.ToShortDateString()}");
      Console.WriteLine ($"Age : {birth.Age}");
    }
  }
}

