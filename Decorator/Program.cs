//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Program.cs">
//  (c) 2020 Nikolay Nenov, Solothurn, Switzerland, www.nenov.de
//  </copyright>
// 
//  <summary>
//    Main "Decorator" pattern example
//  </summary>
// 
//  <date>17-06-2020</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------

using Nenov.DesignPatterns.Decorator.Example;

namespace Nenov.DesignPatterns.Decorator
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var decorator = new DecoratorExample();
      decorator.TryDecorator();
    }
  }
}