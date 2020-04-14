
using Nenov.DesignPatterns.Adapter.Structural.AdapterA;

namespace Nenov.DesignPatterns.Adapter.Structural
{
  public class Adapter : ITarget
  {
    private readonly AdapteeA _adapteeA;
    
    /// <summary>
    /// Specific constructor 
    /// </summary>
    /// <param name="adapteeA">AdapteeA object</param>
    public Adapter(AdapteeA adapteeA)
    {
      _adapteeA = adapteeA;
    }

    /// <summary>
    /// Implemented ITarget interface method
    /// </summary>
    /// <returns></returns>
    public string GetRequest() => $"This is {_adapteeA.GetSpecificRequest()}.";
  }
}
