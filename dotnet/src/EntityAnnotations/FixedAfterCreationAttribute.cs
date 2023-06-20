using System;

namespace System.ComponentModel.DataAnnotations {

  /// <summary>
  /// (from 'FUSE-fx.EntityAnnotations')
  /// </summary>
  [Obsolete("This attribute is Obsolete - please use 'Setable(Setability.OnCreation)' instead!")]
  [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
  public class FixedAfterCreationAttribute : Attribute {

    public FixedAfterCreationAttribute() {
    }

  }

  /// <summary>
  /// Defines, in which cases a field is ment to be set.
  /// This is a non-technical information, which relates
  /// to the domain model (business-level)!
  /// (from 'FUSE-fx.EntityAnnotations')
  /// </summary>
  [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
  public class SetableAttribute : Attribute {

    public SetableAttribute(Setability setability) {
      this.Setability = setability;
    }

    public Setability Setability { get; }

  }

  /// <summary>
  /// Defines, in which cases a field is ment to be set.
  /// This is a non-technical information, which relates
  /// to the domain model (business-level)!
  /// (from 'FUSE-fx.EntityAnnotations')
  /// </summary>
  [Flags]
  public enum Setability {

    /// <summary> this field should only be set by wellknown technical automatisms </summary>
    Never = 0,

    /// <summary> this field should be setable when a record is created newly (or on full-import/recovery) </summary>
    OnCreation = 1,

    /// <summary> this field should be setable during the usecase of an individual edit</summary>
    OnSingleUpdate = 2,

    /// <summary> this field should be setable during a batch-update for multiple records</summary>
    OnBatchUpdate = 4,

    /// <summary> represents the logical combination of 'OnSingleUpdate' + 'OnBatchUpdate' </summary>
    AfterCreation = 6,

    /// <summary> represents the logical combination of 'OnCreation' + 'AfterCreation' </summary>
    Always = 7

  }

}
