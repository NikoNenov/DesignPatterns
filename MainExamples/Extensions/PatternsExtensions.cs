using System.ComponentModel;
using System.Linq;
using Nenov.DesignPatterns.MainExamples.Definitions;

namespace Nenov.DesignPatterns.MainExamples.Extensions
{
  public static class PatternsExtensions
  {
    public static string GetEnumDescription(this Patterns pattern)
    {
      var attributes = (DescriptionAttribute[])pattern
        .GetType()
        .GetField(pattern.ToString())
        .GetCustomAttributes(typeof(DescriptionAttribute), false);

      return attributes.Length > 0 ? attributes.First().Description : string.Empty;
    }
  }
}
