<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Presentacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Presentacion))
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.LinkAcademia = New System.Windows.Forms.LinkLabel()
        Me.Lblcontacta = New System.Windows.Forms.Label()
        Me.Lblemail = New System.Windows.Forms.Label()
        Me.ImgLogo = New System.Windows.Forms.PictureBox()
        CType(Me.ImgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInicio
        '
        Me.btnInicio.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.Location = New System.Drawing.Point(410, 197)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(132, 39)
        Me.btnInicio.TabIndex = 2
        Me.btnInicio.Text = "INICIAR SESION"
        Me.btnInicio.UseVisualStyleBackColor = False
        '
        'LinkAcademia
        '
        Me.LinkAcademia.AutoSize = True
        Me.LinkAcademia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkAcademia.Location = New System.Drawing.Point(156, 143)
        Me.LinkAcademia.Name = "LinkAcademia"
        Me.LinkAcademia.Size = New System.Drawing.Size(260, 20)
        Me.LinkAcademia.TabIndex = 3
        Me.LinkAcademia.TabStop = True
        Me.LinkAcademia.Text = "http://www.always-idiomas.com/"
        '
        'Lblcontacta
        '
        Me.Lblcontacta.AutoSize = True
        Me.Lblcontacta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcontacta.Location = New System.Drawing.Point(12, 197)
        Me.Lblcontacta.Name = "Lblcontacta"
        Me.Lblcontacta.Size = New System.Drawing.Size(196, 20)
        Me.Lblcontacta.TabIndex = 4
        Me.Lblcontacta.Text = "Contacta con nosotros en:"
        '
        'Lblemail
        '
        Me.Lblemail.AutoSize = True
        Me.Lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblemail.ForeColor = System.Drawing.Color.Red
        Me.Lblemail.Location = New System.Drawing.Point(13, 220)
        Me.Lblemail.Name = "Lblemail"
        Me.Lblemail.Size = New System.Drawing.Size(169, 16)
        Me.Lblemail.TabIndex = 5
        Me.Lblemail.Text = " info@always-idiomas.com"
        '
        'ImgLogo
        '
        Me.ImgLogo.Image = Global.AcademiaAlways.My.Resources.Resources.logo
        Me.ImgLogo.Location = New System.Drawing.Point(160, 12)
        Me.ImgLogo.Name = "ImgLogo"
        Me.ImgLogo.Size = New System.Drawing.Size(252, 128)
        Me.ImgLogo.TabIndex = 1
        Me.ImgLogo.TabStop = False
        '
        'Presentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 257)
        Me.Controls.Add(Me.Lblemail)
        Me.Controls.Add(Me.Lblcontacta)
        Me.Controls.Add(Me.LinkAcademia)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.ImgLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Presentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Always School"
        CType(Me.ImgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents LinkAcademia As System.Windows.Forms.LinkLabel
    Friend WithEvents Lblcontacta As System.Windows.Forms.Label
    Friend WithEvents Lblemail As System.Windows.Forms.Label

End Class
