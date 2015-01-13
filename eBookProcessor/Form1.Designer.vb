<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.conMain = New System.Windows.Forms.SplitContainer()
        Me.lblDirectoryDestination = New System.Windows.Forms.Label()
        Me.lblDirectoryTarget = New System.Windows.Forms.Label()
        Me.btnBrowseDestination = New System.Windows.Forms.Button()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.btnBrowseTarget = New System.Windows.Forms.Button()
        Me.lstStatus = New System.Windows.Forms.ListBox()
        Me.conActions = New System.Windows.Forms.SplitContainer()
        Me.btnDeselectAll = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.chkDeleteAfterProcessing = New System.Windows.Forms.CheckBox()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.datFiles = New System.Windows.Forms.DataGridView()
        Me.colSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dlgDirectoryTarget = New System.Windows.Forms.FolderBrowserDialog()
        Me.dlgDirectoryDestination = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.conMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.conMain.Panel1.SuspendLayout()
        Me.conMain.Panel2.SuspendLayout()
        Me.conMain.SuspendLayout()
        CType(Me.conActions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.conActions.Panel1.SuspendLayout()
        Me.conActions.Panel2.SuspendLayout()
        Me.conActions.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.datFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'conMain
        '
        Me.conMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.conMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.conMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.conMain.IsSplitterFixed = True
        Me.conMain.Location = New System.Drawing.Point(0, 0)
        Me.conMain.Name = "conMain"
        '
        'conMain.Panel1
        '
        Me.conMain.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.conMain.Panel1.Controls.Add(Me.lblDirectoryDestination)
        Me.conMain.Panel1.Controls.Add(Me.lblDirectoryTarget)
        '
        'conMain.Panel2
        '
        Me.conMain.Panel2.Controls.Add(Me.btnBrowseDestination)
        Me.conMain.Panel2.Controls.Add(Me.btnScan)
        Me.conMain.Panel2.Controls.Add(Me.btnBrowseTarget)
        Me.conMain.Size = New System.Drawing.Size(499, 49)
        Me.conMain.SplitterDistance = 382
        Me.conMain.SplitterWidth = 2
        Me.conMain.TabIndex = 5
        '
        'lblDirectoryDestination
        '
        Me.lblDirectoryDestination.AutoSize = True
        Me.lblDirectoryDestination.Location = New System.Drawing.Point(2, 28)
        Me.lblDirectoryDestination.Name = "lblDirectoryDestination"
        Me.lblDirectoryDestination.Size = New System.Drawing.Size(152, 13)
        Me.lblDirectoryDestination.TabIndex = 1
        Me.lblDirectoryDestination.Text = "Select a destination directory..."
        '
        'lblDirectoryTarget
        '
        Me.lblDirectoryTarget.AutoSize = True
        Me.lblDirectoryTarget.Location = New System.Drawing.Point(2, 5)
        Me.lblDirectoryTarget.Name = "lblDirectoryTarget"
        Me.lblDirectoryTarget.Size = New System.Drawing.Size(128, 13)
        Me.lblDirectoryTarget.TabIndex = 0
        Me.lblDirectoryTarget.Text = "Select a target directory..."
        '
        'btnBrowseDestination
        '
        Me.btnBrowseDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseDestination.Location = New System.Drawing.Point(-1, 23)
        Me.btnBrowseDestination.Name = "btnBrowseDestination"
        Me.btnBrowseDestination.Size = New System.Drawing.Size(30, 25)
        Me.btnBrowseDestination.TabIndex = 4
        Me.btnBrowseDestination.Text = "..."
        Me.btnBrowseDestination.UseVisualStyleBackColor = True
        '
        'btnScan
        '
        Me.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScan.Location = New System.Drawing.Point(28, -1)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(92, 49)
        Me.btnScan.TabIndex = 3
        Me.btnScan.Text = "Scan"
        Me.btnScan.UseVisualStyleBackColor = True
        '
        'btnBrowseTarget
        '
        Me.btnBrowseTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseTarget.Location = New System.Drawing.Point(-1, -1)
        Me.btnBrowseTarget.Name = "btnBrowseTarget"
        Me.btnBrowseTarget.Size = New System.Drawing.Size(30, 25)
        Me.btnBrowseTarget.TabIndex = 2
        Me.btnBrowseTarget.Text = "..."
        Me.btnBrowseTarget.UseVisualStyleBackColor = True
        '
        'lstStatus
        '
        Me.lstStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lstStatus.FormattingEnabled = True
        Me.lstStatus.Location = New System.Drawing.Point(0, 284)
        Me.lstStatus.Name = "lstStatus"
        Me.lstStatus.Size = New System.Drawing.Size(499, 82)
        Me.lstStatus.TabIndex = 7
        '
        'conActions
        '
        Me.conActions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.conActions.IsSplitterFixed = True
        Me.conActions.Location = New System.Drawing.Point(0, 259)
        Me.conActions.Name = "conActions"
        '
        'conActions.Panel1
        '
        Me.conActions.Panel1.Controls.Add(Me.btnDeselectAll)
        Me.conActions.Panel1.Controls.Add(Me.btnSelectAll)
        Me.conActions.Panel1MinSize = 157
        '
        'conActions.Panel2
        '
        Me.conActions.Panel2.Controls.Add(Me.chkDeleteAfterProcessing)
        Me.conActions.Panel2.Controls.Add(Me.btnRename)
        Me.conActions.Panel2MinSize = 340
        Me.conActions.Size = New System.Drawing.Size(499, 25)
        Me.conActions.SplitterDistance = 157
        Me.conActions.SplitterWidth = 2
        Me.conActions.TabIndex = 9
        '
        'btnDeselectAll
        '
        Me.btnDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeselectAll.Location = New System.Drawing.Point(77, 0)
        Me.btnDeselectAll.Name = "btnDeselectAll"
        Me.btnDeselectAll.Size = New System.Drawing.Size(80, 25)
        Me.btnDeselectAll.TabIndex = 11
        Me.btnDeselectAll.Text = "Deselect All"
        Me.btnDeselectAll.UseVisualStyleBackColor = True
        '
        'btnSelectAll
        '
        Me.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectAll.Location = New System.Drawing.Point(0, 0)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(75, 25)
        Me.btnSelectAll.TabIndex = 10
        Me.btnSelectAll.Text = "Select All"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'chkDeleteAfterProcessing
        '
        Me.chkDeleteAfterProcessing.AutoSize = True
        Me.chkDeleteAfterProcessing.Location = New System.Drawing.Point(3, 5)
        Me.chkDeleteAfterProcessing.Name = "chkDeleteAfterProcessing"
        Me.chkDeleteAfterProcessing.Size = New System.Drawing.Size(262, 17)
        Me.chkDeleteAfterProcessing.TabIndex = 10
        Me.chkDeleteAfterProcessing.Text = "Delete directory after processing (if no more PDFs)"
        Me.chkDeleteAfterProcessing.UseVisualStyleBackColor = True
        '
        'btnRename
        '
        Me.btnRename.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRename.Location = New System.Drawing.Point(270, 0)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(70, 25)
        Me.btnRename.TabIndex = 9
        Me.btnRename.Text = "Rename"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.datFiles)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.Panel1.Size = New System.Drawing.Size(499, 210)
        Me.Panel1.TabIndex = 10
        '
        'datFiles
        '
        Me.datFiles.AllowUserToAddRows = False
        Me.datFiles.AllowUserToDeleteRows = False
        Me.datFiles.AllowUserToResizeColumns = False
        Me.datFiles.AllowUserToResizeRows = False
        Me.datFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datFiles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSelect, Me.colFile})
        Me.datFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datFiles.Location = New System.Drawing.Point(0, 2)
        Me.datFiles.Name = "datFiles"
        Me.datFiles.RowHeadersVisible = False
        Me.datFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datFiles.Size = New System.Drawing.Size(499, 206)
        Me.datFiles.TabIndex = 7
        '
        'colSelect
        '
        Me.colSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSelect.HeaderText = ""
        Me.colSelect.Name = "colSelect"
        Me.colSelect.Width = 5
        '
        'colFile
        '
        Me.colFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colFile.HeaderText = "File"
        Me.colFile.Name = "colFile"
        Me.colFile.ReadOnly = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 366)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.conActions)
        Me.Controls.Add(Me.conMain)
        Me.Controls.Add(Me.lstStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MinimumSize = New System.Drawing.Size(515, 400)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.conMain.Panel1.ResumeLayout(False)
        Me.conMain.Panel1.PerformLayout()
        Me.conMain.Panel2.ResumeLayout(False)
        CType(Me.conMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.conMain.ResumeLayout(False)
        Me.conActions.Panel1.ResumeLayout(False)
        Me.conActions.Panel2.ResumeLayout(False)
        Me.conActions.Panel2.PerformLayout()
        CType(Me.conActions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.conActions.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.datFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents conMain As System.Windows.Forms.SplitContainer
    Friend WithEvents btnScan As System.Windows.Forms.Button
    Friend WithEvents btnBrowseTarget As System.Windows.Forms.Button
    Friend WithEvents lstStatus As System.Windows.Forms.ListBox
    Friend WithEvents conActions As System.Windows.Forms.SplitContainer
    Friend WithEvents btnDeselectAll As System.Windows.Forms.Button
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents btnRename As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents datFiles As System.Windows.Forms.DataGridView
    Friend WithEvents dlgDirectoryTarget As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lblDirectoryTarget As System.Windows.Forms.Label
    Friend WithEvents colSelect As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colFile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblDirectoryDestination As System.Windows.Forms.Label
    Friend WithEvents btnBrowseDestination As System.Windows.Forms.Button
    Friend WithEvents dlgDirectoryDestination As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents chkDeleteAfterProcessing As System.Windows.Forms.CheckBox

End Class
