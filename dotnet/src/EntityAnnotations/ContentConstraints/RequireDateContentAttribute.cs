using System;
using System.Linq;

namespace System.ComponentModel.DataAnnotations.ContentConstraints {

  /// <summary>
  ///  Defines, that a Property contains Date(Time)-Content.
  ///  This Attribute is ONLY VALID when placed on a Property of Type of DATETIME,
  ///  LONG (which will have the semantic of a UnixTimestamp in UTC)
  ///  or STRING (which will have the semantic of an ISO-8601 date string)
  /// </summary>
  [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
  public class RequireDateContentAttribute : Attribute {

    /// <summary>
    ///  Defines, that a Property contains Date(Time)-Content.
    ///  This Attribute is ONLY VALID when placed on a Property of Type of DATETIME,
    ///  LONG (which will have the semantic of a UnixTimestamp in UTC)
    ///  or STRING (which will have the semantic of an ISO-8601 date string)
    /// </summary>
    /// <param name="defaultRepresentingVaue">usually 0001-01-01 or 1900-01-01 or 1970-01-01</param>
    /// <param name="hasTimePortion">if false, then the time portion always must have the fixed value 00:00:00</param>
    /// <param name="allowDefaultValue"></param>
    public RequireDateContentAttribute(
      DateTime defaultRepresentingVaue, bool hasTimePortion = false, bool allowDefaultValue = true
    ) {
 

    }

    /// <summary>
    ///  Defines, that a Property contains Date(Time)-Content.
    ///  This Attribute is ONLY VALID when placed on a Property of Type of DATETIME,
    ///  LONG (which will have the semantic of a UnixTimestamp in UTC)
    ///  or STRING (which will have the semantic of an ISO-8601 date string)
    /// </summary>
    /// <param name="defaultRepresentingVaue">usually 0001-01-01 or 1900-01-01 or 1970-01-01</param>
    /// <param name="minAllowedValue">defines the valid timerange</param>
    /// <param name="maxAllowedValue">defines the valid timerange</param>
    public RequireDateContentAttribute(
      DateTime defaultRepresentingVaue, DateTime minAllowedValue, DateTime maxAllowedValue
    ) {


    }

    /// <summary>
    ///  Defines, that a Property contains Date(Time)-Content.
    ///  This Attribute is ONLY VALID when placed on a Property of Type of DATETIME,
    ///  LONG (which will have the semantic of a UnixTimestamp in UTC)
    ///  or STRING (which will have the semantic of an ISO-8601 date string) 
    /// </summary>
    /// <param name="defaultRepresentingVaue">usually 0001-01-01 or 1900-01-01 or 1970-01-01</param>
    /// <param name="hasTimePortion">if false, then the time portion always must have the fixed value 00:00:00</param>
    /// <param name="minAllowedValue">defines the valid timerange</param>
    /// <param name="maxAllowedValue">defines the valid timerange</param>
    public RequireDateContentAttribute(
      DateTime defaultRepresentingVaue, bool hasTimePortion, DateTime minAllowedValue, DateTime maxAllowedValue
    ) {


    }

  }

}
