Public Class form_tasks

    Function subtrack_multiple(op As String) As String
        Dim i, j As Integer, output As String = ""
        Dim A(,) As Integer = {{10, 20, 30}, {40, 50, 60}, {70, 80, 90}}
        Dim B(,) As Integer = {{100, 200, 300}, {400, 500, 600}, {700, 800, 900}}

        Dim LenA As Integer = UBound(A), LenB As Integer = UBound(B)
        Dim C(LenA, LenB) As Integer

        For i = 0 To LenA
            For j = 0 To LenB
                If op = "-" Then
                    C(i, j) = A(i, j) - B(i, j)
                ElseIf op = "*" Then
                    C(i, j) = A(i, j) * B(i, j)
                End If
            Next
        Next
        For i = 0 To LenA
            For j = 0 To LenB
                output = output + (C(i, j)).ToString() + vbTab
            Next

            output = output + vbCrLf
        Next

        If op = "-" Then
            MsgBox(output, , "Subtract two Arrays")
        ElseIf op = "*" Then
            MsgBox(output, , "Multiplecation two Arrays")
        End If

    End Function

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
        Dim i As Integer, output As String = ""
        Dim st_mark(4) As Integer
        st_mark(0) = 86
        st_mark(1) = 90
        st_mark(2) = 66
        st_mark(3) = 96
        st_mark(4) = 76
        Array.Sort(st_mark)
        Array.Reverse(st_mark)
        For i = 0 To st_mark.Length - 1
            output = output + st_mark(i).ToString() + vbCrLf
        Next
        MsgBox(output, , "Sort array descending 1")


        'Sort array descending 2
        Dim j As Integer, result As String = ""
        Dim st_Name(4) As String
        st_Name(0) = "محمد"
        st_Name(1) = "نورين"
        st_Name(2) = "فرح"
        st_Name(3) = "نوران"
        st_Name(4) = "عبدالرحمن"
        Array.Sort(st_Name)
        Array.Reverse(st_Name)
        For j = 0 To st_Name.Length - 1
            result = result + st_Name(j).ToString() + vbCrLf
        Next
        MsgBox(result, , "Sort array descending 2")
    End Sub
End Class