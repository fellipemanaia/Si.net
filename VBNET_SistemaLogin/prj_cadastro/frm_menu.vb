Public Class frm_menu
    Private Sub AdivinharNúmeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdivinharNúmeroToolStripMenuItem.Click
        Try
            Process.Start(Application.StartupPath & "\Batch\teste.bat")
        Catch ex As Exception
            MsgBox("Erro ao executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Try
            Process.Start("calc.exe")
        Catch ex As Exception
            MsgBox("Erro ao executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub BlocoDeNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlocoDeNotasToolStripMenuItem.Click
        Try
            Process.Start("notepad.exe")
        Catch ex As Exception
            MsgBox("Erro ao executar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        If (MessageBox.Show("Você deseja realmente sair?", "ENCERRAR PROGRAMA",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) = DialogResult.Yes) Then Application.Exit()
    End Sub
End Class
