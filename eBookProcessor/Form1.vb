Imports System.IO
Public Class frmMain
    Dim Ready As Boolean
    Private Sub btnBrowseTarget_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowseTarget.Click
        If dlgDirectoryTarget.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblDirectoryTarget.Text = "Target: " & dlgDirectoryTarget.SelectedPath
            My.Settings.TargetDir = Replace(lblDirectoryTarget.Text, "Target: ", "")
            My.Settings.Save()
        End If
    End Sub
    Private Sub btnBrowseDestination_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowseDestination.Click
        If dlgDirectoryDestination.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblDirectoryDestination.Text = "Destination: " & dlgDirectoryDestination.SelectedPath
            My.Settings.DestinationDir = Replace(lblDirectoryDestination.Text, "Destination: ", "")
            My.Settings.Save()
        End If
    End Sub
    Private Sub btnScan_Click(sender As Object, e As System.EventArgs) Handles btnScan.Click

        Dim strDirectory As String = Replace(lblDirectoryTarget.Text, "Target: ", "")

        ' This list stores a temporary list of files found in the current directory
        Dim lstFiles As New List(Of String)

        ' This stack stores the directories to process.
        Dim stkDirectories As New Stack(Of String)

        Ready = False
        datFiles.Rows.Clear()

        ' Add the initial directory
        stkDirectories.Push(strDirectory)

        ' Continue processing for each stacked directory
        Do While (stkDirectories.Count > 0)
            ' Get top directory string
            Dim curDirectory As String = stkDirectories.Pop
            Try
                ' Add all files within current directory to temporary list
                lstFiles.AddRange(Directory.GetFiles(curDirectory, "*.*"))

                ' Loop through temporary file list, add .pdf/.epub/.mobi files to datagrid
                For Each strFileName As String In lstFiles
                    If InStr(strFileName, ".pdf") Or InStr(strFileName, ".epub") Or InStr(strFileName, ".mobi") Then datFiles.Rows.Add(New String() {False, strFileName})
                Next

                ' Loop through all subdirectories and add them to the stack.
                Dim directoryName As String
                For Each directoryName In Directory.GetDirectories(curDirectory)
                    stkDirectories.Push(directoryName)
                Next

                ' Clear temporary list of files
                lstFiles.Clear()

            Catch ex As Exception
            End Try
        Loop

        'btnSelectAll.Enabled = True
        'btnDeselectAll.Enabled = True

        Ready = True
    End Sub
    Private Sub datFiles_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datFiles.CellValueChanged
        If Ready Then
            'If datFiles.IsCurrentCellDirty Then datFiles.CommitEdit()

            If datFiles.Item(e.ColumnIndex, e.RowIndex).Value = True Then
                'btnRename.Enabled = True
            Else
                Dim intCount As Integer = 0

                For Each Row As DataGridViewRow In datFiles.Rows
                    If Row.Cells("colSelect").Value = True Then intCount += 1
                Next

                'IIf(intCount > 0, btnRename.Enabled = True, btnRename.Enabled = False)

                intCount = 0
            End If
        End If

        'IIf(datFiles.SelectedRows.Count > 0, btnRename.Enabled = True, btnRename.Enabled = False)
    End Sub
    Private Sub datFiles_CurrentCellDirtyStateChanged(sender As Object, e As System.EventArgs) Handles datFiles.CurrentCellDirtyStateChanged
        If Ready And datFiles.IsCurrentCellDirty Then datFiles.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub
    Private Sub btnSelectAll_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectAll.Click
        For Each Row As DataGridViewRow In datFiles.Rows
            Row.Cells("colSelect").Value = True
        Next
    End Sub
    Private Sub btnDeselectAll_Click(sender As Object, e As System.EventArgs) Handles btnDeselectAll.Click
        For Each Row As DataGridViewRow In datFiles.Rows
            Row.Cells("colSelect").Value = False
            'btnRename.Enabled = False
        Next
    End Sub
    Private Sub btnRename_Click(sender As System.Object, e As System.EventArgs) Handles btnRename.Click
        For Each Row As DataGridViewRow In datFiles.Rows
            Dim fullPathOld, fullPathNew, parentDirectory, fileNameOld, fileNameNew, fileType As String
            Dim tmpDirectoryInfo As DirectoryInfo
            ' Only rename selected files
            If Row.Cells("colSelect").Value Then
                lstStatus.Items.Add("Processing row " & Row.Index) 'Debug

                fullPathOld = Row.Cells("colFile").Value
                tmpDirectoryInfo = Directory.GetParent(fullPathOld)
                parentDirectory = tmpDirectoryInfo.FullName.Substring(InStrRev(tmpDirectoryInfo.FullName, "\"))
                fileNameOld = fullPathOld.Replace(tmpDirectoryInfo.FullName & "\", "")
                fileType = fileNameOld.Substring(InStrRev(fileNameOld, "."))

                'Rename file, using parent directory as filename
                fileNameNew = parentDirectory & "." & fileType
                fullPathNew = tmpDirectoryInfo.FullName & "\" & fileNameNew
                Rename(fullPathOld, fullPathNew)

                'Move file to destination directory
                File.Move("\\?\" & fullPathNew, "\\?\" & Replace(lblDirectoryDestination.Text, "Destination: ", "") & "\" & fileNameNew)

                'lstStatus.Items.Add(FormatDateTime(Now, DateFormat.GeneralDate) & ": New filename is '" & parentDirectory & "." & fileType & "'") 'Debug
            End If
        Next
        datFiles.Rows.Clear()
        lstStatus.Items.Add("Processing complete.") 'Debug
    End Sub
    Private Sub frmMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        If My.Settings.TargetDir Is Nothing Then
            lblDirectoryTarget.Text = "Select a target directory..."
        Else
            lblDirectoryTarget.Text = "Target: " & My.Settings.TargetDir
        End If

        If My.Settings.TargetDir Is Nothing Then
            lblDirectoryDestination.Text = "Select a destination directory..."
        Else
            lblDirectoryDestination.Text = "Destination: " & My.Settings.DestinationDir
        End If

        chkDeleteAfterProcessing.Checked = My.Settings.DeleteFolder

    End Sub
    Private Sub chkDeleteAfterProcessing_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkDeleteAfterProcessing.CheckedChanged
        My.Settings.DeleteFolder = chkDeleteAfterProcessing.Checked
        My.Settings.Save()
    End Sub
End Class
