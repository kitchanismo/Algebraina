<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChoosePlayer
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation6 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation5 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation4 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChoosePlayer))
        Me.lvplayer = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnchoose = New System.Windows.Forms.Panel()
        Me.pntitle = New System.Windows.Forms.Panel()
        Me.btnclose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tbplayer = New System.Windows.Forms.TextBox()
        Me.btnplay = New Bunifu.Framework.UI.BunifuImageButton()
        Me.thoriz = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.pload = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.tmrload = New System.Windows.Forms.Timer(Me.components)
        Me.tmosaic = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.trotate = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnchoose.SuspendLayout()
        Me.pntitle.SuspendLayout()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvplayer
        '
        Me.lvplayer.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lvplayer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvplayer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvplayer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.lvplayer, BunifuAnimatorNS.DecorationType.None)
        Me.thoriz.SetDecoration(Me.lvplayer, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lvplayer, BunifuAnimatorNS.DecorationType.None)
        Me.lvplayer.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvplayer.ForeColor = System.Drawing.Color.White
        Me.lvplayer.FullRowSelect = True
        Me.lvplayer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvplayer.Location = New System.Drawing.Point(95, 58)
        Me.lvplayer.Name = "lvplayer"
        Me.lvplayer.Size = New System.Drawing.Size(280, 317)
        Me.lvplayer.TabIndex = 0
        Me.lvplayer.UseCompatibleStateImageBehavior = False
        Me.lvplayer.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Player"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 280
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.tmosaic.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.thoriz.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(104, 8)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(209, 30)
        Me.BunifuCustomLabel3.TabIndex = 19
        Me.BunifuCustomLabel3.Text = "CHOOSE PLAYER"
        '
        'pnchoose
        '
        Me.pnchoose.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.pnchoose.Controls.Add(Me.pntitle)
        Me.pnchoose.Controls.Add(Me.lvplayer)
        Me.pnchoose.Controls.Add(Me.btnclose)
        Me.pnchoose.Controls.Add(Me.tbplayer)
        Me.pnchoose.Controls.Add(Me.btnplay)
        Me.trotate.SetDecoration(Me.pnchoose, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.pnchoose, BunifuAnimatorNS.DecorationType.None)
        Me.thoriz.SetDecoration(Me.pnchoose, BunifuAnimatorNS.DecorationType.None)
        Me.pnchoose.Location = New System.Drawing.Point(210, 90)
        Me.pnchoose.Name = "pnchoose"
        Me.pnchoose.Size = New System.Drawing.Size(470, 548)
        Me.pnchoose.TabIndex = 23
        Me.pnchoose.Visible = False
        '
        'pntitle
        '
        Me.pntitle.BackColor = System.Drawing.Color.Teal
        Me.pntitle.Controls.Add(Me.BunifuCustomLabel3)
        Me.trotate.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.thoriz.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.pntitle.Location = New System.Drawing.Point(19, -5)
        Me.pntitle.Name = "pntitle"
        Me.pntitle.Size = New System.Drawing.Size(431, 48)
        Me.pntitle.TabIndex = 54
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trotate.SetDecoration(Me.btnclose, BunifuAnimatorNS.DecorationType.None)
        Me.thoriz.SetDecoration(Me.btnclose, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.btnclose, BunifuAnimatorNS.DecorationType.None)
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageActive = Nothing
        Me.btnclose.Location = New System.Drawing.Point(162, 462)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(45, 45)
        Me.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnclose.TabIndex = 25
        Me.btnclose.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnclose, "CLOSE")
        Me.btnclose.Visible = False
        Me.btnclose.Zoom = 10
        '
        'tbplayer
        '
        Me.tbplayer.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.tbplayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.trotate.SetDecoration(Me.tbplayer, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.tbplayer, BunifuAnimatorNS.DecorationType.None)
        Me.thoriz.SetDecoration(Me.tbplayer, BunifuAnimatorNS.DecorationType.None)
        Me.tbplayer.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbplayer.ForeColor = System.Drawing.Color.Gray
        Me.tbplayer.Location = New System.Drawing.Point(95, 396)
        Me.tbplayer.Name = "tbplayer"
        Me.tbplayer.Size = New System.Drawing.Size(280, 33)
        Me.tbplayer.TabIndex = 2
        Me.tbplayer.Text = "Enter New Player"
        Me.tbplayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnplay
        '
        Me.btnplay.BackColor = System.Drawing.Color.Transparent
        Me.btnplay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trotate.SetDecoration(Me.btnplay, BunifuAnimatorNS.DecorationType.None)
        Me.thoriz.SetDecoration(Me.btnplay, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.btnplay, BunifuAnimatorNS.DecorationType.None)
        Me.btnplay.Image = CType(resources.GetObject("btnplay.Image"), System.Drawing.Image)
        Me.btnplay.ImageActive = Nothing
        Me.btnplay.Location = New System.Drawing.Point(263, 462)
        Me.btnplay.Name = "btnplay"
        Me.btnplay.Size = New System.Drawing.Size(45, 45)
        Me.btnplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnplay.TabIndex = 24
        Me.btnplay.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnplay, "START")
        Me.btnplay.Visible = False
        Me.btnplay.Zoom = 10
        '
        'thoriz
        '
        Me.thoriz.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.thoriz.Cursor = Nothing
        Animation6.AnimateOnlyDifferences = True
        Animation6.BlindCoeff = CType(resources.GetObject("Animation6.BlindCoeff"), System.Drawing.PointF)
        Animation6.LeafCoeff = 0.0!
        Animation6.MaxTime = 1.0!
        Animation6.MinTime = 0.0!
        Animation6.MosaicCoeff = CType(resources.GetObject("Animation6.MosaicCoeff"), System.Drawing.PointF)
        Animation6.MosaicShift = CType(resources.GetObject("Animation6.MosaicShift"), System.Drawing.PointF)
        Animation6.MosaicSize = 0
        Animation6.Padding = New System.Windows.Forms.Padding(0)
        Animation6.RotateCoeff = 0.0!
        Animation6.RotateLimit = 0.0!
        Animation6.ScaleCoeff = CType(resources.GetObject("Animation6.ScaleCoeff"), System.Drawing.PointF)
        Animation6.SlideCoeff = CType(resources.GetObject("Animation6.SlideCoeff"), System.Drawing.PointF)
        Animation6.TimeCoeff = 0.0!
        Animation6.TransparencyCoeff = 0.0!
        Me.thoriz.DefaultAnimation = Animation6
        '
        'pload
        '
        Me.pload.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pload.animated = True
        Me.pload.animationIterval = 5
        Me.pload.animationSpeed = 30
        Me.pload.BackColor = System.Drawing.Color.Transparent
        Me.pload.BackgroundImage = CType(resources.GetObject("pload.BackgroundImage"), System.Drawing.Image)
        Me.trotate.SetDecoration(Me.pload, BunifuAnimatorNS.DecorationType.None)
        Me.thoriz.SetDecoration(Me.pload, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.pload, BunifuAnimatorNS.DecorationType.None)
        Me.pload.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pload.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.pload.LabelVisible = True
        Me.pload.LineProgressThickness = 8
        Me.pload.LineThickness = 5
        Me.pload.Location = New System.Drawing.Point(335, 239)
        Me.pload.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.pload.MaxValue = 100
        Me.pload.Name = "pload"
        Me.pload.ProgressBackColor = System.Drawing.Color.DarkGray
        Me.pload.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pload.Size = New System.Drawing.Size(201, 201)
        Me.pload.TabIndex = 25
        Me.pload.Value = 0
        '
        'tmrload
        '
        Me.tmrload.Enabled = True
        Me.tmrload.Interval = 50
        '
        'tmosaic
        '
        Me.tmosaic.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic
        Me.tmosaic.Cursor = Nothing
        Animation5.AnimateOnlyDifferences = True
        Animation5.BlindCoeff = CType(resources.GetObject("Animation5.BlindCoeff"), System.Drawing.PointF)
        Animation5.LeafCoeff = 0.0!
        Animation5.MaxTime = 1.0!
        Animation5.MinTime = 0.0!
        Animation5.MosaicCoeff = CType(resources.GetObject("Animation5.MosaicCoeff"), System.Drawing.PointF)
        Animation5.MosaicShift = CType(resources.GetObject("Animation5.MosaicShift"), System.Drawing.PointF)
        Animation5.MosaicSize = 20
        Animation5.Padding = New System.Windows.Forms.Padding(30)
        Animation5.RotateCoeff = 0.0!
        Animation5.RotateLimit = 0.0!
        Animation5.ScaleCoeff = CType(resources.GetObject("Animation5.ScaleCoeff"), System.Drawing.PointF)
        Animation5.SlideCoeff = CType(resources.GetObject("Animation5.SlideCoeff"), System.Drawing.PointF)
        Animation5.TimeCoeff = 0.0!
        Animation5.TransparencyCoeff = 0.0!
        Me.tmosaic.DefaultAnimation = Animation5
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 10
        Me.BunifuElipse1.TargetControl = Me
        '
        'trotate
        '
        Me.trotate.AnimationType = BunifuAnimatorNS.AnimationType.Rotate
        Me.trotate.Cursor = Nothing
        Animation4.AnimateOnlyDifferences = True
        Animation4.BlindCoeff = CType(resources.GetObject("Animation4.BlindCoeff"), System.Drawing.PointF)
        Animation4.LeafCoeff = 0.0!
        Animation4.MaxTime = 1.0!
        Animation4.MinTime = 0.0!
        Animation4.MosaicCoeff = CType(resources.GetObject("Animation4.MosaicCoeff"), System.Drawing.PointF)
        Animation4.MosaicShift = CType(resources.GetObject("Animation4.MosaicShift"), System.Drawing.PointF)
        Animation4.MosaicSize = 0
        Animation4.Padding = New System.Windows.Forms.Padding(50)
        Animation4.RotateCoeff = 1.0!
        Animation4.RotateLimit = 0.0!
        Animation4.ScaleCoeff = CType(resources.GetObject("Animation4.ScaleCoeff"), System.Drawing.PointF)
        Animation4.SlideCoeff = CType(resources.GetObject("Animation4.SlideCoeff"), System.Drawing.PointF)
        Animation4.TimeCoeff = 0.0!
        Animation4.TransparencyCoeff = 1.0!
        Me.trotate.DefaultAnimation = Animation4
        Me.trotate.Interval = 15
        Me.trotate.MaxAnimationTime = 2000
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 10
        Me.BunifuElipse2.TargetControl = Me.pnchoose
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 10
        Me.BunifuElipse3.TargetControl = Me.pntitle
        '
        'frmChoosePlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(898, 736)
        Me.Controls.Add(Me.pnchoose)
        Me.Controls.Add(Me.pload)
        Me.tmosaic.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.thoriz.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmChoosePlayer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmChoosePlayer"
        Me.pnchoose.ResumeLayout(False)
        Me.pnchoose.PerformLayout()
        Me.pntitle.ResumeLayout(False)
        Me.pntitle.PerformLayout()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvplayer As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnchoose As System.Windows.Forms.Panel
    Friend WithEvents tbplayer As System.Windows.Forms.TextBox
    Friend WithEvents thoriz As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents pload As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents tmrload As System.Windows.Forms.Timer
    Friend WithEvents tmosaic As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnplay As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents trotate As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents btnclose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pntitle As System.Windows.Forms.Panel
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
End Class
