Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim name As String = TextBox1.Text
        Dim email As String = TextBox2.Text
        Dim Phone_num As String = TextBox3.Text
        Dim GithubLink As String = TextBox4.Text
        SendDataToExpress(name, email, Phone_num, GithubLink)
    End Sub
End Class