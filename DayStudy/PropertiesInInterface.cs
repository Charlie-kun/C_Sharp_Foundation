using System;

namespace PropertiesInInterface
{
  interface INamedValue
  {
    string Name
    {
      get;
      set;
    }

    string Value
    {
      get;
      set;
    }
  }

  class NamedValue : INamedValue
  {
    public string Name
    {
      get;
      set;
    }
    public string Value
    {
      get;
      set;
    }
  }

  class MainClass 
  {
    static void Main (string[] args) 
    {
      NamedValue name=new NamedValue()
      {Name="Name", Value="charlie"};

      NamedValue height=new NamedValue()
      {Name="Height", Value="165cm"};

      NamedValue weight=new NamedValue()
      {Name="Weight", Value="60kg"};

      Console.WriteLine ($"{name.Name} : {name.Value}");
      Console.WriteLine ($"{height.Name} : {height.Value}");
      Console.WriteLine ($"{weight.Name} : {weight.Value}");
    }
  }

}

