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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inputWidth = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.inputHeight = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.inputClearCover = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.outputAcp = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.inputFC = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.outputPcp = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.outputTcr_lbinch = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.outputTcr_kipft = New System.Windows.Forms.TextBox()
        Me.radPhi_075 = New System.Windows.Forms.RadioButton()
        Me.radPhi_085 = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(544, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CALCULATION OF CRACKING TORSION FOR RECTANGULAR RCC SECTION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Width of RCC Beam, b"
        '
        'inputWidth
        '
        Me.inputWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputWidth.Location = New System.Drawing.Point(317, 38)
        Me.inputWidth.Name = "inputWidth"
        Me.inputWidth.Size = New System.Drawing.Size(180, 21)
        Me.inputWidth.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(503, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "inch"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(503, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "inch"
        '
        'inputHeight
        '
        Me.inputHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputHeight.Location = New System.Drawing.Point(317, 67)
        Me.inputHeight.Name = "inputHeight"
        Me.inputHeight.Size = New System.Drawing.Size(180, 21)
        Me.inputHeight.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total depth of RCC beam, h"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(503, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "inch"
        '
        'inputClearCover
        '
        Me.inputClearCover.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputClearCover.Location = New System.Drawing.Point(317, 96)
        Me.inputClearCover.Name = "inputClearCover"
        Me.inputClearCover.Size = New System.Drawing.Size(180, 21)
        Me.inputClearCover.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(224, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Clear cover to outer hoop / stirrup, cc"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(503, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "inch^2"
        '
        'outputAcp
        '
        Me.outputAcp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.outputAcp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputAcp.ForeColor = System.Drawing.Color.Blue
        Me.outputAcp.Location = New System.Drawing.Point(317, 238)
        Me.outputAcp.Name = "outputAcp"
        Me.outputAcp.ReadOnly = True
        Me.outputAcp.Size = New System.Drawing.Size(180, 21)
        Me.outputAcp.TabIndex = 11
        Me.outputAcp.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(220, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Gross area of concrete section, Acp"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(503, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 16)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "psi"
        '
        'inputFC
        '
        Me.inputFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputFC.Location = New System.Drawing.Point(317, 125)
        Me.inputFC.Name = "inputFC"
        Me.inputFC.Size = New System.Drawing.Size(180, 21)
        Me.inputFC.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(278, 16)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Specified Cylinderical Strength of concrete, f'c"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(503, 270)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 16)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "inch"
        '
        'outputPcp
        '
        Me.outputPcp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.outputPcp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputPcp.ForeColor = System.Drawing.Color.Blue
        Me.outputPcp.Location = New System.Drawing.Point(317, 267)
        Me.outputPcp.Name = "outputPcp"
        Me.outputPcp.ReadOnly = True
        Me.outputPcp.Size = New System.Drawing.Size(180, 21)
        Me.outputPcp.TabIndex = 17
        Me.outputPcp.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 270)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(248, 16)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Perimeter of gross concrete section, Pcp"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 157)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(175, 16)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Strength reduction factor, phi"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(503, 297)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 16)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "lb-inch"
        '
        'outputTcr_lbinch
        '
        Me.outputTcr_lbinch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.outputTcr_lbinch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputTcr_lbinch.ForeColor = System.Drawing.Color.Blue
        Me.outputTcr_lbinch.Location = New System.Drawing.Point(317, 294)
        Me.outputTcr_lbinch.Name = "outputTcr_lbinch"
        Me.outputTcr_lbinch.ReadOnly = True
        Me.outputTcr_lbinch.Size = New System.Drawing.Size(180, 21)
        Me.outputTcr_lbinch.TabIndex = 23
        Me.outputTcr_lbinch.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(14, 297)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(161, 16)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Cracking torsion, phi*Tcr *"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(503, 324)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(36, 16)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "kip-ft"
        '
        'outputTcr_kipft
        '
        Me.outputTcr_kipft.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.outputTcr_kipft.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputTcr_kipft.ForeColor = System.Drawing.Color.Blue
        Me.outputTcr_kipft.Location = New System.Drawing.Point(317, 321)
        Me.outputTcr_kipft.Name = "outputTcr_kipft"
        Me.outputTcr_kipft.ReadOnly = True
        Me.outputTcr_kipft.Size = New System.Drawing.Size(180, 21)
        Me.outputTcr_kipft.TabIndex = 25
        Me.outputTcr_kipft.TabStop = False
        '
        'radPhi_075
        '
        Me.radPhi_075.AutoSize = True
        Me.radPhi_075.Checked = True
        Me.radPhi_075.Location = New System.Drawing.Point(317, 155)
        Me.radPhi_075.Name = "radPhi_075"
        Me.radPhi_075.Size = New System.Drawing.Size(50, 20)
        Me.radPhi_075.TabIndex = 27
        Me.radPhi_075.TabStop = True
        Me.radPhi_075.Text = "0.75"
        Me.radPhi_075.UseVisualStyleBackColor = True
        '
        'radPhi_085
        '
        Me.radPhi_085.AutoSize = True
        Me.radPhi_085.Location = New System.Drawing.Point(381, 155)
        Me.radPhi_085.Name = "radPhi_085"
        Me.radPhi_085.Size = New System.Drawing.Size(50, 20)
        Me.radPhi_085.TabIndex = 28
        Me.radPhi_085.TabStop = True
        Me.radPhi_085.Text = "0.85"
        Me.radPhi_085.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(314, 345)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(180, 32)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "* Multiply with reduction factor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   for light weight concrete"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(317, 181)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 28)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(17, 413)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "About"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(486, 413)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 448)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.radPhi_085)
        Me.Controls.Add(Me.radPhi_075)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.outputTcr_kipft)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.outputTcr_lbinch)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.outputPcp)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.inputFC)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.outputAcp)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.inputClearCover)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.inputHeight)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.inputWidth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Cracking Torsion Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents inputWidth As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents inputHeight As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents inputClearCover As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents outputAcp As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents inputFC As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents outputPcp As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents outputTcr_lbinch As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents outputTcr_kipft As System.Windows.Forms.TextBox
    Friend WithEvents radPhi_075 As System.Windows.Forms.RadioButton
    Friend WithEvents radPhi_085 As System.Windows.Forms.RadioButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
