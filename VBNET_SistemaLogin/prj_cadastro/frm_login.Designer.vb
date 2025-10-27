<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cpf_login = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_senha_login = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.cbx_senha = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(675, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "CPF"
        '
        'txt_cpf_login
        '
        Me.txt_cpf_login.Location = New System.Drawing.Point(402, 208)
        Me.txt_cpf_login.Name = "txt_cpf_login"
        Me.txt_cpf_login.Size = New System.Drawing.Size(583, 26)
        Me.txt_cpf_login.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(611, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "SENHA"
        '
        'txt_senha_login
        '
        Me.txt_senha_login.Location = New System.Drawing.Point(402, 331)
        Me.txt_senha_login.Name = "txt_senha_login"
        Me.txt_senha_login.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_login.Size = New System.Drawing.Size(583, 26)
        Me.txt_senha_login.TabIndex = 1
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(554, 412)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(273, 75)
        Me.btn_login.TabIndex = 2
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'cbx_senha
        '
        Me.cbx_senha.AutoSize = True
        Me.cbx_senha.Location = New System.Drawing.Point(682, 306)
        Me.cbx_senha.Name = "cbx_senha"
        Me.cbx_senha.Size = New System.Drawing.Size(140, 24)
        Me.cbx_senha.TabIndex = 12
        Me.cbx_senha.Text = "Mostrar Senha"
        Me.cbx_senha.UseVisualStyleBackColor = True
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 697)
        Me.Controls.Add(Me.cbx_senha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cpf_login)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_senha_login)
        Me.Controls.Add(Me.btn_login)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_login"
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cpf_login As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_senha_login As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents cbx_senha As CheckBox
End Class
