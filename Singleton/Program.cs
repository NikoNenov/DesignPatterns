//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Program.cs">
//  (c) 2020 Nikolay Nenov, Solothurn, Switzerland, www.nenov.de
//  </copyright>
// 
//  <summary>
//    Main "Singleton" pattern example
//  </summary>
// 
//  <date>17-06-2020</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------

using System;
using Nenov.DesignPatterns.MainExamples.Examples;

namespace Nenov.DesignPatterns.Singleton
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // SingletonNotThreadSafe
      var singletonExamples = new SingletonExamples();
      singletonExamples.Try_Singleton_NotThreadSafe();
      Console.WriteLine(string.Empty);
      singletonExamples.Try_Singleton_NotThreadSafe_Fail();

      // SingletonLazyType
    }
  }
}