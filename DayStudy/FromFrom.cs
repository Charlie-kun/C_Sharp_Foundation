using System;
using System.Linq;

namespace FromFrom
{
  class Class
  {
    public string Name {get; set;}
    public int[] Score {get; set;}
  }

  class MainClass 
  {
    public static void Main (string[] args) 
    {
      Class[] arrClass=
      {
        new Class(){Name="Yellow", Score=new int[]{99,80,70,24}},
        new Class(){Name="Red", Score=new int[]{70,20,50,94}},
        new Class(){Name="Green", Score=new int[]{90,72,70,84}}
      };
      var classes=from c in arrClass
                  from s in c.Score
                  where s<60
                  orderby s
                  select new {c.Name, Lowest=s};

      foreach(var c in classes)
        Console.WriteLine ($"낙제 : {c.Name} ({c.Lowest})");
    }
  }
}
