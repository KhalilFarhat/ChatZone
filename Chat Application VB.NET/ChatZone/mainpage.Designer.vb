<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainpage
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(mainpage))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        ServerIPtextBox = New TextBox()
        Label3 = New Label()
        ServerPorttextBox = New TextBox()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Label5 = New Label()
        clientIPtextBox = New TextBox()
        Label6 = New Label()
        clientPorttextBox = New TextBox()
        startBtn = New Button()
        connectBtn = New Button()
        ChatScreentextBox = New RichTextBox()
        MessagetextBox = New RichTextBox()
        backBtn = New Button()
        sendBtn = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        BackgroundWorker2 = New ComponentModel.BackgroundWorker()
        usernameTextBox = New TextBox()
        Label7 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.server
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(56, 50)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(86, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 17)
        Label1.TabIndex = 1
        Label1.Text = "Server"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(80, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(20, 17)
        Label2.TabIndex = 2
        Label2.Text = "IP"
        ' 
        ' ServerIPtextBox
        ' 
        ServerIPtextBox.Cursor = Cursors.IBeam
        ServerIPtextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ServerIPtextBox.Location = New Point(104, 37)
        ServerIPtextBox.Name = "ServerIPtextBox"
        ServerIPtextBox.Size = New Size(164, 25)
        ServerIPtextBox.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(271, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 17)
        Label3.TabIndex = 4
        Label3.Text = "PORT"
        ' 
        ' ServerPorttextBox
        ' 
        ServerPorttextBox.Cursor = Cursors.IBeam
        ServerPorttextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ServerPorttextBox.Location = New Point(314, 37)
        ServerPorttextBox.Name = "ServerPorttextBox"
        ServerPorttextBox.PlaceholderText = "1 to 65535"
        ServerPorttextBox.Size = New Size(127, 25)
        ServerPorttextBox.TabIndex = 5
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.client
        PictureBox2.Location = New Point(12, 85)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(45, 50)
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(86, 85)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 17)
        Label4.TabIndex = 7
        Label4.Text = "Client"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(80, 118)
        Label5.Name = "Label5"
        Label5.Size = New Size(20, 17)
        Label5.TabIndex = 8
        Label5.Text = "IP"
        ' 
        ' clientIPtextBox
        ' 
        clientIPtextBox.Cursor = Cursors.IBeam
        clientIPtextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        clientIPtextBox.Location = New Point(104, 110)
        clientIPtextBox.Name = "clientIPtextBox"
        clientIPtextBox.Size = New Size(164, 25)
        clientIPtextBox.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(271, 114)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 17)
        Label6.TabIndex = 10
        Label6.Text = "PORT"
        ' 
        ' clientPorttextBox
        ' 
        clientPorttextBox.Cursor = Cursors.IBeam
        clientPorttextBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        clientPorttextBox.Location = New Point(314, 110)
        clientPorttextBox.Name = "clientPorttextBox"
        clientPorttextBox.PlaceholderText = "1 to 65535"
        clientPorttextBox.Size = New Size(127, 25)
        clientPorttextBox.TabIndex = 11
        ' 
        ' startBtn
        ' 
        startBtn.BackColor = Color.LightGreen
        startBtn.Cursor = Cursors.Hand
        startBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        startBtn.Location = New Point(457, 29)
        startBtn.Name = "startBtn"
        startBtn.Size = New Size(95, 38)
        startBtn.TabIndex = 12
        startBtn.Text = "START"
        startBtn.UseVisualStyleBackColor = False
        ' 
        ' connectBtn
        ' 
        connectBtn.BackColor = Color.Cyan
        connectBtn.Cursor = Cursors.Hand
        connectBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        connectBtn.Location = New Point(457, 102)
        connectBtn.Name = "connectBtn"
        connectBtn.Size = New Size(95, 38)
        connectBtn.TabIndex = 13
        connectBtn.Text = "CONNECT"
        connectBtn.UseVisualStyleBackColor = False
        ' 
        ' ChatScreentextBox
        ' 
        ChatScreentextBox.BorderStyle = BorderStyle.FixedSingle
        ChatScreentextBox.Location = New Point(12, 200)
        ChatScreentextBox.Name = "ChatScreentextBox"
        ChatScreentextBox.ReadOnly = True
        ChatScreentextBox.Size = New Size(540, 211)
        ChatScreentextBox.TabIndex = 14
        ChatScreentextBox.Text = "The Chat-Screen will be accessible when connecting to a server or client." & vbLf & "-------------------------------------------------------------------------------------------------------"
        ' 
        ' MessagetextBox
        ' 
        MessagetextBox.BorderStyle = BorderStyle.FixedSingle
        MessagetextBox.Cursor = Cursors.IBeam
        MessagetextBox.EnableAutoDragDrop = True
        MessagetextBox.Location = New Point(91, 417)
        MessagetextBox.Name = "MessagetextBox"
        MessagetextBox.Size = New Size(382, 82)
        MessagetextBox.TabIndex = 15
        MessagetextBox.Text = ""
        ' 
        ' backBtn
        ' 
        backBtn.BackColor = Color.LightGray
        backBtn.Cursor = Cursors.Hand
        backBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        backBtn.Location = New Point(12, 417)
        backBtn.Name = "backBtn"
        backBtn.Size = New Size(73, 82)
        backBtn.TabIndex = 16
        backBtn.Text = "BACK"
        backBtn.UseVisualStyleBackColor = False
        ' 
        ' sendBtn
        ' 
        sendBtn.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        sendBtn.Cursor = Cursors.Hand
        sendBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        sendBtn.Location = New Point(479, 417)
        sendBtn.Name = "sendBtn"
        sendBtn.Size = New Size(73, 82)
        sendBtn.TabIndex = 17
        sendBtn.Text = "SEND"
        sendBtn.UseVisualStyleBackColor = False
        ' 
        ' BackgroundWorker1
        ' 
        ' 
        ' BackgroundWorker2
        ' 
        ' 
        ' usernameTextBox
        ' 
        usernameTextBox.Location = New Point(314, 162)
        usernameTextBox.Name = "usernameTextBox"
        usernameTextBox.PlaceholderText = "UserName"
        usernameTextBox.Size = New Size(238, 25)
        usernameTextBox.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(12, 153)
        Label7.Name = "Label7"
        Label7.Size = New Size(285, 34)
        Label7.TabIndex = 19
        Label7.Text = " Set a Name For Your Account on The Server." & vbCrLf & " Note: Name Can't be changed later On." & vbCrLf
        ' 
        ' mainpage
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(564, 511)
        Controls.Add(Label7)
        Controls.Add(usernameTextBox)
        Controls.Add(sendBtn)
        Controls.Add(backBtn)
        Controls.Add(MessagetextBox)
        Controls.Add(ChatScreentextBox)
        Controls.Add(connectBtn)
        Controls.Add(startBtn)
        Controls.Add(clientPorttextBox)
        Controls.Add(Label6)
        Controls.Add(clientIPtextBox)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(PictureBox2)
        Controls.Add(ServerPorttextBox)
        Controls.Add(Label3)
        Controls.Add(ServerIPtextBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "mainpage"
        Text = "ChatZone"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ServerIPtextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ServerPorttextBox As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents clientIPtextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents clientPorttextBox As TextBox
    Friend WithEvents startBtn As Button
    Friend WithEvents connectBtn As Button
    Friend WithEvents ChatScreentextBox As RichTextBox
    Friend WithEvents MessagetextBox As RichTextBox
    Friend WithEvents backBtn As Button
    Friend WithEvents sendBtn As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents usernameTextBox As TextBox
    Friend WithEvents Label7 As Label
End Class
