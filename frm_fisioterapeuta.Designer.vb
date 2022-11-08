<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_fisioterapeuta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_fisioterapeuta))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cpf_cliente = New System.Windows.Forms.MaskedTextBox()
        Me.img_atendimento = New System.Windows.Forms.PictureBox()
        Me.img_agendamentos = New System.Windows.Forms.PictureBox()
        Me.img_relatorios = New System.Windows.Forms.PictureBox()
        Me.img_voltar = New System.Windows.Forms.PictureBox()
        Me.img_sair = New System.Windows.Forms.PictureBox()
        CType(Me.img_atendimento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_agendamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_relatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_sair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(31, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Insira o CPF do Cliente:"
        '
        'txt_cpf_cliente
        '
        Me.txt_cpf_cliente.BackColor = System.Drawing.Color.Chocolate
        Me.txt_cpf_cliente.Font = New System.Drawing.Font("Imprint MT Shadow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf_cliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_cpf_cliente.Location = New System.Drawing.Point(222, 57)
        Me.txt_cpf_cliente.Mask = "000.000.000-00"
        Me.txt_cpf_cliente.Name = "txt_cpf_cliente"
        Me.txt_cpf_cliente.Size = New System.Drawing.Size(125, 25)
        Me.txt_cpf_cliente.TabIndex = 2
        Me.txt_cpf_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'img_atendimento
        '
        Me.img_atendimento.BackColor = System.Drawing.Color.Transparent
        Me.img_atendimento.Image = CType(resources.GetObject("img_atendimento.Image"), System.Drawing.Image)
        Me.img_atendimento.Location = New System.Drawing.Point(280, 114)
        Me.img_atendimento.Name = "img_atendimento"
        Me.img_atendimento.Size = New System.Drawing.Size(58, 54)
        Me.img_atendimento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_atendimento.TabIndex = 3
        Me.img_atendimento.TabStop = False
        '
        'img_agendamentos
        '
        Me.img_agendamentos.BackColor = System.Drawing.Color.Transparent
        Me.img_agendamentos.Image = CType(resources.GetObject("img_agendamentos.Image"), System.Drawing.Image)
        Me.img_agendamentos.Location = New System.Drawing.Point(40, 114)
        Me.img_agendamentos.Name = "img_agendamentos"
        Me.img_agendamentos.Size = New System.Drawing.Size(58, 54)
        Me.img_agendamentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_agendamentos.TabIndex = 4
        Me.img_agendamentos.TabStop = False
        '
        'img_relatorios
        '
        Me.img_relatorios.BackColor = System.Drawing.Color.Transparent
        Me.img_relatorios.Image = CType(resources.GetObject("img_relatorios.Image"), System.Drawing.Image)
        Me.img_relatorios.Location = New System.Drawing.Point(160, 114)
        Me.img_relatorios.Name = "img_relatorios"
        Me.img_relatorios.Size = New System.Drawing.Size(58, 54)
        Me.img_relatorios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_relatorios.TabIndex = 5
        Me.img_relatorios.TabStop = False
        '
        'img_voltar
        '
        Me.img_voltar.BackColor = System.Drawing.Color.Transparent
        Me.img_voltar.Image = CType(resources.GetObject("img_voltar.Image"), System.Drawing.Image)
        Me.img_voltar.Location = New System.Drawing.Point(3, 1)
        Me.img_voltar.Name = "img_voltar"
        Me.img_voltar.Size = New System.Drawing.Size(30, 30)
        Me.img_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_voltar.TabIndex = 6
        Me.img_voltar.TabStop = False
        '
        'img_sair
        '
        Me.img_sair.BackColor = System.Drawing.Color.Transparent
        Me.img_sair.Image = CType(resources.GetObject("img_sair.Image"), System.Drawing.Image)
        Me.img_sair.Location = New System.Drawing.Point(351, 0)
        Me.img_sair.Name = "img_sair"
        Me.img_sair.Size = New System.Drawing.Size(33, 33)
        Me.img_sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_sair.TabIndex = 7
        Me.img_sair.TabStop = False
        '
        'frm_fisioterapeuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 191)
        Me.Controls.Add(Me.img_sair)
        Me.Controls.Add(Me.img_voltar)
        Me.Controls.Add(Me.img_relatorios)
        Me.Controls.Add(Me.img_agendamentos)
        Me.Controls.Add(Me.img_atendimento)
        Me.Controls.Add(Me.txt_cpf_cliente)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_fisioterapeuta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_fisioterapeuta"
        CType(Me.img_atendimento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_agendamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_relatorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_voltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_sair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cpf_cliente As MaskedTextBox
    Friend WithEvents img_atendimento As PictureBox
    Friend WithEvents img_agendamentos As PictureBox
    Friend WithEvents img_relatorios As PictureBox
    Friend WithEvents img_voltar As PictureBox
    Friend WithEvents img_sair As PictureBox
End Class
