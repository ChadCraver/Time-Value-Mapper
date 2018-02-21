Public Class frmImportFile
    Private HasHeaders As Boolean

    Private Sub frmImportFile_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        chkbxHasHeaders.Checked = True
        chkbxHasHeaders_Click(Nothing, Nothing)
        txtFilePath.Text = ""
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) And (OpenFileDialog1.FileName <> "") Then
            txtFilePath.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        frmMain.BeingImport(txtFilePath.Text, HasHeaders)
        Me.Hide()
    End Sub

    Private Sub chkbxHasHeaders_Click(sender As Object, e As EventArgs) Handles chkbxHasHeaders.Click
        If chkbxHasHeaders.Checked Then
            HasHeaders = True
        Else
            HasHeaders = False
        End If
    End Sub
End Class