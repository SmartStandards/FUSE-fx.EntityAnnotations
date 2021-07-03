using System;

namespace System.ComponentModel.DataAnnotations {

  [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
  public class FixedAfterCreationAttribute : Attribute {

    public FixedAfterCreationAttribute() {
    }

  }

}
