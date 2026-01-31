Public Class Form1

    Function GetInput(prompt As String, title As String) As String
        Return InputBox(prompt, title)
    End Function

    Shared Function GetScore(prompt As String) As Double
        Dim handleInput As String
        Dim score As Double
        Dim isit60 As Boolean = False

        Do
            handleInput = InputBox(prompt, "Score Entry (60-100)")

            If Double.TryParse(handleInput, score) AndAlso score >= 60 AndAlso score <= 100 Then
                isit60 = True
            Else
                MsgBox("Invalid input! Please enter a score between 60 and 100.", MsgBoxStyle.Exclamation, "Incorrect Input")
            End If
        Loop While isit60 = False

        Return score
    End Function

    Shared Function ComputeCS(mq1 As Double, mq2 As Double, mq3 As Double, ml1 As Double, ml2 As Double, ml3 As Double) As Double
        Return (2 / 3 * ((mq1 + mq2 + mq3) / 3)) + (1 / 3 * ((ml1 + ml2 + ml3) / 3))
    End Function

    Shared Function ComputeMG(cs As Double, meGrade As Double) As Double
        Return (2 / 3 * cs) + (1 / 3 * meGrade)
    End Function

    Private Sub BtnCompute_Click(sender As Object, e As EventArgs) Handles BtnCompute.Click
        Dim studname As String = GetInput("Enter Student Name:", "Student Name")
        Dim ID As String = GetInput("Enter ID Number:", "Your ID")

        Dim mq1 As Double = GetScore("Enter Midterm Quiz 1:")
        Dim mq2 As Double = GetScore("Enter Midterm Quiz 2:")
        Dim mq3 As Double = GetScore("Enter Midterm Quiz 3:")
        Dim ml1 As Double = GetScore("Enter Lab 1:")
        Dim ml2 As Double = GetScore("Enter Lab 2:")
        Dim ml3 As Double = GetScore("Enter Lab 3:")
        Dim exam As Double = GetScore("Enter Midterm Exam:")

        Dim classStanding As Double = ComputeCS(mq1, mq2, mq3, ml1, ml2, ml3)
        Dim midtermGrade As Double = ComputeMG(classStanding, exam)


        TxtStud.Text = studname
        TxtMidterm.Text = Format(midtermGrade / 100, "Percent")
        TxtID.Text = ID
    End Sub

    Private Sub LblMidterm_Click(sender As Object, e As EventArgs) Handles LblMidterm.Click

    End Sub
End Class