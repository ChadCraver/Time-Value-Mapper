<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.contextmnu_DataSourceRowControl = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuItem_InsertRow = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TabPage_Graph = New System.Windows.Forms.TabPage()
        Me.chkbxShowDays = New System.Windows.Forms.CheckBox()
        Me.chkbxShowHours = New System.Windows.Forms.CheckBox()
        Me.btnGenerateGraph = New System.Windows.Forms.Button()
        Me.grpbxGraphColors = New System.Windows.Forms.GroupBox()
        Me.cmbTemplates = New System.Windows.Forms.ComboBox()
        Me.lblKeyTemplates = New System.Windows.Forms.Label()
        Me.lblKey_InstructionsToChangeColor = New System.Windows.Forms.Label()
        Me.lblColor_Background_Dynamic = New System.Windows.Forms.Label()
        Me.lblColor_Background_Static = New System.Windows.Forms.Label()
        Me.lblColor_BNVA_Dynamic = New System.Windows.Forms.Label()
        Me.lblColor_NVA_Dynamic = New System.Windows.Forms.Label()
        Me.lblColor_VA_Dynamic = New System.Windows.Forms.Label()
        Me.lblColor_BNVA_Static = New System.Windows.Forms.Label()
        Me.lblColor_NVA_Static = New System.Windows.Forms.Label()
        Me.lblColor_VA_Static = New System.Windows.Forms.Label()
        Me.grpbxGraphDataSummary = New System.Windows.Forms.GroupBox()
        Me.lblTotalRecords_Static = New System.Windows.Forms.Label()
        Me.lblTotalRecords_Dynamic = New System.Windows.Forms.Label()
        Me.lblPercentBNVATime_Dynamic = New System.Windows.Forms.Label()
        Me.lblTotalBNVATime_Dynamic = New System.Windows.Forms.Label()
        Me.lblPercentNVATime_Dynamic = New System.Windows.Forms.Label()
        Me.lblTotalNVATime_Dynamic = New System.Windows.Forms.Label()
        Me.lblPercentTotalNVAAndBNVA_Dynamic = New System.Windows.Forms.Label()
        Me.lblTotalVAAndBNVATime_Dynamic = New System.Windows.Forms.Label()
        Me.lblPercentValueTime_Dynamic = New System.Windows.Forms.Label()
        Me.lblTotalVATime_Dynamic = New System.Windows.Forms.Label()
        Me.lblTotalTimeInHours_Dynamic = New System.Windows.Forms.Label()
        Me.lblPercentBNVATime_Static = New System.Windows.Forms.Label()
        Me.lblTotalBNVATime_Static = New System.Windows.Forms.Label()
        Me.lblPercentNVATime_Static = New System.Windows.Forms.Label()
        Me.lblTotalNVATime_Static = New System.Windows.Forms.Label()
        Me.lblPercentTotalNVAAndBNVA_Static = New System.Windows.Forms.Label()
        Me.lblTotalVAAndBNVATime_Static = New System.Windows.Forms.Label()
        Me.lblPercentValueTime_Static = New System.Windows.Forms.Label()
        Me.lblTotalVATime_Static = New System.Windows.Forms.Label()
        Me.lblTotalTimeInHours_Static = New System.Windows.Forms.Label()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.pnlGraphingArea = New System.Windows.Forms.Panel()
        Me.picStaticGraph = New System.Windows.Forms.PictureBox()
        Me.TabPage_Data = New System.Windows.Forms.TabPage()
        Me.DataSource = New System.Windows.Forms.DataGridView()
        Me.Column_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_B = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_C = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_E = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip_Data = New System.Windows.Forms.MenuStrip()
        Me.ImportDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportFromXLSXFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CSVFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XLSXFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsXLSXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportAsTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.contextmnu_DataSourceRowControl.SuspendLayout()
        Me.TabPage_Graph.SuspendLayout()
        Me.grpbxGraphColors.SuspendLayout()
        Me.grpbxGraphDataSummary.SuspendLayout()
        Me.pnlGraphingArea.SuspendLayout()
        CType(Me.picStaticGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Data.SuspendLayout()
        CType(Me.DataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip_Data.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'contextmnu_DataSourceRowControl
        '
        Me.contextmnu_DataSourceRowControl.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItem_InsertRow})
        Me.contextmnu_DataSourceRowControl.Name = "contextmnu_DataSourceRowControl"
        Me.contextmnu_DataSourceRowControl.Size = New System.Drawing.Size(130, 26)
        '
        'mnuItem_InsertRow
        '
        Me.mnuItem_InsertRow.Name = "mnuItem_InsertRow"
        Me.mnuItem_InsertRow.Size = New System.Drawing.Size(129, 22)
        Me.mnuItem_InsertRow.Text = "Insert Row"
        '
        'TabPage_Graph
        '
        Me.TabPage_Graph.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage_Graph.Controls.Add(Me.chkbxShowDays)
        Me.TabPage_Graph.Controls.Add(Me.chkbxShowHours)
        Me.TabPage_Graph.Controls.Add(Me.btnGenerateGraph)
        Me.TabPage_Graph.Controls.Add(Me.grpbxGraphColors)
        Me.TabPage_Graph.Controls.Add(Me.grpbxGraphDataSummary)
        Me.TabPage_Graph.Controls.Add(Me.btnExport)
        Me.TabPage_Graph.Controls.Add(Me.pnlGraphingArea)
        Me.TabPage_Graph.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Graph.Name = "TabPage_Graph"
        Me.TabPage_Graph.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Graph.Size = New System.Drawing.Size(1160, 623)
        Me.TabPage_Graph.TabIndex = 1
        Me.TabPage_Graph.Text = "Graph"
        '
        'chkbxShowDays
        '
        Me.chkbxShowDays.AutoSize = True
        Me.chkbxShowDays.Checked = True
        Me.chkbxShowDays.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbxShowDays.Location = New System.Drawing.Point(772, 10)
        Me.chkbxShowDays.Name = "chkbxShowDays"
        Me.chkbxShowDays.Size = New System.Drawing.Size(80, 17)
        Me.chkbxShowDays.TabIndex = 6
        Me.chkbxShowDays.Text = "Show Days"
        Me.chkbxShowDays.UseVisualStyleBackColor = True
        '
        'chkbxShowHours
        '
        Me.chkbxShowHours.AutoSize = True
        Me.chkbxShowHours.Location = New System.Drawing.Point(682, 10)
        Me.chkbxShowHours.Name = "chkbxShowHours"
        Me.chkbxShowHours.Size = New System.Drawing.Size(84, 17)
        Me.chkbxShowHours.TabIndex = 6
        Me.chkbxShowHours.Text = "Show Hours"
        Me.chkbxShowHours.UseVisualStyleBackColor = True
        '
        'btnGenerateGraph
        '
        Me.btnGenerateGraph.Location = New System.Drawing.Point(6, 6)
        Me.btnGenerateGraph.Name = "btnGenerateGraph"
        Me.btnGenerateGraph.Size = New System.Drawing.Size(96, 23)
        Me.btnGenerateGraph.TabIndex = 5
        Me.btnGenerateGraph.Text = "Generate Graph"
        Me.btnGenerateGraph.UseVisualStyleBackColor = True
        '
        'grpbxGraphColors
        '
        Me.grpbxGraphColors.Controls.Add(Me.cmbTemplates)
        Me.grpbxGraphColors.Controls.Add(Me.lblKeyTemplates)
        Me.grpbxGraphColors.Controls.Add(Me.lblKey_InstructionsToChangeColor)
        Me.grpbxGraphColors.Controls.Add(Me.lblColor_Background_Dynamic)
        Me.grpbxGraphColors.Controls.Add(Me.lblColor_Background_Static)
        Me.grpbxGraphColors.Controls.Add(Me.lblColor_BNVA_Dynamic)
        Me.grpbxGraphColors.Controls.Add(Me.lblColor_NVA_Dynamic)
        Me.grpbxGraphColors.Controls.Add(Me.lblColor_VA_Dynamic)
        Me.grpbxGraphColors.Controls.Add(Me.lblColor_BNVA_Static)
        Me.grpbxGraphColors.Controls.Add(Me.lblColor_NVA_Static)
        Me.grpbxGraphColors.Controls.Add(Me.lblColor_VA_Static)
        Me.grpbxGraphColors.Location = New System.Drawing.Point(861, 38)
        Me.grpbxGraphColors.Name = "grpbxGraphColors"
        Me.grpbxGraphColors.Size = New System.Drawing.Size(293, 238)
        Me.grpbxGraphColors.TabIndex = 4
        Me.grpbxGraphColors.TabStop = False
        Me.grpbxGraphColors.Text = "Key"
        '
        'cmbTemplates
        '
        Me.cmbTemplates.FormattingEnabled = True
        Me.cmbTemplates.Location = New System.Drawing.Point(97, 64)
        Me.cmbTemplates.Name = "cmbTemplates"
        Me.cmbTemplates.Size = New System.Drawing.Size(137, 21)
        Me.cmbTemplates.TabIndex = 4
        '
        'lblKeyTemplates
        '
        Me.lblKeyTemplates.AutoSize = True
        Me.lblKeyTemplates.Location = New System.Drawing.Point(23, 67)
        Me.lblKeyTemplates.Name = "lblKeyTemplates"
        Me.lblKeyTemplates.Size = New System.Drawing.Size(59, 13)
        Me.lblKeyTemplates.TabIndex = 3
        Me.lblKeyTemplates.Text = "Templates:"
        '
        'lblKey_InstructionsToChangeColor
        '
        Me.lblKey_InstructionsToChangeColor.Location = New System.Drawing.Point(7, 20)
        Me.lblKey_InstructionsToChangeColor.Name = "lblKey_InstructionsToChangeColor"
        Me.lblKey_InstructionsToChangeColor.Size = New System.Drawing.Size(244, 30)
        Me.lblKey_InstructionsToChangeColor.TabIndex = 2
        Me.lblKey_InstructionsToChangeColor.Text = "Double click the box next to each label to change the associated color."
        '
        'lblColor_Background_Dynamic
        '
        Me.lblColor_Background_Dynamic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblColor_Background_Dynamic.Location = New System.Drawing.Point(150, 200)
        Me.lblColor_Background_Dynamic.Name = "lblColor_Background_Dynamic"
        Me.lblColor_Background_Dynamic.Size = New System.Drawing.Size(84, 23)
        Me.lblColor_Background_Dynamic.TabIndex = 1
        '
        'lblColor_Background_Static
        '
        Me.lblColor_Background_Static.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor_Background_Static.Location = New System.Drawing.Point(45, 200)
        Me.lblColor_Background_Static.Name = "lblColor_Background_Static"
        Me.lblColor_Background_Static.Size = New System.Drawing.Size(101, 23)
        Me.lblColor_Background_Static.TabIndex = 0
        Me.lblColor_Background_Static.Text = "Background"
        Me.lblColor_Background_Static.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColor_BNVA_Dynamic
        '
        Me.lblColor_BNVA_Dynamic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblColor_BNVA_Dynamic.Location = New System.Drawing.Point(150, 167)
        Me.lblColor_BNVA_Dynamic.Name = "lblColor_BNVA_Dynamic"
        Me.lblColor_BNVA_Dynamic.Size = New System.Drawing.Size(84, 23)
        Me.lblColor_BNVA_Dynamic.TabIndex = 1
        '
        'lblColor_NVA_Dynamic
        '
        Me.lblColor_NVA_Dynamic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblColor_NVA_Dynamic.Location = New System.Drawing.Point(150, 133)
        Me.lblColor_NVA_Dynamic.Name = "lblColor_NVA_Dynamic"
        Me.lblColor_NVA_Dynamic.Size = New System.Drawing.Size(84, 23)
        Me.lblColor_NVA_Dynamic.TabIndex = 1
        '
        'lblColor_VA_Dynamic
        '
        Me.lblColor_VA_Dynamic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblColor_VA_Dynamic.Location = New System.Drawing.Point(150, 99)
        Me.lblColor_VA_Dynamic.Name = "lblColor_VA_Dynamic"
        Me.lblColor_VA_Dynamic.Size = New System.Drawing.Size(84, 23)
        Me.lblColor_VA_Dynamic.TabIndex = 1
        '
        'lblColor_BNVA_Static
        '
        Me.lblColor_BNVA_Static.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor_BNVA_Static.Location = New System.Drawing.Point(84, 167)
        Me.lblColor_BNVA_Static.Name = "lblColor_BNVA_Static"
        Me.lblColor_BNVA_Static.Size = New System.Drawing.Size(60, 23)
        Me.lblColor_BNVA_Static.TabIndex = 0
        Me.lblColor_BNVA_Static.Text = "BNVA"
        Me.lblColor_BNVA_Static.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColor_NVA_Static
        '
        Me.lblColor_NVA_Static.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor_NVA_Static.Location = New System.Drawing.Point(84, 133)
        Me.lblColor_NVA_Static.Name = "lblColor_NVA_Static"
        Me.lblColor_NVA_Static.Size = New System.Drawing.Size(60, 23)
        Me.lblColor_NVA_Static.TabIndex = 0
        Me.lblColor_NVA_Static.Text = "NVA"
        Me.lblColor_NVA_Static.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColor_VA_Static
        '
        Me.lblColor_VA_Static.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor_VA_Static.Location = New System.Drawing.Point(84, 99)
        Me.lblColor_VA_Static.Name = "lblColor_VA_Static"
        Me.lblColor_VA_Static.Size = New System.Drawing.Size(60, 23)
        Me.lblColor_VA_Static.TabIndex = 0
        Me.lblColor_VA_Static.Text = "VA"
        Me.lblColor_VA_Static.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpbxGraphDataSummary
        '
        Me.grpbxGraphDataSummary.Controls.Add(Me.lblTotalRecords_Static)
        Me.grpbxGraphDataSummary.Controls.Add(Me.lblTotalRecords_Dynamic)
        Me.grpbxGraphDataSummary.Controls.Add(Me.lblPercentBNVATime_Dynamic)
        Me.grpbxGraphDataSummary.Controls.Add(Me.lblTotalBNVATime_Dynamic)
        Me.grpbxGraphDataSummary.Controls.Add(Me.lblPercentNVATime_Dynamic)
        Me.grpbxGraphDataSummary.Controls.Add(Me.lblTotalNVATime_Dynamic)
        Me.grpbxGraphDataSummary.Controls.Add(Me.lblPercentTotalNVAAndBNVA_Dynamic)
        Me.grpbxGraphDataSummary.Controls.Add(Me.lblTotalVAAndBNVATime_Dynamic)
        Me.grpbxGraphDataSummary.Controls.Add(Me.lblPercentValueTime_Dynamic)
        Me.grpbxGraphDataSummary.Controls.Add(Me.lblTotalVATime_Dynamic)
        Me.grpbxGraphDataSummary.Controls.Add(Me.lblTotalTimeInHours_Dynamic)
        Me.grpbxGraphDataSummary.Controls.Add(Me.lblPercentBNVATime_Static)
        Me.grpbxGraphDataSummary.Controls.Add(Me.lblTotalBNVATime_Static)
        Me.grpbxGraphDataSummary.Controls.Add(Me.lblPercentNVATime_Static)
        Me.grpbxGraphDataSummary.Controls.Add(Me.lblTotalNVATime_Static)
        Me.grpbxGraphDataSummary.Controls.Add(Me.lblPercentTotalNVAAndBNVA_Static)
        Me.grpbxGraphDataSummary.Controls.Add(Me.lblTotalVAAndBNVATime_Static)
        Me.grpbxGraphDataSummary.Controls.Add(Me.lblPercentValueTime_Static)
        Me.grpbxGraphDataSummary.Controls.Add(Me.lblTotalVATime_Static)
        Me.grpbxGraphDataSummary.Controls.Add(Me.lblTotalTimeInHours_Static)
        Me.grpbxGraphDataSummary.Location = New System.Drawing.Point(861, 334)
        Me.grpbxGraphDataSummary.Name = "grpbxGraphDataSummary"
        Me.grpbxGraphDataSummary.Size = New System.Drawing.Size(293, 283)
        Me.grpbxGraphDataSummary.TabIndex = 3
        Me.grpbxGraphDataSummary.TabStop = False
        Me.grpbxGraphDataSummary.Text = "Data Summary"
        '
        'lblTotalRecords_Static
        '
        Me.lblTotalRecords_Static.AutoSize = True
        Me.lblTotalRecords_Static.Location = New System.Drawing.Point(6, 24)
        Me.lblTotalRecords_Static.Name = "lblTotalRecords_Static"
        Me.lblTotalRecords_Static.Size = New System.Drawing.Size(129, 13)
        Me.lblTotalRecords_Static.TabIndex = 1
        Me.lblTotalRecords_Static.Text = "Total Number of Records:"
        '
        'lblTotalRecords_Dynamic
        '
        Me.lblTotalRecords_Dynamic.AutoSize = True
        Me.lblTotalRecords_Dynamic.Location = New System.Drawing.Point(228, 24)
        Me.lblTotalRecords_Dynamic.Name = "lblTotalRecords_Dynamic"
        Me.lblTotalRecords_Dynamic.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalRecords_Dynamic.TabIndex = 0
        Me.lblTotalRecords_Dynamic.Text = "0"
        '
        'lblPercentBNVATime_Dynamic
        '
        Me.lblPercentBNVATime_Dynamic.AutoSize = True
        Me.lblPercentBNVATime_Dynamic.Location = New System.Drawing.Point(228, 258)
        Me.lblPercentBNVATime_Dynamic.Name = "lblPercentBNVATime_Dynamic"
        Me.lblPercentBNVATime_Dynamic.Size = New System.Drawing.Size(13, 13)
        Me.lblPercentBNVATime_Dynamic.TabIndex = 0
        Me.lblPercentBNVATime_Dynamic.Text = "0"
        '
        'lblTotalBNVATime_Dynamic
        '
        Me.lblTotalBNVATime_Dynamic.AutoSize = True
        Me.lblTotalBNVATime_Dynamic.Location = New System.Drawing.Point(228, 232)
        Me.lblTotalBNVATime_Dynamic.Name = "lblTotalBNVATime_Dynamic"
        Me.lblTotalBNVATime_Dynamic.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalBNVATime_Dynamic.TabIndex = 0
        Me.lblTotalBNVATime_Dynamic.Text = "0"
        '
        'lblPercentNVATime_Dynamic
        '
        Me.lblPercentNVATime_Dynamic.AutoSize = True
        Me.lblPercentNVATime_Dynamic.Location = New System.Drawing.Point(228, 206)
        Me.lblPercentNVATime_Dynamic.Name = "lblPercentNVATime_Dynamic"
        Me.lblPercentNVATime_Dynamic.Size = New System.Drawing.Size(13, 13)
        Me.lblPercentNVATime_Dynamic.TabIndex = 0
        Me.lblPercentNVATime_Dynamic.Text = "0"
        '
        'lblTotalNVATime_Dynamic
        '
        Me.lblTotalNVATime_Dynamic.AutoSize = True
        Me.lblTotalNVATime_Dynamic.Location = New System.Drawing.Point(228, 180)
        Me.lblTotalNVATime_Dynamic.Name = "lblTotalNVATime_Dynamic"
        Me.lblTotalNVATime_Dynamic.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalNVATime_Dynamic.TabIndex = 0
        Me.lblTotalNVATime_Dynamic.Text = "0"
        '
        'lblPercentTotalNVAAndBNVA_Dynamic
        '
        Me.lblPercentTotalNVAAndBNVA_Dynamic.AutoSize = True
        Me.lblPercentTotalNVAAndBNVA_Dynamic.Location = New System.Drawing.Point(228, 154)
        Me.lblPercentTotalNVAAndBNVA_Dynamic.Name = "lblPercentTotalNVAAndBNVA_Dynamic"
        Me.lblPercentTotalNVAAndBNVA_Dynamic.Size = New System.Drawing.Size(13, 13)
        Me.lblPercentTotalNVAAndBNVA_Dynamic.TabIndex = 0
        Me.lblPercentTotalNVAAndBNVA_Dynamic.Text = "0"
        '
        'lblTotalVAAndBNVATime_Dynamic
        '
        Me.lblTotalVAAndBNVATime_Dynamic.AutoSize = True
        Me.lblTotalVAAndBNVATime_Dynamic.Location = New System.Drawing.Point(228, 128)
        Me.lblTotalVAAndBNVATime_Dynamic.Name = "lblTotalVAAndBNVATime_Dynamic"
        Me.lblTotalVAAndBNVATime_Dynamic.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalVAAndBNVATime_Dynamic.TabIndex = 0
        Me.lblTotalVAAndBNVATime_Dynamic.Text = "0"
        '
        'lblPercentValueTime_Dynamic
        '
        Me.lblPercentValueTime_Dynamic.AutoSize = True
        Me.lblPercentValueTime_Dynamic.Location = New System.Drawing.Point(228, 102)
        Me.lblPercentValueTime_Dynamic.Name = "lblPercentValueTime_Dynamic"
        Me.lblPercentValueTime_Dynamic.Size = New System.Drawing.Size(13, 13)
        Me.lblPercentValueTime_Dynamic.TabIndex = 0
        Me.lblPercentValueTime_Dynamic.Text = "0"
        '
        'lblTotalVATime_Dynamic
        '
        Me.lblTotalVATime_Dynamic.AutoSize = True
        Me.lblTotalVATime_Dynamic.Location = New System.Drawing.Point(228, 76)
        Me.lblTotalVATime_Dynamic.Name = "lblTotalVATime_Dynamic"
        Me.lblTotalVATime_Dynamic.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalVATime_Dynamic.TabIndex = 0
        Me.lblTotalVATime_Dynamic.Text = "0"
        '
        'lblTotalTimeInHours_Dynamic
        '
        Me.lblTotalTimeInHours_Dynamic.AutoSize = True
        Me.lblTotalTimeInHours_Dynamic.Location = New System.Drawing.Point(228, 50)
        Me.lblTotalTimeInHours_Dynamic.Name = "lblTotalTimeInHours_Dynamic"
        Me.lblTotalTimeInHours_Dynamic.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalTimeInHours_Dynamic.TabIndex = 0
        Me.lblTotalTimeInHours_Dynamic.Text = "0"
        '
        'lblPercentBNVATime_Static
        '
        Me.lblPercentBNVATime_Static.AutoSize = True
        Me.lblPercentBNVATime_Static.Location = New System.Drawing.Point(6, 258)
        Me.lblPercentBNVATime_Static.Name = "lblPercentBNVATime_Static"
        Me.lblPercentBNVATime_Static.Size = New System.Drawing.Size(105, 13)
        Me.lblPercentBNVATime_Static.TabIndex = 0
        Me.lblPercentBNVATime_Static.Text = "Percent BNVA Time:"
        '
        'lblTotalBNVATime_Static
        '
        Me.lblTotalBNVATime_Static.AutoSize = True
        Me.lblTotalBNVATime_Static.Location = New System.Drawing.Point(6, 232)
        Me.lblTotalBNVATime_Static.Name = "lblTotalBNVATime_Static"
        Me.lblTotalBNVATime_Static.Size = New System.Drawing.Size(92, 13)
        Me.lblTotalBNVATime_Static.TabIndex = 0
        Me.lblTotalBNVATime_Static.Text = "Total BNVA Time:"
        '
        'lblPercentNVATime_Static
        '
        Me.lblPercentNVATime_Static.AutoSize = True
        Me.lblPercentNVATime_Static.Location = New System.Drawing.Point(6, 206)
        Me.lblPercentNVATime_Static.Name = "lblPercentNVATime_Static"
        Me.lblPercentNVATime_Static.Size = New System.Drawing.Size(98, 13)
        Me.lblPercentNVATime_Static.TabIndex = 0
        Me.lblPercentNVATime_Static.Text = "Percent NVA Time:"
        '
        'lblTotalNVATime_Static
        '
        Me.lblTotalNVATime_Static.AutoSize = True
        Me.lblTotalNVATime_Static.Location = New System.Drawing.Point(6, 180)
        Me.lblTotalNVATime_Static.Name = "lblTotalNVATime_Static"
        Me.lblTotalNVATime_Static.Size = New System.Drawing.Size(108, 13)
        Me.lblTotalNVATime_Static.TabIndex = 0
        Me.lblTotalNVATime_Static.Text = "Total NVA Time (hrs):"
        '
        'lblPercentTotalNVAAndBNVA_Static
        '
        Me.lblPercentTotalNVAAndBNVA_Static.AutoSize = True
        Me.lblPercentTotalNVAAndBNVA_Static.Location = New System.Drawing.Point(6, 154)
        Me.lblPercentTotalNVAAndBNVA_Static.Name = "lblPercentTotalNVAAndBNVA_Static"
        Me.lblPercentTotalNVAAndBNVA_Static.Size = New System.Drawing.Size(139, 13)
        Me.lblPercentTotalNVAAndBNVA_Static.TabIndex = 0
        Me.lblPercentTotalNVAAndBNVA_Static.Text = "Percent NVA + BNVA Time:"
        '
        'lblTotalVAAndBNVATime_Static
        '
        Me.lblTotalVAAndBNVATime_Static.AutoSize = True
        Me.lblTotalVAAndBNVATime_Static.Location = New System.Drawing.Point(6, 128)
        Me.lblTotalVAAndBNVATime_Static.Name = "lblTotalVAAndBNVATime_Static"
        Me.lblTotalVAAndBNVATime_Static.Size = New System.Drawing.Size(141, 13)
        Me.lblTotalVAAndBNVATime_Static.TabIndex = 0
        Me.lblTotalVAAndBNVATime_Static.Text = "Total VA + BNVA Time (hrs):"
        '
        'lblPercentValueTime_Static
        '
        Me.lblPercentValueTime_Static.AutoSize = True
        Me.lblPercentValueTime_Static.Location = New System.Drawing.Point(6, 102)
        Me.lblPercentValueTime_Static.Name = "lblPercentValueTime_Static"
        Me.lblPercentValueTime_Static.Size = New System.Drawing.Size(90, 13)
        Me.lblPercentValueTime_Static.TabIndex = 0
        Me.lblPercentValueTime_Static.Text = "Percent VA Time:"
        '
        'lblTotalVATime_Static
        '
        Me.lblTotalVATime_Static.AutoSize = True
        Me.lblTotalVATime_Static.Location = New System.Drawing.Point(6, 76)
        Me.lblTotalVATime_Static.Name = "lblTotalVATime_Static"
        Me.lblTotalVATime_Static.Size = New System.Drawing.Size(100, 13)
        Me.lblTotalVATime_Static.TabIndex = 0
        Me.lblTotalVATime_Static.Text = "Total VA Time (hrs):"
        '
        'lblTotalTimeInHours_Static
        '
        Me.lblTotalTimeInHours_Static.AutoSize = True
        Me.lblTotalTimeInHours_Static.Location = New System.Drawing.Point(6, 50)
        Me.lblTotalTimeInHours_Static.Name = "lblTotalTimeInHours_Static"
        Me.lblTotalTimeInHours_Static.Size = New System.Drawing.Size(86, 13)
        Me.lblTotalTimeInHours_Static.TabIndex = 0
        Me.lblTotalTimeInHours_Static.Text = "Total Time (hrs): "
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(138, 6)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 1
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'pnlGraphingArea
        '
        Me.pnlGraphingArea.BackColor = System.Drawing.Color.White
        Me.pnlGraphingArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlGraphingArea.Controls.Add(Me.picStaticGraph)
        Me.pnlGraphingArea.Location = New System.Drawing.Point(6, 38)
        Me.pnlGraphingArea.Name = "pnlGraphingArea"
        Me.pnlGraphingArea.Size = New System.Drawing.Size(846, 579)
        Me.pnlGraphingArea.TabIndex = 0
        '
        'picStaticGraph
        '
        Me.picStaticGraph.BackColor = System.Drawing.Color.Transparent
        Me.picStaticGraph.Location = New System.Drawing.Point(-1, -1)
        Me.picStaticGraph.Name = "picStaticGraph"
        Me.picStaticGraph.Size = New System.Drawing.Size(846, 579)
        Me.picStaticGraph.TabIndex = 0
        Me.picStaticGraph.TabStop = False
        '
        'TabPage_Data
        '
        Me.TabPage_Data.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage_Data.Controls.Add(Me.DataSource)
        Me.TabPage_Data.Controls.Add(Me.MenuStrip_Data)
        Me.TabPage_Data.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Data.Name = "TabPage_Data"
        Me.TabPage_Data.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Data.Size = New System.Drawing.Size(1160, 623)
        Me.TabPage_Data.TabIndex = 0
        Me.TabPage_Data.Text = "Data"
        '
        'DataSource
        '
        Me.DataSource.AllowDrop = True
        Me.DataSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataSource.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_A, Me.Column_B, Me.Column_C, Me.Column_D, Me.Column_E, Me.Column_F})
        Me.DataSource.Location = New System.Drawing.Point(6, 33)
        Me.DataSource.Name = "DataSource"
        Me.DataSource.Size = New System.Drawing.Size(1148, 587)
        Me.DataSource.TabIndex = 0
        '
        'Column_A
        '
        Me.Column_A.HeaderText = "Step/Action Number"
        Me.Column_A.Name = "Column_A"
        Me.Column_A.Width = 125
        '
        'Column_B
        '
        Me.Column_B.HeaderText = "Step/Action Description"
        Me.Column_B.Name = "Column_B"
        Me.Column_B.Width = 200
        '
        'Column_C
        '
        DataGridViewCellStyle1.Format = "G"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column_C.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column_C.HeaderText = "Step/Action Start Time"
        Me.Column_C.Name = "Column_C"
        Me.Column_C.Width = 125
        '
        'Column_D
        '
        DataGridViewCellStyle2.Format = "G"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column_D.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column_D.HeaderText = "Step/Action End Time"
        Me.Column_D.Name = "Column_D"
        Me.Column_D.Width = 125
        '
        'Column_E
        '
        Me.Column_E.HeaderText = "Total Step/Action Time"
        Me.Column_E.Name = "Column_E"
        Me.Column_E.Width = 125
        '
        'Column_F
        '
        Me.Column_F.HeaderText = "Step Classification"
        Me.Column_F.Name = "Column_F"
        Me.Column_F.Width = 125
        '
        'MenuStrip_Data
        '
        Me.MenuStrip_Data.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportDataToolStripMenuItem, Me.ExportDataToolStripMenuItem, Me.ClearDataToolStripMenuItem})
        Me.MenuStrip_Data.Location = New System.Drawing.Point(3, 3)
        Me.MenuStrip_Data.Name = "MenuStrip_Data"
        Me.MenuStrip_Data.Size = New System.Drawing.Size(1154, 24)
        Me.MenuStrip_Data.TabIndex = 1
        Me.MenuStrip_Data.Text = "MenuStrip1"
        '
        'ImportDataToolStripMenuItem
        '
        Me.ImportDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportFromXLSXFileToolStripMenuItem})
        Me.ImportDataToolStripMenuItem.Name = "ImportDataToolStripMenuItem"
        Me.ImportDataToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.ImportDataToolStripMenuItem.Text = "Import Data..."
        '
        'ImportFromXLSXFileToolStripMenuItem
        '
        Me.ImportFromXLSXFileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CSVFileToolStripMenuItem, Me.XLSXFileToolStripMenuItem})
        Me.ImportFromXLSXFileToolStripMenuItem.Name = "ImportFromXLSXFileToolStripMenuItem"
        Me.ImportFromXLSXFileToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ImportFromXLSXFileToolStripMenuItem.Text = "Import from Excel"
        '
        'CSVFileToolStripMenuItem
        '
        Me.CSVFileToolStripMenuItem.Name = "CSVFileToolStripMenuItem"
        Me.CSVFileToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.CSVFileToolStripMenuItem.Text = ".CSV File"
        '
        'XLSXFileToolStripMenuItem
        '
        Me.XLSXFileToolStripMenuItem.Name = "XLSXFileToolStripMenuItem"
        Me.XLSXFileToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.XLSXFileToolStripMenuItem.Text = ".XLSX File"
        '
        'ExportDataToolStripMenuItem
        '
        Me.ExportDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToExcelToolStripMenuItem, Me.ExportAsTextToolStripMenuItem})
        Me.ExportDataToolStripMenuItem.Name = "ExportDataToolStripMenuItem"
        Me.ExportDataToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.ExportDataToolStripMenuItem.Text = "Export Data..."
        '
        'ExportToExcelToolStripMenuItem
        '
        Me.ExportToExcelToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsCSVToolStripMenuItem, Me.AsXLSXToolStripMenuItem})
        Me.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem"
        Me.ExportToExcelToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ExportToExcelToolStripMenuItem.Text = "Export To Excel"
        '
        'AsCSVToolStripMenuItem
        '
        Me.AsCSVToolStripMenuItem.Name = "AsCSVToolStripMenuItem"
        Me.AsCSVToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.AsCSVToolStripMenuItem.Text = ".CSV File"
        '
        'AsXLSXToolStripMenuItem
        '
        Me.AsXLSXToolStripMenuItem.Name = "AsXLSXToolStripMenuItem"
        Me.AsXLSXToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.AsXLSXToolStripMenuItem.Text = ".XLSX File"
        '
        'ExportAsTextToolStripMenuItem
        '
        Me.ExportAsTextToolStripMenuItem.Name = "ExportAsTextToolStripMenuItem"
        Me.ExportAsTextToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ExportAsTextToolStripMenuItem.Text = "Export As Text"
        '
        'ClearDataToolStripMenuItem
        '
        Me.ClearDataToolStripMenuItem.Name = "ClearDataToolStripMenuItem"
        Me.ClearDataToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ClearDataToolStripMenuItem.Text = "Clear Data"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_Data)
        Me.TabControl1.Controls.Add(Me.TabPage_Graph)
        Me.TabControl1.Location = New System.Drawing.Point(4, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1168, 649)
        Me.TabControl1.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 662)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip_Data
        Me.Name = "frmMain"
        Me.Text = "Time Value Mapper"
        Me.contextmnu_DataSourceRowControl.ResumeLayout(False)
        Me.TabPage_Graph.ResumeLayout(False)
        Me.TabPage_Graph.PerformLayout()
        Me.grpbxGraphColors.ResumeLayout(False)
        Me.grpbxGraphColors.PerformLayout()
        Me.grpbxGraphDataSummary.ResumeLayout(False)
        Me.grpbxGraphDataSummary.PerformLayout()
        Me.pnlGraphingArea.ResumeLayout(False)
        CType(Me.picStaticGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Data.ResumeLayout(False)
        Me.TabPage_Data.PerformLayout()
        CType(Me.DataSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip_Data.ResumeLayout(False)
        Me.MenuStrip_Data.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents contextmnu_DataSourceRowControl As ContextMenuStrip
    Friend WithEvents mnuItem_InsertRow As ToolStripMenuItem
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents TabPage_Graph As TabPage
    Friend WithEvents btnGenerateGraph As Button
    Friend WithEvents grpbxGraphColors As GroupBox
    Friend WithEvents cmbTemplates As ComboBox
    Friend WithEvents lblKeyTemplates As Label
    Friend WithEvents lblKey_InstructionsToChangeColor As Label
    Friend WithEvents lblColor_Background_Dynamic As Label
    Friend WithEvents lblColor_Background_Static As Label
    Friend WithEvents lblColor_BNVA_Dynamic As Label
    Friend WithEvents lblColor_NVA_Dynamic As Label
    Friend WithEvents lblColor_VA_Dynamic As Label
    Friend WithEvents lblColor_BNVA_Static As Label
    Friend WithEvents lblColor_NVA_Static As Label
    Friend WithEvents lblColor_VA_Static As Label
    Friend WithEvents grpbxGraphDataSummary As GroupBox
    Friend WithEvents lblTotalRecords_Static As Label
    Friend WithEvents lblTotalRecords_Dynamic As Label
    Friend WithEvents lblPercentBNVATime_Dynamic As Label
    Friend WithEvents lblTotalBNVATime_Dynamic As Label
    Friend WithEvents lblPercentNVATime_Dynamic As Label
    Friend WithEvents lblTotalNVATime_Dynamic As Label
    Friend WithEvents lblPercentTotalNVAAndBNVA_Dynamic As Label
    Friend WithEvents lblTotalVAAndBNVATime_Dynamic As Label
    Friend WithEvents lblPercentValueTime_Dynamic As Label
    Friend WithEvents lblTotalVATime_Dynamic As Label
    Friend WithEvents lblTotalTimeInHours_Dynamic As Label
    Friend WithEvents lblPercentBNVATime_Static As Label
    Friend WithEvents lblTotalBNVATime_Static As Label
    Friend WithEvents lblPercentNVATime_Static As Label
    Friend WithEvents lblTotalNVATime_Static As Label
    Friend WithEvents lblPercentTotalNVAAndBNVA_Static As Label
    Friend WithEvents lblTotalVAAndBNVATime_Static As Label
    Friend WithEvents lblPercentValueTime_Static As Label
    Friend WithEvents lblTotalVATime_Static As Label
    Friend WithEvents lblTotalTimeInHours_Static As Label
    Friend WithEvents btnExport As Button
    Friend WithEvents pnlGraphingArea As Panel
    Friend WithEvents picStaticGraph As PictureBox
    Friend WithEvents TabPage_Data As TabPage
    Friend WithEvents DataSource As DataGridView
    Friend WithEvents Column_A As DataGridViewTextBoxColumn
    Friend WithEvents Column_B As DataGridViewTextBoxColumn
    Friend WithEvents Column_C As DataGridViewTextBoxColumn
    Friend WithEvents Column_D As DataGridViewTextBoxColumn
    Friend WithEvents Column_E As DataGridViewTextBoxColumn
    Friend WithEvents Column_F As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip_Data As MenuStrip
    Friend WithEvents ImportDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportFromXLSXFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CSVFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XLSXFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsCSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsXLSXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportAsTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents chkbxShowDays As CheckBox
    Friend WithEvents chkbxShowHours As CheckBox
End Class
