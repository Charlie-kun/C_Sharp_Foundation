using System;

namespace Structure
{
  struct Point3D    //Value type
  {
    public int X;
    public int Y;
    public int Z;

    public Point3D(int X, int Y, int Z)
    {
      this.X=X;
      this.Y=Y;
      this.Z=Z;
    }

    public override string ToString()    //override ToString
    {
      return string.Format($"{X}, {Y}, {Z}");
    }
  }
  class MainClass 
  {
    static void Main (string[] args) 
    {
      Point3D p3d1;    //Just declaration, but create instance.
      p3d1.X=10;
      p3d1.Y=20;
      p3d1.Z=40;

      Console.WriteLine(p3d1.ToString());

      Point3D p3d2=new Point3D(100,200,300);    //using Constructor, instance create
      Point3D p3d3=p3d2;   //deep copy
      p3d3.Z=400;    

      Console.WriteLine(p3d2.ToString());
      Console.WriteLine(p3d3.ToString());
    }
  }
}

