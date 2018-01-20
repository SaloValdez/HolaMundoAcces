<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrueba
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
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.btnGrabar = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFiltrar = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.gwEmpleado = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.cbxProveedor = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.btnEliminar2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModificar2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.gwProducto = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.btnGrabar2 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.BunifuFormFadeTransition1 = New Bunifu.Framework.UI.BunifuFormFadeTransition(Me.components)
        Me.btnReporte = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.gwEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.gwProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.AutoSizeMode = True
        Me.SeparatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center
        Me.SeparatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl1.Location = New System.Drawing.Point(615, 4)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(20, 566)
        Me.SeparatorControl1.TabIndex = 0
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(6, 225)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(97, 29)
        Me.btnGrabar.TabIndex = 1
        Me.btnGrabar.Text = "Grabar"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnReporte)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Controls.Add(Me.txtEdad)
        Me.PanelControl1.Controls.Add(Me.txtFecha)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Controls.Add(Me.txtFiltrar)
        Me.PanelControl1.Controls.Add(Me.btnEliminar)
        Me.PanelControl1.Controls.Add(Me.btnModificar)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.txtApellido)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.txtNombre)
        Me.PanelControl1.Controls.Add(Me.gwEmpleado)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.txtId)
        Me.PanelControl1.Controls.Add(Me.btnGrabar)
        Me.PanelControl1.Location = New System.Drawing.Point(3, 35)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(606, 501)
        Me.PanelControl1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "EDAD :"
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(125, 116)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(114, 21)
        Me.txtEdad.TabIndex = 19
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(125, 148)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(235, 21)
        Me.txtFecha.TabIndex = 18
        Me.txtFecha.Value = New Date(2017, 12, 25, 23, 59, 59, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(409, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Filtrar x Nombre:"
        '
        'txtFiltrar
        '
        Me.txtFiltrar.Location = New System.Drawing.Point(412, 233)
        Me.txtFiltrar.Name = "txtFiltrar"
        Me.txtFiltrar.Size = New System.Drawing.Size(187, 21)
        Me.txtFiltrar.TabIndex = 16
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(200, 225)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(97, 29)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(103, 225)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(97, 29)
        Me.btnModificar.TabIndex = 14
        Me.btnModificar.Text = "Modificar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "FECHA INGRESO :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "APELLIDO :"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(125, 89)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(235, 21)
        Me.txtApellido.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "NOMBRES  :"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(125, 62)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(146, 21)
        Me.txtNombre.TabIndex = 8
        '
        'gwEmpleado
        '
        Me.gwEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gwEmpleado.Location = New System.Drawing.Point(5, 259)
        Me.gwEmpleado.Name = "gwEmpleado"
        Me.gwEmpleado.Size = New System.Drawing.Size(596, 230)
        Me.gwEmpleado.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID :"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(125, 26)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(146, 21)
        Me.txtId.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(238, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(125, 25)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "EMPLEADO"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.cbxProveedor)
        Me.PanelControl2.Controls.Add(Me.Label11)
        Me.PanelControl2.Controls.Add(Me.txtMarca)
        Me.PanelControl2.Controls.Add(Me.btnEliminar2)
        Me.PanelControl2.Controls.Add(Me.btnModificar2)
        Me.PanelControl2.Controls.Add(Me.Label7)
        Me.PanelControl2.Controls.Add(Me.Label8)
        Me.PanelControl2.Controls.Add(Me.txtCantidad)
        Me.PanelControl2.Controls.Add(Me.Label9)
        Me.PanelControl2.Controls.Add(Me.txtDescripcion)
        Me.PanelControl2.Controls.Add(Me.gwProducto)
        Me.PanelControl2.Controls.Add(Me.Label10)
        Me.PanelControl2.Controls.Add(Me.txtIdProducto)
        Me.PanelControl2.Controls.Add(Me.btnGrabar2)
        Me.PanelControl2.Location = New System.Drawing.Point(641, 35)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(628, 501)
        Me.PanelControl2.TabIndex = 19
        '
        'cbxProveedor
        '
        Me.cbxProveedor.FormattingEnabled = True
        Me.cbxProveedor.Location = New System.Drawing.Point(124, 164)
        Me.cbxProveedor.Name = "cbxProveedor"
        Me.cbxProveedor.Size = New System.Drawing.Size(147, 21)
        Me.cbxProveedor.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(80, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Marca :"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(125, 122)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(146, 21)
        Me.txtMarca.TabIndex = 19
        '
        'btnEliminar2
        '
        Me.btnEliminar2.Location = New System.Drawing.Point(199, 224)
        Me.btnEliminar2.Name = "btnEliminar2"
        Me.btnEliminar2.Size = New System.Drawing.Size(97, 29)
        Me.btnEliminar2.TabIndex = 15
        Me.btnEliminar2.Text = "Eliminar"
        '
        'btnModificar2
        '
        Me.btnModificar2.Location = New System.Drawing.Point(102, 224)
        Me.btnModificar2.Name = "btnModificar2"
        Me.btnModificar2.Size = New System.Drawing.Size(97, 29)
        Me.btnModificar2.TabIndex = 14
        Me.btnModificar2.Text = "Modificar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Proveedor :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(66, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Cantidad :"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(125, 89)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(146, 21)
        Me.txtCantidad.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(52, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Descripcion  :"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(125, 62)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(146, 21)
        Me.txtDescripcion.TabIndex = 8
        '
        'gwProducto
        '
        Me.gwProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gwProducto.Location = New System.Drawing.Point(5, 259)
        Me.gwProducto.Name = "gwProducto"
        Me.gwProducto.Size = New System.Drawing.Size(617, 230)
        Me.gwProducto.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(98, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "ID :"
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Location = New System.Drawing.Point(125, 26)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(146, 21)
        Me.txtIdProducto.TabIndex = 5
        '
        'btnGrabar2
        '
        Me.btnGrabar2.Location = New System.Drawing.Point(5, 224)
        Me.btnGrabar2.Name = "btnGrabar2"
        Me.btnGrabar2.Size = New System.Drawing.Size(97, 29)
        Me.btnGrabar2.TabIndex = 1
        Me.btnGrabar2.Text = "Grabar"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(890, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(126, 25)
        Me.LabelControl2.TabIndex = 20
        Me.LabelControl2.Text = "PRODUCTO"
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
        '
        'BunifuFormFadeTransition1
        '
        Me.BunifuFormFadeTransition1.Delay = 2
        '
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(475, 8)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(126, 39)
        Me.btnReporte.TabIndex = 21
        Me.btnReporte.Text = "Ver Reporte"
        '
        'frmPrueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1302, 560)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Name = "frmPrueba"
        Me.Text = "FrmPrueba"
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.gwEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.gwProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents btnGrabar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents gwEmpleado As System.Windows.Forms.DataGridView
    Friend WithEvents btnModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFiltrar As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnEliminar2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnModificar2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents gwProducto As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtIdProducto As System.Windows.Forms.TextBox
    Friend WithEvents btnGrabar2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents cbxProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents BunifuFormFadeTransition1 As Bunifu.Framework.UI.BunifuFormFadeTransition
    Friend WithEvents btnReporte As DevExpress.XtraEditors.SimpleButton
End Class
