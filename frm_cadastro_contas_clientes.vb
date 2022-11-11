Public Class frm_cadastro_contas_clientes
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_vizualizar_senha.CheckedChanged
        If chk_vizualizar_senha.Checked = True Then
            txt_senha.PasswordChar = ""
            txt_confirma_senha.PasswordChar = ""
        Else
            txt_senha.PasswordChar = "•"
            txt_confirma_senha.PasswordChar = "•"
        End If
    End Sub

    Private Sub btn_criar_conta_Click(sender As Object, e As EventArgs) Handles btn_criar_conta.Click
        If txt_usuario.Text = "" Or
           txt_email.Text = "" Or
           txt_senha.Text = "" Or
           txt_confirma_senha.Text = "" Or
           txt_recuperar_senha.Text = "" Then

            MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        ElseIf txt_senha.Text <> txt_confirma_senha.Text Then
            MsgBox("Senhas não conferem!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÂO")
            Exit Sub
        Else
            SQL = "select * from tb_login where usuario='" & txt_usuario.Text & "' or email='" & txt_email.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then
                resp = MsgBox("Conta já cadastrada!" + vbNewLine &
                       "Deseja fazer login ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "AVISO")
                If resp = MsgBoxResult.Yes Then
                    Me.Hide()
                    frm_login.Show()
                Else
                    Exit Sub
                End If
            Else
                SQL = "insert into tb_login (usuario,email,senha,palavra_chave,status_conta,funcionario) values ('" & txt_usuario.Text & "'," &
                        "'" & txt_email.Text & "', '" & txt_senha.Text & "', '" & txt_recuperar_senha.Text & "','ATIVA','NÃO')"
                rs = db.Execute(UCase(SQL))
                MsgBox("Conta criada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        End If
        txt_usuario.Clear()
        txt_email.Clear()
        txt_senha.Clear()
        txt_confirma_senha.Clear()
        txt_recuperar_senha.Clear()
    End Sub

    Private Sub frm_cadastro_contas_clientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco()
    End Sub
End Class