Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click
        Dim year As Integer = 2014
        Dim population As Double = 7000

        Do While (population >= 6)
            year = year - 50
            population = population / 2


        Loop

        MessageBox.Show("The year is " & year)

    End Sub
End Class
