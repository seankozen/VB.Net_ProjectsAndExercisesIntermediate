Imports System.IO
Imports System.Net.Security

Public Class TrainingWSApp

    Private ReadOnly filePath = "..\..\workshops.txt"
    Private allWorkshops() As Workshop


    Private Sub TrainingWSApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetFile()
        FillList()


    End Sub

    Private Function GetFile() As Boolean
        Dim inFile As StreamReader = Nothing
        txtResult.Text = String.Empty

        Try
            inFile = File.OpenText(filePath)
            Dim numVals As Integer = File.ReadAllLines(filePath).Length

            ReDim allWorkshops(numVals - 1)

            For i As Integer = 0 To numVals - 1
                Dim line As String = inFile.ReadLine()
                Dim fields() As String = line.Split("\"c)
                Dim wShop As New Workshop With {
                    .Category = CType(fields(0), Workshop.CategoryType),
                    .NumDays = CInt(fields(1)),
                    .Cost = CDbl(fields(2)),
                    .Title = fields(3)
                }
                allWorkshops(i) = wShop
            Next
            txtResult.Text = "Workshop successfully loaded!"
            Return True
        Catch ex As Exception
            txtResult.Text = ex.Message
            Return False
        Finally
            If inFile IsNot Nothing Then inFile.Close()
        End Try


    End Function

    Private Sub FillList()
        lstWorkshops.Items.Clear()
        For Each ws As Workshop In allWorkshops
            lstWorkshops.Items.Add(ws)
        Next

    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        Dim index As Integer = lstWorkshops.SelectedIndex
        If index = -1 Then
            txtResult.Text = "Please select a workshop!"
            Return
        Else
            txtResult.Text = String.Empty
        End If

        Dim frm As New frmDetailsForm
        frm.SingleWorkshop = allWorkshops(index)
        frm.ShowDialog()
        FillList()
    End Sub
End Class
