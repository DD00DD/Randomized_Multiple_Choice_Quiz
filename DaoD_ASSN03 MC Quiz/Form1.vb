'***********************************************************************
'	PROGRAMME NAME	    :	ASSN03 MC Quiz
'
'	PROGRAMME OUTLINE	:	This programme allows the user to do a multiple
'                           choice quiz that fills up a progressbar if they 
'                           guess the right answer, which then indiacates 
'                           the person's score.
'
'	PROGRAMMER		    :	Derek Dao
'
'	DATE				:	Jan 10th, 2020
'
'***********************************************************************
Imports System.IO
Public Class Form1
    Private num(9) As Integer
    Private score As Integer
    Private count As Integer
    Private str() As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim randNum As Integer
        Dim rand As New Random

        For i = 0 To num.Length - 1
input:
            randNum = rand.Next(1, 11)

            If num.Contains(randNum) Then
                GoTo input
            End If

            num(i) = randNum
        Next
    End Sub

    Private Sub BtnAsk_Click(sender As Object, e As EventArgs) Handles btnAsk.Click
        Dim line As String
        Dim quiz As StreamReader

        If File.Exists("questions.txt") Then
            quiz = File.OpenText("questions.txt")
        End If

        btnAsk.Enabled = False
        btnCheck.Enabled = True

        For i = 0 To 9
            line = quiz.ReadLine
            str = Split(line, ",")

            If str(0) = num(count) Then
                Exit For
            End If
        Next

        quiz.Close()

        lblQuestion.Text = count + 1 & ". " & str(1)
        rdbOne.Text = str(2)
        rdbTwo.Text = str(3)
        rdbThree.Text = str(4)
        rdbFour.Text = str(5)
    End Sub

    Private Sub GetScore() ' Updates the score
        Dim answers() As RadioButton = {rdbOne, rdbTwo, rdbThree, rdbFour}

        For i = 0 To answers.Length - 1
            If answers(i).Checked = True Then
                If str(6) = answers(i).Tag Then
                    prgScore.Value += 10
                    score += 10
                    lblScore.Text = score & "/100"
                End If
            End If
        Next

            btnCheck.Enabled = False
        btnAsk.Enabled = True
        lblScore.Text = score & "/" & 100

        For index = 0 To answers.Length - 1
            answers(index).Checked = False
        Next

        count += 1
        If count = 10 Then
            MessageBox.Show("End of quiz!!" & Environment.NewLine & score & "/100", "The End", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnAsk.Enabled = False
            btnCheck.Enabled = False
        End If
    End Sub

    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        If rdbOne.Checked = False And rdbTwo.Checked = False And rdbThree.Checked = False And rdbFour.Checked = False Then
            MessageBox.Show("Choose an answer!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            GetScore()
        End If
    End Sub
End Class
