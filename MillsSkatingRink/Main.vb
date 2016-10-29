'Joshua Pickenpaugh
'October 28th, 2016
'Skater scorer. 

Public Class frmMain

    Dim sktrCalc As New SkaterCalculator()

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Populates the list box with score numbers:
        For intScores As Integer = 0 To 10 Step 1
            lstScore.Items.Add(intScores.ToString("N0"))
        Next intScores

        'Selects number 0 onload:
        lstScore.SelectedItem = "0"

    End Sub

    Private Sub btnNextSkater_Click(sender As Object, e As EventArgs) Handles btnNextSkater.Click

        'Instantiates new Skater object:
        sktrCalc.Clear()

        lblTotalScore.Text = String.Empty
        lblNumScores.Text = String.Empty
        lblAverageScore.Text = String.Empty

    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click

        Integer.TryParse(lstScore.SelectedItem.ToString, sktrCalc.SelectedScore)

        lblTotalScore.Text = sktrCalc.GetTotalScore().ToString()
    End Sub
End Class
