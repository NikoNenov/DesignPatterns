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
  public class StateA : State
  {
    /// <summary>
    /// Handle request
    /// </summary>
    public override void HandleA()
    {
      Console.WriteLine("Concrete StateA handles request A.");
      Console.WriteLine("Concrete StateA wants to change the state of the context.");
      Context.TransitionTo(new StateB());
    }

    /// <summary>
    /// Handle request
    /// </summary>
    public override void HandleB()
    {
      Console.WriteLine("Concrete StateA handles request B.");
    }
  }
}