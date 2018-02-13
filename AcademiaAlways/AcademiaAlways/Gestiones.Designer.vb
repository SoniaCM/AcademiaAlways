<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestiones
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestiones))
        Me.MenuGestiones = New System.Windows.Forms.MenuStrip()
        Me.AlumnosItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltasItemAlu = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajasItemAlu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificacionesItemAlu = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedasItemAlu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfesoresItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltasItemProf = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajasItemProf = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificacionesItemProf = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedasItemProf = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarClavesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btVolver = New System.Windows.Forms.Button()
        Me.MenuGestiones.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuGestiones
        '
        Me.MenuGestiones.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuGestiones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnosItem, Me.ProfesoresItem, Me.EmpleadosItem})
        Me.MenuGestiones.Location = New System.Drawing.Point(0, 0)
        Me.MenuGestiones.Name = "MenuGestiones"
        Me.MenuGestiones.Size = New System.Drawing.Size(378, 29)
        Me.MenuGestiones.TabIndex = 0
        Me.MenuGestiones.Text = "Menu"
        '
        'AlumnosItem
        '
        Me.AlumnosItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltasItemAlu, Me.BajasItemAlu, Me.ModificacionesItemAlu, Me.BusquedasItemAlu})
        Me.AlumnosItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlumnosItem.Name = "AlumnosItem"
        Me.AlumnosItem.Size = New System.Drawing.Size(84, 25)
        Me.AlumnosItem.Text = "Alumnos"
        '
        'AltasItemAlu
        '
        Me.AltasItemAlu.Name = "AltasItemAlu"
        Me.AltasItemAlu.Size = New System.Drawing.Size(184, 26)
        Me.AltasItemAlu.Text = "Altas"
        '
        'BajasItemAlu
        '
        Me.BajasItemAlu.Name = "BajasItemAlu"
        Me.BajasItemAlu.Size = New System.Drawing.Size(184, 26)
        Me.BajasItemAlu.Text = "Bajas"
        '
        'ModificacionesItemAlu
        '
        Me.ModificacionesItemAlu.Name = "ModificacionesItemAlu"
        Me.ModificacionesItemAlu.Size = New System.Drawing.Size(184, 26)
        Me.ModificacionesItemAlu.Text = "Modificaciones"
        '
        'BusquedasItemAlu
        '
        Me.BusquedasItemAlu.BackColor = System.Drawing.SystemColors.Control
        Me.BusquedasItemAlu.Name = "BusquedasItemAlu"
        Me.BusquedasItemAlu.Size = New System.Drawing.Size(184, 26)
        Me.BusquedasItemAlu.Text = "Busquedas"
        '
        'ProfesoresItem
        '
        Me.ProfesoresItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltasItemProf, Me.BajasItemProf, Me.ModificacionesItemProf, Me.BusquedasItemProf})
        Me.ProfesoresItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfesoresItem.Name = "ProfesoresItem"
        Me.ProfesoresItem.Size = New System.Drawing.Size(96, 25)
        Me.ProfesoresItem.Text = "Profesores"
        '
        'AltasItemProf
        '
        Me.AltasItemProf.Name = "AltasItemProf"
        Me.AltasItemProf.Size = New System.Drawing.Size(184, 26)
        Me.AltasItemProf.Text = "Altas"
        '
        'BajasItemProf
        '
        Me.BajasItemProf.Name = "BajasItemProf"
        Me.BajasItemProf.Size = New System.Drawing.Size(184, 26)
        Me.BajasItemProf.Text = "Bajas"
        '
        'ModificacionesItemProf
        '
        Me.ModificacionesItemProf.Name = "ModificacionesItemProf"
        Me.ModificacionesItemProf.Size = New System.Drawing.Size(184, 26)
        Me.ModificacionesItemProf.Text = "Modificaciones"
        '
        'BusquedasItemProf
        '
        Me.BusquedasItemProf.Name = "BusquedasItemProf"
        Me.BusquedasItemProf.Size = New System.Drawing.Size(184, 26)
        Me.BusquedasItemProf.Text = "Busquedas"
        '
        'EmpleadosItem
        '
        Me.EmpleadosItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarClavesToolStripMenuItem})
        Me.EmpleadosItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpleadosItem.Name = "EmpleadosItem"
        Me.EmpleadosItem.Size = New System.Drawing.Size(98, 25)
        Me.EmpleadosItem.Text = "Empleados"
        '
        'CambiarClavesToolStripMenuItem
        '
        Me.CambiarClavesToolStripMenuItem.Name = "CambiarClavesToolStripMenuItem"
        Me.CambiarClavesToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.CambiarClavesToolStripMenuItem.Text = "Cambiar claves"
        '
        'btVolver
        '
        Me.btVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVolver.Location = New System.Drawing.Point(283, 187)
        Me.btVolver.Name = "btVolver"
        Me.btVolver.Size = New System.Drawing.Size(83, 35)
        Me.btVolver.TabIndex = 1
        Me.btVolver.Text = "Volver"
        Me.btVolver.UseVisualStyleBackColor = False
        '
        'Gestiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(378, 234)
        Me.Controls.Add(Me.btVolver)
        Me.Controls.Add(Me.MenuGestiones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuGestiones
        Me.MaximizeBox = False
        Me.Name = "Gestiones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestiones"
        Me.MenuGestiones.ResumeLayout(False)
        Me.MenuGestiones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuGestiones As System.Windows.Forms.MenuStrip
    Friend WithEvents AlumnosItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltasItemAlu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajasItemAlu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionesItemAlu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusquedasItemAlu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfesoresItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltasItemProf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajasItemProf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionesItemProf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusquedasItemProf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarClavesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btVolver As System.Windows.Forms.Button
End Class
