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

        Dim seco As Integer
        Dim deco As Integer
        Dim parters As Integer
        Dim self As String

        Dim cost As Integer
        Dim cost1 As Integer

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
        Dim hlh As Integer
        Dim glg As Integer
        Dim sum1 As Integer
        Dim sum2 As Integer
        Dim sum3 As Integer
        Dim astro As Integer
        Dim astrot As Integer
        Dim max2 As Integer
        Dim max1 As Integer
        Dim eco As Integer

        start = TextBox1.Text
        seco = TextBox2.Text
        lend = TextBox3.Text
        deco = TextBox4.Text
        parters = TextBox5.Text
        self = CheckBox1.CheckState


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
        hlh = Int(ssystem / 10) - Int(lsystem / 10)
        'region 2
        jlj = ((sregion Mod 10) - (lregion Mod 10)) * 10
        glg = ssystem Mod 10 - lsystem Mod 10
        sum1 = uou + hlh
        sum2 = jlj + glg

        sum3 = Math.Round(Math.Sqrt((sum1 * sum1) + (sum2 * sum2)), 0)

        astro = Math.Abs(sastro - lastro) / 5
        astrot = Math.Round(astro, 1)

        max1 = Math.Max(Math.Abs(ooo), sum3)
        max2 = Math.Max(max1, astrot)

        'system
        TextBox6.Text = max2

        'cost
        cost = If(self = 0, max2 / 2, max2)
        cost1 = If(self = 0, 2, 1)
        TextBox7.Text = cost
        'lowesteco
        eco = Math.Min(seco, deco)


        'Trade Income = Sqrt(Lowest base's income) x [ 1 + Sqrt(Distance)/75 + Sqrt(Players)/10 ]
        '=(ROUNDUP(SQRT(MIN(L17,N17))*(1+SQRT(MAX(defaults!AB88:AE88))/75+SQRT(P17)/10),0))*(2/defaults!AA86)        '
        TextBox8.Text = Math.Round(Math.Sqrt(eco) * (1 + Math.Sqrt(max2) / 75 + Math.Sqrt(parters) / 10)) * (2 / cost1)




    End Sub

    
End Class