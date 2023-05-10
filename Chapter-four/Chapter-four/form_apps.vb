Public Class form_apps
    Structure student
        Dim name As String
        Dim level As String
        Dim Cavg As Double
    End Structure

    Private Sub btn_studentsGrades_Click(sender As Object, e As EventArgs) Handles btn_studentsGrades.Click
        Dim persons(9) As student
        Dim output As String = ""

        Try
            'Loop to input student data
            For i = 0 To UBound(persons)
                persons(i).name = InputBox("Enter Name: ", "Students Grades")
                persons(i).level = InputBox("Enter Level: ", "Students Grades")
                persons(i).Cavg = InputBox("Enter Cumulative average: ", "Students Grades")
            Next

            output = output + "Name" + vbTab + "Level" + vbTab + "CumulativeAverage" + vbCrLf

            'Loop for print student data with Cumulative average higher than 3.5
            For j = 0 To UBound(persons)
                If persons(j).Cavg > 3.5 Then
                    output = output + persons(j).name + vbTab + persons(j).level + vbTab + persons(j).Cavg.ToString()
                End If
            Next

            MsgBox(output, , "Students Grades")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_arrRndEl_Click(sender As Object, e As EventArgs) Handles btn_arrRndEl.Click
        Dim Random_arr(9) As Integer
        Dim result As String = ""

        For i = 0 To UBound(Random_arr)
            Random_arr(i) = Rnd() * 100
            result = result + Random_arr(i).ToString() + vbTab
        Next

        MsgBox(result)
    End Sub

    Private Sub btn_arrTwoDimentions_Click(sender As Object, e As EventArgs) Handles btn_arrTwoDimentions.Click
        Dim arrTwoDimen(7, 7) As Integer
        Dim output As String = ""

        For i = 0 To arrTwoDimen.GetUpperBound(0)
            For j = 0 To arrTwoDimen.GetUpperBound(1)
                arrTwoDimen(i, j) = Rnd() * 100
                output = output + arrTwoDimen(i, j).ToString() + vbTab
            Next
            output = output + vbCrLf
        Next

        MsgBox(output)
    End Sub

    Private Sub btn_arrCopy_Click(sender As Object, e As EventArgs) Handles btn_arrCopy.Click
        Dim arr() As Integer = {6, 8, 9, 11}
        Dim arr_copy() As Integer
        Dim output As String
        arr_copy = arr.Clone()
        output = arr_copy(0).ToString() + vbTab + arr_copy(1).ToString() + vbTab + arr_copy(2).ToString() + vbTab + arr_copy(3).ToString()
        MsgBox(output, , "Array Copy")
    End Sub


    Private Sub btn_arrSort_Click(sender As Object, e As EventArgs) Handles btn_arrSort.Click
        Dim st_arr(9) As Integer, output As String
        output = "Array Before Sorted" + vbCrLf

        For i = 0 To 9
            st_arr(i) = Rnd() * 50
            output = output + st_arr(i).ToString() + vbTab
        Next

        output = output + vbCrLf + vbCrLf + "Array After Sorted" + vbCrLf
        Array.Sort(st_arr)

        For j = 0 To 9
            output = output + st_arr(j).ToString() + vbTab
        Next

        MsgBox(output)
    End Sub
End Class