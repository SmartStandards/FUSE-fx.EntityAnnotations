Imports System
Imports System.ComponentModel
Imports System.Linq
Imports System.Runtime.CompilerServices

Public Module EntityAnnotationExtensions

  <Extension(), EditorBrowsable(EditorBrowsableState.Always)>
  Public Function GetEntityName(extendee As Type) As String
    Return GetEntityName(extendee, extendee.Name)
  End Function

  Public Function GetEntityName(extendee As Type, defaultName As String) As String
    Dim a = extendee.GetCustomAttributes(False).OfType(Of EntityNameAttribute).FirstOrDefault()
    If (a IsNot Nothing) Then
      Return a.EntityNameSingular
    End If
    If (extendee.BaseType IsNot Nothing) Then
      Return GetEntityName(extendee.BaseType, defaultName)
    Else
      Return defaultName
    End If
  End Function

End Module
