using System;

namespace Nenov.DesignPatterns.TemplateMethod.Structural
{
  /// <summary>
  /// <para>
  /// Defines abstract primitive operations that concrete subclasses define to implement steps of an algorithm
  /// </para>
  /// 
  /// <para>
  /// Implements a template method defining the skeleton of an algorithm.
  /// The template method calls primitive operations as well as operations defined in AbstractClass or those of other objects.
  /// </para>
  /// </summary>
  public abstract class AbstractClass
  {
    /// <summary>
    /// The template method defines the skeleton of an algorithm.
    /// </summary>
    public void TemplateMethod()
    {
      BaseOperation();

      RequiredOperation();

      Hook();
    }

    /// <summary>
    /// These operations already have implementations.
    /// </summary>
    protected void BaseOperation()
    {
      Console.WriteLine("AbstractClass call BaseOperation()");
    }

    /// <summary>
    /// These operations have to be implemented in subclasses.
    /// </summary>
    protected abstract void RequiredOperation();

    /// <summary>
    /// These are "hooks."
    /// Subclasses may override them, but it's not mandatory since
    /// the hooks already have default implementation.
    /// Hooks provide additional extension points in some crucial places of the algorithm.
    /// </summary>
    protected virtual void Hook()
    {
      Console.WriteLine("AbstractClass call Hook()");
    }
  }
}
