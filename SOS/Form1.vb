Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Panel12.Width += 2
        If Panel12.Width >= 50 Then
            Label2.Text = "Opening files"
        End If
        If Panel12.Width >= 100 Then
            Label2.Text = "Finishing up"
        End If
        If Panel12.Width >= 150 Then
            Label2.Text = "Openng"
        End If
        If Panel12.Width >= 150 Then
            'Label1.Visible = False
        End If

        If Panel12.Width >= 199 Then
            Dim a As New login()
            a.TopLevel = False
            Panel2.Controls.Clear()
            Panel2.Controls.Add(a)
            a.Dock = DockStyle.Fill
            a.Show()
            Timer1.Enabled = False
            Label1.Text = "© SOS 2023 | login"
        End If


    End Sub

End Class
