using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace System.ComponentModel.DataAnnotations.ContentConstraints {

  /// <summary>
  ///  Defines, that a Property contains Numeric-Content.
  ///  This Attribute is ONLY VALID when placed on a Property with an numeric Type like
  ///  INTEGER/DECIMAL/DOUBLE/... or (as a special case) STRING!
  /// </summary>
  [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
  public class RequireNumericContentAttribute : Attribute {

    /// <summary>
    ///  Defines, that a Property contains Numeric-Content.
    ///  This Attribute is ONLY VALID when placed on a Property with an numeric Type like
    ///  INTEGER/DECIMAL/DOUBLE/... or (as a special case) STRING!
    /// </summary>
    /// <param name="disallowZero"></param>
    /// <param name="positiveOnly"></param>
    /// <param name="decimalDigits"></param>
    public RequireNumericContentAttribute(
      bool disallowZero, bool positiveOnly = true , int decimalDigits = -1
    ) {

    }

    /// <summary>
    ///  Defines, that a Property contains Numeric-Content.
    ///  This Attribute is ONLY VALID when placed on a Property with an numeric Type like
    ///  INTEGER/DECIMAL/DOUBLE/... or (as a special case) STRING!
    /// </summary>
    /// <param name="disallowZero"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <param name="decimalDigits"></param>
    public RequireNumericContentAttribute(
      bool disallowZero, object rangeFrom, object rangeTo, int decimalDigits = -1
    ) {

    }

    /// <summary>
    ///  Defines, that a Property contains Numeric-Content.
    ///  This Attribute is ONLY VALID when placed on a Property with an numeric Type like
    ///  INTEGER/DECIMAL/DOUBLE/... or (as a special case) STRING!
    /// </summary>
    /// <param name="allowedValues"></param>
    public RequireNumericContentAttribute(
      params int[] allowedValues
    ) {

    }

  }

  internal class Demo {

    [RequireNumericContent(true)]
    public string Property1 { get; set; }

    [RequireNumericContent(8, 16, 32, 64)]
    public string Property2 { get; set; }

  }

}
