<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ingreso_de_pruebas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.MaskedTextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbResultado = New System.Windows.Forms.ComboBox()
        Me.cmbDepto = New System.Windows.Forms.ComboBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lstDepto = New System.Windows.Forms.ListBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.txtactivo = New System.Windows.Forms.TextBox()
        Me.txtRecuperados = New System.Windows.Forms.TextBox()
        Me.txtmuertos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ErrorSeleccion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.DataSet1 = New System.Data.DataSet()
        CType(Me.ErrorSeleccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Edad:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Departamento:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Municipio:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(199, 80)
        Me.txtEdad.Mask = "999"
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(64, 20)
        Me.txtEdad.TabIndex = 5
        Me.txtEdad.ValidatingType = GetType(Integer)
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(199, 24)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(146, 20)
        Me.txtNombre.TabIndex = 6
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(199, 201)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(146, 20)
        Me.txtMunicipio.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 34)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Resultado de Prueba:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmbResultado
        '
        Me.cmbResultado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbResultado.FormattingEnabled = True
        Me.cmbResultado.Items.AddRange(New Object() {"", "Positivo", "Negativo"})
        Me.cmbResultado.Location = New System.Drawing.Point(199, 261)
        Me.cmbResultado.Name = "cmbResultado"
        Me.cmbResultado.Size = New System.Drawing.Size(147, 21)
        Me.cmbResultado.TabIndex = 10
        '
        'cmbDepto
        '
        Me.cmbDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepto.FormattingEnabled = True
        Me.cmbDepto.Items.AddRange(New Object() {"", "Colón", "Atlántida", "Choluteca", "Francisco Morazán", "Cortés", "Valle", "Copán", "Yoro", "Santa Bárbara", "Olancho", "Gracias a Dios", "El Paraiso", "Ocotepeque", "Lempira", "Intibucá", "Comayagua", "Islas de la Bahía", "La Paz"})
        Me.cmbDepto.Location = New System.Drawing.Point(199, 136)
        Me.cmbDepto.Name = "cmbDepto"
        Me.cmbDepto.Size = New System.Drawing.Size(146, 21)
        Me.cmbDepto.TabIndex = 13
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(366, 414)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(123, 23)
        Me.btnIngresar.TabIndex = 14
        Me.btnIngresar.Text = "Ingresar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(427, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 51)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Historial de los reportes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lstDepto
        '
        Me.lstDepto.FormattingEnabled = True
        Me.lstDepto.Location = New System.Drawing.Point(445, 55)
        Me.lstDepto.Name = "lstDepto"
        Me.lstDepto.Size = New System.Drawing.Size(176, 134)
        Me.lstDepto.TabIndex = 16
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"", "Activo", "Recuperado", "Muerto"})
        Me.cmbEstado.Location = New System.Drawing.Point(200, 309)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(145, 21)
        Me.cmbEstado.TabIndex = 17
        '
        'txtactivo
        '
        Me.txtactivo.Enabled = False
        Me.txtactivo.Location = New System.Drawing.Point(489, 233)
        Me.txtactivo.Name = "txtactivo"
        Me.txtactivo.Size = New System.Drawing.Size(100, 20)
        Me.txtactivo.TabIndex = 18
        '
        'txtRecuperados
        '
        Me.txtRecuperados.Enabled = False
        Me.txtRecuperados.Location = New System.Drawing.Point(489, 293)
        Me.txtRecuperados.Name = "txtRecuperados"
        Me.txtRecuperados.Size = New System.Drawing.Size(100, 20)
        Me.txtRecuperados.TabIndex = 19
        '
        'txtmuertos
        '
        Me.txtmuertos.Enabled = False
        Me.txtmuertos.Location = New System.Drawing.Point(489, 354)
        Me.txtmuertos.Name = "txtmuertos"
        Me.txtmuertos.Size = New System.Drawing.Size(100, 20)
        Me.txtmuertos.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(517, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Activo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(505, 276)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Recuperados"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(517, 338)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Muertos"
        '
        'ErrorSeleccion
        '
        Me.ErrorSeleccion.ContainerControl = Me
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(609, 414)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(60, 23)
        Me.btnSalir.TabIndex = 24
        Me.btnSalir.Text = "salir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(543, 414)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(60, 23)
        Me.btnNuevo.TabIndex = 25
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(58, 364)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 17)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(200, 345)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(146, 75)
        Me.txtDescripcion.TabIndex = 27
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'Ingreso_de_pruebas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(687, 449)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtmuertos)
        Me.Controls.Add(Me.txtRecuperados)
        Me.Controls.Add(Me.txtactivo)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.lstDepto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.cmbDepto)
        Me.Controls.Add(Me.cmbResultado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMunicipio)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ingreso_de_pruebas"
        Me.Text = "Ingresar"
        CType(Me.ErrorSeleccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEdad As MaskedTextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbResultado As ComboBox
    Friend WithEvents cmbDepto As ComboBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lstDepto As ListBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents txtactivo As TextBox
    Friend WithEvents txtRecuperados As TextBox
    Friend WithEvents txtmuertos As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ErrorSeleccion As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents btnSalir As Button
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DataSet1 As DataSet
End Class
