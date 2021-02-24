Public Class Archery
    Dim bild As Graphics
    Dim a As Single
    Dim x1 As Single
    Dim y1 As Single
    Dim x2 As Single
    Dim y2 As Single
    Dim xp(2) As Single
    Dim yp(2) As Single
    Dim vx As Single
    Dim vy As Single
    Dim h1 As Single
    Dim h2 As Single
    Dim wind As Single
    Dim rot As Integer
    Dim blau As Integer
    Dim gruen As Integer

    Dim flying As Boolean

    Sub drawguy(house As Integer, x As Single, y As Single)
        Select Case house
            Case 1
                bild.FillEllipse(New SolidBrush(Color.White), x, y, 20, 20)
                bild.FillEllipse(New SolidBrush(Color.LightGray), x + 5, y + 8, 10, 4)
            Case 2
                bild.FillEllipse(New SolidBrush(Color.Crimson), x, y, 20, 20)
                bild.FillEllipse(New SolidBrush(Color.Gold), x + 5, y + 7, 10, 6)
            Case 3
                bild.FillEllipse(New SolidBrush(Color.Black), x, y, 20, 20)
                bild.FillEllipse(New SolidBrush(Color.Red), x + 5, y + 7, 10, 6)
            Case 4
                bild.FillEllipse(New SolidBrush(Color.RoyalBlue), x, y, 20, 20)
                bild.FillEllipse(New SolidBrush(Color.White), x + 6, y + 6, 8, 8)
                bild.FillEllipse(New SolidBrush(Color.RoyalBlue), x + 8, y + 8, 4, 4)
            Case 5
                bild.FillEllipse(New SolidBrush(Color.Gold), x, y, 20, 20)
                bild.FillEllipse(New SolidBrush(Color.Black), x + 6, y + 5, 6, 10)
            Case 6
                bild.FillEllipse(New SolidBrush(Color.Black), x, y, 20, 20)
                bild.FillEllipse(New SolidBrush(Color.Gold), x + 6, y + 2, 8, 14)
            Case 7
                bild.FillEllipse(New SolidBrush(Color.Orange), x, y, 20, 20)
                bild.FillEllipse(New SolidBrush(Color.Red), x + 6, y + 6, 8, 8)
                bild.DrawLine(New Pen(Color.Gold), x + 5, y + 5, x + 15, y + 15)
            Case 8
                bild.FillEllipse(New SolidBrush(Color.Red), x, y, 20, 20)
                bild.DrawLine(New Pen(Color.Blue, 4), x + 7, y + 2, x + 7, y + 19)
                bild.DrawLine(New Pen(Color.Blue, 4), x + 15, y + 2, x + 15, y + 19)
                bild.DrawLine(New Pen(Color.White, 3), x + 13, y + 15, x + 7, y + 5)
            Case 9
                bild.FillEllipse(New SolidBrush(Color.Green), x, y, 20, 20)
                bild.FillEllipse(New SolidBrush(Color.Gold), x + 7, y + 7, 6, 6)
        End Select
    End Sub

    Sub drawflag()
        bild.FillRectangle(New SolidBrush(Color.FromArgb(200, 230, 255)), 136, 260, 27, 40)
        bild.DrawLine(New Pen(Color.Brown, 3), 150, 300, 150, 260)
        If wind > 0 Then
            bild.FillRectangle(New SolidBrush(Color.FromArgb(rot, blau, gruen)), 150, 260, (wind * 50), 10)
        Else
            bild.FillRectangle(New SolidBrush(Color.FromArgb(rot, blau, gruen)), 150 + wind * 80, 260, (wind * -80), 10)

        End If
    End Sub

    Sub setwind()
        wind = (Rnd() * 100 - 50) / 300
    End Sub

    Sub win(house As Integer)
        Select Case house
            Case 1
                bild.DrawString("Winter is coming.", New Font("Arial", 20), New SolidBrush(Color.White), 10, 20)
            Case 2
                bild.DrawString("Hear me roar!", New Font("Arial", 20), New SolidBrush(Color.Crimson), 10, 20)
            Case 3
                bild.DrawString("Fire and Blood.", New Font("Arial", 20), New SolidBrush(Color.Black), 10, 20)
            Case 4
                bild.DrawString("As high as honour.", New Font("Arial", 20), New SolidBrush(Color.White), 10, 20)
            Case 5
                bild.DrawString("Ours is the fury!", New Font("Arial", 20), New SolidBrush(Color.Black), 10, 20)
            Case 6
                bild.DrawString("We do not sow.", New Font("Arial", 20), New SolidBrush(Color.Black), 10, 20)
            Case 7
                bild.DrawString("Unbowed, unbent, unbroken.", New Font("Arial", 16), New SolidBrush(Color.Red), 10, 20)
            Case 8
                bild.DrawString("Family, honour, duty.", New Font("Arial", 20), New SolidBrush(Color.Red), 10, 20)
            Case 9
                bild.DrawString("Growing strong.", New Font("Arial", 20), New SolidBrush(Color.Green), 10, 20)
        End Select
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Randomize()
        rot = (Rnd() * 255)
        blau = (Rnd() * 255)
        gruen = (Rnd() * 255)
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        Call setwind()
        a = Math.Ceiling(Rnd() * 200)
        bild = PictureBox1.CreateGraphics
        x1 = 20
        y1 = 280 - a
        a = Math.Ceiling(Rnd() * 200)
        x2 = 260
        y2 = 280 - a
        bild.FillRectangle(New SolidBrush(Color.FromArgb(200, 230, 255)), 0, 0, 300, 300)
        bild.FillRectangle(New SolidBrush(Color.FromArgb(20, 255, 0)), 0, 300, 300, 10)
        a = Math.Ceiling(Rnd() * 150) + 50
        bild.FillRectangle(New SolidBrush(Color.FromArgb(a, a, a)), x1, y1 + 20, 20, 300 - (y1 + 20))
        a = Math.Ceiling(Rnd() * 150) + 50
        bild.FillRectangle(New SolidBrush(Color.FromArgb(a, a, a)), x2, y2 + 20, 20, 300 - (y2 + 20))
        Call drawguy(h1, x1, y1)
        Call drawguy(h2, x2, y2)
        Call drawflag()
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        xp(0) = x1 + 21
        yp(0) = y1 + 10
        xp(1) = x1 + 21
        yp(1) = y1 + 10
        xp(2) = x1 + 21
        yp(2) = y1 + 10
        flying = True
        Timer1.Enabled = True
        vx = NumericUpDown3.Value * Math.Cos(NumericUpDown1.Value / 180 * Math.PI) / 10
        vy = NumericUpDown3.Value * Math.Sin(-NumericUpDown1.Value / 180 * Math.PI) / 10
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        xp(0) = xp(1)
        yp(0) = yp(1)
        xp(1) = xp(2)
        yp(1) = yp(2)
        xp(2) += vx
        yp(2) += vy
        vy += 0.2
        vx += wind
        bild.DrawLine(New Pen(Color.Brown), xp(2), yp(2), xp(1), yp(1))
        bild.DrawLine(New Pen(Color.FromArgb(200, 230, 255)), xp(1), yp(1), xp(0), yp(0))
        Call drawflag()
        If xp(2) > 310 Or xp(2) <= -10 Or yp(2) >= 300 Then
            flying = False
            Timer1.Enabled = False
            Call setwind()
            Call drawflag()
        End If
        If xp(2) > x1 And xp(2) <= x1 + 20 And yp(2) >= y1 + 20 Then
            flying = False
            Timer1.Enabled = False
            Call setwind()
            Call drawflag()
        End If
        If xp(2) > x2 And xp(2) <= x2 + 20 And yp(2) >= y2 + 20 Then
            flying = False
            Timer1.Enabled = False
            Call setwind()
            Call drawflag()
        End If
        If xp(2) >= x2 And xp(2) < x2 + 20 And yp(2) >= y2 And yp(2) < y2 + 20 Then
            flying = False
            Timer1.Enabled = False
            Button3.Enabled = False
            Call win(h1)
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
        End If
        If xp(2) >= x1 And xp(2) < x1 + 20 And yp(2) >= y1 And yp(2) < y1 + 20 Then
            flying = False
            Timer1.Enabled = False
            Button2.Enabled = False
            Call win(h2)
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        xp(0) = x2 - 1
        yp(0) = y2 + 10
        xp(1) = x2 - 1
        yp(1) = y2 + 10
        xp(2) = x2 - 1
        yp(2) = y2 + 10
        flying = True
        Timer1.Enabled = True
        vx = -NumericUpDown4.Value * Math.Cos(NumericUpDown2.Value / 180 * Math.PI) / 10
        vy = NumericUpDown4.Value * Math.Sin(-NumericUpDown2.Value / 180 * Math.PI) / 10
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        h1 = 1
        h2 = 2
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Stark"
                h1 = 1
            Case "Lannister"
                h1 = 2
            Case "Targaryen"
                h1 = 3
            Case "Arryn"
                h1 = 4
            Case "Baratheon"
                h1 = 5
            Case "Greyjoy"
                h1 = 6
            Case "Martell"
                h1 = 7
            Case "Tully"
                h1 = 8
            Case "Tyrell"
                h1 = 9
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Stark"
                h2 = 1
            Case "Lannister"
                h2 = 2
            Case "Targaryen"
                h2 = 3
            Case "Arryn"
                h2 = 4
            Case "Baratheon"
                h2 = 5
            Case "Greyjoy"
                h2 = 6
            Case "Martell"
                h2 = 7
            Case "Tully"
                h2 = 8
            Case "Tyrell"
                h2 = 9
        End Select
    End Sub
End Class
