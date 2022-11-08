<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_recepcionista
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_cpf_agendamento = New System.Windows.Forms.MaskedTextBox()
        Me.txt_data_agendamento = New System.Windows.Forms.DateTimePicker()
        Me.cmb_profissional = New System.Windows.Forms.ComboBox()
        Me.btn_agendar = New System.Windows.Forms.Button()
        Me.cmb_horarios = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nome_agendamento = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.txt_data = New System.Windows.Forms.DateTimePicker()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.txt_rg = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmb_planos = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_num = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_uf = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(640, 332)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_cpf_agendamento)
        Me.TabPage1.Controls.Add(Me.txt_data_agendamento)
        Me.TabPage1.Controls.Add(Me.cmb_profissional)
        Me.TabPage1.Controls.Add(Me.btn_agendar)
        Me.TabPage1.Controls.Add(Me.cmb_horarios)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txt_nome_agendamento)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(632, 306)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "AGENDAMENTOS"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_cpf_agendamento
        '
        Me.txt_cpf_agendamento.Location = New System.Drawing.Point(198, 40)
        Me.txt_cpf_agendamento.Mask = "000.000.000-00"
        Me.txt_cpf_agendamento.Name = "txt_cpf_agendamento"
        Me.txt_cpf_agendamento.Size = New System.Drawing.Size(101, 20)
        Me.txt_cpf_agendamento.TabIndex = 15
        '
        'txt_data_agendamento
        '
        Me.txt_data_agendamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_data_agendamento.Location = New System.Drawing.Point(198, 157)
        Me.txt_data_agendamento.Name = "txt_data_agendamento"
        Me.txt_data_agendamento.Size = New System.Drawing.Size(116, 20)
        Me.txt_data_agendamento.TabIndex = 14
        '
        'cmb_profissional
        '
        Me.cmb_profissional.FormattingEnabled = True
        Me.cmb_profissional.Location = New System.Drawing.Point(198, 117)
        Me.cmb_profissional.Name = "cmb_profissional"
        Me.cmb_profissional.Size = New System.Drawing.Size(116, 21)
        Me.cmb_profissional.TabIndex = 13
        Me.cmb_profissional.Text = "PROFISSIONAL"
        '
        'btn_agendar
        '
        Me.btn_agendar.Location = New System.Drawing.Point(198, 235)
        Me.btn_agendar.Name = "btn_agendar"
        Me.btn_agendar.Size = New System.Drawing.Size(136, 38)
        Me.btn_agendar.TabIndex = 12
        Me.btn_agendar.Text = "Agendar"
        Me.btn_agendar.UseVisualStyleBackColor = True
        '
        'cmb_horarios
        '
        Me.cmb_horarios.FormattingEnabled = True
        Me.cmb_horarios.Location = New System.Drawing.Point(198, 196)
        Me.cmb_horarios.Name = "cmb_horarios"
        Me.cmb_horarios.Size = New System.Drawing.Size(116, 21)
        Me.cmb_horarios.TabIndex = 11
        Me.cmb_horarios.Text = "HORÁRIOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(195, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CPF: "
        '
        'txt_nome_agendamento
        '
        Me.txt_nome_agendamento.Location = New System.Drawing.Point(198, 83)
        Me.txt_nome_agendamento.Name = "txt_nome_agendamento"
        Me.txt_nome_agendamento.Size = New System.Drawing.Size(273, 20)
        Me.txt_nome_agendamento.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(195, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "NOME"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txt_telefone)
        Me.TabPage2.Controls.Add(Me.txt_data)
        Me.TabPage2.Controls.Add(Me.txt_cep)
        Me.TabPage2.Controls.Add(Me.txt_rg)
        Me.TabPage2.Controls.Add(Me.txt_cpf)
        Me.TabPage2.Controls.Add(Me.btn_cadastrar)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.cmb_planos)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txt_email)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txt_num)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txt_cidade)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txt_bairro)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txt_uf)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txt_endereco)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txt_nome)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(632, 306)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CADASTRO DE CLIENTES"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txt_telefone
        '
        Me.txt_telefone.Location = New System.Drawing.Point(266, 206)
        Me.txt_telefone.Mask = "(99) 00000-0000"
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(100, 20)
        Me.txt_telefone.TabIndex = 59
        '
        'txt_data
        '
        Me.txt_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_data.Location = New System.Drawing.Point(266, 34)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(125, 20)
        Me.txt_data.TabIndex = 58
        '
        'txt_cep
        '
        Me.txt_cep.Location = New System.Drawing.Point(21, 121)
        Me.txt_cep.Mask = "00000-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(101, 20)
        Me.txt_cep.TabIndex = 57
        '
        'txt_rg
        '
        Me.txt_rg.Location = New System.Drawing.Point(21, 76)
        Me.txt_rg.Mask = "00.000.000-0"
        Me.txt_rg.Name = "txt_rg"
        Me.txt_rg.Size = New System.Drawing.Size(101, 20)
        Me.txt_rg.TabIndex = 56
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(150, 76)
        Me.txt_cpf.Mask = "000.000.000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(101, 20)
        Me.txt_cpf.TabIndex = 55
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Location = New System.Drawing.Point(375, 255)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(88, 33)
        Me.btn_cadastrar.TabIndex = 54
        Me.btn_cadastrar.Text = "Cadastrar"
        Me.btn_cadastrar.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 239)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "PLANOS"
        '
        'cmb_planos
        '
        Me.cmb_planos.FormattingEnabled = True
        Me.cmb_planos.Location = New System.Drawing.Point(21, 255)
        Me.cmb_planos.Name = "cmb_planos"
        Me.cmb_planos.Size = New System.Drawing.Size(121, 21)
        Me.cmb_planos.TabIndex = 52
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(263, 190)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "TELEFONE"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(21, 206)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(239, 20)
        Me.txt_email.TabIndex = 49
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "EMAIL"
        '
        'txt_num
        '
        Me.txt_num.Location = New System.Drawing.Point(397, 164)
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(66, 20)
        Me.txt_num.TabIndex = 47
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(394, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "COMP/NUM"
        '
        'txt_cidade
        '
        Me.txt_cidade.Location = New System.Drawing.Point(220, 164)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(171, 20)
        Me.txt_cidade.TabIndex = 45
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(217, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "CIDADE"
        '
        'txt_bairro
        '
        Me.txt_bairro.Location = New System.Drawing.Point(21, 164)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(193, 20)
        Me.txt_bairro.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "BAIRRO"
        '
        'txt_uf
        '
        Me.txt_uf.Location = New System.Drawing.Point(397, 121)
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.Size = New System.Drawing.Size(66, 20)
        Me.txt_uf.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(394, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "UF"
        '
        'txt_endereco
        '
        Me.txt_endereco.Location = New System.Drawing.Point(150, 121)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(241, 20)
        Me.txt_endereco.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(147, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "ENDEREÇO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "CEP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(147, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "CPF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "RG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(263, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "DATA DE NASCIMENTO"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(21, 34)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(239, 20)
        Me.txt_nome.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "NOME"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(632, 306)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "LISTAGEM DE CLIENTES"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView2.Location = New System.Drawing.Point(-4, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(638, 306)
        Me.DataGridView2.TabIndex = 0
        '
        'Column7
        '
        Me.Column7.HeaderText = "N°"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "CPF CLIENTE"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "NOME CLIENTE"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "EDITAR"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "EXCLUIR"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "PLANO"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DataGridView1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(632, 306)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "CONTROLE DE ARMARIOS"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column3, Me.Column2, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(-4, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(636, 310)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "N° ARMÁRIO"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "STATUS ARMÁRIO"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "NOME CLIENTE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "TELEFONE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "EMPRESTAR CHAVE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "RECOLHER CHAVE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'frm_recepcionista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 333)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_recepcionista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_recepcionista"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents cmb_planos As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_num As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_uf As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_profissional As ComboBox
    Friend WithEvents btn_agendar As Button
    Friend WithEvents cmb_horarios As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome_agendamento As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents txt_data_agendamento As DateTimePicker
    Friend WithEvents txt_cpf_agendamento As MaskedTextBox
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents txt_data As DateTimePicker
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents txt_rg As MaskedTextBox
    Friend WithEvents txt_cpf As MaskedTextBox
End Class
