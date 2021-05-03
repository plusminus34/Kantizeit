Public Class VierDreh
    Dim x(60) As Single
    Dim y(60) As Single
    Dim z(60) As Single
    Dim w(60) As Single
    Dim x_j(60) As Single
    Dim y_j(60) As Single
    Dim z_j(60) As Single
    Dim w_j(60) As Single
    Dim vis_x(60) As Single
    Dim vis_y(60) As Single
    Dim line_a(150) As Integer
    Dim line_b(150) As Integer
    Dim there(150) As Boolean
    Dim red(150) As Integer
    Dim green(150) As Integer
    Dim blue(150) As Integer
    Dim p As Single
    Dim g As Graphics
    Dim ofd As New SaveFileDialog
    Dim dfo As New OpenFileDialog

    Private Sub Button1_Click(ByVal sender As System.Object,
                              ByVal e As System.EventArgs) Handles Button_Start.Click
        Timer.Enabled = True
        For i = 0 To 60
            x_j(i) = x(i)
            y_j(i) = y(i)
            z_j(i) = z(i)
            w_j(i) = w(i)
        Next
        g = PictureBox_Bild.CreateGraphics
        g.TranslateTransform(200, 200)
        g.ScaleTransform(1, -1)
        Call play()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        For i = 0 To 60
            ' ZW /   um XY
            p = z_j(i)
            z_j(i) = p * Math.Cos(TextBox_XY.Text * Math.PI / 180) + w_j(i) * Math.Sin(TextBox_XY.Text * Math.PI / 180)
            w_j(i) = -p * Math.Sin(TextBox_XY.Text * Math.PI / 180) + w_j(i) * Math.Cos(TextBox_XY.Text * Math.PI / 180)
            ' YW /   um XZ
            p = y_j(i)
            y_j(i) = p * Math.Cos(TextBox_XZ.Text * Math.PI / 180) + w_j(i) * Math.Sin(TextBox_XZ.Text * Math.PI / 180)
            w_j(i) = -p * Math.Sin(TextBox_XZ.Text * Math.PI / 180) + w_j(i) * Math.Cos(TextBox_XZ.Text * Math.PI / 180)
            ' YZ /   um XW
            p = y_j(i)
            y_j(i) = p * Math.Cos(TextBox_XW.Text * Math.PI / 180) - z_j(i) * Math.Sin(TextBox_XW.Text * Math.PI / 180)
            z_j(i) = p * Math.Sin(TextBox_XW.Text * Math.PI / 180) + z_j(i) * Math.Cos(TextBox_XW.Text * Math.PI / 180)
            ' XW /   um YZ
            p = x_j(i)
            x_j(i) = p * Math.Cos(TextBox_YZ.Text * Math.PI / 180) - w_j(i) * Math.Sin(TextBox_YZ.Text * Math.PI / 180)
            w_j(i) = p * Math.Sin(TextBox_YZ.Text * Math.PI / 180) + w_j(i) * Math.Cos(TextBox_YZ.Text * Math.PI / 180)
            ' XZ /   um YW
            p = x_j(i)
            x_j(i) = p * Math.Cos(TextBox_YW.Text * Math.PI / 180) + z_j(i) * Math.Sin(TextBox_YW.Text * Math.PI / 180)
            z_j(i) = -p * Math.Sin(TextBox_YW.Text * Math.PI / 180) + z_j(i) * Math.Cos(TextBox_YW.Text * Math.PI / 180)
            ' XY /   um ZW
            p = x_j(i)
            x_j(i) = p * Math.Cos(TextBox_ZW.Text * Math.PI / 180) - y_j(i) * Math.Sin(TextBox_ZW.Text * Math.PI / 180)
            y_j(i) = p * Math.Sin(TextBox_ZW.Text * Math.PI / 180) + y_j(i) * Math.Cos(TextBox_ZW.Text * Math.PI / 180)

            vis_x(i) = x_j(i) + TextBox_ZinX.Text * z_j(i) + TextBox_Winx.Text * w_j(i)
            vis_y(i) = y_j(i) + TextBox_ZinY.Text * z_j(i) + TextBox_WinY.Text * w_j(i)
        Next
        g.Clear(Color.White)
        For i = 0 To 150
            If there(i) = True Then
                g.DrawLine(New Pen(Color.FromArgb(red(i), green(i), blue(i))), vis_x(line_a(i)), vis_y(line_a(i)), vis_x(line_b(i)), vis_y(line_b(i)))
            End If
        Next
        'Momentan ausgewählter Punkt und momentan ausgewählte Verbindung
        g.FillEllipse(New SolidBrush(Color.FromArgb(255, 0, 255)), vis_x(NumericUpDown_Punkt.Value) - 2, vis_y(NumericUpDown_Punkt.Value) - 2, 5, 5)
        g.DrawLine(New Pen(Color.FromArgb(red(NumericUpDown_Verbindung.Value), green(NumericUpDown_Verbindung.Value), blue(NumericUpDown_Verbindung.Value)), 2), vis_x(line_a(NumericUpDown_Verbindung.Value)), vis_y(line_a(NumericUpDown_Verbindung.Value)), vis_x(line_b(NumericUpDown_Verbindung.Value)), vis_y(line_b(NumericUpDown_Verbindung.Value)))
    End Sub

    Sub pause()
        Timer.Enabled = False
        TextBox_ZW.Enabled = True
        TextBox_YW.Enabled = True
        TextBox_YZ.Enabled = True
        TextBox_Xpos.Enabled = True
        TextBox_Ypos.Enabled = True
        TextBox_Zpos.Enabled = True
        TextBox_Wpos.Enabled = True
        TextBox_XW.Enabled = True
        TextBox_XZ.Enabled = True
        TextBox_XY.Enabled = True
        TextBox_ZinX.Enabled = True
        TextBox_ZinY.Enabled = True
        TextBox_Winx.Enabled = True
        TextBox_WinY.Enabled = True
        NumericUpDown_LineA.Enabled = True
        NumericUpDown_LineB.Enabled = True
        NumericUpDown_Zeit.Enabled = True
        Button_PauseWeiter.Text = "Weiter"
    End Sub

    Sub play()
        Timer.Enabled = True
        TextBox_ZW.Enabled = False
        TextBox_YW.Enabled = False
        TextBox_YZ.Enabled = False
        TextBox_Xpos.Enabled = False
        TextBox_Ypos.Enabled = False
        TextBox_Zpos.Enabled = False
        TextBox_Wpos.Enabled = False
        TextBox_XW.Enabled = False
        TextBox_XZ.Enabled = False
        TextBox_XY.Enabled = False
        TextBox_ZinX.Enabled = False
        TextBox_ZinY.Enabled = False
        TextBox_Winx.Enabled = False
        TextBox_WinY.Enabled = False
        NumericUpDown_LineA.Enabled = False
        NumericUpDown_LineB.Enabled = False
        NumericUpDown_Zeit.Enabled = False
        Button_PauseWeiter.Text = "Pause"
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown_Punkt.ValueChanged
        TextBox_Xpos.Text = x(NumericUpDown_Punkt.Value)
        TextBox_Ypos.Text = y(NumericUpDown_Punkt.Value)
        TextBox_Zpos.Text = z(NumericUpDown_Punkt.Value)
        TextBox_Wpos.Text = w(NumericUpDown_Punkt.Value)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 0 To 60
            x(i) = 0
            y(i) = 0
            z(i) = 0
            w(i) = 0
        Next
        For i = 0 To 150
            line_a(i) = 0
            line_b(i) = 0
            there(i) = False
            red(i) = 0
            green(i) = 0
            blue(i) = 0
        Next
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Xpos.TextChanged
        If TextBox_Xpos.Text.Length = 0 Then
            TextBox_Xpos.Text = "0"
        End If
        x(NumericUpDown_Punkt.Value) = TextBox_Xpos.Text
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Ypos.TextChanged
        If TextBox_Ypos.Text.Length = 0 Then
            TextBox_Ypos.Text = "0"
        End If
        y(NumericUpDown_Punkt.Value) = TextBox_Ypos.Text
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Zpos.TextChanged
        If TextBox_Zpos.Text.Length = 0 Then
            TextBox_Zpos.Text = "0"
        End If
        z(NumericUpDown_Punkt.Value) = TextBox_Zpos.Text
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Wpos.TextChanged
        If TextBox_Wpos.Text.Length = 0 Then
            TextBox_Wpos.Text = "0"
        End If
        w(NumericUpDown_Punkt.Value) = TextBox_Wpos.Text
    End Sub

    'Verbindungen
    Private Sub NumericUpDown2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown_Verbindung.ValueChanged
        NumericUpDown_LineA.Value = line_a(NumericUpDown_Verbindung.Value)
        NumericUpDown_LineB.Value = line_b(NumericUpDown_Verbindung.Value)
        NumericUpDown_Rot.Value = red(NumericUpDown_Verbindung.Value)
        NumericUpDown_Gruen.Value = green(NumericUpDown_Verbindung.Value)
        NumericUpDown_Blau.Value = blue(NumericUpDown_Verbindung.Value)
        PictureBox_Farbvorschau.BackColor = Color.FromArgb(NumericUpDown_Rot.Value, NumericUpDown_Gruen.Value, NumericUpDown_Blau.Value)
        CheckBox_There.Checked = there(NumericUpDown_Verbindung.Value)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_There.CheckedChanged
        there(NumericUpDown_Verbindung.Value) = CheckBox_There.Checked
    End Sub

    Private Sub NumericUpDown4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown_LineB.ValueChanged
        line_b(NumericUpDown_Verbindung.Value) = NumericUpDown_LineB.Value
    End Sub

    Private Sub NumericUpDown3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown_LineA.ValueChanged
        line_a(NumericUpDown_Verbindung.Value) = NumericUpDown_LineA.Value
    End Sub

    Private Sub NumericUpDown5_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown_Rot.ValueChanged
        red(NumericUpDown_Verbindung.Value) = NumericUpDown_Rot.Value
        PictureBox_Farbvorschau.BackColor = Color.FromArgb(NumericUpDown_Rot.Value, NumericUpDown_Gruen.Value, NumericUpDown_Blau.Value)
    End Sub

    Private Sub NumericUpDown6_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown_Gruen.ValueChanged
        green(NumericUpDown_Verbindung.Value) = NumericUpDown_Gruen.Value
        PictureBox_Farbvorschau.BackColor = Color.FromArgb(NumericUpDown_Rot.Value, NumericUpDown_Gruen.Value, NumericUpDown_Blau.Value)
    End Sub

    Private Sub NumericUpDown7_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown_Blau.ValueChanged
        blue(NumericUpDown_Verbindung.Value) = NumericUpDown_Blau.Value
        PictureBox_Farbvorschau.BackColor = Color.FromArgb(NumericUpDown_Rot.Value, NumericUpDown_Gruen.Value, NumericUpDown_Blau.Value)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_PauseWeiter.Click
        If Timer.Enabled = True Then
            Call pause()
        Else
            Call play()
        End If
    End Sub

    ' Speichern und Laden
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Speichern.Click
        Dim path As String
        If ofd.ShowDialog() = DialogResult.OK Then
            path = ofd.FileName & ".txt"


            Dim sw As System.IO.StreamWriter = IO.File.CreateText(path)
            For i = 0 To 60
                sw.WriteLine(x(i))
                sw.WriteLine(y(i))
                sw.WriteLine(z(i))
                sw.WriteLine(w(i))
            Next
            For i = 0 To 150
                sw.WriteLine(line_a(i))
                sw.WriteLine(line_b(i))
                sw.WriteLine(there(i))
                sw.WriteLine(red(i))
                sw.WriteLine(green(i))
                sw.WriteLine(blue(i))
            Next
            sw.WriteLine(TextBox_ZinX.Text)
            sw.WriteLine(TextBox_ZinY.Text)
            sw.WriteLine(TextBox_Winx.Text)
            sw.WriteLine(TextBox_WinY.Text)
            sw.Close()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Laden.Click
        Dim path As String
        If dfo.ShowDialog() = DialogResult.OK Then
            path = dfo.FileName

            Dim sr As System.IO.StreamReader = IO.File.OpenText(path)
            For i = 0 To 60
                x(i) = sr.ReadLine
                y(i) = sr.ReadLine
                z(i) = sr.ReadLine
                w(i) = sr.ReadLine
            Next
            For i = 0 To 150
                line_a(i) = sr.ReadLine
                line_b(i) = sr.ReadLine
                there(i) = sr.ReadLine
                red(i) = sr.ReadLine
                green(i) = sr.ReadLine
                blue(i) = sr.ReadLine
            Next
            TextBox_ZinX.Text = sr.ReadLine
            TextBox_ZinY.Text = sr.ReadLine
            TextBox_Winx.Text = sr.ReadLine
            TextBox_WinY.Text = sr.ReadLine
            sr.Close()
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Formen.Click
        If Button_Formen.Text = "Vorlagen" Then
            Button_Tesserakt.Visible = True
            Button_Pentachoron.Visible = True
            Button_Wuerfel.Visible = True
            Button_Tetraeder.Visible = True
            Button_Quadrat.Visible = True
            Button_Dreieck.Visible = True
            Button_Formen.Text = "Schliessen"
        Else
            Button_Tesserakt.Visible = False
            Button_Pentachoron.Visible = False
            Button_Wuerfel.Visible = False
            Button_Tetraeder.Visible = False
            Button_Quadrat.Visible = False
            Button_Dreieck.Visible = False
            Button_Formen.Text = "Vorlagen"
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Tesserakt.Click
        For i = 0 To 60
            x(i) = 0
            y(i) = 0
            z(i) = 0
            w(i) = 0
        Next
        For i = 0 To 150
            line_a(i) = 0
            line_b(i) = 0
            there(i) = False
            red(i) = 0
            green(i) = 0
            blue(i) = 0
        Next
        'Tesserakt, Mittelpunkt im Ursprung, Seitenlänge 200
        x(1) = 100
        y(1) = 100
        z(1) = 100
        w(1) = 100

        x(2) = -100
        y(2) = 100
        z(2) = 100
        w(2) = 100

        x(3) = 100
        y(3) = -100
        z(3) = 100
        w(3) = 100

        x(4) = 100
        y(4) = 100
        z(4) = -100
        w(4) = 100

        x(5) = 100
        y(5) = 100
        z(5) = 100
        w(5) = -100

        x(6) = -100
        y(6) = -100
        z(6) = 100
        w(6) = 100

        x(7) = -100
        y(7) = 100
        z(7) = -100
        w(7) = 100

        x(8) = -100
        y(8) = 100
        z(8) = 100
        w(8) = -100

        x(9) = -100
        y(9) = -100
        z(9) = -100
        w(9) = 100

        x(10) = -100
        y(10) = -100
        z(10) = 100
        w(10) = -100

        x(11) = -100
        y(11) = 100
        z(11) = -100
        w(11) = -100

        x(12) = -100
        y(12) = -100
        z(12) = -100
        w(12) = -100

        x(13) = 100
        y(13) = 100
        z(13) = -100
        w(13) = -100

        x(14) = 100
        y(14) = -100
        z(14) = 100
        w(14) = -100

        x(15) = 100
        y(15) = -100
        z(15) = -100
        w(15) = 100

        x(16) = 100
        y(16) = -100
        z(16) = -100
        w(16) = -100

        line_a(1) = 1
        line_b(1) = 2
        there(1) = True
        line_a(2) = 1
        line_b(2) = 3
        there(2) = True
        line_a(3) = 1
        line_b(3) = 4
        there(3) = True
        line_a(4) = 1
        line_b(4) = 5
        there(4) = True

        line_a(5) = 3
        line_b(5) = 15
        there(5) = True
        line_a(6) = 3
        line_b(6) = 6
        there(6) = True
        line_a(7) = 3
        line_b(7) = 14
        there(7) = True

        line_a(8) = 6
        line_b(8) = 2
        there(8) = True
        line_a(9) = 6
        line_b(9) = 9
        there(9) = True
        line_a(10) = 6
        line_b(10) = 10
        there(10) = True

        line_a(11) = 2
        line_b(11) = 7
        there(11) = True
        line_a(12) = 2
        line_b(12) = 8
        there(12) = True

        line_a(13) = 4
        line_b(13) = 15
        there(13) = True
        line_a(14) = 4
        line_b(14) = 7
        there(14) = True
        line_a(15) = 4
        line_b(15) = 13
        there(15) = True

        line_a(16) = 15
        line_b(16) = 9
        there(16) = True
        line_a(17) = 15
        line_b(17) = 16
        there(17) = True

        line_a(18) = 9
        line_b(18) = 7
        there(18) = True
        line_a(19) = 9
        line_b(19) = 12
        there(19) = True

        line_a(20) = 7
        line_b(20) = 11
        there(20) = True

        line_a(21) = 5
        line_b(21) = 14
        there(21) = True
        line_a(22) = 5
        line_b(22) = 8
        there(22) = True
        line_a(23) = 5
        line_b(23) = 13
        there(23) = True

        line_a(24) = 14
        line_b(24) = 10
        there(24) = True
        line_a(25) = 14
        line_b(25) = 16
        there(25) = True

        line_a(26) = 10
        line_b(26) = 8
        there(26) = True
        line_a(27) = 10
        line_b(27) = 12
        there(27) = True

        line_a(28) = 8
        line_b(28) = 11
        there(28) = True

        line_a(29) = 13
        line_b(29) = 16
        there(29) = True
        line_a(30) = 13
        line_b(30) = 11
        there(30) = True

        line_a(31) = 16
        line_b(31) = 12
        there(31) = True

        line_a(32) = 12
        line_b(32) = 11
        there(32) = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Pentachoron.Click
        For i = 0 To 60
            x(i) = 0
            y(i) = 0
            z(i) = 0
            w(i) = 0
        Next
        For i = 0 To 150
            line_a(i) = 0
            line_b(i) = 0
            there(i) = False
            red(i) = 0
            green(i) = 0
            blue(i) = 0
        Next
        ' Pentachoron, Mittelpunkt im Ursprung, Seitenlänge 200
        x(1) = 100
        y(1) = -57.735026918965
        z(1) = -40.824829046387
        w(1) = -63.245553203367

        x(2) = -100
        y(2) = -57.735026918965
        z(2) = -40.824829046387
        w(2) = -63.245553203367

        x(3) = 0
        y(3) = 115.47005383793
        z(3) = -40.824829046387
        w(3) = -63.245553203367

        x(4) = 0
        y(4) = 0
        z(4) = 122.47448713916
        w(4) = -63.245553203367

        x(5) = 0
        y(5) = 0
        z(5) = 0
        w(5) = 94.868329805053

        line_a(1) = 1
        line_b(1) = 2
        there(1) = True

        line_a(2) = 1
        line_b(2) = 3
        there(2) = True

        line_a(3) = 1
        line_b(3) = 4
        there(3) = True

        line_a(4) = 1
        line_b(4) = 5
        there(4) = True

        line_a(5) = 2
        line_b(5) = 3
        there(5) = True

        line_a(6) = 2
        line_b(6) = 4
        there(6) = True

        line_a(7) = 2
        line_b(7) = 5
        there(7) = True

        line_a(8) = 3
        line_b(8) = 4
        there(8) = True

        line_a(9) = 3
        line_b(9) = 5
        there(9) = True

        line_a(10) = 4
        line_b(10) = 5
        there(10) = True
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Tetraeder.Click
        For i = 0 To 60
            x(i) = 0
            y(i) = 0
            z(i) = 0
            w(i) = 0
        Next
        For i = 0 To 150
            line_a(i) = 0
            line_b(i) = 0
            there(i) = False
            red(i) = 0
            green(i) = 0
            blue(i) = 0
        Next
        ' Tetraeder, Seitenlänge 200, Mittelpunkt im Ursprung, DIESMAL RICHTIG!
        x(1) = 100
        y(1) = -57.735026918965
        z(1) = -40.824829046387
        w(1) = 0    'der ist nur dreidimensional

        x(2) = -100
        y(2) = -57.735026918965
        z(2) = -40.824829046387
        w(2) = 0

        x(3) = 0
        y(3) = 115.47005383793
        z(3) = -40.824829046387
        w(3) = 0

        x(4) = 0
        y(4) = 0
        z(4) = 122.47448713916
        w(4) = 0

        line_a(1) = 1
        line_b(1) = 2
        there(1) = True

        line_a(2) = 1
        line_b(2) = 3
        there(2) = True

        line_a(3) = 1
        line_b(3) = 4
        there(3) = True

        line_a(4) = 2
        line_b(4) = 3
        there(4) = True

        line_a(5) = 2
        line_b(5) = 4
        there(5) = True

        line_a(6) = 3
        line_b(6) = 4
        there(6) = True
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Dreieck.Click

        For i = 0 To 60
            x(i) = 0
            y(i) = 0
            z(i) = 0
            w(i) = 0
        Next
        For i = 0 To 150
            line_a(i) = 0
            line_b(i) = 0
            there(i) = False
            red(i) = 0
            green(i) = 0
            blue(i) = 0
        Next
        ' Gleichseitiges Dreieck
        x(1) = 100
        y(1) = -57.735026918965
        z(1) = 0
        w(1) = 0

        x(2) = -100
        y(2) = -57.735026918965
        z(2) = 0
        w(2) = 0

        x(3) = 0
        y(3) = 115.47005383793
        z(3) = 0
        w(3) = 0

        line_a(1) = 1
        line_b(1) = 2
        there(1) = True

        line_a(2) = 1
        line_b(2) = 3
        there(2) = True

        line_a(3) = 2
        line_b(3) = 3
        there(3) = True
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Wuerfel.Click
        For i = 0 To 60
            x(i) = 0
            y(i) = 0
            z(i) = 0
            w(i) = 0
        Next
        For i = 0 To 150
            line_a(i) = 0
            line_b(i) = 0
            there(i) = False
            red(i) = 0
            green(i) = 0
            blue(i) = 0
        Next
        'Würfel, Mittelpunkt im Ursprung, Seitenlänge 200
        x(1) = 100
        y(1) = 100
        z(1) = 100
        w(1) = 0

        x(2) = -100
        y(2) = 100
        z(2) = 100
        w(2) = 0

        x(3) = 100
        y(3) = -100
        z(3) = 100
        w(3) = 0

        x(4) = 100
        y(4) = 100
        z(4) = -100
        w(4) = 0

        x(5) = -100
        y(5) = -100
        z(5) = 100
        w(5) = 0

        x(6) = 100
        y(6) = -100
        z(6) = -100
        w(6) = 0

        x(7) = -100
        y(7) = 100
        z(7) = -100
        w(7) = 0

        x(8) = -100
        y(8) = -100
        z(8) = -100
        w(8) = 0

        line_a(1) = 1
        line_b(1) = 2
        there(1) = True

        line_a(2) = 1
        line_b(2) = 3
        there(2) = True

        line_a(3) = 1
        line_b(3) = 4
        there(3) = True

        line_a(4) = 2
        line_b(4) = 5
        there(4) = True

        line_a(5) = 2
        line_b(5) = 7
        there(5) = True

        line_a(6) = 3
        line_b(6) = 5
        there(6) = True

        line_a(7) = 3
        line_b(7) = 6
        there(7) = True

        line_a(8) = 4
        line_b(8) = 6
        there(8) = True

        line_a(9) = 4
        line_b(9) = 7
        there(9) = True

        line_a(10) = 5
        line_b(10) = 8
        there(10) = True

        line_a(11) = 6
        line_b(11) = 8
        there(11) = True

        line_a(12) = 7
        line_b(12) = 8
        there(12) = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Quadrat.Click
        For i = 0 To 60
            x(i) = 0
            y(i) = 0
            z(i) = 0
            w(i) = 0
        Next
        For i = 0 To 150
            line_a(i) = 0
            line_b(i) = 0
            there(i) = False
            red(i) = 0
            green(i) = 0
            blue(i) = 0
        Next
        'Quadrat, Mittelpunkt im Ursprung, Seitenlänge 200
        x(1) = 100
        y(1) = 100
        z(1) = 0
        w(1) = 0

        x(2) = -100
        y(2) = 100
        z(2) = 0
        w(2) = 0

        x(3) = 100
        y(3) = -100
        z(3) = 0
        w(3) = 0

        x(4) = -100
        y(4) = -100
        z(4) = 0
        w(4) = 0

        line_a(1) = 1
        line_b(1) = 2
        there(1) = True

        line_a(2) = 1
        line_b(2) = 3
        there(2) = True

        line_a(3) = 2
        line_b(3) = 4
        there(3) = True

        line_a(4) = 3
        line_b(4) = 4
        there(4) = True
    End Sub

    Private Sub NumericUpDown8_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown_Zeit.ValueChanged
        Timer.Interval = NumericUpDown_Zeit.Value
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                                        Handles TextBox_ZW.KeyPress

        If "1234567890.-".Contains(e.KeyChar) = False And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                                        Handles TextBox_YW.KeyPress

        If "1234567890.-".Contains(e.KeyChar) = False And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                                        Handles TextBox_YZ.KeyPress

        If "1234567890.-".Contains(e.KeyChar) = False And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox4_KeyPress(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                                        Handles TextBox_Xpos.KeyPress

        If "1234567890.-".Contains(e.KeyChar) = False And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox5_KeyPress(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                                        Handles TextBox_Ypos.KeyPress

        If "1234567890.-".Contains(e.KeyChar) = False And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox6_KeyPress(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                                        Handles TextBox_Zpos.KeyPress

        If "1234567890.-".Contains(e.KeyChar) = False And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox7_KeyPress(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                                        Handles TextBox_Wpos.KeyPress

        If "1234567890.-".Contains(e.KeyChar) = False And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox8_KeyPress(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                                        Handles TextBox_XW.KeyPress

        If "1234567890.-".Contains(e.KeyChar) = False And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox9_KeyPress(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                                        Handles TextBox_XZ.KeyPress

        If "1234567890.-".Contains(e.KeyChar) = False And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox10_KeyPress(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                                        Handles TextBox_XY.KeyPress

        If "1234567890.-".Contains(e.KeyChar) = False And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox11_KeyPress(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                                        Handles TextBox_ZinX.KeyPress

        If "1234567890.-".Contains(e.KeyChar) = False And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox12_KeyPress(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                                        Handles TextBox_ZinY.KeyPress

        If "1234567890.-".Contains(e.KeyChar) = False And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox13_KeyPress(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                                        Handles TextBox_Winx.KeyPress

        If "1234567890.-".Contains(e.KeyChar) = False And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox14_KeyPress(ByVal sender As Object, _
                                ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                                        Handles TextBox_WinY.KeyPress

        If "1234567890.-".Contains(e.KeyChar) = False And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_ZW.TextChanged
        If TextBox_ZW.Text.Length = 0 Then
            TextBox_ZW.Text = "0"
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_YW.TextChanged
        If TextBox_YW.Text.Length = 0 Then
            TextBox_YW.Text = "0"
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_YZ.TextChanged
        If TextBox_YZ.Text.Length = 0 Then
            TextBox_YZ.Text = "0"
        End If
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_XW.TextChanged
        If TextBox_XW.Text.Length = 0 Then
            TextBox_XW.Text = "0"
        End If
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_XZ.TextChanged
        If TextBox_XZ.Text.Length = 0 Then
            TextBox_XZ.Text = "0"
        End If
    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_XY.TextChanged
        If TextBox_XY.Text.Length = 0 Then
            TextBox_XY.Text = "0"
        End If
    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_ZinX.TextChanged
        If TextBox_ZinX.Text.Length = 0 Then
            TextBox_ZinX.Text = "0"
        End If
    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_ZinY.TextChanged
        If TextBox_ZinY.Text.Length = 0 Then
            TextBox_ZinY.Text = "0"
        End If
    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Winx.TextChanged
        If TextBox_Winx.Text.Length = 0 Then
            TextBox_Winx.Text = "0"
        End If
    End Sub

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_WinY.TextChanged
        If TextBox_WinY.Text.Length = 0 Then
            TextBox_WinY.Text = "0"
        End If
    End Sub
End Class
