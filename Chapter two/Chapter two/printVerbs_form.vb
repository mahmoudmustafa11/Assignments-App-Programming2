Public Class printVerbs_form

    Private Sub btn_printVerbs_Click(sender As Object, e As EventArgs) Handles btn_printVerbs.Click
        OpenFileDialog1.DefaultExt = "TXT"
        OpenFileDialog1.Filter = "Text|*.TXT|All Files|*.*"
        OpenFileDialog1.FileName = "verbs.txt"
        OpenFileDialog1.ShowDialog()

        Try
            'Array to Split
            Dim Delimiters() As Char = {CType(" ", Char), CType("", Char), CType(".", Char),
                                        CType(".", Char), CType("*", Char), CType("!", Char),
                                        CType(":", Char), CType(":", Char), Chr(10), Chr(13)}
            'Array to Verbs
            Dim verbs() As String = {"be", "have", "do", "say", "go", "get", "make", "know",
                                     "take", "see", "Accept", "Achieve", "Act", "Add", "Analyze", "Apply",
                                     "Argue", "Build", "Buy", "Calculate", "Choose", "Complete", "Consider",
                                     "Create", "Decide", "Define", "Develop", "Discover", "Discuss", "Divide",
                                     "Eat", "Enjoy", "Establish", "Examine", "Explain", "Explore", "Find", "Follow",
                                     "Give", "Go", "Have", "Help", "Identify", "Improve", "Increase", "Invent", "Join",
                                     "Know", "Learn", "Listen", "Make", "Manage", "Measure", "Organize", "Participate",
                                     "Plan", "Read", "Remember", "Speak", "Write"}

            If OpenFileDialog1.FileName = "" Then Exit Sub
            Dim txtLine As String = ""
            Dim Words() As String, counter As Integer
            FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)

            While Not EOF(1)
                Input(1, txtLine)
                Words = txtLine.Split(Delimiters)
                Dim iword, iverb As Integer, word As String
                For iword = 0 To Words.GetUpperBound(0)
                    For iverb = 0 To UBound(verbs)
                        If Words(iword).ToUpper = verbs(iverb).ToUpper Then
                            word = Words(iword)
                            ListBox1.Items.Add(word)
                            counter = counter + 1
                        End If
                    Next
                Next
            End While
            Label1.Text = "Number of verbs = " + counter.ToString() + " verbs"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class