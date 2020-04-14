
using System;
using Nenov.DesignPatterns.Adapter.Structural;
using Nenov.DesignPatterns.Adapter.Structural.AdapterA;

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
      ITarget targetA = new Structural.Adapter(adapteeA);


      Console.WriteLine($"Adaptee interface is incompatible with the client. "+
                        $"But with adapter {nameof(Adapter)} client can call it's method.");
      Console.WriteLine(targetA.GetRequest());
    }
  }
}
