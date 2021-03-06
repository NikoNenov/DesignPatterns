﻿
namespace Nenov.DesignPatterns.Singleton.NotThreadSafe
{
  /// <summary>
  /// Not thread-safe.
  /// Two different threads could both have evaluated the test if (instance==null) and found it to be true,
  /// then both create instances, which violates the singleton pattern.
  /// </summary>
  public class Logger
  {
    /// <summary>
    /// Singleton instance of Logger
    /// </summary>
    private static Logger _instance;

    /// <summary>
    /// Default constructor
    /// </summary>
    private Logger() { }

    /// <summary>
    /// Get the logger singleton instance
    ///
    /// Uses lazy initialization and is not thread safe.
    /// </summary>
    /// <returns>logger singleton instance</returns>
    public static Logger Instance() => _instance ?? (_instance = new Logger());
  }
}
