# Programacion Visual studio
Codigo de la aplicacion Gestion  
Public Class Form1

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        REM Boton Agregar 
        If TextId.Text = "" Or TextNombre.Text = "" Or TextAso.Text = "" Or TextDes.Text = "" Then
            MsgBox("Error, Verifique datos")
            REM Tira un mensaje de error si una de las cadenas esta vacia 
        Else
            dgv.Rows.Add(TextId.Text, TextNombre.Text, TextAso.Text, TextDes.Text)
        End If
        REM Limpiar las casillas 
        TextId.Clear()
        TextNombre.Clear()
        TextAso.Clear()
        TextDes.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        REM Boton eliminar 
        dgv.Rows.Remove(dgv.CurrentRow)
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        REM Boton Modificar datos
        dgv.Item(0, dgv.CurrentRow.Index).Value = TextId.Text
        dgv.Item(1, dgv.CurrentRow.Index).Value = TextNombre.Text
        dgv.Item(2, dgv.CurrentRow.Index).Value = TextAso.Text
        dgv.Item(3, dgv.CurrentRow.Index).Value = TextDes.Text
        REM Al dar click en una de las casillas, se obtienen todos los datos previamente guardados para su modificacion
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim i As Integer = dgv.CurrentRow.Index
        REM Muestra los datos ingresados anteriormente
        TextId.Text = dgv(0, i).Value
        TextNombre.Text = dgv(1, i).Value
        TextAso.Text = dgv(2, i).Value
        TextDes.Text = dgv(3, i).Value

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub
End Class
