<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_menu_adm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu_adm))
        Me.lbl_trabalhos = New System.Windows.Forms.Label()
        Me.lbl_confirmar = New System.Windows.Forms.Label()
        Me.lbl_limpar = New System.Windows.Forms.Label()
        Me.lbl_voltar = New System.Windows.Forms.Label()
        Me.pic_confirmar = New System.Windows.Forms.PictureBox()
        Me.pic_limpar = New System.Windows.Forms.PictureBox()
        Me.pic_voltar = New System.Windows.Forms.PictureBox()
        CType(Me.pic_confirmar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_limpar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_trabalhos
        '
        Me.lbl_trabalhos.AutoSize = True
        Me.lbl_trabalhos.Font = New System.Drawing.Font("Britannic Bold", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_trabalhos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_trabalhos.Location = New System.Drawing.Point(33, 22)
        Me.lbl_trabalhos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_trabalhos.Name = "lbl_trabalhos"
        Me.lbl_trabalhos.Size = New System.Drawing.Size(433, 71)
        Me.lbl_trabalhos.TabIndex = 9
        Me.lbl_trabalhos.Text = "Administrador"
        '
        'lbl_confirmar
        '
        Me.lbl_confirmar.AutoSize = True
        Me.lbl_confirmar.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_confirmar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_confirmar.Location = New System.Drawing.Point(137, 283)
        Me.lbl_confirmar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_confirmar.Name = "lbl_confirmar"
        Me.lbl_confirmar.Size = New System.Drawing.Size(232, 30)
        Me.lbl_confirmar.TabIndex = 33
        Me.lbl_confirmar.Text = "Consultar Pedidos"
        '
        'lbl_limpar
        '
        Me.lbl_limpar.AutoSize = True
        Me.lbl_limpar.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_limpar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_limpar.Location = New System.Drawing.Point(84, 186)
        Me.lbl_limpar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_limpar.Name = "lbl_limpar"
        Me.lbl_limpar.Size = New System.Drawing.Size(337, 30)
        Me.lbl_limpar.TabIndex = 32
        Me.lbl_limpar.Text = "Gerenciar Administradores"
        '
        'lbl_voltar
        '
        Me.lbl_voltar.AutoSize = True
        Me.lbl_voltar.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_voltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_voltar.Location = New System.Drawing.Point(213, 387)
        Me.lbl_voltar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_voltar.Name = "lbl_voltar"
        Me.lbl_voltar.Size = New System.Drawing.Size(84, 30)
        Me.lbl_voltar.TabIndex = 31
        Me.lbl_voltar.Text = "Voltar"
        '
        'pic_confirmar
        '
        Me.pic_confirmar.Image = CType(resources.GetObject("pic_confirmar.Image"), System.Drawing.Image)
        Me.pic_confirmar.InitialImage = Nothing
        Me.pic_confirmar.Location = New System.Drawing.Point(227, 232)
        Me.pic_confirmar.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_confirmar.Name = "pic_confirmar"
        Me.pic_confirmar.Size = New System.Drawing.Size(45, 49)
        Me.pic_confirmar.TabIndex = 30
        Me.pic_confirmar.TabStop = False
        '
        'pic_limpar
        '
        Me.pic_limpar.Image = CType(resources.GetObject("pic_limpar.Image"), System.Drawing.Image)
        Me.pic_limpar.InitialImage = Nothing
        Me.pic_limpar.Location = New System.Drawing.Point(227, 135)
        Me.pic_limpar.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_limpar.Name = "pic_limpar"
        Me.pic_limpar.Size = New System.Drawing.Size(51, 49)
        Me.pic_limpar.TabIndex = 29
        Me.pic_limpar.TabStop = False
        '
        'pic_voltar
        '
        Me.pic_voltar.Image = CType(resources.GetObject("pic_voltar.Image"), System.Drawing.Image)
        Me.pic_voltar.InitialImage = Nothing
        Me.pic_voltar.Location = New System.Drawing.Point(227, 337)
        Me.pic_voltar.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_voltar.Name = "pic_voltar"
        Me.pic_voltar.Size = New System.Drawing.Size(51, 48)
        Me.pic_voltar.TabIndex = 28
        Me.pic_voltar.TabStop = False
        '
        'frm_menu_adm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(498, 440)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_confirmar)
        Me.Controls.Add(Me.lbl_limpar)
        Me.Controls.Add(Me.lbl_voltar)
        Me.Controls.Add(Me.pic_confirmar)
        Me.Controls.Add(Me.pic_limpar)
        Me.Controls.Add(Me.pic_voltar)
        Me.Controls.Add(Me.lbl_trabalhos)
        Me.MaximizeBox = False
        Me.Name = "frm_menu_adm"
        Me.Text = "Form5"
        CType(Me.pic_confirmar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_limpar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_voltar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_trabalhos As Label
    Friend WithEvents lbl_confirmar As Label
    Friend WithEvents lbl_limpar As Label
    Friend WithEvents lbl_voltar As Label
    Friend WithEvents pic_confirmar As PictureBox
    Friend WithEvents pic_limpar As PictureBox
    Friend WithEvents pic_voltar As PictureBox
End Class
