Imports System.Data.OleDb
Imports System.IO

Public Class Main
#If DEBUG Then
    Public WithEvents objCa As ICa2
    Public objProbe As IProbe2
#Else
    Private objCa200 As Ca200
    Private WithEvents ObjCa As Ca
    Private objProbe As Probe
#End If
    Private isMsr As Boolean
    Private ListNo As Short
    Public Const FORMAT_SXY As String = "0.0000"
    Public Const FORMAT_LV As String = "0.0###"
    Private objDataset1 As New DataTable

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ObjCa.RemoteMode = 0
#If DEBUG Then
#Else
        objCa200 = Nothing
#End If
        ObjCa = Nothing
        objProbe = Nothing
    End Sub

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        On Error GoTo Error1
#If DEBUG Then
        Dim T As New implementCa2
        Dim TA As New implementProbe2
        objCa = T
        objProbe = TA
#Else
        objCa200 = New Ca200
        objCa200.AutoConnect()
        ObjCa = objCa200.SingleCa
        objProbe = ObjCa.SingleProbe
#End If
        ButtonCancel.Enabled = False
        ButtonMeasure.Enabled = True
        ButtonCalZero.Enabled = True
        GridInit()
        GetSerialPortNames()
        Exit Sub

Error1:
        DisplayError()
        End

    End Sub

    Private Sub DisplayError()
        Dim msg As String
        msg = "Error :" + Err.Source + vbCrLf
        msg = msg + Err.Description + vbCrLf
        msg = msg + "HR: " + (Err.Number - vbObjectError).ToString
        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub GetSerialPortNames()
        For Each sp As String In IO.Ports.SerialPort.GetPortNames
            comportdrp.Items.Add(sp)
        Next
        If comportdrp.Items.Count <> 0 Then
            comportdrp.SelectedIndex = 0
        End If
    End Sub

    Public Sub TestSerialData()
        Using com1 As Ports.SerialPort =
            My.Computer.Ports.OpenSerialPort(comportdrp.SelectedItem.ToString(), baud.Text, IO.Ports.Parity.None, 8, 1)
            com1.Write("echo Test" & Chr(10))
            Try
                com1.ReadTimeout = 5000
                Do
                    Dim Incoming As String = com1.ReadChar()
                    If Incoming Is Nothing Then
                        Exit Do
                    Else
                        Cursor.Current = Cursors.Default
                        MessageBox.Show(Incoming, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Do
                    End If
                Loop
            Catch ex As TimeoutException
                Cursor.Current = Cursors.Default
                MessageBox.Show("Error: Serial Port reply timeout.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If com1 IsNot Nothing Then com1.Close()
                Cursor.Current = Cursors.Default
            End Try
        End Using
    End Sub

    Public Sub SendSerialData(data As String)
        Using com1 As Ports.SerialPort =
        My.Computer.Ports.OpenSerialPort(comportdrp.SelectedItem.ToString(), baud.Text, IO.Ports.Parity.None, 8, 1)
            Try
                com1.Write(data & Chr(10))
            Catch ex As TimeoutException
                MessageBox.Show("Error: Serial Port write timeout.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If com1 IsNot Nothing Then com1.Close()
            End Try

        End Using
    End Sub

    Public Sub GridInit()
        Dim i As Short
        ListNo = 0

        grdDataList.Rows.Clear()
        grdDataList.ReadOnly = True
        grdDataList.RowHeadersVisible = False


        grdDataList.ColumnCount = 14

        grdDataList.ColumnHeadersVisible = True
        grdDataList.ReadOnly = True
        grdDataList.Columns(0).Name = "No"
        grdDataList.Columns(1).Name = "X"
        grdDataList.Columns(2).Name = "Y"
        grdDataList.Columns(3).Name = "Z"
        grdDataList.Columns(4).Name = "x"
        grdDataList.Columns(5).Name = "y"
        grdDataList.Columns(6).Name = "Lv"
        grdDataList.Columns(7).Name = "ud"
        grdDataList.Columns(8).Name = "vd"
        grdDataList.Columns(9).Name = "T"
        grdDataList.Columns(10).Name = "duv"
        grdDataList.Columns(11).Name = "Date"
        grdDataList.Columns(12).Name = "Time"
        grdDataList.Columns(13).Name = "cmd"

        grdDataList.Columns(0).Width = 25 'NO
        grdDataList.Columns(1).Width = 40 'X
        grdDataList.Columns(2).Width = 40 'Y
        grdDataList.Columns(3).Width = 40 'Z
        grdDataList.Columns(4).Width = 40 'x
        grdDataList.Columns(5).Width = 40 'y
        grdDataList.Columns(6).Width = 58 'Lv
        grdDataList.Columns(7).Width = 40 'ud
        grdDataList.Columns(8).Width = 40 'vd
        grdDataList.Columns(9).Width = 40 'T
        grdDataList.Columns(10).Width = 40 'duv
        grdDataList.Columns(11).Width = 70 'Date
        grdDataList.Columns(12).Width = 50 'Time
        grdDataList.Columns(13).Width = 150 'cmd
        grdDataList.Columns(0).DataPropertyName = "No"
        grdDataList.Columns(1).DataPropertyName = "X"
        grdDataList.Columns(2).DataPropertyName = "Y"
        grdDataList.Columns(3).DataPropertyName = "Z"
        grdDataList.Columns(4).DataPropertyName = "sx"
        grdDataList.Columns(5).DataPropertyName = "sy"
        grdDataList.Columns(6).DataPropertyName = "Lv"
        grdDataList.Columns(7).DataPropertyName = "ud"
        grdDataList.Columns(8).DataPropertyName = "vd"
        grdDataList.Columns(9).DataPropertyName = "T"
        grdDataList.Columns(10).DataPropertyName = "duv"
        grdDataList.Columns(11).DataPropertyName = "Date"
        grdDataList.Columns(12).DataPropertyName = "Time"
        grdDataList.Columns(13).DataPropertyName = "cmd"

        objDataset1.Columns.Add("No")
        objDataset1.Columns.Add("X")
        objDataset1.Columns.Add("Y")
        objDataset1.Columns.Add("Z")
        objDataset1.Columns.Add("sx")
        objDataset1.Columns.Add("sy")
        objDataset1.Columns.Add("Lv")
        objDataset1.Columns.Add("ud")
        objDataset1.Columns.Add("vd")
        objDataset1.Columns.Add("T")
        objDataset1.Columns.Add("duv")
        objDataset1.Columns.Add("Date")
        objDataset1.Columns.Add("Time")
        objDataset1.Columns.Add("cmd")

        i = 0
        For Each dgvc As DataGridViewColumn In grdDataList.Columns
            If i = 0 Then
                dgvc.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)
            Else
                dgvc.DefaultCellStyle.BackColor = Color.White
            End If
            dgvc.SortMode = Windows.Forms.DataGridViewColumnSortMode.NotSortable
            dgvc.Resizable = False
            i += 1
        Next
        grdDataList.MultiSelect = False
        grdDataList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grdDataList.AllowUserToAddRows = False
        grdDataList.AllowUserToResizeRows = False
        grdDataList.AllowUserToResizeColumns = True
        grdDataList.AllowUserToDeleteRows = True
        grdDataList.AutoGenerateColumns = False
        grdDataList.Columns(13).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        TimeoutSec.Text = 2000
        baud.Text = 9600
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        isMsr = False
        ButtonCancel.Enabled = False
        ButtonMeasure.Enabled = True
        ButtonCalZero.Enabled = True
    End Sub

    Private Sub ButtonSingleMeasure_Click(sender As Object, e As EventArgs) Handles ButtonSingleMeasure.Click
        On Error GoTo Error2

        isMsr = True
        ButtonCancel.Enabled = True
        ButtonMeasure.Enabled = False
        ButtonCalZero.Enabled = False
        btnloadcmd.Enabled = False
        cmdDataSave.Enabled = False

        ObjCa.Measure()
        LabelLv.Text = objProbe.Lv.ToString("##0.00")
        Labelx.Text = objProbe.sx.ToString("0.0000")
        Labely.Text = objProbe.sy.ToString("0.0000")
        SetSingleData()
        Application.DoEvents()
        ButtonCancel.Enabled = False
        ButtonMeasure.Enabled = True
        ButtonCalZero.Enabled = True
        btnloadcmd.Enabled = True
        cmdDataSave.Enabled = True
        Exit Sub

Error2:
        DisplayError()
        End

    End Sub

    Private Sub ButtonCalZero_Click(sender As Object, e As EventArgs) Handles ButtonCalZero.Click
        Dim calzero_success As Boolean = False

        While calzero_success = False
            ButtonMeasure.Enabled = False
            ButtonCalZero.Enabled = False
            ButtonSingleMeasure.Enabled = False
            Try
                ObjCa.CalZero()
                calzero_success = True
            Catch er As Exception
                DisplayError()
                If MessageBox.Show("Zero Cal Error" + vbCrLf + "Retry?", "CalZero", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
                    ObjCa.RemoteMode = 0
                    End
                End If
            End Try
        End While

        ButtonMeasure.Enabled = True
        ButtonCalZero.Enabled = True
        ButtonSingleMeasure.Enabled = True

    End Sub

    Private Sub ObjCa200_ExeCalZero() Handles ObjCa.ExeCalZero
        If MessageBox.Show("CalZero?", "CalZero", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
            Exit Sub
        End If
        ButtonMeasure.Enabled = False
        ButtonCalZero.Enabled = False

        Try
            ObjCa.CalZero()
        Catch er As Exception
            DisplayError()
        End Try

        ButtonMeasure.Enabled = True
        ButtonCalZero.Enabled = True

    End Sub

    Private Sub SetSingleData()
        Dim LisNo = objDataset1.Rows.Count
        objDataset1.Rows.Add()
        objDataset1.Rows(LisNo)(1) = objProbe.X.ToString("0.00")
        objDataset1.Rows(LisNo)(2) = objProbe.Y.ToString("0.00")
        objDataset1.Rows(LisNo)(3) = objProbe.Z.ToString("0.00")
        objDataset1.Rows(LisNo)(4) = objProbe.sx.ToString(FORMAT_SXY)
        objDataset1.Rows(LisNo)(5) = objProbe.sy.ToString(FORMAT_SXY)
        objDataset1.Rows(LisNo)(6) = objProbe.Lv.ToString(FORMAT_LV)
        objDataset1.Rows(LisNo)(7) = objProbe.ud.ToString(FORMAT_SXY)
        objDataset1.Rows(LisNo)(8) = objProbe.vd.ToString(FORMAT_SXY)
        If objProbe.T = -1 Then
            objDataset1.Rows(LisNo)(9) = "-"
        Else
            objDataset1.Rows(LisNo)(9) = objProbe.T.ToString("00000")
        End If
        If objProbe.T = -1 Then
            objDataset1.Rows(LisNo)(10) = "-"
        Else
            objDataset1.Rows(LisNo)(10) = objProbe.duv.ToString("+.000;-.000")
        End If
        objDataset1.Rows(LisNo)(11) = Today.ToString("yyyy/MM/dd")
        objDataset1.Rows(LisNo)(12) = TimeOfDay.ToString("HH:mm:ss")
        grdDataList.DataSource = objDataset1.DefaultView
        grdDataList.Refresh()
    End Sub

    Private Sub SetCMDData(LisNo As Integer)
        objDataset1.Rows(LisNo)(1) = objProbe.X.ToString("0.00")
        objDataset1.Rows(LisNo)(2) = objProbe.Y.ToString("0.00")
        objDataset1.Rows(LisNo)(3) = objProbe.Z.ToString("0.00")
        objDataset1.Rows(LisNo)(4) = objProbe.sx.ToString(FORMAT_SXY)
        objDataset1.Rows(LisNo)(5) = objProbe.sy.ToString(FORMAT_SXY)
        objDataset1.Rows(LisNo)(6) = objProbe.Lv.ToString(FORMAT_LV)
        objDataset1.Rows(LisNo)(7) = objProbe.ud.ToString(FORMAT_SXY)
        objDataset1.Rows(LisNo)(8) = objProbe.vd.ToString(FORMAT_SXY)
        If objProbe.T = -1 Then
            objDataset1.Rows(LisNo)(9) = "-"
        Else
            objDataset1.Rows(LisNo)(9) = objProbe.T.ToString("00000")
        End If
        If objProbe.T = -1 Then
            objDataset1.Rows(LisNo)(10) = "-"
        Else
            objDataset1.Rows(LisNo)(10) = objProbe.duv.ToString("+.000;-.000")
        End If
        objDataset1.Rows(LisNo)(11) = Today.ToString("yyyy/MM/dd")
        objDataset1.Rows(LisNo)(12) = TimeOfDay.ToString("HH:mm:ss")
        grdDataList.DataSource = objDataset1.DefaultView
        grdDataList.Refresh()
    End Sub

    Private Sub SaveData()
        Dim dd(600, 600) As String
        Dim i, j As Short
        Dim fm, fname As String
        Dim fnum As Short

        For i = 0 To grdDataList.RowCount - 1
            For j = 0 To 13
                If IsDBNull(grdDataList(j, i).Value) = False Then
                    dd(i, j) = grdDataList(j, i).Value
                Else
                    dd(i, j) = ""
                End If
            Next j
        Next i
        On Error Resume Next

        cmdDiagSave.FileName = ""
        cmdDiagSave.Filter = "Data Files (*.csv)|*.csv"
        cmdDiagSave.FilterIndex = 2

        If cmdDiagSave.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        Else
            fm = cmdDiagSave.FileName
            fm = fm.Substring(0, fm.IndexOf(".") + 1) & "csv"
        End If

        fname = Dir(fm, vbNormal OrElse FileAttribute.ReadOnly)
        fnum = FreeFile()
        FileOpen(fnum, fm, OpenMode.Output, OpenAccess.Write, OpenShare.Shared)
        Dim csvDelimiter As String
        csvDelimiter = ","
        Print(fnum, "No" & csvDelimiter)
        Print(fnum, "X" & csvDelimiter)
        Print(fnum, "Y" & csvDelimiter)
        Print(fnum, "Z" & csvDelimiter)
        Print(fnum, "x" & csvDelimiter)
        Print(fnum, "y" & csvDelimiter)
        Print(fnum, "Lv" & csvDelimiter)
        Print(fnum, "ud" & csvDelimiter)
        Print(fnum, "vd" & csvDelimiter)
        Print(fnum, "T" & csvDelimiter)
        Print(fnum, "duv" & csvDelimiter)
        Print(fnum, "Date" & csvDelimiter)
        Print(fnum, "Time" & csvDelimiter)
        PrintLine(fnum, "cmd")
        For i = 0 To grdDataList.RowCount - 1
            For j = 0 To 12
                Print(fnum, dd(i, j) & csvDelimiter)
            Next j
            PrintLine(fnum, dd(i, 13))
        Next i
        FileClose(fnum)
    End Sub

    Private Sub LoadData()
        cmdopen.Filter = "Data Files (*.csv)|*.csv"
        cmdopen.FilterIndex = 2
        cmdopen.RestoreDirectory = True
        If cmdopen.ShowDialog() = DialogResult.OK Then
            Try
                Dim fi As New FileInfo(cmdopen.FileName)
                Dim sConnectionStringz As String = "Provider=Microsoft.Ace.OLEDB.12.0; Data Source=" & fi.DirectoryName & "; Extended Properties='Text;HDR=YES;FMT=Delimited'"
                Dim objConn As New OleDbConnection(sConnectionStringz)
                objDataset1.Rows.Clear()
                objConn.Open()
                Dim objCmdSelect As New OleDbCommand("SELECT * FROM " & fi.Name, objConn)
                Dim objAdapter1 As New OleDbDataAdapter
                objAdapter1.SelectCommand = objCmdSelect
                objAdapter1.Fill(objDataset1)
                objAdapter1.Update(objDataset1)
                grdDataList.DataSource = objDataset1.DefaultView
                objConn.Close()
            Finally

            End Try
        End If
    End Sub

    Private Sub GrdDataList_CellMouseClick(sender As System.Object, e As DataGridViewCellMouseEventArgs) Handles grdDataList.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = grdDataList.Rows(e.RowIndex)
            LabelLv.Text = row.Cells(6).Value
            Labelx.Text = row.Cells(4).Value
            Labely.Text = row.Cells(5).Value
        End If
    End Sub

    Private Sub CmdDataSave_Click(sender As Object, e As EventArgs) Handles cmdDataSave.Click
        SaveData()
    End Sub

    Private Sub Btnloadcmd_Click(sender As Object, e As EventArgs) Handles btnloadcmd.Click
        LoadData()
    End Sub

    Private Sub Testserial_Click(sender As Object, e As EventArgs) Handles testserial.Click
        If comportdrp.Items.Count <> 0 Then
            Cursor.Current = Cursors.WaitCursor
            TestSerialData()
        End If
    End Sub

    Private Sub DetectSerial_Click(sender As Object, e As EventArgs) Handles detectSerial.Click
        comportdrp.Items.Clear()
        comportdrp.Text = ""
        GetSerialPortNames()
    End Sub

    Private Sub Runremotecmd_Click(sender As Object, e As EventArgs) Handles runremotecmd.Click
        If comportdrp.Items.Count <> 0 Then
            SendSerialData(remotecmd.Text)
            MessageBox.Show("Command write success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ButtonMeasure_Click(sender As Object, e As EventArgs) Handles ButtonMeasure.Click
        On Error GoTo Error2
        Dim i As Integer
        If comportdrp.Items.Count <> 0 Then
            If objDataset1.Rows.Count <> 0 Then
                isMsr = True
                ButtonCancel.Enabled = True
                ButtonMeasure.Enabled = False
                ButtonSingleMeasure.Enabled = False
                ButtonCalZero.Enabled = False
                btnloadcmd.Enabled = False
                cmdDataSave.Enabled = False
                For i = 0 To objDataset1.Rows.Count - 1
                    SendSerialData(objDataset1.Rows(i)(13).ToString)
                    System.Threading.Thread.Sleep(TimeoutSec.Text)
                    ObjCa.Measure()
                    LabelLv.Text = objProbe.Lv.ToString("##0.00")
                    Labelx.Text = objProbe.sx.ToString("0.0000")
                    Labely.Text = objProbe.sy.ToString("0.0000")
                    SetCMDData(i)
                    Application.DoEvents()
                    If isMsr = False Then
                        Exit For
                    End If
                Next
                ButtonCancel.Enabled = False
                ButtonMeasure.Enabled = True
                ButtonSingleMeasure.Enabled = True
                ButtonCalZero.Enabled = True
                btnloadcmd.Enabled = True
                cmdDataSave.Enabled = True
                Exit Sub
            Else
                MessageBox.Show("No command !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            MessageBox.Show("No COM Port defined !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


Error2:
        DisplayError()
        End
    End Sub

    Public Sub GrdDataList_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles grdDataList.UserDeletedRow
        objDataset1.AcceptChanges()
    End Sub

End Class