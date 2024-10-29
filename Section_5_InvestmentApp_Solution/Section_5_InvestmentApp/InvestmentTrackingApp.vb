Public Class InvestmentTrackingApp
    Private Sub InvestmentTrackingApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDate.Value = Today

        If Not Investment.LoadPrices("..\..\InvestPrices.txt") Then
            MessageBox.Show("Cannot load the .txt file.")
        End If
    End Sub

    Private Sub cboInvType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInvType.SelectedIndexChanged

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub TextChanged(sender As Object, e As EventArgs) Handles txtTicker.TextChanged
        Dim price As Double = Investment.GetCurrentPrice(txtTicker.Text)
        If price > 0 Then
            txtPpShare.Text = price.ToString("n")
        Else
            txtPpShare.Text = String.Empty
        End If


    End Sub

    Private Sub KeyPressForShares(sender As Object, e As KeyPressEventArgs) Handles txtShareNum.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CTbInvestmentType(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim invest As New Investment
        If cboInvType.SelectedIndex = -1 Or txtShareNum.Text = "" Then
            MessageBox.Show("Please enter the correct input!")
            Exit Sub
        End If

        With invest
            .Type = CType(cboInvType.SelectedIndex, Investment.InvestmentType)
            .PurchaseDate = dtpDate.Value.Date
            .Ticker = txtTicker.Text
            .PricePerShare = CDbl(txtPpShare.Text)
            .NumOfShares = CInt(txtShareNum.Text)

        End With
        txtTotal.Text = invest.PurchaseAmount.ToString("c")


    End Sub

End Class
