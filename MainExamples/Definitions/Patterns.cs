using System.ComponentModel;

namespace Nenov.DesignPatterns.MainExamples.Definitions
{
  /// <summary>
  /// Design patterns definition
  /// </summary>
  public enum Patterns
  {
    Exit = -1,

    [Description("Lets you ensure that a class has only one instance, while providing a global access point to this instance.")]
    SingletonNotThreadSafe = 1,
    [Description(".Net 4 Lazy<T> Type")]
    SingletonLazyType = 2,
    [Description("Creates an instance of several derived classes.")]
    FactoryMethod = 3,

    [Description("Allows objects with incompatible interfaces to collaborate.")]
    Adapter = 4,
    [Description("Add responsibilities to objects dynamically.")]
    Decorator = 5,

    [Description("Defines the skeleton of an algorithm in the superclass but lets subclasses override specific steps of the algorithm without changing its structure.")]
    TemplateMethod = 10
  }
}
