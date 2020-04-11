
namespace Nenov.DesignPatterns.Adapter.AdapterA
{
  public class AdapterA : ITarget
  {
    private readonly AdapteeA _adapteeA;

    /// <summary>
    /// Specific constructor with AdapteeA parameter 
    /// </summary>
    /// <param name="adapteeA">AdapteeA object</param>
    public AdapterA(AdapteeA adapteeA)
    {
      _adapteeA = adapteeA;
    }

    /// <summary>
    /// Implemented ITarget interface method
    /// </summary>
    /// <returns></returns>
    public string GetRequest() => $"This is '{_adapteeA.GetSpecificRequest()}'";
  }
}
