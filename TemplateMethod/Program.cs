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