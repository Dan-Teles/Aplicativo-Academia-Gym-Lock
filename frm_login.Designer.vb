﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.lbl_acesso = New System.Windows.Forms.Label()
        Me.LOGIN = New System.Windows.Forms.Label()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.img_esqueceu_senha = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.img_halter = New System.Windows.Forms.PictureBox()
        Me.img_nao_senha = New System.Windows.Forms.PictureBox()
        Me.img_vizualizar_senha = New System.Windows.Forms.PictureBox()
        Me.img_sair = New System.Windows.Forms.PictureBox()
        Me.img_modo_diurno = New System.Windows.Forms.PictureBox()
        Me.img_modo_noturno = New System.Windows.Forms.PictureBox()
        CType(Me.img_esqueceu_senha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_halter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_nao_senha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_vizualizar_senha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_sair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_modo_diurno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_modo_noturno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_acesso
        '
        Me.lbl_acesso.AutoSize = True
        Me.lbl_acesso.BackColor = System.Drawing.Color.Transparent
        Me.lbl_acesso.Font = New System.Drawing.Font("High Tower Text", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_acesso.Location = New System.Drawing.Point(125, 20)
        Me.lbl_acesso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_acesso.Name = "lbl_acesso"
        Me.lbl_acesso.Size = New System.Drawing.Size(131, 32)
        Me.lbl_acesso.TabIndex = 0
        Me.lbl_acesso.Text = "ACESSO"
        '
        'LOGIN
        '
        Me.LOGIN.AutoSize = True
        Me.LOGIN.BackColor = System.Drawing.Color.Transparent
        Me.LOGIN.Font = New System.Drawing.Font("High Tower Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOGIN.Location = New System.Drawing.Point(27, 80)
        Me.LOGIN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LOGIN.Name = "LOGIN"
        Me.LOGIN.Size = New System.Drawing.Size(74, 20)
        Me.LOGIN.TabIndex = 1
        Me.LOGIN.Text = "LOGIN:"
        '
        'txt_login
        '
        Me.txt_login.Location = New System.Drawing.Point(31, 103)
        Me.txt_login.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(331, 22)
        Me.txt_login.TabIndex = 2
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(31, 176)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_senha.Size = New System.Drawing.Size(331, 22)
        Me.txt_senha.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("High Tower Text", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(27, 153)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SENHA:"
        '
        'img_esqueceu_senha
        '
        Me.img_esqueceu_senha.BackColor = System.Drawing.Color.Transparent
        Me.img_esqueceu_senha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_esqueceu_senha.Image = CType(resources.GetObject("img_esqueceu_senha.Image"), System.Drawing.Image)
        Me.img_esqueceu_senha.Location = New System.Drawing.Point(320, 208)
        Me.img_esqueceu_senha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.img_esqueceu_senha.Name = "img_esqueceu_senha"
        Me.img_esqueceu_senha.Size = New System.Drawing.Size(40, 37)
        Me.img_esqueceu_senha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_esqueceu_senha.TabIndex = 6
        Me.img_esqueceu_senha.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(272, 279)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'img_halter
        '
        Me.img_halter.BackColor = System.Drawing.Color.Transparent
        Me.img_halter.Image = CType(resources.GetObject("img_halter.Image"), System.Drawing.Image)
        Me.img_halter.Location = New System.Drawing.Point(31, 277)
        Me.img_halter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.img_halter.Name = "img_halter"
        Me.img_halter.Size = New System.Drawing.Size(93, 86)
        Me.img_halter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_halter.TabIndex = 8
        Me.img_halter.TabStop = False
        '
        'img_nao_senha
        '
        Me.img_nao_senha.BackColor = System.Drawing.Color.White
        Me.img_nao_senha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_nao_senha.Image = CType(resources.GetObject("img_nao_senha.Image"), System.Drawing.Image)
        Me.img_nao_senha.Location = New System.Drawing.Point(336, 177)
        Me.img_nao_senha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.img_nao_senha.Name = "img_nao_senha"
        Me.img_nao_senha.Size = New System.Drawing.Size(24, 22)
        Me.img_nao_senha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_nao_senha.TabIndex = 9
        Me.img_nao_senha.TabStop = False
        '
        'img_vizualizar_senha
        '
        Me.img_vizualizar_senha.BackColor = System.Drawing.Color.White
        Me.img_vizualizar_senha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_vizualizar_senha.Image = CType(resources.GetObject("img_vizualizar_senha.Image"), System.Drawing.Image)
        Me.img_vizualizar_senha.Location = New System.Drawing.Point(336, 177)
        Me.img_vizualizar_senha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.img_vizualizar_senha.Name = "img_vizualizar_senha"
        Me.img_vizualizar_senha.Size = New System.Drawing.Size(24, 22)
        Me.img_vizualizar_senha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_vizualizar_senha.TabIndex = 10
        Me.img_vizualizar_senha.TabStop = False
        '
        'img_sair
        '
        Me.img_sair.BackColor = System.Drawing.Color.Transparent
        Me.img_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_sair.Image = CType(resources.GetObject("img_sair.Image"), System.Drawing.Image)
        Me.img_sair.Location = New System.Drawing.Point(345, 4)
        Me.img_sair.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.img_sair.Name = "img_sair"
        Me.img_sair.Size = New System.Drawing.Size(37, 34)
        Me.img_sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_sair.TabIndex = 11
        Me.img_sair.TabStop = False
        '
        'img_modo_diurno
        '
        Me.img_modo_diurno.BackColor = System.Drawing.Color.Transparent
        Me.img_modo_diurno.Image = CType(resources.GetObject("img_modo_diurno.Image"), System.Drawing.Image)
        Me.img_modo_diurno.Location = New System.Drawing.Point(4, 4)
        Me.img_modo_diurno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.img_modo_diurno.Name = "img_modo_diurno"
        Me.img_modo_diurno.Size = New System.Drawing.Size(37, 34)
        Me.img_modo_diurno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_modo_diurno.TabIndex = 12
        Me.img_modo_diurno.TabStop = False
        '
        'img_modo_noturno
        '
        Me.img_modo_noturno.BackColor = System.Drawing.Color.Transparent
        Me.img_modo_noturno.Image = CType(resources.GetObject("img_modo_noturno.Image"), System.Drawing.Image)
        Me.img_modo_noturno.Location = New System.Drawing.Point(5, 5)
        Me.img_modo_noturno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.img_modo_noturno.Name = "img_modo_noturno"
        Me.img_modo_noturno.Size = New System.Drawing.Size(36, 33)
        Me.img_modo_noturno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_modo_noturno.TabIndex = 13
        Me.img_modo_noturno.TabStop = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(385, 378)
        Me.Controls.Add(Me.img_modo_noturno)
        Me.Controls.Add(Me.img_modo_diurno)
        Me.Controls.Add(Me.img_sair)
        Me.Controls.Add(Me.img_vizualizar_senha)
        Me.Controls.Add(Me.img_nao_senha)
        Me.Controls.Add(Me.img_halter)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.img_esqueceu_senha)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.LOGIN)
        Me.Controls.Add(Me.lbl_acesso)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        CType(Me.img_esqueceu_senha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_halter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_nao_senha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_vizualizar_senha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_sair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_modo_diurno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_modo_noturno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_acesso As Label
    Friend WithEvents LOGIN As Label
    Friend WithEvents txt_login As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents img_esqueceu_senha As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents img_halter As PictureBox
    Friend WithEvents img_nao_senha As PictureBox
    Friend WithEvents img_vizualizar_senha As PictureBox
    Friend WithEvents img_sair As PictureBox
    Friend WithEvents img_modo_diurno As PictureBox
    Friend WithEvents img_modo_noturno As PictureBox
End Class
