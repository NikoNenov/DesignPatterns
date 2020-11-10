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
    public override string HandleA()
    {
      var message = $"Concrete StateA handles request A. {Environment.NewLine}";
      message += $"Concrete StateA wants to change the state of the context. {Environment.NewLine}";
      message += Context.TransitionTo(new StateB());

      return message;
    }

    /// <summary>
    /// Handle request
    /// </summary>
    public override string HandleB()
    {
      return $"Concrete StateA handles request B. {Environment.NewLine}";
    }
  }
}