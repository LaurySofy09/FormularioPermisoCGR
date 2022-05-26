Imports System.Data.SqlClient
Module ModuleConnection
    Public conexion As New SqlConnection
    Public comando As New SqlCommand
    Public estado As String
    Public f3 As New Nuevo
    Public f4 As New Actualizar1
    Public f5 As New Actualizar2
    Public f6 As New Eliminar1
    Public f7 As New Eliminar2
    Public f8 As New Consultar1
    Public f9 As New Imprimir

    Sub enlace()
        Try
            conexion.ConnectionString = "Data Source=cgr-app-95\EXAMEN;Initial Catalog=CONCURSA;User ID=PRACTICANTE;Password=_pARTICIPANTE$01"
            conexion.Open()
            estado = "Conected"
        Catch ex As Exception
            estado = "Disconnected"
        End Try
    End Sub
End Module
