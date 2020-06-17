//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Program.cs">
//  (c) 2020 Nikolay Nenov, Solothurn, Switzerland, www.nenov.de
//  </copyright>
// 
//  <summary>
//    Main "Adapter" pattern example
//  </summary>
// 
//  <date>17-06-2020</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------

using Nenov.DesignPatterns.TemplateMethod.Example;

namespace Nenov.DesignPatterns.TemplateMethod
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var templateMethod = new TemplateMethodExample();
      templateMethod.TryTemplateMethod();
    }
  }
}