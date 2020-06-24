using System;
using System.Reflection;

namespace DynamicInstance
{
  class Profile
  {
    private string name;
    private string phone;
    public Profile()
    {
      name=""; phone="";
    }

    public Profile(string name, string phone)
    {
      this.name=name;
      this.phone=phone;
    }

    public void Print()
    {
      Console.WriteLine($"{name}, {phone}");
    }

    public string Name
    {
      get{return name;}
      set{name=value;}
    }

    public string Phone
    {
      get{return phone;}
      set{phone=value;}
    }
  }

  class MainClass 
  {
    public static void Main (string[] args) 
    {
      Type type=Type.GetType("DynamicInstance.Profile");
      MethodInfo methodInfo=type.GetMethod("Print");
      PropertyInfo nameProperty=type.GetProperty("Name");
      PropertyInfo phoneProperty=type.GetProperty("Phone");

      object profile = Activator.CreateInstance(type, "Krystal", "578-1555");
      methodInfo.Invoke(profile, null);

      profile=Activator.CreateInstance(type);
      nameProperty.SetValue(profile, "Charlie", null);
      phoneProperty.SetValue(profile, "788-4885", null);

      Console.WriteLine("{0}, {1}", nameProperty.GetValue(profile, null), phoneProperty.GetValue(profile, null));
    } 
  }
}

