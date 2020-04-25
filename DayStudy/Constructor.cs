using System;

namespace Constructor
{
  class Cat
  {
    public Cat()
    {
      Name="";
      Color="";
    }

    public Cat(string _Name, string _Color)
    {
      Name=_Name;
      Color=_Color;
    }

    ~Cat()
    {
      Console.WriteLine($"{Name} : Good bye");
    }
  
  public string Name;
  public string Color;
  public void Meow()
  {
    Console.WriteLine($"{Name} : Meow");
  }
}

  class MainClass 
  {
    public static void Main (string[] args) 
    {
      Cat kitty =new Cat("Kitty", "White");
      kitty.Meow();
      Console.WriteLine ($"{kitty.Name} : {kitty.Color}");

      Cat nero=new Cat("nero", "Black");
      nero.Meow();
      Console.WriteLine($"{nero.Name} : {nero.Color}");
    }
  }
}
