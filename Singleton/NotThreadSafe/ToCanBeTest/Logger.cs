
namespace Nenov.DesignPatterns.Singleton.NotThreadSafe.ToCanBeTest
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
    /// This property prove that Singleton really works
    /// </summary>
    public string Value { get; set; }

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

    /// <summary>
    /// Logger singleton instance with prove parameter
    /// </summary>
    /// <param name="value">Singleton prove parameter</param>
    /// <returns>Logger singleton instance</returns>
    public static Logger InstanceProveSingleton(string value)
    {
      if (_instance == null)
      {
        _instance = new Logger {Value = value};
      }

      return _instance;
    }
  }
}
