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