﻿Public Class frm_login


    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()

        img_vizualizar_senha.Visible = False
        img_modo_noturno.Visible = False
        MostraTextoObj(img_esqueceu_senha, "Esqueceu sua senha?")

        'otimiza a rotina de gradiente
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
    End Sub

    Private Sub frm_login_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        'Cria um  novo retangulo com lagura e altura similar na base do formulário
        Dim oRAngle As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)

        'Cria um novo gradiente estilo brush.
        'altera as cores para boter diferentes combinações
        Dim oGradientBrush As Brush = New Drawing.Drawing2D.LinearGradientBrush(oRAngle, Color.Chocolate, Color.LightCoral, Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal)

        'Com a ajuda da função fillrectangle desenha o retangulo no formulário
        e.Graphics.FillRectangle(oGradientBrush, oRAngle)
    End Sub

    Private Sub img_esqueceu_senha_DoubleClick(sender As Object, e As EventArgs) Handles img_esqueceu_senha.DoubleClick
        Me.Hide()
        frm_esqueceu_senha.Show()
    End Sub

    Private Sub img_sair_Click(sender As Object, e As EventArgs) Handles img_sair.Click
        Me.Close()
    End Sub

    Private Sub img_vizualizar_senha_Click(sender As Object, e As EventArgs) Handles img_vizualizar_senha.Click
        img_nao_senha.Visible = True
        img_vizualizar_senha.Visible = False
        txt_senha.PasswordChar = "•"
    End Sub

    Private Sub img_nao_senha_Click(sender As Object, e As EventArgs) Handles img_nao_senha.Click
        img_nao_senha.Visible = False
        img_vizualizar_senha.Visible = True
        txt_senha.PasswordChar = ""
    End Sub

    Private Sub img_modo_noturno_Click(sender As Object, e As EventArgs) Handles img_modo_noturno.Click
        img_modo_noturno.Visible = False
        img_modo_diurno.Visible = True
    End Sub

    Private Sub img_modo_diurno_Click(sender As Object, e As EventArgs) Handles img_modo_diurno.Click
        img_modo_noturno.Visible = True
        img_modo_diurno.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If txt_login.Text = "admin" And txt_senha.Text = "admin" Then
            Me.Hide()
            frm_admin.ShowDialog()
        End If

        SQL = "select * from tb_login where (usuario='" & txt_login.Text & "' or email='" & txt_login.Text & "') and senha='" & txt_senha.Text & "'"
        rs = db.Execute(SQL)

        If rs.EOF = False Then
            nome_usuario = rs.Fields(1).Value
            status_conta = rs.Fields(5).Value
            funcionario = rs.Fields(6).Value

            If status_conta = "ATIVA" And funcionario = "CLIENTE" Then
                MsgBox("Conta logada com sucesso!" + vbNewLine &
                       "Bem-Vindo " & UCase(nome_usuario) & "", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Me.Hide()
            ElseIf status_conta = "ATIVA" And funcionario = "RECEPICIONISTA" Then
                MsgBox("Conta logada com sucesso!" + vbNewLine &
                       "Bem-Vindo " & UCase(nome_usuario) & "", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Me.Hide()
                frm_recepcionista.ShowDialog()
            ElseIf status_conta = "ATIVA" And funcionario = "FISIOTERAPEUTA" Then
                MsgBox("Conta logada com sucesso!" + vbNewLine &
                      "Bem-Vindo " & UCase(nome_usuario) & "", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Me.Hide()
                frm_fisioterapeuta.ShowDialog()
            ElseIf status_conta = "ATIVA" And funcionario = "NUTRICIONISTA" Then
                MsgBox("Conta logada com sucesso!" + vbNewLine &
                      "Bem-Vindo " & UCase(nome_usuario) & "", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Me.Hide()
                frm_nutricionista.ShowDialog()
            ElseIf status_conta = "ATIVA" And funcionario = "INSTRUTOR" Then
                MsgBox("Conta logada com sucesso!" + vbNewLine &
                      "Bem-Vindo " & UCase(nome_usuario) & "", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Me.Hide()
            ElseIf status_conta = "BLOQUEADO" Then
                MsgBox("Conta bloqueada! Contate o administrador", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÂO")
                Me.Close()
            End If
        Else
            MsgBox("Conta Invalida ou Inexistente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÂO")
            txt_login.Clear()
            txt_senha.Clear()
            txt_login.Focus()
        End If
    End Sub
End Class