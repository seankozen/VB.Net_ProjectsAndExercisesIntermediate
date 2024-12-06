Public Class frmInvestmentList
    Private Sub frmInvestmentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InvestTrackDataSet.Investments' table. You can move, or remove it, as needed.
        Me.InvestmentsTableAdapter.Fill(Me.InvestTrackDataSet.Investments)
        'TODO: This line of code loads data into the 'InvestTrackDataSet.Investments' table. You can move, or remove it, as needed.
        Me.InvestmentsTableAdapter.Fill(Me.InvestTrackDataSet.Investments)
        'TODO: This line of code loads data into the 'InvestTrackDataSet1.Investments' table. You can move, or remove it, as needed.
        Me.InvestmentsTableAdapter.Fill(Me.InvestTrackDataSet1.Investments)
        'TODO: This line of code loads data into the 'InvestTrackDataSet.Investments' table. You can move, or remove it, as needed.
        Me.InvestmentsTableAdapter.Fill(Me.InvestTrackDataSet.Investments)
        'TODO: This line of code loads data into the 'InvestTrackDataSet1.Investments' table. You can move, or remove it, as needed.
        Me.InvestmentsTableAdapter.Fill(Me.InvestTrackDataSet1.Investments)
        'TODO: This line of code loads data into the 'InvestTrackDataSet.Investments' table. You can move, or remove it, as needed.
        Me.InvestmentsTableAdapter.Fill(Me.InvestTrackDataSet.Investments)
        'TODO: This line of code loads data into the 'InvestTrackDataSet.Prices' table. You can move, or remove it, as needed.
        Me.PricesTableAdapter.Fill(Me.InvestTrackDataSet.Prices)
        'TODO: This line of code loads data into the 'InvestTrackDataSet1.Investments' table. You can move, or remove it, as needed.
        Me.InvestmentsTableAdapter.Fill(Me.InvestTrackDataSet1.Investments)
        'TODO: This line of code loads data into the 'InvestTrackDataSet.Investments' table. You can move, or remove it, as needed.
        Me.InvestmentsTableAdapter.Fill(Me.InvestTrackDataSet.Investments)
        'TODO: This line of code loads data into the 'InvestTrackDataSet.Investments' table. You can move, or remove it, as needed.
        Me.InvestmentsTableAdapter.Fill(Me.InvestTrackDataSet.Investments)

    End Sub

    Private Sub InvestTrackDataSetBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles InvestTrackDataSetBindingSource.CurrentChanged

    End Sub
End Class