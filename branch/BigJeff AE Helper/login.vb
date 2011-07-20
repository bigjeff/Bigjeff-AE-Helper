Imports MySql.Data.MySqlClient

Public Class login

    Private Sub login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim conn As New MySqlConnection
        Dim myCommand As New MySqlCommand
        Dim myReader As MySqlDataReader
        Dim aid As String
        Dim password As String

        aid = TextBox1.Text
        password = TextBox2.Text


        Dim SQL As String
        Dim result As String

        conn = New MySqlConnection()
        conn.ConnectionString = "server=www.bigjeff.co.uk;" _
            & "user id=jeffrey;" _
        & "password=Js031@3595;" _
        & "database=ae_helper;"

        SQL = "SELECT * FROM `login` WHERE `user` = '" & aid & "' AND `pass` ='" & password & "'"


        Try
            conn.Open()
            Try
                myCommand.Connection = conn
                myCommand.CommandText = SQL

                myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)

                If myReader.HasRows() Then
                    myReader.Read()

                    login1.userid = aid
                    Dim oForm As ems
                    oForm = New ems()
                    oForm.Show()
                    oForm = Nothing
                    Me.Close()
                Else
                    MsgBox("Incorrect login. please contact Bigjeff if you feel you should be allowed in ")


                End If







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