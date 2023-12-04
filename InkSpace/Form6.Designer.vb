<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.lbl_trabalhos = New System.Windows.Forms.Label()
        Me.dgv_adm = New System.Windows.Forms.DataGridView()
        Me.pic_add_adm = New System.Windows.Forms.PictureBox()
        Me.pic_voltar = New System.Windows.Forms.PictureBox()
        Me.lbl_voltar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pic_limpar = New System.Windows.Forms.PictureBox()
        Me.lbl_limpar = New System.Windows.Forms.Label()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_busca = New System.Windows.Forms.Button()
        CType(Me.dgv_adm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_add_adm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_limpar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_trabalhos
        '
        Me.lbl_trabalhos.AutoSize = True
        Me.lbl_trabalhos.Font = New System.Drawing.Font("Britannic Bold", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_trabalhos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_trabalhos.Location = New System.Drawing.Point(18, 9)
        Me.lbl_trabalhos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_trabalhos.Name = "lbl_trabalhos"
        Me.lbl_trabalhos.Size = New System.Drawing.Size(496, 71)
        Me.lbl_trabalhos.TabIndex = 10
        Me.lbl_trabalhos.Text = "Administradores"
        '
        'dgv_adm
        '
        Me.dgv_adm.AllowUserToAddRows = False
        Me.dgv_adm.AllowUserToDeleteRows = False
        Me.dgv_adm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_adm.Location = New System.Drawing.Point(106, 163)
        Me.dgv_adm.Name = "dgv_adm"
        Me.dgv_adm.ReadOnly = True
        Me.dgv_adm.Size = New System.Drawing.Size(315, 314)
        Me.dgv_adm.TabIndex = 11
        '
        'pic_add_adm
        '
        Me.pic_add_adm.Image = CType(resources.GetObject("pic_add_adm.Image"), System.Drawing.Image)
        Me.pic_add_adm.Location = New System.Drawing.Point(374, 491)
        Me.pic_add_adm.Name = "pic_add_adm"
        Me.pic_add_adm.Size = New System.Drawing.Size(54, 50)
        Me.pic_add_adm.TabIndex = 12
        Me.pic_add_adm.TabStop = False
        Me.pic_add_adm.Tag = ""
        '
        'pic_voltar
        '
        Me.pic_voltar.Image = CType(resources.GetObject("pic_voltar.Image"), System.Drawing.Image)
        Me.pic_voltar.InitialImage = Nothing
        Me.pic_voltar.Location = New System.Drawing.Point(106, 493)
        Me.pic_voltar.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_voltar.Name = "pic_voltar"
        Me.pic_voltar.Size = New System.Drawing.Size(51, 48)
        Me.pic_voltar.TabIndex = 26
        Me.pic_voltar.TabStop = False
        '
        'lbl_voltar
        '
        Me.lbl_voltar.AutoSize = True
        Me.lbl_voltar.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_voltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_voltar.Location = New System.Drawing.Point(92, 543)
        Me.lbl_voltar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_voltar.Name = "lbl_voltar"
        Me.lbl_voltar.Size = New System.Drawing.Size(84, 30)
        Me.lbl_voltar.TabIndex = 27
        Me.lbl_voltar.Text = "Voltar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(339, 541)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 30)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Adicionar"
        '
        'pic_limpar
        '
        Me.pic_limpar.Image = CType(resources.GetObject("pic_limpar.Image"), System.Drawing.Image)
        Me.pic_limpar.InitialImage = Nothing
        Me.pic_limpar.Location = New System.Drawing.Point(239, 492)
        Me.pic_limpar.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_limpar.Name = "pic_limpar"
        Me.pic_limpar.Size = New System.Drawing.Size(51, 49)
        Me.pic_limpar.TabIndex = 29
        Me.pic_limpar.TabStop = False
        '
        'lbl_limpar
        '
        Me.lbl_limpar.AutoSize = True
        Me.lbl_limpar.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_limpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_limpar.Location = New System.Drawing.Point(216, 542)
        Me.lbl_limpar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_limpar.Name = "lbl_limpar"
        Me.lbl_limpar.Size = New System.Drawing.Size(97, 30)
        Me.lbl_limpar.TabIndex = 30
        Me.lbl_limpar.Text = "Apagar"
        '
        'txt_login
        '
        Me.txt_login.Location = New System.Drawing.Point(206, 123)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(100, 20)
        Me.txt_login.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(139, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 21)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Login:"
        '
        'btn_busca
        '
        Me.btn_busca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_busca.FlatAppearance.BorderSize = 5
        Me.btn_busca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_busca.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_busca.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_busca.Location = New System.Drawing.Point(321, 123)
        Me.btn_busca.Name = "btn_busca"
        Me.btn_busca.Size = New System.Drawing.Size(75, 23)
        Me.btn_busca.TabIndex = 33
        Me.btn_busca.Text = "Buscar"
        Me.btn_busca.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(532, 588)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_busca)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.pic_limpar)
        Me.Controls.Add(Me.lbl_limpar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pic_voltar)
        Me.Controls.Add(Me.lbl_voltar)
        Me.Controls.Add(Me.pic_add_adm)
        Me.Controls.Add(Me.dgv_adm)
        Me.Controls.Add(Me.lbl_trabalhos)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaximizeBox = False
        Me.Name = "Form6"
        Me.Text = "Administradores"
        CType(Me.dgv_adm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_add_adm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_voltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_limpar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_trabalhos As Label
    Friend WithEvents dgv_adm As DataGridView
    Friend WithEvents pic_add_adm As PictureBox
    Friend WithEvents pic_voltar As PictureBox
    Friend WithEvents lbl_voltar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pic_limpar As PictureBox
    Friend WithEvents lbl_limpar As Label
    Friend WithEvents txt_login As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_busca As Button
End Class
