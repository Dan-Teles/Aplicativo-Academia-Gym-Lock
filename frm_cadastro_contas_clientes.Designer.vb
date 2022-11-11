<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro_contas_clientes
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
        Me.chk_vizualizar_senha = New System.Windows.Forms.CheckBox()
        Me.btn_criar_conta = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_recuperar_senha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_confirma_senha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'chk_vizualizar_senha
        '
        Me.chk_vizualizar_senha.AutoSize = True
        Me.chk_vizualizar_senha.Location = New System.Drawing.Point(30, 211)
        Me.chk_vizualizar_senha.Name = "chk_vizualizar_senha"
        Me.chk_vizualizar_senha.Size = New System.Drawing.Size(129, 20)
        Me.chk_vizualizar_senha.TabIndex = 23
        Me.chk_vizualizar_senha.Text = "Visualizar Senha"
        Me.chk_vizualizar_senha.UseVisualStyleBackColor = True
        '
        'btn_criar_conta
        '
        Me.btn_criar_conta.Location = New System.Drawing.Point(111, 324)
        Me.btn_criar_conta.Name = "btn_criar_conta"
        Me.btn_criar_conta.Size = New System.Drawing.Size(181, 49)
        Me.btn_criar_conta.TabIndex = 22
        Me.btn_criar_conta.Text = "CRIAR CONTA"
        Me.btn_criar_conta.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(342, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "DIGITE UMA PALAVRA PARA RECUPERAR A SENHA:"
        '
        'txt_recuperar_senha
        '
        Me.txt_recuperar_senha.Location = New System.Drawing.Point(30, 275)
        Me.txt_recuperar_senha.Name = "txt_recuperar_senha"
        Me.txt_recuperar_senha.Size = New System.Drawing.Size(350, 22)
        Me.txt_recuperar_senha.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(211, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "CONFIRME A SENHA:"
        '
        'txt_confirma_senha
        '
        Me.txt_confirma_senha.Location = New System.Drawing.Point(214, 183)
        Me.txt_confirma_senha.Name = "txt_confirma_senha"
        Me.txt_confirma_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_confirma_senha.Size = New System.Drawing.Size(166, 22)
        Me.txt_confirma_senha.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "SENHA:"
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(30, 183)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_senha.Size = New System.Drawing.Size(165, 22)
        Me.txt_senha.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "E-MAIL:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(30, 126)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(350, 22)
        Me.txt_email.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "USUÁRIO:"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(30, 67)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(165, 22)
        Me.txt_usuario.TabIndex = 12
        '
        'frm_cadastro_contas_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 450)
        Me.Controls.Add(Me.chk_vizualizar_senha)
        Me.Controls.Add(Me.btn_criar_conta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_recuperar_senha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_confirma_senha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_usuario)
        Me.Name = "frm_cadastro_contas_clientes"
        Me.Text = "frm_cadastro_contas_clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chk_vizualizar_senha As CheckBox
    Friend WithEvents btn_criar_conta As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_recuperar_senha As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_confirma_senha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_usuario As TextBox
End Class
