Imports System.ComponentModel.Design.Serialization
Imports System.Data.Odbc
Imports System.Reflection
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Security.Cryptography
Imports Microsoft.VisualBasic.Devices

Module mod_geral
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public diretorio, sql, aux_cpf, resp, senha, cpf, bloqueado As String  'Declaração de Variáveis
    Public cont As Integer


    Sub conecta_banco_mysql()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;DATABASE=att_login;UID=root;PWD=usbw;port=3307;option=3")
            'MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_usuarios()
        Try
            With frm_usuarios.dgv_usuarios
                sql = "select * from tb_usuarios order by id asc"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(5).Value, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao usuario", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try

    End Sub


    Sub carregar_tipo_usuarios()
        Try
            With frm_usuarios.cmb_usuario.Items
                .Clear()
                .Add("CPF")
                .Add("NOME")
            End With
            frm_usuarios.cmb_usuario.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao tipo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try

    End Sub

End Module