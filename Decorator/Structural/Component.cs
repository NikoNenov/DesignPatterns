namespace Nenov.DesignPatterns.Decorator.Structural
{
  /// <summary>
  /// The base Component interface defines operations that can be altered by decorators.
  /// </summary>
  public abstract class Component
  {
    public abstract string Operation();
  }
}
