Public Class DGVPaginado
    Private total_los_datos = New DataTable
    Private tabla = New DataTable
    Private total As Integer = 0
    Private pagina As Integer = 0
    Private maximo_paginas As Integer = 0
    Private items_por_pagina As Integer = 10

    Public Sub Cargar_datos(dt As DataTable)
        total_los_datos = dt
        total = dt.Rows.Count

        maximo_paginas = Math.Ceiling(total / items_por_pagina)
        lbl_totalPaginas.Text = maximo_paginas
        dgv_Vista.DataSource = Split(total_los_datos)
        For Each row As DataGridViewRow In dgv_Vista.Rows
            Dim valor As String = CStr(row.Cells(0).Value)
            MsgBox(valor)
        Next
        Habilitar_Botones()
    End Sub

    Private Function Split(dt As DataTable) As DataTable
        lbl_Pagina.Text = (pagina + 1)
        Habilitar_Botones()
        Return dt.Select.Skip(items_por_pagina * pagina).Take(items_por_pagina).CopyToDataTable()
    End Function

    Private Sub btn_Sig_Click(sender As Object, e As EventArgs) Handles btn_Sig.Click
        pagina = pagina + 1
        dgv_Vista.DataSource = Split(total_los_datos)
        For Each row As DataGridViewRow In dgv_Vista.Rows
            Dim valor As String = CStr(row.Cells(0).Value)
            MsgBox(valor)
        Next
    End Sub

    Private Sub btn_Previo_Click(sender As Object, e As EventArgs) Handles btn_Previo.Click
        pagina = pagina - 1
        dgv_Vista.DataSource = Split(total_los_datos)
        For Each row As DataGridViewRow In dgv_Vista.Rows
            Dim valor As String = CStr(row.Cells(0).Value)
            MsgBox(valor)
        Next
    End Sub

    Private Sub Habilitar_Botones()
        If pagina = 0 Then
            btn_Previo.Enabled = False
        Else
            btn_Previo.Enabled = True
        End If

        If pagina = (maximo_paginas - 1) Then
            btn_Sig.Enabled = False
        Else
            btn_Sig.Enabled = True
        End If
    End Sub

    Private Sub btn_Primera_Click(sender As Object, e As EventArgs) Handles btn_Primera.Click
        pagina = 0
        dgv_Vista.DataSource = Split(total_los_datos)
        For Each row As DataGridViewRow In dgv_Vista.Rows
            Dim valor As String = CStr(row.Cells(0).Value)
            MsgBox(valor)
        Next
    End Sub

    Private Sub btn_Ultima_Click(sender As Object, e As EventArgs) Handles btn_Ultima.Click
        pagina = maximo_paginas - 1
        dgv_Vista.DataSource = Split(total_los_datos)
        For Each row As DataGridViewRow In dgv_Vista.Rows
            Dim valor As String = CStr(row.Cells(0).Value)
            MsgBox(valor)
        Next
    End Sub

    Private Sub dgv_Vista_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgv_Vista.RowsAdded
    End Sub

    Private Sub lbl_totalPaginas_Click(sender As Object, e As EventArgs) Handles lbl_totalPaginas.Click

    End Sub

    Private Sub lbl_Pagina_Click(sender As Object, e As EventArgs) Handles lbl_Pagina.Click

    End Sub
End Class
