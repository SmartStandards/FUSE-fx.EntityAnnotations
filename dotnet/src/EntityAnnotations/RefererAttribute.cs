using System;

namespace System.ComponentModel.DataAnnotations {

  /// <summary>
  /// qualifies a Navigation-Property
  /// (this should be used in combination with the HasRefererAttribute on the current entity-type which declares the details of the association) 
  /// (from 'FUSE-fx.EntityAnnotations')
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
  public class RefererAttribute : Attribute {

    /// <summary>
    /// qualifies a Navigation-Property
    /// (this should be used in combination with the HasRefererAttribute on the current entity-type which declares the details of the association) 
    /// </summary>
    public RefererAttribute() {
    }

  }

  /// <summary>
  /// Defines, that this entity has an INBOUND relationship by a associated entity for which the current entity is a LOOKUP.
  /// (from 'FUSE-fx.EntityAnnotations')
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
  public class HasRefererAttribute : Attribute {

    /// <summary>
    /// Defines, that this entity has an INBOUND relationship by a associated entity for which the current entity is a LOOKUP.
    /// </summary>
    /// <param name="localNavigationName">can be just defined here, or in combination with an identically named navigation-property qualified by a RefererAttribute </param>
    /// <param name="localKeyPropertyGroupName">name of a PropertyGroup defined on the local entity, which will be used as 'Primary-Key' (if not sepecified, then the PrimaryIdentityAttribute will used to identify the primary PropertyGroup name)</param>
    public HasRefererAttribute(string localNavigationName, string localKeyPropertyGroupName = null) {
      this.LocalNavigationName = localNavigationName;
      this.LocalKeyPropertyGroupName = localKeyPropertyGroupName;
    }

    /// <summary>
    /// Defines, that this entity has an INBOUND relationship by a associated entity for which the current entity is a LOOKUP.
    /// In addition to that, this specific overload will also define details for reversed view from for the remote entity -> this should only be done, if it is not possible to specify attributes on the remote entity (preferred way) 
    /// </summary>
    /// <param name="localNavigationName">can be just defined here, or in combination with an identically named navigation-property qualified by a RefererAttribute </param>
    /// <param name="fkPropertyGroupOnReferer">name of a PropertyGroup defined on the Referring entity which will be used as 'Foreigen-Key'</param>
    /// <param name="navigationNameOnReferer">should be defined to qualify each direction of the association (also, if there is no navigation-property)</param>
    /// <param name="localKeyPropertyGroupName">name of a PropertyGroup defined on the local entity, which will be used as 'Primary-Key' (if not sepecified, then the PrimaryIdentityAttribute will used to identify the primary PropertyGroup name)</param>
    public HasRefererAttribute(string localNavigationName, string fkPropertyGroupOnReferer, string navigationNameOnReferer, string localKeyPropertyGroupName = null) {
      this.LocalNavigationName = localNavigationName;
      this.FkPropertyGroupOnReferer = fkPropertyGroupOnReferer;
      this.NavigationNameOnReferer = navigationNameOnReferer;
      this.LocalKeyPropertyGroupName = localKeyPropertyGroupName;
    }

    /// <summary>
    /// Defines, that this entity has an INBOUND relationship by a associated entity for which the current entity is a LOOKUP.
    /// In addition to that, this specific overload will also define details for reversed view from for the remote entity -> this should only be done, if it is not possible to specify attributes on the remote entity (preferred way) 
    /// </summary>
    /// <param name="localNavigationName">can be just defined here, or in combination with an identically named navigation-property qualified by a RefererAttribute </param>
    /// <param name="fkPropertyNamesOnReferer">One ore more Property names on the Referring entity which will be used as 'Foreigen-Key'</param>
    /// <param name="navigationNameOnReferer">should be defined to qualify each direction of the association (also, if there is no navigation-property)</param>
    /// <param name="localKeyPropertyGroupName">name of a PropertyGroup defined on the local entity, which will be used as 'Primary-Key' (if not sepecified, then the PrimaryIdentityAttribute will used to identify the primary PropertyGroup name)</param>
    public HasRefererAttribute(string localNavigationName, string[] fkPropertyNamesOnReferer, string navigationNameOnReferer, string localKeyPropertyGroupName = null) {
      this.LocalNavigationName = localNavigationName;
      this.FkPropertyNamesOnReferer = fkPropertyNamesOnReferer;
      this.NavigationNameOnReferer = navigationNameOnReferer;
      this.LocalKeyPropertyGroupName = localKeyPropertyGroupName;
    }

    /// <summary>
    /// can be just defined here, or in combination with an identically named navigation-property qualified by a RefererAttribute
    /// </summary>
    public string LocalNavigationName { get; }

    /// <summary>
    /// name of a PropertyGroup defined on the Referring entity which will be used as 'Foreigen-Key'
    /// </summary>
    public string FkPropertyGroupOnReferer { get; }

    /// <summary>
    /// One ore more Property names on the Referring entity which will be used as 'Foreigen-Key'
    /// </summary>
    public string[] FkPropertyNamesOnReferer { get; }

    /// <summary>
    /// should be defined to qualify each direction of the association (also, if there is no navigation-property)
    /// </summary>
    public string NavigationNameOnReferer { get; }

    /// <summary>
    /// name of a PropertyGroup defined on the local entity, which will be used as 'Primary-Key' (if not sepecified, then the PrimaryIdentityAttribute will used to identify the primary PropertyGroup name)
    /// </summary>
    public string LocalKeyPropertyGroupName { get; }

  }

}
