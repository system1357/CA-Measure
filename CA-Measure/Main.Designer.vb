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
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'LabelLv
        '
        resources.ApplyResources(Me.LabelLv, "LabelLv")
        Me.LabelLv.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelLv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelLv.Name = "LabelLv"
        '
        'Labelx
        '
        resources.ApplyResources(Me.Labelx, "Labelx")
        Me.Labelx.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Labelx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Labelx.Name = "Labelx"
        '
        'Labely
        '
        resources.ApplyResources(Me.Labely, "Labely")
        Me.Labely.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Labely.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Labely.Name = "Labely"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.ButtonCancel, "ButtonCancel")
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonMeasure
        '
        resources.ApplyResources(Me.ButtonMeasure, "ButtonMeasure")
        Me.ButtonMeasure.Name = "ButtonMeasure"
        Me.ButtonMeasure.UseVisualStyleBackColor = True
        '
        'ButtonCalZero
        '
        Me.ButtonCalZero.BackColor = System.Drawing.Color.Khaki
        resources.ApplyResources(Me.ButtonCalZero, "ButtonCalZero")
        Me.ButtonCalZero.Name = "ButtonCalZero"
        Me.ButtonCalZero.UseVisualStyleBackColor = False
        '
        'grdDataList
        '
        Me.grdDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.grdDataList, "grdDataList")
        Me.grdDataList.Name = "grdDataList"
        Me.grdDataList.RowTemplate.Height = 24
        '
        'btnloadcmd
        '
        resources.ApplyResources(Me.btnloadcmd, "btnloadcmd")
        Me.btnloadcmd.Name = "btnloadcmd"
        Me.btnloadcmd.UseVisualStyleBackColor = True
        '
        'cmdDataSave
        '
        resources.ApplyResources(Me.cmdDataSave, "cmdDataSave")
        Me.cmdDataSave.Name = "cmdDataSave"
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
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'remotecmd
        '
        resources.ApplyResources(Me.remotecmd, "remotecmd")
        Me.remotecmd.Name = "remotecmd"
        '
        'runremotecmd
        '
        resources.ApplyResources(Me.runremotecmd, "runremotecmd")
        Me.runremotecmd.Name = "runremotecmd"
        Me.runremotecmd.UseVisualStyleBackColor = True
        '
        'detectSerial
        '
        resources.ApplyResources(Me.detectSerial, "detectSerial")
        Me.detectSerial.Name = "detectSerial"
        Me.detectSerial.UseVisualStyleBackColor = True
        '
        'testserial
        '
        resources.ApplyResources(Me.testserial, "testserial")
        Me.testserial.Name = "testserial"
        Me.testserial.UseVisualStyleBackColor = True
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'comportdrp
        '
        Me.comportdrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comportdrp.FormattingEnabled = True
        resources.ApplyResources(Me.comportdrp, "comportdrp")
        Me.comportdrp.Name = "comportdrp"
        '
        'ButtonSingleMeasure
        '
        resources.ApplyResources(Me.ButtonSingleMeasure, "ButtonSingleMeasure")
        Me.ButtonSingleMeasure.Name = "ButtonSingleMeasure"
        Me.ButtonSingleMeasure.UseVisualStyleBackColor = True
        '
        'Main
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
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
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
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
