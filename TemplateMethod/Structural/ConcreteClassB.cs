using System;

namespace Nenov.DesignPatterns.TemplateMethod.Structural
{
  /// <summary>
  /// Implements the primitive operations ot carry out subclass-specific steps of the algorithm.
  /// </summary>
  public class ConcreteClassB : AbstractClass
  {
    protected override void RequiredOperation()
    {
      Console.WriteLine("ConcreteClassB call RequiredOperation() ***");
    }

    protected override void Hook()
    {
      Console.WriteLine("ConcreteClassB call Hook() ***");
    }
  }
}
