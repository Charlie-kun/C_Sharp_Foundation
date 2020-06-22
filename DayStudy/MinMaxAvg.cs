using System;
using System.Linq;

namespace MinMaxAvg
{
  class Profile
  {
    public string Name{get;set;}
    public int Height{get;set;}
  }

  class MainClass 
  {
    public static void Main (string[] args) 
    {
      Profile[] arrProfile=
      {
        new Profile(){Name="Krystal", Height=165},
        new Profile(){Name="Victoria", Height=168},
        new Profile(){Name="Amber", Height=167},
        new Profile(){Name="Luna", Height=160},
        new Profile(){Name="Charlie", Height=167}
      };

      var heightStat=from profile in arrProfile
                      group profile by profile.Height<166 into g select new
                      {
                        Group=g.Key==true?"Height 166 less":"Height 165 over",
                        Count=g.Count(),
                        Max=g.Max(profile=>profile.Height),
                        Min=g.Min(profile=>profile.Height),
                        Average=g.Average(profile=>profile.Height)
                      };

      foreach(var stat in heightStat)
      {
        Console.Write("{0}-Count : {1}, Max : {2}, ", stat.Group, stat.Count, stat.Max);
        Console.WriteLine("Min : {0}, Average : {1}", stat.Min, stat.Average);
      }
    }
  }
}
