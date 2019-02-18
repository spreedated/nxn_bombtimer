<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Overlay
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
        Me.Lbl_Time = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_Time
        '
        Me.Lbl_Time.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Time.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Time.ForeColor = System.Drawing.Color.White
        Me.Lbl_Time.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_Time.Name = "Lbl_Time"
        Me.Lbl_Time.Size = New System.Drawing.Size(136, 39)
        Me.Lbl_Time.TabIndex = 0
        Me.Lbl_Time.Text = "##"
        Me.Lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_Overlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(136, 39)
        Me.ControlBox = False
        Me.Controls.Add(Me.Lbl_Time)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Overlay"
        Me.Opacity = 0.6R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Frm_Overlay"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lbl_Time As Label
End Class
