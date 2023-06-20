using System;
using System.Linq;

namespace System.ComponentModel.DataAnnotations {

  /// <summary>
  /// Defines a PropertyGroup on the current entity which contains a combination of values
  /// in order to be used for creating an index and/or addressing foreign entities (use as FK)
  /// (from 'FUSE-fx.EntityAnnotations')
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
  public class PropertyGroupAttribute : Attribute {

    /// <summary>
    /// Defines a PropertyGroup on the current entity which contains a combination of values
    /// in order to be used for creating an index and/or addressing foreign entities (use as FK)
    /// </summary>
    /// <param name="groupName"></param>
    /// <param name="propertyName1"></param>
    /// <param name="additionalPropertyNames"></param>
    public PropertyGroupAttribute(string groupName, string propertyName1, params string[] additionalPropertyNames) {
      this.GroupName = groupName;
      if (additionalPropertyNames != null && additionalPropertyNames.Length > 0) {
        this.PropertyNames = new string[] { propertyName1 }.Union(additionalPropertyNames).ToArray();
      }
      else {
        this.PropertyNames = new string[] { propertyName1 };
      }

    }

    public String GroupName { get; }
    public string[] PropertyNames { get; }

  }

  /// <summary>
  /// Defines a PropertyGroup on the current entity which contains a unique combination of values
  /// in order to be used for creating an index and/or addressing the current entity
  /// (from 'FUSE-fx.EntityAnnotations')
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
  public class UniquePropertyGroupAttribute : Attribute {

    /// <summary>
    /// Defines a PropertyGroup on the current entity which contains a unique combination of values
    /// in order to be used for creating an index and/or addressing the current entity
    /// </summary>
    /// <param name="groupName"></param>
    /// <param name="propertyName1"></param>
    /// <param name="additionalPropertyNames"></param>
    public UniquePropertyGroupAttribute(string groupName, string propertyName1, params string[] additionalPropertyNames) {
      this.GroupName = groupName;
      if (additionalPropertyNames != null && additionalPropertyNames.Length > 0) {
        this.PropertyNames = new string[] { propertyName1 }.Union(additionalPropertyNames).ToArray();
      }
      else {
        this.PropertyNames = new string[] { propertyName1 };
      }

    }

    public String GroupName { get; }
    public string[] PropertyNames { get; }

  }

}
