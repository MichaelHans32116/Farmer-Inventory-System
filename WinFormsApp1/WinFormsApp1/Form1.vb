Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=127.0.0.1;userid=root;password=;database=DBTest"
        lgnBtn.Padding = New Padding(0)
    End Sub

    Private Sub unameText_Enter(sender As Object, e As EventArgs) Handles unameText.Enter
        If unameText.Text = "Username" Then

            unameText.Text = ""
            unameText.ForeColor = Color.White
        End If
    End Sub

    Private Sub unameText_Leave(sender As Object, e As EventArgs) Handles unameText.Leave
        If unameText.Text = "" Then

            unameText.Text = "Username"
            unameText.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub passText_Enter(sender As Object, e As EventArgs) Handles passText.Enter
        If passText.Text = "Password" Then

            passText.Text = ""
            passText.ForeColor = Color.White
        End If
    End Sub

    Private Sub passText_Leave(sender As Object, e As EventArgs) Handles passText.Leave
        If passText.Text = "" Then

            passText.Text = "Password"
            passText.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub lgnText_Click(sender As Object, e As EventArgs) Handles lgnBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=DBTest"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM user_data WHERE username='" & unameText.Text & "' AND password='" & passText.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count += 1
            End While

            If count = 1 Then
                lblErrorMessage.Visible = False
                Form2.Show()
                Me.Hide()
            ElseIf count > 1 Then
                lblErrorMessage.Text = "Username and Password are duplicated."
                lblErrorMessage.ForeColor = Color.LightSteelBlue
                lblErrorMessage.Visible = True
            Else
                lblErrorMessage.Text = "Wrong username or password."
                lblErrorMessage.ForeColor = Color.LightSteelBlue
                lblErrorMessage.Visible = True
            End If

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class
