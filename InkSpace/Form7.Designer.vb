<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.lbl_trabalhos = New System.Windows.Forms.Label()
        Me.pic_voltar = New System.Windows.Forms.PictureBox()
        Me.datepicker_busca = New System.Windows.Forms.DateTimePicker()
        Me.btn_busca = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dgv_pedidos = New System.Windows.Forms.DataGridView()
        Me.cod_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpf_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefone_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horario_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.disponibilidade_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preco_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imagem_ref_pedido = New System.Windows.Forms.DataGridViewImageColumn()
        Me.desc_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.pic_voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_trabalhos
        '
        Me.lbl_trabalhos.AutoSize = True
        Me.lbl_trabalhos.Font = New System.Drawing.Font("Britannic Bold", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_trabalhos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_trabalhos.Location = New System.Drawing.Point(101, 24)
        Me.lbl_trabalhos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_trabalhos.Name = "lbl_trabalhos"
        Me.lbl_trabalhos.Size = New System.Drawing.Size(252, 71)
        Me.lbl_trabalhos.TabIndex = 12
        Me.lbl_trabalhos.Text = "Pedidos"
        '
        'pic_voltar
        '
        Me.pic_voltar.Image = CType(resources.GetObject("pic_voltar.Image"), System.Drawing.Image)
        Me.pic_voltar.InitialImage = Nothing
        Me.pic_voltar.Location = New System.Drawing.Point(46, 35)
        Me.pic_voltar.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_voltar.Name = "pic_voltar"
        Me.pic_voltar.Size = New System.Drawing.Size(51, 48)
        Me.pic_voltar.TabIndex = 28
        Me.pic_voltar.TabStop = False
        '
        'datepicker_busca
        '
        Me.datepicker_busca.Location = New System.Drawing.Point(441, 63)
        Me.datepicker_busca.Name = "datepicker_busca"
        Me.datepicker_busca.Size = New System.Drawing.Size(212, 20)
        Me.datepicker_busca.TabIndex = 29
        '
        'btn_busca
        '
        Me.btn_busca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_busca.FlatAppearance.BorderSize = 5
        Me.btn_busca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_busca.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_busca.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_busca.Location = New System.Drawing.Point(659, 62)
        Me.btn_busca.Name = "btn_busca"
        Me.btn_busca.Size = New System.Drawing.Size(75, 23)
        Me.btn_busca.TabIndex = 30
        Me.btn_busca.Text = "Buscar"
        Me.btn_busca.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(380, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 23)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Data:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Gray
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(847, 37)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(51, 48)
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'dgv_pedidos
        '
        Me.dgv_pedidos.AllowUserToAddRows = False
        Me.dgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_pedido, Me.nome_pedido, Me.cpf_pedido, Me.telefone_pedido, Me.data_pedido, Me.horario_pedido, Me.disponibilidade_pedido, Me.tipo_pedido, Me.preco_pedido, Me.imagem_ref_pedido, Me.desc_pedido})
        Me.dgv_pedidos.Location = New System.Drawing.Point(46, 117)
        Me.dgv_pedidos.Name = "dgv_pedidos"
        Me.dgv_pedidos.RowHeadersVisible = False
        Me.dgv_pedidos.Size = New System.Drawing.Size(852, 456)
        Me.dgv_pedidos.TabIndex = 34
        '
        'cod_pedido
        '
        Me.cod_pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.cod_pedido.HeaderText = "Código"
        Me.cod_pedido.Name = "cod_pedido"
        Me.cod_pedido.Width = 50
        '
        'nome_pedido
        '
        Me.nome_pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.nome_pedido.HeaderText = "Nome"
        Me.nome_pedido.Name = "nome_pedido"
        Me.nome_pedido.Width = 60
        '
        'cpf_pedido
        '
        Me.cpf_pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cpf_pedido.HeaderText = "CPF"
        Me.cpf_pedido.Name = "cpf_pedido"
        Me.cpf_pedido.Width = 52
        '
        'telefone_pedido
        '
        Me.telefone_pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.telefone_pedido.HeaderText = "Telefone"
        Me.telefone_pedido.Name = "telefone_pedido"
        Me.telefone_pedido.Width = 74
        '
        'data_pedido
        '
        Me.data_pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.data_pedido.HeaderText = "Data"
        Me.data_pedido.Name = "data_pedido"
        Me.data_pedido.Width = 55
        '
        'horario_pedido
        '
        Me.horario_pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.horario_pedido.HeaderText = "Horário"
        Me.horario_pedido.Name = "horario_pedido"
        Me.horario_pedido.Width = 66
        '
        'disponibilidade_pedido
        '
        Me.disponibilidade_pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.disponibilidade_pedido.HeaderText = "Disponibilidade"
        Me.disponibilidade_pedido.Name = "disponibilidade_pedido"
        Me.disponibilidade_pedido.Width = 103
        '
        'tipo_pedido
        '
        Me.tipo_pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.tipo_pedido.HeaderText = "Tipo"
        Me.tipo_pedido.Name = "tipo_pedido"
        Me.tipo_pedido.Width = 53
        '
        'preco_pedido
        '
        Me.preco_pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.preco_pedido.HeaderText = "Preço"
        Me.preco_pedido.Name = "preco_pedido"
        Me.preco_pedido.Width = 60
        '
        'imagem_ref_pedido
        '
        Me.imagem_ref_pedido.HeaderText = "Imagem"
        Me.imagem_ref_pedido.Name = "imagem_ref_pedido"
        Me.imagem_ref_pedido.Width = 196
        '
        'desc_pedido
        '
        Me.desc_pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.desc_pedido.HeaderText = "Descrição"
        Me.desc_pedido.Name = "desc_pedido"
        Me.desc_pedido.Width = 80
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(937, 585)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgv_pedidos)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_busca)
        Me.Controls.Add(Me.datepicker_busca)
        Me.Controls.Add(Me.pic_voltar)
        Me.Controls.Add(Me.lbl_trabalhos)
        Me.MaximizeBox = False
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.pic_voltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_trabalhos As Label
    Friend WithEvents pic_voltar As PictureBox
    Friend WithEvents datepicker_busca As DateTimePicker
    Friend WithEvents btn_busca As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents dgv_pedidos As DataGridView
    Friend WithEvents cod_pedido As DataGridViewTextBoxColumn
    Friend WithEvents nome_pedido As DataGridViewTextBoxColumn
    Friend WithEvents cpf_pedido As DataGridViewTextBoxColumn
    Friend WithEvents telefone_pedido As DataGridViewTextBoxColumn
    Friend WithEvents data_pedido As DataGridViewTextBoxColumn
    Friend WithEvents horario_pedido As DataGridViewTextBoxColumn
    Friend WithEvents disponibilidade_pedido As DataGridViewTextBoxColumn
    Friend WithEvents tipo_pedido As DataGridViewTextBoxColumn
    Friend WithEvents preco_pedido As DataGridViewTextBoxColumn
    Friend WithEvents imagem_ref_pedido As DataGridViewImageColumn
    Friend WithEvents desc_pedido As DataGridViewTextBoxColumn
End Class
