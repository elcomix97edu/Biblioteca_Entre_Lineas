<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PréstamosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SociosToolStripMenuItem, Me.LibrosToolStripMenuItem, Me.PréstamosToolStripMenuItem, Me.AutorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SociosToolStripMenuItem
        '
        Me.SociosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem, Me.ModificaciónToolStripMenuItem})
        Me.SociosToolStripMenuItem.Name = "SociosToolStripMenuItem"
        Me.SociosToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.SociosToolStripMenuItem.Text = "Socios"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.AltaToolStripMenuItem.Text = "Alta"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.BajaToolStripMenuItem.Text = "Baja"
        '
        'ModificaciónToolStripMenuItem
        '
        Me.ModificaciónToolStripMenuItem.Name = "ModificaciónToolStripMenuItem"
        Me.ModificaciónToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ModificaciónToolStripMenuItem.Text = "Modificación"
        '
        'LibrosToolStripMenuItem
        '
        Me.LibrosToolStripMenuItem.Name = "LibrosToolStripMenuItem"
        Me.LibrosToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.LibrosToolStripMenuItem.Text = "Libros"
        '
        'PréstamosToolStripMenuItem
        '
        Me.PréstamosToolStripMenuItem.Name = "PréstamosToolStripMenuItem"
        Me.PréstamosToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.PréstamosToolStripMenuItem.Text = "Préstamos"
        '
        'AutorToolStripMenuItem
        '
        Me.AutorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem1, Me.ListadoToolStripMenuItem, Me.BajaToolStripMenuItem1, Me.ModificarToolStripMenuItem})
        Me.AutorToolStripMenuItem.Name = "AutorToolStripMenuItem"
        Me.AutorToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.AutorToolStripMenuItem.Text = "Autor"
        '
        'AltaToolStripMenuItem1
        '
        Me.AltaToolStripMenuItem1.Name = "AltaToolStripMenuItem1"
        Me.AltaToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AltaToolStripMenuItem1.Text = "Alta"
        '
        'ListadoToolStripMenuItem
        '
        Me.ListadoToolStripMenuItem.Name = "ListadoToolStripMenuItem"
        Me.ListadoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListadoToolStripMenuItem.Text = "Listado"
        '
        'BajaToolStripMenuItem1
        '
        Me.BajaToolStripMenuItem1.Name = "BajaToolStripMenuItem1"
        Me.BajaToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.BajaToolStripMenuItem1.Text = "Baja"
        '
        'lblBienvenida
        '
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.BackColor = System.Drawing.Color.Transparent
        Me.lblBienvenida.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenida.Location = New System.Drawing.Point(199, 216)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(188, 39)
        Me.lblBienvenida.TabIndex = 3
        Me.lblBienvenida.Text = "Bienvenido"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblBienvenida)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "Inicio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PréstamosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblBienvenida As Label
    Friend WithEvents BajaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
End Class
