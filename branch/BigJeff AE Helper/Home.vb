Imports MySql.Data.MySqlClient
Imports System.Data


Public Class Home
    Dim conn As New MySqlConnection
    Dim myCommand As New MySqlCommand
    Dim myReader As MySqlDataReader


    Dim SQL As String
    Dim result As String
    Public String1 As String



    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim oForm As trade
        oForm = New trade()
        oForm.Show()
        oForm = Nothing
        Me.Hide()


    End Sub

    Private Sub Home_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conn = New MySqlConnection()
        conn.ConnectionString = "server=www.bigjeff.co.uk;" _
            & "user id=jeffrey;" _
        & "password=Js031@3595;" _
        & "database=ae_helper;"

        SQL = "SELECT log FROM `Logs` ORDER BY id DESC LIMIT 0,1"

        Try
            conn.Open()
            Try
                myCommand.Connection = conn
                myCommand.CommandText = SQL

                myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
                myReader.Read()

                Label2.Text = Convert.ToString(myReader.GetString("log"))



                
            Catch myerror As MySqlException
                MsgBox("There was an error reading from the database: " & myerror.Message)
            End Try

            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error Connecting to Database: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try

        ToolStripStatusLabel1.Text = "Status"






    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim defencess As defence
        defencess = New defence()
        defencess.Show()
        defencess = Nothing

        Me.Hide()
    End Sub

    Private Sub Button1_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button1.MouseHover
        ToolStripStatusLabel1.Text = "Calc Trades"
    End Sub

    Private Sub Button1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button1.MouseLeave
        ToolStripStatusLabel1.Text = ""
    End Sub

    Private Sub ToolStripProgressBar1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim defencess As ems
        defencess = New ems()
        defencess.Show()
        defencess = Nothing


    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim setting As Form1
        setting = New Form1()
        setting.Show()
        setting = Nothing

    End Sub
End Class
