using System;

namespace Nenov.DesignPatterns.TemplateMethod.Structural
{
  /// <summary>
  /// Concrete classes have to implement all abstract operations of the base class.
  /// They can also override some operations with a default implementation.
  /// </summary>
  public class ConcreteClassA: AbstractClass
  {
    protected override void RequiredOperation()
    {
      Console.WriteLine(" - 'ConcreteClassA' call 'RequiredOperation' Concrete implementation!");
    }
  }
}
