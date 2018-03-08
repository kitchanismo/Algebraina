<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemperature
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemperature))
        Dim Animation10 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation11 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation9 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation7 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation12 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation8 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.pnthermo = New System.Windows.Forms.Panel()
        Me.pnheight = New System.Windows.Forms.Panel()
        Me.PicCup = New System.Windows.Forms.PictureBox()
        Me.btn4 = New System.Windows.Forms.Panel()
        Me.lbl4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn3 = New System.Windows.Forms.Panel()
        Me.lbl3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn2 = New System.Windows.Forms.Panel()
        Me.lbl2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn1 = New System.Windows.Forms.Panel()
        Me.lbl1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.timerresize = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblunit = New System.Windows.Forms.Label()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnspeaker = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pntitle = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnclose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblbest = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblwrong = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblcorrect = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pnbomb1 = New System.Windows.Forms.Panel()
        Me.lblbomb1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnbomb2 = New System.Windows.Forms.Panel()
        Me.lblbomb2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnbomb3 = New System.Windows.Forms.Panel()
        Me.lblbomb3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TimerBomb1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerBomb2 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerBomb3 = New System.Windows.Forms.Timer(Me.components)
        Me.tmosaic = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.btnmute = New Bunifu.Framework.UI.BunifuImageButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tbquestion = New System.Windows.Forms.TextBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse5 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse4 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse6 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.tVertSlide = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.tparticles = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.trotate = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuElipse7 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.tleaf = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.pnthermo.SuspendLayout()
        CType(Me.PicCup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btn4.SuspendLayout()
        Me.btn3.SuspendLayout()
        Me.btn2.SuspendLayout()
        Me.btn1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnspeaker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pntitle.SuspendLayout()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnbomb1.SuspendLayout()
        Me.pnbomb2.SuspendLayout()
        Me.pnbomb3.SuspendLayout()
        CType(Me.btnmute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnthermo
        '
        Me.pnthermo.BackColor = System.Drawing.Color.Transparent
        Me.pnthermo.BackgroundImage = CType(resources.GetObject("pnthermo.BackgroundImage"), System.Drawing.Image)
        Me.pnthermo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnthermo.Controls.Add(Me.pnheight)
        Me.tparticles.SetDecoration(Me.pnthermo, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.pnthermo, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pnthermo, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.pnthermo, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.pnthermo, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pnthermo, BunifuAnimatorNS.DecorationType.None)
        Me.pnthermo.Location = New System.Drawing.Point(662, 165)
        Me.pnthermo.Name = "pnthermo"
        Me.pnthermo.Size = New System.Drawing.Size(120, 358)
        Me.pnthermo.TabIndex = 0
        '
        'pnheight
        '
        Me.pnheight.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnheight.BackColor = System.Drawing.Color.White
        Me.tparticles.SetDecoration(Me.pnheight, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.pnheight, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pnheight, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.pnheight, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.pnheight, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pnheight, BunifuAnimatorNS.DecorationType.None)
        Me.pnheight.Location = New System.Drawing.Point(52, 22)
        Me.pnheight.Name = "pnheight"
        Me.pnheight.Size = New System.Drawing.Size(15, 250)
        Me.pnheight.TabIndex = 0
        '
        'PicCup
        '
        Me.tparticles.SetDecoration(Me.PicCup, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.PicCup, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.PicCup, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.PicCup, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.PicCup, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.PicCup, BunifuAnimatorNS.DecorationType.None)
        Me.PicCup.Location = New System.Drawing.Point(275, 165)
        Me.PicCup.Name = "PicCup"
        Me.PicCup.Size = New System.Drawing.Size(357, 358)
        Me.PicCup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCup.TabIndex = 1
        Me.PicCup.TabStop = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn4.Controls.Add(Me.lbl4)
        Me.btn4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tparticles.SetDecoration(Me.btn4, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.btn4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn4, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.btn4, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btn4, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btn4, BunifuAnimatorNS.DecorationType.None)
        Me.btn4.Location = New System.Drawing.Point(595, 569)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(110, 65)
        Me.btn4.TabIndex = 81
        '
        'lbl4
        '
        Me.lbl4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl4.AutoSize = True
        Me.lbl4.BackColor = System.Drawing.Color.Transparent
        Me.lbl4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.lbl4, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.lbl4, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lbl4, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lbl4, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.lbl4, BunifuAnimatorNS.DecorationType.None)
        Me.tparticles.SetDecoration(Me.lbl4, BunifuAnimatorNS.DecorationType.None)
        Me.lbl4.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.White
        Me.lbl4.Location = New System.Drawing.Point(8, 13)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(0, 39)
        Me.lbl4.TabIndex = 57
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn3.Controls.Add(Me.lbl3)
        Me.btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tparticles.SetDecoration(Me.btn3, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.btn3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn3, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.btn3, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btn3, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btn3, BunifuAnimatorNS.DecorationType.None)
        Me.btn3.Location = New System.Drawing.Point(464, 569)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(110, 65)
        Me.btn3.TabIndex = 82
        '
        'lbl3
        '
        Me.lbl3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.Color.Transparent
        Me.lbl3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.lbl3, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.lbl3, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lbl3, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lbl3, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.lbl3, BunifuAnimatorNS.DecorationType.None)
        Me.tparticles.SetDecoration(Me.lbl3, BunifuAnimatorNS.DecorationType.None)
        Me.lbl3.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.White
        Me.lbl3.Location = New System.Drawing.Point(8, 13)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(0, 39)
        Me.lbl3.TabIndex = 55
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn2.Controls.Add(Me.lbl2)
        Me.btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tparticles.SetDecoration(Me.btn2, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.btn2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn2, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.btn2, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btn2, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btn2, BunifuAnimatorNS.DecorationType.None)
        Me.btn2.Location = New System.Drawing.Point(334, 569)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(110, 65)
        Me.btn2.TabIndex = 80
        '
        'lbl2
        '
        Me.lbl2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.lbl2, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.lbl2, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lbl2, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lbl2, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.lbl2, BunifuAnimatorNS.DecorationType.None)
        Me.tparticles.SetDecoration(Me.lbl2, BunifuAnimatorNS.DecorationType.None)
        Me.lbl2.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(8, 13)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(0, 39)
        Me.lbl2.TabIndex = 53
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn1.Controls.Add(Me.lbl1)
        Me.btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tparticles.SetDecoration(Me.btn1, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.btn1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn1, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.btn1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btn1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btn1, BunifuAnimatorNS.DecorationType.None)
        Me.btn1.Location = New System.Drawing.Point(202, 569)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(110, 65)
        Me.btn1.TabIndex = 79
        '
        'lbl1
        '
        Me.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.lbl1, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.lbl1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lbl1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lbl1, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.lbl1, BunifuAnimatorNS.DecorationType.None)
        Me.tparticles.SetDecoration(Me.lbl1, BunifuAnimatorNS.DecorationType.None)
        Me.lbl1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(8, 13)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(0, 39)
        Me.lbl1.TabIndex = 51
        '
        'timerresize
        '
        Me.timerresize.Interval = 1
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblunit)
        Me.tparticles.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(640, 155)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(46, 264)
        Me.Panel1.TabIndex = 1
        '
        'lblunit
        '
        Me.lblunit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblunit.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblunit, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.lblunit, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblunit, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lblunit, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.lblunit, BunifuAnimatorNS.DecorationType.None)
        Me.tparticles.SetDecoration(Me.lblunit, BunifuAnimatorNS.DecorationType.None)
        Me.lblunit.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunit.ForeColor = System.Drawing.Color.White
        Me.lblunit.Location = New System.Drawing.Point(14, 27)
        Me.lblunit.Name = "lblunit"
        Me.lblunit.Size = New System.Drawing.Size(33, 30)
        Me.lblunit.TabIndex = 0
        Me.lblunit.Text = "C"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tparticles.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(758, 672)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(61, 52)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 107
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'btnspeaker
        '
        Me.btnspeaker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnspeaker.BackColor = System.Drawing.Color.Transparent
        Me.btnspeaker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnspeaker, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.btnspeaker, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btnspeaker, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btnspeaker, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.btnspeaker, BunifuAnimatorNS.DecorationType.None)
        Me.tparticles.SetDecoration(Me.btnspeaker, BunifuAnimatorNS.DecorationType.None)
        Me.btnspeaker.Image = CType(resources.GetObject("btnspeaker.Image"), System.Drawing.Image)
        Me.btnspeaker.ImageActive = Nothing
        Me.btnspeaker.Location = New System.Drawing.Point(825, 673)
        Me.btnspeaker.Name = "btnspeaker"
        Me.btnspeaker.Size = New System.Drawing.Size(61, 52)
        Me.btnspeaker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnspeaker.TabIndex = 106
        Me.btnspeaker.TabStop = False
        Me.btnspeaker.Zoom = 10
        '
        'pntitle
        '
        Me.pntitle.BackColor = System.Drawing.Color.Teal
        Me.pntitle.Controls.Add(Me.BunifuCustomLabel7)
        Me.pntitle.Controls.Add(Me.btnclose)
        Me.tparticles.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.pntitle.Location = New System.Drawing.Point(27, -1)
        Me.pntitle.Name = "pntitle"
        Me.pntitle.Size = New System.Drawing.Size(855, 66)
        Me.pntitle.TabIndex = 105
        Me.pntitle.Visible = False
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.BunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.BunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.BunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.BunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None)
        Me.tparticles.SetDecoration(Me.BunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(310, 15)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(237, 42)
        Me.BunifuCustomLabel7.TabIndex = 29
        Me.BunifuCustomLabel7.Text = "Temperature"
        '
        'btnclose
        '
        Me.btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.BunifuTransition1.SetDecoration(Me.btnclose, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.btnclose, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btnclose, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btnclose, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.btnclose, BunifuAnimatorNS.DecorationType.None)
        Me.tparticles.SetDecoration(Me.btnclose, BunifuAnimatorNS.DecorationType.None)
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageActive = Nothing
        Me.btnclose.Location = New System.Drawing.Point(4, 12)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(45, 45)
        Me.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnclose.TabIndex = 30
        Me.btnclose.TabStop = False
        Me.btnclose.Zoom = 10
        '
        'lblbest
        '
        Me.lblbest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblbest.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblbest, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.lblbest, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblbest, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lblbest, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.lblbest, BunifuAnimatorNS.DecorationType.None)
        Me.tparticles.SetDecoration(Me.lblbest, BunifuAnimatorNS.DecorationType.None)
        Me.lblbest.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbest.ForeColor = System.Drawing.Color.White
        Me.lblbest.Location = New System.Drawing.Point(62, 596)
        Me.lblbest.Name = "lblbest"
        Me.lblbest.Size = New System.Drawing.Size(37, 42)
        Me.lblbest.TabIndex = 104
        Me.lblbest.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tparticles.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(13, 588)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(55, 50)
        Me.Panel2.TabIndex = 103
        '
        'lblwrong
        '
        Me.lblwrong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblwrong.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblwrong, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.lblwrong, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblwrong, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lblwrong, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.lblwrong, BunifuAnimatorNS.DecorationType.None)
        Me.tparticles.SetDecoration(Me.lblwrong, BunifuAnimatorNS.DecorationType.None)
        Me.lblwrong.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwrong.ForeColor = System.Drawing.Color.White
        Me.lblwrong.Location = New System.Drawing.Point(62, 685)
        Me.lblwrong.Name = "lblwrong"
        Me.lblwrong.Size = New System.Drawing.Size(37, 42)
        Me.lblwrong.TabIndex = 102
        Me.lblwrong.Text = "0"
        '
        'lblcorrect
        '
        Me.lblcorrect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblcorrect.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblcorrect, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.lblcorrect, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblcorrect, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lblcorrect, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.lblcorrect, BunifuAnimatorNS.DecorationType.None)
        Me.tparticles.SetDecoration(Me.lblcorrect, BunifuAnimatorNS.DecorationType.None)
        Me.lblcorrect.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorrect.ForeColor = System.Drawing.Color.White
        Me.lblcorrect.Location = New System.Drawing.Point(62, 640)
        Me.lblcorrect.Name = "lblcorrect"
        Me.lblcorrect.Size = New System.Drawing.Size(37, 42)
        Me.lblcorrect.TabIndex = 99
        Me.lblcorrect.Text = "0"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tparticles.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.Panel4.Location = New System.Drawing.Point(22, 689)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(37, 33)
        Me.Panel4.TabIndex = 101
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), System.Drawing.Image)
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tparticles.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.Panel6.Location = New System.Drawing.Point(20, 643)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(39, 35)
        Me.Panel6.TabIndex = 100
        '
        'pnbomb1
        '
        Me.pnbomb1.BackColor = System.Drawing.Color.Transparent
        Me.pnbomb1.BackgroundImage = CType(resources.GetObject("pnbomb1.BackgroundImage"), System.Drawing.Image)
        Me.pnbomb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnbomb1.Controls.Add(Me.lblbomb1)
        Me.tparticles.SetDecoration(Me.pnbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.pnbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pnbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.pnbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.pnbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pnbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.pnbomb1.Location = New System.Drawing.Point(27, 260)
        Me.pnbomb1.Name = "pnbomb1"
        Me.pnbomb1.Size = New System.Drawing.Size(77, 88)
        Me.pnbomb1.TabIndex = 98
        Me.pnbomb1.Visible = False
        '
        'lblbomb1
        '
        Me.lblbomb1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblbomb1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.lblbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lblbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.lblbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.tparticles.SetDecoration(Me.lblbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.lblbomb1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbomb1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblbomb1.Location = New System.Drawing.Point(2, 38)
        Me.lblbomb1.Name = "lblbomb1"
        Me.lblbomb1.Size = New System.Drawing.Size(62, 44)
        Me.lblbomb1.TabIndex = 19
        Me.lblbomb1.Text = "60"
        '
        'pnbomb2
        '
        Me.pnbomb2.BackColor = System.Drawing.Color.Transparent
        Me.pnbomb2.BackgroundImage = CType(resources.GetObject("pnbomb2.BackgroundImage"), System.Drawing.Image)
        Me.pnbomb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnbomb2.Controls.Add(Me.lblbomb2)
        Me.tparticles.SetDecoration(Me.pnbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.pnbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pnbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.pnbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.pnbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pnbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.pnbomb2.Location = New System.Drawing.Point(27, 166)
        Me.pnbomb2.Name = "pnbomb2"
        Me.pnbomb2.Size = New System.Drawing.Size(77, 88)
        Me.pnbomb2.TabIndex = 97
        Me.pnbomb2.Visible = False
        '
        'lblbomb2
        '
        Me.lblbomb2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblbomb2.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.lblbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lblbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.lblbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.tparticles.SetDecoration(Me.lblbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.lblbomb2.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbomb2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblbomb2.Location = New System.Drawing.Point(2, 38)
        Me.lblbomb2.Name = "lblbomb2"
        Me.lblbomb2.Size = New System.Drawing.Size(62, 44)
        Me.lblbomb2.TabIndex = 19
        Me.lblbomb2.Text = "60"
        '
        'pnbomb3
        '
        Me.pnbomb3.BackColor = System.Drawing.Color.Transparent
        Me.pnbomb3.BackgroundImage = CType(resources.GetObject("pnbomb3.BackgroundImage"), System.Drawing.Image)
        Me.pnbomb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnbomb3.Controls.Add(Me.lblbomb3)
        Me.tparticles.SetDecoration(Me.pnbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.pnbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pnbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.pnbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.pnbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pnbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.pnbomb3.Location = New System.Drawing.Point(27, 72)
        Me.pnbomb3.Name = "pnbomb3"
        Me.pnbomb3.Size = New System.Drawing.Size(77, 88)
        Me.pnbomb3.TabIndex = 96
        Me.pnbomb3.Visible = False
        '
        'lblbomb3
        '
        Me.lblbomb3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblbomb3.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.lblbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lblbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.lblbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.tparticles.SetDecoration(Me.lblbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.lblbomb3.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbomb3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblbomb3.Location = New System.Drawing.Point(2, 38)
        Me.lblbomb3.Name = "lblbomb3"
        Me.lblbomb3.Size = New System.Drawing.Size(62, 44)
        Me.lblbomb3.TabIndex = 19
        Me.lblbomb3.Text = "60"
        '
        'TimerBomb1
        '
        Me.TimerBomb1.Interval = 1000
        '
        'TimerBomb2
        '
        Me.TimerBomb2.Interval = 1000
        '
        'TimerBomb3
        '
        Me.TimerBomb3.Interval = 1000
        '
        'tmosaic
        '
        Me.tmosaic.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic
        Me.tmosaic.Cursor = Nothing
        Animation10.AnimateOnlyDifferences = True
        Animation10.BlindCoeff = CType(resources.GetObject("Animation10.BlindCoeff"), System.Drawing.PointF)
        Animation10.LeafCoeff = 0.0!
        Animation10.MaxTime = 1.0!
        Animation10.MinTime = 0.0!
        Animation10.MosaicCoeff = CType(resources.GetObject("Animation10.MosaicCoeff"), System.Drawing.PointF)
        Animation10.MosaicShift = CType(resources.GetObject("Animation10.MosaicShift"), System.Drawing.PointF)
        Animation10.MosaicSize = 20
        Animation10.Padding = New System.Windows.Forms.Padding(30)
        Animation10.RotateCoeff = 0.0!
        Animation10.RotateLimit = 0.0!
        Animation10.ScaleCoeff = CType(resources.GetObject("Animation10.ScaleCoeff"), System.Drawing.PointF)
        Animation10.SlideCoeff = CType(resources.GetObject("Animation10.SlideCoeff"), System.Drawing.PointF)
        Animation10.TimeCoeff = 0.0!
        Animation10.TransparencyCoeff = 0.0!
        Me.tmosaic.DefaultAnimation = Animation10
        Me.tmosaic.Interval = 15
        '
        'btnmute
        '
        Me.btnmute.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmute.BackColor = System.Drawing.Color.Transparent
        Me.btnmute.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnmute, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.btnmute, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btnmute, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btnmute, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.btnmute, BunifuAnimatorNS.DecorationType.None)
        Me.tparticles.SetDecoration(Me.btnmute, BunifuAnimatorNS.DecorationType.None)
        Me.btnmute.Image = CType(resources.GetObject("btnmute.Image"), System.Drawing.Image)
        Me.btnmute.ImageActive = Nothing
        Me.btnmute.Location = New System.Drawing.Point(825, 673)
        Me.btnmute.Name = "btnmute"
        Me.btnmute.Size = New System.Drawing.Size(61, 52)
        Me.btnmute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmute.TabIndex = 108
        Me.btnmute.TabStop = False
        Me.btnmute.Zoom = 10
        '
        'TextBox1
        '
        Me.trotate.SetDecoration(Me.TextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tparticles.SetDecoration(Me.TextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.TextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.TextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.TextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.TextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox1.Location = New System.Drawing.Point(652, 749)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 109
        '
        'tbquestion
        '
        Me.tbquestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.tbquestion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbquestion.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.trotate.SetDecoration(Me.tbquestion, BunifuAnimatorNS.DecorationType.None)
        Me.tparticles.SetDecoration(Me.tbquestion, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.tbquestion, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.tbquestion, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me.tbquestion, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.tbquestion, BunifuAnimatorNS.DecorationType.None)
        Me.tbquestion.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbquestion.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tbquestion.HideSelection = False
        Me.tbquestion.Location = New System.Drawing.Point(111, 104)
        Me.tbquestion.Name = "tbquestion"
        Me.tbquestion.ReadOnly = True
        Me.tbquestion.Size = New System.Drawing.Size(659, 46)
        Me.tbquestion.TabIndex = 110
        Me.tbquestion.Text = "???????????"
        Me.tbquestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'BunifuElipse5
        '
        Me.BunifuElipse5.ElipseRadius = 7
        Me.BunifuElipse5.TargetControl = Me.btn3
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 7
        Me.BunifuElipse4.TargetControl = Me.btn2
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 7
        Me.BunifuElipse3.TargetControl = Me.btn1
        '
        'BunifuElipse6
        '
        Me.BunifuElipse6.ElipseRadius = 7
        Me.BunifuElipse6.TargetControl = Me.btn4
        '
        'tVertSlide
        '
        Me.tVertSlide.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.tVertSlide.Cursor = Nothing
        Animation11.AnimateOnlyDifferences = True
        Animation11.BlindCoeff = CType(resources.GetObject("Animation11.BlindCoeff"), System.Drawing.PointF)
        Animation11.LeafCoeff = 0.0!
        Animation11.MaxTime = 1.0!
        Animation11.MinTime = 0.0!
        Animation11.MosaicCoeff = CType(resources.GetObject("Animation11.MosaicCoeff"), System.Drawing.PointF)
        Animation11.MosaicShift = CType(resources.GetObject("Animation11.MosaicShift"), System.Drawing.PointF)
        Animation11.MosaicSize = 0
        Animation11.Padding = New System.Windows.Forms.Padding(0)
        Animation11.RotateCoeff = 0.0!
        Animation11.RotateLimit = 0.0!
        Animation11.ScaleCoeff = CType(resources.GetObject("Animation11.ScaleCoeff"), System.Drawing.PointF)
        Animation11.SlideCoeff = CType(resources.GetObject("Animation11.SlideCoeff"), System.Drawing.PointF)
        Animation11.TimeCoeff = 0.0!
        Animation11.TransparencyCoeff = 0.0!
        Me.tVertSlide.DefaultAnimation = Animation11
        Me.tVertSlide.Interval = 15
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation9.AnimateOnlyDifferences = True
        Animation9.BlindCoeff = CType(resources.GetObject("Animation9.BlindCoeff"), System.Drawing.PointF)
        Animation9.LeafCoeff = 0.0!
        Animation9.MaxTime = 1.0!
        Animation9.MinTime = 0.0!
        Animation9.MosaicCoeff = CType(resources.GetObject("Animation9.MosaicCoeff"), System.Drawing.PointF)
        Animation9.MosaicShift = CType(resources.GetObject("Animation9.MosaicShift"), System.Drawing.PointF)
        Animation9.MosaicSize = 0
        Animation9.Padding = New System.Windows.Forms.Padding(0)
        Animation9.RotateCoeff = 0.0!
        Animation9.RotateLimit = 0.0!
        Animation9.ScaleCoeff = CType(resources.GetObject("Animation9.ScaleCoeff"), System.Drawing.PointF)
        Animation9.SlideCoeff = CType(resources.GetObject("Animation9.SlideCoeff"), System.Drawing.PointF)
        Animation9.TimeCoeff = 0.0!
        Animation9.TransparencyCoeff = 0.0!
        Me.BunifuTransition1.DefaultAnimation = Animation9
        Me.BunifuTransition1.Interval = 15
        '
        'tparticles
        '
        Me.tparticles.AnimationType = BunifuAnimatorNS.AnimationType.Leaf
        Me.tparticles.Cursor = Nothing
        Animation7.AnimateOnlyDifferences = True
        Animation7.BlindCoeff = CType(resources.GetObject("Animation7.BlindCoeff"), System.Drawing.PointF)
        Animation7.LeafCoeff = 1.0!
        Animation7.MaxTime = 1.0!
        Animation7.MinTime = 0.0!
        Animation7.MosaicCoeff = CType(resources.GetObject("Animation7.MosaicCoeff"), System.Drawing.PointF)
        Animation7.MosaicShift = CType(resources.GetObject("Animation7.MosaicShift"), System.Drawing.PointF)
        Animation7.MosaicSize = 0
        Animation7.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation7.RotateCoeff = 0.0!
        Animation7.RotateLimit = 0.0!
        Animation7.ScaleCoeff = CType(resources.GetObject("Animation7.ScaleCoeff"), System.Drawing.PointF)
        Animation7.SlideCoeff = CType(resources.GetObject("Animation7.SlideCoeff"), System.Drawing.PointF)
        Animation7.TimeCoeff = 0.0!
        Animation7.TransparencyCoeff = 0.0!
        Me.tparticles.DefaultAnimation = Animation7
        '
        'trotate
        '
        Me.trotate.AnimationType = BunifuAnimatorNS.AnimationType.Rotate
        Me.trotate.Cursor = Nothing
        Animation12.AnimateOnlyDifferences = True
        Animation12.BlindCoeff = CType(resources.GetObject("Animation12.BlindCoeff"), System.Drawing.PointF)
        Animation12.LeafCoeff = 0.0!
        Animation12.MaxTime = 1.0!
        Animation12.MinTime = 0.0!
        Animation12.MosaicCoeff = CType(resources.GetObject("Animation12.MosaicCoeff"), System.Drawing.PointF)
        Animation12.MosaicShift = CType(resources.GetObject("Animation12.MosaicShift"), System.Drawing.PointF)
        Animation12.MosaicSize = 0
        Animation12.Padding = New System.Windows.Forms.Padding(50)
        Animation12.RotateCoeff = 1.0!
        Animation12.RotateLimit = 0.0!
        Animation12.ScaleCoeff = CType(resources.GetObject("Animation12.ScaleCoeff"), System.Drawing.PointF)
        Animation12.SlideCoeff = CType(resources.GetObject("Animation12.SlideCoeff"), System.Drawing.PointF)
        Animation12.TimeCoeff = 0.0!
        Animation12.TransparencyCoeff = 1.0!
        Me.trotate.DefaultAnimation = Animation12
        Me.trotate.Interval = 15
        Me.trotate.MaxAnimationTime = 2000
        '
        'BunifuElipse7
        '
        Me.BunifuElipse7.ElipseRadius = 10
        Me.BunifuElipse7.TargetControl = Me.pnheight
        '
        'tleaf
        '
        Me.tleaf.AnimationType = BunifuAnimatorNS.AnimationType.Leaf
        Me.tleaf.Cursor = Nothing
        Animation8.AnimateOnlyDifferences = True
        Animation8.BlindCoeff = CType(resources.GetObject("Animation8.BlindCoeff"), System.Drawing.PointF)
        Animation8.LeafCoeff = 1.0!
        Animation8.MaxTime = 1.0!
        Animation8.MinTime = 0.0!
        Animation8.MosaicCoeff = CType(resources.GetObject("Animation8.MosaicCoeff"), System.Drawing.PointF)
        Animation8.MosaicShift = CType(resources.GetObject("Animation8.MosaicShift"), System.Drawing.PointF)
        Animation8.MosaicSize = 0
        Animation8.Padding = New System.Windows.Forms.Padding(0)
        Animation8.RotateCoeff = 0.0!
        Animation8.RotateLimit = 0.0!
        Animation8.ScaleCoeff = CType(resources.GetObject("Animation8.ScaleCoeff"), System.Drawing.PointF)
        Animation8.SlideCoeff = CType(resources.GetObject("Animation8.SlideCoeff"), System.Drawing.PointF)
        Animation8.TimeCoeff = 0.0!
        Animation8.TransparencyCoeff = 0.0!
        Me.tleaf.DefaultAnimation = Animation8
        '
        'frmTemperature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(898, 736)
        Me.Controls.Add(Me.tbquestion)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PicCup)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.btnspeaker)
        Me.Controls.Add(Me.pntitle)
        Me.Controls.Add(Me.lblbest)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblwrong)
        Me.Controls.Add(Me.lblcorrect)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.pnbomb1)
        Me.Controls.Add(Me.pnbomb2)
        Me.Controls.Add(Me.pnbomb3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.pnthermo)
        Me.Controls.Add(Me.btnmute)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tparticles.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tleaf.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTemperature"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTemperature"
        Me.pnthermo.ResumeLayout(False)
        CType(Me.PicCup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btn4.ResumeLayout(False)
        Me.btn4.PerformLayout()
        Me.btn3.ResumeLayout(False)
        Me.btn3.PerformLayout()
        Me.btn2.ResumeLayout(False)
        Me.btn2.PerformLayout()
        Me.btn1.ResumeLayout(False)
        Me.btn1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnspeaker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pntitle.ResumeLayout(False)
        Me.pntitle.PerformLayout()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnbomb1.ResumeLayout(False)
        Me.pnbomb1.PerformLayout()
        Me.pnbomb2.ResumeLayout(False)
        Me.pnbomb2.PerformLayout()
        Me.pnbomb3.ResumeLayout(False)
        Me.pnbomb3.PerformLayout()
        CType(Me.btnmute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnthermo As System.Windows.Forms.Panel
    Friend WithEvents pnheight As System.Windows.Forms.Panel
    Friend WithEvents PicCup As System.Windows.Forms.PictureBox
    Friend WithEvents btn4 As System.Windows.Forms.Panel
    Friend WithEvents lbl4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn3 As System.Windows.Forms.Panel
    Friend WithEvents lbl3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn2 As System.Windows.Forms.Panel
    Friend WithEvents lbl2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn1 As System.Windows.Forms.Panel
    Friend WithEvents lbl1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents timerresize As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblunit As System.Windows.Forms.Label
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnspeaker As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pntitle As System.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnclose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblbest As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblwrong As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblcorrect As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents pnbomb1 As System.Windows.Forms.Panel
    Friend WithEvents lblbomb1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnbomb2 As System.Windows.Forms.Panel
    Friend WithEvents lblbomb2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnbomb3 As System.Windows.Forms.Panel
    Friend WithEvents lblbomb3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tmosaic As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents tparticles As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents trotate As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents tVertSlide As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents TimerBomb1 As System.Windows.Forms.Timer
    Friend WithEvents TimerBomb2 As System.Windows.Forms.Timer
    Friend WithEvents TimerBomb3 As System.Windows.Forms.Timer
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse5 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse4 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse6 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnmute As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents tbquestion As System.Windows.Forms.TextBox
    Friend WithEvents BunifuElipse7 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents tleaf As BunifuAnimatorNS.BunifuTransition
End Class
