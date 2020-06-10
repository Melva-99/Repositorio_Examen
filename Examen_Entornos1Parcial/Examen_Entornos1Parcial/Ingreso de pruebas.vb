Imports System.ComponentModel

Public Class Ingreso_de_pruebas
    Dim activos, recuperados, muertos As Integer
    Private Sub Ingreso_de_pruebas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbEstado.Enabled = False
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            If Me.ValidateChildren And txtNombre.Text <> String.Empty And txtMunicipio.Text <> String.Empty And cmbDepto.SelectedItem <> String.Empty And cmbResultado.SelectedItem <> String.Empty Then
                Dim opcion = MessageBox.Show("¿Desea agregarlo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If opcion = DialogResult.Yes Then
                    If cmbDepto.SelectedIndex Then
                        lstDepto.Items.Add(cmbDepto.SelectedItem)
                        lstDepto.Items.Add(txtNombre.Text)
                        lstDepto.Items.Add(cmbResultado.SelectedItem)
                        lstDepto.Items.Add(cmbEstado.SelectedItem)
                        If cmbEstado.Text = "Activo" Then
                            activos += 1
                        End If
                        txtactivo.Text = activos
                        If cmbEstado.Text = "Recuperado" Then
                            recuperados += 1
                        End If
                        txtRecuperados.Text = recuperados
                        If cmbEstado.Text = "Muerto" Then
                            muertos += 1
                        End If
                        txtmuertos.Text = muertos
                    End If
                    MsgBox("Datos Ingresados Exitosamente")
                End If
            Else
                MessageBox.Show("Revise los datos Ingresados", "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmbResultado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbResultado.SelectedIndexChanged
        If cmbResultado.Text = "Positivo" Then
            cmbEstado.Enabled = True
        ElseIf cmbResultado.Text = "Negativo" Then
            cmbEstado.Enabled = False
        End If
    End Sub

    Private Sub cmbResultado_Validating(sender As Object, e As CancelEventArgs) Handles cmbResultado.Validating
        If DirectCast(sender, ComboBox).SelectedItem <> String.Empty Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Debe seleccionar un estado de prueba")
        End If
    End Sub

    Private Sub cmbDepto_Validating(sender As Object, e As CancelEventArgs) Handles cmbDepto.Validating
        If DirectCast(sender, ComboBox).SelectedItem <> String.Empty Then
            Me.ErrorSeleccion.SetError(sender, "")
        Else
            Me.ErrorSeleccion.SetError(sender, "Debe seleccionar un departamento")
        End If
    End Sub

    Private Sub cmbEstado_Validating(sender As Object, e As CancelEventArgs) Handles cmbEstado.Validating
        If cmbResultado.Text = "Positivo" Then
            If DirectCast(sender, ComboBox).SelectedItem <> String.Empty Then
                Me.ErrorProvider2.SetError(sender, "")
            Else
                Me.ErrorProvider2.SetError(sender, "Debe seleccionar el estado de la persona positiva")
            End If
        End If
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip1.SetToolTip(txtNombre, "Ingrese el nombre de la persona a ingresar")
        ToolTip1.ToolTipTitle = "Nombre"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        ToolTip2.SetToolTip(txtEdad, "Ingrese la edad de la persona a ingresar")
        ToolTip2.ToolTipTitle = "Edad"
        ToolTip2.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        ToolTip3.SetToolTip(txtMunicipio, "Ingrese el municipio")
        ToolTip3.ToolTipTitle = "Municipio"
        ToolTip3.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider3.SetError(sender, "")
        Else
            Me.ErrorProvider3.SetError(sender, "Debe agregar el nombre del paciente")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Clear()
        txtEdad.Clear()
        cmbDepto.Text = ""
        txtMunicipio.Clear()
        cmbResultado.Text = ""
        cmbEstado.Text = ""
    End Sub
End Class