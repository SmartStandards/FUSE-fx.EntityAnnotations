using System;

namespace System.ComponentModel.DataAnnotations {

  [AttributeUsage(AttributeTargets.Property)]
  public class LookupAttribute : Attribute {

    public LookupAttribute() {
    }

  }

}
