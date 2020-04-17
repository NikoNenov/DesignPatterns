using System;
using Nenov.DesignPatterns.FactoryMethod.Structural;

namespace Nenov.DesignPatterns.FactoryMethod.Example
{
  public class FactoryMethodExample
  {
    public void TryFactoryMethod()
    {
      Console.WriteLine("Launched with the ConcreteCreatorA.");
      ClientCode(new ConcreteCreatorA());

      Console.WriteLine();
      Console.WriteLine("Launched with the ConcreteCreatorB.");
      ClientCode(new ConcreteCreatorB());
    }

    /// <summary>
    /// The client code works with an instance of a concrete creator,
    /// albeit through its base interface.
    /// As long as the client keeps working with the creator via the base interface,
    /// you can pass it any creator's subclass.
    /// </summary>
    /// <param name="creator"></param>
    private void ClientCode(Creator creator)
    {
      // ...
      Console.WriteLine($"Client call Creator.SomeOperation(): {creator.SomeOperation()}");
      // ...
    }
  }
}
