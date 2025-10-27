Public Class frm_login

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            If txt_cpf_login.Text = "" Or txt_senha_login.Text = "" Then
                MsgBox("preencha todos os campos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            Else
                If txt_cpf_login.Text = "admin" And txt_senha_login.Text = "admin" Then
                    MsgBox("Login de ADM feito com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                    txt_cpf_login.Clear()
                    txt_senha_login.Clear()
                    frm_usuarios.ShowDialog()
                Else
                    sql = $"select * from tb_usuarios where cpf='{txt_cpf_login.Text}'"
                    rs = db.Execute(sql)
                    senha = rs.Fields(4).Value
                    cpf = rs.Fields(1).Value
                    bloqueado = rs.Fields(5).Value
                    If rs.EOF = False Then
                        If txt_cpf_login.Text = cpf And txt_senha_login.Text = senha Then
                            If bloqueado = "NAO" Then
                                MsgBox("Login de usuario feito com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                                txt_cpf_login.Clear()
                                txt_senha_login.Clear()
                                frm_menu.ShowDialog()
                            Else
                                MsgBox("Sua conta foi bloqueada, contate um adm", MsgBoxStyle.Critical + vbOKOnly, "Atenção")
                            End If
                        Else
                            MsgBox("Senha incorreta", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
                            txt_senha_login.Focus()
                        End If
                    Else
                        MsgBox("CPF não cadastrado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
                        txt_cpf_login.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao fazer login", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco_mysql()
    End Sub

    Private Sub cbx_senha_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_senha.CheckedChanged
        If cbx_senha.Checked = True Then
            txt_senha_login.PasswordChar = ""
        ElseIf cbx_senha.Checked = False Then
            txt_senha_login.PasswordChar = "*"
        End If
    End Sub
End Class