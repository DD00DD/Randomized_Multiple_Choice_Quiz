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
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbFour = New System.Windows.Forms.RadioButton()
        Me.rdbThree = New System.Windows.Forms.RadioButton()
        Me.rdbTwo = New System.Windows.Forms.RadioButton()
        Me.rdbOne = New System.Windows.Forms.RadioButton()
        Me.prgScore = New System.Windows.Forms.ProgressBar()
        Me.btnAsk = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.ForeColor = System.Drawing.Color.White
        Me.lblQuestion.Location = New System.Drawing.Point(12, 9)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(589, 81)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.Label4)
        Me.grpOptions.Controls.Add(Me.Label3)
        Me.grpOptions.Controls.Add(Me.Label2)
        Me.grpOptions.Controls.Add(Me.Label1)
        Me.grpOptions.Controls.Add(Me.rdbFour)
        Me.grpOptions.Controls.Add(Me.rdbThree)
        Me.grpOptions.Controls.Add(Me.rdbTwo)
        Me.grpOptions.Controls.Add(Me.rdbOne)
        Me.grpOptions.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOptions.ForeColor = System.Drawing.Color.White
        Me.grpOptions.Location = New System.Drawing.Point(12, 110)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(589, 234)
        Me.grpOptions.TabIndex = 1
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Choose One"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 43)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "D"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 43)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "C"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 43)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "B"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 43)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "A"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rdbFour
        '
        Me.rdbFour.AutoSize = True
        Me.rdbFour.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFour.Location = New System.Drawing.Point(44, 186)
        Me.rdbFour.Name = "rdbFour"
        Me.rdbFour.Size = New System.Drawing.Size(14, 13)
        Me.rdbFour.TabIndex = 3
        Me.rdbFour.Tag = "D"
        Me.rdbFour.UseVisualStyleBackColor = True
        '
        'rdbThree
        '
        Me.rdbThree.AutoSize = True
        Me.rdbThree.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbThree.Location = New System.Drawing.Point(44, 136)
        Me.rdbThree.Name = "rdbThree"
        Me.rdbThree.Size = New System.Drawing.Size(14, 13)
        Me.rdbThree.TabIndex = 2
        Me.rdbThree.Tag = "C"
        Me.rdbThree.UseVisualStyleBackColor = True
        '
        'rdbTwo
        '
        Me.rdbTwo.AutoSize = True
        Me.rdbTwo.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbTwo.Location = New System.Drawing.Point(44, 89)
        Me.rdbTwo.Name = "rdbTwo"
        Me.rdbTwo.Size = New System.Drawing.Size(14, 13)
        Me.rdbTwo.TabIndex = 1
        Me.rdbTwo.Tag = "B"
        Me.rdbTwo.UseVisualStyleBackColor = True
        '
        'rdbOne
        '
        Me.rdbOne.AutoSize = True
        Me.rdbOne.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbOne.Location = New System.Drawing.Point(44, 45)
        Me.rdbOne.Name = "rdbOne"
        Me.rdbOne.Size = New System.Drawing.Size(14, 13)
        Me.rdbOne.TabIndex = 0
        Me.rdbOne.Tag = "A"
        Me.rdbOne.UseVisualStyleBackColor = True
        '
        'prgScore
        '
        Me.prgScore.Location = New System.Drawing.Point(14, 357)
        Me.prgScore.Name = "prgScore"
        Me.prgScore.Size = New System.Drawing.Size(586, 57)
        Me.prgScore.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgScore.TabIndex = 2
        '
        'btnAsk
        '
        Me.btnAsk.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsk.Location = New System.Drawing.Point(14, 434)
        Me.btnAsk.Name = "btnAsk"
        Me.btnAsk.Size = New System.Drawing.Size(167, 71)
        Me.btnAsk.TabIndex = 3
        Me.btnAsk.Text = "Ask Question"
        Me.btnAsk.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Enabled = False
        Me.btnCheck.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.Location = New System.Drawing.Point(434, 434)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(167, 71)
        Me.btnCheck.TabIndex = 4
        Me.btnCheck.Text = "Check Answer"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblScore.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(219, 428)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(170, 77)
        Me.lblScore.TabIndex = 5
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(613, 517)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnAsk)
        Me.Controls.Add(Me.prgScore)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.lblQuestion)
        Me.Name = "Form1"
        Me.Text = "MC Quiz"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblQuestion As Label
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents rdbFour As RadioButton
    Friend WithEvents rdbThree As RadioButton
    Friend WithEvents rdbTwo As RadioButton
    Friend WithEvents rdbOne As RadioButton
    Friend WithEvents prgScore As ProgressBar
    Friend WithEvents btnAsk As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
