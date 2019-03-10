Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Runtime.CompilerServices

<AttributeUsage(AttributeTargets.Class, AllowMultiple:=False, Inherited:=True)>
<DebuggerDisplay("{EntityNameSingular}")>
Public Class EntityNameAttribute
  Inherits Attribute

  Public Sub New(entityNameSingular As String, entityNamePlural As String)
    Me.EntityNameSingular = entityNameSingular
    Me.EntityNamePlural = entityNamePlural
  End Sub

  Public ReadOnly Property EntityNameSingular As String
  Public ReadOnly Property EntityNamePlural As String

End Class

<AttributeUsage(AttributeTargets.Class, AllowMultiple:=True, Inherited:=True)>
<DebuggerDisplay("{KeysetName}")>
Public Class HasKeysetAttribute
  Inherits Attribute

  ''' <summary>
  ''' Defines a 'PRIMARY' keyset!
  ''' </summary>
  ''' <param name="fieldName1"></param>
  ''' <param name="fieldNamesN"></param>
  Public Sub New(fieldName1 As String, ParamArray fieldNamesN() As String)
    MyClass.New("PRIMARY", True, fieldName1, fieldNamesN)
  End Sub

  Public Sub New(keysetName As String, isUnique As Boolean, fieldName1 As String, ParamArray fieldNamesN() As String)
    Dim all As New List(Of String)
    all.Add(fieldName1)
    If (fieldNamesN IsNot Nothing) Then
      For Each fieldName In fieldNamesN
        all.Add(fieldName)
      Next
    End If

    Me.KeysetName = keysetName
    Me.IsUnique = isUnique
    Me.FieldNames = all.ToArray()
  End Sub

  Public ReadOnly Property KeysetName As String
  Public ReadOnly Property IsUnique As Boolean
  Public ReadOnly Property FieldNames As String()

End Class

''' <summary>
''' declaration of a outbound principal-relation
''' </summary>
<AttributeUsage(AttributeTargets.Class, AllowMultiple:=True, Inherited:=True)>
<DebuggerDisplay("{RelationName}")>
Public Class HasPrincipalAttribute
  Inherits Attribute

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="keysetNameOnDependent">Name of a keyset (foreign) on this entity. Use the <seealso cref="HasKeysetAttribute"/> to specify a keyset.</param>
  ''' <param name="relationName">Should be a name which descibes the 'ROLE' of a relation between two entities</param>
  ''' <param name="principalRequired">defines the multiplicity of the principal as 0/1 (extreemly seldom usecase)</param>
  ''' <param name="keysetNameOnPrincipal">Name of a keyset (UNIQUE!) on the dependent entity. Use the <seealso cref="HasKeysetAttribute"/> to specify a keyset.</param>
  Public Sub New(
    relationName As String,
    principalEntityType As Type,
    keysetNameOnDependent As String,
    Optional principalRequired As Boolean = True,
    Optional canHaveMultipleDependents As Boolean = True,
    Optional dependentRequired As Boolean = False,
    Optional keysetNameOnPrincipal As String = "PRIMARY"
  )
    Me.RelationName = relationName
    Me.PrincipalEntityName = principalEntityType.GetEntityName()
    Me.KeysetNameOnPrincipal = keysetNameOnPrincipal
    Me.KeysetNameOnDependent = keysetNameOnDependent
    Me.PrincipalRequired = principalRequired
    Me.DependentRequired = dependentRequired
    Me.CanHaveMultipleDependents = canHaveMultipleDependents
  End Sub

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="principalEntityName"></param>
  ''' <param name="keysetNameOnDependent">Name of a keyset (foreign) on this entity. Use the <seealso cref="HasKeysetAttribute"/> to specify a keyset.</param>
  ''' <param name="relationName">Should be a name which descibes the 'ROLE' of a relation between two entities</param>
  ''' <param name="principalRequired">defines the multiplicity of the principal as 0/1 (extreemly seldom usecase)</param>
  ''' <param name="keysetNameOnPrincipal">Name of a keyset (UNIQUE!) on the dependent entity. Use the <seealso cref="HasKeysetAttribute"/> to specify a keyset.</param>
  Public Sub New(
    relationName As String,
    principalEntityName As String,
    keysetNameOnDependent As String,
    Optional principalRequired As Boolean = True,
    Optional canHaveMultipleDependents As Boolean = True,
    Optional dependentRequired As Boolean = False,
    Optional keysetNameOnPrincipal As String = "PRIMARY"
  )
    Me.RelationName = relationName
    Me.PrincipalEntityName = principalEntityName
    Me.KeysetNameOnPrincipal = keysetNameOnPrincipal
    Me.KeysetNameOnDependent = keysetNameOnDependent
    Me.PrincipalRequired = principalRequired
    Me.DependentRequired = dependentRequired
    Me.CanHaveMultipleDependents = canHaveMultipleDependents
  End Sub

  Public ReadOnly Property RelationName As String
  Public ReadOnly Property PrincipalEntityName As String

  Public ReadOnly Property KeysetNameOnPrincipal As String
  Public ReadOnly Property KeysetNameOnDependent As String

  ''' <summary> defines the multiplicity of the principal (1 OR 0/1)</summary>
  Public ReadOnly Property PrincipalRequired As Boolean

  ''' <summary> defines the multiplicity of the dependents</summary>
  Public ReadOnly Property DependentRequired As Boolean

  ''' <summary> defines the multiplicity of the dependents</summary>
  Public ReadOnly Property CanHaveMultipleDependents As Boolean


