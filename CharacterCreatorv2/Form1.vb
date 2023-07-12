Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub PnlEditionOpt_Paint(sender As Object, e As PaintEventArgs) Handles PnlEditionOpt.Paint

    End Sub

    Private Sub RadioButtons_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbFifth.CheckedChanged, rbFourth.CheckedChanged, rbThird.CheckedChanged, rbSecond.CheckedChanged
        PnlFifthOpt.Visible = rbFifth.Checked
        'PnlFourthOpt.Visible = rbFourth.Checked
        'PnlThirdOpt.Visible = rbThird.Checked
        'PnlSecondOpt.Visible = rbSecond.Checked
    End Sub

    Private Sub PnlFifthOpt_Paint(sender As Object, e As PaintEventArgs) Handles PnlFifthOpt.Paint

    End Sub

    Private Sub btnThirdPartyAcc_Click(sender As Object, e As EventArgs) Handles btnThirdPartyAcc.Click
        MessageBox.Show("Coming Soon!")
    End Sub

    Private Sub btnSheets_Click(sender As Object, e As EventArgs) Handles btnSheets.Click

        Sheets.Show()

    End Sub

    Private Sub cbGeneric_CheckedChanged(sender As Object, e As EventArgs) Handles cbGeneric.CheckedChanged

    End Sub

    Private Sub clbSources_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clbSources.SelectedIndexChanged

    End Sub

    Private Sub btnSourcesReset_Click(sender As Object, e As EventArgs) Handles btnSourcesReset.Click
        uncheckSourceList(clbSources)
        uncheckSourceList(clbAccessories)
        uncheckSourceList(clbAdventures)
    End Sub

    Private Sub uncheckSourceList(sourceList As CheckedListBox)
        For i As Integer = 0 To sourceList.Items.Count - 1
            sourceList.SetItemChecked(i, False)
        Next
    End Sub
End Class
