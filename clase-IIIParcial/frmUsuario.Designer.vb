<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
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
        Me.components = New System.ComponentModel.Container()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.cmbRol = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TiendaDataSet = New clase_IIIParcial.TiendaDataSet()
        Me.UsuarioTableAdapter = New clase_IIIParcial.TiendaDataSetTableAdapters.usuarioTableAdapter()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dtgUsuario = New System.Windows.Forms.DataGridView()
        Me.IdUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PswDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiendaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.Location = New System.Drawing.Point(83, 19)
        Me.txtCodigo.Multiline = True
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(121, 20)
        Me.txtCodigo.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Location = New System.Drawing.Point(83, 51)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(121, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtApellido
        '
        Me.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApellido.Location = New System.Drawing.Point(83, 80)
        Me.txtApellido.Multiline = True
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(121, 20)
        Me.txtApellido.TabIndex = 4
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Location = New System.Drawing.Point(83, 108)
        Me.txtUsuario.Multiline = True
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(121, 20)
        Me.txtUsuario.TabIndex = 5
        '
        'txtContraseña
        '
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContraseña.Location = New System.Drawing.Point(83, 136)
        Me.txtContraseña.Multiline = True
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(121, 20)
        Me.txtContraseña.TabIndex = 6
        '
        'txtCorreo
        '
        Me.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCorreo.Location = New System.Drawing.Point(83, 233)
        Me.txtCorreo.Multiline = True
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(121, 20)
        Me.txtCorreo.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Codigo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.cmbRol)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.txtContraseña)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 270)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Usuario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Estado"
        '
        'txtEstado
        '
        Me.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEstado.Enabled = False
        Me.txtEstado.Location = New System.Drawing.Point(83, 201)
        Me.txtEstado.Multiline = True
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(121, 20)
        Me.txtEstado.TabIndex = 16
        '
        'cmbRol
        '
        Me.cmbRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbRol.FormattingEnabled = True
        Me.cmbRol.Items.AddRange(New Object() {"admin", "trabajador"})
        Me.cmbRol.Location = New System.Drawing.Point(83, 169)
        Me.cmbRol.Name = "cmbRol"
        Me.cmbRol.Size = New System.Drawing.Size(121, 21)
        Me.cmbRol.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Correo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Contraseña"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Rol"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(17, 299)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(100, 299)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 17
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "usuario"
        Me.UsuarioBindingSource.DataSource = Me.TiendaDataSet
        '
        'TiendaDataSet
        '
        Me.TiendaDataSet.DataSetName = "TiendaDataSet"
        Me.TiendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(189, 299)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 19
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(275, 299)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 20
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dtgUsuario
        '
        Me.dtgUsuario.AutoGenerateColumns = False
        Me.dtgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUsuarioDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.NombreUsuarioDataGridViewTextBoxColumn, Me.PswDataGridViewTextBoxColumn, Me.RolDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn})
        Me.dtgUsuario.DataSource = Me.UsuarioBindingSource
        Me.dtgUsuario.Location = New System.Drawing.Point(335, 50)
        Me.dtgUsuario.Name = "dtgUsuario"
        Me.dtgUsuario.Size = New System.Drawing.Size(343, 215)
        Me.dtgUsuario.TabIndex = 21
        '
        'IdUsuarioDataGridViewTextBoxColumn
        '
        Me.IdUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario"
        Me.IdUsuarioDataGridViewTextBoxColumn.HeaderText = "idUsuario"
        Me.IdUsuarioDataGridViewTextBoxColumn.Name = "IdUsuarioDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        '
        'NombreUsuarioDataGridViewTextBoxColumn
        '
        Me.NombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "nombreUsuario"
        Me.NombreUsuarioDataGridViewTextBoxColumn.HeaderText = "nombreUsuario"
        Me.NombreUsuarioDataGridViewTextBoxColumn.Name = "NombreUsuarioDataGridViewTextBoxColumn"
        '
        'PswDataGridViewTextBoxColumn
        '
        Me.PswDataGridViewTextBoxColumn.DataPropertyName = "psw"
        Me.PswDataGridViewTextBoxColumn.HeaderText = "psw"
        Me.PswDataGridViewTextBoxColumn.Name = "PswDataGridViewTextBoxColumn"
        '
        'RolDataGridViewTextBoxColumn
        '
        Me.RolDataGridViewTextBoxColumn.DataPropertyName = "rol"
        Me.RolDataGridViewTextBoxColumn.HeaderText = "rol"
        Me.RolDataGridViewTextBoxColumn.Name = "RolDataGridViewTextBoxColumn"
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "correo"
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(295, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Usuario"
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar.Location = New System.Drawing.Point(359, 24)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(121, 20)
        Me.txtBuscar.TabIndex = 22
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 355)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dtgUsuario)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmUsuario"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiendaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbRol As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents TiendaDataSet As TiendaDataSet
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As TiendaDataSetTableAdapters.usuarioTableAdapter
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents dtgUsuario As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents IdUsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreUsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PswDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
