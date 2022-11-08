<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_fisioterapeuta_atendimento
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_atendimento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_lesoes = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_agrupamento_musculo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.txt_observacao = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Atendimento Prestado:"
        '
        'cmb_atendimento
        '
        Me.cmb_atendimento.FormattingEnabled = True
        Me.cmb_atendimento.Location = New System.Drawing.Point(196, 97)
        Me.cmb_atendimento.Name = "cmb_atendimento"
        Me.cmb_atendimento.Size = New System.Drawing.Size(121, 21)
        Me.cmb_atendimento.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Possui lesões ou patologias:"
        '
        'cmb_lesoes
        '
        Me.cmb_lesoes.FormattingEnabled = True
        Me.cmb_lesoes.Location = New System.Drawing.Point(218, 134)
        Me.cmb_lesoes.Name = "cmb_lesoes"
        Me.cmb_lesoes.Size = New System.Drawing.Size(99, 21)
        Me.cmb_lesoes.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Em qual agrupamento muscular:"
        '
        'cmb_agrupamento_musculo
        '
        Me.cmb_agrupamento_musculo.FormattingEnabled = True
        Me.cmb_agrupamento_musculo.Location = New System.Drawing.Point(218, 172)
        Me.cmb_agrupamento_musculo.Name = "cmb_agrupamento_musculo"
        Me.cmb_agrupamento_musculo.Size = New System.Drawing.Size(99, 21)
        Me.cmb_agrupamento_musculo.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Observações:"
        '
        'btn_registrar
        '
        Me.btn_registrar.Location = New System.Drawing.Point(173, 343)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_registrar.TabIndex = 9
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'txt_observacao
        '
        Me.txt_observacao.Location = New System.Drawing.Point(60, 225)
        Me.txt_observacao.Multiline = True
        Me.txt_observacao.Name = "txt_observacao"
        Me.txt_observacao.Size = New System.Drawing.Size(257, 93)
        Me.txt_observacao.TabIndex = 10
        '
        'frm_fisioterapeuta_atendimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 398)
        Me.Controls.Add(Me.txt_observacao)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_agrupamento_musculo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_lesoes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_atendimento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_fisioterapeuta_atendimento"
        Me.Text = "frm_fisioterapeuta_atendimento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_atendimento As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_lesoes As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_agrupamento_musculo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_registrar As Button
    Friend WithEvents txt_observacao As TextBox
End Class
