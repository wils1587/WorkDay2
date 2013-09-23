Option Strict On

Public Class Form1
    Dim FirstNumber As Double
    Dim SecondNumber As Double
   

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        
        If IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text) Then
            FirstNumber = CDbl(txtFirstNum.Text)
            SecondNumber = CDbl(txtSecondNum.Text)
            If FirstNumber < 0 Or SecondNumber < 0 Then
                MessageBox.Show("Error: Please enter postive numbers only")
                Return
            End If

            If FirstNumber > SecondNumber Then
                txtResult.Text = txtFirstNum.Text
            ElseIf FirstNumber < SecondNumber Then
                txtResult.Text = txtSecondNum.Text
            Else : txtResult.Text = "Equal"
            End If
        Else
            MessageBox.Show("Error: Please enter numbers only")

        End If
    End Sub

   
End Class
