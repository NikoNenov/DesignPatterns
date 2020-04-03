using System;

namespace Nenov.DesignPatterns.Singleton.Net4LazyType
{
  /// <summary>
  ///  .NET 4 (or higher), you can use the System.Lazy<T> type to make the laziness
  /// </summary>
  public sealed class Logger
  {
    private static readonly Lazy<Logger> lazy = new Lazy<Logger>(() => new Logger());

    public static Logger Instance => lazy.Value;

    private Logger()
    {
    }
  }
}
