﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstNum = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.vsbMin = New System.Windows.Forms.VScrollBar()
        Me.vsbMax = New System.Windows.Forms.VScrollBar()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.btnFirst20 = New System.Windows.Forms.Button()
        Me.btnMin2Max = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnFirst10Multiples3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(280, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Simple Loops"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "List of Numbers"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(399, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Minimum"
        '
        'lstNum
        '
        Me.lstNum.FormattingEnabled = True
        Me.lstNum.ItemHeight = 25
        Me.lstNum.Location = New System.Drawing.Point(12, 95)
        Me.lstNum.Name = "lstNum"
        Me.lstNum.Size = New System.Drawing.Size(287, 254)
        Me.lstNum.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(583, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 32)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Maximum"
        '
        'vsbMin
        '
        Me.vsbMin.LargeChange = 1
        Me.vsbMin.Location = New System.Drawing.Point(455, 203)
        Me.vsbMin.Maximum = 5
        Me.vsbMin.Name = "vsbMin"
        Me.vsbMin.Size = New System.Drawing.Size(39, 208)
        Me.vsbMin.TabIndex = 5
        '
        'vsbMax
        '
        Me.vsbMax.LargeChange = 5
        Me.vsbMax.Location = New System.Drawing.Point(638, 203)
        Me.vsbMax.Maximum = 50
        Me.vsbMax.Name = "vsbMax"
        Me.vsbMax.Size = New System.Drawing.Size(39, 208)
        Me.vsbMax.TabIndex = 6
        Me.vsbMax.Value = 1
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMin.Location = New System.Drawing.Point(443, 411)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(65, 32)
        Me.lblMin.TabIndex = 7
        Me.lblMin.Text = "Void"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMax.Location = New System.Drawing.Point(627, 411)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(65, 32)
        Me.lblMax.TabIndex = 8
        Me.lblMax.Text = "Void"
        '
        'btnFirst20
        '
        Me.btnFirst20.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFirst20.Location = New System.Drawing.Point(702, 53)
        Me.btnFirst20.Name = "btnFirst20"
        Me.btnFirst20.Size = New System.Drawing.Size(86, 39)
        Me.btnFirst20.TabIndex = 9
        Me.btnFirst20.Text = "First 20"
        Me.btnFirst20.UseVisualStyleBackColor = True
        '
        'btnMin2Max
        '
        Me.btnMin2Max.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMin2Max.Location = New System.Drawing.Point(667, 9)
        Me.btnMin2Max.Name = "btnMin2Max"
        Me.btnMin2Max.Size = New System.Drawing.Size(121, 38)
        Me.btnMin2Max.TabIndex = 10
        Me.btnMin2Max.Text = "Min to Max"
        Me.btnMin2Max.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(12, 356)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 42)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Quit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(12, 401)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(133, 42)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Help"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(151, 356)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 42)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnFirst10Multiples3
        '
        Me.btnFirst10Multiples3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFirst10Multiples3.Location = New System.Drawing.Point(600, 95)
        Me.btnFirst10Multiples3.Name = "btnFirst10Multiples3"
        Me.btnFirst10Multiples3.Size = New System.Drawing.Size(188, 38)
        Me.btnFirst10Multiples3.TabIndex = 14
        Me.btnFirst10Multiples3.Text = "First 10 Multiples of 3"
        Me.btnFirst10Multiples3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button5.Location = New System.Drawing.Point(508, 50)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(188, 39)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "First 20 w/ 5 Multiples"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnFirst10Multiples3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnMin2Max)
        Me.Controls.Add(Me.btnFirst20)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.vsbMax)
        Me.Controls.Add(Me.vsbMin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstNum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstNum As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents vsbMin As VScrollBar
    Friend WithEvents vsbMax As VScrollBar
    Friend WithEvents lblMin As Label
    Friend WithEvents lblMax As Label
    Friend WithEvents btnFirst20 As Button
    Friend WithEvents btnMin2Max As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnFirst10Multiples3 As Button
    Friend WithEvents Button5 As Button
End Class
