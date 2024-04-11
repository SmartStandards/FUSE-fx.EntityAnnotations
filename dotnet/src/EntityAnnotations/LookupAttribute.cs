using System;

namespace System.ComponentModel.DataAnnotations {

  /// <summary>
  /// qualifies a Navigation-Property
  /// (this should be used in combination with the HasLookupAttribute on the current entity-type which declares the details of the association) 
  /// (from 'FUSE-fx.EntityAnnotations')
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
  public class LookupAttribute : Attribute {

    /// <summary>
    /// qualifies a Navigation-Property
    /// (this should be used in combination with the HasLookupAttribute on the current entity-type which declares the details of the association) 
    /// </summary>
    public LookupAttribute() {
    }

  }

  /// <summary>
  /// Defines, that this entity has an OUTBOUND relationship to another entity which represents a LOOKUP.
  /// (from 'FUSE-fx.EntityAnnotations')
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
  public class HasLookupAttribute : Attribute {

    /// <summary>
    /// Defines, that this entity has an OUTBOUND relationship to another entity which represents a LOOKUP.
    /// </summary>
    /// <param name="localNavigationName">can be just defined here, or in combination with an identically named navigation-property qualified by a LookupAttribute </param>
    /// <param name="localFkPropertyGroupName">name of a local defined PropertyGroup which will be used as 'Foreigen-Key'</param>
    public HasLookupAttribute(string localNavigationName, string localFkPropertyGroupName) {
      this.LocalNavigationName = localNavigationName;
      this.LocalFkPropertyGroupName = localFkPropertyGroupName;
    }

    /// <summary>
    /// Defines, that this entity has an OUTBOUND relationship to another entity which represents a LOOKUP.
    /// In addition to that, this specific overload will also define details for reversed view from for the remote entity -> this should only be done, if it is not possible to specify attributes on the remote entity (preferred way)
    /// </summary>
    /// <param name="localNavigationName">can be just defined here, or in combination with an identically named navigation-property qualified by a LookupAttribute </param>
    /// <param name="localFkPropertyGroupName">name of a local defined PropertyGroup which will be used as 'Foreigen-Key'</param>
    /// <param name="navigationNameOnLookup">should be defined to qualify each direction of the association (also, if there is no navigation-property)</param>
    /// <param name="keyPropertyGroupNameOnLookup">name of a PropertyGroup defined on the target entity, which will be used as 'Primary-Key' (if not sepecified, then the PrimaryIdentityAttribute will used to identify the primary PropertyGroup name)</param>
    /// <param name="lookupTypeName">typename of Lookup Entity</param>
    public HasLookupAttribute(
      string localNavigationName, string localFkPropertyGroupName, string navigationNameOnLookup, 
      string keyPropertyGroupNameOnLookup = null, string lookupTypeName = null
    ) {
      this.LocalNavigationName = localNavigationName;
      this.LocalFkPropertyGroupName = localFkPropertyGroupName;
      this.NavigationNameOnLookup = navigationNameOnLookup;
      this.KeyPropertyGroupNameOnLookup = keyPropertyGroupNameOnLookup;
      this.LookupTypeName = lookupTypeName;
    }

    /// <summary>
    /// Defines, that this entity has an OUTBOUND relationship to another entity which represents a LOOKUP.
    /// In addition to that, this specific overload will also define details for reversed view from for the remote entity -> this should only be done, if it is not possible to specify attributes on the remote entity (preferred way)
    /// </summary>
    /// <param name="localNavigationName">can be just defined here, or in combination with an identically named navigation-property qualified by a LookupAttribute </param>
    /// <param name="localFkPropertyGroupName">name of a local defined PropertyGroup which will be used as 'Foreigen-Key'</param>
    /// <param name="navigationNameOnLookup">should be defined to qualify each direction of the association (also, if there is no navigation-property)</param>
    /// <param name="keyPropertyNamesOnLookup">name of a PropertyGroup defined on the target entity, which will be used as 'Primary-Key' (if not sepecified, then the PrimaryIdentityAttribute will used to identify the primary PropertyGroup name)</param>
    public HasLookupAttribute(string localNavigationName, string localFkPropertyGroupName, string navigationNameOnLookup, string[] keyPropertyNamesOnLookup) {
      this.LocalNavigationName = localNavigationName;
      this.LocalFkPropertyGroupName = localFkPropertyGroupName;
      this.NavigationNameOnLookup = navigationNameOnLookup;
      this.KeyPropertyNamesOnLookup = keyPropertyNamesOnLookup;
    }

    /// <summary>
    /// can be just defined here, or in combination with an identically named navigation-property qualified by a LookupAttribute
    /// </summary>
    public string LocalNavigationName { get; }

    /// <summary>
    /// name of a local defined PropertyGroup which will be used as 'Foreigen-Key'
    /// </summary>
    public string LocalFkPropertyGroupName { get; }

    /// <summary>
    /// should be defined to qualify each direction of the association (also, if there is no navigation-property)
    /// </summary>
    public string NavigationNameOnLookup { get; }

    /// <summary>
    /// name of the type of the Lookup
    /// </summary>
    public string LookupTypeName { get; }

    /// <summary>
    /// name of a PropertyGroup defined on the target entity, which will be used as 'Primary-Key' (if not sepecified, then the PrimaryIdentityAttribute will used to identify the primary PropertyGroup name)
    /// </summary>
    public string KeyPropertyGroupNameOnLookup { get; }

    /// <summary>
    /// name of a PropertyGroup defined on the target entity, which will be used as 'Primary-Key' (if not sepecified, then the PrimaryIdentityAttribute will used to identify the primary PropertyGroup name)
    /// </summary>
    public string[] KeyPropertyNamesOnLookup { get; }

  }

}
