namespace Nenov.DesignPatterns.FactoryMethod.Structural
{
  /// <summary>
  /// The Creator class declares the factory method that is supposed to return an object of a Product class.
  /// The Creator's subclasses usually provide the implementation of this method.
  /// </summary>
  public abstract class Creator
  {

    /// <summary>
    /// Note that the Creator may also provide some default implementation of the factory method.
    /// </summary>
    /// <returns></returns>
    public abstract IProduct FactoryMethod();

    /// <summary>
    /// Also note that, despite its name, the Creator's primary responsibility is not creating products.
    /// Usually, it contains some core business logic that relies on Product objects,
    /// returned by the factory method.
    /// Subclasses can indirectly change that business logic
    /// by overriding the factory method and returning a different type of product from it.
    /// </summary>
    public string SomeOperation()
    {
      // Call the factory method to create a Product object.
      var product = FactoryMethod();

      // Now, use the product.
      var result = $"Creator same code has just worked with {product?.Operation()}";

      return result;
    }
  }
}
