<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_pedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pedidos))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.date_data = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_hora = New System.Windows.Forms.ComboBox()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.pic_voltar = New System.Windows.Forms.PictureBox()
        Me.pic_limpar = New System.Windows.Forms.PictureBox()
        Me.pic_confirmar = New System.Windows.Forms.PictureBox()
        Me.lbl_voltar = New System.Windows.Forms.Label()
        Me.lbl_limpar = New System.Windows.Forms.Label()
        Me.lbl_confirmar = New System.Windows.Forms.Label()
        Me.btn_img = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_preco = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_disponivel = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MySqlCommand1 = New MySqlConnector.MySqlCommand()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_limpar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_confirmar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 162)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_nome.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_nome.Location = New System.Drawing.Point(224, 26)
        Me.lbl_nome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(79, 30)
        Me.lbl_nome.TabIndex = 7
        Me.lbl_nome.Text = "Nome"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(229, 59)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(361, 20)
        Me.txt_nome.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(224, 103)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 30)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CPF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(403, 103)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 30)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Telefone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(11, 190)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 30)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Data"
        '
        'date_data
        '
        Me.date_data.Location = New System.Drawing.Point(16, 224)
        Me.date_data.Name = "date_data"
        Me.date_data.Size = New System.Drawing.Size(214, 20)
        Me.date_data.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(11, 263)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 30)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Horário"
        '
        'cmb_hora
        '
        Me.cmb_hora.FormattingEnabled = True
        Me.cmb_hora.Items.AddRange(New Object() {"8:00", "10:30", "13:00", "15:30", "18:00"})
        Me.cmb_hora.Location = New System.Drawing.Point(16, 296)
        Me.cmb_hora.Name = "cmb_hora"
        Me.cmb_hora.Size = New System.Drawing.Size(102, 21)
        Me.cmb_hora.TabIndex = 16
        '
        'cmb_tipo
        '
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Items.AddRange(New Object() {"Preto e Branco", "Colorido"})
        Me.cmb_tipo.Location = New System.Drawing.Point(19, 366)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipo.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(14, 333)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 30)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Tipo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(320, 176)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(277, 30)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Imagem de Referência"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(322, 263)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(265, 30)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Descrição (Opcional)"
        '
        'txt_desc
        '
        Me.txt_desc.Location = New System.Drawing.Point(327, 296)
        Me.txt_desc.Multiline = True
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(272, 91)
        Me.txt_desc.TabIndex = 21
        '
        'pic_voltar
        '
        Me.pic_voltar.Image = CType(resources.GetObject("pic_voltar.Image"), System.Drawing.Image)
        Me.pic_voltar.InitialImage = Nothing
        Me.pic_voltar.Location = New System.Drawing.Point(106, 18)
        Me.pic_voltar.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_voltar.Name = "pic_voltar"
        Me.pic_voltar.Size = New System.Drawing.Size(51, 48)
        Me.pic_voltar.TabIndex = 22
        Me.pic_voltar.TabStop = False
        '
        'pic_limpar
        '
        Me.pic_limpar.Image = CType(resources.GetObject("pic_limpar.Image"), System.Drawing.Image)
        Me.pic_limpar.InitialImage = Nothing
        Me.pic_limpar.Location = New System.Drawing.Point(266, 18)
        Me.pic_limpar.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_limpar.Name = "pic_limpar"
        Me.pic_limpar.Size = New System.Drawing.Size(51, 49)
        Me.pic_limpar.TabIndex = 23
        Me.pic_limpar.TabStop = False
        '
        'pic_confirmar
        '
        Me.pic_confirmar.Image = CType(resources.GetObject("pic_confirmar.Image"), System.Drawing.Image)
        Me.pic_confirmar.InitialImage = Nothing
        Me.pic_confirmar.Location = New System.Drawing.Point(434, 18)
        Me.pic_confirmar.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_confirmar.Name = "pic_confirmar"
        Me.pic_confirmar.Size = New System.Drawing.Size(45, 49)
        Me.pic_confirmar.TabIndex = 24
        Me.pic_confirmar.TabStop = False
        '
        'lbl_voltar
        '
        Me.lbl_voltar.AutoSize = True
        Me.lbl_voltar.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_voltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_voltar.Location = New System.Drawing.Point(92, 68)
        Me.lbl_voltar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_voltar.Name = "lbl_voltar"
        Me.lbl_voltar.Size = New System.Drawing.Size(84, 30)
        Me.lbl_voltar.TabIndex = 25
        Me.lbl_voltar.Text = "Voltar"
        '
        'lbl_limpar
        '
        Me.lbl_limpar.AutoSize = True
        Me.lbl_limpar.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_limpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_limpar.Location = New System.Drawing.Point(243, 68)
        Me.lbl_limpar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_limpar.Name = "lbl_limpar"
        Me.lbl_limpar.Size = New System.Drawing.Size(98, 30)
        Me.lbl_limpar.TabIndex = 26
        Me.lbl_limpar.Text = "Limpar"
        '
        'lbl_confirmar
        '
        Me.lbl_confirmar.AutoSize = True
        Me.lbl_confirmar.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_confirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_confirmar.Location = New System.Drawing.Point(405, 68)
        Me.lbl_confirmar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_confirmar.Name = "lbl_confirmar"
        Me.lbl_confirmar.Size = New System.Drawing.Size(111, 30)
        Me.lbl_confirmar.TabIndex = 27
        Me.lbl_confirmar.Text = "Agendar"
        '
        'btn_img
        '
        Me.btn_img.Location = New System.Drawing.Point(347, 221)
        Me.btn_img.Name = "btn_img"
        Me.btn_img.Size = New System.Drawing.Size(90, 23)
        Me.btn_img.TabIndex = 28
        Me.btn_img.Text = "Fazer Upload"
        Me.btn_img.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(166, 333)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 30)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Preço"
        '
        'txt_preco
        '
        Me.txt_preco.Enabled = False
        Me.txt_preco.Location = New System.Drawing.Point(171, 366)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(121, 20)
        Me.txt_preco.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(166, 263)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 30)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Disponível"
        '
        'txt_disponivel
        '
        Me.txt_disponivel.Enabled = False
        Me.txt_disponivel.Location = New System.Drawing.Point(171, 296)
        Me.txt_disponivel.Name = "txt_disponivel"
        Me.txt_disponivel.Size = New System.Drawing.Size(121, 20)
        Me.txt_disponivel.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Controls.Add(Me.txt_telefone)
        Me.GroupBox1.Controls.Add(Me.txt_cpf)
        Me.GroupBox1.Location = New System.Drawing.Point(219, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 161)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'txt_telefone
        '
        Me.txt_telefone.Location = New System.Drawing.Point(189, 124)
        Me.txt_telefone.Mask = "(99) 00000-0000"
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(148, 20)
        Me.txt_telefone.TabIndex = 1
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(10, 124)
        Me.txt_cpf.Mask = "000.000.000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(148, 20)
        Me.txt_cpf.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox3.Controls.Add(Me.pic_limpar)
        Me.GroupBox3.Controls.Add(Me.pic_voltar)
        Me.GroupBox3.Controls.Add(Me.pic_confirmar)
        Me.GroupBox3.Controls.Add(Me.lbl_voltar)
        Me.GroupBox3.Controls.Add(Me.lbl_limpar)
        Me.GroupBox3.Controls.Add(Me.lbl_confirmar)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 393)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(583, 104)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(467, 209)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CommandTimeout = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.Transaction = Nothing
        Me.MySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(305, 165)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(10, 222)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        '
        'frm_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(625, 521)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txt_disponivel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_preco)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_img)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmb_tipo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_hora)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.date_data)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.MaximizeBox = False
        Me.Name = "frm_pedidos"
        Me.Text = "Pedidos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_voltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_limpar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_confirmar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_nome As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents date_data As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_hora As ComboBox
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_desc As TextBox
    Friend WithEvents pic_voltar As PictureBox
    Friend WithEvents pic_limpar As PictureBox
    Friend WithEvents pic_confirmar As PictureBox
    Friend WithEvents lbl_voltar As Label
    Friend WithEvents lbl_limpar As Label
    Friend WithEvents lbl_confirmar As Label
    Friend WithEvents btn_img As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_preco As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_disponivel As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MySqlCommand1 As MySqlConnector.MySqlCommand
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
