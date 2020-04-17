namespace Nenov.DesignPatterns.FactoryMethod.Structural
{
  /// <summary>
  /// Concrete Products provide various implementations of the Product interface.
  /// </summary>
  public class ConcreteProductA : IProduct
  {
    public string Operation() => "ConcreteProductA ***";
  }
}
