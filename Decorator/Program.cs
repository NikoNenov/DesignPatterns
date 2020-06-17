//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Program.cs" company="Curtis Instruments AG">
//  (c) 2020 Curtis Instruments AG, Biberist, Switzerland, www.curtis.ch
//  </copyright>
// 
//  <summary>
//    TODO .......
//  </summary>
// 
//  <date>17-06-2020</date>
//  <author>nenovn</author>
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