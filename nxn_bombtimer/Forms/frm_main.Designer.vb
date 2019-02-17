<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Main
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
        Me.Btn_Start = New System.Windows.Forms.Button()
        Me.Btn_Options = New System.Windows.Forms.Button()
        Me.Btn_Licence = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Chk_custom = New System.Windows.Forms.RadioButton()
        Me.chk_comp = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btn_ClearFields = New System.Windows.Forms.Button()
        Me.Btn_RemoveLicence = New System.Windows.Forms.Button()
        Me.Btn_Paste = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Btn_Register = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Start
        '
        Me.Btn_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Start.Location = New System.Drawing.Point(248, 12)
        Me.Btn_Start.Name = "Btn_Start"
        Me.Btn_Start.Size = New System.Drawing.Size(123, 29)
        Me.Btn_Start.TabIndex = 0
        Me.Btn_Start.Text = "&Rock 'n' Roll"
        Me.Btn_Start.UseVisualStyleBackColor = True
        '
        'Btn_Options
        '
        Me.Btn_Options.Location = New System.Drawing.Point(248, 131)
        Me.Btn_Options.Name = "Btn_Options"
        Me.Btn_Options.Size = New System.Drawing.Size(123, 31)
        Me.Btn_Options.TabIndex = 1
        Me.Btn_Options.Text = "&Options »"
        Me.Btn_Options.UseVisualStyleBackColor = True
        '
        'Btn_Licence
        '
        Me.Btn_Licence.Location = New System.Drawing.Point(248, 168)
        Me.Btn_Licence.Name = "Btn_Licence"
        Me.Btn_Licence.Size = New System.Drawing.Size(123, 31)
        Me.Btn_Licence.TabIndex = 2
        Me.Btn_Licence.Text = "&Licence"
        Me.Btn_Licence.UseVisualStyleBackColor = True
        Me.Btn_Licence.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.nxn_bombtimer.My.Resources.Resources.bomb_empty
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 574)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(415, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(13, 17)
        Me.ToolStripStatusLabel1.Text = "|"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(61, 17)
        Me.ToolStripStatusLabel2.Text = "[+] Ready"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 280)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 198)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        Me.GroupBox1.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(6, 167)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(128, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Listen on CS:GO start"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"None", "3D Announcer", "Female Voice", "UT99", "Analogue Tick"})
        Me.ComboBox1.Location = New System.Drawing.Point(77, 131)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(143, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Announcer:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox2.Controls.Add(Me.Chk_custom)
        Me.GroupBox2.Controls.Add(Me.chk_comp)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(170, 96)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Timer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Seconds"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Enabled = False
        Me.NumericUpDown1.Location = New System.Drawing.Point(30, 65)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(36, 20)
        Me.NumericUpDown1.TabIndex = 4
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {35, 0, 0, 0})
        '
        'Chk_custom
        '
        Me.Chk_custom.AutoSize = True
        Me.Chk_custom.Location = New System.Drawing.Point(6, 42)
        Me.Chk_custom.Name = "Chk_custom"
        Me.Chk_custom.Size = New System.Drawing.Size(60, 17)
        Me.Chk_custom.TabIndex = 3
        Me.Chk_custom.Text = "Custom"
        Me.Chk_custom.UseVisualStyleBackColor = True
        '
        'chk_comp
        '
        Me.chk_comp.AutoSize = True
        Me.chk_comp.Checked = True
        Me.chk_comp.Location = New System.Drawing.Point(6, 19)
        Me.chk_comp.Name = "chk_comp"
        Me.chk_comp.Size = New System.Drawing.Size(146, 17)
        Me.chk_comp.TabIndex = 2
        Me.chk_comp.TabStop = True
        Me.chk_comp.Text = "Competitive (40 Seconds)"
        Me.chk_comp.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(218, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 84)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "### LICENCE ###"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btn_ClearFields)
        Me.GroupBox3.Controls.Add(Me.Btn_RemoveLicence)
        Me.GroupBox3.Controls.Add(Me.Btn_Paste)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Btn_Register)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 484)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(391, 76)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Register Licence"
        '
        'Btn_ClearFields
        '
        Me.Btn_ClearFields.Location = New System.Drawing.Point(62, 47)
        Me.Btn_ClearFields.Name = "Btn_ClearFields"
        Me.Btn_ClearFields.Size = New System.Drawing.Size(76, 21)
        Me.Btn_ClearFields.TabIndex = 13
        Me.Btn_ClearFields.Text = "Clear fields"
        Me.Btn_ClearFields.UseVisualStyleBackColor = True
        '
        'Btn_RemoveLicence
        '
        Me.Btn_RemoveLicence.Location = New System.Drawing.Point(188, 47)
        Me.Btn_RemoveLicence.Name = "Btn_RemoveLicence"
        Me.Btn_RemoveLicence.Size = New System.Drawing.Size(97, 21)
        Me.Btn_RemoveLicence.TabIndex = 12
        Me.Btn_RemoveLicence.Text = "Remove licence"
        Me.Btn_RemoveLicence.UseVisualStyleBackColor = True
        '
        'Btn_Paste
        '
        Me.Btn_Paste.Location = New System.Drawing.Point(6, 47)
        Me.Btn_Paste.Name = "Btn_Paste"
        Me.Btn_Paste.Size = New System.Drawing.Size(50, 21)
        Me.Btn_Paste.TabIndex = 11
        Me.Btn_Paste.Text = "&Paste"
        Me.Btn_Paste.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(235, 19)
        Me.TextBox3.MaxLength = 6
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(50, 22)
        Me.TextBox3.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(223, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(139, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "-"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(151, 19)
        Me.TextBox2.MaxLength = 9
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(70, 22)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(87, 19)
        Me.TextBox1.MaxLength = 6
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(50, 22)
        Me.TextBox1.TabIndex = 7
        '
        'Btn_Register
        '
        Me.Btn_Register.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Register.Location = New System.Drawing.Point(291, 47)
        Me.Btn_Register.Name = "Btn_Register"
        Me.Btn_Register.Size = New System.Drawing.Size(81, 21)
        Me.Btn_Register.TabIndex = 10
        Me.Btn_Register.Text = "&Register"
        Me.Btn_Register.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(391, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Options only available" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in full Version"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Visible = False
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 596)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_Licence)
        Me.Controls.Add(Me.Btn_Options)
        Me.Controls.Add(Me.Btn_Start)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_main"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Start As Button
    Friend WithEvents Btn_Options As Button
    Friend WithEvents Btn_Licence As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Chk_custom As RadioButton
    Friend WithEvents chk_comp As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Btn_Register As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Btn_Paste As Button
    Friend WithEvents Btn_RemoveLicence As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Btn_ClearFields As Button
End Class
