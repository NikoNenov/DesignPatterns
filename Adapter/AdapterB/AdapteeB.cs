
namespace Nenov.DesignPatterns.Adapter.AdapterB
{
  public class AdapteeB
  {
    /// <summary>
    /// Specific AdapteeB request
    /// </summary>
    /// <returns></returns>
    public string GetSpecificRequest() => $"Specific request from {nameof(AdapteeB)}";
  }
}
