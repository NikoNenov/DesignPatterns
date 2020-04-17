using System;
using Nenov.DesignPatterns.Adapter.Example;
using Nenov.DesignPatterns.Decorator.Example;
using Nenov.DesignPatterns.FactoryMethod.Example;
using Nenov.DesignPatterns.MainExamples.Examples;
using Nenov.DesignPatterns.TemplateMethod.Example;

namespace Nenov.DesignPatterns.MainExamples
{
  public class Program
  {
    /// <summary>
    /// Main 
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
      var menuPoint = 0;
      do
      {
        menuPoint = ShowMenuDesignPatterns();

        switch (menuPoint)
        {
          case (int)DesignPatterns.Singleton_NotThreadSafe:
          {
            var singletonExamples = new SingletonExamples();
            singletonExamples.Try_Singleton_NotThreadSafe();
            Console.WriteLine(string.Empty);
            singletonExamples.Try_Singleton_NotThreadSafe_Fail();

            WaitAfterExample();
            break;
          }
          case (int) DesignPatterns.Singleton_LazyType:
          {
              break;
          }
          case (int)DesignPatterns.FactoryMethod:
          {
            new FactoryMethodExample().TryFactoryMethod();
            WaitAfterExample();
            break;
          }
          case (int) DesignPatterns.Adapter:
          {
            new AdapterExample().TryAdapter();
            WaitAfterExample();
            break;
          }
          case (int) DesignPatterns.Decorator:
          {
            new DecoratorExample().TryDecorator();
            WaitAfterExample();
            break;
          }
          case (int)DesignPatterns.TemplateMethod:
          {
            new TemplateMethodExample().TryTemplateMethod();
            WaitAfterExample();
            break;
          }
          default:
          {
            menuPoint = -1;
            break;
          }
        }
      } while ( menuPoint != (int)DesignPatterns.Exit);
    }

    /// <summary>
    /// Show design patterns menu
    /// </summary>
    /// <returns>User choice</returns>
    private static int ShowMenuDesignPatterns()
    {
      var menu = $"===== Menu - design patterns ===== {Environment.NewLine}" +
                 
                 $"{Environment.NewLine}" +
                 $" *** Creational Patterns *** {Environment.NewLine}" +
                 CreateMenuPoint(DesignPatterns.Singleton_NotThreadSafe, 
                   "Lets you ensure that a class has only one instance, while providing a global access point to this instance.") +
                 CreateMenuPoint(DesignPatterns.Singleton_LazyType, ".Net 4 Lazy<T> Type") +
                 CreateMenuPoint(DesignPatterns.FactoryMethod,
                   "Creates an instance of several derived classes") +

                 $"{Environment.NewLine}" +
                 $" *** Structural Patterns *** {Environment.NewLine}" +
                 CreateMenuPoint(DesignPatterns.Adapter, "Allows objects with incompatible interfaces to collaborate.") +
                 CreateMenuPoint(DesignPatterns.Decorator, "Add responsibilities to objects dynamically.") +
                 
                 $"{Environment.NewLine}" +
                 $" *** Behavioral Patterns *** {Environment.NewLine}" +
                 CreateMenuPoint(DesignPatterns.TemplateMethod, 
                   "Defines the skeleton of an algorithm in the superclass " + 
                   "but lets subclasses override specific steps of the algorithm without changing its structure.") + 

                 $"{Environment.NewLine}" +
                 $" -1) Exit {Environment.NewLine}" +
                 $"> Please enter menu number: ";
      Console.Write(menu);
      
      var userChoice = Console.ReadLine();
      Console.Clear();
      int.TryParse(userChoice, out var userChoiceInt);

      return userChoiceInt;
    }

    /// <summary>
    /// Create one menu point
    /// </summary>
    /// <param name="designPattern"></param>
    /// <returns></returns>
    private static string CreateMenuPoint(DesignPatterns designPattern) => $"  {(int) designPattern}) {designPattern} {Environment.NewLine}";

    /// <summary>
    /// Create one menu point with description
    /// </summary>
    /// <param name="designPattern"></param>
    /// <param name="description"></param>
    /// <returns></returns>
    private static string CreateMenuPoint(DesignPatterns designPattern, string description) =>
      CreateMenuPoint(designPattern) 
      + $"     {description} {Environment.NewLine}";

    /// <summary>
    /// Display edn of example point 
    /// </summary>
    private static void WaitAfterExample()
    {
      Console.Write($"{Environment.NewLine}> Press eny key: ");
      Console.ReadLine();
      Console.Clear();
    }
  }
}
