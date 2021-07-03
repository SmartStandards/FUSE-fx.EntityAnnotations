using System;

namespace System.ComponentModel.DataAnnotations {

  /// <summary>
  /// qualifies a Navigation-Property
  /// (this should be used in combination with the HasDependentAttribute on the current entity-type which declares the details of the association) 
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
  public class DependentAttribute : Attribute {

    /// <summary>
    /// qualifies a Navigation-Property
    /// (this should be used in combination with the HasDependentAttribute on the current entity-type which declares the details of the association) 
    /// </summary>
    public DependentAttribute() {
    }

  }

  /// <summary>
  /// Defines, that this entity has an INBOUND dependency by a associated entity for which the current entity is the PRINCIPAL.
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
  public class HasDependentAttribute : Attribute {

    /// <summary>
    /// Defines, that this entity has an INBOUND dependency by a associated entity for which the current entity is the PRINCIPAL.
    /// In addition to that, this specific overload will also define details for reversed view from for the remote entity -> this should only be done, if it is not possible to specify attributes on the remote entity (preferred way)
    /// </summary>
    /// <param name="localNavigationName">can be just defined here, or in combination with an identically named navigation-property qualified by a DependentAttribute </param>
    /// <param name="localKeyPropertyGroupName">name of a PropertyGroup defined on the local entity, which will be used as 'Primary-Key' (if not sepecified, then the PrimaryIdentityAttribute will used to identify the primary PropertyGroup name)</param>
    public HasDependentAttribute(string localNavigationName, string localKeyPropertyGroupName = null) {
      this.LocalNavigationName = localNavigationName;
      this.LocalKeyPropertyGroupName = localKeyPropertyGroupName;
    }

    /// <summary>
    /// Defines, that this entity has an INBOUND dependency by a associated entity for which the current entity is the PRINCIPAL.
    /// In addition to that, this specific overload will also define details for reversed view from for the remote entity -> this should only be done, if it is not possible to specify attributes on the remote entity (preferred way)
    /// </summary>
    /// <param name="localNavigationName">can be just defined here, or in combination with an identically named navigation-property qualified by a DependentAttribute </param>
    /// <param name="fkPropertyGroupNameOnDependent">name of a PropertyGroup defined on the Dependent entity which will be used as 'Foreigen-Key'</param>
    /// <param name="navigationNameOnDependent">should be defined to qualify each direction of the association (also, if there is no navigation-property)</param>
    /// <param name="localKeyPropertyGroupName">name of a PropertyGroup defined on the local entity, which will be used as 'Primary-Key' (if not sepecified, then the PrimaryIdentityAttribute will used to identify the primary PropertyGroup name)</param>
    public HasDependentAttribute(string localNavigationName, string fkPropertyGroupNameOnDependent, string navigationNameOnDependent, string localKeyPropertyGroupName = null) {
      this.LocalNavigationName = localNavigationName;
      this.FkPropertyGroupNameOnDependent = fkPropertyGroupNameOnDependent;
      this.NavigationNameOnDependent = navigationNameOnDependent;
      this.LocalKeyPropertyGroupName = localKeyPropertyGroupName;
    }

    /// <summary>
    /// Defines, that this entity has an INBOUND dependency by a associated entity for which the current entity is the PRINCIPAL.
    /// In addition to that, this specific overload will also define details for reversed view from for the remote entity -> this should only be done, if it is not possible to specify attributes on the remote entity (preferred way)
    /// </summary>
    /// <param name="localNavigationName">can be just defined here, or in combination with an identically named navigation-property qualified by a DependentAttribute </param>
    /// <param name="fkPropertyNamesOnDependent">One ore more Property names on the Dependent entity which will be used as 'Foreigen-Key'</param>
    /// <param name="navigationNameOnDependent">should be defined to qualify each direction of the association (also, if there is no navigation-property)</param>
    /// <param name="localKeyPropertyGroupName">name of a PropertyGroup defined on the local entity, which will be used as 'Primary-Key' (if not sepecified, then the PrimaryIdentityAttribute will used to identify the primary PropertyGroup name)</param>
    public HasDependentAttribute(string localNavigationName, string[] fkPropertyNamesOnDependent, string navigationNameOnDependent, string localKeyPropertyGroupName = null) {
      this.LocalNavigationName = localNavigationName;
      this.FkPropertyNamesOnDependent = fkPropertyNamesOnDependent;
      this.NavigationNameOnDependent = navigationNameOnDependent;
      this.LocalKeyPropertyGroupName = localKeyPropertyGroupName;
    }

    /// <summary>
    /// can be just defined here, or in combination with an identically named navigation-property qualified by a DependentAttribute
    /// </summary>
    public string LocalNavigationName { get; }

    /// <summary>
    /// name of a PropertyGroup defined on the Dependent entity which will be used as 'Foreigen-Key'
    /// </summary>
    public string FkPropertyGroupNameOnDependent { get; }

    /// <summary>
    /// One ore more Property names on the Dependent entity which will be used as 'Foreigen-Key'
    /// </summary>
    public string[] FkPropertyNamesOnDependent { get; }

    /// <summary>
    /// should be defined to qualify each direction of the association (also, if there is no navigation-property)
    /// </summary>
    public string NavigationNameOnDependent { get; }

    /// <summary>
    /// name of a PropertyGroup defined on the local entity, which will be used as 'Primary-Key' (if not sepecified, then the PrimaryIdentityAttribute will used to identify the primary PropertyGroup name)
    /// </summary>
    public string LocalKeyPropertyGroupName { get; }

  }

}
