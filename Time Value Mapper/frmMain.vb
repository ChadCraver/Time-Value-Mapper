' Time Value Mapper by Chad J. Craver for JP Recovery Services, Inc. 2018

Imports Microsoft.Office.Interop

Public Class frmMain
    ' ==== Global Variables ====

    Public graph As GraphingGrid
    Private DragDrop_RowToMove As DataGridViewRow, DragDrop_RowIndexFromMouseDown As Integer

    ' ==== Form Routines ====

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        graph = New GraphingGrid()

        With cmbTemplates.Items
            .Add("Default")
            .Add("Bold")
            .Add("Elegant")
            .Add("Meadow")
            .Add("Minimal")
            .Add("Modern")
            .Add("Muted")
            .Add("Neon")
            .Add("Pastel")
            .Add("Vibrant")
        End With
        cmbTemplates.SelectedIndex = 0
        cmbTemplates_SelectedIndexChanged(Nothing, Nothing)

        TabControl1.Height = Me.Height * 0.93
        TabControl1.Width = Me.Width * 0.97
        DataSource.Width = Me.Width * 0.97
        DataSource.Height = Me.Height * 0.84
        pnlGraphingArea.Width = TabControl1.Width * 0.73 + 30
        pnlGraphingArea.Height = TabControl1.Height * 0.92
        picStaticGraph.Width = pnlGraphingArea.Width
        picStaticGraph.Height = pnlGraphingArea.Height
        grpbxGraphColors.Location = New Point(pnlGraphingArea.Width + 20, grpbxGraphColors.Location.Y)
        grpbxGraphDataSummary.Location = New Point(pnlGraphingArea.Width + 20, grpbxGraphDataSummary.Location.Y)
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        picStaticGraph.Visible = False
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ExportGraph()
    End Sub

    Private Sub lblColor_BNVA_Dynamic_DoubleClick(sender As Object, e As EventArgs) Handles lblColor_Background_Dynamic.DoubleClick, lblColor_VA_Dynamic.DoubleClick, lblColor_NVA_Dynamic.DoubleClick, lblColor_BNVA_Dynamic.DoubleClick
        Dim lblToUpdate As Label = sender
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            lblToUpdate.BackColor = ColorDialog1.Color
        End If

        If sender Is lblColor_Background_Dynamic Then
            pnlGraphingArea.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub btnGenerateGraph_Click(sender As Object, e As EventArgs) Handles btnGenerateGraph.Click
        If CalculateTotalProcessTime() Then
            TabControl1.SelectTab(1)
            TabPage_Graph.Focus()
            graph.Clear()
            DrawGraph()
            UpdateDataSummary()
        End If
    End Sub

    Private Sub cmbTemplates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTemplates.SelectedIndexChanged
        Select Case cmbTemplates.SelectedIndex
            Case 0 ' Default
                lblColor_VA_Dynamic.BackColor = Color.CornflowerBlue
                lblColor_NVA_Dynamic.BackColor = Color.DimGray
                lblColor_BNVA_Dynamic.BackColor = Color.LightGray
                lblColor_Background_Dynamic.BackColor = Color.White
            Case 1 ' Bold
                lblColor_VA_Dynamic.BackColor = Color.OrangeRed
                lblColor_NVA_Dynamic.BackColor = Color.Gold
                lblColor_BNVA_Dynamic.BackColor = Color.Violet
                lblColor_Background_Dynamic.BackColor = Color.White
            Case 2 ' Elegant
                lblColor_VA_Dynamic.BackColor = Color.MediumPurple
                lblColor_NVA_Dynamic.BackColor = Color.DarkMagenta
                lblColor_BNVA_Dynamic.BackColor = Color.Khaki
                lblColor_Background_Dynamic.BackColor = Color.White
            Case 3 ' Meadow
                lblColor_VA_Dynamic.BackColor = Color.Gold
                lblColor_NVA_Dynamic.BackColor = Color.RoyalBlue
                lblColor_BNVA_Dynamic.BackColor = Color.SeaGreen
                lblColor_Background_Dynamic.BackColor = Color.White
            Case 4 ' Minimal
                lblColor_VA_Dynamic.BackColor = Color.RosyBrown
                lblColor_NVA_Dynamic.BackColor = Color.SlateBlue
                lblColor_BNVA_Dynamic.BackColor = Color.SlateGray
                lblColor_Background_Dynamic.BackColor = Color.White
            Case 5 ' Modern
                lblColor_VA_Dynamic.BackColor = Color.DarkOrange
                lblColor_NVA_Dynamic.BackColor = Color.SteelBlue
                lblColor_BNVA_Dynamic.BackColor = Color.SkyBlue
                lblColor_Background_Dynamic.BackColor = Color.White
            Case 6 ' Muted
                lblColor_VA_Dynamic.BackColor = Color.DarkKhaki
                lblColor_NVA_Dynamic.BackColor = Color.Tan
                lblColor_BNVA_Dynamic.BackColor = Color.Silver
                lblColor_Background_Dynamic.BackColor = Color.White
            Case 7 ' Neon
                lblColor_VA_Dynamic.BackColor = Color.MediumSpringGreen
                lblColor_NVA_Dynamic.BackColor = Color.DarkViolet
                lblColor_BNVA_Dynamic.BackColor = Color.DeepPink
                lblColor_Background_Dynamic.BackColor = Color.White
            Case 8 ' Pastel
                lblColor_VA_Dynamic.BackColor = Color.LightSteelBlue
                lblColor_NVA_Dynamic.BackColor = Color.LightCoral
                lblColor_BNVA_Dynamic.BackColor = Color.LightGreen
                lblColor_Background_Dynamic.BackColor = Color.White
            Case 9 ' Vibrant
                lblColor_VA_Dynamic.BackColor = Color.LightSeaGreen
                lblColor_NVA_Dynamic.BackColor = Color.OrangeRed
                lblColor_BNVA_Dynamic.BackColor = Color.Gold
                lblColor_Background_Dynamic.BackColor = Color.White
        End Select
    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Not IsNothing(graph) Then
            graph.Clear()
        End If

        TabControl1.Height = Me.Height * 0.93
        TabControl1.Width = Me.Width * 0.97
        DataSource.Width = Me.Width * 0.97
        DataSource.Height = Me.Height * 0.84
        pnlGraphingArea.Width = TabControl1.Width * 0.73 + 30
        pnlGraphingArea.Height = TabControl1.Height * 0.92
        picStaticGraph.Width = pnlGraphingArea.Width
        picStaticGraph.Height = pnlGraphingArea.Height
        grpbxGraphColors.Location = New Point(pnlGraphingArea.Width + 20, grpbxGraphColors.Location.Y)
        grpbxGraphDataSummary.Location = New Point(pnlGraphingArea.Width + 20, grpbxGraphDataSummary.Location.Y)

        If Not IsNothing(graph) Then
            graph = New GraphingGrid
        End If
    End Sub

    ' ==== MenuStrip Routines ====

    Private Sub MenuStrip_Data_Paint(sender As Object, e As PaintEventArgs) Handles MenuStrip_Data.Paint
        Dim graphic As Graphics = e.Graphics
        Dim rect As New Rectangle(0, 0, MenuStrip_Data.Width, MenuStrip_Data.Height)
        Dim brush As New System.Drawing.SolidBrush(Color.FromKnownColor(KnownColor.Control))

        graphic.FillRectangle(brush, rect)
        brush.Dispose()
    End Sub

    Private Sub ClearDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearDataToolStripMenuItem.Click
        Dim msg As MsgBoxResult = MsgBox($"Are you sure you want to clear all data?{vbCrLf}{vbCrLf}This cannot be undone.", vbYesNo, "Clear Data")
        If msg = vbYes Then
            DataSource.Rows.Clear()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub XLSXFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XLSXFileToolStripMenuItem.Click
        ' Clear grid.
        Dim msg As MsgBoxResult
        If DataSource.Rows(0).Cells(0).Value <> "" Then
            msg = MsgBox($"To import data, the current grid must be cleared. Are you sure you want to clear all data?{vbCrLf}{vbCrLf}This cannot be undone.", vbYesNo, "Clear Data")
            If msg = vbYes Then
                DataSource.Rows.Clear()
            Else
                Exit Sub
            End If
        End If
        ShowImportForm("XLSX Files (*.xlsx)|*.xlsx", "Select an XLSX file to import.", False, True)
    End Sub

    Private Sub CSVFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CSVFileToolStripMenuItem.Click
        ' Clear grid.
        Dim msg As MsgBoxResult
        If DataSource.Rows(0).Cells(0).Value <> "" Then
            msg = MsgBox($"To import data, the current grid must be cleared. Are you sure you want to clear all data?{vbCrLf}{vbCrLf}This cannot be undone.", vbYesNo, "Clear Data")
            If msg = vbYes Then
                DataSource.Rows.Clear()
            Else
                Exit Sub
            End If
        End If
        ShowImportForm("CSV Files (*.csv)|*.csv", "Select CSV File to Import Data", False, True)
    End Sub

    ' ==== Data Export Routines ====

    Private Sub ExportAsTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportAsTextToolStripMenuItem.Click
        ' Check if there is data to export.
        Dim DataToExport As Boolean = False
        With DataSource
            If .Rows(0).Cells(0).Value <> "" Then DataToExport = True

            If Not DataToExport Then
                Exit Sub
            Else
                With SaveFileDialog1
                    .Title = "Save Data as Delimited Text File"
                    .FileName = $"ExportedData_{Format(Now, "MM.dd.yy")}.txt"
                    .AddExtension = True
                    .DefaultExt = ".txt"
                    .Filter = "Text Files|*.txt"
                End With
                If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                    Dim strFilePath As String = SaveFileDialog1.FileName
                    Dim ExportFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(strFilePath, False)

                    ' Add headers
                    ExportFile.Write("""Step/Action Number"";")
                    ExportFile.Write("""Step/Action Description"";")
                    ExportFile.Write("""Step/Action Start Time"";")
                    ExportFile.Write("""Step/Action End Time"";")
                    ExportFile.Write("""Total Step/Action Time"";")
                    ExportFile.Write("""Step Classification"";")

                    For Each row As DataGridViewRow In .Rows
                        If row.Index = .RowCount - 1 Then Exit For
                        For Each cell As DataGridViewCell In row.Cells
                            ExportFile.Write($"""{cell.Value}"";")
                        Next
                    Next

                    ExportFile.Close()
                End If
            End If
        End With
    End Sub

    Private Sub AsCSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsCSVToolStripMenuItem.Click
        ' Check if there is data to export.
        Dim DataToExport As Boolean = False
        With DataSource
            If .Rows(0).Cells(0).Value <> "" Then DataToExport = True

            If Not DataToExport Then
                Exit Sub
            Else
                With SaveFileDialog1
                    .Title = "Save Data as Comma-Delimited File"
                    .FileName = $"ExportedData_{Format(Now, "MM.dd.yy")}.csv"
                    .AddExtension = True
                    .DefaultExt = ".csv"
                    .Filter = "Comma-Delimited (CSV)|*.csv"
                End With
                If SaveFileDialog1.ShowDialog = DialogResult.OK And SaveFileDialog1.FileName <> "" Then
                    Dim strFilePath As String = SaveFileDialog1.FileName
                    Dim iExcel As New Excel.Application
                    Dim xlWorkbook As Excel.Workbook = iExcel.Workbooks.Add
                    Dim xlWorksheet As Excel.Worksheet = xlWorkbook.Worksheets(1)

                    ' Add headers
                    With xlWorksheet
                        .Range("A1").Value = "Step/Action Number"
                        .Range("B1").Value = "Step/Action Description"
                        .Range("C1").Value = "Step/Action Start Time"
                        .Range("D1").Value = "Step/Action End Time"
                        .Range("E1").Value = "Total Step/Action Time"
                        .Range("F1").Value = "Step Classification"
                    End With

                    For Each row As DataGridViewRow In .Rows
                        If row.Index = .RowCount - 1 Then Exit For
                        For X = 1 To 1000
                            If IsNothing(xlWorksheet.Cells(X, 1).Value) Then
                                For Y = 0 To 5
                                    xlWorksheet.Cells(X, (Y + 1)).Value = row.Cells(Y).Value
                                Next
                                Exit For
                            End If
                        Next
                    Next

                    xlWorkbook.SaveAs(SaveFileDialog1.FileName, Excel.XlFileFormat.xlCSV)
                    xlWorkbook.Close()
                    iExcel.Quit()
                    ReleaseMemory(iExcel)
                End If
            End If
        End With
    End Sub

    Private Sub AsXLSXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsXLSXToolStripMenuItem.Click
        ' Check if there is data to export.
        Dim DataToExport As Boolean = False
        With DataSource
            If .Rows(0).Cells(0).Value <> "" Then DataToExport = True

            If Not DataToExport Then
                Exit Sub
            Else
                With SaveFileDialog1
                    .Title = "Save Data as Excel Workbook"
                    .FileName = $"ExportedData_{Format(Now, "MM.dd.yy")}.xlsx"
                    .AddExtension = True
                    .DefaultExt = ".xlsx"
                    .Filter = "Excel Workbook (.xlsx)|*.xlsx"
                End With
                If SaveFileDialog1.ShowDialog = DialogResult.OK And SaveFileDialog1.FileName <> "" Then
                    Dim strFilePath As String = SaveFileDialog1.FileName
                    Dim iExcel As New Excel.Application
                    Dim xlWorkbook As Excel.Workbook = iExcel.Workbooks.Add
                    Dim xlWorksheet As Excel.Worksheet = xlWorkbook.Worksheets(1)

                    ' Add headers
                    With xlWorksheet
                        .Range("A1").Value = "Step/Action Number"
                        .Range("B1").Value = "Step/Action Description"
                        .Range("C1").Value = "Step/Action Start Time"
                        .Range("D1").Value = "Step/Action End Time"
                        .Range("E1").Value = "Total Step/Action Time"
                        .Range("F1").Value = "Step Classification"
                    End With

                    For Each row As DataGridViewRow In .Rows
                        If row.Index = .RowCount - 1 Then Exit For
                        For X = 1 To 1000
                            If IsNothing(xlWorksheet.Cells(X, 1).Value) Then
                                For Y = 0 To 5
                                    xlWorksheet.Cells(X, (Y + 1)).Value = row.Cells(Y).Value
                                Next
                                Exit For
                            End If
                        Next
                    Next

                    xlWorkbook.SaveAs(SaveFileDialog1.FileName)
                    xlWorkbook.Close()
                    iExcel.Quit()
                    ReleaseMemory(iExcel)
                End If
            End If
        End With
    End Sub

    ' ==== Data Import Routines ====

    Public Sub ShowImportForm(ByVal Filter As String, ByVal Title As String, ByVal MultiSelect As Boolean, ByVal CheckFileExists As Boolean)
        With frmImportFile.OpenFileDialog1
            .Filter = Filter
            .Multiselect = MultiSelect
            .Title = Title
            .CheckFileExists = CheckFileExists
            .FileName = ""
        End With

        frmImportFile.Show()
    End Sub

    Public Shared Sub BeingImport(ByVal FileName As String, ByVal HasHeaders As Boolean)
        Dim ImportedDataTable As DataTable = ImportXLSXToDataGrid(FileName, HasHeaders)
        Dim row As DataGridViewRow
        With frmMain.DataSource
            For X = 0 To ImportedDataTable.Rows.Count - 1
                row = New DataGridViewRow
                row.CreateCells(frmMain.DataSource)
                row.SetValues(ImportedDataTable.Rows(X).Item(0).ToString, ImportedDataTable.Rows(X).Item(1).ToString, ImportedDataTable.Rows(X).Item(2).ToString, ImportedDataTable.Rows(X).Item(3).ToString, ImportedDataTable.Rows(X).Item(4).ToString, ImportedDataTable.Rows(X).Item(5).ToString)
                If .Rows.Count = 0 Then
                    .Rows.Insert(0, row)
                Else
                    .Rows.Insert(.Rows.Count - 1, row)
                End If
                .Update()
                Application.DoEvents()
            Next
        End With
        ImportedDataTable = Nothing
    End Sub

    Public Shared Function CreateDataTable() As DataTable
        ' Creates a 6 column table.
        Dim table As DataTable = New DataTable("ImportedData")
        Dim column As DataColumn

        ' Column 1
        column = New DataColumn()
        column.DataType = Type.GetType("System.Int32")
        column.ColumnName = "StepNumber"
        column.ReadOnly = False
        column.Unique = False

        ' Add the column to the table.
        table.Columns.Add(column)

        ' Column 2
        column = New DataColumn()
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "StepAction"
        column.ReadOnly = False
        column.Unique = False

        ' Add the column to the table.
        table.Columns.Add(column)

        ' Column 3
        column = New DataColumn()
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "StepStartTime"
        column.ReadOnly = False
        column.Unique = False

        ' Add the column to the table.
        table.Columns.Add(column)

        ' Column 4
        column = New DataColumn()
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "StepEndTime"
        column.ReadOnly = False
        column.Unique = False

        ' Add the column to the table.
        table.Columns.Add(column)

        ' Column 5
        column = New DataColumn()
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "StepTotalTime"
        column.ReadOnly = False
        column.Unique = False

        ' Add the column to the table.
        table.Columns.Add(column)

        ' Column 6
        column = New DataColumn()
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "StepClass"
        column.ReadOnly = False
        column.Unique = False

        ' Add the column to the table.
        table.Columns.Add(column)

        Return table
    End Function

    Public Shared Function ImportXLSXToDataGrid(ByVal FilePath As String, ByVal HasHeaders As Boolean) As DataTable
        Dim iExcel As New Excel.Application
        Dim xlWorkbook As Excel.Workbook = iExcel.Workbooks.Open(FilePath)
        Dim xlWorksheet As Excel.Worksheet = xlWorkbook.Worksheets(1)
        Dim intStartingRow As Integer, intEndRow As Integer
        Dim Output_DataTable As DataTable = CreateDataTable()
        Dim row As DataRow

        ' Set starting row of workbook.
        If Not HasHeaders Then
            intStartingRow = 1
        Else
            intStartingRow = 2
        End If

        ' Iterate through workbook.
        With xlWorksheet
            For X = intStartingRow To 10000
                If CStr(.Range("A" & X).Value) = "" Then
                    intEndRow = X - 1
                    Exit For
                End If
                Application.DoEvents()
            Next

            For X = intStartingRow To intEndRow
                row = Output_DataTable.NewRow
                row("StepNumber") = CInt(.Cells(X, 1).Value)
                row("StepAction") = CStr(.Cells(X, 2).Value)
                row("StepStartTime") = CStr(.Cells(X, 3).Value)
                row("StepEndTime") = CStr(.Cells(X, 4).Value)
                row("StepTotalTime") = CStr(.Cells(X, 5).Value)
                row("StepClass") = CStr(.Cells(X, 6).Value)
                Output_DataTable.Rows.Add(row)
            Next
        End With

        xlWorkbook.Close()
        iExcel.Quit()
        ReleaseMemory(iExcel)
        Return Output_DataTable
    End Function

    ' ==== Drag and Drop Functionality for DataGridView ====

    Private Sub DataSource_MouseDown(sender As Object, e As MouseEventArgs) Handles DataSource.MouseDown
        Try
            If DataSource.SelectedRows.Count = 1 Then
                If e.Button = MouseButtons.Left Then
                    DragDrop_RowToMove = DataSource.SelectedRows(0)
                    DragDrop_RowIndexFromMouseDown = DataSource.SelectedRows(0).Index
                    DataSource.DoDragDrop(DragDrop_RowToMove, DragDropEffects.Move)
                End If
            End If
        Catch ex As Exception
            MsgBox($"Encountered an error during DataSource_MouseDown event.{vbCrLf}{vbCrLf}{ex.HResult} - {ex.Message}", vbOKOnly + vbCritical, "Error!")
        End Try
    End Sub

    Private Sub DataSource_DragEnter(sender As Object, e As DragEventArgs) Handles DataSource.DragEnter
        If DataSource.SelectedRows.Count > 0 Then
            e.Effect = DragDropEffects.Move
        End If
    End Sub

    Private Sub DataSource_DragDrop(sender As Object, e As DragEventArgs) Handles DataSource.DragDrop
        Dim RowIndexOfItemUnderMouseToDrop As Integer
        Dim clientPoint As Point = DataSource.PointToClient(New Point(e.X, e.Y))
        RowIndexOfItemUnderMouseToDrop = DataSource.HitTest(clientPoint.X, clientPoint.Y).RowIndex

        If RowIndexOfItemUnderMouseToDrop < 0 Or DragDrop_RowIndexFromMouseDown < 0 Then Exit Sub
        If e.Effect = DragDropEffects.Move Then
            Try
                DataSource.Rows.RemoveAt(DragDrop_RowIndexFromMouseDown)
                DataSource.Rows.Insert(RowIndexOfItemUnderMouseToDrop, DragDrop_RowToMove)
            Catch ex As System.InvalidOperationException
                Exit Sub
            End Try
        End If
    End Sub

    ' ==== Graph Routines ====

    Public Sub DrawGraph()
        picStaticGraph.Visible = False
        picStaticGraph.SendToBack()
        pnlGraphingArea.BringToFront()
        pnlGraphingArea.CreateGraphics.Clear(Color.White)

        If CDec(lblTotalTimeInHours_Dynamic.Text) = 0 Then
            graph.Draw(pnlGraphingArea.Width)
        Else
            graph.Draw(Math.Round(pnlGraphingArea.Width / (CDec(lblTotalTimeInHours_Dynamic.Text) / 24), 0, MidpointRounding.ToEven))
        End If
    End Sub

    Public Function GetGraphBitmap() As Bitmap
        Dim tmpImage As New Bitmap(pnlGraphingArea.Width, pnlGraphingArea.Height)
        For Each ctrl As Control In pnlGraphingArea.Controls
            If ctrl.GetType Is GetType(Label) Then
                Dim lbl As Label = ctrl
                lbl.BringToFront()
            End If
        Next
        Using g As Graphics = Graphics.FromImage(tmpImage)
            g.CopyFromScreen(pnlGraphingArea.PointToScreen(New Point(0, 0)), New Point(0, 0), New Size(pnlGraphingArea.Width, pnlGraphingArea.Height))
        End Using

        Return tmpImage
    End Function

    Private Sub ToggleControlsForExportImage(ByVal Visible As Boolean)
        lblColor_Background_Static.Visible = Visible
        lblColor_Background_Dynamic.Visible = Visible
        lblKey_InstructionsToChangeColor.Visible = Visible
        lblKeyTemplates.Visible = Visible
        cmbTemplates.Visible = Visible

        Me.Refresh()
    End Sub

    Public Function GetExportBitmap() As Bitmap
        ToggleControlsForExportImage(False)

        Dim tmpImage As New Bitmap(pnlGraphingArea.Width + grpbxGraphDataSummary.Width + 30, pnlGraphingArea.Height)
        Using g As Graphics = Graphics.FromImage(tmpImage)
            g.CopyFromScreen(pnlGraphingArea.PointToScreen(New Point(0, 0)), New Point(0, 0), New Size(pnlGraphingArea.Width + grpbxGraphDataSummary.Width + 30, pnlGraphingArea.Height))
        End Using

        Return tmpImage
    End Function

    Public Sub ExportGraph()
        Dim tmpImg As New Bitmap(GetExportBitmap)
        With SaveFileDialog1
            .Title = "Export a Graph"
            .Filter = "JPEG (.jpg)|*.jpg|PNG (.png)|*.png"
            .AddExtension = True
            .FileName = $"ExportedTimeValueMap_{Format(Now, "MM.dd.yy")}.jpg"
            .DefaultExt = ".jpg"
        End With
        If SaveFileDialog1.ShowDialog = DialogResult.OK And SaveFileDialog1.FileName <> "" Then
            tmpImg.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)

            MsgBox($"File saved to: {SaveFileDialog1.FileName}", vbOKOnly + vbInformation)
        End If
        ToggleControlsForExportImage(True)
    End Sub

    ' ==== Data Analysis Routines ====

    Private Function FormatTotalProcessTime(ByVal TotalProcessTime As String) As String
        If InStr(TotalProcessTime, ",") = 0 Then
            If TotalProcessTime Like "* day" Or TotalProcessTime Like "* hour" Or TotalProcessTime Like "* minute" Then
                Return TotalProcessTime & "s"
            End If
        End If

        Return $"INVALID_FORMAT: {TotalProcessTime}"
    End Function

    Public Shared Function CalculateTotalProcessTime() As Boolean
        Dim decTotalProcessTimeAsHours As Decimal = 0.0
        Dim days As Decimal, hrs As Decimal, mins As Decimal, strTotalTime() As String

        With frmMain.DataSource
            For Each row As DataGridViewRow In .Rows
                days = 0
                hrs = 0
                mins = 0
                ' Ensure each record has a total time calculation.
                If row.Cells(4).Value = "" Then ' Total time field is blank.
                    If row.Cells(2).Value <> "" And row.Cells(3).Value <> "" Then ' Start and end time fields are not blank.
                        row.Cells(4).Value = $"{Math.Round(DateDiff(DateInterval.Minute, CDate(row.Cells(2).Value), CDate(row.Cells(3).Value), FirstDayOfWeek.Monday), 0, MidpointRounding.AwayFromZero)} minutes"

                        ' Add the total time calculation to the running total.
                        decTotalProcessTimeAsHours += (Math.Round(DateDiff(DateInterval.Minute, CDate(row.Cells(2).Value), CDate(row.Cells(3).Value), FirstDayOfWeek.Monday) / 60, 1, MidpointRounding.AwayFromZero))
                    End If
                Else
                    If row.Cells(4).Value Like "*days*" Or row.Cells(4).Value Like "*hours*" Or row.Cells(4).Value Like "*minutes*" Then
                        strTotalTime = Split(row.Cells(4).Value, ", ")
                        For X = LBound(strTotalTime) To UBound(strTotalTime)
                            If InStr(strTotalTime(X), " days") > 0 Then
                                days = CInt(Replace(strTotalTime(X), " days", "")) * 24
                            ElseIf InStr(strTotalTime(X), " hours") > 0 Then
                                hrs = CInt(Replace(strTotalTime(X), " hours", ""))
                            ElseIf InStr(strTotalTime(X), " minutes") > 0 Then
                                mins = CDec(Replace(strTotalTime(X), " minutes", "")) / 60
                            End If
                        Next
                        decTotalProcessTimeAsHours += Math.Round(days + hrs + mins, 1, MidpointRounding.AwayFromZero)
                    Else
                        MsgBox($"While calculating the total process time for each step, a value was encountered that could not be converted to a number.
This is likely due to a data entry error in an imported set of data. All ""Total Process Time"" fields should follow the pattern of:

""# days, # hours, # minutes""

This error occurred at step {row.Cells(0).Value}. Please correct the data and try again.", vbOKOnly + vbCritical, "Error!")
                        Return False
                        Exit Function
                    End If
                End If
            Next

            frmMain.lblTotalTimeInHours_Dynamic.Text = Math.Round(decTotalProcessTimeAsHours, 1)
            Return True
        End With
    End Function

    Public Shared Function ConvertProcessTimeToHours(ByVal ProcessTime As String) As Decimal
        Dim TotalProcessTime As Decimal = 0.0
        If InStr(ProcessTime, ",") > 0 Then
            Dim arrPTime() As String = Split(ProcessTime, ", ")
            For X = LBound(arrPTime) To UBound(arrPTime)
                Select Case True
                    Case InStr(arrPTime(X), " days") > 0
                        TotalProcessTime += (CDec(Replace(arrPTime(X), " days", "")) * 24)
                    Case InStr(arrPTime(X), " hours") > 0
                        TotalProcessTime += CDec(Replace(arrPTime(X), " hours", ""))
                    Case InStr(arrPTime(X), " minutes") > 0
                        TotalProcessTime += (CDec(Replace(arrPTime(X), " minutes", "")) / 60)
                End Select
            Next
        Else
            Select Case True
                Case InStr(ProcessTime, " days") > 0
                    TotalProcessTime += (CDec(Replace(ProcessTime, " days", "")) * 24)
                Case InStr(ProcessTime, " hours") > 0
                    TotalProcessTime += CDec(Replace(ProcessTime, " hours", ""))
                Case InStr(ProcessTime, " minutes") > 0
                    TotalProcessTime += (CDec(Replace(ProcessTime, " minutes", "")) / 60)
            End Select
        End If

        Return TotalProcessTime
    End Function

    Public Shared Sub UpdateDataSummary()
        If CDec(frmMain.lblTotalTimeInHours_Dynamic.Text) = 0 Then Exit Sub

        Dim TotalTime As Decimal = CDec(frmMain.lblTotalTimeInHours_Dynamic.Text)
        Dim TotalVATime As Decimal
        Dim TotalNVATime As Decimal
        Dim TotalBNVATime As Decimal
        Dim TotalVA_BNVATime As Decimal
        Dim PercentVATime As Decimal
        Dim PercentNVATime As Decimal
        Dim PercentBNVATime As Decimal
        Dim PercentNVA_BNVATime As Decimal

        ' Total Records
        frmMain.lblTotalRecords_Dynamic.Text = frmMain.DataSource.Rows.Count - 1

        ' Get total time values.
        For Each row As DataGridViewRow In frmMain.DataSource.Rows
            Select Case row.Cells(5).Value
                Case "VA"
                    TotalVATime += Math.Round(ConvertProcessTimeToHours(row.Cells(4).Value), 1, MidpointRounding.ToEven)
                Case "NVA"
                    TotalNVATime += Math.Round(ConvertProcessTimeToHours(row.Cells(4).Value), 1, MidpointRounding.ToEven)
                Case "BNVA"
                    TotalBNVATime += Math.Round(ConvertProcessTimeToHours(row.Cells(4).Value), 1, MidpointRounding.ToEven)
            End Select
        Next

        TotalVA_BNVATime = TotalVATime + TotalBNVATime
        PercentVATime = Math.Round((TotalVATime / TotalTime) * 100, 1, MidpointRounding.ToEven)
        PercentNVATime = Math.Round((TotalNVATime / TotalTime) * 100, 1, MidpointRounding.ToEven)
        PercentBNVATime = Math.Round((TotalBNVATime / TotalTime) * 100, 1, MidpointRounding.ToEven)
        PercentNVA_BNVATime = Math.Round(((TotalNVATime + TotalBNVATime) / TotalTime) * 100, 1, MidpointRounding.ToEven)

        ' Update labels.
        With frmMain
            .lblTotalVATime_Dynamic.Text = TotalVATime
            .lblTotalNVATime_Dynamic.Text = TotalNVATime
            .lblTotalBNVATime_Dynamic.Text = TotalBNVATime
            .lblTotalVAAndBNVATime_Dynamic.Text = TotalVA_BNVATime
            .lblPercentValueTime_Dynamic.Text = PercentVATime & " %"
            .lblPercentNVATime_Dynamic.Text = PercentNVATime & " %"
            .lblPercentBNVATime_Dynamic.Text = PercentBNVATime & " %"
            .lblPercentTotalNVAAndBNVA_Dynamic.Text = PercentNVA_BNVATime & " %"
        End With
    End Sub

    ' ==== Memory Cleanup ====

    Public Shared Sub ReleaseMemory(ByVal obj As Object)
        Try
            Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Class

Public Class DrawingPoint
    Private _x As Integer, _y As Integer

    Public Sub New(ByVal X As Integer, ByVal Y As Integer)
        _x = X
        _y = Y
    End Sub

    Public Property X() As Integer
        Get
            Return _x
        End Get
        Set(value As Integer)
            _x = value
        End Set
    End Property

    Public Property Y() As Integer
        Get
            Return _y
        End Get
        Set(value As Integer)
            _y = value
        End Set
    End Property

    Public Sub DrawPoint(Optional DrawColor As Color = Nothing)
        If DrawColor = Nothing Then DrawColor = Color.Black
        Dim graphics As Graphics = frmMain.pnlGraphingArea.CreateGraphics
        Dim pen As New Pen(DrawColor, 1)
        graphics.DrawRectangle(pen, _x, _y, 1, 1)
    End Sub

    Public Function GetDistanceTo(ByVal Pt2 As DrawingPoint) As Integer
        Return Math.Sqrt(Math.Pow((Pt2.X - _x), 2) + Math.Pow((Pt2.Y - _y), 2))
    End Function
End Class

Public Class GraphingGrid
    Private _width As Integer, _height As Integer, _midline_YValue As Integer, _EndPointOfPreviousRecord As DrawingPoint

    Public Property EndPointOfPreviousRecord As DrawingPoint
        Get
            Return _EndPointOfPreviousRecord
        End Get
        Set(value As DrawingPoint)
            _EndPointOfPreviousRecord = value
        End Set
    End Property

    Public Sub New()
        _width = frmMain.pnlGraphingArea.Width - 5
        _height = frmMain.pnlGraphingArea.Height
        _midline_YValue = frmMain.pnlGraphingArea.Height / 2
        _EndPointOfPreviousRecord = Nothing
    End Sub

    Public Sub Draw(ByVal TotalTimeInHours As Integer)
        ' Reset Last End Point Variable
        _EndPointOfPreviousRecord = Nothing

        frmMain.pnlGraphingArea.CreateGraphics.Clear(frmMain.lblColor_Background_Dynamic.BackColor)

        ' Draw X Axis
        DrawMidLine(TotalTimeInHours)

        ' Draw each record.
        For Each row As DataGridViewRow In frmMain.DataSource.Rows
            If Len(row.Cells(5).Value) > 0 Then
                DrawSingleRecord(EndPointOfPreviousRecord, row.Cells(5).Value, frmMain.ConvertProcessTimeToHours(row.Cells(4).Value), row.Cells(0).Value, row.Cells(1).Value)
            End If
            Application.DoEvents()
        Next

        DrawLegend()

        ' Produce and display the static image.
        frmMain.picStaticGraph.Image = frmMain.GetGraphBitmap()
        frmMain.picStaticGraph.Visible = True
    End Sub

    Public Property Width()
        Get
            Return _width
        End Get
        Set(value)
            _width = value
        End Set
    End Property

    Public Property Height()
        Get
            Return _height
        End Get
        Set(value)
            _height = value
        End Set
    End Property

    Public Sub DrawMidLine(ByVal TotalTimeInHours As Integer)
        Dim pt As DrawingPoint
        Dim counter As Integer = 1
        Dim fontSize As Single = 12

        If (TotalTimeInHours / 10) > 100 Then
            fontSize = 7
        End If

        For X = 1 To _width
            pt = New DrawingPoint(X, _midline_YValue)
            pt.DrawPoint()
            If X = 1 Or X = _width Then
                For Y = -25 To -1
                    pt = New DrawingPoint(X, _midline_YValue - Y)
                    pt.DrawPoint()
                    pt = New DrawingPoint(X, _midline_YValue + Y)
                    pt.DrawPoint()
                Next
            End If

            If frmMain.chkbxShowDays.Checked Then
                If X Mod TotalTimeInHours = 0 Then
                    counter += 1
                    For Z = -25 To -1
                        pt = New DrawingPoint(X, _midline_YValue - Z)
                        pt.DrawPoint()
                        pt = New DrawingPoint(X, _midline_YValue + Z)
                        pt.DrawPoint()
                    Next
                End If
                Dim g As Graphics = frmMain.pnlGraphingArea.CreateGraphics
                Dim brush As New SolidBrush(Color.Black)
                If X = 1 Then
                    g.DrawString("Day 1", New Font("Arial", fontSize), brush, X, _midline_YValue + 10, New Drawing.StringFormat)
                End If
                If X Mod TotalTimeInHours = 0 Then
                    g.DrawString($"Day {counter}", New Font("Arial", fontSize), brush, X - 50, _midline_YValue + 10, New Drawing.StringFormat)
                End If
                If X = _width Then
                    g.DrawString($"Day {counter + 1}", New Font("Arial", fontSize), brush, X - 50, _midline_YValue + 10, New Drawing.StringFormat)
                End If
            End If

            If frmMain.chkbxShowHours.Checked Then
                Dim hr As Decimal = Math.Round((TotalTimeInHours / 24), 0)
                If X Mod hr = 0 Then
                    Dim Q As Integer = X - 5
                    For Z = -10 To -1
                        pt = New DrawingPoint(Q, _midline_YValue - Z)
                        pt.DrawPoint()
                        pt = New DrawingPoint(Q, _midline_YValue + Z)
                        pt.DrawPoint()
                    Next
                End If
            End If

            Application.DoEvents()
        Next

    End Sub

    Public Function DrawSingleRecord(ByVal StartPoint As DrawingPoint, ByVal Classification As String, ByVal Duration As Double, ByVal StepNumber As String, ByVal Description As String) As Boolean
        Dim DrawColor As Color
        Dim Y_Coord As Integer, BarHeight As Integer

        If Duration = 0 Then
            Return False
            Exit Function
        Else
            Duration = Duration * (_width / CInt(frmMain.lblTotalTimeInHours_Dynamic.Text))
        End If

        Select Case Classification
            Case "VA"
                DrawColor = frmMain.lblColor_VA_Dynamic.BackColor
                BarHeight = 200
                Y_Coord = (_midline_YValue - BarHeight) - 10
            Case "BNVA"
                DrawColor = frmMain.lblColor_BNVA_Dynamic.BackColor
                BarHeight = 100
                Y_Coord = _midline_YValue + 20
            Case "NVA"
                DrawColor = frmMain.lblColor_NVA_Dynamic.BackColor
                BarHeight = 100
                Y_Coord = (_midline_YValue + (BarHeight / 2)) + 75
            Case Else
                MsgBox($"While attempting to graph a record, an invalid Classification (""{Classification}"") was encountered. Valid classifications are ""VA"", ""NVA"", and ""BNVA"". Please correct the data and try again.", vbOKOnly + vbCritical, "Error!")
                Return False
                Exit Function
        End Select

        If IsNothing(_EndPointOfPreviousRecord) Then
            _EndPointOfPreviousRecord = New DrawingPoint(1, Y_Coord)
        Else
            _EndPointOfPreviousRecord = New DrawingPoint(_EndPointOfPreviousRecord.X, Y_Coord)
        End If

        Dim record As New Label
        Dim recordTip As New ToolTip
        With record
            .Parent = frmMain.pnlGraphingArea
            .Text = StepNumber
            .BackColor = DrawColor
            .Width = Duration
            .Height = BarHeight
            If Duration < 10 Then
                .BorderStyle = BorderStyle.None
            Else
                .BorderStyle = BorderStyle.FixedSingle
            End If
            .Location = New Point(_EndPointOfPreviousRecord.X, _EndPointOfPreviousRecord.Y)
        End With

        frmMain.pnlGraphingArea.Controls.Add(record)

        With recordTip
            .SetToolTip(record, Description)
        End With


        _EndPointOfPreviousRecord = New DrawingPoint(_EndPointOfPreviousRecord.X + Duration, Y_Coord)

        Return True
    End Function

    Public Sub DrawLegend()
        Dim g As Graphics = frmMain.pnlGraphingArea.CreateGraphics
        Dim brush As New SolidBrush(Color.White)
        Dim pen As New Pen(Color.Black)
        Dim rect As New Rectangle(1, frmMain.pnlGraphingArea.Height - 100, frmMain.pnlGraphingArea.Width - 5, 100)
        Dim YModifier As Integer = 0
        Dim XModifier As Integer = 0
        Dim recordCounter As Integer = 0

        g.FillRectangle(brush, rect)
        g.DrawRectangle(pen, rect)

        brush = New SolidBrush(Color.Black)
        g.DrawString("Legend", New Font("Arial", 8, FontStyle.Underline), brush, 3, frmMain.pnlGraphingArea.Height - 100)

        For Each row As DataGridViewRow In frmMain.DataSource.Rows
            If row.Index <> frmMain.DataSource.Rows.Count - 1 Then
                recordCounter += 1
                brush = New SolidBrush(Color.Black)
                g.DrawString($"{row.Cells(0).Value} - {row.Cells(1).Value} ({row.Cells(5).Value})", New Font("Arial", 8), brush, 13 + XModifier, frmMain.pnlGraphingArea.Height - 80 + YModifier)
                YModifier += 15
                If recordCounter = 5 Then
                    XModifier += 225
                    YModifier = 0
                    recordCounter = 0
                End If
            End If
        Next
    End Sub

    Public Sub Clear(Optional ByVal BackgroundColor As Color = Nothing)
        If IsNothing(BackgroundColor) Then BackgroundColor = Color.White
        frmMain.pnlGraphingArea.CreateGraphics.Clear(BackgroundColor)

        For Each ctrl As Control In frmMain.pnlGraphingArea.Controls
            If ctrl.GetType Is GetType(Label) Then
                frmMain.pnlGraphingArea.Controls.Remove(ctrl)
                ctrl.Dispose()
            End If
        Next

        frmMain.picStaticGraph.Visible = False
        frmMain.picStaticGraph.Image = Nothing
    End Sub
End Class