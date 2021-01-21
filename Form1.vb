Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const base As Double = 85
        Const perMile As Double = 5
        Dim limit As Integer
        Dim clocked As Integer
        Dim fine As Double
        Dim overage As Integer
        limit = CInt(txtLimit.Text)
        clocked = CInt(txtClocked.Text)
        If clocked <= limit Then
            txtLegal.Text = "Legal"
            txtFine.Text = "N/A"
        Else
            txtLegal.Text = "Illegal"
            overage = clocked - limit
            fine = base + (perMile * overage)
            txtFine.Text = String.Format("{0:C}", fine)
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtClocked.Text = ""
        txtFine.Text = ""
        txtLegal.Text = ""
        txtLimit.Text = ""
    End Sub
End Class
