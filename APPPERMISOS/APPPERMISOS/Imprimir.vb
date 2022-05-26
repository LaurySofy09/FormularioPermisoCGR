Imports System.Drawing.Printing
Imports System.Data.SqlClient

Public Class Imprimir
    Dim imagen As Bitmap

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        seleccion()
    End Sub

    Sub seleccion()
        Dim dt As New DataTable
        Dim cadena As String = "select * from LSDREGISTER where id = '" & TextBox4.Text & "' and fechainicial = '" & DateTimePicker6.Value.ToShortDateString & "'"
        Dim da As New SqlCommand(cadena, conexion)
        Dim drd As SqlDataReader
        drd = da.ExecuteReader()
        If drd.Read() Then
            Me.TextBox1.Text = drd.Item("nombre").ToString
            Me.TextBox2.Text = drd.Item("id").ToString
            Me.ComboBox1.Text = drd.Item("direccion").ToString
            Me.ComboBox2.Text = drd.Item("departamento").ToString
            Me.ComboBox3.Text = drd.Item("seccion").ToString
            Me.ComboBox4.Text = drd.Item("tipopermiso").ToString
            Me.TextBox3.Text = drd.Item("otros").ToString
            Me.DateTimePicker1.Value = drd.Item("fechainicial").ToString
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

    Sub rango()
        If CheckBox1.Checked = True Then
            DateTimePicker2.Visible = True
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CaptureScreen()
        If PrintDialog1.ShowDialog() Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    Sub CaptureScreen()
        Dim s As Size
        Dim grafico = Me.CreateGraphics()
        s = Me.Size
        imagen = New Bitmap(s.Width, s.Height, grafico)
        Dim b = Graphics.FromImage(imagen)
        b.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, s)
    End Sub

    Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(imagen, 0, 0)
    End Sub

End Class