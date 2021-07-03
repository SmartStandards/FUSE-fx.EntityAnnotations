using System;

namespace System.ComponentModel.DataAnnotations {

  [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
  public class SystemInternalAttribute : Attribute {

    public SystemInternalAttribute() {
    }

  }

}
