Public Class trade

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Home.Show()

        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim start As String
        Dim lend As String
        Dim sgalaxy As Integer
        Dim sregion As Integer
        Dim ssystem As Integer
        Dim sastro As Integer
        Dim lgalaxy As Integer
        Dim lregion As Integer
        Dim lsystem As Integer
        Dim lastro As Integer
        Dim you As Integer
        Dim uou As Integer
        Dim ioi As Integer
        Dim ooo As Integer
        Dim jlj As Integer



        start = TextBox1.Text
        lend = TextBox2.Text

        sgalaxy = Mid(start, "2", "2")
        sregion = Mid(start, "5", "2")
        ssystem = Mid(start, "8", "2")
        sastro = Mid(start, "11", "2") / 10

        lgalaxy = Mid(lend, "2", "2")
        lregion = Mid(lend, "5", "2")
        lsystem = Mid(lend, "8", "2")
        lastro = Mid(lend, "11", "2") / 10

        you = If(Math.Abs(Int(sgalaxy / 10) - Int(lgalaxy / 10)) > 0, 3800, 0)
        'galaxy
        ioi = ((sgalaxy Mod 10) - (lgalaxy Mod 10)) * -200
        ooo = If(sregion > lgalaxy, you - ioi, you + ioi)
        'region
        uou = (Int(sregion / 10) - Int(lregion / 10)) * 10

        'system
        Label7.Text = ooo



    End Sub

    
End Class