End Class

''' <summary>
''' declaration of a outbound lookup-relation
''' </summary>
<AttributeUsage(AttributeTargets.Class, AllowMultiple:=True, Inherited:=True)>
<DebuggerDisplay("{RelationName}")>
Public Class HasLookupAttribute
  Inherits Attribute

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="keysetNameOnReferer">Name of a keyset (foreign) on this entity. Use the <seealso cref="HasKeysetAttribute"/> to specify a keyset.</param>
  ''' <param name="relationName">Should be a name which descibes the 'ROLE' of a relation between two entities</param>
  ''' <param name="lookupRequired">defines the multiplicity of the lookup as 0/1</param>
  ''' <param name="keysetNameOnLookup">Name of a keyset (UNIQUE!) on the dependent entity. Use the <seealso cref="HasKeysetAttribute"/> to specify a keyset.</param>
  Public Sub New(
    relationName As String,
    lookupEntityType As Type,
    keysetNameOnReferer As String,
    Optional lookupRequired As Boolean = True,
    Optional canHaveMultipleReferers As Boolean = True,
    Optional refererRequired As Boolean = False,
    Optional keysetNameOnLookup As String = "PRIMARY"
  )

    Me.RelationName = relationName
    Me.LookupEntityName = lookupEntityType.GetEntityName()
    Me.KeysetNameOnLookup = keysetNameOnLookup
    Me.KeysetNameOnReferer = keysetNameOnReferer
    Me.LookupRequired = lookupRequired
    Me.RefererRequired = refererRequired
    Me.CanHaveMultipleReferers = canHaveMultipleReferers

  End Sub

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="lookupEntityName"></param>
  ''' <param name="keysetNameOnReferer">Name of a keyset (foreign) on this entity. Use the <seealso cref="HasKeysetAttribute"/> to specify a keyset.</param>
  ''' <param name="relationName">Should be a name which descibes the 'ROLE' of a relation between two entities</param>
  ''' <param name="lookupRequired">defines the multiplicity of the lookup as 0/1</param>
  ''' <param name="keysetNameOnLookup">Name of a keyset (UNIQUE!) on the dependent entity. Use the <seealso cref="HasKeysetAttribute"/> to specify a keyset.</param>
  Public Sub New(
    relationName As String,
    lookupEntityName As String,
    keysetNameOnReferer As String,
    Optional lookupRequired As Boolean = True,
    Optional canHaveMultipleReferers As Boolean = True,
    Optional refererRequired As Boolean = False,
    Optional keysetNameOnLookup As String = "PRIMARY"
  )

    Me.RelationName = relationName
    Me.LookupEntityName = lookupEntityName
    Me.KeysetNameOnLookup = keysetNameOnLookup
    Me.KeysetNameOnReferer = keysetNameOnReferer
    Me.LookupRequired = lookupRequired
    Me.RefererRequired = refererRequired
    Me.CanHaveMultipleReferers = canHaveMultipleReferers

  End Sub

  Public ReadOnly Property RelationName As String
  Public ReadOnly Property LookupEntityName As String

  Public ReadOnly Property KeysetNameOnLookup As String
  Public ReadOnly Property KeysetNameOnReferer As String

  ''' <summary> defines the multiplicity of the lookup (1 OR 0/1)</summary>
  Public ReadOnly Property LookupRequired As Boolean

  ''' <summary> defines the multiplicity of the referers</summary>
  Public ReadOnly Property RefererRequired As Boolean

  ''' <summary> defines the multiplicity of the referers</summary>
  Public ReadOnly Property CanHaveMultipleReferers As Boolean


End Class

''' <summary>
''' REVERSED DECLARATION of a inbound principal-relation
''' </summary>
<AttributeUsage(AttributeTargets.Class, AllowMultiple:=True, Inherited:=True)>
<DebuggerDisplay("{RelationName}")>
Public Class HasDependentAttribute
  Inherits Attribute

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="keysetNameOnDependent">Name of a keyset (foreign) on the dependent entity. Use the <seealso cref="HasKeysetAttribute"/> to specify a keyset.</param>
  ''' <param name="relationName">Should be a name which descibes the 'ROLE' of a relation between two entities</param>
  ''' <param name="principalRequired">defines the multiplicity of the principal as 0/1 (extreemly seldom usecase)</param>
  ''' <param name="keysetNameOnPrincipal">Name of a keyset (UNIQUE!) on this entity. Use the <seealso cref="HasKeysetAttribute"/> to specify a keyset.</param>
  Public Sub New(
    relationName As String,
    dependentEntityType As Type,
    keysetNameOnDependent As String,
    Optional principalRequired As Boolean = True,
    Optional canHaveMultipleDependents As Boolean = True,
    Optional dependentRequired As Boolean = False,
    Optional keysetNameOnPrincipal As String = "PRIMARY"
  )

    Me.RelationName = relationName
    Me.DependentEntityName = dependentEntityType.GetEntityName()
    Me.KeysetNameOnPrincipal = keysetNameOnPrincipal
    Me.KeysetNameOnDependent = keysetNameOnDependent
    Me.PrincipalRequired = principalRequired
    Me.DependentRequired = dependentRequired
    Me.CanHaveMultipleDependents = canHaveMultipleDependents

  End Sub

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="dependentEntityName"></param>
  ''' <param name="keysetNameOnDependent">Name of a keyset (foreign) on the dependent entity. Use the <seealso cref="HasKeysetAttribute"/> to specify a keyset.</param>
  ''' <param name="relationName">Should be a name which descibes the 'ROLE' of a relation between two entities</param>
  ''' <param name="principalRequired">defines the multiplicity of the principal as 0/1 (extreemly seldom usecase)</param>
  ''' <param name="keysetNameOnPrincipal">Name of a keyset (UNIQUE!) on this entity. Use the <seealso cref="HasKeysetAttribute"/> to specify a keyset.</param>
  Public Sub New(
    relationName As String,
    dependentEntityName As String,
    keysetNameOnDependent As String,
    Optional principalRequired As Boolean = True,
    Optional canHaveMultipleDependents As Boolean = True,
    Optional dependentRequired As Boolean = False,
    Optional keysetNameOnPrincipal As String = "PRIMARY"
  )

    Me.RelationName = relationName
    Me.DependentEntityName = dependentEntityName
    Me.KeysetNameOnPrincipal = keysetNameOnPrincipal
    Me.KeysetNameOnDependent = keysetNameOnDependent
    Me.PrincipalRequired = principalRequired
    Me.DependentRequired = dependentRequired
    Me.CanHaveMultipleDependents = canHaveMultipleDependents

  End Sub

  Public ReadOnly Property RelationName As String
  Public ReadOnly Property DependentEntityName As String

  Public ReadOnly Property KeysetNameOnPrincipal As String
  Public ReadOnly Property KeysetNameOnDependent As String

  ''' <summary> defines the multiplicity of the principal (1 OR 0/1)</summary>
  Public ReadOnly Property PrincipalRequired As Boolean

  ''' <summary> defines the multiplicity of the dependents</summary>
  Public ReadOnly Property DependentRequired As Boolean

  ''' <summary> defines the multiplicity of the dependents</summary>
  Public ReadOnly Property CanHaveMultipleDependents As Boolean

