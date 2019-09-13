<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LabelCiclo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pictureConfig = New System.Windows.Forms.PictureBox()
        Me.btnFwd = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.labelMensaje = New System.Windows.Forms.Label()
        Me.pictureMensajes = New System.Windows.Forms.PictureBox()
        Me.pictureUser = New System.Windows.Forms.PictureBox()
        Me.labelPerfil = New System.Windows.Forms.Label()
        Me.labelConfig = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.comboSeccion = New System.Windows.Forms.ComboBox()
        Me.LabelSeccion = New System.Windows.Forms.Label()
        Me.btnIr = New System.Windows.Forms.Button()
        Me.LabelAño = New System.Windows.Forms.Label()
        Me.comboCicloLectivo = New System.Windows.Forms.ComboBox()
        Me.comboAño = New System.Windows.Forms.ComboBox()
        Me.comboMateria = New System.Windows.Forms.ComboBox()
        Me.LabelMateria = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pictureConfig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureMensajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelCiclo
        '
        Me.LabelCiclo.AutoSize = True
        Me.LabelCiclo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCiclo.Location = New System.Drawing.Point(3, 18)
        Me.LabelCiclo.Name = "LabelCiclo"
        Me.LabelCiclo.Size = New System.Drawing.Size(123, 25)
        Me.LabelCiclo.TabIndex = 4
        Me.LabelCiclo.Text = "Ciclo Lectivo"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.WebBrowser1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1172, 637)
        Me.Panel1.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.pictureConfig)
        Me.Panel3.Controls.Add(Me.btnFwd)
        Me.Panel3.Controls.Add(Me.btnBack)
        Me.Panel3.Controls.Add(Me.labelMensaje)
        Me.Panel3.Controls.Add(Me.pictureMensajes)
        Me.Panel3.Controls.Add(Me.pictureUser)
        Me.Panel3.Controls.Add(Me.labelPerfil)
        Me.Panel3.Controls.Add(Me.labelConfig)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(99, 582)
        Me.Panel3.TabIndex = 13
        '
        'pictureConfig
        '
        Me.pictureConfig.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pictureConfig.Image = Global.IrsoApp.My.Resources.Resources.Gear
        Me.pictureConfig.Location = New System.Drawing.Point(-2, 485)
        Me.pictureConfig.Name = "pictureConfig"
        Me.pictureConfig.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.pictureConfig.Size = New System.Drawing.Size(96, 75)
        Me.pictureConfig.TabIndex = 15
        Me.pictureConfig.TabStop = False
        '
        'btnFwd
        '
        Me.btnFwd.Image = Global.IrsoApp.My.Resources.Resources.Fwd
        Me.btnFwd.Location = New System.Drawing.Point(47, -1)
        Me.btnFwd.Name = "btnFwd"
        Me.btnFwd.Size = New System.Drawing.Size(50, 50)
        Me.btnFwd.TabIndex = 14
        Me.btnFwd.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Image = Global.IrsoApp.My.Resources.Resources.Back1
        Me.btnBack.Location = New System.Drawing.Point(0, -1)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(50, 50)
        Me.btnBack.TabIndex = 14
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'labelMensaje
        '
        Me.labelMensaje.AutoSize = True
        Me.labelMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMensaje.Location = New System.Drawing.Point(3, 372)
        Me.labelMensaje.Name = "labelMensaje"
        Me.labelMensaje.Size = New System.Drawing.Size(81, 20)
        Me.labelMensaje.TabIndex = 3
        Me.labelMensaje.Text = "Mensajes"
        '
        'pictureMensajes
        '
        Me.pictureMensajes.Image = Global.IrsoApp.My.Resources.Resources.Mensaje2
        Me.pictureMensajes.Location = New System.Drawing.Point(-2, 263)
        Me.pictureMensajes.Name = "pictureMensajes"
        Me.pictureMensajes.Size = New System.Drawing.Size(105, 102)
        Me.pictureMensajes.TabIndex = 2
        Me.pictureMensajes.TabStop = False
        '
        'pictureUser
        '
        Me.pictureUser.Image = Global.IrsoApp.My.Resources.Resources.f1
        Me.pictureUser.Location = New System.Drawing.Point(0, 89)
        Me.pictureUser.Name = "pictureUser"
        Me.pictureUser.Size = New System.Drawing.Size(96, 102)
        Me.pictureUser.TabIndex = 1
        Me.pictureUser.TabStop = False
        '
        'labelPerfil
        '
        Me.labelPerfil.AutoSize = True
        Me.labelPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPerfil.Location = New System.Drawing.Point(10, 194)
        Me.labelPerfil.Name = "labelPerfil"
        Me.labelPerfil.Size = New System.Drawing.Size(71, 20)
        Me.labelPerfil.TabIndex = 0
        Me.labelPerfil.Text = "Mi Perfil"
        '
        'labelConfig
        '
        Me.labelConfig.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.labelConfig.AutoSize = True
        Me.labelConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelConfig.Location = New System.Drawing.Point(0, 562)
        Me.labelConfig.Name = "labelConfig"
        Me.labelConfig.Size = New System.Drawing.Size(100, 18)
        Me.labelConfig.TabIndex = 14
        Me.labelConfig.Text = "Configuración"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.comboSeccion)
        Me.Panel2.Controls.Add(Me.LabelSeccion)
        Me.Panel2.Controls.Add(Me.btnIr)
        Me.Panel2.Controls.Add(Me.LabelCiclo)
        Me.Panel2.Controls.Add(Me.LabelAño)
        Me.Panel2.Controls.Add(Me.comboCicloLectivo)
        Me.Panel2.Controls.Add(Me.comboAño)
        Me.Panel2.Controls.Add(Me.comboMateria)
        Me.Panel2.Controls.Add(Me.LabelMateria)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1172, 55)
        Me.Panel2.TabIndex = 12
        '
        'comboSeccion
        '
        Me.comboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboSeccion.FormattingEnabled = True
        Me.comboSeccion.Location = New System.Drawing.Point(883, 10)
        Me.comboSeccion.Name = "comboSeccion"
        Me.comboSeccion.Size = New System.Drawing.Size(166, 33)
        Me.comboSeccion.TabIndex = 13
        '
        'LabelSeccion
        '
        Me.LabelSeccion.AutoSize = True
        Me.LabelSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSeccion.Location = New System.Drawing.Point(799, 15)
        Me.LabelSeccion.Name = "LabelSeccion"
        Me.LabelSeccion.Size = New System.Drawing.Size(89, 25)
        Me.LabelSeccion.TabIndex = 12
        Me.LabelSeccion.Text = "Sección:"
        '
        'btnIr
        '
        Me.btnIr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIr.Location = New System.Drawing.Point(1067, 10)
        Me.btnIr.Name = "btnIr"
        Me.btnIr.Size = New System.Drawing.Size(89, 33)
        Me.btnIr.TabIndex = 11
        Me.btnIr.Text = "Ir"
        Me.btnIr.UseVisualStyleBackColor = True
        '
        'LabelAño
        '
        Me.LabelAño.AutoSize = True
        Me.LabelAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAño.Location = New System.Drawing.Point(209, 15)
        Me.LabelAño.Name = "LabelAño"
        Me.LabelAño.Size = New System.Drawing.Size(54, 25)
        Me.LabelAño.TabIndex = 8
        Me.LabelAño.Text = "Año:"
        '
        'comboCicloLectivo
        '
        Me.comboCicloLectivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboCicloLectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboCicloLectivo.FormattingEnabled = True
        Me.comboCicloLectivo.Location = New System.Drawing.Point(132, 12)
        Me.comboCicloLectivo.Name = "comboCicloLectivo"
        Me.comboCicloLectivo.Size = New System.Drawing.Size(71, 33)
        Me.comboCicloLectivo.TabIndex = 3
        '
        'comboAño
        '
        Me.comboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboAño.FormattingEnabled = True
        Me.comboAño.Location = New System.Drawing.Point(269, 12)
        Me.comboAño.Name = "comboAño"
        Me.comboAño.Size = New System.Drawing.Size(103, 33)
        Me.comboAño.TabIndex = 7
        '
        'comboMateria
        '
        Me.comboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboMateria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboMateria.FormattingEnabled = True
        Me.comboMateria.Location = New System.Drawing.Point(467, 12)
        Me.comboMateria.Name = "comboMateria"
        Me.comboMateria.Size = New System.Drawing.Size(326, 33)
        Me.comboMateria.TabIndex = 5
        '
        'LabelMateria
        '
        Me.LabelMateria.AutoSize = True
        Me.LabelMateria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMateria.Location = New System.Drawing.Point(378, 15)
        Me.LabelMateria.Name = "LabelMateria"
        Me.LabelMateria.Size = New System.Drawing.Size(83, 25)
        Me.LabelMateria.TabIndex = 6
        Me.LabelMateria.Text = "Materia:"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1172, 637)
        Me.WebBrowser1.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 637)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "IrsoApp"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.pictureConfig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureMensajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelCiclo As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents comboSeccion As System.Windows.Forms.ComboBox
    Friend WithEvents LabelSeccion As System.Windows.Forms.Label
    Friend WithEvents btnIr As System.Windows.Forms.Button
    Friend WithEvents LabelAño As System.Windows.Forms.Label
    Friend WithEvents comboCicloLectivo As System.Windows.Forms.ComboBox
    Friend WithEvents comboAño As System.Windows.Forms.ComboBox
    Friend WithEvents comboMateria As System.Windows.Forms.ComboBox
    Friend WithEvents LabelMateria As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents labelPerfil As System.Windows.Forms.Label
    Friend WithEvents pictureUser As System.Windows.Forms.PictureBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pictureMensajes As System.Windows.Forms.PictureBox
    Friend WithEvents labelMensaje As System.Windows.Forms.Label
    Friend WithEvents btnFwd As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents labelConfig As System.Windows.Forms.Label
    Friend WithEvents pictureConfig As System.Windows.Forms.PictureBox

End Class
