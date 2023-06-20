﻿using System;
using System.Linq;

namespace System.ComponentModel.DataAnnotations {

  /// <summary>
  /// Defines, which PropertyGroup will be treated as Primary Identity (=PK) for the current entity
  /// (from 'FUSE-fx.EntityAnnotations')
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
  public class PrimaryIdentityAttribute : Attribute {

    /// <summary>
    /// Defines, which PropertyGroup will be treated as Primary Identity (=PK) for the current entity
    /// (from 'FUSE-fx.EntityAnnotations')
    /// </summary>
    /// <param name="propertyGroupName">The name of a UniquePropertyGroup which is defined on the current class (using the UniquePropertyGroupAttribute)!</param>
    public PrimaryIdentityAttribute(string propertyGroupName) {
      this.PropertyGroupName = propertyGroupName;
    }

    /// <summary>
    /// The name of a UniquePropertyGroup which is defined on the current class (using the UniquePropertyGroupAttribute)!
    /// (from 'FUSE-fx.EntityAnnotations')
    /// </summary>
    public String PropertyGroupName { get; }

  }

}
