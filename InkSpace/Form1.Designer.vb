<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.img_adm = New System.Windows.Forms.PictureBox()
        Me.lbl_adm = New System.Windows.Forms.Label()
        Me.img_pedido = New System.Windows.Forms.PictureBox()
        Me.img_trabalhos = New System.Windows.Forms.PictureBox()
        Me.lbl_pedido = New System.Windows.Forms.Label()
        Me.lbl_trabalhos = New System.Windows.Forms.Label()
        Me.lbl_titulo_sobre_nos = New System.Windows.Forms.Label()
        Me.lbl_sobre_nos = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_adm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_pedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_trabalhos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(28, 21)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 162)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'img_adm
        '
        Me.img_adm.BackColor = System.Drawing.Color.Black
        Me.img_adm.Image = CType(resources.GetObject("img_adm.Image"), System.Drawing.Image)
        Me.img_adm.Location = New System.Drawing.Point(54, 209)
        Me.img_adm.Margin = New System.Windows.Forms.Padding(2)
        Me.img_adm.Name = "img_adm"
        Me.img_adm.Size = New System.Drawing.Size(45, 42)
        Me.img_adm.TabIndex = 1
        Me.img_adm.TabStop = False
        '
        'lbl_adm
        '
        Me.lbl_adm.AutoSize = True
        Me.lbl_adm.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_adm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_adm.Location = New System.Drawing.Point(25, 263)
        Me.lbl_adm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_adm.Name = "lbl_adm"
        Me.lbl_adm.Size = New System.Drawing.Size(109, 17)
        Me.lbl_adm.TabIndex = 2
        Me.lbl_adm.Text = "Administrador"
        '
        'img_pedido
        '
        Me.img_pedido.BackColor = System.Drawing.Color.Black
        Me.img_pedido.Image = CType(resources.GetObject("img_pedido.Image"), System.Drawing.Image)
        Me.img_pedido.Location = New System.Drawing.Point(214, 209)
        Me.img_pedido.Margin = New System.Windows.Forms.Padding(2)
        Me.img_pedido.Name = "img_pedido"
        Me.img_pedido.Size = New System.Drawing.Size(49, 52)
        Me.img_pedido.TabIndex = 3
        Me.img_pedido.TabStop = False
        '
        'img_trabalhos
        '
        Me.img_trabalhos.BackColor = System.Drawing.Color.Black
        Me.img_trabalhos.Image = CType(resources.GetObject("img_trabalhos.Image"), System.Drawing.Image)
        Me.img_trabalhos.Location = New System.Drawing.Point(385, 209)
        Me.img_trabalhos.Margin = New System.Windows.Forms.Padding(2)
        Me.img_trabalhos.Name = "img_trabalhos"
        Me.img_trabalhos.Size = New System.Drawing.Size(49, 42)
        Me.img_trabalhos.TabIndex = 5
        Me.img_trabalhos.TabStop = False
        '
        'lbl_pedido
        '
        Me.lbl_pedido.AutoSize = True
        Me.lbl_pedido.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_pedido.Location = New System.Drawing.Point(177, 263)
        Me.lbl_pedido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_pedido.Name = "lbl_pedido"
        Me.lbl_pedido.Size = New System.Drawing.Size(126, 17)
        Me.lbl_pedido.TabIndex = 6
        Me.lbl_pedido.Text = "Realizar Pedidos"
        '
        'lbl_trabalhos
        '
        Me.lbl_trabalhos.AutoSize = True
        Me.lbl_trabalhos.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_trabalhos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_trabalhos.Location = New System.Drawing.Point(341, 263)
        Me.lbl_trabalhos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_trabalhos.Name = "lbl_trabalhos"
        Me.lbl_trabalhos.Size = New System.Drawing.Size(135, 17)
        Me.lbl_trabalhos.TabIndex = 7
        Me.lbl_trabalhos.Text = "Nossos Trabalhos"
        '
        'lbl_titulo_sobre_nos
        '
        Me.lbl_titulo_sobre_nos.AutoSize = True
        Me.lbl_titulo_sobre_nos.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo_sobre_nos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_titulo_sobre_nos.Location = New System.Drawing.Point(11, 318)
        Me.lbl_titulo_sobre_nos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_titulo_sobre_nos.Name = "lbl_titulo_sobre_nos"
        Me.lbl_titulo_sobre_nos.Size = New System.Drawing.Size(103, 23)
        Me.lbl_titulo_sobre_nos.TabIndex = 8
        Me.lbl_titulo_sobre_nos.Text = "Sobre Nós"
        '
        'lbl_sobre_nos
        '
        Me.lbl_sobre_nos.AutoSize = True
        Me.lbl_sobre_nos.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sobre_nos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_sobre_nos.Location = New System.Drawing.Point(12, 341)
        Me.lbl_sobre_nos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_sobre_nos.Name = "lbl_sobre_nos"
        Me.lbl_sobre_nos.Size = New System.Drawing.Size(470, 45)
        Me.lbl_sobre_nos.TabIndex = 9
        Me.lbl_sobre_nos.Text = resources.GetString("lbl_sobre_nos.Text")
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(5, 318)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 77)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(227, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 38)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Bem vindo(a)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(227, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 38)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ao"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(227, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 38)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "InkSpace!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(501, 398)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_sobre_nos)
        Me.Controls.Add(Me.lbl_titulo_sobre_nos)
        Me.Controls.Add(Me.lbl_trabalhos)
        Me.Controls.Add(Me.lbl_pedido)
        Me.Controls.Add(Me.img_trabalhos)
        Me.Controls.Add(Me.img_pedido)
        Me.Controls.Add(Me.lbl_adm)
        Me.Controls.Add(Me.img_adm)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "                                                   Bem-vindo(a) ao InkSpace!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_adm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_pedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_trabalhos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents img_adm As PictureBox
    Friend WithEvents lbl_adm As Label
    Friend WithEvents img_pedido As PictureBox
    Friend WithEvents img_trabalhos As PictureBox
    Friend WithEvents lbl_pedido As Label
    Friend WithEvents lbl_trabalhos As Label
    Friend WithEvents lbl_titulo_sobre_nos As Label
    Friend WithEvents lbl_sobre_nos As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
