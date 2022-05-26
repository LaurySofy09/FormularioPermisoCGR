Imports System.Data.SqlClient

Public Class Eliminar2

    Private Sub Actualizar1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()
        'Label4.Text = estado
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        seleccion()
    End Sub

    Sub seleccion()
        Dim dt As New DataTable
        Dim cadena As String = "select * from LSDREGISTER where nombre = '" & TextBox1.Text & "' and fechainicial = '" & DateTimePicker1.Value.ToShortDateString & "'"
        Dim da As New SqlCommand(cadena, conexion)
        Dim drd As SqlDataReader
        drd = da.ExecuteReader()
        If drd.Read() Then
            Me.TextBox2.Text = drd.Item("id").ToString
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
        eliminar()
    End Sub

    Sub eliminar()
        Dim cadena As String = "Delete from LSDREGISTER where nombre = '" & TextBox1.Text & "' and fechainicial = '" & DateTimePicker1.Value.ToShortDateString & "'"
        If MsgBox("Esta seguro que desea eliminar este registro?", vbYesNo) = vbYes Then
            Try
                comando = New SqlCommand(cadena, conexion)
                comando.ExecuteNonQuery()
                MsgBox("Eliminado con éxito")
                Limpiar()
            Catch ex As Exception
                MsgBox(ex.ToString)
                MsgBox("Error. Verifique")
            End Try
        End If
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
        ElseIf CheckBox1.Checked = False Then
            DateTimePicker2.Visible = False
        End If
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
        TextBox3.Visible = False
        Label11.Visible = False
        MaskedTextBox1.Enabled = False
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
End Class