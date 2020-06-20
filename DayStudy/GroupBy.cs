using System;
using System.Linq;

namespace GroupBy
{
  class Profile
  {
    public string Name{get; set;}
    public int Height{get; set;}
  }

  class MainClass 
  {
    public static void Main (string[] args) 
    {
      Profile[] arrProfile=
      {
        new Profile(){Name="Charlie", Height=167},
        new Profile(){Name="Krystal", Height=165}
      };

      var listProfile=from profile in arrProfile
                      orderby profile.Height
                      group profile by profile.Height <166 into g  
                      select new {GroupKey=g.Key, Profiles=g};

      foreach (var Group in listProfile)
      {
        Console.WriteLine($"- 166cm under? : {Group.GroupKey}");

        foreach(var profile in Group.Profiles)
        {
          Console.WriteLine($"{profile.Name}, {profile.Height}");
        }
      }
    }
  }
}
