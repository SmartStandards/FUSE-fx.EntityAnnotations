using System;
using System.Linq;

namespace System.ComponentModel.DataAnnotations {

  /// <summary>
  ///  Defines, that a Property contains Business-Content
  ///  (from 'FUSE-fx.EntityAnnotations')
  /// </summary>
  [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
  public class ContentAttribute : Attribute {

    /// <summary>
    ///  Defines, that a Property contains Business-Content
    /// </summary>
    /// <param name="specializedConcern">
    ///   Indicates, if a field belongs to a more specific business domain.
    ///   This can be used to control the detail-grade (displayed fields) in the UI
    ///   or when exporting data in an abstract way.
    /// </param>
    public ContentAttribute(string specializedConcern = null) {
      this.SpecializedConcern = specializedConcern;
    }

    /// <summary>
    ///   Indicates, if a field belongs to a more specific business domain.
    ///   This can be used to control the detail-grade (displayed fields) in the UI
    ///   or when exporting data in an abstract way.
    /// </summary>
    public string SpecializedConcern { get; }

  }

  /// <summary>
  ///  Defines, that a Property contains content, which represents a human readable natural
  ///  key, that should be preferred when refering to the current record (UI/Logging/Tracing).
  ///  This is a non-technical information, which relates to the domain model (business-level)!
  ///  (from 'FUSE-fx.EntityAnnotations')
  /// </summary>
  [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
  public class IdentityLabelAttribute : Attribute {

    /// <summary>
    ///  Defines, that a Property contains content, which represents a human readable natural
    ///  key, that should be preferred when refering to the current record (UI/Logging/Tracing).
    ///  This is a non-technical information, which relates to the domain model (business-level)!
    /// </summary>
    public IdentityLabelAttribute() {
    }

  }

  /// <summary>
  ///  Defines whether a field contains content that is commonly used for filtering.
  ///  This is a non-technical information, which relates to the domain model (business-level)!
  ///  (from 'FUSE-fx.EntityAnnotations')
  /// </summary>
  [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
  public class FilterableAttribute : Attribute {

    /// <summary>
    ///  Defines whether a field contains content that is commonly used for filtering.
    ///  This is a non-technical information, which relates to the domain model (business-level)!
    /// </summary>
    public FilterableAttribute(Filterability filterability) {
      this.Filterability = filterability;
    }

    public Filterability Filterability { get; }

  }

  /// <summary>
  ///  Defines whether a field contains content that is commonly used for filtering.
  ///  This is a non-technical information, which relates to the domain model (business-level)!
  ///  (from 'FUSE-fx.EntityAnnotations')
  /// </summary>
  [Flags]
  public enum Filterability {
    None = 0,
    ExactMatch = 1,
    Substring = 2
  }

  /// <summary>
  ///  Defines whether a field contains content that is sematically owned by the current entity,
  ///  so that it wont make sense to offer usecases like batch/mass-updates for it.
  ///  Also when creating a clone (using this entity as template) the content of this field 
  ///  should not be included by default.
  ///  (from 'FUSE-fx.EntityAnnotations')
  /// </summary>
  [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
  public class IdentityProtectedAttribute : Attribute {

    /// <summary>
    ///  Defines whether a field contains content that is sematically owned by the current entity,
    ///  so that it wont make sense to offer usecases like batch/mass-updates for it.
    ///  Also when creating a clone (using this entity as template) the content of this field 
    ///  should not be included by default.
    /// </summary>
    public IdentityProtectedAttribute(bool isIdentityProtected) {
      this.IsIdentityProtected = isIdentityProtected;
    }

    public bool IsIdentityProtected { get; }

  }

}
