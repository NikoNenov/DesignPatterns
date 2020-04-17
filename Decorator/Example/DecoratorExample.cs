using System;
using Nenov.DesignPatterns.Decorator.Structural;

namespace Nenov.DesignPatterns.Decorator.Example
{
  /// <summary>
  /// The client code works with all objects using the Component interface.
  /// This way it can stay independent of the concrete classes of components it works with.
  /// </summary>
  public class DecoratorExample
  {
    public void TryDecorator()
    {
      var simpleComponent = new ConcreteComponent();
      Console.WriteLine("I get a simple component:");
      ClientCode(simpleComponent);
      Console.WriteLine();

      // Note how decorators can wrap not only simple components
      // but the other decorators as well.
      var decoratorA = new ConcreteDecoratorA(simpleComponent);
      var decoratorB = new ConcreteDecoratorB(decoratorA);
      Console.WriteLine("Now I've got a decorated component:");
      ClientCode(decoratorB);
    }

    /// <summary>
    /// Client code
    /// </summary>
    /// <param name="component"></param>
    private void ClientCode(Component component)
    {
      Console.WriteLine(component.Operation());
    }
  }
}
