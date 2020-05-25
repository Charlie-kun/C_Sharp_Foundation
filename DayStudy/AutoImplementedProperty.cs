using System;

namespace AutoImplimentedProperty
{
  class BirthdayInfo
  {
    public string Name {get; set;}="Unkown";
    public DateTime Birthday{get; set;}=new DateTime(1,1,1);
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
    public static void Main (string[] args) 
    {
      BirthdayInfo birth=new BirthdayInfo();
      Console.WriteLine($"Name : {birth.Name}");
      Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
      Console.WriteLine ($"Age : {birth.Age}");

      birth.Name="charlie";
      birth.Birthday=new DateTime(1994, 10, 24);

      Console.WriteLine($"Name : {birth.Name}");
      Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
      Console.WriteLine ($"Age : {birth.Age}");
    }
  }
}

