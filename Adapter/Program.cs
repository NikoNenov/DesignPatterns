//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Program.cs">
//  (c) 2020 Nikolay Nenov, Solothurn, Switzerland, www.nenov.de
//  </copyright>
// 
//  <summary>
//    Main start "Adapter" pattern example
//  </summary>
// 
//  <date>17-06-2020</date>
//  <author>Nikolay Nenov</author>
//  --------------------------------------------------------------------------------------------------------------------

using Nenov.DesignPatterns.Adapter.Example;

namespace Nenov.DesignPatterns.Adapter
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var adapter = new AdapterExample();
      adapter.TryAdapter();
    }
  }
}