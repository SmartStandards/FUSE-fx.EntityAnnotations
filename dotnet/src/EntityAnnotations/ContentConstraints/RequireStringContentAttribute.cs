using System;
using System.Linq;

namespace System.ComponentModel.DataAnnotations.ContentConstraints {

  /// <summary>
  ///  Defines, that a Property contains String-Content.
  ///  This Attribute is ONLY VALID when placed on a Property of Type of STRING!
  /// </summary>
  [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
  public class RequireStringContentAttribute : Attribute {

    /// <summary>
    ///  Defines, that a Property contains String-Content.
    ///  This Attribute is ONLY VALID when placed on a Property of Type of STRING!
    /// </summary>
    /// <param name="allowedValueOrPatternOrRegex"></param>
    /// <param name="additionalAllowedValuesOrPatternsOrRegexs"></param>
    public RequireStringContentAttribute(  
      string allowedValueOrPatternOrRegex,
      params string[] additionalAllowedValuesOrPatternsOrRegexs
    ) {




    }

    /// <summary>
    ///  Defines, that a Property contains String-Content.
    ///  This Attribute is ONLY VALID when placed on a Property of Type of STRING!
    /// </summary>
    /// <param name="disallowEmptyString"></param>
    /// <param name="disallowWhitespaceString"></param>
    /// <param name="allowMultiLine"></param>
    /// <param name="mayLength"></param>
    /// <param name="blacklist"></param>
    public RequireStringContentAttribute(
      bool disallowEmptyString = true,
      bool disallowWhitespaceString = true,
      bool allowMultiLine = false,
      int mayLength = -1,
      params string[] blacklist
    ) {




    }

  }

  public static class StringContentPatterns {

    public const string IpAddressV4 = "todo-regey";
    public const string IpAddressV6 = "todo-regey";
    public const string IpAddressV4orV6 = "todo-regey";



  }

}
