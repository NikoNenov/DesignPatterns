using System;
using Nenov.DesignPatterns.TemplateMethod.Structural;

namespace Nenov.DesignPatterns.TemplateMethod.Example
{
  public class TemplateMethodExample
  {
    public void TryTemplateMethod()
    {
      Console.WriteLine("Same client code can work with different subclasses:");
      Console.WriteLine(" - 'ConcreteClassA' call 'TemplateMethod'");
      ClientCode(new ConcreteClassA());

      Console.WriteLine();
      Console.WriteLine("Same client code can work with different subclasses:");
      ClientCode(new ConcreteClassB());
    }

    /// <summary>
    /// The client code calls the template method to execute the algorithm.
    /// Client code does not have to know the concrete class of an object it works with,
    /// as long as it works with objects through the interface of their base class.
    /// </summary>
    /// <param name="abstractClass"></param>
    private void ClientCode(AbstractClass abstractClass)
    {
      // ...
      abstractClass.TemplateMethod();
      // ...
    }
  }
}
