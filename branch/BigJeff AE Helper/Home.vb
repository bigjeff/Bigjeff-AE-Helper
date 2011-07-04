Imports MySql.Data.MySqlClient
Imports System.Data


Public Class Home
    Dim conn As New MySqlConnection
    Dim myCommand As New MySqlCommand
    Dim myReader As MySqlDataReader

    Dim SQL As String
    Dim result As String


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

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
    End Sub
End Class
