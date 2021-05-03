<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VierDreh
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox_Bild = New System.Windows.Forms.PictureBox()
        Me.TextBox_ZW = New System.Windows.Forms.TextBox()
        Me.TextBox_YW = New System.Windows.Forms.TextBox()
        Me.TextBox_YZ = New System.Windows.Forms.TextBox()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.NumericUpDown_Punkt = New System.Windows.Forms.NumericUpDown()
        Me.TextBox_Xpos = New System.Windows.Forms.TextBox()
        Me.TextBox_Ypos = New System.Windows.Forms.TextBox()
        Me.TextBox_Zpos = New System.Windows.Forms.TextBox()
        Me.NumericUpDown_Verbindung = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_LineA = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_LineB = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_There = New System.Windows.Forms.CheckBox()
        Me.TextBox_Wpos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_XW = New System.Windows.Forms.TextBox()
        Me.TextBox_XZ = New System.Windows.Forms.TextBox()
        Me.TextBox_XY = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown_Rot = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Gruen = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_Blau = New System.Windows.Forms.NumericUpDown()
        Me.Button_Tesserakt = New System.Windows.Forms.Button()
        Me.TextBox_ZinX = New System.Windows.Forms.TextBox()
        Me.TextBox_ZinY = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_Winx = New System.Windows.Forms.TextBox()
        Me.TextBox_WinY = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button_PauseWeiter = New System.Windows.Forms.Button()
        Me.Button_Speichern = New System.Windows.Forms.Button()
        Me.Button_Laden = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button_Pentachoron = New System.Windows.Forms.Button()
        Me.Button_Wuerfel = New System.Windows.Forms.Button()
        Me.Button_Tetraeder = New System.Windows.Forms.Button()
        Me.Button_Quadrat = New System.Windows.Forms.Button()
        Me.Button_Dreieck = New System.Windows.Forms.Button()
        Me.Button_Formen = New System.Windows.Forms.Button()
        Me.NumericUpDown_Zeit = New System.Windows.Forms.NumericUpDown()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PictureBox_Farbvorschau = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox_Bild, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Punkt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Verbindung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_LineA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_LineB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Rot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Gruen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Blau, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Zeit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Farbvorschau, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox_Bild
        '
        Me.PictureBox_Bild.BackColor = System.Drawing.Color.White
        Me.PictureBox_Bild.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox_Bild.Name = "PictureBox_Bild"
        Me.PictureBox_Bild.Size = New System.Drawing.Size(400, 400)
        Me.PictureBox_Bild.TabIndex = 0
        Me.PictureBox_Bild.TabStop = False
        '
        'TextBox_ZW
        '
        Me.TextBox_ZW.Location = New System.Drawing.Point(418, 245)
        Me.TextBox_ZW.Name = "TextBox_ZW"
        Me.TextBox_ZW.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_ZW.TabIndex = 1
        Me.TextBox_ZW.Text = "0"
        '
        'TextBox_YW
        '
        Me.TextBox_YW.Location = New System.Drawing.Point(418, 206)
        Me.TextBox_YW.Name = "TextBox_YW"
        Me.TextBox_YW.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_YW.TabIndex = 2
        Me.TextBox_YW.Text = "0"
        '
        'TextBox_YZ
        '
        Me.TextBox_YZ.Location = New System.Drawing.Point(418, 167)
        Me.TextBox_YZ.Name = "TextBox_YZ"
        Me.TextBox_YZ.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_YZ.TabIndex = 3
        Me.TextBox_YZ.Text = "0"
        '
        'Button_Start
        '
        Me.Button_Start.Location = New System.Drawing.Point(547, 389)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(75, 23)
        Me.Button_Start.TabIndex = 4
        Me.Button_Start.Text = "Start"
        Me.Button_Start.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Interval = 10
        '
        'NumericUpDown_Punkt
        '
        Me.NumericUpDown_Punkt.Location = New System.Drawing.Point(581, 131)
        Me.NumericUpDown_Punkt.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumericUpDown_Punkt.Name = "NumericUpDown_Punkt"
        Me.NumericUpDown_Punkt.Size = New System.Drawing.Size(122, 20)
        Me.NumericUpDown_Punkt.TabIndex = 6
        '
        'TextBox_Xpos
        '
        Me.TextBox_Xpos.Location = New System.Drawing.Point(603, 157)
        Me.TextBox_Xpos.Name = "TextBox_Xpos"
        Me.TextBox_Xpos.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Xpos.TabIndex = 7
        Me.TextBox_Xpos.Text = "0"
        '
        'TextBox_Ypos
        '
        Me.TextBox_Ypos.Location = New System.Drawing.Point(603, 183)
        Me.TextBox_Ypos.Name = "TextBox_Ypos"
        Me.TextBox_Ypos.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Ypos.TabIndex = 8
        Me.TextBox_Ypos.Text = "0"
        '
        'TextBox_Zpos
        '
        Me.TextBox_Zpos.Location = New System.Drawing.Point(603, 209)
        Me.TextBox_Zpos.Name = "TextBox_Zpos"
        Me.TextBox_Zpos.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Zpos.TabIndex = 9
        Me.TextBox_Zpos.Text = "0"
        '
        'NumericUpDown_Verbindung
        '
        Me.NumericUpDown_Verbindung.Location = New System.Drawing.Point(823, 131)
        Me.NumericUpDown_Verbindung.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.NumericUpDown_Verbindung.Name = "NumericUpDown_Verbindung"
        Me.NumericUpDown_Verbindung.Size = New System.Drawing.Size(122, 20)
        Me.NumericUpDown_Verbindung.TabIndex = 10
        '
        'NumericUpDown_LineA
        '
        Me.NumericUpDown_LineA.Location = New System.Drawing.Point(823, 183)
        Me.NumericUpDown_LineA.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDown_LineA.Name = "NumericUpDown_LineA"
        Me.NumericUpDown_LineA.Size = New System.Drawing.Size(122, 20)
        Me.NumericUpDown_LineA.TabIndex = 11
        '
        'NumericUpDown_LineB
        '
        Me.NumericUpDown_LineB.Location = New System.Drawing.Point(823, 209)
        Me.NumericUpDown_LineB.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDown_LineB.Name = "NumericUpDown_LineB"
        Me.NumericUpDown_LineB.Size = New System.Drawing.Size(122, 20)
        Me.NumericUpDown_LineB.TabIndex = 12
        '
        'CheckBox_There
        '
        Me.CheckBox_There.AutoSize = True
        Me.CheckBox_There.Location = New System.Drawing.Point(823, 160)
        Me.CheckBox_There.Name = "CheckBox_There"
        Me.CheckBox_There.Size = New System.Drawing.Size(63, 17)
        Me.CheckBox_There.TabIndex = 13
        Me.CheckBox_There.Text = "sichtbar"
        Me.CheckBox_There.UseVisualStyleBackColor = True
        '
        'TextBox_Wpos
        '
        Me.TextBox_Wpos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.TextBox_Wpos.Location = New System.Drawing.Point(603, 235)
        Me.TextBox_Wpos.Name = "TextBox_Wpos"
        Me.TextBox_Wpos.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Wpos.TabIndex = 14
        Me.TextBox_Wpos.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(418, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "zw-Ebene"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(418, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "yw-Ebene"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(418, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "yz-Ebene"
        '
        'TextBox_XW
        '
        Me.TextBox_XW.Location = New System.Drawing.Point(418, 128)
        Me.TextBox_XW.Name = "TextBox_XW"
        Me.TextBox_XW.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_XW.TabIndex = 18
        Me.TextBox_XW.Text = "0"
        '
        'TextBox_XZ
        '
        Me.TextBox_XZ.Location = New System.Drawing.Point(418, 89)
        Me.TextBox_XZ.Name = "TextBox_XZ"
        Me.TextBox_XZ.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_XZ.TabIndex = 19
        Me.TextBox_XZ.Text = "0"
        '
        'TextBox_XY
        '
        Me.TextBox_XY.Location = New System.Drawing.Point(418, 50)
        Me.TextBox_XY.Name = "TextBox_XY"
        Me.TextBox_XY.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_XY.TabIndex = 20
        Me.TextBox_XY.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(418, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "xw-Ebene"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(418, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "xz-Ebene"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(418, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "xy-Ebene"
        '
        'NumericUpDown_Rot
        '
        Me.NumericUpDown_Rot.BackColor = System.Drawing.Color.Red
        Me.NumericUpDown_Rot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NumericUpDown_Rot.Location = New System.Drawing.Point(823, 235)
        Me.NumericUpDown_Rot.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown_Rot.Name = "NumericUpDown_Rot"
        Me.NumericUpDown_Rot.Size = New System.Drawing.Size(68, 20)
        Me.NumericUpDown_Rot.TabIndex = 24
        Me.NumericUpDown_Rot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumericUpDown_Gruen
        '
        Me.NumericUpDown_Gruen.BackColor = System.Drawing.Color.Lime
        Me.NumericUpDown_Gruen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NumericUpDown_Gruen.Location = New System.Drawing.Point(823, 261)
        Me.NumericUpDown_Gruen.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown_Gruen.Name = "NumericUpDown_Gruen"
        Me.NumericUpDown_Gruen.Size = New System.Drawing.Size(68, 20)
        Me.NumericUpDown_Gruen.TabIndex = 25
        Me.NumericUpDown_Gruen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumericUpDown_Blau
        '
        Me.NumericUpDown_Blau.BackColor = System.Drawing.Color.Blue
        Me.NumericUpDown_Blau.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NumericUpDown_Blau.Location = New System.Drawing.Point(823, 287)
        Me.NumericUpDown_Blau.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown_Blau.Name = "NumericUpDown_Blau"
        Me.NumericUpDown_Blau.Size = New System.Drawing.Size(68, 20)
        Me.NumericUpDown_Blau.TabIndex = 26
        Me.NumericUpDown_Blau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_Tesserakt
        '
        Me.Button_Tesserakt.Location = New System.Drawing.Point(204, 462)
        Me.Button_Tesserakt.Name = "Button_Tesserakt"
        Me.Button_Tesserakt.Size = New System.Drawing.Size(90, 23)
        Me.Button_Tesserakt.TabIndex = 27
        Me.Button_Tesserakt.Text = "Tesserakt"
        Me.Button_Tesserakt.UseVisualStyleBackColor = True
        Me.Button_Tesserakt.Visible = False
        '
        'TextBox_ZinX
        '
        Me.TextBox_ZinX.Location = New System.Drawing.Point(697, 34)
        Me.TextBox_ZinX.Name = "TextBox_ZinX"
        Me.TextBox_ZinX.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_ZinX.TabIndex = 28
        Me.TextBox_ZinX.Text = "0"
        '
        'TextBox_ZinY
        '
        Me.TextBox_ZinY.Location = New System.Drawing.Point(697, 60)
        Me.TextBox_ZinY.Name = "TextBox_ZinY"
        Me.TextBox_ZinY.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_ZinY.TabIndex = 29
        Me.TextBox_ZinY.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(643, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Projektion: 1 z  ->"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(824, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "1 w  ->"
        '
        'TextBox_Winx
        '
        Me.TextBox_Winx.Location = New System.Drawing.Point(827, 34)
        Me.TextBox_Winx.Name = "TextBox_Winx"
        Me.TextBox_Winx.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Winx.TabIndex = 32
        Me.TextBox_Winx.Text = "0"
        '
        'TextBox_WinY
        '
        Me.TextBox_WinY.Location = New System.Drawing.Point(827, 60)
        Me.TextBox_WinY.Name = "TextBox_WinY"
        Me.TextBox_WinY.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_WinY.TabIndex = 31
        Me.TextBox_WinY.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(933, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "x"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(933, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "y"
        '
        'Button_PauseWeiter
        '
        Me.Button_PauseWeiter.Location = New System.Drawing.Point(628, 389)
        Me.Button_PauseWeiter.Name = "Button_PauseWeiter"
        Me.Button_PauseWeiter.Size = New System.Drawing.Size(87, 23)
        Me.Button_PauseWeiter.TabIndex = 36
        Me.Button_PauseWeiter.Text = "Pause/Weiter"
        Me.Button_PauseWeiter.UseVisualStyleBackColor = True
        '
        'Button_Speichern
        '
        Me.Button_Speichern.Location = New System.Drawing.Point(852, 508)
        Me.Button_Speichern.Name = "Button_Speichern"
        Me.Button_Speichern.Size = New System.Drawing.Size(93, 23)
        Me.Button_Speichern.TabIndex = 37
        Me.Button_Speichern.Text = "Speichern"
        Me.Button_Speichern.UseVisualStyleBackColor = True
        '
        'Button_Laden
        '
        Me.Button_Laden.Location = New System.Drawing.Point(852, 537)
        Me.Button_Laden.Name = "Button_Laden"
        Me.Button_Laden.Size = New System.Drawing.Size(93, 23)
        Me.Button_Laden.TabIndex = 39
        Me.Button_Laden.Text = "Öffnen"
        Me.Button_Laden.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(540, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Punkt"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(585, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(12, 13)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "x"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(585, 186)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(12, 13)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "y"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(585, 211)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(12, 13)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "z"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(582, 238)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 13)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "w"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(756, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 13)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Verbindung"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(761, 186)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 13)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "von Punkt"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(768, 212)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "zu Punkt"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(418, 12)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(144, 13)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Drehung (in ° pro Bild) um die"
        '
        'Button_Pentachoron
        '
        Me.Button_Pentachoron.Location = New System.Drawing.Point(204, 491)
        Me.Button_Pentachoron.Name = "Button_Pentachoron"
        Me.Button_Pentachoron.Size = New System.Drawing.Size(90, 23)
        Me.Button_Pentachoron.TabIndex = 49
        Me.Button_Pentachoron.Text = "Pentachoron"
        Me.Button_Pentachoron.UseVisualStyleBackColor = True
        Me.Button_Pentachoron.Visible = False
        '
        'Button_Wuerfel
        '
        Me.Button_Wuerfel.Location = New System.Drawing.Point(108, 462)
        Me.Button_Wuerfel.Name = "Button_Wuerfel"
        Me.Button_Wuerfel.Size = New System.Drawing.Size(90, 23)
        Me.Button_Wuerfel.TabIndex = 50
        Me.Button_Wuerfel.Text = "Würfel"
        Me.Button_Wuerfel.UseVisualStyleBackColor = True
        Me.Button_Wuerfel.Visible = False
        '
        'Button_Tetraeder
        '
        Me.Button_Tetraeder.Location = New System.Drawing.Point(108, 491)
        Me.Button_Tetraeder.Name = "Button_Tetraeder"
        Me.Button_Tetraeder.Size = New System.Drawing.Size(90, 23)
        Me.Button_Tetraeder.TabIndex = 51
        Me.Button_Tetraeder.Text = "Tetraeder"
        Me.Button_Tetraeder.UseVisualStyleBackColor = True
        Me.Button_Tetraeder.Visible = False
        '
        'Button_Quadrat
        '
        Me.Button_Quadrat.Location = New System.Drawing.Point(12, 462)
        Me.Button_Quadrat.Name = "Button_Quadrat"
        Me.Button_Quadrat.Size = New System.Drawing.Size(90, 23)
        Me.Button_Quadrat.TabIndex = 52
        Me.Button_Quadrat.Text = "Quadrat"
        Me.Button_Quadrat.UseVisualStyleBackColor = True
        Me.Button_Quadrat.Visible = False
        '
        'Button_Dreieck
        '
        Me.Button_Dreieck.Location = New System.Drawing.Point(12, 491)
        Me.Button_Dreieck.Name = "Button_Dreieck"
        Me.Button_Dreieck.Size = New System.Drawing.Size(90, 23)
        Me.Button_Dreieck.TabIndex = 53
        Me.Button_Dreieck.Text = "Dreieck"
        Me.Button_Dreieck.UseVisualStyleBackColor = True
        Me.Button_Dreieck.Visible = False
        '
        'Button_Formen
        '
        Me.Button_Formen.Location = New System.Drawing.Point(12, 433)
        Me.Button_Formen.Name = "Button_Formen"
        Me.Button_Formen.Size = New System.Drawing.Size(282, 23)
        Me.Button_Formen.TabIndex = 54
        Me.Button_Formen.Text = "Vorlagen"
        Me.Button_Formen.UseVisualStyleBackColor = True
        '
        'NumericUpDown_Zeit
        '
        Me.NumericUpDown_Zeit.Location = New System.Drawing.Point(588, 320)
        Me.NumericUpDown_Zeit.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown_Zeit.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown_Zeit.Name = "NumericUpDown_Zeit"
        Me.NumericUpDown_Zeit.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown_Zeit.TabIndex = 55
        Me.NumericUpDown_Zeit.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(418, 322)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(164, 13)
        Me.Label20.TabIndex = 56
        Me.Label20.Text = "Zeit (in ms) zwischen zwei Bildern"
        '
        'PictureBox_Farbvorschau
        '
        Me.PictureBox_Farbvorschau.BackColor = System.Drawing.Color.Black
        Me.PictureBox_Farbvorschau.Location = New System.Drawing.Point(897, 235)
        Me.PictureBox_Farbvorschau.Name = "PictureBox_Farbvorschau"
        Me.PictureBox_Farbvorschau.Size = New System.Drawing.Size(48, 72)
        Me.PictureBox_Farbvorschau.TabIndex = 57
        Me.PictureBox_Farbvorschau.TabStop = False
        '
        'VierDreh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 572)
        Me.Controls.Add(Me.PictureBox_Farbvorschau)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.NumericUpDown_Zeit)
        Me.Controls.Add(Me.Button_Formen)
        Me.Controls.Add(Me.Button_Dreieck)
        Me.Controls.Add(Me.Button_Quadrat)
        Me.Controls.Add(Me.Button_Tetraeder)
        Me.Controls.Add(Me.Button_Wuerfel)
        Me.Controls.Add(Me.Button_Pentachoron)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button_Laden)
        Me.Controls.Add(Me.Button_Speichern)
        Me.Controls.Add(Me.Button_PauseWeiter)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox_Winx)
        Me.Controls.Add(Me.TextBox_WinY)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox_ZinY)
        Me.Controls.Add(Me.TextBox_ZinX)
        Me.Controls.Add(Me.Button_Tesserakt)
        Me.Controls.Add(Me.NumericUpDown_Blau)
        Me.Controls.Add(Me.NumericUpDown_Gruen)
        Me.Controls.Add(Me.NumericUpDown_Rot)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_XY)
        Me.Controls.Add(Me.TextBox_XZ)
        Me.Controls.Add(Me.TextBox_XW)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_Wpos)
        Me.Controls.Add(Me.CheckBox_There)
        Me.Controls.Add(Me.NumericUpDown_LineB)
        Me.Controls.Add(Me.NumericUpDown_LineA)
        Me.Controls.Add(Me.NumericUpDown_Verbindung)
        Me.Controls.Add(Me.TextBox_Zpos)
        Me.Controls.Add(Me.TextBox_Ypos)
        Me.Controls.Add(Me.TextBox_Xpos)
        Me.Controls.Add(Me.NumericUpDown_Punkt)
        Me.Controls.Add(Me.Button_Start)
        Me.Controls.Add(Me.TextBox_YZ)
        Me.Controls.Add(Me.TextBox_YW)
        Me.Controls.Add(Me.TextBox_ZW)
        Me.Controls.Add(Me.PictureBox_Bild)
        Me.MinimumSize = New System.Drawing.Size(973, 610)
        Me.Name = "VierDreh"
        Me.Text = "4Dreh"
        CType(Me.PictureBox_Bild, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Punkt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Verbindung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_LineA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_LineB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Rot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Gruen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Blau, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Zeit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Farbvorschau, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_Bild As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox_ZW As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_YW As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_YZ As System.Windows.Forms.TextBox
    Friend WithEvents Button_Start As System.Windows.Forms.Button
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents NumericUpDown_Punkt As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBox_Xpos As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Ypos As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Zpos As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDown_Verbindung As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown_LineA As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown_LineB As System.Windows.Forms.NumericUpDown
    Friend WithEvents CheckBox_There As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox_Wpos As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_XW As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_XZ As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_XY As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown_Rot As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown_Gruen As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown_Blau As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button_Tesserakt As System.Windows.Forms.Button
    Friend WithEvents TextBox_ZinX As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_ZinY As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Winx As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_WinY As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button_PauseWeiter As System.Windows.Forms.Button
    Friend WithEvents Button_Speichern As System.Windows.Forms.Button
    Friend WithEvents Button_Laden As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Button_Pentachoron As System.Windows.Forms.Button
    Friend WithEvents Button_Wuerfel As System.Windows.Forms.Button
    Friend WithEvents Button_Tetraeder As System.Windows.Forms.Button
    Friend WithEvents Button_Quadrat As System.Windows.Forms.Button
    Friend WithEvents Button_Dreieck As System.Windows.Forms.Button
    Friend WithEvents Button_Formen As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown_Zeit As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents PictureBox_Farbvorschau As System.Windows.Forms.PictureBox

End Class
