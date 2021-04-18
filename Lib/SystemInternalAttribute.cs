using System;

namespace System.ComponentModel.DataAnnotations {

  [AttributeUsage(AttributeTargets.Property)]
  public class SystemInternalAttribute : Attribute {

    public SystemInternalAttribute() {
    }

  }

}
