Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles cbsbVan.CheckedChanged

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
End Class