End Class

''' <summary>
''' REVERSED DECLARATION of a inbound lookup-relation
''' </summary>
<AttributeUsage(AttributeTargets.Class, AllowMultiple:=True, Inherited:=True)>
<DebuggerDisplay("{RelationName}")>
Public Class HasRefererAttribute
  Inherits Attribute

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="keysetNameOnReferer">Name of a keyset (foreign) on the dependent entity. Use the <seealso cref="HasKeysetAttribute"/> to specify a keyset.</param>
  ''' <param name="relationName">Should be a name which descibes the 'ROLE' of a relation between two entities</param>
  ''' <param name="lookupRequired">defines the multiplicity of the lookup as 0/1</param>
  ''' <param name="keysetNameOnLookup">Name of a keyset (UNIQUE!) on this entity. Use the <seealso cref="HasKeysetAttribute"/> to specify a keyset.</param>
  Public Sub New(
    relationName As String,
    refererEntityType As Type,
    keysetNameOnReferer As String,
    Optional lookupRequired As Boolean = True,
    Optional canHaveMultipleReferers As Boolean = True,
    Optional refererRequired As Boolean = False,
    Optional keysetNameOnLookup As String = "PRIMARY"
  )

    Me.RelationName = relationName
    Me.RefererEntityName = refererEntityType.GetEntityName()
    Me.KeysetNameOnLookup = keysetNameOnLookup
    Me.KeysetNameOnReferer = keysetNameOnReferer
    Me.LookupRequired = lookupRequired
    Me.RefererRequired = refererRequired
    Me.CanHaveMultipleReferers = canHaveMultipleReferers

  End Sub

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="refererEntityName"></param>
  ''' <param name="keysetNameOnReferer">Name of a keyset (foreign) on the dependent entity. Use the <seealso cref="HasKeysetAttribute"/> to specify a keyset.</param>
  ''' <param name="relationName">Should be a name which descibes the 'ROLE' of a relation between two entities</param>
  ''' <param name="lookupRequired">defines the multiplicity of the lookup as 0/1</param>
  ''' <param name="keysetNameOnLookup">Name of a keyset (UNIQUE!) on this entity. Use the <seealso cref="HasKeysetAttribute"/> to specify a keyset.</param>
  Public Sub New(
    relationName As String,
    refererEntityName As String,
    keysetNameOnReferer As String,
    Optional lookupRequired As Boolean = True,
    Optional canHaveMultipleReferers As Boolean = True,
    Optional refererRequired As Boolean = False,
    Optional keysetNameOnLookup As String = "PRIMARY"
  )

    Me.RelationName = relationName
    Me.RefererEntityName = refererEntityName
    Me.KeysetNameOnLookup = keysetNameOnLookup
    Me.KeysetNameOnReferer = keysetNameOnReferer
    Me.LookupRequired = lookupRequired
    Me.RefererRequired = refererRequired
    Me.CanHaveMultipleReferers = canHaveMultipleReferers

  End Sub

  Public ReadOnly Property RelationName As String
  Public ReadOnly Property RefererEntityName As String

  Public ReadOnly Property KeysetNameOnLookup As String
  Public ReadOnly Property KeysetNameOnReferer As String

  ''' <summary> defines the multiplicity of the lookup (1 OR 0/1)</summary>
  Public ReadOnly Property LookupRequired As Boolean

  ''' <summary> defines the multiplicity of the referers</summary>
  Public ReadOnly Property RefererRequired As Boolean

  ''' <summary> defines the multiplicity of the referers</summary>
  Public ReadOnly Property CanHaveMultipleReferers As Boolean

End Class


''' <summary>
''' navigates to the primary Entity (Principal or Lookup) which is pointed by a local defined foreign keyset
''' </summary>
<AttributeUsage(AttributeTargets.Property Or AttributeTargets.Method, AllowMultiple:=False, Inherited:=True)>
<DebuggerDisplay("{OutboundRelationName}")>
Public Class NavigationAttribute
  Inherits Attribute

  Public Sub New(outboundRelationName As String)
    Me.OutboundRelationName = outboundRelationName
  End Sub

  Public ReadOnly Property OutboundRelationName As String

