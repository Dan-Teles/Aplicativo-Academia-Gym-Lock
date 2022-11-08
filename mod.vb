Module Module1
    Public SQL As String
    Public db As New ADODB.Connection 'Variável de BD
    Public rs As New ADODB.Recordset 'Variável de TB
    Public dirbanco = Application.StartupPath & "\banco_dados\BancoDados.mdb"

    Sub conecta_banco()
        Try
            'String de Conexão com o Banco de Dados - MSAccess
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dirbanco)
        Catch ex As Exception
            MsgBox("Erro ao conectar com o banco de dados" + vbNewLine &
                   "Contate o TI!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_planos()
        Try
            With frm_recepcionista.cmb_planos.Items
                .Add("COMUM")
                .Add("BLACK")
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar planos" + vbNewLine &
                   "Contate o TI!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_profissionais()
        Try
            With frm_recepcionista.cmb_profissional.Items
                .Add("FISIOTERAPEUTA")
                .Add("NUTRICIONISTA")
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar profissionais" + vbNewLine &
                   "Contate o TI!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub MostraTextoObj(objeto As Control, mensagem As String)
        Dim tooltip1 As New ToolTip()
        tooltip1.AutoPopDelay = 5000
        tooltip1.InitialDelay = 1000
        tooltip1.ReshowDelay = 500
        tooltip1.ShowAlways = True
        tooltip1.SetToolTip(objeto, mensagem)
    End Sub


End Module
