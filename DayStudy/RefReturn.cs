using System;

namespace RefReturn
{
  class Product
  {
    private int price =100;

    public ref int GetPrice()
    {
      return ref price;
    }

    public void PrintPrice()
    {
      Console.WriteLine($"Price :{price}");
    }
  }

  class MainClass 
  {
    static void Main (string[] args) 
    {
      Product carrot=new Product();
      ref int ref_local_price=ref carrot.GetPrice();  //When modified ref_local_price. together modified at "carrot.price" too.
      int nomal_local_price=carrot.GetPrice();

      carrot.PrintPrice();
      Console.WriteLine($"Ref Local Price :{ref_local_price}");
      Console.WriteLine($"Normal Local Price : {nomal_local_price}");

      ref_local_price=200;
      
      carrot.PrintPrice();
      Console.WriteLine($"Ref Local Price :{ref_local_price}");
      Console.WriteLine($"Normal Local Price : {nomal_local_price}");

    }
  }
}

