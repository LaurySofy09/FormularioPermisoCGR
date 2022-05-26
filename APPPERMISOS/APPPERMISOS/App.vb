Imports System.Data.SqlClient

Public Class App

    Private Sub CrearNuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearNuevoToolStripMenuItem.Click
        Label1.Visible = False
        f4.Hide()
        f5.Hide()
        f6.Hide()
        f7.Hide()
        f8.Hide()
        f9.Hide()
        f3.MdiParent = Me
        f3.Show()
    End Sub

    Private Sub PorCédulaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorCédulaToolStripMenuItem.Click
        Label1.Visible = False
        f3.Hide()
        f5.Hide()
        f6.Hide()
        f7.Hide()
        f8.Hide()
        f9.Hide()
        f4.MdiParent = Me
        f4.Show()
    End Sub

    Private Sub PorNombreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorNombreToolStripMenuItem.Click
        Label1.Visible = False
        f3.Hide()
        f4.Hide()
        f6.Hide()
        f7.Hide()
        f8.Hide()
        f9.Hide()
        f5.MdiParent() = Me
        f5.Show()
    End Sub

    Private Sub PorCédulaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PorCédulaToolStripMenuItem1.Click
        Label1.Visible = False
        f3.Hide()
        f4.Hide()
        f5.Hide()
        f7.Hide()
        f8.Hide()
        f9.Hide()
        f6.MdiParent() = Me
        f6.Show()
    End Sub


    Private Sub PorNombreToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PorNombreToolStripMenuItem1.Click
        Label1.Visible = False
        f3.Hide()
        f4.Hide()
        f5.Hide()
        f6.Hide()
        f8.Hide()
        f9.Hide()
        f7.MdiParent() = Me
        f7.Show()
    End Sub


    Private Sub ConsultarPermisosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPermisosToolStripMenuItem.Click
        Label1.Visible = False
        f3.Hide()
        f4.Hide()
        f5.Hide()
        f6.Hide()
        f7.Hide()
        f9.Hide()
        f8.MdiParent() = Me
        f8.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Label1.Visible = False
        f3.Close()
        f4.Close()
        f5.Close()
        f6.Close()
        f7.Close()
        f8.Close()
        f9.Close()
        Me.Close()
        conexion.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        f3.TextBox1.Text = ""
        f3.TextBox2.Text = ""
        f3.TextBox3.Text = ""
        f3.TextBox3.Visible = False
        f3.MaskedTextBox1.Text = "00:00:00"
        f3.TextBox5.Text = ""
        f3.TextBox6.Text = ""
        f3.ComboBox3.Text = ""
        f3.ComboBox2.Text = ""
        f3.ComboBox1.Text = ""
        f3.ComboBox4.Text = ""
        f3.DateTimePicker1.Value = Now()
        f3.DateTimePicker2.Value = Now()
        f3.DateTimePicker3.Value = Now()
        f3.DateTimePicker4.Value = Now()
        f3.DateTimePicker5.Value = Now()
        f3.Label11.Visible = False
        f3.CheckBox1.Checked = False
        f3.MaskedTextBox1.Enabled = False
        f4.TextBox1.Text = ""
        f4.TextBox2.Text = ""
        f4.TextBox3.Text = ""
        f4.TextBox3.Visible = False
        f4.MaskedTextBox1.Text = "00:00:00"
        f4.TextBox5.Text = ""
        f4.TextBox6.Text = ""
        f4.ComboBox3.Text = ""
        f4.ComboBox2.Text = ""
        f4.ComboBox1.Text = ""
        f4.ComboBox4.Text = ""
        f4.DateTimePicker1.Value = Now()
        f4.DateTimePicker2.Value = Now()
        f4.DateTimePicker3.Value = Now()
        f4.DateTimePicker4.Value = Now()
        f4.DateTimePicker5.Value = Now()
        f4.CheckBox1.Checked = False
        f4.Label11.Visible = False
        f4.MaskedTextBox1.Enabled = False
        f5.TextBox1.Text = ""
        f5.TextBox2.Text = ""
        f5.TextBox3.Text = ""
        f5.TextBox3.Visible = False
        f5.MaskedTextBox1.Text = "00:00:00"
        f5.TextBox5.Text = ""
        f5.TextBox6.Text = ""
        f5.ComboBox3.Text = ""
        f5.ComboBox2.Text = ""
        f5.ComboBox1.Text = ""
        f5.ComboBox4.Text = ""
        f5.DateTimePicker1.Value = Now()
        f5.DateTimePicker2.Value = Now()
        f5.DateTimePicker3.Value = Now()
        f5.DateTimePicker4.Value = Now()
        f5.DateTimePicker5.Value = Now()
        f5.CheckBox1.Checked = False
        f5.Label11.Visible = False
        f5.MaskedTextBox1.Enabled = False
        f6.TextBox1.Text = ""
        f6.TextBox2.Text = ""
        f6.TextBox3.Text = ""
        f6.TextBox3.Visible = False
        f6.MaskedTextBox1.Text = "00:00:00"
        f6.TextBox5.Text = ""
        f6.TextBox6.Text = ""
        f6.ComboBox3.Text = ""
        f6.ComboBox2.Text = ""
        f6.ComboBox1.Text = ""
        f6.ComboBox4.Text = ""
        f6.DateTimePicker1.Value = Now()
        f6.DateTimePicker2.Value = Now()
        f6.DateTimePicker3.Value = Now()
        f6.DateTimePicker4.Value = Now()
        f6.DateTimePicker5.Value = Now()
        f6.CheckBox1.Checked = False
        f6.Label11.Visible = False
        f6.MaskedTextBox1.Enabled = False
        f7.TextBox1.Text = ""
        f7.TextBox2.Text = ""
        f7.TextBox3.Text = ""
        f7.TextBox3.Visible = False
        f7.MaskedTextBox1.Text = "00:00:00"
        f7.TextBox5.Text = ""
        f7.TextBox6.Text = ""
        f7.ComboBox3.Text = ""
        f7.ComboBox2.Text = ""
        f7.ComboBox1.Text = ""
        f7.ComboBox4.Text = ""
        f7.DateTimePicker1.Value = Now()
        f7.DateTimePicker2.Value = Now()
        f7.DateTimePicker3.Value = Now()
        f7.DateTimePicker4.Value = Now()
        f7.DateTimePicker5.Value = Now()
        f7.CheckBox1.Checked = False
        f7.Label11.Visible = False
        f7.MaskedTextBox1.Enabled = False
        f8.TextBox1.Text = ""
        f8.TextBox2.Text = ""
        f8.TextBox3.Text = ""
        f8.TextBox4.Text = ""
        f8.TextBox5.Text = ""
        f8.DataGridView1.DataSource = ""
        f9.TextBox1.Text = ""
        f9.TextBox2.Text = ""
        f9.TextBox3.Text = ""
        f9.TextBox3.Visible = False
        f9.MaskedTextBox1.Text = "00:00:00"
        f9.TextBox5.Text = ""
        f9.TextBox6.Text = ""
        f9.ComboBox3.Text = ""
        f9.ComboBox2.Text = ""
        f9.ComboBox1.Text = ""
        f9.ComboBox4.Text = ""
        f9.DateTimePicker1.Value = Now()
        f9.DateTimePicker2.Value = Now()
        f9.DateTimePicker3.Value = Now()
        f9.DateTimePicker4.Value = Now()
        f9.DateTimePicker5.Value = Now()
        f9.Label11.Visible = False
        f9.CheckBox1.Checked = False
        f9.MaskedTextBox1.Enabled = False

    End Sub

    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cadena As String = "select * from LSDLOGIN where id = '" & Login.TextBox1.Text & "'"
        Dim da As New SqlCommand(cadena, conexion)
        Dim drd As SqlDataReader
        drd = da.ExecuteReader()
        If drd.Read() Then
            Me.Label1.Text = "Hola, " & drd.Item("name").ToString
        End If
        drd.Close()
    End Sub

    Private Sub ImprimirPermisoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirPermisoToolStripMenuItem.Click
        Label1.Visible = False
        f9.Show()
    End Sub
End Class