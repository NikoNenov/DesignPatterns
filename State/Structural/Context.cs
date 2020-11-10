﻿//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Program.cs">
//  (c) 2020 Nikolay Nenov, Solothurn, Switzerland, www.nenov.de
//  </copyright>
// 
//  <summary>
//    The Context defines the interface of interest to clients.
//    It also maintains a reference to an instance of a State subclass,
//    which represents the current state of the Context.
//  </summary>
// 
//  <date>19-08-2020</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------

using System;

namespace Nenov.DesignPatterns.State.Structural
{
  public class Context
  {
    /// <summary>
    /// A reference to the current state of the Context.
    /// </summary>
    private State _state;

    /// <summary>
    /// Context constructor
    /// </summary>
    /// <param name="state"></param>
    public Context(State state)
    {
      _state = null;
      TransitionTo(state);
    }

    /// <summary>
    /// The Context allows changing the State object at runtime.
    /// </summary>
    /// <param name="state"></param>
    public void TransitionTo(State state)
    {
      Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
      _state = state;
      _state.SetContext(this);
    }

    /// <summary>
    /// The Context delegates part of its behavior to the current State object.
    /// </summary>
    public void RequestA()
    {
      _state.HandleA();
    }

    /// <summary>
    /// The Context delegates part of its behavior to the current State object.
    /// </summary>
    public void RequestB()
    {
      _state.HandleB();
    }
  }
}