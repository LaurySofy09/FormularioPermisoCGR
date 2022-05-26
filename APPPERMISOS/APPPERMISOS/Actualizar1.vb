Imports System.Data.SqlClient

Public Class Actualizar1

    Private Sub Actualizar1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()
        'Label4.Text = estado
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        seleccion()
    End Sub

    Sub seleccion()
        Dim cadena As String = "select * from LSDREGISTER where id = '" & TextBox2.Text & "' and fechainicial = '" & DateTimePicker1.Value.ToShortDateString & "'"
        Dim da As New SqlCommand(cadena, conexion)
        Dim drd As SqlDataReader
        drd = da.ExecuteReader()
        If drd.Read() Then
            Me.TextBox1.Text = drd.Item("nombre").ToString
            Me.ComboBox1.Text = drd.Item("direccion").ToString
            Me.ComboBox2.Text = drd.Item("departamento").ToString
            Me.ComboBox3.Text = drd.Item("seccion").ToString
            Me.ComboBox4.Text = drd.Item("tipopermiso").ToString
            Me.TextBox3.Text = drd.Item("otros").ToString
            Me.DateTimePicker6.Value = drd.Item("fechainicial").ToString
            Me.DateTimePicker2.Value = drd.Item("fechafinal").ToString
            Me.DateTimePicker5.Value = drd.Item("fechaactual").ToString
            Me.CheckBox1.Checked = drd.Item("rango").ToString
            Me.DateTimePicker3.Text = drd.Item("horainicial").ToString
            Me.DateTimePicker4.Text = drd.Item("horafinal").ToString
            Me.MaskedTextBox1.Text = drd.Item("horatotal").ToString
            Me.TextBox5.Text = drd.Item("jefe_supervisor").ToString
            Me.TextBox6.Text = drd.Item("observacion").ToString

            rango()

        Else
            MsgBox("No se ha encontrado registro")
            Limpiar()
        End If
        drd.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        validaciones()
    End Sub

    Sub modificar()
        Dim cadena As String = "Update LSDREGISTER set nombre = '" & TextBox1.Text & "', direccion = '" & ComboBox1.Text & "', departamento = '" & ComboBox2.Text & "', Seccion = '" & ComboBox3.Text & "', tipopermiso = '" & ComboBox4.Text & "', otros = '" & TextBox3.Text & "', fechainicial = '" & DateTimePicker6.Value.ToShortDateString & "', fechafinal = '" & DateTimePicker2.Value.ToShortDateString & "', fechaactual = '" & DateTimePicker5.Value.ToShortDateString & "', rango = '" & CheckBox1.Checked & "', horainicial = '" & DateTimePicker3.Value.ToLongTimeString & "', horafinal = '" & DateTimePicker4.Value.ToLongTimeString & "', horatotal = '" & MaskedTextBox1.Text & "', jefe_supervisor = '" & TextBox5.Text & "', observacion = '" & TextBox6.Text & "' where id = '" & TextBox2.Text & "' and fechainicial = '" & DateTimePicker1.Value.ToShortDateString & "'"
        Try
            comando = New SqlCommand(cadena, conexion)
            comando.ExecuteNonQuery()
            MsgBox("Actualizado con éxito")
            Limpiar()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error. Verifique")
        End Try
    End Sub

    Sub rango()
        If CheckBox1.Checked = True Then
            DateTimePicker2.Visible = True
        ElseIf CheckBox1.Checked = False Then
            DateTimePicker2.Visible = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            DateTimePicker2.Visible = True
            MaskedTextBox1.Enabled = False
        ElseIf CheckBox1.Checked = False Then
            DateTimePicker2.Visible = False
        End If
    End Sub

    Sub Limpiar()
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
            modificar()
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


    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.Text = "Otros" Then
            TextBox3.Visible = True
            Label11.Visible = True
        Else
            TextBox3.Visible = False
            Label11.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fechainicial, fechafinal As Date
        Dim dias, horas As Integer

        fechainicial = DateTimePicker6.Value.ToShortDateString
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
            MaskedTextBox1.Enabled = False
        ElseIf CheckBox1.Checked = False And horafinal < horainicial Then
            MaskedTextBox1.Enabled = True
            MaskedTextBox1.Text = intervalo.ToString
        End If
    End Sub

End Class