//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Program.cs">
//  (c) 2020 Nikolay Nenov, Solothurn, Switzerland, www.nenov.de
//  </copyright>
// 
//  <summary>
//    Concrete States implement various behaviors, associated with a state of the Context.
//  </summary>
// 
//  <date>19-08-2020</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------

using System;

namespace Nenov.DesignPatterns.State.Structural
{
  public class StateB : State
  {
    /// <summary>
    /// Handles request
    /// </summary>
    public override void HandleA()
    {
      Console.WriteLine("Concrete StateB handles request A.");
    }

    /// <summary>
    /// Handles request
    /// </summary>
    public override void HandleB()
    {
      Console.WriteLine("Concrete StateB handles request B.");
      Console.WriteLine("Concrete StateB wants to change the state of the context.");
      Context.TransitionTo(new StateA());
    }
  }
}
