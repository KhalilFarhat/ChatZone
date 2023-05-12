Public Class instructions
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub confirm_Click(sender As Object, e As EventArgs) Handles confirm.Click
        Dim home As New Home()
        home.StartPosition = FormStartPosition.Manual
        home.Location = Me.Location
        home.Show()
        Me.Hide()
    End Sub
    Private Sub instructions_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Check if the form is closing because of the "X" button
        If e.CloseReason = CloseReason.UserClosing Then
            ' Display confirmation prompt
            If MessageBox.Show("Are you sure you want to close the application?", "Exit", MessageBoxButtons.YesNo) = DialogResult.No Then
                e.Cancel = True
                ' Show the existing instance of the form
                If Not IsNothing(Home.instructionsForm) Then
                    Home.instructionsForm.Show()
                End If
            Else
                ' Terminate the application
                End
            End If
        End If
    End Sub

    Private Sub instructions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class