End Class

''' <summary>
''' navigates to the foreign Entity or entities (Dependent or Referer) which is/are pointing to a local defined keyset
''' </summary>
<AttributeUsage(AttributeTargets.Property Or AttributeTargets.Method, AllowMultiple:=True, Inherited:=True)>
<DebuggerDisplay("{InboundRelationName}")>
Public Class ReverseNavigationAttribute
  Inherits Attribute

  Public Sub New(inboundRelationName As String)
    Me.InboundRelationName = inboundRelationName
  End Sub

  Public ReadOnly Property InboundRelationName As String

End Class

''' <summary>
''' supports the specifiation of XOR-Relations (see 'http://www.refurbished-modeling-language.org')
''' </summary>
<AttributeUsage(AttributeTargets.Class, AllowMultiple:=True, Inherited:=True)>
Public Class XorRelationConstraintAttribute
  Inherits Attribute

  Public Sub New(relationName1 As String, relationName2 As String, ParamArray relationNamesN() As String)
    Dim all As New List(Of String)
    all.Add(relationName1)
    all.Add(relationName2)
    If (relationNamesN IsNot Nothing) Then
      For Each relationName In relationNamesN
        all.Add(relationName)
      Next
    End If
    Me.RelationNames = all.ToArray()
  End Sub

  Public ReadOnly Property RelationNames As String()

End Class

<AttributeUsage(AttributeTargets.Class, AllowMultiple:=False, Inherited:=True)>
<DebuggerDisplay("{KeysetName}")>
Public Class EntityStock
  Inherits Attribute

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="stockOrHierarchyName">Should be the PLURAL of the entity name</param>
  Public Sub New(stockOrHierarchyName As String, primaryKeysetName As String)
    Me.HierarchyName = stockOrHierarchyName
  End Sub

  Public ReadOnly Property HierarchyName As String

End Class
