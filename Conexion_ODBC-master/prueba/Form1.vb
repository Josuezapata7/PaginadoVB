Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form1

    Private conexion As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=crudNetCore;Integrated Security=True")
    Public adaptador As SqlDataAdapter
    Public dt As DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conexion.Open()
            MsgBox("Conexion Exitosa")

            adaptador = New SqlDataAdapter("select * from Libro", conexion)
            dt = New DataTable
            adaptador.Fill(dt)

            dgv_personalizado.Cargar_datos(dt)

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            conexion.Close()
        End Try

    End Sub

    Private Sub cerrar_ventana(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.Closing
        'If MessageBox.Show("Seguro que quiere salir?", "Cerrar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '    Cerrar()
        '    Console.WriteLine("Cerrado!")
        'Else
        '    e.Cancel = True
        'End If
    End Sub

    Private Sub dgv_personalizado_Load(sender As Object, e As EventArgs) Handles dgv_personalizado.Load

    End Sub
End Class
