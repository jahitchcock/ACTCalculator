'Joshua Hitchcock
'ACT average calculator
'assignment 4

Option Explicit On
Option Strict On

Public Class frmMain

    'Validates user entry in text boxes fall in the correct range and calculates average

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim dblMath As Double = Val(txtMath.Text)
        Dim dblRead As Double = Val(txtRead.Text)
        Dim dblSciHis As Double = Val(txtSciHis.Text)
        Dim average As Double
        If dblMath > 26 Then
            dblMath = 0
            txtMath.Text = "Invalid Score"
        End If
        If dblRead > 26 Then
            dblRead = 0
            txtRead.Text = "Invalid Score"
        End If
        If dblSciHis > 26 Then
            dblSciHis = 0
            txtSciHis.Text = ("Invalid Score")
        End If
        average = (dblMath + dblRead + dblSciHis) / 3
        Me.lblAvgScore.Text = average.ToString


    End Sub

    'Validates only numbers entered in textboxes

    Private Sub txtMath_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMath.KeyPress, txtRead.KeyPress, txtSciHis.KeyPress
        If e.KeyChar < "0" Or e.KeyChar > "9" Then
            e.Handled = True
        End If
    End Sub

    'Clears textboxes and average label

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtMath.Text = ""
        txtRead.Text = ""
        txtSciHis.Text = ""
        lblAvgScore.Text = ""
    End Sub

    'Closes the form

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
