using System;
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
            singletonExamples.Singleton_NotThreadSafe();
            Console.WriteLine(string.Empty);
            singletonExamples.Singleton_NotThreadSafe_Fail();

            WaitAfterExample();
            break;
          }
        }
      } while ( menuPoint != (int)DesignPatterns.Exit);

      

      Singleton.NotThreadSafe.Logger l = Singleton.NotThreadSafe.Logger.Instance();
      Singleton.Net4LazyType.Logger l2 = Singleton.Net4LazyType.Logger.Instance;
    }

    /// <summary>
    /// Show design patterns menu
    /// </summary>
    /// <returns>User choice</returns>
    private static int ShowMenuDesignPatterns()
    {
      var menu = $"===== Menu - design patterns ===== {Environment.NewLine}" +
                 $"{Environment.NewLine}" +
                 $"  1) Singleton (Not Thread Safe) {Environment.NewLine}" +
                 $"  2) Singleton (.Net 4 Lazy<T> Type) {Environment.NewLine}" +
                 $"{Environment.NewLine}" +
                 $" -1) Exit {Environment.NewLine}" +
                 $"> Please enter menu number: ";
      Console.Write(menu);
      
      var userChoice = Console.ReadLine();
      Console.Clear();
      int.TryParse(userChoice, out var userChoiceInt);

      return userChoiceInt;
    }

    private static void WaitAfterExample()
    {

      Console.Write($"{Environment.NewLine}> Press eny key: ");
      Console.ReadLine();
      Console.Clear();
    }
  }
}
