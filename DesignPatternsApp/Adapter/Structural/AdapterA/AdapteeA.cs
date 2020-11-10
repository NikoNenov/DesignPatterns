
namespace Nenov.DesignPatterns.Adapter.Structural.AdapterA
{
  public class AdapteeA
  {
    /// <summary>
    /// Specific AdapteeA request
    /// </summary>
    /// <returns></returns>
    public string GetSpecificRequest() => $"Specific request from {nameof(AdapteeA)}";
  }
}
