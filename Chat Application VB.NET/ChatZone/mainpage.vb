Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.Net.Http
Imports System.Diagnostics
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class mainpage


    Private isClosingFromMenuBar As Boolean = False
    Private client As TcpClient
    Public STR As StreamReader
    Public STW As StreamWriter
    Public recieve As String
    Public TextToSend As String
    Private tcpListeners As New List(Of TcpListener)
    Private tcpClients As New List(Of TcpClient)
    Private clientStreams As New List(Of StreamWriter)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim localIP As IPAddress() = Dns.GetHostAddresses(Dns.GetHostName)
        ChatScreentextBox.DetectUrls = True



        For Each address As IPAddress In localIP
            If address.AddressFamily = AddressFamily.InterNetwork Then
                ServerIPtextBox.Text = address.ToString()
            End If
        Next


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub startBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click
        ' Validate the port number
        Dim portNumber As Integer
        If Not Integer.TryParse(ServerPorttextBox.Text, portNumber) OrElse portNumber < 1 OrElse portNumber > 65535 Then
            MessageBox.Show("Please enter a valid port number between 1 and 65535.")
            Return
        End If
        ' Validate the username
        Dim username As String = usernameTextBox.Text.Trim()
        If String.IsNullOrEmpty(username) Then
            MessageBox.Show("Please enter a username.")
            Return
        End If

        ' If the port number and username are valid, continue with the rest of the code
        Dim listener As New TcpListener(IPAddress.Any, portNumber)
        listener.Start()

        Dim serverName As String = Dns.GetHostName()
        Dim message As String = $"Server Started: {serverName}, IP {ServerIPtextBox.Text}, PORT: {portNumber}"
        ChatScreentextBox.AppendText($"[SERVER] {message}{vbCrLf}")

        ' Add a separator line after the message
        ChatScreentextBox.AppendText("-------------------------------------------------------------------------------------------------------" & vbCrLf)

        ' Display the username in the ChatScreentextBox
        ChatScreentextBox.AppendText($"[SERVER] Admin '{username}' has joined the chat.{vbCrLf}")

        Dim clientConnected As Boolean = False ' flag to indicate if a client has connected



        Do While Not clientConnected ' loop until a client connects
            ' Display a prompt message indicating that the server is waiting for a client to connect
            ChatScreentextBox.AppendText($"[SERVER] Waiting for a client to connect...{vbCrLf}")

            ' Wait for a short period of time before checking again for a client connection
            Threading.Thread.Sleep(0)
            If listener.Pending() Then ' check if a client is attempting to connect
                client = listener.AcceptTcpClient()
                Dim clientStream As NetworkStream = client.GetStream()
                Dim clientWriter As New StreamWriter(clientStream)
                clientStreams.Add(clientWriter)

                ' Send the "[SERVER] Admin '{username}' has joined the chat." message to all clients
                For Each writer As StreamWriter In clientStreams
                    writer.WriteLine($"[SERVER] Admin '{username}' has joined the chat.")
                    writer.Flush()
                Next

                STR = New StreamReader(client.GetStream())
                STW = New StreamWriter(client.GetStream())
                STW.AutoFlush = True

                clientConnected = True ' set the flag to true to exit the loop
            End If

        Loop

        BackgroundWorker1.RunWorkerAsync()
        BackgroundWorker2.WorkerSupportsCancellation = True

        ' Refresh the UI
        Me.Refresh()

        ' Add a separator line after the message
        ChatScreentextBox.AppendText("-------------------------------------------------------------------------------------------------------" & vbCrLf)
    End Sub


    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As KeyEventArgs) Handles ServerPorttextBox.KeyDown

        'Check if enter key was pressed
        If e.KeyCode = Keys.Enter Then
            'Trigger start button's click event
            startBtn.PerformClick()
        End If
    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close/leave all the ports and return to the Home screen?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            For Each tcpClient In tcpClients
                tcpClient.Close()
            Next
            For Each tcpListener In tcpListeners
                tcpListener.Stop()
            Next

            Dim home As New Home()
            home.StartPosition = FormStartPosition.Manual
            home.Location = Me.Location
            home.Show()
            Me.Hide()
        End If
    End Sub


    Private Sub mainpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ServerIPtextBox_TextChanged(sender As Object, e As EventArgs) Handles ServerIPtextBox.TextChanged

    End Sub

    Private Sub connectBtn_Click(sender As Object, e As EventArgs) Handles connectBtn.Click
        Try
            ' Check if username is entered
            If String.IsNullOrWhiteSpace(usernameTextBox.Text) Then
                MessageBox.Show("Please enter a username before connecting.")
                Return
            End If
            ' Check if port number is entered
            Dim portNumber As Integer
            If Not Integer.TryParse(clientPorttextBox.Text, portNumber) OrElse portNumber < 1 OrElse portNumber > 65535 Then
                MessageBox.Show("Enter a Port Number Between 1 and 65535")
                Return
            End If

            ' Connect to server
            client = New TcpClient()
            Dim IpEnd As New IPEndPoint(IPAddress.Parse(clientIPtextBox.Text), portNumber)
            client.Connect(IpEnd)

            ' Display connection message and username in ChatScreentextBox
            If (client.Connected) Then
                ChatScreentextBox.AppendText($"Connected to server at IP {clientIPtextBox.Text} and port {clientPorttextBox.Text}{vbCrLf}-------------------------------------------------------------------------------------------------------{vbCrLf}Please be respectful to others and abide by the rules. You are responsible for your actions.{vbCrLf}-------------------------------------------------------------------------------------------------------{vbCrLf}")
                STW = New StreamWriter(client.GetStream())
                STR = New StreamReader(client.GetStream())
                STW.AutoFlush = True
                BackgroundWorker1.RunWorkerAsync()
                BackgroundWorker2.WorkerSupportsCancellation = True
                ChatScreentextBox.AppendText($"[SERVER] User '{usernameTextBox.Text}' has joined the chat.{vbCrLf}-------------------------------------------------------------------------------------------------------{vbCrLf}")
            End If
        Catch ex As Exception
            MessageBox.Show("There could be a network problem or you might be using an incorrect port.")
        End Try
    End Sub



    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim isClientMessage As Boolean = CType(e.Argument, Boolean)
        Dim prefix As String = If(isClientMessage, "Client: " + usernameTextBox.Text + " - ", "Server: ")

        While client.Connected
            If STR IsNot Nothing Then
                Dim message = STR.ReadLine()
                Me.ChatScreentextBox.Invoke(New MethodInvoker(Sub() ChatScreentextBox.AppendText($"{prefix}{message}{Environment.NewLine}-------------------------------------------------------------------------------------------------------{Environment.NewLine}")))
            End If
        End While
    End Sub


    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        If (client.Connected) Then
            STW.WriteLine(TextToSend)
            Me.ChatScreentextBox.Invoke(New MethodInvoker(Function()
                                                              ChatScreentextBox.AppendText("ME: " + TextToSend + Environment.NewLine + "-------------------------------------------------------------------------------------------------------" + Environment.NewLine)
                                                          End Function))
        Else
            MessageBox.Show("Sending Failed")
        End If

        BackgroundWorker2.CancelAsync()
    End Sub



    Private Sub sendBtn_Click(sender As Object, e As EventArgs) Handles sendBtn.Click
        If (client Is Nothing OrElse Not client.Connected) Then
            MessageBox.Show("You are not connected to any chat room or server.")
            Return
        End If

        If (MessagetextBox.Text <> "") Then
            Dim result As DialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                TextToSend = MessagetextBox.Text
                BackgroundWorker2.RunWorkerAsync()
                MessagetextBox.Text = ""
            End If
        End If
    End Sub



    Private Sub mainpage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Check if the form is closing because of the "X" button
        If e.CloseReason = CloseReason.UserClosing AndAlso Not isClosingFromMenuBar Then
            ' Display confirmation prompt
            If MessageBox.Show("Are you sure you want to close the application?", "Exit", MessageBoxButtons.YesNo) = DialogResult.No Then
                e.Cancel = True

            Else
                ' Terminate the application
                End
                For Each tcpListener In tcpListeners
                    tcpListener.Stop()
                Next

                For Each tcpClient In tcpClients
                    tcpClient.Close()
                Next
            End If
        End If
    End Sub


    Private Sub clientPorttextBox_TextChanged(sender As Object, e As EventArgs) Handles clientPorttextBox.TextChanged
        ' Remove any non-digit characters from the input
        Dim input As String = ""
        For Each c As Char In clientPorttextBox.Text
            If Char.IsDigit(c) Then
                input += c
            End If
        Next

        ' Set the text box to the cleaned-up input
        clientPorttextBox.Text = input

        ' Set the cursor position to the end of the text box
        clientPorttextBox.SelectionStart = clientPorttextBox.Text.Length
    End Sub
    Private Sub clientPorttextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles clientPorttextBox.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then ' Check if the Enter key was pressed
            e.Handled = True ' Set the event as handled
            connectBtn.PerformClick() ' Simulate a click on the Connect button
        End If
    End Sub


    Private Sub MessagetextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles MessagetextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent the "ding" sound
            sendBtn.PerformClick()
        End If
    End Sub

    Private Sub ChatScreentextBox_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles ChatScreentextBox.LinkClicked
        Dim link As String = e.LinkText

        ' Try to open the link in the default browser
        Try
            Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("HTTP\shell\open\command", False)
            Dim defaultBrowser As String = key.GetValue(Nothing).ToString().ToLower().Replace("""", "").Split(New String() {"exe"}, StringSplitOptions.None)(0) + "exe"
            Process.Start(defaultBrowser, link)
        Catch ex As Exception
            ' If opening the link with the default browser fails, try to open it with Chrome, Firefox or Edge
            Dim chromePath As String = "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
            Dim firefoxPath As String = "C:\Program Files\Mozilla Firefox\firefox.exe"
            Dim edgePath As String = "C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe"
            Dim browserPaths() As String = {chromePath, firefoxPath, edgePath}

            For Each browserPath In browserPaths
                If IO.File.Exists(browserPath) Then
                    Process.Start(browserPath, link)
                    Exit For
                End If
            Next

            ' If none of the browsers are found, show an error message
            MessageBox.Show("Unable to open the link in a web browser.")
        End Try
    End Sub




    Private Sub ServerPorttextBox_TextChanged(sender As Object, e As EventArgs) Handles ServerPorttextBox.TextChanged
        ' Check if the entered value is an integer
        Dim result As Integer
        If Not Int32.TryParse(ServerPorttextBox.Text, result) Then
            ' If not or if "." is present, remove the last entered character (if possible)
            If ServerPorttextBox.TextLength > 0 Then
                ServerPorttextBox.Text = ServerPorttextBox.Text.TrimEnd(ServerPorttextBox.Text.Chars(ServerPorttextBox.TextLength - 1))
                ' Set the cursor position to the end of the text box
                ServerPorttextBox.SelectionStart = ServerPorttextBox.TextLength
            End If
        End If
    End Sub




    Private Sub clientIPtextBox_TextChanged(sender As Object, e As EventArgs) Handles clientIPtextBox.TextChanged
        Dim regexPattern As String = "^[0-9.]*$"
        Dim inputStr As String = clientIPtextBox.Text

        If Not Regex.IsMatch(inputStr, regexPattern) Then
            ' The input string contains invalid characters.
            ' Remove the last character from the textbox.
            Dim newStr As String = inputStr.Substring(0, inputStr.Length - 1)
            clientIPtextBox.Text = newStr
            clientIPtextBox.SelectionStart = newStr.Length
        End If
    End Sub
    Private Sub clientIPtextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles clientIPtextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            clientPorttextBox.Focus()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles usernameTextBox.TextChanged

    End Sub
End Class
