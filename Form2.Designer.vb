<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.EvolveThemeControl1 = New SampleApplication.EvolveThemeControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EvolveThemeControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EvolveThemeControl1
        '
        Me.EvolveThemeControl1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.EvolveThemeControl1.Colors = New SampleApplication.Bloom(-1) {}
        Me.EvolveThemeControl1.Controls.Add(Me.PictureBox1)
        Me.EvolveThemeControl1.Customization = ""
        Me.EvolveThemeControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EvolveThemeControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.EvolveThemeControl1.Image = Nothing
        Me.EvolveThemeControl1.Location = New System.Drawing.Point(0, 0)
        Me.EvolveThemeControl1.MinimumSize = New System.Drawing.Size(80, 55)
        Me.EvolveThemeControl1.Movable = True
        Me.EvolveThemeControl1.Name = "EvolveThemeControl1"
        Me.EvolveThemeControl1.NoRounding = False
        Me.EvolveThemeControl1.Sizable = True
        Me.EvolveThemeControl1.Size = New System.Drawing.Size(368, 250)
        Me.EvolveThemeControl1.SmartBounds = True
        Me.EvolveThemeControl1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.EvolveThemeControl1.TabIndex = 0
        Me.EvolveThemeControl1.Text = "EvolveThemeControl1"
        Me.EvolveThemeControl1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.EvolveThemeControl1.Transparent = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox1.Location = New System.Drawing.Point(50, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 176)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 250)
        Me.Controls.Add(Me.EvolveThemeControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.EvolveThemeControl1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EvolveThemeControl1 As SampleApplication.EvolveThemeControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
