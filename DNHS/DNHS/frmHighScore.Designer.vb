<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighScore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHighScore))
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNmeasure = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblSmeasure = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnmeasure = New System.Windows.Forms.Panel()
        Me.pnequation = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblSequation = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblNequation = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pntemperature = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblNTemperature = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblStemperature = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnsquare = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblNsquare = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblSsquare = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnequivalent = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.lblNequivalent = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblSequivalent = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel14 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnfraction = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.lblNfraction = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblSfraction = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel17 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pntitle = New System.Windows.Forms.Panel()
        Me.btnclose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.tscale = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.trotate = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel1.SuspendLayout()
        Me.pnmeasure.SuspendLayout()
        Me.pnequation.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pntemperature.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.pnsquare.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.pnequivalent.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.pnfraction.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.pntitle.SuspendLayout()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.lblNmeasure)
        Me.Panel1.Controls.Add(Me.lblSmeasure)
        Me.tscale.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(34, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 189)
        Me.Panel1.TabIndex = 0
        '
        'lblNmeasure
        '
        Me.lblNmeasure.AutoSize = True
        Me.lblNmeasure.BackColor = System.Drawing.Color.Transparent
        Me.tscale.SetDecoration(Me.lblNmeasure, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblNmeasure, BunifuAnimatorNS.DecorationType.None)
        Me.lblNmeasure.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNmeasure.ForeColor = System.Drawing.Color.White
        Me.lblNmeasure.Location = New System.Drawing.Point(-5, 114)
        Me.lblNmeasure.Name = "lblNmeasure"
        Me.lblNmeasure.Size = New System.Drawing.Size(36, 33)
        Me.lblNmeasure.TabIndex = 29
        Me.lblNmeasure.Text = "..."
        '
        'lblSmeasure
        '
        Me.lblSmeasure.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSmeasure.AutoSize = True
        Me.lblSmeasure.BackColor = System.Drawing.Color.Transparent
        Me.tscale.SetDecoration(Me.lblSmeasure, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblSmeasure, BunifuAnimatorNS.DecorationType.None)
        Me.lblSmeasure.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSmeasure.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblSmeasure.Location = New System.Drawing.Point(53, 152)
        Me.lblSmeasure.Name = "lblSmeasure"
        Me.lblSmeasure.Size = New System.Drawing.Size(45, 33)
        Me.lblSmeasure.TabIndex = 31
        Me.lblSmeasure.Text = "00"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.tscale.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.DarkGray
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(12, 202)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(203, 33)
        Me.BunifuCustomLabel1.TabIndex = 30
        Me.BunifuCustomLabel1.Text = "MEASUREMENT"
        '
        'pnmeasure
        '
        Me.pnmeasure.Controls.Add(Me.Panel1)
        Me.pnmeasure.Controls.Add(Me.BunifuCustomLabel1)
        Me.tscale.SetDecoration(Me.pnmeasure, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pnmeasure, BunifuAnimatorNS.DecorationType.None)
        Me.pnmeasure.Location = New System.Drawing.Point(98, 102)
        Me.pnmeasure.Name = "pnmeasure"
        Me.pnmeasure.Size = New System.Drawing.Size(218, 247)
        Me.pnmeasure.TabIndex = 31
        Me.pnmeasure.Visible = False
        '
        'pnequation
        '
        Me.pnequation.Controls.Add(Me.Panel4)
        Me.pnequation.Controls.Add(Me.BunifuCustomLabel5)
        Me.tscale.SetDecoration(Me.pnequation, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pnequation, BunifuAnimatorNS.DecorationType.None)
        Me.pnequation.Location = New System.Drawing.Point(352, 102)
        Me.pnequation.Name = "pnequation"
        Me.pnequation.Size = New System.Drawing.Size(218, 247)
        Me.pnequation.TabIndex = 32
        Me.pnequation.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.lblSequation)
        Me.Panel4.Controls.Add(Me.lblNequation)
        Me.tscale.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.Panel4.Location = New System.Drawing.Point(34, 15)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(150, 189)
        Me.Panel4.TabIndex = 0
        '
        'lblSequation
        '
        Me.lblSequation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSequation.AutoSize = True
        Me.lblSequation.BackColor = System.Drawing.Color.Transparent
        Me.tscale.SetDecoration(Me.lblSequation, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblSequation, BunifuAnimatorNS.DecorationType.None)
        Me.lblSequation.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSequation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblSequation.Location = New System.Drawing.Point(52, 152)
        Me.lblSequation.Name = "lblSequation"
        Me.lblSequation.Size = New System.Drawing.Size(45, 33)
        Me.lblSequation.TabIndex = 31
        Me.lblSequation.Text = "00"
        '
        'lblNequation
        '
        Me.lblNequation.AutoSize = True
        Me.lblNequation.BackColor = System.Drawing.Color.Transparent
        Me.tscale.SetDecoration(Me.lblNequation, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblNequation, BunifuAnimatorNS.DecorationType.None)
        Me.lblNequation.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNequation.ForeColor = System.Drawing.Color.White
        Me.lblNequation.Location = New System.Drawing.Point(-2, 115)
        Me.lblNequation.Name = "lblNequation"
        Me.lblNequation.Size = New System.Drawing.Size(36, 33)
        Me.lblNequation.TabIndex = 29
        Me.lblNequation.Text = "..."
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.tscale.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.DarkGray
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(35, 202)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(149, 33)
        Me.BunifuCustomLabel5.TabIndex = 30
        Me.BunifuCustomLabel5.Text = "EQUATION"
        '
        'pntemperature
        '
        Me.pntemperature.Controls.Add(Me.Panel6)
        Me.pntemperature.Controls.Add(Me.BunifuCustomLabel8)
        Me.tscale.SetDecoration(Me.pntemperature, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pntemperature, BunifuAnimatorNS.DecorationType.None)
        Me.pntemperature.Location = New System.Drawing.Point(610, 102)
        Me.pntemperature.Name = "pntemperature"
        Me.pntemperature.Size = New System.Drawing.Size(218, 247)
        Me.pntemperature.TabIndex = 32
        Me.pntemperature.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), System.Drawing.Image)
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Controls.Add(Me.lblNTemperature)
        Me.Panel6.Controls.Add(Me.lblStemperature)
        Me.tscale.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.Panel6.Location = New System.Drawing.Point(34, 15)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(150, 189)
        Me.Panel6.TabIndex = 0
        '
        'lblNTemperature
        '
        Me.lblNTemperature.AutoSize = True
        Me.lblNTemperature.BackColor = System.Drawing.Color.Transparent
        Me.tscale.SetDecoration(Me.lblNTemperature, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblNTemperature, BunifuAnimatorNS.DecorationType.None)
        Me.lblNTemperature.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNTemperature.ForeColor = System.Drawing.Color.White
        Me.lblNTemperature.Location = New System.Drawing.Point(0, 115)
        Me.lblNTemperature.Name = "lblNTemperature"
        Me.lblNTemperature.Size = New System.Drawing.Size(36, 33)
        Me.lblNTemperature.TabIndex = 29
        Me.lblNTemperature.Text = "..."
        '
        'lblStemperature
        '
        Me.lblStemperature.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStemperature.AutoSize = True
        Me.lblStemperature.BackColor = System.Drawing.Color.Transparent
        Me.tscale.SetDecoration(Me.lblStemperature, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblStemperature, BunifuAnimatorNS.DecorationType.None)
        Me.lblStemperature.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStemperature.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblStemperature.Location = New System.Drawing.Point(52, 152)
        Me.lblStemperature.Name = "lblStemperature"
        Me.lblStemperature.Size = New System.Drawing.Size(45, 33)
        Me.lblStemperature.TabIndex = 31
        Me.lblStemperature.Text = "00"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.tscale.SetDecoration(Me.BunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.BunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.DarkGray
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(15, 203)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(188, 33)
        Me.BunifuCustomLabel8.TabIndex = 30
        Me.BunifuCustomLabel8.Text = "TEMPERATURE"
        '
        'pnsquare
        '
        Me.pnsquare.Controls.Add(Me.Panel8)
        Me.pnsquare.Controls.Add(Me.BunifuCustomLabel11)
        Me.tscale.SetDecoration(Me.pnsquare, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pnsquare, BunifuAnimatorNS.DecorationType.None)
        Me.pnsquare.Location = New System.Drawing.Point(218, 390)
        Me.pnsquare.Name = "pnsquare"
        Me.pnsquare.Size = New System.Drawing.Size(218, 247)
        Me.pnsquare.TabIndex = 33
        Me.pnsquare.Visible = False
        '
        'Panel8
        '
        Me.Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), System.Drawing.Image)
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel8.Controls.Add(Me.lblNsquare)
        Me.Panel8.Controls.Add(Me.lblSsquare)
        Me.tscale.SetDecoration(Me.Panel8, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.Panel8, BunifuAnimatorNS.DecorationType.None)
        Me.Panel8.Location = New System.Drawing.Point(34, 15)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(150, 189)
        Me.Panel8.TabIndex = 0
        '
        'lblNsquare
        '
        Me.lblNsquare.AutoSize = True
        Me.lblNsquare.BackColor = System.Drawing.Color.Transparent
        Me.tscale.SetDecoration(Me.lblNsquare, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblNsquare, BunifuAnimatorNS.DecorationType.None)
        Me.lblNsquare.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNsquare.ForeColor = System.Drawing.Color.White
        Me.lblNsquare.Location = New System.Drawing.Point(-3, 114)
        Me.lblNsquare.Name = "lblNsquare"
        Me.lblNsquare.Size = New System.Drawing.Size(36, 33)
        Me.lblNsquare.TabIndex = 29
        Me.lblNsquare.Text = "..."
        '
        'lblSsquare
        '
        Me.lblSsquare.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSsquare.AutoSize = True
        Me.lblSsquare.BackColor = System.Drawing.Color.Transparent
        Me.tscale.SetDecoration(Me.lblSsquare, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblSsquare, BunifuAnimatorNS.DecorationType.None)
        Me.lblSsquare.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSsquare.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblSsquare.Location = New System.Drawing.Point(48, 152)
        Me.lblSsquare.Name = "lblSsquare"
        Me.lblSsquare.Size = New System.Drawing.Size(45, 33)
        Me.lblSsquare.TabIndex = 31
        Me.lblSsquare.Text = "00"
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.tscale.SetDecoration(Me.BunifuCustomLabel11, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.BunifuCustomLabel11, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.Color.DarkGray
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(15, 202)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(184, 33)
        Me.BunifuCustomLabel11.TabIndex = 30
        Me.BunifuCustomLabel11.Text = "FIND SQUARE"
        '
        'pnequivalent
        '
        Me.pnequivalent.Controls.Add(Me.Panel10)
        Me.pnequivalent.Controls.Add(Me.BunifuCustomLabel14)
        Me.tscale.SetDecoration(Me.pnequivalent, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pnequivalent, BunifuAnimatorNS.DecorationType.None)
        Me.pnequivalent.Location = New System.Drawing.Point(116, 680)
        Me.pnequivalent.Name = "pnequivalent"
        Me.pnequivalent.Size = New System.Drawing.Size(218, 247)
        Me.pnequivalent.TabIndex = 34
        Me.pnequivalent.Visible = False
        '
        'Panel10
        '
        Me.Panel10.BackgroundImage = CType(resources.GetObject("Panel10.BackgroundImage"), System.Drawing.Image)
        Me.Panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel10.Controls.Add(Me.lblNequivalent)
        Me.Panel10.Controls.Add(Me.lblSequivalent)
        Me.tscale.SetDecoration(Me.Panel10, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.Panel10, BunifuAnimatorNS.DecorationType.None)
        Me.Panel10.Location = New System.Drawing.Point(34, 15)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(150, 189)
        Me.Panel10.TabIndex = 0
        '
        'lblNequivalent
        '
        Me.lblNequivalent.AutoSize = True
        Me.lblNequivalent.BackColor = System.Drawing.Color.Transparent
        Me.tscale.SetDecoration(Me.lblNequivalent, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblNequivalent, BunifuAnimatorNS.DecorationType.None)
        Me.lblNequivalent.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNequivalent.ForeColor = System.Drawing.Color.White
        Me.lblNequivalent.Location = New System.Drawing.Point(56, 115)
        Me.lblNequivalent.Name = "lblNequivalent"
        Me.lblNequivalent.Size = New System.Drawing.Size(0, 33)
        Me.lblNequivalent.TabIndex = 29
        '
        'lblSequivalent
        '
        Me.lblSequivalent.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSequivalent.AutoSize = True
        Me.lblSequivalent.BackColor = System.Drawing.Color.Transparent
        Me.tscale.SetDecoration(Me.lblSequivalent, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblSequivalent, BunifuAnimatorNS.DecorationType.None)
        Me.lblSequivalent.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSequivalent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblSequivalent.Location = New System.Drawing.Point(52, 152)
        Me.lblSequivalent.Name = "lblSequivalent"
        Me.lblSequivalent.Size = New System.Drawing.Size(45, 33)
        Me.lblSequivalent.TabIndex = 31
        Me.lblSequivalent.Text = "00"
        '
        'BunifuCustomLabel14
        '
        Me.BunifuCustomLabel14.AutoSize = True
        Me.tscale.SetDecoration(Me.BunifuCustomLabel14, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.BunifuCustomLabel14, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel14.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel14.ForeColor = System.Drawing.Color.DarkGray
        Me.BunifuCustomLabel14.Location = New System.Drawing.Point(23, 202)
        Me.BunifuCustomLabel14.Name = "BunifuCustomLabel14"
        Me.BunifuCustomLabel14.Size = New System.Drawing.Size(171, 33)
        Me.BunifuCustomLabel14.TabIndex = 30
        Me.BunifuCustomLabel14.Text = "EQUIVALENT"
        '
        'pnfraction
        '
        Me.pnfraction.Controls.Add(Me.Panel12)
        Me.pnfraction.Controls.Add(Me.BunifuCustomLabel17)
        Me.tscale.SetDecoration(Me.pnfraction, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pnfraction, BunifuAnimatorNS.DecorationType.None)
        Me.pnfraction.Location = New System.Drawing.Point(485, 391)
        Me.pnfraction.Name = "pnfraction"
        Me.pnfraction.Size = New System.Drawing.Size(218, 247)
        Me.pnfraction.TabIndex = 35
        Me.pnfraction.Visible = False
        '
        'Panel12
        '
        Me.Panel12.BackgroundImage = CType(resources.GetObject("Panel12.BackgroundImage"), System.Drawing.Image)
        Me.Panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel12.Controls.Add(Me.lblNfraction)
        Me.Panel12.Controls.Add(Me.lblSfraction)
        Me.tscale.SetDecoration(Me.Panel12, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.Panel12, BunifuAnimatorNS.DecorationType.None)
        Me.Panel12.Location = New System.Drawing.Point(34, 15)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(150, 189)
        Me.Panel12.TabIndex = 0
        '
        'lblNfraction
        '
        Me.lblNfraction.AutoSize = True
        Me.lblNfraction.BackColor = System.Drawing.Color.Transparent
        Me.tscale.SetDecoration(Me.lblNfraction, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblNfraction, BunifuAnimatorNS.DecorationType.None)
        Me.lblNfraction.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNfraction.ForeColor = System.Drawing.Color.White
        Me.lblNfraction.Location = New System.Drawing.Point(-2, 115)
        Me.lblNfraction.Name = "lblNfraction"
        Me.lblNfraction.Size = New System.Drawing.Size(36, 33)
        Me.lblNfraction.TabIndex = 29
        Me.lblNfraction.Text = "..."
        '
        'lblSfraction
        '
        Me.lblSfraction.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSfraction.AutoSize = True
        Me.lblSfraction.BackColor = System.Drawing.Color.Transparent
        Me.tscale.SetDecoration(Me.lblSfraction, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.lblSfraction, BunifuAnimatorNS.DecorationType.None)
        Me.lblSfraction.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSfraction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblSfraction.Location = New System.Drawing.Point(52, 152)
        Me.lblSfraction.Name = "lblSfraction"
        Me.lblSfraction.Size = New System.Drawing.Size(45, 33)
        Me.lblSfraction.TabIndex = 31
        Me.lblSfraction.Text = "00"
        '
        'BunifuCustomLabel17
        '
        Me.BunifuCustomLabel17.AutoSize = True
        Me.tscale.SetDecoration(Me.BunifuCustomLabel17, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.BunifuCustomLabel17, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel17.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel17.ForeColor = System.Drawing.Color.DarkGray
        Me.BunifuCustomLabel17.Location = New System.Drawing.Point(70, 202)
        Me.BunifuCustomLabel17.Name = "BunifuCustomLabel17"
        Me.BunifuCustomLabel17.Size = New System.Drawing.Size(71, 33)
        Me.BunifuCustomLabel17.TabIndex = 30
        Me.BunifuCustomLabel17.Text = "TIME"
        '
        'pntitle
        '
        Me.pntitle.BackColor = System.Drawing.Color.Teal
        Me.pntitle.Controls.Add(Me.btnclose)
        Me.pntitle.Controls.Add(Me.BunifuCustomLabel2)
        Me.tscale.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.pntitle, BunifuAnimatorNS.DecorationType.None)
        Me.pntitle.Location = New System.Drawing.Point(22, -6)
        Me.pntitle.Name = "pntitle"
        Me.pntitle.Size = New System.Drawing.Size(855, 66)
        Me.pntitle.TabIndex = 36
        '
        'btnclose
        '
        Me.btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.tscale.SetDecoration(Me.btnclose, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.btnclose, BunifuAnimatorNS.DecorationType.None)
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageActive = Nothing
        Me.btnclose.Location = New System.Drawing.Point(5, 12)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(45, 45)
        Me.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnclose.TabIndex = 37
        Me.btnclose.TabStop = False
        Me.btnclose.Zoom = 5
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel2.AutoSize = True
        Me.tscale.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.trotate.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(319, 15)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(230, 42)
        Me.BunifuCustomLabel2.TabIndex = 29
        Me.BunifuCustomLabel2.Text = "HIGH SCORE"
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 10
        Me.BunifuElipse2.TargetControl = Me.pntitle
        '
        'tscale
        '
        Me.tscale.AnimationType = BunifuAnimatorNS.AnimationType.Scale
        Me.tscale.Cursor = Nothing
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
        Me.tscale.DefaultAnimation = Animation1
        Me.tscale.Interval = 15
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
        'frmHighScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(898, 736)
        Me.Controls.Add(Me.pntitle)
        Me.Controls.Add(Me.pnfraction)
        Me.Controls.Add(Me.pnequivalent)
        Me.Controls.Add(Me.pnsquare)
        Me.Controls.Add(Me.pntemperature)
        Me.Controls.Add(Me.pnequation)
        Me.Controls.Add(Me.pnmeasure)
        Me.trotate.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tscale.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHighScore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHighScore"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnmeasure.ResumeLayout(False)
        Me.pnmeasure.PerformLayout()
        Me.pnequation.ResumeLayout(False)
        Me.pnequation.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pntemperature.ResumeLayout(False)
        Me.pntemperature.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.pnsquare.ResumeLayout(False)
        Me.pnsquare.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.pnequivalent.ResumeLayout(False)
        Me.pnequivalent.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.pnfraction.ResumeLayout(False)
        Me.pnfraction.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.pntitle.ResumeLayout(False)
        Me.pntitle.PerformLayout()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblSmeasure As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblNmeasure As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnmeasure As System.Windows.Forms.Panel
    Friend WithEvents pnequation As System.Windows.Forms.Panel
    Friend WithEvents lblNequation As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblSequation As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pntemperature As System.Windows.Forms.Panel
    Friend WithEvents lblNTemperature As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lblStemperature As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnsquare As System.Windows.Forms.Panel
    Friend WithEvents lblNsquare As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents lblSsquare As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnequivalent As System.Windows.Forms.Panel
    Friend WithEvents lblNequivalent As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents lblSequivalent As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel14 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnfraction As System.Windows.Forms.Panel
    Friend WithEvents lblNfraction As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents lblSfraction As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel17 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pntitle As System.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents tscale As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents btnclose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents trotate As BunifuAnimatorNS.BunifuTransition
End Class
