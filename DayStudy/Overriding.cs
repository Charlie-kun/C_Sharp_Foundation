using System;

namespace Overriding
{
  class ArmorSuite
  {
    public virtual void Initialize()
    {
      Console.WriteLine("Armored");

    }
  }

  class IronMan : ArmorSuite
  {
    public override void Initialize()
    {
      base.Initialize();
      Console.WriteLine("Repulsor Rays Armed");

    }
  }

  class WarMashine : ArmorSuite
  {
    public override void Initialize()
    {
      base.Initialize();
      Console.WriteLine("Double-Barrel Cannons Armed");
      Console.WriteLine("Micro-Rocket Launcher Armed");
    }
  }

  class MainClass 
  {
    static void Main (string[] args) 
    {
      Console.WriteLine ("Creating ArmorSuite...");
      ArmorSuite armorSuite=new ArmorSuite();
      armorSuite.Initialize();

      Console.WriteLine("\nCreating IronMan...");
      ArmorSuite ironman= new IronMan();
      ironman.Initialize();

      Console.WriteLine("\nCreating WarMashine...");
      ArmorSuite warmashine=new WarMashine();
      warmashine.Initialize();
    }
  }
}
