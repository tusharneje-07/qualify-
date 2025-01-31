﻿Public Class Form1
    Dim db As New DatabaseConnection()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Equals("") And TextBox2.Text.Equals("") Then
            Form5.Show()
            Me.Hide()
        ElseIf TextBox1.Text IsNot "" And TextBox2.Text IsNot "" Then
            Dim status = db.auth(TextBox1.Text, TextBox2.Text)
            If status Then
                Form2.Username = TextBox1.Text
                Me.Hide()
                Form2.Show()
            Else
                MessageBox.Show("Login Failed")
            End If
        Else
            MessageBox.Show("Please Enter Username and Password")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form6.Show()
    End Sub
End Class
