<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse4 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblbest = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.tbquestion = New System.Windows.Forms.TextBox()
        Me.btnclose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblcorrect = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblwrong = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pntitle = New System.Windows.Forms.Panel()
        Me.lblbomb3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnbomb3 = New System.Windows.Forms.Panel()
        Me.lblbomb2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnbomb2 = New System.Windows.Forms.Panel()
        Me.lblbomb1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnbomb1 = New System.Windows.Forms.Panel()
        CType(Me.btn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pntitle.SuspendLayout()
        Me.pnbomb3.SuspendLayout()
        Me.pnbomb2.SuspendLayout()
        Me.pnbomb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me.btn1
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me.btn2
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 5
        Me.BunifuElipse3.TargetControl = Me.btn3
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 5
        Me.BunifuElipse4.TargetControl = Me.btn4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(346, 302)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(223, 223)
        Me.Panel1.TabIndex = 38
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn1.Image = CType(resources.GetObject("btn1.Image"), System.Drawing.Image)
        Me.btn1.ImageActive = Nothing
        Me.btn1.Location = New System.Drawing.Point(194, 566)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(108, 63)
        Me.btn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn1.TabIndex = 7
        Me.btn1.TabStop = False
        Me.btn1.Zoom = 5
        '
        'lblbest
        '
        Me.lblbest.AutoSize = True
        Me.lblbest.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblbest.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbest.ForeColor = System.Drawing.Color.White
        Me.lblbest.Location = New System.Drawing.Point(197, 577)
        Me.lblbest.Name = "lblbest"
        Me.lblbest.Size = New System.Drawing.Size(103, 42)
        Me.lblbest.TabIndex = 30
        Me.lblbest.Text = "00:00"
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn2.Image = CType(resources.GetObject("btn2.Image"), System.Drawing.Image)
        Me.btn2.ImageActive = Nothing
        Me.btn2.Location = New System.Drawing.Point(331, 566)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(108, 63)
        Me.btn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn2.TabIndex = 31
        Me.btn2.TabStop = False
        Me.btn2.Zoom = 5
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(334, 577)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(103, 42)
        Me.BunifuCustomLabel1.TabIndex = 32
        Me.BunifuCustomLabel1.Text = "00:00"
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn3.Image = CType(resources.GetObject("btn3.Image"), System.Drawing.Image)
        Me.btn3.ImageActive = Nothing
        Me.btn3.Location = New System.Drawing.Point(467, 566)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(108, 63)
        Me.btn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn3.TabIndex = 33
        Me.btn3.TabStop = False
        Me.btn3.Zoom = 5
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(470, 577)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(103, 42)
        Me.BunifuCustomLabel2.TabIndex = 34
        Me.BunifuCustomLabel2.Text = "00:00"
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn4.Image = CType(resources.GetObject("btn4.Image"), System.Drawing.Image)
        Me.btn4.ImageActive = Nothing
        Me.btn4.Location = New System.Drawing.Point(605, 566)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(108, 63)
        Me.btn4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn4.TabIndex = 35
        Me.btn4.TabStop = False
        Me.btn4.Zoom = 5
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(608, 577)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(103, 42)
        Me.BunifuCustomLabel3.TabIndex = 36
        Me.BunifuCustomLabel3.Text = "00:00"
        '
        'tbquestion
        '
        Me.tbquestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.tbquestion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbquestion.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbquestion.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbquestion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbquestion.HideSelection = False
        Me.tbquestion.Location = New System.Drawing.Point(220, 179)
        Me.tbquestion.Multiline = True
        Me.tbquestion.Name = "tbquestion"
        Me.tbquestion.ReadOnly = True
        Me.tbquestion.Size = New System.Drawing.Size(493, 111)
        Me.tbquestion.TabIndex = 37
        Me.tbquestion.Text = "wewewewrerererrersfaas aa da d"
        Me.tbquestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnclose
        '
        Me.btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageActive = Nothing
        Me.btnclose.Location = New System.Drawing.Point(819, 652)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(72, 72)
        Me.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnclose.TabIndex = 45
        Me.btnclose.TabStop = False
        Me.btnclose.Zoom = 5
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel4.Location = New System.Drawing.Point(33, 635)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(39, 35)
        Me.Panel4.TabIndex = 39
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel2.Location = New System.Drawing.Point(35, 682)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(37, 33)
        Me.Panel2.TabIndex = 41
        '
        'lblcorrect
        '
        Me.lblcorrect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblcorrect.AutoSize = True
        Me.lblcorrect.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorrect.ForeColor = System.Drawing.Color.White
        Me.lblcorrect.Location = New System.Drawing.Point(75, 632)
        Me.lblcorrect.Name = "lblcorrect"
        Me.lblcorrect.Size = New System.Drawing.Size(37, 42)
        Me.lblcorrect.TabIndex = 40
        Me.lblcorrect.Text = "0"
        '
        'lblwrong
        '
        Me.lblwrong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblwrong.AutoSize = True
        Me.lblwrong.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwrong.ForeColor = System.Drawing.Color.White
        Me.lblwrong.Location = New System.Drawing.Point(75, 677)
        Me.lblwrong.Name = "lblwrong"
        Me.lblwrong.Size = New System.Drawing.Size(37, 42)
        Me.lblwrong.TabIndex = 42
        Me.lblwrong.Text = "0"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel3.Location = New System.Drawing.Point(26, 576)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(55, 50)
        Me.Panel3.TabIndex = 43
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(75, 584)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(37, 42)
        Me.BunifuCustomLabel5.TabIndex = 44
        Me.BunifuCustomLabel5.Text = "0"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(242, 15)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(378, 42)
        Me.BunifuCustomLabel4.TabIndex = 29
        Me.BunifuCustomLabel4.Text = "SOLVE THE EQUATION"
        '
        'pntitle
        '
        Me.pntitle.BackColor = System.Drawing.Color.Teal
        Me.pntitle.Controls.Add(Me.BunifuCustomLabel4)
        Me.pntitle.Location = New System.Drawing.Point(33, -4)
        Me.pntitle.Name = "pntitle"
        Me.pntitle.Size = New System.Drawing.Size(855, 66)
        Me.pntitle.TabIndex = 46
        '
        'lblbomb3
        '
        Me.lblbomb3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblbomb3.AutoSize = True
        Me.lblbomb3.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbomb3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblbomb3.Location = New System.Drawing.Point(1, 37)
        Me.lblbomb3.Name = "lblbomb3"
        Me.lblbomb3.Size = New System.Drawing.Size(62, 44)
        Me.lblbomb3.TabIndex = 19
        Me.lblbomb3.Text = "60"
        '
        'pnbomb3
        '
        Me.pnbomb3.BackColor = System.Drawing.Color.Transparent
        Me.pnbomb3.BackgroundImage = CType(resources.GetObject("pnbomb3.BackgroundImage"), System.Drawing.Image)
        Me.pnbomb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnbomb3.Controls.Add(Me.lblbomb3)
        Me.pnbomb3.Location = New System.Drawing.Point(201, 74)
        Me.pnbomb3.Name = "pnbomb3"
        Me.pnbomb3.Size = New System.Drawing.Size(77, 88)
        Me.pnbomb3.TabIndex = 47
        Me.pnbomb3.Visible = False
        '
        'lblbomb2
        '
        Me.lblbomb2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblbomb2.AutoSize = True
        Me.lblbomb2.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbomb2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblbomb2.Location = New System.Drawing.Point(1, 37)
        Me.lblbomb2.Name = "lblbomb2"
        Me.lblbomb2.Size = New System.Drawing.Size(62, 44)
        Me.lblbomb2.TabIndex = 19
        Me.lblbomb2.Text = "60"
        '
        'pnbomb2
        '
        Me.pnbomb2.BackColor = System.Drawing.Color.Transparent
        Me.pnbomb2.BackgroundImage = CType(resources.GetObject("pnbomb2.BackgroundImage"), System.Drawing.Image)
        Me.pnbomb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnbomb2.Controls.Add(Me.lblbomb2)
        Me.pnbomb2.Location = New System.Drawing.Point(118, 74)
        Me.pnbomb2.Name = "pnbomb2"
        Me.pnbomb2.Size = New System.Drawing.Size(77, 88)
        Me.pnbomb2.TabIndex = 48
        Me.pnbomb2.Visible = False
        '
        'lblbomb1
        '
        Me.lblbomb1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblbomb1.AutoSize = True
        Me.lblbomb1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbomb1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblbomb1.Location = New System.Drawing.Point(1, 37)
        Me.lblbomb1.Name = "lblbomb1"
        Me.lblbomb1.Size = New System.Drawing.Size(62, 44)
        Me.lblbomb1.TabIndex = 19
        Me.lblbomb1.Text = "60"
        '
        'pnbomb1
        '
        Me.pnbomb1.BackColor = System.Drawing.Color.Transparent
        Me.pnbomb1.BackgroundImage = CType(resources.GetObject("pnbomb1.BackgroundImage"), System.Drawing.Image)
        Me.pnbomb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnbomb1.Controls.Add(Me.lblbomb1)
        Me.pnbomb1.Location = New System.Drawing.Point(35, 74)
        Me.pnbomb1.Name = "pnbomb1"
        Me.pnbomb1.Size = New System.Drawing.Size(77, 88)
        Me.pnbomb1.TabIndex = 49
        Me.pnbomb1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(917, 721)
        Me.Controls.Add(Me.pnbomb1)
        Me.Controls.Add(Me.pnbomb2)
        Me.Controls.Add(Me.pnbomb3)
        Me.Controls.Add(Me.pntitle)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblwrong)
        Me.Controls.Add(Me.lblcorrect)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tbquestion)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.lblbest)
        Me.Controls.Add(Me.btn1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.btn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pntitle.ResumeLayout(False)
        Me.pntitle.PerformLayout()
        Me.pnbomb3.ResumeLayout(False)
        Me.pnbomb3.PerformLayout()
        Me.pnbomb2.ResumeLayout(False)
        Me.pnbomb2.PerformLayout()
        Me.pnbomb1.ResumeLayout(False)
        Me.pnbomb1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse4 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblbest As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tbquestion As System.Windows.Forms.TextBox
    Friend WithEvents btnclose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblcorrect As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblwrong As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pntitle As System.Windows.Forms.Panel
    Friend WithEvents lblbomb3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnbomb3 As System.Windows.Forms.Panel
    Friend WithEvents lblbomb2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnbomb2 As System.Windows.Forms.Panel
    Friend WithEvents lblbomb1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnbomb1 As System.Windows.Forms.Panel
End Class
