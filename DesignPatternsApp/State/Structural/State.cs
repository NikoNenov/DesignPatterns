//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Program.cs">
//  (c) 2020 Nikolay Nenov, Solothurn, Switzerland, www.nenov.de
//  </copyright>
//
//  <summary>
//    The base State class declares methods that all Concrete State should implement
//    and also provides a back reference to the Context object, associated with the State.
//    This back reference can be used by States to transition the Context to another State.
//  </summary>
//
//  <date>19-08-2020</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------

namespace Nenov.DesignPatterns.State.Structural
{
  public abstract class State
  {
    /// <summary>
    /// Back reference to the Context object
    /// </summary>
    protected Context Context;

    /// <summary>
    /// State constructor
    /// </summary>
    /// <param name="context"></param>
    public void SetContext(Context context)
    {
      Context = context;
    }

    public abstract string HandleA();

    public abstract string HandleB();
  }
}