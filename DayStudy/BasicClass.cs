using System;

namespace BasicClass
{
  class Cat
  {
    public string Name;
    public string Color;

    public void Meow()
    {
      Console.WriteLine($"{Name} : Meow");
    }
  }

  class MainApp 
  {
    public static void Main (string[] args) 
    {
      Cat kitty=new Cat();
      kitty.Color="White";
      kitty.Name="kitty";
      kitty.Meow();
      Console.WriteLine($"{kitty.Name} : {kitty.Color}");

      Cat nero=new Cat();
      nero.Color="Black";
      nero.Name="Nero";
      nero.Meow();

      Console.WriteLine ($"{nero.Name} : {nero.Color}");
    }
  }
}
