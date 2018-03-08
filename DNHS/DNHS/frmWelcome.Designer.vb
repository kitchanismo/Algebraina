<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Me.lblmsg = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.requation = New Bunifu.Framework.UI.BunifuRating()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblmsg
        '
        Me.lblmsg.AutoSize = True
        Me.lblmsg.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsg.ForeColor = System.Drawing.Color.White
        Me.lblmsg.Location = New System.Drawing.Point(13, 17)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(152, 36)
        Me.lblmsg.TabIndex = 17
        Me.lblmsg.Text = "Welcome"
        '
        'btnstart
        '
        Me.btnstart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnstart.BackColor = System.Drawing.Color.Transparent
        Me.btnstart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstart.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstart.ForeColor = System.Drawing.Color.White
        Me.btnstart.Location = New System.Drawing.Point(811, 197)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(75, 33)
        Me.btnstart.TabIndex = 18
        Me.btnstart.Text = "OK"
        Me.btnstart.UseVisualStyleBackColor = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(38, 102)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(832, 30)
        Me.BunifuCustomLabel1.TabIndex = 19
        Me.BunifuCustomLabel1.Text = "Collect all                      stars and gain score for every topic you play! "
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.requation)
        Me.Panel2.Location = New System.Drawing.Point(169, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(146, 48)
        Me.Panel2.TabIndex = 20
        '
        'requation
        '
        Me.requation.BackColor = System.Drawing.Color.Transparent
        Me.requation.Enabled = False
        Me.requation.ForeColor = System.Drawing.Color.Goldenrod
        Me.requation.Location = New System.Drawing.Point(3, 3)
        Me.requation.Name = "requation"
        Me.requation.Size = New System.Drawing.Size(241, 38)
        Me.requation.TabIndex = 10
        Me.requation.Value = 3
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(898, 242)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.lblmsg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmWelcome"
        Me.Opacity = 0.99R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMsgBox"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblmsg As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnstart As System.Windows.Forms.Button
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents requation As Bunifu.Framework.UI.BunifuRating
End Class
