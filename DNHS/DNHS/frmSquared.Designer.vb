<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSquared
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSquared))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation4 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.pncontainer = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.lblbest = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.lblwrong = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblcorrect = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.btnclose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.pnbomb1 = New System.Windows.Forms.Panel()
        Me.lblbomb1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnbomb2 = New System.Windows.Forms.Panel()
        Me.lblbomb2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnbomb3 = New System.Windows.Forms.Panel()
        Me.lblbomb3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TimerBomb3 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerBomb2 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerBomb1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmosaic = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.pntitle = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnspeaker = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnmute = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lbl1 = New System.Windows.Forms.Button()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tVertSlide = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse4 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse5 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse6 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse7 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse8 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse9 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse10 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse11 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.trotate = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.pncontainer.SuspendLayout()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnbomb1.SuspendLayout()
        Me.pnbomb2.SuspendLayout()
        Me.pnbomb3.SuspendLayout()
        Me.pntitle.SuspendLayout()
        CType(Me.btnspeaker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pncontainer
        '
        Me.pncontainer.BackColor = System.Drawing.Color.Transparent
        Me.pncontainer.BackgroundImage = CType(resources.GetObject("pncontainer.BackgroundImage"), System.Drawing.Image)
        Me.pncontainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pncontainer.Controls.Add(Me.Panel1)
        Me.tVertSlide.SetDecoration(Me.pncontainer, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.pncontainer, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pncontainer, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pncontainer, BunifuAnimatorNS.DecorationType.None)
        Me.pncontainer.Location = New System.Drawing.Point(257, 213)
        Me.pncontainer.Name = "pncontainer"
        Me.pncontainer.Size = New System.Drawing.Size(379, 328)
        Me.pncontainer.TabIndex = 37
        Me.pncontainer.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.tVertSlide.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(27, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 276)
        Me.Panel1.TabIndex = 0
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.btn9, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btn9, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn9, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btn9, BunifuAnimatorNS.DecorationType.None)
        Me.btn9.FlatAppearance.BorderSize = 0
        Me.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn9.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.ForeColor = System.Drawing.Color.White
        Me.btn9.Location = New System.Drawing.Point(501, 424)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(99, 82)
        Me.btn9.TabIndex = 58
        Me.btn9.Text = "0"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.btn8, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btn8, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn8, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btn8, BunifuAnimatorNS.DecorationType.None)
        Me.btn8.FlatAppearance.BorderSize = 0
        Me.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn8.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.ForeColor = System.Drawing.Color.White
        Me.btn8.Location = New System.Drawing.Point(396, 424)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(99, 82)
        Me.btn8.TabIndex = 57
        Me.btn8.Text = "0"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.btn7, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btn7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn7, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btn7, BunifuAnimatorNS.DecorationType.None)
        Me.btn7.FlatAppearance.BorderSize = 0
        Me.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn7.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.ForeColor = System.Drawing.Color.White
        Me.btn7.Location = New System.Drawing.Point(291, 424)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(99, 82)
        Me.btn7.TabIndex = 56
        Me.btn7.Text = "0"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.btn6, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btn6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn6, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btn6, BunifuAnimatorNS.DecorationType.None)
        Me.btn6.FlatAppearance.BorderSize = 0
        Me.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn6.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.ForeColor = System.Drawing.Color.White
        Me.btn6.Location = New System.Drawing.Point(501, 336)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(99, 82)
        Me.btn6.TabIndex = 55
        Me.btn6.Text = "0"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.btn5, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btn5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn5, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btn5, BunifuAnimatorNS.DecorationType.None)
        Me.btn5.FlatAppearance.BorderSize = 0
        Me.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.ForeColor = System.Drawing.Color.White
        Me.btn5.Location = New System.Drawing.Point(396, 337)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(99, 82)
        Me.btn5.TabIndex = 54
        Me.btn5.Text = "0"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.btn4, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btn4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn4, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btn4, BunifuAnimatorNS.DecorationType.None)
        Me.btn4.FlatAppearance.BorderSize = 0
        Me.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.ForeColor = System.Drawing.Color.White
        Me.btn4.Location = New System.Drawing.Point(291, 337)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(99, 82)
        Me.btn4.TabIndex = 53
        Me.btn4.Text = "0"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.btn3, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btn3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn3, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btn3, BunifuAnimatorNS.DecorationType.None)
        Me.btn3.FlatAppearance.BorderSize = 0
        Me.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.Color.White
        Me.btn3.Location = New System.Drawing.Point(501, 249)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(99, 82)
        Me.btn3.TabIndex = 52
        Me.btn3.Text = "0"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.btn2, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btn2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn2, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btn2, BunifuAnimatorNS.DecorationType.None)
        Me.btn2.FlatAppearance.BorderSize = 0
        Me.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.White
        Me.btn2.Location = New System.Drawing.Point(396, 249)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(99, 82)
        Me.btn2.TabIndex = 51
        Me.btn2.Text = "0"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.btn1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.btn1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.btn1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btn1, BunifuAnimatorNS.DecorationType.None)
        Me.btn1.FlatAppearance.BorderSize = 0
        Me.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.White
        Me.btn1.Location = New System.Drawing.Point(291, 249)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(99, 82)
        Me.btn1.TabIndex = 50
        Me.btn1.Text = "0"
        Me.btn1.UseVisualStyleBackColor = False
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
        Me.lblbest.Location = New System.Drawing.Point(61, 592)
        Me.lblbest.Name = "lblbest"
        Me.lblbest.Size = New System.Drawing.Size(37, 42)
        Me.lblbest.TabIndex = 43
        Me.lblbest.Text = "0"
        '
        'Panel11
        '
        Me.Panel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.BackgroundImage = CType(resources.GetObject("Panel11.BackgroundImage"), System.Drawing.Image)
        Me.Panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel11.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tVertSlide.SetDecoration(Me.Panel11, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.Panel11, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel11, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.Panel11, BunifuAnimatorNS.DecorationType.None)
        Me.Panel11.Location = New System.Drawing.Point(12, 584)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(55, 50)
        Me.Panel11.TabIndex = 42
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
        Me.lblwrong.Location = New System.Drawing.Point(60, 681)
        Me.lblwrong.Name = "lblwrong"
        Me.lblwrong.Size = New System.Drawing.Size(37, 42)
        Me.lblwrong.TabIndex = 41
        Me.lblwrong.Text = "0"
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
        Me.lblcorrect.Location = New System.Drawing.Point(61, 637)
        Me.lblcorrect.Name = "lblcorrect"
        Me.lblcorrect.Size = New System.Drawing.Size(37, 42)
        Me.lblcorrect.TabIndex = 38
        Me.lblcorrect.Text = "0"
        '
        'Panel12
        '
        Me.Panel12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel12.BackColor = System.Drawing.Color.Transparent
        Me.Panel12.BackgroundImage = CType(resources.GetObject("Panel12.BackgroundImage"), System.Drawing.Image)
        Me.Panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel12.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tVertSlide.SetDecoration(Me.Panel12, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.Panel12, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel12, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.Panel12, BunifuAnimatorNS.DecorationType.None)
        Me.Panel12.Location = New System.Drawing.Point(20, 684)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(37, 33)
        Me.Panel12.TabIndex = 40
        '
        'Panel13
        '
        Me.Panel13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel13.BackColor = System.Drawing.Color.Transparent
        Me.Panel13.BackgroundImage = CType(resources.GetObject("Panel13.BackgroundImage"), System.Drawing.Image)
        Me.Panel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel13.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tVertSlide.SetDecoration(Me.Panel13, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.Panel13, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel13, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.Panel13, BunifuAnimatorNS.DecorationType.None)
        Me.Panel13.Location = New System.Drawing.Point(19, 640)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(39, 35)
        Me.Panel13.TabIndex = 39
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
        Me.btnclose.Location = New System.Drawing.Point(5, 12)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(45, 45)
        Me.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnclose.TabIndex = 44
        Me.btnclose.TabStop = False
        Me.btnclose.Zoom = 10
        '
        'ListBox1
        '
        Me.trotate.SetDecoration(Me.ListBox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.ListBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.ListBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.ListBox1, BunifuAnimatorNS.DecorationType.None)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(909, 131)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 225)
        Me.ListBox1.TabIndex = 45
        Me.ListBox1.Visible = False
        '
        'ListBox2
        '
        Me.trotate.SetDecoration(Me.ListBox2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.ListBox2, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.ListBox2, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.ListBox2, BunifuAnimatorNS.DecorationType.None)
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(909, 362)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 225)
        Me.ListBox2.TabIndex = 46
        Me.ListBox2.Visible = False
        '
        'ListBox4
        '
        Me.trotate.SetDecoration(Me.ListBox4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.ListBox4, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.ListBox4, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.ListBox4, BunifuAnimatorNS.DecorationType.None)
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(1013, 131)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(120, 225)
        Me.ListBox4.TabIndex = 48
        Me.ListBox4.Visible = False
        '
        'pnbomb1
        '
        Me.pnbomb1.BackColor = System.Drawing.Color.Transparent
        Me.pnbomb1.BackgroundImage = CType(resources.GetObject("pnbomb1.BackgroundImage"), System.Drawing.Image)
        Me.pnbomb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnbomb1.Controls.Add(Me.lblbomb1)
        Me.tVertSlide.SetDecoration(Me.pnbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.pnbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pnbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pnbomb1, BunifuAnimatorNS.DecorationType.None)
        Me.pnbomb1.Location = New System.Drawing.Point(21, 259)
        Me.pnbomb1.Name = "pnbomb1"
        Me.pnbomb1.Size = New System.Drawing.Size(77, 88)
        Me.pnbomb1.TabIndex = 52
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
        'pnbomb2
        '
        Me.pnbomb2.BackColor = System.Drawing.Color.Transparent
        Me.pnbomb2.BackgroundImage = CType(resources.GetObject("pnbomb2.BackgroundImage"), System.Drawing.Image)
        Me.pnbomb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnbomb2.Controls.Add(Me.lblbomb2)
        Me.tVertSlide.SetDecoration(Me.pnbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.pnbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pnbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pnbomb2, BunifuAnimatorNS.DecorationType.None)
        Me.pnbomb2.Location = New System.Drawing.Point(21, 165)
        Me.pnbomb2.Name = "pnbomb2"
        Me.pnbomb2.Size = New System.Drawing.Size(77, 88)
        Me.pnbomb2.TabIndex = 51
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
        'pnbomb3
        '
        Me.pnbomb3.BackColor = System.Drawing.Color.Transparent
        Me.pnbomb3.BackgroundImage = CType(resources.GetObject("pnbomb3.BackgroundImage"), System.Drawing.Image)
        Me.pnbomb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnbomb3.Controls.Add(Me.lblbomb3)
        Me.tVertSlide.SetDecoration(Me.pnbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.pnbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pnbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pnbomb3, BunifuAnimatorNS.DecorationType.None)
        Me.pnbomb3.Location = New System.Drawing.Point(23, 71)
        Me.pnbomb3.Name = "pnbomb3"
        Me.pnbomb3.Size = New System.Drawing.Size(77, 88)
        Me.pnbomb3.TabIndex = 50
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
        Me.tmosaic.AnimationType = BunifuAnimatorNS.AnimationType.Scale
        Me.tmosaic.Cursor = Nothing
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
        Me.tmosaic.DefaultAnimation = Animation2
        Me.tmosaic.Interval = 15
        '
        'pntitle
        '
        Me.pntitle.BackColor = System.Drawing.Color.Teal
        Me.pntitle.Controls.Add(Me.BunifuCustomLabel1)
        Me.pntitle.Controls.Add(Me.btnclose)
        Me.tVertSlide.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.pntitle.Location = New System.Drawing.Point(21, -5)
        Me.pntitle.Name = "pntitle"
        Me.pntitle.Size = New System.Drawing.Size(855, 66)
        Me.pntitle.TabIndex = 53
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
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(305, 15)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(265, 42)
        Me.BunifuCustomLabel1.TabIndex = 29
        Me.BunifuCustomLabel1.Text = "DRAG SQUARE"
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
        Me.btnspeaker.Location = New System.Drawing.Point(823, 670)
        Me.btnspeaker.Name = "btnspeaker"
        Me.btnspeaker.Size = New System.Drawing.Size(61, 52)
        Me.btnspeaker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnspeaker.TabIndex = 54
        Me.btnspeaker.TabStop = False
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
        Me.btnmute.Location = New System.Drawing.Point(823, 670)
        Me.btnmute.Name = "btnmute"
        Me.btnmute.Size = New System.Drawing.Size(61, 52)
        Me.btnmute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmute.TabIndex = 55
        Me.btnmute.TabStop = False
        Me.btnmute.Zoom = 10
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Teal
        Me.lbl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmosaic.SetDecoration(Me.lbl1, BunifuAnimatorNS.DecorationType.None)
        Me.tVertSlide.SetDecoration(Me.lbl1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lbl1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lbl1, BunifuAnimatorNS.DecorationType.None)
        Me.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(281, 244)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(99, 82)
        Me.lbl1.TabIndex = 50
        Me.lbl1.Text = "0"
        Me.lbl1.UseVisualStyleBackColor = False
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
        Me.BunifuImageButton1.Location = New System.Drawing.Point(757, 670)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(61, 52)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 59
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'tVertSlide
        '
        Me.tVertSlide.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.tVertSlide.Cursor = Nothing
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
        Me.tVertSlide.DefaultAnimation = Animation1
        Me.tVertSlide.Interval = 15
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 10
        Me.BunifuElipse2.TargetControl = Me.pntitle
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 7
        Me.BunifuElipse1.TargetControl = Me
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
        'BunifuElipse7
        '
        Me.BunifuElipse7.ElipseRadius = 7
        Me.BunifuElipse7.TargetControl = Me.btn5
        '
        'BunifuElipse8
        '
        Me.BunifuElipse8.ElipseRadius = 7
        Me.BunifuElipse8.TargetControl = Me.btn6
        '
        'BunifuElipse9
        '
        Me.BunifuElipse9.ElipseRadius = 7
        Me.BunifuElipse9.TargetControl = Me.btn7
        '
        'BunifuElipse10
        '
        Me.BunifuElipse10.ElipseRadius = 7
        Me.BunifuElipse10.TargetControl = Me.btn8
        '
        'BunifuElipse11
        '
        Me.BunifuElipse11.ElipseRadius = 7
        Me.BunifuElipse11.TargetControl = Me.btn9
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
        'frmSquared
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(898, 736)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btnspeaker)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btnmute)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.pntitle)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.pnbomb1)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.pnbomb2)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.pnbomb3)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblbest)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.lblwrong)
        Me.Controls.Add(Me.lblcorrect)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.pncontainer)
        Me.tVertSlide.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tmosaic.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSquared"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSquared"
        Me.pncontainer.ResumeLayout(False)
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnbomb1.ResumeLayout(False)
        Me.pnbomb1.PerformLayout()
        Me.pnbomb2.ResumeLayout(False)
        Me.pnbomb2.PerformLayout()
        Me.pnbomb3.ResumeLayout(False)
        Me.pnbomb3.PerformLayout()
        Me.pntitle.ResumeLayout(False)
        Me.pntitle.PerformLayout()
        CType(Me.btnspeaker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pncontainer As System.Windows.Forms.Panel
    Friend WithEvents lblbest As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents lblwrong As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblcorrect As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents btnclose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents pnbomb1 As System.Windows.Forms.Panel
    Friend WithEvents lblbomb1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnbomb2 As System.Windows.Forms.Panel
    Friend WithEvents lblbomb2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnbomb3 As System.Windows.Forms.Panel
    Friend WithEvents lblbomb3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TimerBomb3 As System.Windows.Forms.Timer
    Friend WithEvents TimerBomb2 As System.Windows.Forms.Timer
    Friend WithEvents TimerBomb1 As System.Windows.Forms.Timer
    Friend WithEvents tmosaic As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents tVertSlide As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents pntitle As System.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnspeaker As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnmute As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lbl1 As System.Windows.Forms.Button
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse4 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse5 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse6 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse7 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse8 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse9 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse10 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse11 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents trotate As BunifuAnimatorNS.BunifuTransition

End Class
