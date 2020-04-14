namespace Nenov.DesignPatterns.Decorator.Structural
{
  public class ConcreteDecoratorA : Decorator
  {
    public ConcreteDecoratorA(Component component) : base(component)
    {
    }

    /// <summary>
    /// Decorators may call parent implementation of the operation,
    /// instead of calling the wrapped object directly. This approach simplifies extension of decorator classes.
    /// </summary>
    /// <returns></returns>
    public override string Operation() => $"# base.Operation: {base.Operation()} + {nameof(ConcreteDecoratorA)}.Operation";
  }
}
