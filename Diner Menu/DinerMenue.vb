Option Explicit On
Option Strict On

Public Class DinerMenuForm
    Private Sub DinerMenuForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        SoupGroupBox.Hide()
        SaladGroupBox.Hide()
        FishGroupBox.Hide()


    End Sub








    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        SoupGroupBox.Hide()
        SaladGroupBox.Hide()
        FishGroupBox.Show()

    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        FishGroupBox.Hide()
        SaladGroupBox.Hide()
        SoupGroupBox.Show()
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        FishGroupBox.Hide()
        SoupGroupBox.Hide()
        SaladGroupBox.Show()
    End Sub
End Class
