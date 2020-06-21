using System;
using System.Linq;

namespace Join
{
    class Profile
    {
      public string Name { get; set; }
      public int Height { get; set; }
    }

    class Product
    {
      public string Title { get; set; }
      public string Star { get; set; }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
              new Profile(){Name="Krystal", Height=165},
              new Profile(){Name="Charlie", Height=167}
            };

            Product[] arrProduct =
            {
              new Product(){Title="4walls", Star="Krystal"}        
            };
    
            var listProfile =
                from profile in arrProfile
                join product in arrProduct on profile.Name equals product.Star
                select new
                {
                  Name = profile.Name,
                  Work = product.Title,
                  Height = profile.Height
                };

            Console.WriteLine("Inner Join result");

            foreach (var profile in listProfile)
            {
                Console.WriteLine("Name : {0}, Title : {1}, Height : {2}cm", profile.Name, profile.Work, profile.Height);
            }

            listProfile = 
                from profile in arrProfile
                join product in arrProduct on profile.Name equals product.Star into si

                from product in si.DefaultIfEmpty(new Product(){Title="No data"})
                select new
                  {
                    Name = profile.Name,
                    Work = product.Title,
                    Height = profile.Height
                  };

            Console.WriteLine();
            Console.WriteLine("Out Join result");
            foreach (var profile in listProfile)
            {
                Console.WriteLine("Name : {0}, Title : {1}, Height : {2}cm", profile.Name, profile.Work, profile.Height);
            }
        }
    }

}

