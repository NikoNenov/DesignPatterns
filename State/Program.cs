//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Program.cs">
//  (c) 2020 Nikolay Nenov, Solothurn, Switzerland, www.nenov.de
//  </copyright>
// 
//  <summary>
//    Main "State" pattern example
//  </summary>
// 
//  <date>19-08-2020</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------
using System;
using Nenov.DesignPatterns.State.Example;

namespace Nenov.DesignPatterns.State
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var stateExample = new StateExample();
      stateExample.TryState();
    }
  }
}
