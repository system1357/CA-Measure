<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form
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
    Private components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelLv = New System.Windows.Forms.Label()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonMeasure = New System.Windows.Forms.Button()
        Me.ButtonCalZero = New System.Windows.Forms.Button()
        Me.grdDataList = New System.Windows.Forms.DataGridView()
        Me.btnloadcmd = New System.Windows.Forms.Button()
        Me.cmdopen = New System.Windows.Forms.OpenFileDialog()
        Me.cmdDiagSave = New System.Windows.Forms.SaveFileDialog()
        Me.cmdDataSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.baud = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TimeoutSec = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.remotecmd = New System.Windows.Forms.TextBox()
        Me.runremotecmd = New System.Windows.Forms.Button()
        Me.detectSerial = New System.Windows.Forms.Button()
        Me.testserial = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comportdrp = New System.Windows.Forms.ComboBox()
        Me.ButtonSingleMeasure = New System.Windows.Forms.Button()
        Me.linecounter = New System.Windows.Forms.Label()
        Me.lineall = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.grdDataList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lv :"
        '
        'LabelLv
        '
        Me.LabelLv.AutoSize = True
        Me.LabelLv.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelLv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelLv.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.LabelLv.Location = New System.Drawing.Point(127, 15)
        Me.LabelLv.Name = "LabelLv"
        Me.LabelLv.Size = New System.Drawing.Size(73, 26)
        Me.LabelLv.TabIndex = 5
        Me.LabelLv.Text = "000.00"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonCancel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.Location = New System.Drawing.Point(206, 66)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(104, 53)
        Me.ButtonCancel.TabIndex = 10
        Me.ButtonCancel.Text = "Stop"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonMeasure
        '
        Me.ButtonMeasure.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.ButtonMeasure.Location = New System.Drawing.Point(316, 7)
        Me.ButtonMeasure.Name = "ButtonMeasure"
        Me.ButtonMeasure.Size = New System.Drawing.Size(104, 52)
        Me.ButtonMeasure.TabIndex = 11
        Me.ButtonMeasure.Text = "CMD List" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Measure"
        Me.ButtonMeasure.UseVisualStyleBackColor = True
        '
        'ButtonCalZero
        '
        Me.ButtonCalZero.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonCalZero.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCalZero.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCalZero.Location = New System.Drawing.Point(10, 395)
        Me.ButtonCalZero.Name = "ButtonCalZero"
        Me.ButtonCalZero.Size = New System.Drawing.Size(59, 28)
        Me.ButtonCalZero.TabIndex = 12
        Me.ButtonCalZero.Text = "0-Cal"
        Me.ButtonCalZero.UseVisualStyleBackColor = False
        '
        'grdDataList
        '
        Me.grdDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDataList.Location = New System.Drawing.Point(12, 125)
        Me.grdDataList.Name = "grdDataList"
        Me.grdDataList.RowTemplate.Height = 24
        Me.grdDataList.Size = New System.Drawing.Size(762, 263)
        Me.grdDataList.TabIndex = 13
        '
        'btnloadcmd
        '
        Me.btnloadcmd.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloadcmd.Location = New System.Drawing.Point(316, 66)
        Me.btnloadcmd.Name = "btnloadcmd"
        Me.btnloadcmd.Size = New System.Drawing.Size(104, 53)
        Me.btnloadcmd.TabIndex = 14
        Me.btnloadcmd.Text = "Load CMD list"
        Me.btnloadcmd.UseVisualStyleBackColor = True
        '
        'cmdDataSave
        '
        Me.cmdDataSave.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDataSave.Location = New System.Drawing.Point(670, 394)
        Me.cmdDataSave.Name = "cmdDataSave"
        Me.cmdDataSave.Size = New System.Drawing.Size(104, 28)
        Me.cmdDataSave.TabIndex = 15
        Me.cmdDataSave.Text = "Save Data"
        Me.cmdDataSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.baud)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TimeoutSec)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.remotecmd)
        Me.GroupBox1.Controls.Add(Me.runremotecmd)
        Me.GroupBox1.Controls.Add(Me.detectSerial)
        Me.GroupBox1.Controls.Add(Me.testserial)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.comportdrp)
        Me.GroupBox1.Location = New System.Drawing.Point(426, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 109)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "COM Control"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(36, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Baud :"
        '
        'baud
        '
        Me.baud.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.baud.Location = New System.Drawing.Point(91, 81)
        Me.baud.MaxLength = 10
        Me.baud.Name = "baud"
        Me.baud.Size = New System.Drawing.Size(85, 22)
        Me.baud.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(312, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "ms"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(195, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Delay :"
        '
        'TimeoutSec
        '
        Me.TimeoutSec.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TimeoutSec.Location = New System.Drawing.Point(254, 81)
        Me.TimeoutSec.MaxLength = 10
        Me.TimeoutSec.Name = "TimeoutSec"
        Me.TimeoutSec.Size = New System.Drawing.Size(52, 22)
        Me.TimeoutSec.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(4, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Command :"
        '
        'remotecmd
        '
        Me.remotecmd.Font = New System.Drawing.Font("新細明體", 9.0!)
        Me.remotecmd.Location = New System.Drawing.Point(91, 50)
        Me.remotecmd.Name = "remotecmd"
        Me.remotecmd.Size = New System.Drawing.Size(166, 22)
        Me.remotecmd.TabIndex = 5
        '
        'runremotecmd
        '
        Me.runremotecmd.Location = New System.Drawing.Point(263, 50)
        Me.runremotecmd.Name = "runremotecmd"
        Me.runremotecmd.Size = New System.Drawing.Size(75, 23)
        Me.runremotecmd.TabIndex = 4
        Me.runremotecmd.Text = "Run"
        Me.runremotecmd.UseVisualStyleBackColor = True
        '
        'detectSerial
        '
        Me.detectSerial.Location = New System.Drawing.Point(182, 21)
        Me.detectSerial.Name = "detectSerial"
        Me.detectSerial.Size = New System.Drawing.Size(75, 21)
        Me.detectSerial.TabIndex = 3
        Me.detectSerial.Text = "ReDetect"
        Me.detectSerial.UseVisualStyleBackColor = True
        '
        'testserial
        '
        Me.testserial.Location = New System.Drawing.Point(263, 21)
        Me.testserial.Name = "testserial"
        Me.testserial.Size = New System.Drawing.Size(75, 21)
        Me.testserial.TabIndex = 2
        Me.testserial.Text = "Test"
        Me.testserial.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "COM Port :"
        '
        'comportdrp
        '
        Me.comportdrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comportdrp.FormattingEnabled = True
        Me.comportdrp.Location = New System.Drawing.Point(91, 22)
        Me.comportdrp.Name = "comportdrp"
        Me.comportdrp.Size = New System.Drawing.Size(85, 20)
        Me.comportdrp.TabIndex = 0
        '
        'ButtonSingleMeasure
        '
        Me.ButtonSingleMeasure.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.ButtonSingleMeasure.Location = New System.Drawing.Point(206, 6)
        Me.ButtonSingleMeasure.Name = "ButtonSingleMeasure"
        Me.ButtonSingleMeasure.Size = New System.Drawing.Size(104, 53)
        Me.ButtonSingleMeasure.TabIndex = 17
        Me.ButtonSingleMeasure.Text = "Single" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Measure"
        Me.ButtonSingleMeasure.UseVisualStyleBackColor = True
        '
        'linecounter
        '
        Me.linecounter.AutoSize = True
        Me.linecounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.linecounter.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.linecounter.Location = New System.Drawing.Point(127, 83)
        Me.linecounter.Name = "linecounter"
        Me.linecounter.Size = New System.Drawing.Size(67, 26)
        Me.linecounter.TabIndex = 18
        Me.linecounter.Text = "00000"
        '
        'lineall
        '
        Me.lineall.AutoSize = True
        Me.lineall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lineall.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lineall.Location = New System.Drawing.Point(127, 48)
        Me.lineall.Name = "lineall"
        Me.lineall.Size = New System.Drawing.Size(67, 26)
        Me.lineall.TabIndex = 19
        Me.lineall.Text = "00000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 28)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Total :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 28)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Current :"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(75, 395)
        Me.ProgressBar1.MarqueeAnimationSpeed = 10
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(589, 27)
        Me.ProgressBar1.TabIndex = 22
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(781, 430)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lineall)
        Me.Controls.Add(Me.linecounter)
        Me.Controls.Add(Me.ButtonSingleMeasure)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdDataSave)
        Me.Controls.Add(Me.btnloadcmd)
        Me.Controls.Add(Me.grdDataList)
        Me.Controls.Add(Me.ButtonCalZero)
        Me.Controls.Add(Me.ButtonMeasure)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.LabelLv)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "CA-Measure"
        CType(Me.grdDataList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelLv As System.Windows.Forms.Label
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonMeasure As System.Windows.Forms.Button
    Friend WithEvents ButtonCalZero As System.Windows.Forms.Button
    Friend WithEvents grdDataList As DataGridView
    Friend WithEvents btnloadcmd As Button
    Friend WithEvents cmdopen As OpenFileDialog
    Friend WithEvents cmdDiagSave As SaveFileDialog
    Friend WithEvents cmdDataSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents comportdrp As ComboBox
    Friend WithEvents testserial As Button
    Friend WithEvents detectSerial As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents remotecmd As TextBox
    Friend WithEvents runremotecmd As Button
    Friend WithEvents ButtonSingleMeasure As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TimeoutSec As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents baud As TextBox
    Friend WithEvents linecounter As Label
    Friend WithEvents lineall As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
