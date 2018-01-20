<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnRegresar = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 51)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(790, 287)
        Me.ReportViewer1.TabIndex = 0
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(662, 12)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(123, 33)
        Me.btnRegresar.TabIndex = 1
        Me.btnRegresar.Text = "Regresar"
        '
        'frmReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 338)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporte"
        Me.Text = "frmReporte"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnRegresar As DevExpress.XtraEditors.SimpleButton
End Class
