Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim FullName As String = txtFullName.Text 'input from user
        Dim FirstName As String
        Dim x As Integer

        FullName = FullName.Trim 'Eliminates additional spaces before or after 

        x = FullName.IndexOf(" ") 'Location of first space
        FirstName = FullName.Substring(0, x) 'Substring of first name only

        txtFirstName.Text = FirstName 'Displays substring in first name box
    End Sub

    Private Sub txtFullName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFullName.TextChanged

    End Sub
End Class
