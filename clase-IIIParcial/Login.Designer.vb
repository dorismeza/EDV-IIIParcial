<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.txtPsw = New System.Windows.Forms.TextBox()
        Me.optOcultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptVer = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.MenuStrip15 = New System.Windows.Forms.MenuStrip()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCambiarPsw = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.btnIniciarSesion = New System.Windows.Forms.Button()
        Me.brnCambiarUsuario = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnborrarderecha = New System.Windows.Forms.Button()
        Me.btnborrartodo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip15.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPsw
        '
        Me.txtPsw.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtPsw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPsw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtPsw.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtPsw.ForeColor = System.Drawing.Color.White
        Me.txtPsw.Location = New System.Drawing.Point(36, 93)
        Me.txtPsw.Name = "txtPsw"
        Me.txtPsw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPsw.Size = New System.Drawing.Size(271, 31)
        Me.txtPsw.TabIndex = 2
        '
        'optOcultar
        '
        Me.optOcultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.optOcultar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.optOcultar.ForeColor = System.Drawing.Color.Black
        Me.optOcultar.Image = CType(resources.GetObject("optOcultar.Image"), System.Drawing.Image)
        Me.optOcultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optOcultar.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.optOcultar.Name = "optOcultar"
        Me.optOcultar.Size = New System.Drawing.Size(32, 24)
        Me.optOcultar.ToolTipText = "Ocultar contraseña"
        Me.optOcultar.Visible = False
        '
        'OptVer
        '
        Me.OptVer.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.OptVer.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.OptVer.ForeColor = System.Drawing.Color.Black
        Me.OptVer.Image = CType(resources.GetObject("OptVer.Image"), System.Drawing.Image)
        Me.OptVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OptVer.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OptVer.Name = "OptVer"
        Me.OptVer.Size = New System.Drawing.Size(32, 24)
        Me.OptVer.ToolTipText = "Ver contraseña"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtUsuario.ForeColor = System.Drawing.Color.White
        Me.txtUsuario.Location = New System.Drawing.Point(36, 19)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(271, 31)
        Me.txtUsuario.TabIndex = 604
        Me.txtUsuario.Tag = "Ingresar usuario"
        '
        'MenuStrip15
        '
        Me.MenuStrip15.AutoSize = False
        Me.MenuStrip15.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.MenuStrip15.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip15.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip15.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptVer, Me.optOcultar})
        Me.MenuStrip15.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip15.Location = New System.Drawing.Point(312, 93)
        Me.MenuStrip15.Name = "MenuStrip15"
        Me.MenuStrip15.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip15.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip15.ShowItemToolTips = True
        Me.MenuStrip15.Size = New System.Drawing.Size(97, 28)
        Me.MenuStrip15.TabIndex = 603
        Me.MenuStrip15.Text = "MenuStrip15"
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.Transparent
        Me.btn3.BackgroundImage = CType(resources.GetObject("btn3.BackgroundImage"), System.Drawing.Image)
        Me.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn3.FlatAppearance.BorderSize = 0
        Me.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.Font = New System.Drawing.Font("Calibri", 40.0!, System.Drawing.FontStyle.Bold)
        Me.btn3.ForeColor = System.Drawing.Color.White
        Me.btn3.Location = New System.Drawing.Point(178, 3)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(80, 80)
        Me.btn3.TabIndex = 42
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.Transparent
        Me.btn2.BackgroundImage = CType(resources.GetObject("btn2.BackgroundImage"), System.Drawing.Image)
        Me.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn2.FlatAppearance.BorderSize = 0
        Me.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Font = New System.Drawing.Font("Calibri", 40.0!, System.Drawing.FontStyle.Bold)
        Me.btn2.ForeColor = System.Drawing.Color.White
        Me.btn2.Location = New System.Drawing.Point(92, 3)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(80, 80)
        Me.btn2.TabIndex = 41
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.Transparent
        Me.btn1.BackgroundImage = CType(resources.GetObject("btn1.BackgroundImage"), System.Drawing.Image)
        Me.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn1.FlatAppearance.BorderSize = 0
        Me.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("Calibri", 40.0!, System.Drawing.FontStyle.Bold)
        Me.btn1.ForeColor = System.Drawing.Color.White
        Me.btn1.Location = New System.Drawing.Point(6, 3)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(80, 80)
        Me.btn1.TabIndex = 40
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.Transparent
        Me.btn6.BackgroundImage = CType(resources.GetObject("btn6.BackgroundImage"), System.Drawing.Image)
        Me.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn6.FlatAppearance.BorderSize = 0
        Me.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn6.Font = New System.Drawing.Font("Calibri", 40.0!, System.Drawing.FontStyle.Bold)
        Me.btn6.ForeColor = System.Drawing.Color.White
        Me.btn6.Location = New System.Drawing.Point(178, 89)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(80, 80)
        Me.btn6.TabIndex = 37
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.Transparent
        Me.btn5.BackgroundImage = CType(resources.GetObject("btn5.BackgroundImage"), System.Drawing.Image)
        Me.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn5.FlatAppearance.BorderSize = 0
        Me.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5.Font = New System.Drawing.Font("Calibri", 40.0!, System.Drawing.FontStyle.Bold)
        Me.btn5.ForeColor = System.Drawing.Color.White
        Me.btn5.Location = New System.Drawing.Point(92, 89)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(80, 80)
        Me.btn5.TabIndex = 36
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.Transparent
        Me.btn4.BackgroundImage = CType(resources.GetObject("btn4.BackgroundImage"), System.Drawing.Image)
        Me.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn4.FlatAppearance.BorderSize = 0
        Me.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4.Font = New System.Drawing.Font("Calibri", 40.0!, System.Drawing.FontStyle.Bold)
        Me.btn4.ForeColor = System.Drawing.Color.White
        Me.btn4.Location = New System.Drawing.Point(6, 89)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(80, 80)
        Me.btn4.TabIndex = 35
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.Color.Transparent
        Me.btn9.BackgroundImage = CType(resources.GetObject("btn9.BackgroundImage"), System.Drawing.Image)
        Me.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn9.FlatAppearance.BorderSize = 0
        Me.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn9.Font = New System.Drawing.Font("Calibri", 40.0!, System.Drawing.FontStyle.Bold)
        Me.btn9.ForeColor = System.Drawing.Color.White
        Me.btn9.Location = New System.Drawing.Point(178, 175)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(80, 80)
        Me.btn9.TabIndex = 32
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(30, 120)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(307, 2)
        Me.Panel1.TabIndex = 605
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Panel1)
        Me.Panel9.Controls.Add(Me.txtUsuario)
        Me.Panel9.Controls.Add(Me.MenuStrip15)
        Me.Panel9.Controls.Add(Me.Panel4)
        Me.Panel9.Controls.Add(Me.txtPsw)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 76)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(391, 133)
        Me.Panel9.TabIndex = 618
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(28, 56)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(310, 1)
        Me.Panel4.TabIndex = 547
        '
        'btnCambiarPsw
        '
        Me.btnCambiarPsw.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnCambiarPsw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCambiarPsw.FlatAppearance.BorderSize = 0
        Me.btnCambiarPsw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarPsw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarPsw.ForeColor = System.Drawing.Color.White
        Me.btnCambiarPsw.Location = New System.Drawing.Point(67, 572)
        Me.btnCambiarPsw.Name = "btnCambiarPsw"
        Me.btnCambiarPsw.Size = New System.Drawing.Size(252, 35)
        Me.btnCambiarPsw.TabIndex = 615
        Me.btnCambiarPsw.Text = "¿Olvidaste tu contraseña?"
        Me.btnCambiarPsw.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btn3)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn2)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn1)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn6)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn5)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn4)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn9)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn8)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn7)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(58, 117)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(261, 255)
        Me.FlowLayoutPanel1.TabIndex = 46
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.Color.Transparent
        Me.btn8.BackgroundImage = CType(resources.GetObject("btn8.BackgroundImage"), System.Drawing.Image)
        Me.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn8.FlatAppearance.BorderSize = 0
        Me.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn8.Font = New System.Drawing.Font("Calibri", 40.0!, System.Drawing.FontStyle.Bold)
        Me.btn8.ForeColor = System.Drawing.Color.White
        Me.btn8.Location = New System.Drawing.Point(92, 175)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(80, 80)
        Me.btn8.TabIndex = 31
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.Color.Transparent
        Me.btn7.BackgroundImage = CType(resources.GetObject("btn7.BackgroundImage"), System.Drawing.Image)
        Me.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn7.FlatAppearance.BorderSize = 0
        Me.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn7.Font = New System.Drawing.Font("Calibri", 40.0!, System.Drawing.FontStyle.Bold)
        Me.btn7.ForeColor = System.Drawing.Color.White
        Me.btn7.Location = New System.Drawing.Point(6, 175)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(80, 80)
        Me.btn7.TabIndex = 30
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.btnIniciarSesion)
        Me.Panel13.Controls.Add(Me.brnCambiarUsuario)
        Me.Panel13.Controls.Add(Me.btnCambiarPsw)
        Me.Panel13.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel13.Controls.Add(Me.btn0)
        Me.Panel13.Controls.Add(Me.btnborrarderecha)
        Me.Panel13.Controls.Add(Me.btnborrartodo)
        Me.Panel13.Location = New System.Drawing.Point(0, 97)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(393, 615)
        Me.Panel13.TabIndex = 617
        '
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.BackColor = System.Drawing.Color.SteelBlue
        Me.btnIniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIniciarSesion.FlatAppearance.BorderSize = 0
        Me.btnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnIniciarSesion.ForeColor = System.Drawing.Color.White
        Me.btnIniciarSesion.Location = New System.Drawing.Point(67, 479)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(252, 52)
        Me.btnIniciarSesion.TabIndex = 613
        Me.btnIniciarSesion.Text = "Iniciar sesion"
        Me.btnIniciarSesion.UseVisualStyleBackColor = False
        '
        'brnCambiarUsuario
        '
        Me.brnCambiarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.brnCambiarUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.brnCambiarUsuario.FlatAppearance.BorderSize = 0
        Me.brnCambiarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.brnCambiarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brnCambiarUsuario.ForeColor = System.Drawing.Color.DarkGray
        Me.brnCambiarUsuario.Location = New System.Drawing.Point(67, 535)
        Me.brnCambiarUsuario.Name = "brnCambiarUsuario"
        Me.brnCambiarUsuario.Size = New System.Drawing.Size(252, 35)
        Me.brnCambiarUsuario.TabIndex = 614
        Me.brnCambiarUsuario.Text = "Cambiar de Usuario"
        Me.brnCambiarUsuario.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.Color.Transparent
        Me.btn0.BackgroundImage = CType(resources.GetObject("btn0.BackgroundImage"), System.Drawing.Image)
        Me.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn0.FlatAppearance.BorderSize = 0
        Me.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn0.Font = New System.Drawing.Font("Calibri", 37.0!, System.Drawing.FontStyle.Bold)
        Me.btn0.ForeColor = System.Drawing.Color.White
        Me.btn0.Location = New System.Drawing.Point(153, 378)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(80, 66)
        Me.btn0.TabIndex = 45
        Me.btn0.Text = "0"
        Me.btn0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btnborrarderecha
        '
        Me.btnborrarderecha.BackColor = System.Drawing.Color.Transparent
        Me.btnborrarderecha.BackgroundImage = CType(resources.GetObject("btnborrarderecha.BackgroundImage"), System.Drawing.Image)
        Me.btnborrarderecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnborrarderecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnborrarderecha.FlatAppearance.BorderSize = 0
        Me.btnborrarderecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnborrarderecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnborrarderecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnborrarderecha.Font = New System.Drawing.Font("Calibri", 21.0!, System.Drawing.FontStyle.Bold)
        Me.btnborrarderecha.ForeColor = System.Drawing.Color.White
        Me.btnborrarderecha.Location = New System.Drawing.Point(236, 378)
        Me.btnborrarderecha.Name = "btnborrarderecha"
        Me.btnborrarderecha.Size = New System.Drawing.Size(80, 66)
        Me.btnborrarderecha.TabIndex = 26
        Me.btnborrarderecha.Text = "<--"
        Me.btnborrarderecha.UseVisualStyleBackColor = False
        '
        'btnborrartodo
        '
        Me.btnborrartodo.BackColor = System.Drawing.Color.Transparent
        Me.btnborrartodo.BackgroundImage = CType(resources.GetObject("btnborrartodo.BackgroundImage"), System.Drawing.Image)
        Me.btnborrartodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnborrartodo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnborrartodo.FlatAppearance.BorderSize = 0
        Me.btnborrartodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnborrartodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnborrartodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnborrartodo.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnborrartodo.ForeColor = System.Drawing.Color.White
        Me.btnborrartodo.Location = New System.Drawing.Point(67, 378)
        Me.btnborrartodo.Name = "btnborrartodo"
        Me.btnborrartodo.Size = New System.Drawing.Size(80, 66)
        Me.btnborrartodo.TabIndex = 25
        Me.btnborrartodo.Text = "Borrar"
        Me.btnborrartodo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(391, 76)
        Me.Label3.TabIndex = 619
        Me.Label3.Text = "Inicio de Sesion"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 724)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.MenuStrip15.ResumeLayout(False)
        Me.MenuStrip15.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtPsw As TextBox
    Friend WithEvents optOcultar As ToolStripMenuItem
    Friend WithEvents OptVer As ToolStripMenuItem
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents MenuStrip15 As MenuStrip
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnCambiarPsw As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents Panel13 As Panel
    Friend WithEvents btnIniciarSesion As Button
    Friend WithEvents brnCambiarUsuario As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnborrarderecha As Button
    Friend WithEvents btnborrartodo As Button
    Friend WithEvents Label3 As Label
End Class
