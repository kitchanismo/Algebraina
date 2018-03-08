<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTime
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
        Dim Animation5 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation4 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTime))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnbomb1 = New System.Windows.Forms.Panel()
        Me.lblbomb1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnbomb2 = New System.Windows.Forms.Panel()
        Me.lblbomb2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnbomb3 = New System.Windows.Forms.Panel()
        Me.lblbomb3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pntitle = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnclose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblbest = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblwrong = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblcorrect = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btn1 = New System.Windows.Forms.Panel()
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btn2 = New System.Windows.Forms.Panel()
        Me.BunifuElipse4 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btn3 = New System.Windows.Forms.Panel()
        Me.BunifuElipse5 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btn4 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tbquestion = New System.Windows.Forms.TextBox()
        Me.TimerBomb3 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerBomb2 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerBomb1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmosaic = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.pnquestion = New AnalogClock.Clock()
        Me.btnspeaker = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnmute = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tVertSlide = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuElipse6 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.trotate = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuTransition2 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.pnbomb1.SuspendLayout()
        Me.pnbomb2.SuspendLayout()
        Me.pnbomb3.SuspendLayout()
        Me.pntitle.SuspendLayout()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btn1.SuspendLayout()
        Me.btn2.SuspendLayout()
        Me.btn3.SuspendLayout()
        Me.btn4.SuspendLayout()
        CType(Me.btnspeaker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'pnbomb1
        '
        Me.pnbomb1.BackColor = System.Drawing.Color.Transparent
        Me.pnbomb1.BackgroundImage = CType(resources.GetObject("pnbomb1.BackgroundImage"), System.Drawing.Image)
        Me.pnbomb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnbomb1.Controls.Add(Me.lblbomb1)
        Me.tmosaic.SetDecoration(Me.pnbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pnbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pnbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.pnbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.pnbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.pnbomb1.Location = New System.Drawing.Point(24, 269)
        Me.pnbomb1.Name = "pnbomb1"
        Me.pnbomb1.Size = New System.Drawing.Size(77, 88)
        Me.pnbomb1.TabIndex = 69
        Me.pnbomb1.Visible = False
        '
        'lblbomb1
        '
        Me.lblbomb1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblbomb1.AutoSize = True
        Me.tmosaic.SetDecoration(Me.lblbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lblbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lblbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lblbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.lblbomb1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbomb1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblbomb1.Location = New System.Drawing.Point(1, 37)
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
        Me.tmosaic.SetDecoration(Me.pnbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pnbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pnbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.pnbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.pnbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.pnbomb2.Location = New System.Drawing.Point(24, 175)
        Me.pnbomb2.Name = "pnbomb2"
        Me.pnbomb2.Size = New System.Drawing.Size(77, 88)
        Me.pnbomb2.TabIndex = 68
        Me.pnbomb2.Visible = False
        '
        'lblbomb2
        '
        Me.lblbomb2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblbomb2.AutoSize = True
        Me.tmosaic.SetDecoration(Me.lblbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lblbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lblbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lblbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.lblbomb2.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbomb2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblbomb2.Location = New System.Drawing.Point(1, 37)
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
        Me.tmosaic.SetDecoration(Me.pnbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pnbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pnbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.pnbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.pnbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.pnbomb3.Location = New System.Drawing.Point(24, 81)
        Me.pnbomb3.Name = "pnbomb3"
        Me.pnbomb3.Size = New System.Drawing.Size(77, 88)
        Me.pnbomb3.TabIndex = 67
        Me.pnbomb3.Visible = False
        '
        'lblbomb3
        '
        Me.lblbomb3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblbomb3.AutoSize = True
        Me.tmosaic.SetDecoration(Me.lblbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lblbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lblbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lblbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.lblbomb3.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbomb3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblbomb3.Location = New System.Drawing.Point(1, 37)
        Me.lblbomb3.Name = "lblbomb3"
        Me.lblbomb3.Size = New System.Drawing.Size(62, 44)
        Me.lblbomb3.TabIndex = 19
        Me.lblbomb3.Text = "60"
        '
        'pntitle
        '
        Me.pntitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pntitle.BackColor = System.Drawing.Color.Teal
        Me.pntitle.Controls.Add(Me.BunifuCustomLabel4)
        Me.pntitle.Controls.Add(Me.btnclose)
        Me.tmosaic.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.pntitle.Location = New System.Drawing.Point(24, -2)
        Me.pntitle.Name = "pntitle"
        Me.pntitle.Size = New System.Drawing.Size(855, 66)
        Me.pntitle.TabIndex = 66
        Me.pntitle.Visible = False
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel4.AutoSize = True
        Me.tmosaic.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(282, 15)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(286, 42)
        Me.BunifuCustomLabel4.TabIndex = 29
        Me.BunifuCustomLabel4.Text = "WHAT TIME IS IT?"
        '
        'btnclose
        '
        Me.btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.BunifuTransition1.SetDecoration(Me.btnclose, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.btnclose, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btnclose, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btnclose, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.btnclose, BunifuAnimatorNS.DecorationType.None)
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageActive = Nothing
        Me.btnclose.Location = New System.Drawing.Point(5, 11)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(45, 45)
        Me.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnclose.TabIndex = 65
        Me.btnclose.TabStop = False
        Me.btnclose.Zoom = 5
        '
        'lblbest
        '
        Me.lblbest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblbest.AutoSize = True
        Me.tmosaic.SetDecoration(Me.lblbest, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lblbest, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblbest, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lblbest, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lblbest, BunifuAnimatorNS.DecorationType.None)
        Me.lblbest.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbest.ForeColor = System.Drawing.Color.White
        Me.lblbest.Location = New System.Drawing.Point(57, 590)
        Me.lblbest.Name = "lblbest"
        Me.lblbest.Size = New System.Drawing.Size(37, 42)
        Me.lblbest.TabIndex = 64
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
        Me.trotate.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.Panel3.Location = New System.Drawing.Point(8, 582)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(55, 50)
        Me.Panel3.TabIndex = 63
        '
        'lblwrong
        '
        Me.lblwrong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblwrong.AutoSize = True
        Me.tmosaic.SetDecoration(Me.lblwrong, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lblwrong, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblwrong, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lblwrong, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lblwrong, BunifuAnimatorNS.DecorationType.None)
        Me.lblwrong.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwrong.ForeColor = System.Drawing.Color.White
        Me.lblwrong.Location = New System.Drawing.Point(57, 683)
        Me.lblwrong.Name = "lblwrong"
        Me.lblwrong.Size = New System.Drawing.Size(37, 42)
        Me.lblwrong.TabIndex = 62
        Me.lblwrong.Text = "0"
        '
        'lblcorrect
        '
        Me.lblcorrect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblcorrect.AutoSize = True
        Me.tmosaic.SetDecoration(Me.lblcorrect, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lblcorrect, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblcorrect, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lblcorrect, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lblcorrect, BunifuAnimatorNS.DecorationType.None)
        Me.lblcorrect.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorrect.ForeColor = System.Drawing.Color.White
        Me.lblcorrect.Location = New System.Drawing.Point(57, 638)
        Me.lblcorrect.Name = "lblcorrect"
        Me.lblcorrect.Size = New System.Drawing.Size(37, 42)
        Me.lblcorrect.TabIndex = 60
        Me.lblcorrect.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tmosaic.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Location = New System.Drawing.Point(17, 688)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(37, 33)
        Me.Panel2.TabIndex = 61
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tmosaic.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.Panel4.Location = New System.Drawing.Point(15, 641)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(39, 35)
        Me.Panel4.TabIndex = 59
        '
        'lbl4
        '
        Me.lbl4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl4.AutoSize = True
        Me.lbl4.BackColor = System.Drawing.Color.Transparent
        Me.lbl4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.lbl4, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lbl4, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lbl4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lbl4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lbl4, BunifuAnimatorNS.DecorationType.None)
        Me.lbl4.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.White
        Me.lbl4.Location = New System.Drawing.Point(7, 13)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(98, 39)
        Me.lbl4.TabIndex = 57
        Me.lbl4.Text = "00:00"
        '
        'lbl3
        '
        Me.lbl3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.Color.Transparent
        Me.lbl3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.lbl3, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lbl3, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lbl3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lbl3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lbl3, BunifuAnimatorNS.DecorationType.None)
        Me.lbl3.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.White
        Me.lbl3.Location = New System.Drawing.Point(7, 13)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(98, 39)
        Me.lbl3.TabIndex = 55
        Me.lbl3.Text = "00:00"
        '
        'lbl2
        '
        Me.lbl2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.lbl2, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lbl2, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lbl2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lbl2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lbl2, BunifuAnimatorNS.DecorationType.None)
        Me.lbl2.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(7, 13)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(98, 39)
        Me.lbl2.TabIndex = 53
        Me.lbl2.Text = "00:00"
        '
        'lbl1
        '
        Me.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.lbl1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lbl1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lbl1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lbl1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lbl1, BunifuAnimatorNS.DecorationType.None)
        Me.lbl1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(7, 13)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(98, 39)
        Me.lbl1.TabIndex = 51
        Me.lbl1.Text = "00:00"
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me.btn1
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn1.Controls.Add(Me.lbl1)
        Me.btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.btn1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btn1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.btn1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btn1, BunifuAnimatorNS.DecorationType.None)
        Me.btn1.Location = New System.Drawing.Point(192, 602)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(110, 65)
        Me.btn1.TabIndex = 73
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 5
        Me.BunifuElipse3.TargetControl = Me.btn2
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn2.Controls.Add(Me.lbl2)
        Me.btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.btn2, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btn2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.btn2, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btn2, BunifuAnimatorNS.DecorationType.None)
        Me.btn2.Location = New System.Drawing.Point(324, 602)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(110, 65)
        Me.btn2.TabIndex = 74
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 5
        Me.BunifuElipse4.TargetControl = Me.btn3
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn3.Controls.Add(Me.lbl3)
        Me.btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.btn3, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btn3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.btn3, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btn3, BunifuAnimatorNS.DecorationType.None)
        Me.btn3.Location = New System.Drawing.Point(457, 602)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(110, 65)
        Me.btn3.TabIndex = 75
        '
        'BunifuElipse5
        '
        Me.BunifuElipse5.ElipseRadius = 5
        Me.BunifuElipse5.TargetControl = Me.btn4
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn4.Controls.Add(Me.lbl4)
        Me.btn4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.btn4, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btn4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.btn4, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btn4, BunifuAnimatorNS.DecorationType.None)
        Me.btn4.Location = New System.Drawing.Point(590, 602)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(110, 65)
        Me.btn4.TabIndex = 75
        '
        'TextBox1
        '
        Me.BunifuTransition2.SetDecoration(Me.TextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.TextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.TextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.TextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.TextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox1.Location = New System.Drawing.Point(907, 690)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 70
        '
        'tbquestion
        '
        Me.tbquestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.tbquestion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbquestion.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuTransition2.SetDecoration(Me.tbquestion, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.tbquestion, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.tbquestion, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.tbquestion, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.tbquestion, BunifuAnimatorNS.DecorationType.None)
        Me.tbquestion.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbquestion.ForeColor = System.Drawing.Color.White
        Me.tbquestion.HideSelection = False
        Me.tbquestion.Location = New System.Drawing.Point(201, 138)
        Me.tbquestion.Multiline = True
        Me.tbquestion.Name = "tbquestion"
        Me.tbquestion.ReadOnly = True
        Me.tbquestion.Size = New System.Drawing.Size(485, 98)
        Me.tbquestion.TabIndex = 71
        Me.tbquestion.Text = "???????????????????"
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
        Me.tmosaic.Interval = 15
        '
        'pnquestion
        '
        Me.pnquestion.BigMarkers = New AnalogClock.Marker() {New AnalogClock.Marker("BigMarker90", 90.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker60", 60.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker30", 30.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker0", 0.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker330", 330.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker300", 300.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker270", 270.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker240", 240.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker210", 210.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker180", 180.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker150", 150.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker120", 120.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing)}
        Me.pnquestion.CenterPoint.Color = System.Drawing.Color.White
        Me.pnquestion.CenterPoint.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.pnquestion.CenterPoint.RelativeRadius = 0.03!
        Me.pnquestion.CenterPoint.Tag = Nothing
        Me.BunifuTransition2.SetDecoration(Me.pnquestion, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pnquestion, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pnquestion, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.pnquestion, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.pnquestion, BunifuAnimatorNS.DecorationType.None)
        Me.pnquestion.HourHand.Color = System.Drawing.Color.Teal
        Me.pnquestion.HourHand.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.pnquestion.HourHand.RelativeRadius = 0.5!
        Me.pnquestion.HourHand.Style = AnalogClock.HandStyle.Pointed
        Me.pnquestion.HourHand.Tag = Nothing
        Me.pnquestion.HourHand.Width = 10.0!
        Me.pnquestion.Location = New System.Drawing.Point(288, 242)
        Me.pnquestion.MinuteHand.Color = System.Drawing.Color.Teal
        Me.pnquestion.MinuteHand.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.pnquestion.MinuteHand.RelativeRadius = 0.7!
        Me.pnquestion.MinuteHand.Style = AnalogClock.HandStyle.Pointed
        Me.pnquestion.MinuteHand.Tag = Nothing
        Me.pnquestion.MinuteHand.Width = 10.0!
        Me.pnquestion.Name = "pnquestion"
        Me.pnquestion.Running = False
        Me.pnquestion.SecondHand.Color = System.Drawing.Color.Gray
        Me.pnquestion.SecondHand.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.pnquestion.SecondHand.RelativeRadius = 0.9!
        Me.pnquestion.SecondHand.Tag = Nothing
        Me.pnquestion.SecondHand.Visible = False
        Me.pnquestion.SecondHand.Width = 1.0!
        Me.pnquestion.Size = New System.Drawing.Size(315, 306)
        Me.pnquestion.SmallMarkers = New AnalogClock.Marker() {New AnalogClock.Marker("SmallMarker90", 90.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker84", 84.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker78", 78.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker72", 72.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker66", 66.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker60", 60.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker54", 54.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker48", 48.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker42", 42.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker36", 36.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker30", 30.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker24", 24.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker18", 18.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker12", 12.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker6", 6.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker0", 0.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker354", 354.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker348", 348.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker342", 342.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker336", 336.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker330", 330.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker324", 324.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker318", 318.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker312", 312.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker306", 306.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker300", 300.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker294", 294.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker288", 288.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker282", 282.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker276", 276.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker270", 270.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker264", 264.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker258", 258.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker252", 252.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker246", 246.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker240", 240.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker234", 234.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker228", 228.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker222", 222.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker216", 216.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker210", 210.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker204", 204.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker198", 198.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker192", 192.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker186", 186.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker180", 180.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker174", 174.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker168", 168.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker162", 162.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker156", 156.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker150", 150.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker144", 144.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker138", 138.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker132", 132.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker126", 126.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker120", 120.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker114", 114.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker108", 108.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker102", 102.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker96", 96.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 153.0!, 2.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing)}
        Me.pnquestion.Symbols = New AnalogClock.Symbol() {New AnalogClock.Symbol("Symbol90", 90.0!, "12", New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 0, True, True, AnalogClock.SymbolStyle.Numeric, 153.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol60", 60.0!, "1", New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 1, True, True, AnalogClock.SymbolStyle.Numeric, 153.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol30", 30.0!, "2", New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 2, True, True, AnalogClock.SymbolStyle.Numeric, 153.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol0", 0.0!, "3", New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 3, True, True, AnalogClock.SymbolStyle.Numeric, 153.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol330", 330.0!, "4", New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 4, True, True, AnalogClock.SymbolStyle.Numeric, 153.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol300", 300.0!, "5", New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 5, True, True, AnalogClock.SymbolStyle.Numeric, 153.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol270", 270.0!, "6", New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 6, True, True, AnalogClock.SymbolStyle.Numeric, 153.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol240", 240.0!, "7", New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 7, True, True, AnalogClock.SymbolStyle.Numeric, 153.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol210", 210.0!, "8", New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 8, True, True, AnalogClock.SymbolStyle.Numeric, 153.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol180", 180.0!, "9", New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 9, True, True, AnalogClock.SymbolStyle.Numeric, 153.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol150", 150.0!, "10", New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 10, True, True, AnalogClock.SymbolStyle.Numeric, 153.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol120", 120.0!, "11", New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.White, New System.Drawing.Point(1, 1), 11, True, True, AnalogClock.SymbolStyle.Numeric, 153.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing)}
        Me.pnquestion.TabIndex = 76
        '
        'btnspeaker
        '
        Me.btnspeaker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnspeaker.BackColor = System.Drawing.Color.Transparent
        Me.btnspeaker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnspeaker, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.btnspeaker, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btnspeaker, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btnspeaker, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.btnspeaker, BunifuAnimatorNS.DecorationType.None)
        Me.btnspeaker.Image = CType(resources.GetObject("btnspeaker.Image"), System.Drawing.Image)
        Me.btnspeaker.ImageActive = Nothing
        Me.btnspeaker.Location = New System.Drawing.Point(825, 671)
        Me.btnspeaker.Name = "btnspeaker"
        Me.btnspeaker.Size = New System.Drawing.Size(61, 52)
        Me.btnspeaker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnspeaker.TabIndex = 77
        Me.btnspeaker.TabStop = False
        Me.btnspeaker.Zoom = 10
        '
        'btnmute
        '
        Me.btnmute.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmute.BackColor = System.Drawing.Color.Transparent
        Me.btnmute.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.btnmute, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.btnmute, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btnmute, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btnmute, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.btnmute, BunifuAnimatorNS.DecorationType.None)
        Me.btnmute.Image = CType(resources.GetObject("btnmute.Image"), System.Drawing.Image)
        Me.btnmute.ImageActive = Nothing
        Me.btnmute.Location = New System.Drawing.Point(825, 671)
        Me.btnmute.Name = "btnmute"
        Me.btnmute.Size = New System.Drawing.Size(61, 52)
        Me.btnmute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmute.TabIndex = 78
        Me.btnmute.TabStop = False
        Me.btnmute.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(758, 672)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(61, 50)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 79
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'tVertSlide
        '
        Me.tVertSlide.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.tVertSlide.Cursor = Nothing
        Animation4.AnimateOnlyDifferences = True
        Animation4.BlindCoeff = CType(resources.GetObject("Animation4.BlindCoeff"), System.Drawing.PointF)
        Animation4.LeafCoeff = 0.0!
        Animation4.MaxTime = 1.0!
        Animation4.MinTime = 0.0!
        Animation4.MosaicCoeff = CType(resources.GetObject("Animation4.MosaicCoeff"), System.Drawing.PointF)
        Animation4.MosaicShift = CType(resources.GetObject("Animation4.MosaicShift"), System.Drawing.PointF)
        Animation4.MosaicSize = 0
        Animation4.Padding = New System.Windows.Forms.Padding(0)
        Animation4.RotateCoeff = 0.0!
        Animation4.RotateLimit = 0.0!
        Animation4.ScaleCoeff = CType(resources.GetObject("Animation4.ScaleCoeff"), System.Drawing.PointF)
        Animation4.SlideCoeff = CType(resources.GetObject("Animation4.SlideCoeff"), System.Drawing.PointF)
        Animation4.TimeCoeff = 0.0!
        Animation4.TransparencyCoeff = 0.0!
        Me.tVertSlide.DefaultAnimation = Animation4
        Me.tVertSlide.Interval = 15
        '
        'BunifuElipse6
        '
        Me.BunifuElipse6.ElipseRadius = 7
        Me.BunifuElipse6.TargetControl = Me.pntitle
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
        Me.trotate.DefaultAnimation = Animation2
        Me.trotate.Interval = 15
        Me.trotate.MaxAnimationTime = 2000
        '
        'BunifuTransition2
        '
        Me.BunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Scale
        Me.BunifuTransition2.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0.0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation1.RotateCoeff = 0.0!
        Animation1.RotateLimit = 0.0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0.0!
        Animation1.TransparencyCoeff = 0.0!
        Me.BunifuTransition2.DefaultAnimation = Animation1
        Me.BunifuTransition2.Interval = 15
        '
        'frmTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(898, 736)
        Me.Controls.Add(Me.tbquestion)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.btnspeaker)
        Me.Controls.Add(Me.btnmute)
        Me.Controls.Add(Me.pnquestion)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.pnbomb1)
        Me.Controls.Add(Me.pnbomb2)
        Me.Controls.Add(Me.pnbomb3)
        Me.Controls.Add(Me.pntitle)
        Me.Controls.Add(Me.lblbest)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblwrong)
        Me.Controls.Add(Me.lblcorrect)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnbomb1.ResumeLayout(False)
        Me.pnbomb1.PerformLayout()
        Me.pnbomb2.ResumeLayout(False)
        Me.pnbomb2.PerformLayout()
        Me.pnbomb3.ResumeLayout(False)
        Me.pnbomb3.PerformLayout()
        Me.pntitle.ResumeLayout(False)
        Me.pntitle.PerformLayout()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btn1.ResumeLayout(False)
        Me.btn1.PerformLayout()
        Me.btn2.ResumeLayout(False)
        Me.btn2.PerformLayout()
        Me.btn3.ResumeLayout(False)
        Me.btn3.PerformLayout()
        Me.btn4.ResumeLayout(False)
        Me.btn4.PerformLayout()
        CType(Me.btnspeaker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnbomb1 As System.Windows.Forms.Panel
    Friend WithEvents lblbomb1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnbomb2 As System.Windows.Forms.Panel
    Friend WithEvents lblbomb2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnbomb3 As System.Windows.Forms.Panel
    Friend WithEvents lblbomb3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pntitle As System.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblbest As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblwrong As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblcorrect As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnclose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lbl4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Clock1 As AnalogClock.Clock
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse4 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse5 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents tbquestion As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btn4 As System.Windows.Forms.Panel
    Friend WithEvents btn3 As System.Windows.Forms.Panel
    Friend WithEvents btn2 As System.Windows.Forms.Panel
    Friend WithEvents btn1 As System.Windows.Forms.Panel
    Friend WithEvents TimerBomb3 As System.Windows.Forms.Timer
    Friend WithEvents TimerBomb2 As System.Windows.Forms.Timer
    Friend WithEvents TimerBomb1 As System.Windows.Forms.Timer
    Friend WithEvents tmosaic As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents tVertSlide As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents pnquestion As AnalogClock.Clock
    Friend WithEvents BunifuElipse6 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnspeaker As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnmute As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents trotate As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuTransition2 As BunifuAnimatorNS.BunifuTransition
End Class
