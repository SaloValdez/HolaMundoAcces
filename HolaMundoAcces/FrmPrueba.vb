Public Class frmPrueba

    Dim obj As New ClsEmpleado
    Dim obj2 As New ClsProducto
    Private Sub frmPrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call listar_empleado()
        Call listar_producto()
        Call cargar_combo_Proveedor()
    End Sub

    Sub listar_empleado()
        gwEmpleado.DataSource = obj.listar_empleado.Tables(0)
    End Sub

    Sub listar_producto()
        gwProducto.DataSource = obj2.listar_producto.Tables(0)
    End Sub

    Sub cargar_combo_Proveedor()
        Dim dt As New DataTable
        dt = obj2.Listar_Proveedor_Combo.Tables(0)
        cbxProveedor.DataSource = dt
        cbxProveedor.ValueMember = dt.Columns(0).ToString
        cbxProveedor.DisplayMember = dt.Columns(1).ToString
    End Sub
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        obj.Insertar_Empleado(txtNombre.Text, txtApellido.Text, txtEdad.Text, txtFecha.Text)
        Call listar_empleado()

    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        obj.actualizar_empleado(txtNombre.Text, txtApellido.Text, txtEdad.Text, txtFecha.Text, txtId.Text)
        Call listar_empleado()
    End Sub
    Private Sub btnGrabar2_Click(sender As Object, e As EventArgs) Handles btnGrabar2.Click
        obj2.Insertar_producto(txtDescripcion.Text, txtCantidad.Text, txtMarca.Text, cbxProveedor.SelectedValue)
        Call listar_producto()
    End Sub

    Private Sub btnModificar2_Click(sender As Object, e As EventArgs) Handles btnModificar2.Click
        obj2.actualizar_producto(txtDescripcion.Text, txtCantidad.Text, txtMarca.Text, cbxProveedor.SelectedValue, txtIdProducto.Text)
        Call listar_producto()
    End Sub
    Sub buscar_Empleado_nombre()
        Dim dt As New DataTable
        Try
            dt = obj.listar_empleado_nombre(Me.txtFiltrar.Text).Tables(0)
            If dt.Rows.Count > 0 Then
                gwEmpleado.DataSource = dt
            Else
                gwEmpleado.DataSource = Nothing
                '  MessageBox.Show("Nose encontro Registros")
            End If
        Catch ex As Exception
            '  MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtFiltrar_TextChanged(sender As Object, e As EventArgs) Handles txtFiltrar.TextChanged
        Call buscar_Empleado_nombre()
    End Sub




    Private Sub gwEmpleado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gwEmpleado.CellContentClick
        Try
            Me.txtId.Text = gwEmpleado.CurrentRow.Cells(0).Value
            Me.txtNombre.Text = gwEmpleado.CurrentRow.Cells(1).Value
            Me.txtApellido.Text = gwEmpleado.CurrentRow.Cells(2).Value
            Me.txtEdad.Text = gwEmpleado.CurrentRow.Cells(3).Value
            Me.txtFecha.Text = gwEmpleado.CurrentRow.Cells(4).Value

            'BtnActualizar.Enabled = True
            'BtnNuevo.Enabled = True
            'BtnCancelar.Enabled = True
            'btnEliminar.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        obj.Eliminar_Empleado(txtId.Text)
        Call listar_empleado()

    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim frm As New frmReporte()
        frm.Show()
    End Sub

    Private Sub PanelControl2_Paint(sender As Object, e As PaintEventArgs) Handles PanelControl2.Paint

    End Sub
End Class