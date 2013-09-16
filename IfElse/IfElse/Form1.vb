Option Strict On

Public Class Form1
    Dim FirstNumber As Double
    Dim SecondNumber As Double

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        FirstNumber = CDbl(txtFirstNum.Text)
        SecondNumber = CDbl(txtSecondNum.Text)

        If FirstNumber > SecondNumber Then
            txtResult.Text = txtFirstNum.Text
        End If

        If FirstNumber < SecondNumber Then
            txtResult.Text = txtSecondNum.Text
        End If
    End Sub

   
End Class
