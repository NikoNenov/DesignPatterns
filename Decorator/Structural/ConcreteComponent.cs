namespace Nenov.DesignPatterns.Decorator.Structural
{
  /// <summary>
  /// Concrete Components provide default implementations of the operations.
  /// There might be several variations of these classes.
  /// </summary>
  public class ConcreteComponent : Component
  {
    public override string Operation() => $"{nameof(ConcreteComponent)}";
  }
}
