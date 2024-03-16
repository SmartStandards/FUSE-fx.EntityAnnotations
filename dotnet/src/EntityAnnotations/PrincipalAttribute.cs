using System;

namespace System.ComponentModel.DataAnnotations {

  /// <summary>
  /// qualifies a Navigation-Property
  /// (this should be used in combination with the HasPrincipalAttribute on the current entity-type which declares the details of the association) 
  /// (from 'FUSE-fx.EntityAnnotations')
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
  public class PrincipalAttribute : Attribute {

    /// <summary>
    /// qualifies a Navigation-Property
    /// (this should be used in combination with the HasPrincipalAttribute on the current entity-type which declares the details of the association) 
    /// </summary>
    public PrincipalAttribute() {
    }

  }

  /// <summary>
  /// Defines, that this entity has an OUTBOUND dependency to another entity which represents the PRINCIPAL.
  /// (from 'FUSE-fx.EntityAnnotations')
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
  public class HasPrincipalAttribute : Attribute {

    /// <summary>
    /// Defines, that this entity has an OUTBOUND dependency to another entity which represents the PRINCIPAL.
    /// </summary>
    /// <param name="localNavigationName">can be just defined here, or in combination with an identically named navigation-property qualified by a PrincipalAttribute </param>
    /// <param name="localFkPropertyGroupName">name of a local defined PropertyGroup which will be used as 'Foreigen-Key'</param>
    public HasPrincipalAttribute(string localNavigationName, string localFkPropertyGroupName) {
      this.LocalNavigationName = localNavigationName;
      this.LocalFkPropertyGroupName = localFkPropertyGroupName;
    }

    /// <summary>
    /// Defines, that this entity has an OUTBOUND dependency to another entity which represents the PRINCIPAL.
    /// In addition to that, this specific overload will also define details for reversed view from for the remote entity -> this should only be done, if it is not possible to specify attributes on the remote entity (preferred way)
    /// </summary>
    /// <param name="localNavigationName">can be just defined here, or in combination with an identically named navigation-property qualified by a PrincipalAttribute </param>
    /// <param name="localFkPropertyGroupName">name of a local defined PropertyGroup which will be used as 'Foreigen-Key'</param>
    /// <param name="navigationNameOnPrincipal">should be defined to qualify each direction of the association (also, if there is no navigation-property)</param>
    /// <param name="principalTypeName"></param>
    /// <param name="keyPropertyGroupNameOnPrincipal">name of a PropertyGroup defined on the target entity, which will be used as 'Primary-Key' (if not sepecified, then the PrimaryIdentityAttribute will used to identify the primary PropertyGroup name)</param>
    public HasPrincipalAttribute(string localNavigationName, string localFkPropertyGroupName, string navigationNameOnPrincipal, string keyPropertyGroupNameOnPrincipal = null, string principalTypeName = null) {
      this.LocalNavigationName = localNavigationName;
      this.LocalFkPropertyGroupName = localFkPropertyGroupName;
      this.NavigationNameOnPrincipal = navigationNameOnPrincipal;
      this.KeyPropertyGroupNameOnPrincipal = keyPropertyGroupNameOnPrincipal;
      this.PrincipalTypeName = principalTypeName;
    }

    /// <summary>
    /// Defines, that this entity has an OUTBOUND dependency to another entity which represents the PRINCIPAL.
    /// In addition to that, this specific overload will also define details for reversed view from for the remote entity -> this should only be done, if it is not possible to specify attributes on the remote entity (preferred way)
    /// </summary>
    /// <param name="localNavigationName">can be just defined here, or in combination with an identically named navigation-property qualified by a PrincipalAttribute </param>
    /// <param name="localFkPropertyGroupName">name of a local defined PropertyGroup which will be used as 'Foreigen-Key'</param>
    /// <param name="navigationNameOnPrincipal">should be defined to qualify each direction of the association (also, if there is no navigation-property)</param>
    /// <param name="keyPropertyNamesOnPrincipal">name of a PropertyGroup defined on the target entity, which will be used as 'Primary-Key' (if not sepecified, then the PrimaryIdentityAttribute will used to identify the primary PropertyGroup name)</param>
    public HasPrincipalAttribute(string localNavigationName, string localFkPropertyGroupName, string navigationNameOnPrincipal, string[] keyPropertyNamesOnPrincipal) {
      this.LocalNavigationName = localNavigationName;
      this.LocalFkPropertyGroupName = localFkPropertyGroupName;
      this.NavigationNameOnPrincipal = navigationNameOnPrincipal;
      this.KeyPropertyNamesOnPrincipal = keyPropertyNamesOnPrincipal;
    }

    /// <summary>
    /// can be just defined here, or in combination with an identically named navigation-property qualified by a PrincipalAttribute
    /// </summary>
    public string LocalNavigationName { get; }

    /// <summary>
    /// name of a local defined PropertyGroup which will be used as 'Foreigen-Key'
    /// </summary>
    public string LocalFkPropertyGroupName { get; }

    /// <summary>
    /// should be defined to qualify each direction of the association (also, if there is no navigation-property)
    /// </summary>
    public string NavigationNameOnPrincipal { get; }

    /// <summary>
    /// name of the type of the principal
    /// </summary>
    public string PrincipalTypeName { get; }

    /// <summary>
    /// name of a PropertyGroup defined on the target entity, which will be used as 'Primary-Key' (if not sepecified, then the PrimaryIdentityAttribute will used to identify the primary PropertyGroup name)
    /// </summary>
    public string KeyPropertyGroupNameOnPrincipal { get; }

    /// <summary>
    /// name of a PropertyGroup defined on the target entity, which will be used as 'Primary-Key' (if not sepecified, then the PrimaryIdentityAttribute will used to identify the primary PropertyGroup name)
    /// </summary>
    public string[] KeyPropertyNamesOnPrincipal { get; }

  }

}
