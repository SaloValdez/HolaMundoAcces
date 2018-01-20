Public Class combosRelacionados
    Dim obj As New ClsCombosRelacionados
    Private Sub combosRelacionados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargar_combo_Departamento()
        ' Call cargar_combo_Provincia()

    End Sub




    Sub cargar_combo_Departamento()
        Dim dt As New DataTable
        dt = obj.listar_Combo_Departamento.Tables(0)
        cbxDepartamento.DataSource = dt
        cbxDepartamento.ValueMember = dt.Columns(0).ToString
        cbxDepartamento.DisplayMember = dt.Columns(1).ToString
    End Sub

    Sub cargar_combo_Provincia()
        Dim dt As New DataTable
        dt = obj.listar_Combo_Provincia(cbxDepartamento.SelectedIndex).Tables(0)
        cbxProvincia.DataSource = dt
        cbxProvincia.ValueMember = dt.Columns(0).ToString
        cbxProvincia.DisplayMember = dt.Columns(1).ToString
    End Sub

    Private Sub cbxDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDepartamento.SelectedIndexChanged


    End Sub

    Private Sub cbxDepartamento_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxDepartamento.SelectedValueChanged
        cargar_combo_Provincia()
    End Sub
End Class