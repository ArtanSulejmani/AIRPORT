Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text


Namespace Aerodrom

    Public Class Form1

        Public Property Name As String
        Public Property City As String
        Public Property Short As String
        Public Destinations As List(Of Destination)



        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
            Form2.Show()


        End Sub

        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
            Form3.Show()
        End Sub

        Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
            Console.WriteLine(Grad, "-", Ime, "-", Kratenka)


        End Sub
    End Class