namespace Nenov.DesignPatterns.Decorator.Structural
{
  /// <summary>
  /// Concrete Decorators call the wrapped object and alter its result in some way.
  /// </summary>
  public class ConcreteDecoratorB : Decorator
  {
    public ConcreteDecoratorB(Component component) : base(component)
    {
    }

    public override string Operation() => $"# base.Operation: {base.Operation()} + {nameof(ConcreteDecoratorB)}.Operation + {AnotherMethod}";

    private string AnotherMethod => $"{nameof(ConcreteDecoratorB)}.{nameof(AnotherMethod)}";
  }
}
