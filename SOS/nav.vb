Imports System.Reflection.Emit
Imports Microsoft.VisualBasic.ApplicationServices

Public Class nav
    Private Sub nav_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True




        Dim a As New dash()
        a.TopLevel = False
        Panel3.Controls.Clear()
        Panel3.Controls.Add(a)
        a.Dock = DockStyle.Fill
        a.Show()

    End Sub

    Private Sub quit(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New dash()
        a.TopLevel = False
        Panel3.Controls.Clear()
        Panel3.Controls.Add(a)
        a.Dock = DockStyle.Fill
        a.Show()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click


        Dim r As DialogResult = MessageBox.Show("You are already logged in. Do you wish to log out and quit the app?", "Log out?", MessageBoxButtons.YesNo)
        If r = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim t As String = DateTime.Now.ToString("HH")
        'Label6.Text = DateTime.Now.ToString("dddd dd")

        ' Label5.Text = DateTime.Now.ToString("h:mm:ss:tt")
        If t <= 11 Then
            Me.Label5.Text = "Good morning"

        ElseIf t <= 12 Then
            Label5.Text = "Good lunch"

        ElseIf t <= 14 Then
            Label5.Text = "Good afernoon"

        ElseIf t <= 16 Then
            Label5.Text = "Good evening"

        ElseIf t >= (19) Then
            Label5.Text = "Good night"

        End If
    End Sub
End Class