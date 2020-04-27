using System;

namespace This
{
  class Employee
  {
    private string Name;
    private string Position;

    public void SetName(string Name)
    {
      this.Name=Name;
    }

    public string GetName()
    {
      return Name;   //Already got a Name parameter
    }

    public void SetPosition(string Position)
    {
      this.Position=Position;
    }

    public string GetPosition()
    {
      return this.Position;    //Already got a Position parameter
    }
  }
  class MainClass 
  {
    static void Main (string[] args) 
    {
      Employee pooh=new Employee();
      pooh.SetName("Pooh");
      pooh.SetPosition("Waiter");
      
      Console.WriteLine ($"{pooh.GetName()} {pooh.GetPosition()}");

      Employee tigger=new Employee();
      tigger.SetName("Tigger");
      tigger.SetPosition("Cleaner");
      Console.WriteLine($"{tigger.GetName()} {tigger.GetPosition()}");
    }
  }

}
