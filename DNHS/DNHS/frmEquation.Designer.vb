﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEquation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEquation))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation4 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.btn1 = New System.Windows.Forms.Panel()
        Me.lbl1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn2 = New System.Windows.Forms.Panel()
        Me.lbl2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn3 = New System.Windows.Forms.Panel()
        Me.lbl3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn4 = New System.Windows.Forms.Panel()
        Me.lbl4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnquestion = New System.Windows.Forms.Panel()
        Me.pnbomb3 = New System.Windows.Forms.Panel()
        Me.lblbomb3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnbomb2 = New System.Windows.Forms.Panel()
        Me.lblbomb2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnbomb1 = New System.Windows.Forms.Panel()
        Me.lblbomb1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tbquestion = New System.Windows.Forms.TextBox()
        Me.TimerBomb3 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerBomb2 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerBomb1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmosaic = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblcorrect = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblwrong = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblbest = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnclose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pntitle = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnspeaker = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnmute = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pncontainer = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.tVertSlide = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse4 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse5 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse6 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.trotate = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.btn1.SuspendLayout()
        Me.btn2.SuspendLayout()
        Me.btn3.SuspendLayout()
        Me.btn4.SuspendLayout()
        Me.pnbomb3.SuspendLayout()
        Me.pnbomb2.SuspendLayout()
        Me.pnbomb1.SuspendLayout()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pntitle.SuspendLayout()
        CType(Me.btnspeaker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pncontainer.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn1.Controls.Add(Me.lbl1)
        Me.btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.btn1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btn1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btn1, BunifuAnimatorNS.DecorationType.None)
        Me.btn1.Location = New System.Drawing.Point(59, 339)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 75)
        Me.btn1.TabIndex = 1
        '
        'lbl1
        '
        Me.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl1.AutoSize = True
        Me.tmosaic.SetDecoration(Me.lbl1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lbl1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lbl1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lbl1, BunifuAnimatorNS.DecorationType.None)
        Me.lbl1.Font = New System.Drawing.Font("Century Gothic", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(9, 8)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(49, 55)
        Me.lbl1.TabIndex = 19
        Me.lbl1.Text = "0"
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn2.Controls.Add(Me.lbl2)
        Me.btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.btn2, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btn2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn2, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btn2, BunifuAnimatorNS.DecorationType.None)
        Me.btn2.Location = New System.Drawing.Point(165, 339)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 75)
        Me.btn2.TabIndex = 20
        '
        'lbl2
        '
        Me.lbl2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl2.AutoSize = True
        Me.tmosaic.SetDecoration(Me.lbl2, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lbl2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lbl2, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lbl2, BunifuAnimatorNS.DecorationType.None)
        Me.lbl2.Font = New System.Drawing.Font("Century Gothic", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(9, 8)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(49, 55)
        Me.lbl2.TabIndex = 19
        Me.lbl2.Text = "0"
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn3.Controls.Add(Me.lbl3)
        Me.btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.btn3, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btn3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn3, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btn3, BunifuAnimatorNS.DecorationType.None)
        Me.btn3.Location = New System.Drawing.Point(271, 339)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 75)
        Me.btn3.TabIndex = 20
        '
        'lbl3
        '
        Me.lbl3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl3.AutoSize = True
        Me.tmosaic.SetDecoration(Me.lbl3, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lbl3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lbl3, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lbl3, BunifuAnimatorNS.DecorationType.None)
        Me.lbl3.Font = New System.Drawing.Font("Century Gothic", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.White
        Me.lbl3.Location = New System.Drawing.Point(9, 8)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(49, 55)
        Me.lbl3.TabIndex = 19
        Me.lbl3.Text = "0"
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn4.Controls.Add(Me.lbl4)
        Me.btn4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.btn4, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btn4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn4, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btn4, BunifuAnimatorNS.DecorationType.None)
        Me.btn4.Location = New System.Drawing.Point(377, 339)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(75, 75)
        Me.btn4.TabIndex = 20
        '
        'lbl4
        '
        Me.lbl4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl4.AutoSize = True
        Me.tmosaic.SetDecoration(Me.lbl4, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lbl4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lbl4, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lbl4, BunifuAnimatorNS.DecorationType.None)
        Me.lbl4.Font = New System.Drawing.Font("Century Gothic", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.White
        Me.lbl4.Location = New System.Drawing.Point(9, 8)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(49, 55)
        Me.lbl4.TabIndex = 19
        Me.lbl4.Text = "0"
        '
        'pnquestion
        '
        Me.pnquestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnquestion.BackgroundImage = CType(resources.GetObject("pnquestion.BackgroundImage"), System.Drawing.Image)
        Me.pnquestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tmosaic.SetDecoration(Me.pnquestion, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.pnquestion, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pnquestion, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pnquestion, BunifuAnimatorNS.DecorationType.None)
        Me.pnquestion.Location = New System.Drawing.Point(167, 141)
        Me.pnquestion.Name = "pnquestion"
        Me.pnquestion.Size = New System.Drawing.Size(175, 152)
        Me.pnquestion.TabIndex = 20
        '
        'pnbomb3
        '
        Me.pnbomb3.BackColor = System.Drawing.Color.Transparent
        Me.pnbomb3.BackgroundImage = CType(resources.GetObject("pnbomb3.BackgroundImage"), System.Drawing.Image)
        Me.pnbomb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnbomb3.Controls.Add(Me.lblbomb3)
        Me.tmosaic.SetDecoration(Me.pnbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.pnbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pnbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pnbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.pnbomb3.Location = New System.Drawing.Point(24, 67)
        Me.pnbomb3.Name = "pnbomb3"
        Me.pnbomb3.Size = New System.Drawing.Size(77, 88)
        Me.pnbomb3.TabIndex = 21
        Me.pnbomb3.Visible = False
        '
        'lblbomb3
        '
        Me.lblbomb3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblbomb3.AutoSize = True
        Me.tmosaic.SetDecoration(Me.lblbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lblbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lblbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.lblbomb3.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbomb3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblbomb3.Location = New System.Drawing.Point(2, 38)
        Me.lblbomb3.Name = "lblbomb3"
        Me.lblbomb3.Size = New System.Drawing.Size(62, 44)
        Me.lblbomb3.TabIndex = 19
        Me.lblbomb3.Text = "60"
        '
        'pnbomb2
        '
        Me.pnbomb2.BackColor = System.Drawing.Color.Transparent
        Me.pnbomb2.BackgroundImage = CType(resources.GetObject("pnbomb2.BackgroundImage"), System.Drawing.Image)
        Me.pnbomb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnbomb2.Controls.Add(Me.lblbomb2)
        Me.tmosaic.SetDecoration(Me.pnbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.pnbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pnbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pnbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.pnbomb2.Location = New System.Drawing.Point(24, 161)
        Me.pnbomb2.Name = "pnbomb2"
        Me.pnbomb2.Size = New System.Drawing.Size(77, 88)
        Me.pnbomb2.TabIndex = 22
        Me.pnbomb2.Visible = False
        '
        'lblbomb2
        '
        Me.lblbomb2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblbomb2.AutoSize = True
        Me.tmosaic.SetDecoration(Me.lblbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lblbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lblbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.lblbomb2.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbomb2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblbomb2.Location = New System.Drawing.Point(2, 38)
        Me.lblbomb2.Name = "lblbomb2"
        Me.lblbomb2.Size = New System.Drawing.Size(62, 44)
        Me.lblbomb2.TabIndex = 19
        Me.lblbomb2.Text = "60"
        '
        'pnbomb1
        '
        Me.pnbomb1.BackColor = System.Drawing.Color.Transparent
        Me.pnbomb1.BackgroundImage = CType(resources.GetObject("pnbomb1.BackgroundImage"), System.Drawing.Image)
        Me.pnbomb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnbomb1.Controls.Add(Me.lblbomb1)
        Me.tmosaic.SetDecoration(Me.pnbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.pnbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pnbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pnbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.pnbomb1.Location = New System.Drawing.Point(24, 255)
        Me.pnbomb1.Name = "pnbomb1"
        Me.pnbomb1.Size = New System.Drawing.Size(77, 88)
        Me.pnbomb1.TabIndex = 23
        Me.pnbomb1.Visible = False
        '
        'lblbomb1
        '
        Me.lblbomb1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblbomb1.AutoSize = True
        Me.tmosaic.SetDecoration(Me.lblbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lblbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lblbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.lblbomb1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbomb1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblbomb1.Location = New System.Drawing.Point(2, 38)
        Me.lblbomb1.Name = "lblbomb1"
        Me.lblbomb1.Size = New System.Drawing.Size(62, 44)
        Me.lblbomb1.TabIndex = 19
        Me.lblbomb1.Text = "60"
        '
        'TextBox1
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.TextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.TextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.TextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox1.Location = New System.Drawing.Point(916, 664)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 24
        '
        'tbquestion
        '
        Me.tbquestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbquestion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbquestion.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuTransition1.SetDecoration(Me.tbquestion, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.tbquestion, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.tbquestion, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.tbquestion, BunifuAnimatorNS.DecorationType.None)
        Me.tbquestion.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbquestion.ForeColor = System.Drawing.Color.White
        Me.tbquestion.HideSelection = False
        Me.tbquestion.Location = New System.Drawing.Point(2, 44)
        Me.tbquestion.Name = "tbquestion"
        Me.tbquestion.ReadOnly = True
        Me.tbquestion.Size = New System.Drawing.Size(519, 59)
        Me.tbquestion.TabIndex = 25
        Me.tbquestion.Text = "?????????????"
        Me.tbquestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TimerBomb3
        '
        Me.TimerBomb3.Interval = 1000
        '
        'TimerBomb2
        '
        Me.TimerBomb2.Interval = 1000
        '
        'TimerBomb1
        '
        Me.TimerBomb1.Interval = 1000
        '
        'tmosaic
        '
        Me.tmosaic.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic
        Me.tmosaic.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0.0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 20
        Animation1.Padding = New System.Windows.Forms.Padding(30)
        Animation1.RotateCoeff = 0.0!
        Animation1.RotateLimit = 0.0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0.0!
        Animation1.TransparencyCoeff = 0.0!
        Me.tmosaic.DefaultAnimation = Animation1
        Me.tmosaic.Interval = 15
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tmosaic.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(17, 640)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(39, 35)
        Me.Panel1.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.Panel1, "CORRECT")
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tmosaic.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(19, 686)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(37, 33)
        Me.Panel2.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.Panel2, "WRONG")
        '
        'lblcorrect
        '
        Me.lblcorrect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblcorrect.AutoSize = True
        Me.tmosaic.SetDecoration(Me.lblcorrect, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lblcorrect, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lblcorrect, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblcorrect, BunifuAnimatorNS.DecorationType.None)
        Me.lblcorrect.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorrect.ForeColor = System.Drawing.Color.White
        Me.lblcorrect.Location = New System.Drawing.Point(59, 637)
        Me.lblcorrect.Name = "lblcorrect"
        Me.lblcorrect.Size = New System.Drawing.Size(37, 42)
        Me.lblcorrect.TabIndex = 20
        Me.lblcorrect.Text = "0"
        '
        'lblwrong
        '
        Me.lblwrong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblwrong.AutoSize = True
        Me.tmosaic.SetDecoration(Me.lblwrong, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lblwrong, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lblwrong, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblwrong, BunifuAnimatorNS.DecorationType.None)
        Me.lblwrong.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwrong.ForeColor = System.Drawing.Color.White
        Me.lblwrong.Location = New System.Drawing.Point(59, 682)
        Me.lblwrong.Name = "lblwrong"
        Me.lblwrong.Size = New System.Drawing.Size(37, 42)
        Me.lblwrong.TabIndex = 26
        Me.lblwrong.Text = "0"
        '
        'lblbest
        '
        Me.lblbest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblbest.AutoSize = True
        Me.tmosaic.SetDecoration(Me.lblbest, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lblbest, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lblbest, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblbest, BunifuAnimatorNS.DecorationType.None)
        Me.lblbest.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbest.ForeColor = System.Drawing.Color.White
        Me.lblbest.Location = New System.Drawing.Point(59, 593)
        Me.lblbest.Name = "lblbest"
        Me.lblbest.Size = New System.Drawing.Size(37, 42)
        Me.lblbest.TabIndex = 28
        Me.lblbest.Text = "0"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tmosaic.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.Panel3.Location = New System.Drawing.Point(10, 585)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(55, 50)
        Me.Panel3.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.Panel3, "BEST SCORE")
        '
        'btnclose
        '
        Me.btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.trotate.SetDecoration(Me.btnclose, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btnclose, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btnclose, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.btnclose, BunifuAnimatorNS.DecorationType.None)
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageActive = Nothing
        Me.btnclose.Location = New System.Drawing.Point(4, 12)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(45, 45)
        Me.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnclose.TabIndex = 30
        Me.btnclose.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnclose, "QUIT")
        Me.btnclose.Zoom = 10
        '
        'pntitle
        '
        Me.pntitle.BackColor = System.Drawing.Color.Teal
        Me.pntitle.Controls.Add(Me.BunifuCustomLabel1)
        Me.pntitle.Controls.Add(Me.btnclose)
        Me.tmosaic.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.pntitle.Location = New System.Drawing.Point(24, -5)
        Me.pntitle.Name = "pntitle"
        Me.pntitle.Size = New System.Drawing.Size(855, 66)
        Me.pntitle.TabIndex = 31
        Me.pntitle.Visible = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel1.AutoSize = True
        Me.tmosaic.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(243, 15)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(378, 42)
        Me.BunifuCustomLabel1.TabIndex = 29
        Me.BunifuCustomLabel1.Text = "SOLVE THE EQUATION"
        '
        'btnspeaker
        '
        Me.btnspeaker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnspeaker.BackColor = System.Drawing.Color.Transparent
        Me.btnspeaker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trotate.SetDecoration(Me.btnspeaker, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btnspeaker, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btnspeaker, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.btnspeaker, BunifuAnimatorNS.DecorationType.None)
        Me.btnspeaker.Image = CType(resources.GetObject("btnspeaker.Image"), System.Drawing.Image)
        Me.btnspeaker.ImageActive = Nothing
        Me.btnspeaker.Location = New System.Drawing.Point(822, 671)
        Me.btnspeaker.Name = "btnspeaker"
        Me.btnspeaker.Size = New System.Drawing.Size(61, 52)
        Me.btnspeaker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnspeaker.TabIndex = 36
        Me.btnspeaker.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnspeaker, "SPEAKER ON")
        Me.btnspeaker.Zoom = 10
        '
        'btnmute
        '
        Me.btnmute.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmute.BackColor = System.Drawing.Color.Transparent
        Me.btnmute.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trotate.SetDecoration(Me.btnmute, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btnmute, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btnmute, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.btnmute, BunifuAnimatorNS.DecorationType.None)
        Me.btnmute.Image = CType(resources.GetObject("btnmute.Image"), System.Drawing.Image)
        Me.btnmute.ImageActive = Nothing
        Me.btnmute.Location = New System.Drawing.Point(822, 671)
        Me.btnmute.Name = "btnmute"
        Me.btnmute.Size = New System.Drawing.Size(61, 52)
        Me.btnmute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmute.TabIndex = 37
        Me.btnmute.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnmute, "SPEAKER OFF")
        Me.btnmute.Zoom = 10
        '
        'pncontainer
        '
        Me.pncontainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pncontainer.Controls.Add(Me.tbquestion)
        Me.pncontainer.Controls.Add(Me.btn1)
        Me.pncontainer.Controls.Add(Me.btn2)
        Me.pncontainer.Controls.Add(Me.btn3)
        Me.pncontainer.Controls.Add(Me.btn4)
        Me.pncontainer.Controls.Add(Me.pnquestion)
        Me.tmosaic.SetDecoration(Me.pncontainer, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.pncontainer, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pncontainer, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pncontainer, BunifuAnimatorNS.DecorationType.None)
        Me.pncontainer.Location = New System.Drawing.Point(194, 147)
        Me.pncontainer.Name = "pncontainer"
        Me.pncontainer.Size = New System.Drawing.Size(509, 457)
        Me.pncontainer.TabIndex = 38
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trotate.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(755, 672)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(61, 52)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 39
        Me.BunifuImageButton1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BunifuImageButton1, "SPEAKER ON")
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 7
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 10
        Me.BunifuElipse2.TargetControl = Me.pntitle
        '
        'tVertSlide
        '
        Me.tVertSlide.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.tVertSlide.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0.0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0.0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0.0!
        Animation2.RotateLimit = 0.0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0.0!
        Animation2.TransparencyCoeff = 0.0!
        Me.tVertSlide.DefaultAnimation = Animation2
        Me.tVertSlide.Interval = 15
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 7
        Me.BunifuElipse3.TargetControl = Me.btn1
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 7
        Me.BunifuElipse4.TargetControl = Me.btn2
        '
        'BunifuElipse5
        '
        Me.BunifuElipse5.ElipseRadius = 7
        Me.BunifuElipse5.TargetControl = Me.btn3
        '
        'BunifuElipse6
        '
        Me.BunifuElipse6.ElipseRadius = 7
        Me.BunifuElipse6.TargetControl = Me.btn4
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0.0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0.0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0.0!
        Animation3.RotateLimit = 0.0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0.0!
        Animation3.TransparencyCoeff = 0.0!
        Me.BunifuTransition1.DefaultAnimation = Animation3
        Me.BunifuTransition1.Interval = 15
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
        'frmEquation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(898, 736)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.pncontainer)
        Me.Controls.Add(Me.btnspeaker)
        Me.Controls.Add(Me.btnmute)
        Me.Controls.Add(Me.pntitle)
        Me.Controls.Add(Me.lblbest)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblwrong)
        Me.Controls.Add(Me.lblcorrect)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.pnbomb1)
        Me.Controls.Add(Me.pnbomb2)
        Me.Controls.Add(Me.pnbomb3)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEquation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEquation"
        Me.btn1.ResumeLayout(False)
        Me.btn1.PerformLayout()
        Me.btn2.ResumeLayout(False)
        Me.btn2.PerformLayout()
        Me.btn3.ResumeLayout(False)
        Me.btn3.PerformLayout()
        Me.btn4.ResumeLayout(False)
        Me.btn4.PerformLayout()
        Me.pnbomb3.ResumeLayout(False)
        Me.pnbomb3.PerformLayout()
        Me.pnbomb2.ResumeLayout(False)
        Me.pnbomb2.PerformLayout()
        Me.pnbomb1.ResumeLayout(False)
        Me.pnbomb1.PerformLayout()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pntitle.ResumeLayout(False)
        Me.pntitle.PerformLayout()
        CType(Me.btnspeaker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pncontainer.ResumeLayout(False)
        Me.pncontainer.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn1 As System.Windows.Forms.Panel
    Friend WithEvents lbl1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn2 As System.Windows.Forms.Panel
    Friend WithEvents lbl2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn3 As System.Windows.Forms.Panel
    Friend WithEvents lbl3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn4 As System.Windows.Forms.Panel
    Friend WithEvents lbl4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnquestion As System.Windows.Forms.Panel
    Friend WithEvents pnbomb3 As System.Windows.Forms.Panel
    Friend WithEvents lblbomb3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnbomb2 As System.Windows.Forms.Panel
    Friend WithEvents lblbomb2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnbomb1 As System.Windows.Forms.Panel
    Friend WithEvents lblbomb1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents tbquestion As System.Windows.Forms.TextBox
    Friend WithEvents TimerBomb3 As System.Windows.Forms.Timer
    Friend WithEvents TimerBomb2 As System.Windows.Forms.Timer
    Friend WithEvents TimerBomb1 As System.Windows.Forms.Timer
    Friend WithEvents tmosaic As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblcorrect As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblwrong As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblbest As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnclose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pntitle As System.Windows.Forms.Panel
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tVertSlide As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse4 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse5 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse6 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnspeaker As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnmute As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pncontainer As System.Windows.Forms.Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents trotate As BunifuAnimatorNS.BunifuTransition
End Class
