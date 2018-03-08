<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameOver
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGameOver))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.lblmsg = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.lblScore = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rscore = New Bunifu.Framework.UI.BunifuRating()
        Me.TimerScore = New System.Windows.Forms.Timer(Me.components)
        Me.pntrophy = New System.Windows.Forms.Panel()
        Me.tscalerotate = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.lblgreet = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel2.SuspendLayout()
        Me.pntrophy.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblmsg
        '
        Me.lblmsg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblmsg.AutoSize = True
        Me.tscalerotate.SetDecoration(Me.lblmsg, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lblmsg, BunifuAnimatorNS.DecorationType.None)
        Me.lblmsg.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsg.ForeColor = System.Drawing.Color.White
        Me.lblmsg.Location = New System.Drawing.Point(333, 114)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(142, 42)
        Me.lblmsg.TabIndex = 17
        Me.lblmsg.Text = "SCORE:"
        '
        'btnstart
        '
        Me.btnstart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnstart.BackColor = System.Drawing.Color.Transparent
        Me.btnstart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tscalerotate.SetDecoration(Me.btnstart, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btnstart, BunifuAnimatorNS.DecorationType.None)
        Me.btnstart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstart.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstart.ForeColor = System.Drawing.Color.White
        Me.btnstart.Location = New System.Drawing.Point(775, 494)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(75, 33)
        Me.btnstart.TabIndex = 18
        Me.btnstart.Text = "OK"
        Me.btnstart.UseVisualStyleBackColor = False
        '
        'lblScore
        '
        Me.lblScore.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblScore.AutoSize = True
        Me.tscalerotate.SetDecoration(Me.lblScore, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lblScore, BunifuAnimatorNS.DecorationType.None)
        Me.lblScore.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(474, 114)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(56, 42)
        Me.lblScore.TabIndex = 22
        Me.lblScore.Text = "00"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tscalerotate.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(7, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(233, 220)
        Me.Panel1.TabIndex = 26
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel8.AutoSize = True
        Me.tscalerotate.SetDecoration(Me.BunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.Goldenrod
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(308, 30)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(239, 44)
        Me.BunifuCustomLabel8.TabIndex = 27
        Me.BunifuCustomLabel8.Text = "GAME OVER"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rscore)
        Me.tscalerotate.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(51, 232)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(146, 48)
        Me.Panel2.TabIndex = 28
        '
        'rscore
        '
        Me.rscore.BackColor = System.Drawing.Color.Transparent
        Me.tscalerotate.SetDecoration(Me.rscore, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.rscore, BunifuAnimatorNS.DecorationType.None)
        Me.rscore.Enabled = False
        Me.rscore.ForeColor = System.Drawing.Color.Goldenrod
        Me.rscore.Location = New System.Drawing.Point(3, 3)
        Me.rscore.Name = "rscore"
        Me.rscore.Size = New System.Drawing.Size(241, 38)
        Me.rscore.TabIndex = 10
        Me.rscore.Value = 0
        '
        'TimerScore
        '
        Me.TimerScore.Enabled = True
        Me.TimerScore.Interval = 50
        '
        'pntrophy
        '
        Me.pntrophy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pntrophy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pntrophy.Controls.Add(Me.Panel1)
        Me.pntrophy.Controls.Add(Me.Panel2)
        Me.tscalerotate.SetDecoration(Me.pntrophy, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pntrophy, BunifuAnimatorNS.DecorationType.None)
        Me.pntrophy.Location = New System.Drawing.Point(305, 159)
        Me.pntrophy.Name = "pntrophy"
        Me.pntrophy.Size = New System.Drawing.Size(252, 295)
        Me.pntrophy.TabIndex = 27
        Me.pntrophy.Visible = False
        '
        'tscalerotate
        '
        Me.tscalerotate.AnimationType = BunifuAnimatorNS.AnimationType.Scale
        Me.tscalerotate.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0.0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0.0!
        Animation1.RotateLimit = 0.0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0.0!
        Animation1.TransparencyCoeff = 0.0!
        Me.tscalerotate.DefaultAnimation = Animation1
        Me.tscalerotate.Interval = 20
        '
        'lblgreet
        '
        Me.lblgreet.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblgreet.AutoSize = True
        Me.tscalerotate.SetDecoration(Me.lblgreet, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lblgreet, BunifuAnimatorNS.DecorationType.None)
        Me.lblgreet.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgreet.ForeColor = System.Drawing.Color.White
        Me.lblgreet.Location = New System.Drawing.Point(332, 457)
        Me.lblgreet.Name = "lblgreet"
        Me.lblgreet.Size = New System.Drawing.Size(0, 42)
        Me.lblgreet.TabIndex = 28
        Me.lblgreet.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Rotate
        Me.BunifuTransition1.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0.0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0.0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(50)
        Animation2.RotateCoeff = 1.0!
        Animation2.RotateLimit = 0.0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0.0!
        Animation2.TransparencyCoeff = 1.0!
        Me.BunifuTransition1.DefaultAnimation = Animation2
        Me.BunifuTransition1.MaxAnimationTime = 2000
        '
        'frmGameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(862, 539)
        Me.Controls.Add(Me.lblgreet)
        Me.Controls.Add(Me.pntrophy)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.lblmsg)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tscalerotate.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGameOver"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMsgBox"
        Me.Panel2.ResumeLayout(False)
        Me.pntrophy.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblmsg As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnstart As System.Windows.Forms.Button
    Friend WithEvents lblScore As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rscore As Bunifu.Framework.UI.BunifuRating
    Friend WithEvents TimerScore As System.Windows.Forms.Timer
    Friend WithEvents tscalerotate As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents pntrophy As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblgreet As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
End Class
