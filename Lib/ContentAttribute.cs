using System;
using System.Linq;

namespace System.ComponentModel.DataAnnotations {

  /// <summary>
  /// Defines, that a Property contains Business-Content
  /// </summary>
  [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
  public class ContentAttribute : Attribute {

    /// <summary>
    /// Defines, that a Property contains Business-Content
    /// </summary>
    public ContentAttribute() {
    }

  }

}
