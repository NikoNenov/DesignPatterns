namespace Nenov.DesignPatterns.FactoryMethod.Structural
{
  public class ConcreteCreatorB : Creator
  {
    public override IProduct FactoryMethod() => new ConcreteProductB();
  }
}
