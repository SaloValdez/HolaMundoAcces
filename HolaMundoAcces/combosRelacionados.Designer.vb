<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class combosRelacionados
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
        Me.cbxDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxProvincia = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cbxDepartamento
        '
        Me.cbxDepartamento.FormattingEnabled = True
        Me.cbxDepartamento.Location = New System.Drawing.Point(61, 76)
        Me.cbxDepartamento.Name = "cbxDepartamento"
        Me.cbxDepartamento.Size = New System.Drawing.Size(203, 21)
        Me.cbxDepartamento.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DEPARTAMENTO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(363, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PROVINCIA:"
        '
        'cbxProvincia
        '
        Me.cbxProvincia.FormattingEnabled = True
        Me.cbxProvincia.Location = New System.Drawing.Point(366, 76)
        Me.cbxProvincia.Name = "cbxProvincia"
        Me.cbxProvincia.Size = New System.Drawing.Size(203, 21)
        Me.cbxProvincia.TabIndex = 2
        '
        'combosRelacionados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 305)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxProvincia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxDepartamento)
        Me.Name = "combosRelacionados"
        Me.Text = "combosRelacionados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxProvincia As System.Windows.Forms.ComboBox
End Class
