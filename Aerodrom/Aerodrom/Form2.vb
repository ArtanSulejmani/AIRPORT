Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Aerodrom
    Public Class Form2
        Public Property Name As String
        Public Property Distance As Integer
        Public Property Price As Integer

        Public Sub New(ByVal name As String, ByVal distance As Integer, ByVal price As Integer)
            name = name
            distance = distance
            price = price
        End Sub

        Public Overrides Function ToString() As String
            Return String.Format("{0}" & vbTab & "{1} km - {2} EUR", Name, Distance, Price)
        End Function
    End Class
End Namespace
