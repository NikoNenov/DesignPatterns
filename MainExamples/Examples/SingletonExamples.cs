using System;
using System.Threading;

namespace Nenov.DesignPatterns.MainExamples.Examples
{
  public class SingletonExamples
  {

    /// <summary>
    /// Default constructor
    /// </summary>
    public SingletonExamples()
    {

    }

    /// <summary>
    /// Example that show singleton design pattern
    /// </summary>
    public void Try_Singleton_NotThreadSafe()
    {
      Console.WriteLine($"===== Example: Singleton not thread safe");

      var logger1 = Singleton.NotThreadSafe.Logger.Instance();
      var logger2 = Singleton.NotThreadSafe.Logger.Instance();

      if (logger1 == logger2)
      {
        Console.WriteLine($"Instance {nameof(logger1)} ({logger1.GetHashCode()}) and instance {nameof(logger2)} ({logger2.GetHashCode()}) are same.");
      }
      else
      {
        Console.WriteLine($"Instance {nameof(logger1)} ({logger1.GetHashCode()}) and instance {nameof(logger2)} ({logger2.GetHashCode()}) are NOT same.");
      }
    }

    /// <summary>
    /// Example prove singleton really works.
    ///
    /// Please clear and rebuild your solution for run this example.
    /// </summary>
    public void Try_Singleton_NotThreadSafe_Fail()
    {
      Console.WriteLine($"===== Example: Singleton not thread safe ***FAIL***");
      for (int i = 0; i < 5; i++)
      {
        var processA = new Thread(() =>
        {
          var loggerA = Singleton.NotThreadSafe.ToCanBeTest.Logger.InstanceProveSingleton("*** First instance ***");
          Console.WriteLine($"Singleton instance of {nameof(loggerA)} has hash code: {loggerA.GetHashCode()} and value: {loggerA.Value}");
        });
        var processB = new Thread(() =>
        {
          var loggerB = Singleton.NotThreadSafe.ToCanBeTest.Logger.InstanceProveSingleton("*** Second instance ***");
          Console.WriteLine($"Singleton instance of {nameof(loggerB)} has hash code: {loggerB.GetHashCode()} and value: {loggerB.Value}");
        });

        processA.Start();
        processB.Start();

        processA.Join();
        processB.Join();
      }
    }
  }
}
