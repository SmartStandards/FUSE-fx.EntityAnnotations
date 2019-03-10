Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports EntityAnnotations

Module Module1

  Sub Main()

    Dim entityAttribs = GetType(Person).GetCustomAttributes(True).OfType(Of HasKeysetAttribute).ToArray()

  End Sub

End Module

<EntityName("Person", "Persons"), HasKeyset(NameOf(Person.FirstName), NameOf(Person.LastName))>
<HasPrincipal("Mother", GetType(Person), "MotherFK"), HasKeyset("MotherFK", False, NameOf(Person.MothersFirstName), NameOf(Person.MothersLastName))>
<HasPrincipal("Father", GetType(Person), "FatherFK"), HasKeyset("FatherFK", False, NameOf(Person.FathersFirstName), NameOf(Person.FathersLastName))>
Public Class Person

  Public Property FirstName As String
  Public Property LastName As String

  Public Property MothersFirstName As String
  Public Property MothersLastName As String

  Public Property FathersFirstName As String
  Public Property FathersLastName As String

  <Navigation("Mother")>
  Public Property Mother As Person

  <Navigation("Father")>
  Public Property Father As Person

  <ReverseNavigation("Father"), ReverseNavigation("Mother")>
  Public Property Children As IQueryable(Of Person)

End Class
