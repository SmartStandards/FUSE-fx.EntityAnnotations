using System;

namespace System.ComponentModel.DataAnnotations {

  [AttributeUsage(AttributeTargets.Property)]
  public class DependentAttribute : Attribute {

    public DependentAttribute() {
    }

  }

}
