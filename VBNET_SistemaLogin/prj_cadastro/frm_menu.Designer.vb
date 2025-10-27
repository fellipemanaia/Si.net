<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ATIVIDADESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdivinharNúmeroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperadoresMatemáticosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JoKenPoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VBScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoletrandoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.APLICATIVOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlocoDeNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GERENCIARCLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GERECIARUSUARIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENCERRARPROGRAMAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ATIVIDADESToolStripMenuItem, Me.APLICATIVOSToolStripMenuItem, Me.GERENCIARCLIENTESToolStripMenuItem, Me.GERECIARUSUARIOSToolStripMenuItem, Me.ENCERRARPROGRAMAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ATIVIDADESToolStripMenuItem
        '
        Me.ATIVIDADESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BatchToolStripMenuItem, Me.VBScriptToolStripMenuItem})
        Me.ATIVIDADESToolStripMenuItem.Name = "ATIVIDADESToolStripMenuItem"
        Me.ATIVIDADESToolStripMenuItem.Size = New System.Drawing.Size(105, 24)
        Me.ATIVIDADESToolStripMenuItem.Text = "&ATIVIDADES"
        '
        'BatchToolStripMenuItem
        '
        Me.BatchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdivinharNúmeroToolStripMenuItem, Me.OperadoresMatemáticosToolStripMenuItem, Me.JoKenPoToolStripMenuItem})
        Me.BatchToolStripMenuItem.Image = CType(resources.GetObject("BatchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BatchToolStripMenuItem.Name = "BatchToolStripMenuItem"
        Me.BatchToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.BatchToolStripMenuItem.Text = "Batch"
        '
        'AdivinharNúmeroToolStripMenuItem
        '
        Me.AdivinharNúmeroToolStripMenuItem.Name = "AdivinharNúmeroToolStripMenuItem"
        Me.AdivinharNúmeroToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AdivinharNúmeroToolStripMenuItem.Size = New System.Drawing.Size(265, 26)
        Me.AdivinharNúmeroToolStripMenuItem.Text = "Adivinhar Número"
        '
        'OperadoresMatemáticosToolStripMenuItem
        '
        Me.OperadoresMatemáticosToolStripMenuItem.Name = "OperadoresMatemáticosToolStripMenuItem"
        Me.OperadoresMatemáticosToolStripMenuItem.Size = New System.Drawing.Size(265, 26)
        Me.OperadoresMatemáticosToolStripMenuItem.Text = "Operadores Matemáticos"
        '
        'JoKenPoToolStripMenuItem
        '
        Me.JoKenPoToolStripMenuItem.Name = "JoKenPoToolStripMenuItem"
        Me.JoKenPoToolStripMenuItem.Size = New System.Drawing.Size(265, 26)
        Me.JoKenPoToolStripMenuItem.Text = "Jo-Ken-Po"
        '
        'VBScriptToolStripMenuItem
        '
        Me.VBScriptToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoletrandoToolStripMenuItem})
        Me.VBScriptToolStripMenuItem.Image = CType(resources.GetObject("VBScriptToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VBScriptToolStripMenuItem.Name = "VBScriptToolStripMenuItem"
        Me.VBScriptToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.VBScriptToolStripMenuItem.Text = "VBScript"
        '
        'SoletrandoToolStripMenuItem
        '
        Me.SoletrandoToolStripMenuItem.Name = "SoletrandoToolStripMenuItem"
        Me.SoletrandoToolStripMenuItem.Size = New System.Drawing.Size(165, 26)
        Me.SoletrandoToolStripMenuItem.Text = "Soletrando"
        '
        'APLICATIVOSToolStripMenuItem
        '
        Me.APLICATIVOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.BlocoDeNotasToolStripMenuItem})
        Me.APLICATIVOSToolStripMenuItem.Name = "APLICATIVOSToolStripMenuItem"
        Me.APLICATIVOSToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.APLICATIVOSToolStripMenuItem.Text = "A&PLICATIVOS"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'BlocoDeNotasToolStripMenuItem
        '
        Me.BlocoDeNotasToolStripMenuItem.Name = "BlocoDeNotasToolStripMenuItem"
        Me.BlocoDeNotasToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.BlocoDeNotasToolStripMenuItem.Text = "Bloco de Notas"
        '
        'GERENCIARCLIENTESToolStripMenuItem
        '
        Me.GERENCIARCLIENTESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem})
        Me.GERENCIARCLIENTESToolStripMenuItem.Name = "GERENCIARCLIENTESToolStripMenuItem"
        Me.GERENCIARCLIENTESToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.GERENCIARCLIENTESToolStripMenuItem.Text = "&GERENCIAR CLIENTES"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'GERECIARUSUARIOSToolStripMenuItem
        '
        Me.GERECIARUSUARIOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroUsuariosToolStripMenuItem})
        Me.GERECIARUSUARIOSToolStripMenuItem.Name = "GERECIARUSUARIOSToolStripMenuItem"
        Me.GERECIARUSUARIOSToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.GERECIARUSUARIOSToolStripMenuItem.Text = "GERECIAR &USUARIOS"
        '
        'CadastroUsuariosToolStripMenuItem
        '
        Me.CadastroUsuariosToolStripMenuItem.Name = "CadastroUsuariosToolStripMenuItem"
        Me.CadastroUsuariosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.CadastroUsuariosToolStripMenuItem.Size = New System.Drawing.Size(263, 26)
        Me.CadastroUsuariosToolStripMenuItem.Text = "Cadastro Usuarios"
        '
        'ENCERRARPROGRAMAToolStripMenuItem
        '
        Me.ENCERRARPROGRAMAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem})
        Me.ENCERRARPROGRAMAToolStripMenuItem.Name = "ENCERRARPROGRAMAToolStripMenuItem"
        Me.ENCERRARPROGRAMAToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.ENCERRARPROGRAMAToolStripMenuItem.Text = "&ENCERRAR PROGRAMA"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(117, 26)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_menu"
        Me.Text = "MENU PRINCIPAL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ATIVIDADESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BatchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdivinharNúmeroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperadoresMatemáticosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JoKenPoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VBScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoletrandoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents APLICATIVOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlocoDeNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GERENCIARCLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ENCERRARPROGRAMAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GERECIARUSUARIOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroUsuariosToolStripMenuItem As ToolStripMenuItem
End Class
