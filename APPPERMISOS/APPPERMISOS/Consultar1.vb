Imports System.Data.SqlClient

Public Class Consultar1

    Private Sub Consultar1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim cadena As String = "select * from LSDREGISTER where id = '" & TextBox2.Text & "'order by fechainicial desc"

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Try
            da = New SqlDataAdapter(cadena, conexion)
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                Me.DataGridView1.DataSource = dt
                Me.LSDREGISTERTableAdapter.Fill(Me.CONCURSADataSet.LSDREGISTER)
            Else
                MsgBox("No hay registro")
                Limpiar()
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try

        Dim de As New SqlCommand(cadena, conexion)
        Dim drd As SqlDataReader

        drd = de.ExecuteReader()
        If drd.Read() = True Then
            Me.TextBox1.Text = drd.Item("nombre").ToString
            Me.TextBox3.Text = drd.Item("direccion").ToString
            Me.TextBox4.Text = drd.Item("departamento").ToString
            Me.TextBox5.Text = drd.Item("seccion").ToString
        End If
        drd.Close()
    End Sub

    Sub Limpiar()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        DataGridView1.DataSource = ""
        Reset()

    End Sub
End Class