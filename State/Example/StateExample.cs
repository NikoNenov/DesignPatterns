using Nenov.DesignPatterns.State.Structural;

namespace Nenov.DesignPatterns.State.Example
{
  public class StateExample
  {
    public void TryState()
    {
      var context = new Context(new StateA());
      context.RequestA();
      context.RequestB();
    }
  }
}
