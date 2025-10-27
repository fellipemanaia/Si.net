<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_usuarios))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_email_usuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nome_cliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.link_voltar_menu = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_senha_usuario = New System.Windows.Forms.TextBox()
        Me.btn_gravar_usuario = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_nome_usuario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_usuario = New System.Windows.Forms.ComboBox()
        Me.txt_buscar_usuario = New System.Windows.Forms.TextBox()
        Me.txt_cpf_usuario = New System.Windows.Forms.MaskedTextBox()
        Me.dgv_usuarios = New System.Windows.Forms.DataGridView()
        Me.cbx_senha = New System.Windows.Forms.CheckBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(573, -105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 849)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(260, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "EMAIL"
        '
        'txt_email_usuario
        '
        Me.txt_email_usuario.Location = New System.Drawing.Point(15, 266)
        Me.txt_email_usuario.Name = "txt_email_usuario"
        Me.txt_email_usuario.Size = New System.Drawing.Size(532, 26)
        Me.txt_email_usuario.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, -77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "NOME"
        '
        'txt_nome_cliente
        '
        Me.txt_nome_cliente.Location = New System.Drawing.Point(15, -55)
        Me.txt_nome_cliente.Name = "txt_nome_cliente"
        Me.txt_nome_cliente.Size = New System.Drawing.Size(532, 26)
        Me.txt_nome_cliente.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "CPF"
        '
        'link_voltar_menu
        '
        Me.link_voltar_menu.AutoSize = True
        Me.link_voltar_menu.Location = New System.Drawing.Point(260, 532)
        Me.link_voltar_menu.Name = "link_voltar_menu"
        Me.link_voltar_menu.Size = New System.Drawing.Size(47, 20)
        Me.link_voltar_menu.TabIndex = 5
        Me.link_voltar_menu.TabStop = True
        Me.link_voltar_menu.Text = "voltar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(260, 343)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "SENHA"
        '
        'txt_senha_usuario
        '
        Me.txt_senha_usuario.Location = New System.Drawing.Point(15, 368)
        Me.txt_senha_usuario.Name = "txt_senha_usuario"
        Me.txt_senha_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_usuario.Size = New System.Drawing.Size(532, 26)
        Me.txt_senha_usuario.TabIndex = 3
        '
        'btn_gravar_usuario
        '
        Me.btn_gravar_usuario.Location = New System.Drawing.Point(177, 438)
        Me.btn_gravar_usuario.Name = "btn_gravar_usuario"
        Me.btn_gravar_usuario.Size = New System.Drawing.Size(219, 75)
        Me.btn_gravar_usuario.TabIndex = 4
        Me.btn_gravar_usuario.Text = "GRAVAR NOVO USUARIO"
        Me.btn_gravar_usuario.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(258, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "NOME"
        '
        'txt_nome_usuario
        '
        Me.txt_nome_usuario.Location = New System.Drawing.Point(15, 183)
        Me.txt_nome_usuario.Name = "txt_nome_usuario"
        Me.txt_nome_usuario.Size = New System.Drawing.Size(532, 26)
        Me.txt_nome_usuario.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(609, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(316, 20)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "DIGITE UM PARAMETRO DE PESQUISA:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(610, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(440, 20)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "SELECIONE O TIPO DE PARAMETRO PARA PESQUISAR:"
        '
        'cmb_usuario
        '
        Me.cmb_usuario.FormattingEnabled = True
        Me.cmb_usuario.Location = New System.Drawing.Point(1056, 26)
        Me.cmb_usuario.Name = "cmb_usuario"
        Me.cmb_usuario.Size = New System.Drawing.Size(313, 28)
        Me.cmb_usuario.TabIndex = 42
        '
        'txt_buscar_usuario
        '
        Me.txt_buscar_usuario.Location = New System.Drawing.Point(922, 71)
        Me.txt_buscar_usuario.Name = "txt_buscar_usuario"
        Me.txt_buscar_usuario.Size = New System.Drawing.Size(446, 26)
        Me.txt_buscar_usuario.TabIndex = 43
        '
        'txt_cpf_usuario
        '
        Me.txt_cpf_usuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_cpf_usuario.Location = New System.Drawing.Point(18, 98)
        Me.txt_cpf_usuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_cpf_usuario.Mask = "999,999,999-99"
        Me.txt_cpf_usuario.Name = "txt_cpf_usuario"
        Me.txt_cpf_usuario.Size = New System.Drawing.Size(529, 26)
        Me.txt_cpf_usuario.TabIndex = 0
        Me.txt_cpf_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgv_usuarios
        '
        Me.dgv_usuarios.AllowUserToAddRows = False
        Me.dgv_usuarios.AllowUserToDeleteRows = False
        Me.dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_usuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2, Me.Column4, Me.Column5})
        Me.dgv_usuarios.Location = New System.Drawing.Point(610, 109)
        Me.dgv_usuarios.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_usuarios.Name = "dgv_usuarios"
        Me.dgv_usuarios.ReadOnly = True
        Me.dgv_usuarios.RowHeadersWidth = 62
        Me.dgv_usuarios.Size = New System.Drawing.Size(760, 618)
        Me.dgv_usuarios.TabIndex = 45
        '
        'cbx_senha
        '
        Me.cbx_senha.AutoSize = True
        Me.cbx_senha.Location = New System.Drawing.Point(331, 342)
        Me.cbx_senha.Name = "cbx_senha"
        Me.cbx_senha.Size = New System.Drawing.Size(140, 24)
        Me.cbx_senha.TabIndex = 46
        Me.cbx_senha.Text = "Mostrar Senha"
        Me.cbx_senha.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 62
        '
        'Column3
        '
        Me.Column3.HeaderText = "CPF DO CLIENTE"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 161
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOME DO CLIENTE"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 175
        '
        'Column4
        '
        Me.Column4.HeaderText = "BLOQUEADO"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column4.Width = 117
        '
        'Column5
        '
        Me.Column5.HeaderText = "EXCLUIR"
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 86
        '
        'frm_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1380, 746)
        Me.Controls.Add(Me.cbx_senha)
        Me.Controls.Add(Me.dgv_usuarios)
        Me.Controls.Add(Me.txt_cpf_usuario)
        Me.Controls.Add(Me.txt_buscar_usuario)
        Me.Controls.Add(Me.cmb_usuario)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_nome_usuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_email_usuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nome_cliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.link_voltar_menu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_senha_usuario)
        Me.Controls.Add(Me.btn_gravar_usuario)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_usuarios"
        Me.Text = "CADASTRO DE USUARIOS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_email_usuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nome_cliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents link_voltar_menu As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_senha_usuario As TextBox
    Friend WithEvents btn_gravar_usuario As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_nome_usuario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb_usuario As ComboBox
    Friend WithEvents txt_buscar_usuario As TextBox
    Friend WithEvents txt_cpf_usuario As MaskedTextBox
    Friend WithEvents dgv_usuarios As DataGridView
    Friend WithEvents cbx_senha As CheckBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
End Class
