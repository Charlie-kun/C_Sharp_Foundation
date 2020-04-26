using System;

namespace DeepCopy
{
  class MyClass 
  {
    public int MyField1;
    public int MyField2;

    public MyClass DeepCopy()    //Make new Object.
    {
      MyClass newCopy=new MyClass();
      newCopy.MyField1=this.MyField1;    //Save another heap
      newCopy.MyField2=this.MyField2;
    
      return newCopy;
    }
  }
  class MainApp
  {
    static void Main (string[] args) 
    {
      Console.WriteLine ("Shallow Copy");
      {
        MyClass source =new MyClass();
        source.MyField1=10;
        source.MyField2=20;

        MyClass target=source;   //Save in same heap area 
        target.MyField2=30;

        Console.WriteLine($"{source.MyField1} {source.MyField2}");
        Console.WriteLine($"{target.MyField1} {target.MyField2}");
        
      }

      Console.WriteLine("Deep Copy");
      {
        MyClass source=new MyClass();
        source.MyField1=10;
        source.MyField2=20;

        MyClass target=source.DeepCopy();    //Save at another heap area
        target.MyField2=30;

        Console.WriteLine($"{source.MyField1} {source.MyField2}");
        Console.WriteLine($"{target.MyField1} {target.MyField2}");
      }
    }
  }
}
