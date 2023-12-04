<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.lbl_trabalhos = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.lbl_salvar = New System.Windows.Forms.Label()
        Me.pic_salvar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pic_voltar = New System.Windows.Forms.PictureBox()
        CType(Me.pic_salvar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_trabalhos
        '
        Me.lbl_trabalhos.AutoSize = True
        Me.lbl_trabalhos.Font = New System.Drawing.Font("Britannic Bold", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_trabalhos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_trabalhos.Location = New System.Drawing.Point(25, 9)
        Me.lbl_trabalhos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_trabalhos.Name = "lbl_trabalhos"
        Me.lbl_trabalhos.Size = New System.Drawing.Size(433, 142)
        Me.lbl_trabalhos.TabIndex = 10
        Me.lbl_trabalhos.Text = "    Adicionar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Administrador"
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(37, 294)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(421, 20)
        Me.txt_senha.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(32, 261)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 30)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Senha"
        '
        'txt_login
        '
        Me.txt_login.Location = New System.Drawing.Point(37, 217)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(421, 20)
        Me.txt_login.TabIndex = 12
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_login.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_login.Location = New System.Drawing.Point(32, 184)
        Me.lbl_login.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(79, 30)
        Me.lbl_login.TabIndex = 11
        Me.lbl_login.Text = "Login"
        '
        'lbl_salvar
        '
        Me.lbl_salvar.AutoSize = True
        Me.lbl_salvar.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_salvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_salvar.Location = New System.Drawing.Point(323, 384)
        Me.lbl_salvar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_salvar.Name = "lbl_salvar"
        Me.lbl_salvar.Size = New System.Drawing.Size(87, 30)
        Me.lbl_salvar.TabIndex = 35
        Me.lbl_salvar.Text = "Salvar"
        '
        'pic_salvar
        '
        Me.pic_salvar.Image = CType(resources.GetObject("pic_salvar.Image"), System.Drawing.Image)
        Me.pic_salvar.InitialImage = Nothing
        Me.pic_salvar.Location = New System.Drawing.Point(340, 333)
        Me.pic_salvar.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_salvar.Name = "pic_salvar"
        Me.pic_salvar.Size = New System.Drawing.Size(45, 49)
        Me.pic_salvar.TabIndex = 34
        Me.pic_salvar.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(95, 384)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 30)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Voltar"
        '
        'pic_voltar
        '
        Me.pic_voltar.Image = CType(resources.GetObject("pic_voltar.Image"), System.Drawing.Image)
        Me.pic_voltar.InitialImage = Nothing
        Me.pic_voltar.Location = New System.Drawing.Point(112, 333)
        Me.pic_voltar.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_voltar.Name = "pic_voltar"
        Me.pic_voltar.Size = New System.Drawing.Size(45, 49)
        Me.pic_voltar.TabIndex = 36
        Me.pic_voltar.TabStop = False
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(483, 433)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pic_voltar)
        Me.Controls.Add(Me.lbl_salvar)
        Me.Controls.Add(Me.pic_salvar)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.lbl_login)
        Me.Controls.Add(Me.lbl_trabalhos)
        Me.MaximizeBox = False
        Me.Name = "Form8"
        Me.Text = "Adicionar"
        CType(Me.pic_salvar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_voltar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_trabalhos As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_login As TextBox
    Friend WithEvents lbl_login As Label
    Friend WithEvents lbl_salvar As Label
    Friend WithEvents pic_salvar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pic_voltar As PictureBox
End Class
