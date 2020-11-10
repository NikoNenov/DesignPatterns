//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Program.cs">
//  (c) 2020 Nikolay Nenov, Solothurn, Switzerland, www.nenov.de
//  </copyright>
// 
//  <summary>
//    Main "Template Method" pattern example
//  </summary>
// 
//  <date>17-06-2020</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------

using System;
using Nenov.DesignPatterns.TemplateMethod.Example;

namespace Nenov.DesignPatterns.TemplateMethod
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var menu = $"===== Template Method - design pattern ===== {Environment.NewLine}" + 
                 $" **** Behavioral Pattern **** {Environment.NewLine}";
      Console.WriteLine(menu);
      
      var templateMethod = new TemplateMethodExample();
      templateMethod.TryTemplateMethod();
    }
  }
}