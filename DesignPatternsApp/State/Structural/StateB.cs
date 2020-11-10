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
    public override string HandleA()
    {
      return $"Concrete StateB handles request A. {Environment.NewLine}";
    }

    /// <summary>
    /// Handles request
    /// </summary>
    public override string HandleB()
    {
      var message = $"Concrete StateB handles request B. {Environment.NewLine}";
      message += $"Concrete StateB wants to change the state of the context. {Environment.NewLine}";
      message += Context.TransitionTo(new StateA());
      return message;
    }
  }
}
