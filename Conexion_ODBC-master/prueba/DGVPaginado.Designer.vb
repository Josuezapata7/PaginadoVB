<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DGVPaginado
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgv_Vista = New System.Windows.Forms.DataGridView()
        Me.btn_Sig = New System.Windows.Forms.Button()
        Me.btn_Previo = New System.Windows.Forms.Button()
        Me.lbl_Pagina = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_totalPaginas = New System.Windows.Forms.Label()
        Me.btn_Primera = New System.Windows.Forms.Button()
        Me.btn_Ultima = New System.Windows.Forms.Button()
        CType(Me.dgv_Vista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Vista
        '
        Me.dgv_Vista.AllowUserToAddRows = False
        Me.dgv_Vista.AllowUserToDeleteRows = False
        Me.dgv_Vista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Vista.Location = New System.Drawing.Point(22, 21)
        Me.dgv_Vista.Name = "dgv_Vista"
        Me.dgv_Vista.ReadOnly = True
        Me.dgv_Vista.Size = New System.Drawing.Size(589, 325)
        Me.dgv_Vista.TabIndex = 0
        '
        'btn_Sig
        '
        Me.btn_Sig.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Sig.Location = New System.Drawing.Point(500, 352)
        Me.btn_Sig.Name = "btn_Sig"
        Me.btn_Sig.Size = New System.Drawing.Size(111, 37)
        Me.btn_Sig.TabIndex = 1
        Me.btn_Sig.Text = "Siguiente"
        Me.btn_Sig.UseVisualStyleBackColor = True
        '
        'btn_Previo
        '
        Me.btn_Previo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Previo.Location = New System.Drawing.Point(22, 352)
        Me.btn_Previo.Name = "btn_Previo"
        Me.btn_Previo.Size = New System.Drawing.Size(124, 37)
        Me.btn_Previo.TabIndex = 2
        Me.btn_Previo.Text = "Previo"
        Me.btn_Previo.UseVisualStyleBackColor = True
        '
        'lbl_Pagina
        '
        Me.lbl_Pagina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Pagina.AutoSize = True
        Me.lbl_Pagina.Location = New System.Drawing.Point(277, 364)
        Me.lbl_Pagina.Name = "lbl_Pagina"
        Me.lbl_Pagina.Size = New System.Drawing.Size(13, 13)
        Me.lbl_Pagina.TabIndex = 3
        Me.lbl_Pagina.Text = "0"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 364)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "/"
        '
        'lbl_totalPaginas
        '
        Me.lbl_totalPaginas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_totalPaginas.AutoSize = True
        Me.lbl_totalPaginas.Location = New System.Drawing.Point(367, 364)
        Me.lbl_totalPaginas.Name = "lbl_totalPaginas"
        Me.lbl_totalPaginas.Size = New System.Drawing.Size(13, 13)
        Me.lbl_totalPaginas.TabIndex = 5
        Me.lbl_totalPaginas.Text = "0"
        '
        'btn_Primera
        '
        Me.btn_Primera.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Primera.Location = New System.Drawing.Point(152, 352)
        Me.btn_Primera.Name = "btn_Primera"
        Me.btn_Primera.Size = New System.Drawing.Size(92, 37)
        Me.btn_Primera.TabIndex = 6
        Me.btn_Primera.Text = "Primera"
        Me.btn_Primera.UseVisualStyleBackColor = True
        '
        'btn_Ultima
        '
        Me.btn_Ultima.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Ultima.Location = New System.Drawing.Point(402, 352)
        Me.btn_Ultima.Name = "btn_Ultima"
        Me.btn_Ultima.Size = New System.Drawing.Size(92, 37)
        Me.btn_Ultima.TabIndex = 7
        Me.btn_Ultima.Text = "Ultima"
        Me.btn_Ultima.UseVisualStyleBackColor = True
        '
        'DGVPaginado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_Ultima)
        Me.Controls.Add(Me.btn_Primera)
        Me.Controls.Add(Me.lbl_totalPaginas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_Pagina)
        Me.Controls.Add(Me.btn_Previo)
        Me.Controls.Add(Me.btn_Sig)
        Me.Controls.Add(Me.dgv_Vista)
        Me.Name = "DGVPaginado"
        Me.Size = New System.Drawing.Size(637, 402)
        CType(Me.dgv_Vista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_Vista As DataGridView
    Friend WithEvents btn_Sig As Button
    Friend WithEvents btn_Previo As Button
    Friend WithEvents lbl_Pagina As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_totalPaginas As Label
    Friend WithEvents btn_Primera As Button
    Friend WithEvents btn_Ultima As Button
End Class
