Public Class Home

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim oForm As trade
        oForm = New trade()
        oForm.Show()
        oForm = Nothing
        Me.Hide()


    End Sub
End Class
