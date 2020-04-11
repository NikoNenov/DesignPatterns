
namespace Nenov.DesignPatterns.Adapter.AdapterB
{
  public class AdapterB : ITarget
  {
    private readonly AdapteeB _adapteeB;

    /// <summary>
    /// Specific constructor with AdapteeB parameter 
    /// </summary>
    /// <param name="adapteeB">AdapteeB object</param>
    public AdapterB(AdapteeB adapteeB)
    {
      _adapteeB = adapteeB;
    }

    /// <summary>
    /// Implemented ITarget interface method
    /// </summary>
    /// <returns></returns>
    public string GetRequest() => $"This is '{_adapteeB.GetSpecificRequest()}'";
  }
}
