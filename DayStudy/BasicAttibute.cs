using System;

namespace BasicAttibute
{
  class MyClass
  {
    [Obsolete("OldMethod rejected. PLZ use NewMethod().")]

    public void OldMethod()
    {
      Console.WriteLine("I'm old");
    }
    public void NewMethod()
    {
      Console.WriteLine("I'm new");
    }
  }
  
  class MainClass 
  {
    public static void Main (string[] args) 
    {
      MyClass obj=new MyClass();

      obj.OldMethod();
      obj.NewMethod();
    }
  }
}
