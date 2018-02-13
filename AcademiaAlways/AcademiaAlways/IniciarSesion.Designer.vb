<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IniciarSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IniciarSesion))
        Me.InicioSesion = New System.Windows.Forms.GroupBox()
        Me.iblUser = New System.Windows.Forms.Label()
        Me.iblClave = New System.Windows.Forms.Label()
        Me.CajaUser = New System.Windows.Forms.TextBox()
        Me.CajaClave = New System.Windows.Forms.TextBox()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.InicioSesion.SuspendLayout()
        Me.SuspendLayout()
        '
        'InicioSesion
        '
        Me.InicioSesion.Controls.Add(Me.CajaClave)
        Me.InicioSesion.Controls.Add(Me.CajaUser)
        Me.InicioSesion.Controls.Add(Me.iblClave)
        Me.InicioSesion.Controls.Add(Me.iblUser)
        Me.InicioSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InicioSesion.Location = New System.Drawing.Point(68, 32)
        Me.InicioSesion.Name = "InicioSesion"
        Me.InicioSesion.Size = New System.Drawing.Size(300, 139)
        Me.InicioSesion.TabIndex = 0
        Me.InicioSesion.TabStop = False
        Me.InicioSesion.Text = "Iniciar sesión"
        '
        'iblUser
        '
        Me.iblUser.AutoSize = True
        Me.iblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iblUser.Location = New System.Drawing.Point(43, 41)
        Me.iblUser.Name = "iblUser"
        Me.iblUser.Size = New System.Drawing.Size(68, 20)
        Me.iblUser.TabIndex = 0
        Me.iblUser.Text = "Usuario:"
        '
        'iblClave
        '
        Me.iblClave.AutoSize = True
        Me.iblClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iblClave.Location = New System.Drawing.Point(43, 85)
        Me.iblClave.Name = "iblClave"
        Me.iblClave.Size = New System.Drawing.Size(52, 20)
        Me.iblClave.TabIndex = 1
        Me.iblClave.Text = "Clave:"
        '
        'CajaUser
        '
        Me.CajaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CajaUser.Location = New System.Drawing.Point(134, 38)
        Me.CajaUser.MaxLength = 10
        Me.CajaUser.Name = "CajaUser"
        Me.CajaUser.Size = New System.Drawing.Size(140, 26)
        Me.CajaUser.TabIndex = 2
        '
        'CajaClave
        '
        Me.CajaClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CajaClave.Location = New System.Drawing.Point(134, 82)
        Me.CajaClave.MaxLength = 10
        Me.CajaClave.Name = "CajaClave"
        Me.CajaClave.Size = New System.Drawing.Size(140, 26)
        Me.CajaClave.TabIndex = 3
        '
        'btnInicio
        '
        Me.btnInicio.BackColor = System.Drawing.Color.White
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.Location = New System.Drawing.Point(317, 192)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(95, 57)
        Me.btnInicio.TabIndex = 1
        Me.btnInicio.Text = "Iniciar Sesión"
        Me.btnInicio.UseVisualStyleBackColor = False
        '
        'IniciarSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(441, 273)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.InicioSesion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IniciarSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesion"
        Me.InicioSesion.ResumeLayout(False)
        Me.InicioSesion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InicioSesion As System.Windows.Forms.GroupBox
    Friend WithEvents CajaClave As System.Windows.Forms.TextBox
    Friend WithEvents CajaUser As System.Windows.Forms.TextBox
    Friend WithEvents iblClave As System.Windows.Forms.Label
    Friend WithEvents iblUser As System.Windows.Forms.Label
    Friend WithEvents btnInicio As System.Windows.Forms.Button
End Class
