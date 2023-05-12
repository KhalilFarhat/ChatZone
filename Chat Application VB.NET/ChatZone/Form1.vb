Public Class Home
    Private WithEvents mainPage As mainpage
    Private WithEvents instructionsPage As instructions
    Public instructionsForm As instructions = Nothing

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If mainPage Is Nothing OrElse mainPage.IsDisposed Then
            mainPage = New mainpage()
            mainPage.Location = Me.Location
            mainPage.StartPosition = FormStartPosition.Manual
            mainPage.Show()
            Me.Hide()
        Else
            mainPage.Activate()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If instructionsPage Is Nothing OrElse instructionsPage.IsDisposed Then
            instructionsPage = New instructions()
            instructionsPage.StartPosition = FormStartPosition.Manual
            instructionsPage.Location = Me.Location
            instructionsPage.Show()
            Me.Hide()
        Else
            instructionsPage.Activate()
        End If
    End Sub

    Private Sub Home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Intro_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Check if the form is closing because of the "X" button
        If e.CloseReason = CloseReason.UserClosing Then
            ' Display confirmation prompt
            If MessageBox.Show("Are you sure you want to close the application?", "Exit", MessageBoxButtons.YesNo) = DialogResult.No Then
                e.Cancel = True
                ' Create a new instance of the form and show it again
                Dim introForm As New Home
                introForm.Show()
            Else
                ' Terminate the application
                End
            End If
        End If
    End Sub


End Class
