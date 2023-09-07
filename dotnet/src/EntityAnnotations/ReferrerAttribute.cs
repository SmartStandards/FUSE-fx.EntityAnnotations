using System;

namespace System.ComponentModel.DataAnnotations {

  /// <summary>
  /// qualifies a Navigation-Property
  /// (this should be used in combination with the HasReferrerAttribute on the current entity-type which declares the details of the association) 
  /// (from 'FUSE-fx.EntityAnnotations')
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
  public class ReferrerAttribute : Attribute {

    /// <summary>
    /// qualifies a Navigation-Property
    /// (this should be used in combination with the HasReferrerAttribute on the current entity-type which declares the details of the association) 
    /// </summary>
    public ReferrerAttribute() {
    }

  }

  /// <summary>
  /// Defines, that this entity has an INBOUND relationship by a associated entity for which the current entity is a LOOKUP.
  /// (from 'FUSE-fx.EntityAnnotations')
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
  public class HasReferrerAttribute : Attribute {

    /// <summary>
    /// Defines, that this entity has an INBOUND relationship by a associated entity for which the current entity is a LOOKUP.
    /// </summary>
    /// <param name="localNavigationName">can be just defined here, or in combination with an identically named navigation-property qualified by a ReferrerAttribute </param>
    /// <param name="localKeyPropertyGroupName">name of a PropertyGroup defined on the local entity, which will be used as 'Primary-Key' (if not sepecified, then the PrimaryIdentityAttribute will used to identify the primary PropertyGroup name)</param>
    public HasReferrerAttribute(string localNavigationName, string localKeyPropertyGroupName = null) {
      this.LocalNavigationName = localNavigationName;
      this.LocalKeyPropertyGroupName = localKeyPropertyGroupName;
    }

    /// <summary>
    /// Defines, that this entity has an INBOUND relationship by a associated entity for which the current entity is a LOOKUP.
    /// In addition to that, this specific overload will also define details for reversed view from for the remote entity -> this should only be done, if it is not possible to specify attributes on the remote entity (preferred way) 
    /// </summary>
    /// <param name="localNavigationName">can be just defined here, or in combination with an identically named navigation-property qualified by a ReferrerAttribute </param>
    /// <param name="fkPropertyGroupOnReferrer">name of a PropertyGroup defined on the Referring entity which will be used as 'Foreigen-Key'</param>
    /// <param name="navigationNameOnReferrer">should be defined to qualify each direction of the association (also, if there is no navigation-property)</param>
    /// <param name="localKeyPropertyGroupName">name of a PropertyGroup defined on the local entity, which will be used as 'Primary-Key' (if not sepecified, then the PrimaryIdentityAttribute will used to identify the primary PropertyGroup name)</param>
    public HasReferrerAttribute(string localNavigationName, string fkPropertyGroupOnReferrer, string navigationNameOnReferrer, string localKeyPropertyGroupName = null) {
      this.LocalNavigationName = localNavigationName;
      this.FkPropertyGroupOnReferrer = fkPropertyGroupOnReferrer;
      this.NavigationNameOnReferrer = navigationNameOnReferrer;
      this.LocalKeyPropertyGroupName = localKeyPropertyGroupName;
    }

    /// <summary>
    /// Defines, that this entity has an INBOUND relationship by a associated entity for which the current entity is a LOOKUP.
    /// In addition to that, this specific overload will also define details for reversed view from for the remote entity -> this should only be done, if it is not possible to specify attributes on the remote entity (preferred way) 
    /// </summary>
    /// <param name="localNavigationName">can be just defined here, or in combination with an identically named navigation-property qualified by a ReferrerAttribute </param>
    /// <param name="fkPropertyNamesOnReferrer">One ore more Property names on the Referring entity which will be used as 'Foreigen-Key'</param>
    /// <param name="navigationNameOnReferrer">should be defined to qualify each direction of the association (also, if there is no navigation-property)</param>
    /// <param name="localKeyPropertyGroupName">name of a PropertyGroup defined on the local entity, which will be used as 'Primary-Key' (if not sepecified, then the PrimaryIdentityAttribute will used to identify the primary PropertyGroup name)</param>
    public HasReferrerAttribute(string localNavigationName, string[] fkPropertyNamesOnReferrer, string navigationNameOnReferrer, string localKeyPropertyGroupName = null) {
      this.LocalNavigationName = localNavigationName;
      this.FkPropertyNamesOnReferrer = fkPropertyNamesOnReferrer;
      this.NavigationNameOnReferrer = navigationNameOnReferrer;
      this.LocalKeyPropertyGroupName = localKeyPropertyGroupName;
    }

    /// <summary>
    /// can be just defined here, or in combination with an identically named navigation-property qualified by a ReferrerAttribute
    /// </summary>
    public string LocalNavigationName { get; }

    /// <summary>
    /// name of a PropertyGroup defined on the Referring entity which will be used as 'Foreigen-Key'
    /// </summary>
    public string FkPropertyGroupOnReferrer { get; }

    /// <summary>
    /// One ore more Property names on the Referring entity which will be used as 'Foreigen-Key'
    /// </summary>
    public string[] FkPropertyNamesOnReferrer { get; }

    /// <summary>
    /// should be defined to qualify each direction of the association (also, if there is no navigation-property)
    /// </summary>
    public string NavigationNameOnReferrer { get; }

    /// <summary>
    /// name of a PropertyGroup defined on the local entity, which will be used as 'Primary-Key' (if not sepecified, then the PrimaryIdentityAttribute will used to identify the primary PropertyGroup name)
    /// </summary>
    public string LocalKeyPropertyGroupName { get; }

  }

}
