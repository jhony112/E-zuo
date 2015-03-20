Imports System.Runtime.InteropServices
Imports SpeechLib


Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim WithEvents _lameShell As New LameShell

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents textImage As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents textHeight As System.Windows.Forms.TextBox
    Friend WithEvents textWidth As System.Windows.Forms.TextBox
    Friend WithEvents textStartY As System.Windows.Forms.TextBox
    Friend WithEvents textStartX As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents textResults As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Radiostream As System.Windows.Forms.RadioButton
    Friend WithEvents Radioconvert As System.Windows.Forms.RadioButton
    Friend WithEvents EvolveControlBox1 As SampleApplication.EvolveControlBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnjob As SampleApplication.EvolveButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents EvolveButton2 As SampleApplication.EvolveButton
    Friend WithEvents EvolveCheckBox1 As SampleApplication.EvolveCheckBox
    Friend WithEvents evbpart As SampleApplication.EvolveButton
    Friend WithEvents evbclick As SampleApplication.EvolveButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents workerimage As System.ComponentModel.BackgroundWorker
    Friend WithEvents workerbarcode As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As SampleApplication.EvolveProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pbar As SampleApplication.EvolveProgressBar
    Friend WithEvents lblFeedback As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Labelrate As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.textHeight = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.textWidth = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textStartX = New System.Windows.Forms.TextBox()
        Me.textStartY = New System.Windows.Forms.TextBox()
        Me.textImage = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Labelrate = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.lblFeedback = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Radioconvert = New System.Windows.Forms.RadioButton()
        Me.Radiostream = New System.Windows.Forms.RadioButton()
        Me.textResults = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.workerimage = New System.ComponentModel.BackgroundWorker()
        Me.workerbarcode = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.EvolveControlBox1 = New SampleApplication.EvolveControlBox()
        Me.ProgressBar1 = New SampleApplication.EvolveProgressBar()
        Me.evbclick = New SampleApplication.EvolveButton()
        Me.EvolveButton2 = New SampleApplication.EvolveButton()
        Me.evbpart = New SampleApplication.EvolveButton()
        Me.EvolveCheckBox1 = New SampleApplication.EvolveCheckBox()
        Me.pbar = New SampleApplication.EvolveProgressBar()
        Me.btnjob = New SampleApplication.EvolveButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.evbclick)
        Me.GroupBox1.Controls.Add(Me.EvolveButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.textImage)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(258, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 444)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.RadioButton2.Location = New System.Drawing.Point(311, 347)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(131, 41)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Barcode"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.RadioButton1.Location = New System.Drawing.Point(49, 347)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(116, 41)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Image "
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.evbpart)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.textHeight)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.textWidth)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.textStartX)
        Me.GroupBox2.Controls.Add(Me.textStartY)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(16, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(484, 245)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Advanced Options"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(105, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 28)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "StartY :"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(46, 33)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(391, 36)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Perform OCR on part of the image only"
        '
        'textHeight
        '
        Me.textHeight.Location = New System.Drawing.Point(357, 139)
        Me.textHeight.Name = "textHeight"
        Me.textHeight.Size = New System.Drawing.Size(40, 34)
        Me.textHeight.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(271, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 28)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Height :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(280, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 28)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Height :"
        '
        'textWidth
        '
        Me.textWidth.Location = New System.Drawing.Point(357, 75)
        Me.textWidth.Name = "textWidth"
        Me.textWidth.Size = New System.Drawing.Size(40, 34)
        Me.textWidth.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 28)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "StartX :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(273, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 28)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Width :"
        '
        'textStartX
        '
        Me.textStartX.Location = New System.Drawing.Point(179, 79)
        Me.textStartX.Name = "textStartX"
        Me.textStartX.Size = New System.Drawing.Size(40, 34)
        Me.textStartX.TabIndex = 7
        '
        'textStartY
        '
        Me.textStartY.Location = New System.Drawing.Point(182, 136)
        Me.textStartY.Name = "textStartY"
        Me.textStartY.Size = New System.Drawing.Size(40, 34)
        Me.textStartY.TabIndex = 9
        '
        'textImage
        '
        Me.textImage.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.textImage.Location = New System.Drawing.Point(112, 56)
        Me.textImage.Name = "textImage"
        Me.textImage.Size = New System.Drawing.Size(253, 29)
        Me.textImage.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(9, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 37)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Image:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(931, 552)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.BackgroundImage = Global.SampleApplication.My.Resources.Resources.bg14
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.ForeColor = System.Drawing.Color.White
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(923, 523)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Image Text Recongition"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ProgressBar1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.EvolveCheckBox1)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(923, 541)
        Me.Panel2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 488)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Loading.."
        Me.Label2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SampleApplication.My.Resources.Resources.Untitled_2
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(249, 210)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DimGray
        Me.TabPage2.BackgroundImage = Global.SampleApplication.My.Resources.Resources.bg14
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.ForeColor = System.Drawing.Color.Black
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(923, 523)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Text To Speech"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SampleApplication.My.Resources.Resources.bg14
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Labelrate)
        Me.Panel1.Controls.Add(Me.TrackBar1)
        Me.Panel1.Controls.Add(Me.lblFeedback)
        Me.Panel1.Controls.Add(Me.pbar)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.btnjob)
        Me.Panel1.Controls.Add(Me.textResults)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(0, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(923, 550)
        Me.Panel1.TabIndex = 8
        '
        'Labelrate
        '
        Me.Labelrate.AutoSize = True
        Me.Labelrate.BackColor = System.Drawing.Color.Transparent
        Me.Labelrate.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Labelrate.ForeColor = System.Drawing.Color.White
        Me.Labelrate.Location = New System.Drawing.Point(820, 442)
        Me.Labelrate.Name = "Labelrate"
        Me.Labelrate.Size = New System.Drawing.Size(91, 20)
        Me.Labelrate.TabIndex = 13
        Me.Labelrate.Text = "Speech Rate"
        Me.Labelrate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.Color.Black
        Me.TrackBar1.Location = New System.Drawing.Point(769, 396)
        Me.TrackBar1.Minimum = -10
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(45, 104)
        Me.TrackBar1.TabIndex = 12
        '
        'lblFeedback
        '
        Me.lblFeedback.AutoSize = True
        Me.lblFeedback.BackColor = System.Drawing.Color.Transparent
        Me.lblFeedback.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.lblFeedback.ForeColor = System.Drawing.Color.White
        Me.lblFeedback.Location = New System.Drawing.Point(8, 480)
        Me.lblFeedback.Name = "lblFeedback"
        Me.lblFeedback.Size = New System.Drawing.Size(49, 20)
        Me.lblFeedback.TabIndex = 11
        Me.lblFeedback.Text = "Status"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Radioconvert)
        Me.GroupBox3.Controls.Add(Me.Radiostream)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(6, 391)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(363, 66)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'Radioconvert
        '
        Me.Radioconvert.AutoSize = True
        Me.Radioconvert.BackColor = System.Drawing.Color.Transparent
        Me.Radioconvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Radioconvert.Checked = True
        Me.Radioconvert.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Radioconvert.ForeColor = System.Drawing.Color.White
        Me.Radioconvert.Location = New System.Drawing.Point(18, 25)
        Me.Radioconvert.Name = "Radioconvert"
        Me.Radioconvert.Size = New System.Drawing.Size(165, 29)
        Me.Radioconvert.TabIndex = 0
        Me.Radioconvert.TabStop = True
        Me.Radioconvert.Text = "Convert To Mp3"
        Me.Radioconvert.UseVisualStyleBackColor = False
        '
        'Radiostream
        '
        Me.Radiostream.AutoSize = True
        Me.Radiostream.BackColor = System.Drawing.Color.Transparent
        Me.Radiostream.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radiostream.ForeColor = System.Drawing.Color.White
        Me.Radiostream.Location = New System.Drawing.Point(237, 25)
        Me.Radiostream.Name = "Radiostream"
        Me.Radiostream.Size = New System.Drawing.Size(94, 29)
        Me.Radiostream.TabIndex = 1
        Me.Radiostream.Text = "Stream "
        Me.Radiostream.UseVisualStyleBackColor = False
        '
        'textResults
        '
        Me.textResults.Location = New System.Drawing.Point(6, 52)
        Me.textResults.Name = "textResults"
        Me.textResults.Size = New System.Drawing.Size(921, 333)
        Me.textResults.TabIndex = 6
        Me.textResults.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(304, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(226, 28)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = " Text to Audio Converter"
        '
        'BackgroundWorker1
        '
        '
        'workerimage
        '
        Me.workerimage.WorkerReportsProgress = True
        '
        'workerbarcode
        '
        Me.workerbarcode.WorkerReportsProgress = True
        '
        'Timer1
        '
        '
        'BackgroundWorker2
        '
        '
        'EvolveControlBox1
        '
        Me.EvolveControlBox1.Colors = New SampleApplication.Bloom(-1) {}
        Me.EvolveControlBox1.Customization = ""
        Me.EvolveControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EvolveControlBox1.Image = Nothing
        Me.EvolveControlBox1.Location = New System.Drawing.Point(842, 3)
        Me.EvolveControlBox1.MaxButton = True
        Me.EvolveControlBox1.MinButton = True
        Me.EvolveControlBox1.Name = "EvolveControlBox1"
        Me.EvolveControlBox1.NoRounding = False
        Me.EvolveControlBox1.Size = New System.Drawing.Size(92, 16)
        Me.EvolveControlBox1.TabIndex = 8
        Me.EvolveControlBox1.Text = "EvolveControlBox1"
        Me.EvolveControlBox1.Transparent = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Colors = New SampleApplication.Bloom(-1) {}
        Me.ProgressBar1.Customization = ""
        Me.ProgressBar1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ProgressBar1.Image = Nothing
        Me.ProgressBar1.Location = New System.Drawing.Point(-6, 506)
        Me.ProgressBar1.Maximum = 100
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.NoRounding = False
        Me.ProgressBar1.Size = New System.Drawing.Size(926, 11)
        Me.ProgressBar1.TabIndex = 5
        Me.ProgressBar1.Text = "Loading"
        Me.ProgressBar1.Transparent = True
        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Visible = False
        '
        'evbclick
        '
        Me.evbclick.Colors = New SampleApplication.Bloom(-1) {}
        Me.evbclick.Customization = ""
        Me.evbclick.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.evbclick.Image = Nothing
        Me.evbclick.Location = New System.Drawing.Point(62, 401)
        Me.evbclick.Name = "evbclick"
        Me.evbclick.NoRounding = False
        Me.evbclick.Size = New System.Drawing.Size(400, 37)
        Me.evbclick.TabIndex = 1
        Me.evbclick.Text = "Generate Ocr"
        Me.evbclick.Transparent = True
        '
        'EvolveButton2
        '
        Me.EvolveButton2.Colors = New SampleApplication.Bloom(-1) {}
        Me.EvolveButton2.Customization = ""
        Me.EvolveButton2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.EvolveButton2.Image = Nothing
        Me.EvolveButton2.Location = New System.Drawing.Point(373, 56)
        Me.EvolveButton2.Name = "EvolveButton2"
        Me.EvolveButton2.NoRounding = False
        Me.EvolveButton2.Size = New System.Drawing.Size(147, 34)
        Me.EvolveButton2.TabIndex = 0
        Me.EvolveButton2.Text = "Browse.."
        Me.EvolveButton2.Transparent = True
        '
        'evbpart
        '
        Me.evbpart.Colors = New SampleApplication.Bloom(-1) {}
        Me.evbpart.Customization = ""
        Me.evbpart.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.evbpart.Image = Nothing
        Me.evbpart.Location = New System.Drawing.Point(46, 188)
        Me.evbpart.Name = "evbpart"
        Me.evbpart.NoRounding = False
        Me.evbpart.Size = New System.Drawing.Size(404, 51)
        Me.evbpart.TabIndex = 1
        Me.evbpart.Text = "OCR on part of the image"
        Me.evbpart.Transparent = True
        '
        'EvolveCheckBox1
        '
        Me.EvolveCheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.EvolveCheckBox1.Checked = False
        Me.EvolveCheckBox1.Colors = New SampleApplication.Bloom(-1) {}
        Me.EvolveCheckBox1.Customization = ""
        Me.EvolveCheckBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EvolveCheckBox1.Image = Nothing
        Me.EvolveCheckBox1.Location = New System.Drawing.Point(329, 233)
        Me.EvolveCheckBox1.Name = "EvolveCheckBox1"
        Me.EvolveCheckBox1.NoRounding = False
        Me.EvolveCheckBox1.Size = New System.Drawing.Size(121, 23)
        Me.EvolveCheckBox1.TabIndex = 0
        Me.EvolveCheckBox1.Text = "EvolveCheckBox1"
        Me.EvolveCheckBox1.Transparent = False
        '
        'pbar
        '
        Me.pbar.Colors = New SampleApplication.Bloom(-1) {}
        Me.pbar.Customization = ""
        Me.pbar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.pbar.Image = Nothing
        Me.pbar.Location = New System.Drawing.Point(-4, 506)
        Me.pbar.Maximum = 100
        Me.pbar.Minimum = 0
        Me.pbar.Name = "pbar"
        Me.pbar.NoRounding = False
        Me.pbar.Size = New System.Drawing.Size(931, 11)
        Me.pbar.TabIndex = 10
        Me.pbar.Text = "EvolveProgressBar1"
        Me.pbar.Transparent = True
        Me.pbar.Value = 0
        '
        'btnjob
        '
        Me.btnjob.BackColor = System.Drawing.Color.Transparent
        Me.btnjob.Colors = New SampleApplication.Bloom(-1) {}
        Me.btnjob.Customization = ""
        Me.btnjob.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.btnjob.Image = Nothing
        Me.btnjob.Location = New System.Drawing.Point(198, 466)
        Me.btnjob.Name = "btnjob"
        Me.btnjob.NoRounding = False
        Me.btnjob.Size = New System.Drawing.Size(555, 37)
        Me.btnjob.TabIndex = 8
        Me.btnjob.Text = "Start Job"
        Me.btnjob.Transparent = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BackgroundImage = Global.SampleApplication.My.Resources.Resources.bg14
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(941, 603)
        Me.Controls.Add(Me.EvolveControlBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Declare Function OCR Lib "xchanger.dll" Alias "OCR" (ByVal file As String, ByVal type As Integer) As IntPtr
    Declare Function OCRBarCodes Lib "xchanger.dll" Alias "OCRBarCodes" (ByVal file As String, ByVal type As Integer) As IntPtr
    Declare Function OCRpart Lib "xchanger.dll" Alias "OCRpart" (ByVal file As String, ByVal type As Integer, ByVal startX As Integer, ByVal startY As Integer, ByVal width As Integer, ByVal height As Integer) As IntPtr
    Declare Function OCRpartBarCodes Lib "xchanger.dll" Alias "OCRpartBarCodes" (ByVal file As String, ByVal type As Integer, ByVal startX As Integer, ByVal startY As Integer, ByVal width As Integer, ByVal height As Integer) As IntPtr
    Dim objSpeech As SpeechLib.SpVoice = New SpVoice()
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            evbpart.Enabled = True
        End If
        If CheckBox1.CheckState = CheckState.Unchecked Then
            evbpart.Enabled = False
        End If
    End Sub

    Private Sub buttonBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub buttonOCR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles evbclick.Click
        If doflag = "I" Then
            workerimage.RunWorkerAsync()
            ProgressBar1.Visible = True
            Label2.Visible = True
            Timer1.Start()
        ElseIf doflag = "B" Then
            workerbarcode.RunWorkerAsync()
            ProgressBar1.Visible = True
            Label2.Visible = True
            Timer1.Start()
        Else
            MessageBox.Show("Please indicate action to perform above", ProductName)
        End If

    End Sub

    Private Sub buttonBarcodes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub buttonOCRPart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        evbpart.Enabled = False
        CheckForIllegalCrossThreadCalls = False

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub
    Dim doflag As String = "g"
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        doflag = "I"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        doflag = "B"
    End Sub

    Private Sub EvolveButton2_Click(sender As Object, e As EventArgs) Handles EvolveButton2.Click

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            textImage.Text = OpenFileDialog1.FileName
        Else
            MessageBox.Show("error")
        End If

    End Sub

    Private Sub EvolveButton3_Click(sender As Object, e As EventArgs) Handles evbpart.Click
        Dim startX As Int32
        Dim startY As Int32
        Dim width As Int32
        Dim height As Int32

        On Error Resume Next

        startX = System.Convert.ToInt32(textStartX.Text)
        startY = System.Convert.ToInt32(textStartY.Text)
        width = System.Convert.ToInt32(textWidth.Text)
        height = System.Convert.ToInt32(textHeight.Text)

        textResults.Text = Marshal.PtrToStringAnsi(OCRpart(textImage.Text, -1, startX, startY, width, height))

    End Sub

    Private Sub buttonOCR_Click_1(sender As Object, e As EventArgs)

    End Sub
    Dim sfd As New SaveFileDialog()
    Private Sub EvolveButton1_Click(sender As Object, e As EventArgs) Handles btnjob.Click
        If Radioconvert.Checked = True Then




            sfd.Filter = "All files (*.*)|*.*|mp3 files (*.mp3)|*.mp3"
            sfd.Title = "Save to a mp3 file"
            sfd.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            sfd.FilterIndex = 2
            sfd.RestoreDirectory = True

            If (sfd.ShowDialog() = DialogResult.OK) Then
                BackgroundWorker2.RunWorkerAsync()
            End If
        ElseIf Radiostream.Checked = True Then
            btnjob.Enabled = False
            BackgroundWorker1.RunWorkerAsync()

        End If
        '    objSpeech.AudioOutput = "c:\test.wav"

        '                objSpeech.Speak(myResult.Output, SpeechVoiceSpeakFlags.SVSFlagsAsync);
    End Sub
    Dim rndfile As String = Application.StartupPath + "\\sample.wav"
    Public Sub savespeech(ByVal text As String, ByVal filepath As String, Optional srate As Integer = 0)
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim speech As New SpVoice()


            Dim SpFileMode As SpeechStreamFileMode = SpeechStreamFileMode.SSFMCreateForWrite
            Dim SpFileStream As New SpFileStream()
            SpFileStream.Open(rndfile, SpFileMode, False)
            speech.AudioOutputStream = SpFileStream
            speech.Rate = TrackBar1.Value

            speech.Speak(text, SpeechVoiceSpeakFlags.SVSFlagsAsync)
            speech.WaitUntilDone(-1)
            SpFileStream.Close()
            _lameShell.InFile = rndfile
            _lameShell.OutFile = filepath
            _lameShell.Options = "-b 32" '_lameShell options now go ahead and write a nice app wrapping these up :)

            If _lameShell.Start() Then
                ' lblFeedback.Text = "Complete"
            End If
        Catch ex As Exception
            MsgBox("error saving")
        End Try

    End Sub
    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'BTW If you call Application.Exit this event would never be raised, just a demo afterall
        'you have to make sure Cancel is called when you are exiting the app - else lame.exe will be running until its done
        _lameShell.Cancel()
        ' My.Computer.FileSystem.DeleteFile(rndfile)
    End Sub

    Private Sub _lameShell_Done() Handles _lameShell.Done
        lblFeedback.Text = "Done"
        If MsgBox("Saving Completed Succesfully" + Environment.NewLine + "Do you want too play saved file?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Process.Start(sfd.FileName)
            pbar.Value = 0

        End If
        Me.Cursor = Cursors.Default
        Me.BringToFront()
    End Sub

    Private Sub _lameShell_Canceled() Handles _lameShell.Canceled
        lblFeedback.Text = "Canceled/Error"
        pbar.Value = 0
    End Sub

    Private Sub _lameShell_Progress(ByRef Progress As LameProgress) Handles _lameShell.Progress

        If pbar.Maximum <> Progress.FrameMax Then
            pbar.Value = 0
            pbar.Maximum = Progress.FrameMax
        Else
            pbar.Value = Progress.FrameCurrent
        End If
        lblFeedback.Text = Progress.PercentDone & "%" & " ETA:" & Progress.ETA

    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim speech As New SpVoice()
        speech.Speak(textResults.Text)
        speech.WaitUntilDone(-1)
        If BackgroundWorker1.IsBusy = False Then
            btnjob.Enabled = True
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles workerimage.DoWork
        textResults.Text = Marshal.PtrToStringAnsi(OCR(textImage.Text, -1))
    End Sub
    Dim i As Integer = 0
    Private Sub workerbarcode_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles workerbarcode.DoWork

        textResults.Text = Marshal.PtrToStringAnsi(OCRBarCodes(textImage.Text, -1))

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text += "."
        i += 1
        ProgressBar1.Value = i
        ProgressBar1.Value = i
        If i = 100 Then
            Timer1.Stop()
            TabControl1.SelectedTab = TabPage2
            ProgressBar1.Visible = False
            Label2.Visible = False
            i = 0
        End If


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_TextChanged(sender As Object, e As EventArgs) Handles Label2.TextChanged
        If Label2.Text.Length = 20 Then
            Label2.Text = "Loading"
        End If
    End Sub
    Public Sub mp3convertor(ByVal path As String, ByVal waveer As SpFileStream)
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackgroundWorker2_DoWork_1(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        savespeech(textResults.Text, sfd.FileName)
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Labelrate.Text = "Speech Rate :" + Environment.NewLine + TrackBar1.Value.ToString
    End Sub
End Class
