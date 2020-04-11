
using System;
using Nenov.DesignPatterns.Adapter.AdapterA;
using Nenov.DesignPatterns.Adapter.AdapterB;

namespace Nenov.DesignPatterns.Adapter.Example
{
  public class AdapterExample
  {
    /// <summary>
    /// Try adapter design pattern 
    /// </summary>
    public void TryAdapter()
    {
      var adapteeA = new AdapteeA();
      ITarget targetA = new AdapterA.AdapterA(adapteeA);
      var adapteeB = new AdapteeB();
      ITarget targetB = new AdapterB.AdapterB(adapteeB);

      Console.WriteLine($"Adaptee interface is incompatible with the client. But with adapter {nameof(AdapterA)} client can call it's method.");

      Console.WriteLine(targetA.GetRequest());
      Console.WriteLine(targetB.GetRequest());
    }
  }
}
