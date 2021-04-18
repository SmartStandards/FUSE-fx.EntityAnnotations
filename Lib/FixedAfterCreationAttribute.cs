using System;

namespace System.ComponentModel.DataAnnotations {

  [AttributeUsage(AttributeTargets.Property)]
  public class FixedAfterCreationAttribute : Attribute {

    public FixedAfterCreationAttribute() {
    }

  }

}
