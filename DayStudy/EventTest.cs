using System;

namespace EventTest
{
  delegate void EventHandler(string message);

  class Mynotifier
  {
    public event EventHandler SomethingHappend;
    public void DoSomething(int number)
    {
      int temp=number %10;

      if(temp !=0 &&temp %3==0)
      {
        SomethingHappend(String.Format("{0} : Even", number));
      }
    }
  }

  class MainClass 
  {
    static public void MyHandler(string message)
    {
      Console.WriteLine(message);
    }

   static void Main (string[] args) 
   {
     Mynotifier notifier=new Mynotifier();
     notifier.SomethingHappend+=new EventHandler(MyHandler);

     for(int i=1;i<30;i++)
     {
       notifier.DoSomething(i);
     }
   }
  }
}

