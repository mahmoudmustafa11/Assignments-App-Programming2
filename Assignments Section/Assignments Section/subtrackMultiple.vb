Module subtrackMultiple

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

End Module
