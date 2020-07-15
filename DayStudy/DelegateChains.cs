using System;

namespace DelegateChains
{
  delegate void Notify(string message);

  class Notifier
  {
    public Notify EventOccured;
  }

  class EventListener
  {
    private string name;
    public EventListener(string name)
    {
      this.name=name;
    }

    public void SomethingHappend(string message)
    {
      Console.WriteLine($"{name}.SomethingHappend : {message}");
    }
  }

  class MainClass 
  {
    static void Main (string[] args) 
    {
      Notifier notifier =new Notifier();
      EventListener listenter1= new EventListener("Listener1");
      EventListener listenter2= new EventListener("Listener2");
      EventListener listenter3= new EventListener("Listener3");

      notifier.EventOccured+=listenter1.SomethingHappend;   //make chain
      notifier.EventOccured+=listenter2.SomethingHappend;
      notifier.EventOccured+=listenter3.SomethingHappend;
      notifier.EventOccured("You've got mail.");
      
      Console.WriteLine();

      notifier.EventOccured-=listenter2.SomethingHappend;   //cut chain
      notifier.EventOccured("Download complite.");

      Console.WriteLine();

      notifier.EventOccured=new Notify(listenter2.SomethingHappend) + new Notify(listenter3.SomethingHappend);    //make chain

      notifier.EventOccured("Nuclear lanch detected.");

      Console.WriteLine();

      Notify notify1=new Notify(listenter1.SomethingHappend);
      Notify notify2=new Notify(listenter2.SomethingHappend);

      notifier.EventOccured=(Notify)Delegate.Combine( notify1, notify2);  //make chain
      notifier.EventOccured("Fire");

      Console.WriteLine();

      notifier.EventOccured=(Notify)Delegate.Remove( notifier.EventOccured, notify2);   //cut chain
      notifier.EventOccured("RPG");
    }
  }
}

