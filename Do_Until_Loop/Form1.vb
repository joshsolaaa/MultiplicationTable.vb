Public Class Form1
    Dim Timesnum As Integer = 1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Do Until Timesnum >= 13
            ListBox1.Items.Add(Timesnum & "*" & Val(TextBox1.Text) & "=" & Timesnum * Val(TextBox1.Text))
            Timesnum += 1
        Loop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        ListBox1.Refresh()
        TextBox1.Text = ""
        Timesnum = 1
        TextBox1.Focus()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class
