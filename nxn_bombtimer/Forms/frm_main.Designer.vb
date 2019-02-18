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
        Me.Btn_Preview = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TrckBar_Volume = New System.Windows.Forms.TrackBar()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Chk_custom = New System.Windows.Forms.RadioButton()
        Me.chk_comp = New System.Windows.Forms.RadioButton()
        Me.Btn_Debug = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TrckBar_Volume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 432)
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
        Me.GroupBox1.Controls.Add(Me.Btn_Preview)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TrckBar_Volume)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 198)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        Me.GroupBox1.Visible = False
        '
        'Btn_Preview
        '
        Me.Btn_Preview.Location = New System.Drawing.Point(320, 169)
        Me.Btn_Preview.Name = "Btn_Preview"
        Me.Btn_Preview.Size = New System.Drawing.Size(65, 23)
        Me.Btn_Preview.TabIndex = 8
        Me.Btn_Preview.Text = "Preview"
        Me.Btn_Preview.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(332, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Volume"
        '
        'TrckBar_Volume
        '
        Me.TrckBar_Volume.Location = New System.Drawing.Point(330, 58)
        Me.TrckBar_Volume.Maximum = 100
        Me.TrckBar_Volume.Minimum = 10
        Me.TrckBar_Volume.Name = "TrckBar_Volume"
        Me.TrckBar_Volume.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrckBar_Volume.Size = New System.Drawing.Size(45, 105)
        Me.TrckBar_Volume.TabIndex = 10
        Me.TrckBar_Volume.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrckBar_Volume.Value = 10
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
        'Btn_Debug
        '
        Me.Btn_Debug.Location = New System.Drawing.Point(248, 94)
        Me.Btn_Debug.Name = "Btn_Debug"
        Me.Btn_Debug.Size = New System.Drawing.Size(123, 31)
        Me.Btn_Debug.TabIndex = 7
        Me.Btn_Debug.Text = "Debug"
        Me.Btn_Debug.UseVisualStyleBackColor = True
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 454)
        Me.Controls.Add(Me.Btn_Debug)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_Licence)
        Me.Controls.Add(Me.Btn_Options)
        Me.Controls.Add(Me.Btn_Start)
        Me.Name = "Frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_main"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TrckBar_Volume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Btn_Debug As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TrckBar_Volume As TrackBar
    Friend WithEvents Btn_Preview As Button
End Class
