﻿//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Program.cs">
//  (c) 2020 Nikolay Nenov, Solothurn, Switzerland, www.nenov.de
//  </copyright>
// 
//  <summary>
//    Main "Factory Method" pattern example
//  </summary>
// 
//  <date>17-06-2020</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------

using Nenov.DesignPatterns.FactoryMethod.Example;

namespace Nenov.DesignPatterns.FactoryMethod
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var factoryMethod = new FactoryMethodExample();
      factoryMethod.TryFactoryMethod();
    }
  }
}