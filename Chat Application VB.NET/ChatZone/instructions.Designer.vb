<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class instructions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(instructions))
        Label1 = New Label()
        Label2 = New Label()
        confirm = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(-9, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(622, 32)
        Label1.TabIndex = 0
        Label1.Text = "      Instructions" & vbCrLf & "---------------------------------------------------------------------------------------------------------------------------"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(31, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(506, 330)
        Label2.TabIndex = 1
        Label2.Text = resources.GetString("Label2.Text")
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' confirm
        ' 
        confirm.BackColor = Color.FromArgb(CByte(61), CByte(155), CByte(233))
        confirm.Cursor = Cursors.Hand
        confirm.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        confirm.Location = New Point(225, 431)
        confirm.Name = "confirm"
        confirm.Size = New Size(105, 46)
        confirm.TabIndex = 2
        confirm.Text = "Confirm!"
        confirm.UseVisualStyleBackColor = False
        ' 
        ' instructions
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(564, 511)
        Controls.Add(confirm)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "instructions"
        Text = "ChatZone"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents confirm As Button
End Class
