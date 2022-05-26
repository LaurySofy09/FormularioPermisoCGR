Imports System.Data.SqlClient

Public Class Nuevo

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Fundamento legal: artículo 47 del reglamento interno de la CGR." & vbNewLine & "1. Se utilizará cuando (el/la) servidor(a) se retire parcial o totalmente de su puesto y el mismo reemplaza cualquier otro documento utilizado internamente para registrar permiso por lo que deberán adjuntarse las constancias respectivas al retorno del servidor(a)" & vbNewLine & "2. Debe completarse en su totalidad previo al permiso...")
    End Sub


    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            DateTimePicker2.Visible = True
        ElseIf CheckBox1.Checked = False Then
            DateTimePicker2.Visible = False
        End If
    End Sub

    Private Sub Nuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()
        'Label4.Text = estado
        Dim fechaactual As Date = Today.ToShortDateString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        validaciones()
    End Sub

    Sub insertar()
        Dim cadena As String = "Insert into LSDREGISTER (id, nombre, direccion, departamento, seccion, tipopermiso, otros, fechainicial, fechafinal, fechaactual, rango, horainicial, horafinal, horatotal, jefe_supervisor, observacion) values ('" & TextBox2.Text & "', '" & TextBox1.Text & "', '" & ComboBox1.Text & "','" & ComboBox2.Text & "', '" & ComboBox3.Text & "', '" & ComboBox4.Text & "', '" & TextBox3.Text & "', '" & DateTimePicker1.Value.ToShortDateString & "', '" & DateTimePicker2.Value.ToShortDateString & "', '" & DateTimePicker5.Value.ToShortDateString & "', '" & CheckBox1.Checked & "', '" & DateTimePicker3.Value.ToLongTimeString & "', '" & DateTimePicker4.Value.ToLongTimeString & "', '" & MaskedTextBox1.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "')"
        Try
            comando = New SqlCommand(cadena, conexion)
            comando.ExecuteNonQuery()
            MsgBox("Creado con éxito")
            Limpiar()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error. Verifique")
        End Try
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.Text = "Otros" Then
            Label11.Visible = True
            TextBox3.Visible = True
        Else
            TextBox3.Visible = False
            Label11.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fechainicial, fechafinal As Date
        Dim dias, horas As Integer

        fechainicial = DateTimePicker1.Value.ToShortDateString
        fechafinal = DateTimePicker2.Value.ToShortDateString

        Dim horainicial, horafinal As Date
        Dim intervalo As TimeSpan

        horainicial = DateTimePicker3.Value.ToLongTimeString
        horafinal = DateTimePicker4.Value.ToLongTimeString

        If CheckBox1.Checked = True Then
            dias = ((DateDiff("s", fechainicial, fechafinal) \ 86400) Mod 365)
            horas = (dias + 1) * 8
            MaskedTextBox1.Text = horas.ToString & ":" & "00" & ":" & "00"
        ElseIf CheckBox1.Checked = False And horafinal > horainicial Then
            intervalo = horafinal.Subtract(horainicial)
            MaskedTextBox1.Text = intervalo.ToString
        ElseIf CheckBox1.Checked = False And horafinal < horainicial Then
            MaskedTextBox1.Enabled = True
            MaskedTextBox1.Text = intervalo.ToString
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("Tip 1: Puede usar formato de 24 horas y el botón celeste para cálculo automático de horas totales." & vbNewLine & "Tip 2: Puede usar formato de 12 horas introduciendo las horas totales de forma manual.")
    End Sub

    Public Sub Limpiar()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        MaskedTextBox1.Text = "00:00:00"
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox3.Text = ""
        ComboBox2.Text = ""
        ComboBox1.Text = ""
        ComboBox4.Text = ""
        DateTimePicker1.Value = Now()
        DateTimePicker2.Value = Now()
        DateTimePicker3.Value = Now()
        DateTimePicker4.Value = Now()
        DateTimePicker5.Value = Now()
        CheckBox1.Checked = False
        TextBox3.Visible = False
        Label11.Visible = False
        MaskedTextBox1.Enabled = False
    End Sub

    Sub validaciones()
        If TextBox2.Text Is "" Then
            MsgBox("Inserte cédula")
            TextBox2.Focus()
        ElseIf TextBox1.Text Is "" Then
            MsgBox("Inserte nombre")
            TextBox1.Focus()
        ElseIf ComboBox1.Text Is "" Then
            MsgBox("Inserte dirección")
            ComboBox1.Focus()
        ElseIf ComboBox2.Text Is "" Then
            MsgBox("Inserte departamento")
            ComboBox2.Focus()
        ElseIf ComboBox4.Text Is "" Then
            MsgBox("Inserte tipo de permiso")
            ComboBox4.Focus()
        ElseIf MaskedTextBox1.Text = "00:00:00" Then
            MsgBox("Calcule horas")
            MaskedTextBox1.Focus()
        ElseIf MaskedTextBox1.Text Is "" Then
            MsgBox("Calcule horas")
            MaskedTextBox1.Focus()
        ElseIf TextBox5.Text Is "" Then
            MsgBox("Inserte jefe o supervisor")
            TextBox5.Focus()
        Else
            insertar()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Items.Clear()
        If ComboBox1.SelectedItem = "DAF" Then
            ComboBox2.Items.Add("")
            ComboBox2.Items.Add("Dirección")
            ComboBox2.Items.Add("Subdirección")
            ComboBox2.Items.Add("Servicios Administrativos")
            ComboBox2.Items.Add("Presupuesto")
            ComboBox2.Items.Add("Contabilidad")
            ComboBox2.Items.Add("Transporte")
            ComboBox2.Items.Add("Mantenimiento")
            ComboBox2.Items.Add("Correspondencia")
            ComboBox2.Items.Add("Provincial")
        ElseIf ComboBox1.SelectedItem = "DNI" Then
            ComboBox2.Items.Add("")
            ComboBox2.Items.Add("Dirección")
            ComboBox2.Items.Add("Subdirección")
            ComboBox2.Items.Add("Servicios Administrativos")
            ComboBox2.Items.Add("Soporte")
            ComboBox2.Items.Add("Programacion")
            ComboBox2.Items.Add("Base de datos")
            ComboBox2.Items.Add("CAU")
            ComboBox2.Items.Add("Provincial")
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox3.Items.Clear()
        If ComboBox2.Text = "Provincial" Then
            ComboBox3.Items.Add("")
            ComboBox3.Items.Add("Bocas del Toro")
            ComboBox3.Items.Add("Coclé")
            ComboBox3.Items.Add("Colón")
            ComboBox3.Items.Add("Chiriquí")
            ComboBox3.Items.Add("Darién")
            ComboBox3.Items.Add("Herrera")
            ComboBox3.Items.Add("Los Santos")
            ComboBox3.Items.Add("Panamá Este")
            ComboBox3.Items.Add("Panamá Oeste")
            ComboBox3.Items.Add("Sede")
        End If
    End Sub


    Private Sub MaskedTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaskedTextBox1.KeyPress
        Dim caracteresPermitidos As String = "1234567890:" & Convert.ToChar(8)
        Dim c As Char = e.KeyChar
        If (Not (caracteresPermitidos.Contains(c))) Then
            MessageBox.Show("Ingrese solamente números.", "ERROR de escritura", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Handled = True
        End If
    End Sub
End Class