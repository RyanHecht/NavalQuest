<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Startup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Startup))
        Me.btnstart = New System.Windows.Forms.Button()
        Me.btnabout = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.picwave2 = New System.Windows.Forms.PictureBox()
        Me.picwave1 = New System.Windows.Forms.PictureBox()
        Me.piclogo = New System.Windows.Forms.PictureBox()
        CType(Me.picwave2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picwave1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnstart
        '
        Me.btnstart.Font = New System.Drawing.Font("Forte", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstart.Location = New System.Drawing.Point(367, 342)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(87, 46)
        Me.btnstart.TabIndex = 1
        Me.btnstart.Text = "Start" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2 PlayerGame"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'btnabout
        '
        Me.btnabout.Font = New System.Drawing.Font("Forte", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnabout.Location = New System.Drawing.Point(367, 409)
        Me.btnabout.Name = "btnabout"
        Me.btnabout.Size = New System.Drawing.Size(87, 46)
        Me.btnabout.TabIndex = 2
        Me.btnabout.Text = "About" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Naval Quest"
        Me.btnabout.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Forte", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(367, 475)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(87, 46)
        Me.btnexit.TabIndex = 3
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'picwave2
        '
        Me.picwave2.Image = CType(resources.GetObject("picwave2.Image"), System.Drawing.Image)
        Me.picwave2.Location = New System.Drawing.Point(0, 342)
        Me.picwave2.Name = "picwave2"
        Me.picwave2.Size = New System.Drawing.Size(361, 179)
        Me.picwave2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picwave2.TabIndex = 5
        Me.picwave2.TabStop = False
        '
        'picwave1
        '
        Me.picwave1.Image = CType(resources.GetObject("picwave1.Image"), System.Drawing.Image)
        Me.picwave1.Location = New System.Drawing.Point(460, 342)
        Me.picwave1.Name = "picwave1"
        Me.picwave1.Size = New System.Drawing.Size(345, 179)
        Me.picwave1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picwave1.TabIndex = 4
        Me.picwave1.TabStop = False
        '
        'piclogo
        '
        Me.piclogo.Image = Global.BattleShip.My.Resources.Resources.navelquestlogo
        Me.piclogo.Location = New System.Drawing.Point(42, 12)
        Me.piclogo.Name = "piclogo"
        Me.piclogo.Size = New System.Drawing.Size(717, 313)
        Me.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piclogo.TabIndex = 0
        Me.piclogo.TabStop = False
        '
        'Startup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(805, 578)
        Me.Controls.Add(Me.picwave2)
        Me.Controls.Add(Me.picwave1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnabout)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.piclogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Startup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Naval"
        CType(Me.picwave2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picwave1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents piclogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnstart As System.Windows.Forms.Button
    Friend WithEvents btnabout As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents picwave1 As System.Windows.Forms.PictureBox
    Friend WithEvents picwave2 As System.Windows.Forms.PictureBox
End Class
