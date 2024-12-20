﻿Imports System.IO

Public Class frmStudentCourses
    Dim studentList As New List(Of Student)
    Private Sub frmStudentCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not ReadStudentFile("..\..\students.txt") Then
            MessageBox.Show("Cannot read student.txt file.")
            Close()
        End If
        AllStudents()
    End Sub


    Private Sub AllStudents()
        Dim query = From aStudent In studentList
                    Select aStudent
                    Order By aStudent.Id

        dgvStudents.DataSource = query.ToList()
    End Sub

    Private Function ReadStudentFile(fileName As String) As Boolean
        Dim inFile As StreamReader = Nothing
        Try
            inFile = File.OpenText(fileName)
            While Not inFile.EndOfStream
                Dim line As String = inFile.ReadLine()
                Dim fields() As String = line.Split(","c)
                Dim stud As New Student
                With stud
                    .Id = CInt(fields(0))
                    .LastName = fields(1)
                    .Status = CInt(fields(2))
                    .Major = fields(3)

                    line = inFile.ReadLine()
                    fields = line.Split(","c)
                    Dim numberOfCourses As Integer = fields.Length \ 3
                    Dim i As Integer = 0
                    For j As Integer = 0 To numberOfCourses - 1
                        Dim c As New Course(fields(i), CInt(fields(i + 1)), CDbl(fields(i + 2)))
                        i += 3
                        stud.Courses.Add(c)
                    Next

                End With
                studentList.Add(stud)
            End While
            Return True
        Catch ex As Exception
            Return False
        Finally
            If inFile IsNot Nothing Then inFile.Close()
        End Try
        Return False
    End Function

    Private Sub SelectionChange(sender As Object, e As EventArgs) Handles dgvStudents.SelectionChanged
        If dgvStudents.SelectedRows.Count = 0 Then Return
        Dim id As Integer = CInt(dgvStudents.SelectedRows(0).Cells(0).Value)
        Dim courseList = (From aStudent In studentList
                          Where aStudent.Id = id
                          Select aStudent).ElementAt(0).Courses
        dgvCourses.DataSource = courseList.ToList()
    End Sub
End Class
