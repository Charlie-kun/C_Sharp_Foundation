using System;
using System.Linq;

namespace SimpleLinq2
{
  class Profile 
  {
    public string Name{get;set;}
    public int Height{get;set;}
  }
  class MainClass 
  {
    static void Main (string[] args) 
    {
      Profile[] arrProfile =
      {
        new Profile(){Name="Krystal", Height=165},
        new Profile(){Name="Charlie", Height=167}
      };

      var profiles=arrProfile.
                    Where(profile=>profile.Height<166). 
                    OrderBy(profile=>profile.Height). 
                    Select(profile=>new
                                    {Name=profile.Name, InchHeight=profile.Height*0.393});

      foreach(var profile in profiles)
        Console.WriteLine ($"{profile.Name}, {profile.InchHeight}");

      
    }
  }

}
