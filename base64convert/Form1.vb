Public Class Form1

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            My.Computer.Clipboard.SetText(Me.TextBox2.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox2.Text = System.Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(TextBox1.Text))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim th As String = Nothing
        th = TextBox2.Text
        TextBox2.Text = String.Empty
        TextBox2.Text = System.Text.ASCIIEncoding.ASCII.GetString(System.Convert.FromBase64String(th))
        th = String.Empty
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Base64 Encode"
    End Sub

End Class
