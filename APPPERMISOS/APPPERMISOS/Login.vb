Imports System.Data.SqlClient

Public Class Login

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()
        Label5.Text = estado
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MsgBox("Contactar al CAU")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Logear()
    End Sub

    Private Sub Logear()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim cadena As String = "select * from LSDLOGIN where id = '" & TextBox1.Text & "' and password ='" & TextBox2.Text & "'"
        If TextBox1.Text = "" Then
            MsgBox("Insertar usuario")
            TextBox1.Focus()
        ElseIf TextBox2.Text = "" Then
            MsgBox("Insertar contraseña")
            TextBox2.Focus()
        Else
            Try
                da = New SqlDataAdapter(cadena, conexion)
                da.Fill(dt)
                If dt.Rows.Count <> 0 Then
                    Dim f2 As New App
                    f2.Show()
                    Me.Hide()
                    'Me.Close()
                Else
                    MsgBox("Acceso Incorrecto")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class
