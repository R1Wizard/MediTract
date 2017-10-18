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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtWithPs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoPs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtList = New System.Windows.Forms.TextBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.RdoPeriods = New System.Windows.Forms.RadioButton()
        Me.RdoHyphens = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'txtWithPs
        '
        Me.txtWithPs.Location = New System.Drawing.Point(12, 44)
        Me.txtWithPs.Multiline = True
        Me.txtWithPs.Name = "txtWithPs"
        Me.txtWithPs.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtWithPs.Size = New System.Drawing.Size(224, 328)
        Me.txtWithPs.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("AdvisorBlackSSi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Paste ID numbers that need trimmed here"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNoPs
        '
        Me.txtNoPs.Location = New System.Drawing.Point(348, 44)
        Me.txtNoPs.Multiline = True
        Me.txtNoPs.Name = "txtNoPs"
        Me.txtNoPs.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNoPs.Size = New System.Drawing.Size(248, 327)
        Me.txtNoPs.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("AdvisorBlackSSi", 9.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(345, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Paste numbers and text that don't need trimmed here"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtList
        '
        Me.txtList.Location = New System.Drawing.Point(12, 377)
        Me.txtList.Multiline = True
        Me.txtList.Name = "txtList"
        Me.txtList.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtList.Size = New System.Drawing.Size(584, 72)
        Me.txtList.TabIndex = 4
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(242, 276)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(100, 21)
        Me.BtnClear.TabIndex = 5
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(242, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 24)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "add single quotes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.Font = New System.Drawing.Font("AdvisorBlackSSi", 9.0!)
        Me.lblCount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCount.Location = New System.Drawing.Point(242, 330)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(100, 41)
        Me.lblCount.TabIndex = 7
        Me.lblCount.Text = "COUNT"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RdoPeriods
        '
        Me.RdoPeriods.AutoSize = True
        Me.RdoPeriods.Checked = True
        Me.RdoPeriods.Location = New System.Drawing.Point(245, 118)
        Me.RdoPeriods.Name = "RdoPeriods"
        Me.RdoPeriods.Size = New System.Drawing.Size(60, 17)
        Me.RdoPeriods.TabIndex = 8
        Me.RdoPeriods.TabStop = True
        Me.RdoPeriods.Text = "Periods"
        Me.RdoPeriods.UseVisualStyleBackColor = True
        '
        'RdoHyphens
        '
        Me.RdoHyphens.AutoSize = True
        Me.RdoHyphens.Location = New System.Drawing.Point(245, 141)
        Me.RdoHyphens.Name = "RdoHyphens"
        Me.RdoHyphens.Size = New System.Drawing.Size(67, 17)
        Me.RdoHyphens.TabIndex = 9
        Me.RdoHyphens.Text = "Hyphens"
        Me.RdoHyphens.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 461)
        Me.Controls.Add(Me.RdoHyphens)
        Me.Controls.Add(Me.RdoPeriods)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.txtList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNoPs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtWithPs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = " Mr. Lister Version 1.25.2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtWithPs As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNoPs As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtList As TextBox
    Friend WithEvents BtnClear As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblCount As Label
    Friend WithEvents RdoPeriods As RadioButton
    Friend WithEvents RdoHyphens As RadioButton
End Class
