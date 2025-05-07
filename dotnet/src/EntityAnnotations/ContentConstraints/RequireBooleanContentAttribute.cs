using System;
using System.Linq;

namespace System.ComponentModel.DataAnnotations.ContentConstraints {

  /// <summary>
  ///  Defines, that a Property contains Date(Time)-Content.
  ///  This Attribute is ONLY VALID when placed on a Property of Type of BOOL,
  ///  or any INTEGER/STRING Property to be used with true/false representing magic-values
  ///  (see constructor signature for customizing that magic-values)
  /// </summary>
  [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
  public class RequireBooleanContentAttribute : Attribute {

    /// <summary>
    ///  Defines, that a Property contains Date(Time)-Content.
    ///  This Attribute is ONLY VALID when placed on a Property of Type of BOOL,
    ///  or any INTEGER/STRING Property to be used with true/false representing magic-values
    ///  (see constructor signature for customizing that magic-values)
    /// </summary>
    public RequireBooleanContentAttribute() {

    }

    /// <summary>
    ///  Defines, that a Property contains Date(Time)-Content.
    ///  This overload is dedicated only for usage of this attribute on INTEGER/STRING properties.
    ///  It will limit the value-range to 2 or max 3 possible values, defined by the given mapping.
    /// </summary>
    /// <param name="trueValue">defines which magic-value is used, to represent the semantic of TRUE</param>
    /// <param name="falseValue">defines which magic-value is used, to represent the semantic of FALSE</param>
    /// <param name="tentativeValue">
    /// defines which magic-value is used, to represent the semantic of TENTATIVE.
    /// If null or no value is provided, then the possibility of a tentative state is depending on the
    /// nullability of the property.
    /// </param>
    public RequireBooleanContentAttribute(object trueValue, object falseValue, object tentativeValue = null) {

    }

  }

}
