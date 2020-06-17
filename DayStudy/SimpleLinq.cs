using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleLinq
{
  class Profile
  {
    public string Name{get; set;}
    public int Height {get; set;}
  }

  class MainClass 
  {
    public static void Main (string[] args) 
    {
      Profile[] arrProfile =
      {
        new Profile(){Name="Krystal", Height = 165},
        new Profile(){Name="MinJoo", Height =163},
        new Profile(){Name="Charlie", Height = 167}
      };

      var profiles=from profile in arrProfile
                    where profile. Height<167
                    orderby profile.Height
                    select new{
                      Name=profile.Name,
                      InchHeight=profile.Height*0.393
                    };
      foreach (var profile in profiles)
        Console.WriteLine ($"{profile.Name}, {profile.InchHeight}");
    }
  }
}

