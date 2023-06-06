Public Class accept

    Private Sub accept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        If Panel1.Width <= 600 Then
            Panel1.Width += 50
        End If

        If Panel1.Width >= 500 Then
            ' dashboard.Show()
            nav.Show()
            Me.Hide()


        End If
    End Sub
End Class