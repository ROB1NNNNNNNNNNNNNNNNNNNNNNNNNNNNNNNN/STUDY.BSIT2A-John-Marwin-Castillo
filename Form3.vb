Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnection()
        LoadRecord()

    End Sub
    Private Sub dgvRecord_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvrecord.CellFormatting
        Dim values As New List(Of String)
        If dgvrecord.Columns(e.ColumnIndex).Index = 2 Then
            If e.Value <> "" Then
                e.Value = "****"
                e.FormattingApplied = True
            End If
        End If
    End Sub

    Private Sub dgvRecord_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvrecord.CellContentClick
        Dim uname, pass, uid As String
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = dgvrecord.Columns("UpdateButton").Index Then
                'HANDLE THE EVENT
                uid = dgvrecord.CurrentRow.Cells(0).Value.ToString()
                uname = dgvrecord.CurrentRow.Cells(1).Value.ToString()
                pass = dgvrecord.CurrentRow.Cells(2).Value.ToString()
                Dim result As DialogResult = MessageBox.Show("Do you really want to update the record?",
                                                     "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    RecordUpdate(e.RowIndex, uname, pass)

                End If

            Else
                Dim result As DialogResult = MessageBox.Show("Do you really want to delete the record?",
                                                   "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    RemoveRecord(e.RowIndex)
                End If
            End If
        End If
    End Sub
End Class