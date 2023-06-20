using System;

namespace System.ComponentModel.DataAnnotations {

  /// <summary>
  /// (from 'FUSE-fx.EntityAnnotations')
  /// </summary>
  [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
  public class SystemInternalAttribute : Attribute {

    public SystemInternalAttribute() {
    }

  }

}
