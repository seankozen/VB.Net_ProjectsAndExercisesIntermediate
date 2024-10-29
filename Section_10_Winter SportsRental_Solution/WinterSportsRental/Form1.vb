Public Class frmWinterSports

    Private ReadOnly TaxRate As Double = 0.07
    Private rentalPrices As New Prices
    Private errProvider = New ErrorProvider

    Private Sub frmWinterSports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Today.ToShortDateString
    End Sub

    Private Sub lnkForecast_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForecast.LinkClicked
        frmWeatherForecast.WebBrowser1.Navigate("https://www.google.com/search?q=nagoya+weather&oq=nagoya+weather&gs_lcrp=EgZjaHJvbWUyDggAEEUYORhDGIAEGIoFMgcIARAAGIAEMgcIAhAAGIAEMgcIAxAAGIAEMgcIBBAAGIAEMgcIBRAAGIAEMgcIBhAAGIAEMgcIBxAAGIAEMgcICBAAGIAEMgcICRAAGIAE0gEIMzk1MGowajeoAgiwAgE&sourceid=chrome&ie=UTF-8")
        frmWeatherForecast.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If lstEquipment.SelectedIndices.Count = 0 Then
            errProvider.SetError(lstEquipment, "Please select something to rent!")
            Return
        Else
            errProvider.SetError(lstEquipment, "")
        End If


        Dim duration As Prices.DurationType = CType(cboDuration.SelectedIndex, Prices.DurationType)
        If duration = -1 Then
            errProvider.SetError(cboDuration, "Please select a valid duration!")
            Return
        Else
            errProvider.SetError(cboDuration, "")

        End If

        Dim deposit As Double
        If Not Double.TryParse(txtDeposit.Text, deposit) Then
            errProvider.SetError(txtDeposit, "Deposit must be a positive number!")
            Return
        Else
            errProvider.SetError(txtDeposit, "")
        End If


        Dim subtotal As Double = 0

        For Each index As Integer In lstEquipment.SelectedIndices
            Dim equipType As Prices.EquipmentType = CType(index, Prices.EquipmentType)
            subtotal += rentalPrices.GetRentalPrice(equipType, duration)
        Next

        Dim insurance As Double = 0
        If chkInsurance.Checked = True Then
            insurance = Prices.InsuranceCost(subtotal)
        End If

        subtotal += insurance
        Dim tax As Double = subtotal * TaxRate

        Dim balance As Double = subtotal + tax - deposit

        lblBalance.Text = subtotal.ToString("n")
        lblTax.Text = tax.ToString("n")
        lblBalance.Text = balance.ToString("c")
    End Sub

End Class
