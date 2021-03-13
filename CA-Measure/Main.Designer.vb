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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelLv = New System.Windows.Forms.Label()
        Me.Labelx = New System.Windows.Forms.Label()
        Me.Labely = New System.Windows.Forms.Label()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonMeasure = New System.Windows.Forms.Button()
        Me.ButtonCalZero = New System.Windows.Forms.Button()
        Me.grdDataList = New System.Windows.Forms.DataGridView()
        Me.btnloadcmd = New System.Windows.Forms.Button()
        Me.cmdopen = New System.Windows.Forms.OpenFileDialog()
        Me.cmdDiagSave = New System.Windows.Forms.SaveFileDialog()
        Me.cmdDataSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.remotecmd = New System.Windows.Forms.TextBox()
        Me.runremotecmd = New System.Windows.Forms.Button()
        Me.detectSerial = New System.Windows.Forms.Button()
        Me.testserial = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comportdrp = New System.Windows.Forms.ComboBox()
        Me.ButtonSingleMeasure = New System.Windows.Forms.Button()
        CType(Me.grdDataList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lv :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("標楷體", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(18, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "x :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("標楷體", 18.0!)
        Me.Label3.Location = New System.Drawing.Point(18, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "y :"
        '
        'LabelLv
        '
        Me.LabelLv.AutoSize = True
        Me.LabelLv.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelLv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelLv.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.LabelLv.Location = New System.Drawing.Point(64, 12)
        Me.LabelLv.Name = "LabelLv"
        Me.LabelLv.Size = New System.Drawing.Size(73, 26)
        Me.LabelLv.TabIndex = 5
        Me.LabelLv.Text = "000.00"
        '
        'Labelx
        '
        Me.Labelx.AutoSize = True
        Me.Labelx.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Labelx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Labelx.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.Labelx.Location = New System.Drawing.Point(64, 54)
        Me.Labelx.Name = "Labelx"
        Me.Labelx.Size = New System.Drawing.Size(73, 26)
        Me.Labelx.TabIndex = 6
        Me.Labelx.Text = "0.0000"
        '
        'Labely
        '
        Me.Labely.AutoSize = True
        Me.Labely.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Labely.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Labely.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.Labely.Location = New System.Drawing.Point(64, 93)
        Me.Labely.Name = "Labely"
        Me.Labely.Size = New System.Drawing.Size(73, 26)
        Me.Labely.TabIndex = 7
        Me.Labely.Text = "0.0000"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonCancel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!)
        Me.ButtonCancel.Location = New System.Drawing.Point(304, 65)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(116, 54)
        Me.ButtonCancel.TabIndex = 10
        Me.ButtonCancel.Text = "Stop"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonMeasure
        '
        Me.ButtonMeasure.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.ButtonMeasure.Location = New System.Drawing.Point(170, 8)
        Me.ButtonMeasure.Name = "ButtonMeasure"
        Me.ButtonMeasure.Size = New System.Drawing.Size(118, 52)
        Me.ButtonMeasure.TabIndex = 11
        Me.ButtonMeasure.Text = "CMD List" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Measure"
        Me.ButtonMeasure.UseVisualStyleBackColor = True
        '
        'ButtonCalZero
        '
        Me.ButtonCalZero.BackColor = System.Drawing.Color.Khaki
        Me.ButtonCalZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCalZero.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!)
        Me.ButtonCalZero.Location = New System.Drawing.Point(304, 8)
        Me.ButtonCalZero.Name = "ButtonCalZero"
        Me.ButtonCalZero.Size = New System.Drawing.Size(116, 52)
        Me.ButtonCalZero.TabIndex = 12
        Me.ButtonCalZero.Text = "0-Cal"
        Me.ButtonCalZero.UseVisualStyleBackColor = False
        '
        'grdDataList
        '
        Me.grdDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDataList.Location = New System.Drawing.Point(8, 125)
        Me.grdDataList.Name = "grdDataList"
        Me.grdDataList.RowTemplate.Height = 24
        Me.grdDataList.Size = New System.Drawing.Size(762, 263)
        Me.grdDataList.TabIndex = 13
        '
        'btnloadcmd
        '
        Me.btnloadcmd.Location = New System.Drawing.Point(673, 94)
        Me.btnloadcmd.Name = "btnloadcmd"
        Me.btnloadcmd.Size = New System.Drawing.Size(97, 28)
        Me.btnloadcmd.TabIndex = 14
        Me.btnloadcmd.Text = "Load CMD list"
        Me.btnloadcmd.UseVisualStyleBackColor = True
        '
        'cmdDataSave
        '
        Me.cmdDataSave.Location = New System.Drawing.Point(673, 394)
        Me.cmdDataSave.Name = "cmdDataSave"
        Me.cmdDataSave.Size = New System.Drawing.Size(97, 28)
        Me.cmdDataSave.TabIndex = 15
        Me.cmdDataSave.Text = "Save Data"
        Me.cmdDataSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.remotecmd)
        Me.GroupBox1.Controls.Add(Me.runremotecmd)
        Me.GroupBox1.Controls.Add(Me.detectSerial)
        Me.GroupBox1.Controls.Add(Me.testserial)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.comportdrp)
        Me.GroupBox1.Location = New System.Drawing.Point(426, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 79)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "COM Control"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(6, 53)
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
        Me.Label4.Location = New System.Drawing.Point(8, 22)
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
        Me.ButtonSingleMeasure.Location = New System.Drawing.Point(170, 66)
        Me.ButtonSingleMeasure.Name = "ButtonSingleMeasure"
        Me.ButtonSingleMeasure.Size = New System.Drawing.Size(118, 53)
        Me.ButtonSingleMeasure.TabIndex = 17
        Me.ButtonSingleMeasure.Text = "Single" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Measure"
        Me.ButtonSingleMeasure.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(778, 430)
        Me.Controls.Add(Me.ButtonSingleMeasure)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdDataSave)
        Me.Controls.Add(Me.btnloadcmd)
        Me.Controls.Add(Me.grdDataList)
        Me.Controls.Add(Me.ButtonCalZero)
        Me.Controls.Add(Me.ButtonMeasure)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.Labely)
        Me.Controls.Add(Me.Labelx)
        Me.Controls.Add(Me.LabelLv)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelLv As System.Windows.Forms.Label
    Friend WithEvents Labelx As System.Windows.Forms.Label
    Friend WithEvents Labely As System.Windows.Forms.Label
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
End Class
