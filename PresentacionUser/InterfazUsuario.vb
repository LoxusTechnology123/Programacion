
Public Class InterfazUsuario

    Private Sub InterfazUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Combo1.Items.Add("")
        Combo1.Items.Add("Tos") REM Cargar datos al ComboBox de Sintomas 1
        Combo1.Items.Add("Diarrea")
        Combo1.Items.Add("Dificultad Respiratoria")

        Combo2.Items.Add("")
        Combo2.Items.Add("Tos") REM Cargar datos al ComboBox de Sintomas 2
        Combo2.Items.Add("Diarrea")
        Combo2.Items.Add("Dificultad Respiratoria")

        Combo3.Items.Add("")
        Combo3.Items.Add("Tos") REM Cargar datos al ComboBox de Sintomas 3
        Combo3.Items.Add("Diarrea")
        Combo3.Items.Add("Dificultad Respiratoria")

    End Sub
    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        TXTAyuda.Visible = True REM Al darle click en el icono aparece el texto de ayuda, mediante el metodo VISIBLE
    End Sub

    Private Sub BTNDiagnostico_Click(sender As Object, e As EventArgs) Handles BTNDiagnostico.Click

        If Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Resfriado o Gripe"
        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Sindrome de la Hipersensibilidad de la tos"

        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Neumonía"

        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Sindrome de la Hipersensibilidad de la tos"
        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Neumonía"
        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Sindrome de la Hipersensibilidad de la tos"

        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Sindrome de la Hipersensibilidad de la tos"

        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Diarrea por Antibioticos"
        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Neumonía"

        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Neumonía"
        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Asma"

        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Bronquitis aguda"
        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Bronquitis aguda"

        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Neumonía"
        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Neumonía"

        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Bronquitis aguda"
        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Asma"
        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Problema con los Pulmones"

        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Resfriado o Gripe"
        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 1 And Combo2.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Bronquitis aguda"

        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Diarrea por Antibioticos"
        ElseIf Combo1.SelectedIndex = 2 And Combo2.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Asma"

        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Bronquitis aguda"
        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Asma"
        ElseIf Combo1.SelectedIndex = 3 And Combo2.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Problema con los Pulmones"

            REM Suponiendo que no coloque los sintomas en orden (1-3) 

        ElseIf Combo1.SelectedIndex = 1 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Resfriado o Gripe"
        ElseIf Combo1.SelectedIndex = 1 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 1 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Bronquitis aguda"

        ElseIf Combo1.SelectedIndex = 2 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo1.SelectedIndex = 2 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Diarrea por Antibioticos"
        ElseIf Combo1.SelectedIndex = 2 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Asma"

        ElseIf Combo1.SelectedIndex = 3 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Bronquitis aguda"
        ElseIf Combo1.SelectedIndex = 3 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Asma"
        ElseIf Combo1.SelectedIndex = 3 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Problema con los Pulmones"

            REM Suponiendo que no coloque los sintomas en orden (2-3)

        ElseIf Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Resfriado o Gripe"
        ElseIf Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo2.SelectedIndex = 1 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Bronquitis aguda"

        ElseIf Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Covid-19"
        ElseIf Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Diarrea por Antibioticos"
        ElseIf Combo2.SelectedIndex = 2 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Asma"

        ElseIf Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Bronquitis aguda"
        ElseIf Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Asma"
        ElseIf Combo2.SelectedIndex = 3 And Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Problema con los Pulmones"

        ElseIf Combo1.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Resfriado o Gripe"
        ElseIf Combo1.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Diarrea por Antibioticos"
        ElseIf Combo1.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Problema con los Pulmones"

            REM Suponiendo que no coloque los sintomas en orden (2)

        ElseIf Combo2.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Resfriado o Gripe"
        ElseIf Combo2.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Diarrea por Antibioticos"
        ElseIf Combo2.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Problema con los Pulmones"

            REM Suponiendo que no coloque los sintomas en orden (2)

        ElseIf Combo3.SelectedIndex = 1 Then
            TXTDiagnostico.Text = "Resfriado o Gripe"
        ElseIf Combo3.SelectedIndex = 2 Then
            TXTDiagnostico.Text = "Diarrea por Antibioticos"
        ElseIf Combo3.SelectedIndex = 3 Then
            TXTDiagnostico.Text = "Problema con los Pulmones"
        End If
    End Sub

    Private Sub BTNCerrar_Click(sender As Object, e As EventArgs) Handles BTNCerrar.Click
        Application.Exit()
    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        If MessageBox.Show("Esta seguro que desea salir?", "Peligro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click

    End Sub

    Private Sub TXTDiagnostico_Click(sender As Object, e As EventArgs) Handles TXTDiagnostico.Click

    End Sub
    'Sub llenar()
    'Dim DA As New SqlDataAdapter()
    'Dim DT As New DataTable()

    'Try
    'DA = New SqlDataAdapter("select * from sintomas", con)
    'DA.Fill(DT)
    'Combo1.DataSource = DT
    'Combo1.DisplayMember = "nombre"
    'Combo1.ValueMember = "id_sintoma"
    'Catch ex As Exception

    'End Try
    'End Sub

End Class