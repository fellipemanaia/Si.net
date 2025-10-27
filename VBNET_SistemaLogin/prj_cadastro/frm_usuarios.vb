Public Class frm_usuarios

    Private Sub frm_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_usuarios()
        carregar_tipo_usuarios()
    End Sub

    Private Sub btn_gravar_usuario_Click(sender As Object, e As EventArgs) Handles btn_gravar_usuario.Click
        Try
            sql = $"select * from tb_usuarios where cpf='{txt_cpf_usuario.Text}'"
            rs = db.Execute(sql)
            If rs.EOF = False Then 'Se existir o cpf na tabela
                resp = MsgBox("Já existe esse CPF,Deseja Alterar-lo?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Atenção")
                If resp = MsgBoxResult.Yes Then
                    sql = $"update tb_usuarios set nome='{txt_nome_usuario.Text}',
                                                 email='{txt_email_usuario.Text}',
                                                 senha='{txt_senha_usuario.Text}' where cpf='{txt_cpf_usuario.Text}'"
                End If
            Else
                    sql = $"insert into tb_usuarios (cpf,nome,email,senha,bloqueado) values
                       ('{txt_cpf_usuario.Text}', '{txt_nome_usuario.Text}',
                        '{txt_email_usuario.Text}','{txt_senha_usuario.Text}', 'NAO' )"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            End If
            carregar_usuarios()
            txt_cpf_usuario.Clear()
            txt_nome_usuario.Clear()
            txt_email_usuario.Clear()
            txt_senha_usuario.Clear()
            txt_cpf_usuario.Focus()

        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub txt_cpf_usuario_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf_usuario.LostFocus
        Try
            sql = $"select * from tb_usuarios where cpf='{txt_cpf_usuario.Text}'"
            rs = db.Execute(sql)
            If rs.EOF = False Then 'Se existir o cpf na tabela
                txt_nome_usuario.Text = rs.Fields(2).Value
                txt_email_usuario.Text = rs.Fields(3).Value
                txt_senha_usuario.Text = rs.Fields(4).Value
            Else
                txt_nome_usuario.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao consultar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs)
        txt_cpf_usuario.Clear()
        txt_nome_usuario.Clear()
        txt_email_usuario.Clear()
        txt_senha_usuario.Clear()
        txt_cpf_usuario.Focus()
    End Sub

    Private Sub txt_buscar_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_usuario.TextChanged
        With dgv_usuarios
            sql = $"select * from tb_usuarios where {cmb_usuario.Text} like '{txt_buscar_usuario.Text}%'"
            rs = db.Execute(sql)
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(5).Value, Nothing)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With
    End Sub
    Private Sub dgv_usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuarios.CellContentClick
        Try
            With dgv_usuarios
                If .CurrentRow.Cells(3).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja alterar o status dessa conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
                    If resp = MsgBoxResult.Yes Then
                        If .CurrentRow.Cells(3).Value = "NAO" Then
                            sql = $"update tb_usuarios set bloqueado='SIM' where cpf='{aux_cpf}'"
                            rs = db.Execute(sql)
                            carregar_usuarios()
                        ElseIf .CurrentRow.Cells(3).Value = "SIM" Then
                            sql = $"update tb_usuarios set bloqueado='NAO' where cpf='{aux_cpf}'"
                            rs = db.Execute(sql)
                            carregar_usuarios()
                        End If
                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente Excluir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = $"delete from tb_usuarios where cpf='{aux_cpf}'"
                        rs = db.Execute(sql)
                        carregar_usuarios()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao consultar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub link_voltar_menu_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_voltar_menu.LinkClicked
        Me.Close()
    End Sub

    Private Sub cbx_senha_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_senha.CheckedChanged
        If cbx_senha.Checked = True Then
            txt_senha_usuario.PasswordChar = ""
        ElseIf cbx_senha.Checked = False Then
            txt_senha_usuario.PasswordChar = "*"
        End If
    End Sub
End Class