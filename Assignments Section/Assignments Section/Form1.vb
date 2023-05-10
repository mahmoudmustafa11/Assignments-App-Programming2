Public Class Form1

    'Replace-UBound-to-Length
    Sub replaceUBoundToLength(name As String, ParamArray intscores() As Object)
        Dim output As String = ""

        output = name & "  " & "Scores"

        For i = 0 To intscores.Length - 1
            output += "  " & intscores(i)
        Next i

        MsgBox(output, , "Replace UBound To Length")
    End Sub

    'Print the number each time
    Function PrintNumberEachTime() As Integer
        Do While True
            Dim x As Integer
            x = x + 1
            If x >= 5 Then
                Exit Do
            End If
            PrintNumberEachTime = x
            MsgBox(PrintNumberEachTime, , "Print Number Each Time")
        Loop
    End Function

    Private Sub btn_TNumEachTime_Click(sender As Object, e As EventArgs) Handles btn_TNumEachTime.Click
        MsgBox("How are you", , "Print Number Each Time")
        PrintNumberEachTime()
    End Sub

    Private Sub btn_TReplaceUboundToLength_Click(sender As Object, e As EventArgs) Handles btn_TReplaceUboundToLength.Click
        replaceUBoundToLength("Mahmoud", 22, 10, 14, 74)
    End Sub

    Private Sub btn_showFormVerb_Click(sender As Object, e As EventArgs) Handles btn_showFormVerb.Click
        Form_verb.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        projCH3_form1.Show()
    End Sub

    Private Sub btn_subtrack_Click(sender As Object, e As EventArgs) Handles btn_subtrack.Click
        subtrack_multiple("-")
    End Sub

    Private Sub btn_multiple_Click(sender As Object, e As EventArgs) Handles btn_multiple.Click
        subtrack_multiple("*")
    End Sub

    Private Sub btn_multiDimentions_Click(sender As Object, e As EventArgs) Handles btn_multiDimentions.Click
        'ThreeDimensionalArrayExample(Two-Layer, Two-Rows, Two-Columns)
        Dim ThreeDimensionalArray(1, 1, 1) As Integer
        Dim resultThree As String
        ThreeDimensionalArray(0, 0, 0) = 1
        ThreeDimensionalArray(0, 0, 1) = 2
        ThreeDimensionalArray(0, 1, 0) = 3
        ThreeDimensionalArray(0, 1, 1) = 4
        ThreeDimensionalArray(1, 0, 0) = 5
        ThreeDimensionalArray(1, 0, 1) = 6
        ThreeDimensionalArray(1, 1, 0) = 7
        ThreeDimensionalArray(1, 1, 1) = 8
        resultThree = ThreeDimensionalArray(0, 0, 0).ToString() + vbTab + ThreeDimensionalArray(0, 1, 1).ToString() + vbTab + ThreeDimensionalArray(1, 0, 1).ToString()
        MsgBox(resultThree, , "ThreeDimensionalArray")

        'FourDimensionalArrayExample(Two-Layer, Two-Rows, Two-Columns, Two-Elements)
        Dim FourDimensionalArray(1, 1, 1, 1) As Integer
        Dim resultFour As String
        FourDimensionalArray(0, 0, 0, 0) = 9
        FourDimensionalArray(0, 0, 0, 1) = 10
        FourDimensionalArray(0, 0, 1, 0) = 11
        FourDimensionalArray(0, 0, 1, 1) = 12
        FourDimensionalArray(0, 1, 0, 0) = 13
        FourDimensionalArray(0, 1, 0, 1) = 14
        FourDimensionalArray(0, 1, 1, 0) = 15
        FourDimensionalArray(0, 1, 1, 1) = 16
        FourDimensionalArray(1, 0, 0, 0) = 17
        FourDimensionalArray(1, 0, 0, 1) = 18
        FourDimensionalArray(1, 0, 1, 0) = 19
        FourDimensionalArray(1, 0, 1, 1) = 20
        FourDimensionalArray(1, 1, 0, 0) = 21
        FourDimensionalArray(1, 1, 1, 0) = 22
        FourDimensionalArray(1, 1, 1, 1) = 23
        resultFour = FourDimensionalArray(0, 0, 0, 0).ToString() + vbTab + FourDimensionalArray(0, 1, 1, 0).ToString() + vbTab + FourDimensionalArray(1, 0, 1, 0).ToString() + vbTab + FourDimensionalArray(1, 0, 1, 1).ToString()
        MsgBox(resultFour, , "FourDimensionalArray")
    End Sub

    Private Sub btn_sortDescending_Click(sender As Object, e As EventArgs) Handles btn_sortDescending.Click
        'Sort array descending 1
        Dim i As Integer, outputB As String = "", outputA As String = ""
        Dim st_mark(4) As Integer
        st_mark(0) = 86
        st_mark(1) = 90
        st_mark(2) = 66
        st_mark(3) = 96
        st_mark(4) = 76
        For a = 0 To st_mark.Length - 1
            outputB = outputB + st_mark(a).ToString() + vbCrLf
        Next
        Array.Sort(st_mark)
        Array.Reverse(st_mark)
        For i = 0 To st_mark.Length - 1
            outputA = outputA + st_mark(i).ToString() + vbCrLf
        Next

        Dim txtOutput As String
        txtOutput = "Array Before Sort Descending" + vbCrLf + outputB + vbCrLf + vbCrLf + "Array Before Sort Descending" + vbCrLf + outputA
        MsgBox(txtOutput, , "Sort array descending 1")


        'Sort array descending 2
        Dim j As Integer, resultB As String = "", resultA As String = ""
        Dim st_Name(4) As String
        st_Name(0) = "محمد"
        st_Name(1) = "نورين"
        st_Name(2) = "فرح"
        st_Name(3) = "نوران"
        st_Name(4) = "عبدالرحمن"
        For b = 0 To st_Name.Length - 1
            resultB = resultB + st_Name(b).ToString() + vbCrLf
        Next
        Array.Sort(st_Name)
        Array.Reverse(st_Name)
        For j = 0 To st_Name.Length - 1
            resultA = resultA + st_Name(j).ToString() + vbCrLf
        Next

        Dim txtResult As String
        txtResult = "Array Before Sort Descending" + vbCrLf + resultB + vbCrLf + vbCrLf + "Array Before Sort Descending" + vbCrLf + resultA
        MsgBox(txtResult, , "Sort array descending 2")
    End Sub

    Private Sub btn_ImgIndex__ImgKey_Click(sender As Object, e As EventArgs) Handles btn_ImgIndex__ImgKey.Click
        Form2.PictureBox1.Image = Image.FromFile("Deference between Image-index And Image-key.PNG")
        Form2.Show()
    End Sub

    Private Sub btn_ProjectNotebad_Click(sender As Object, e As EventArgs) Handles btn_ProjectNotebad.Click
        project_notebad.Show()
    End Sub
End Class
