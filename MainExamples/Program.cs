using System;
//using Nenov.DesignPatterns.Adapter.Example;
//using Nenov.DesignPatterns.Decorator.Example;
//using Nenov.DesignPatterns.FactoryMethod.Example;
using Nenov.DesignPatterns.MainExamples.Definitions;
using Nenov.DesignPatterns.MainExamples.Examples;
using Nenov.DesignPatterns.MainExamples.Extensions;
//using Nenov.DesignPatterns.TemplateMethod.Example;

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
          case (int)Patterns.SingletonNotThreadSafe:
          {
            var singletonExamples = new SingletonExamples();
            singletonExamples.Try_Singleton_NotThreadSafe();
            Console.WriteLine(string.Empty);
            singletonExamples.Try_Singleton_NotThreadSafe_Fail();

            WaitAfterExample();
            break;
          }
          case (int)Patterns.SingletonLazyType:
          {
              break;
          }
          case (int)Patterns.FactoryMethod:
          {
            //new FactoryMethodExample().TryFactoryMethod();
            WaitAfterExample();
            break;
          }
          case (int)Patterns.Adapter:
          {
            //new AdapterExample().TryAdapter();
            WaitAfterExample();
            break;
          }
          case (int)Patterns.Decorator:
          {
            //new DecoratorExample().TryDecorator();
            WaitAfterExample();
            break;
          }
          case (int)Patterns.TemplateMethod:
          {
            //new TemplateMethodExample().TryTemplateMethod();
            WaitAfterExample();
            break;
          }
          default:
          {
            menuPoint = -1;
            break;
          }
        }
      } while ( menuPoint != (int)Patterns.Exit);
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
                 CreateMenuPoint(Patterns.SingletonNotThreadSafe) +
                 CreateMenuPoint(Patterns.SingletonLazyType) +
                 CreateMenuPoint(Patterns.FactoryMethod) +

                 $"{Environment.NewLine}" +
                 $" *** Structural Patterns *** {Environment.NewLine}" +
                 CreateMenuPoint(Patterns.Adapter) +
                 CreateMenuPoint(Patterns.Decorator) +
                 
                 $"{Environment.NewLine}" +
                 $" *** Behavioral Patterns *** {Environment.NewLine}" +
                 CreateMenuPoint(Patterns.TemplateMethod) + 

                 $"{Environment.NewLine}" +
                 CreateMenuPoint(Patterns.Exit) +
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
    private static string CreateMenuPoint(Patterns designPattern) => $"  {(int) designPattern}) {designPattern} {Environment.NewLine}" + 
                                                                     $"     {designPattern.GetEnumDescription()} {Environment.NewLine}";
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
