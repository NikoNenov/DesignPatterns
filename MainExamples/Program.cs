using System;
using Nenov.DesignPatterns.Adapter.Example;
using Nenov.DesignPatterns.MainExamples.Examples;

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
          case (int) DesignPatterns.Adapter:
          {
            new AdapterExample().TryAdapter();
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
                 $"  1) Singleton (Not Thread Safe) {Environment.NewLine}" +
                 $"     Lets you ensure that a class has only one instance, while providing a global access point to this instance.{Environment.NewLine}" +
                 $"  2) Singleton (.Net 4 Lazy<T> Type) {Environment.NewLine}" +
                 $"{Environment.NewLine}" +
                 $" *** Structural Patterns *** {Environment.NewLine}" +
                 $"  3) Adapter {Environment.NewLine}" +
                 $"     Allows objects with incompatible interfaces to collaborate. {Environment.NewLine}" +
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
