<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvestmentList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgvInvestmentList = New System.Windows.Forms.DataGridView()
        Me.InvestTrackDataSet = New InvestmentTracking.InvestTrackDataSet()
        Me.InvestTrackDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvestmentsTableAdapter = New InvestmentTracking.InvestTrackDataSetTableAdapters.InvestmentsTableAdapter()
        Me.InvestTrackDataSet1 = New InvestmentTracking.InvestTrackDataSet()
        Me.PricesTableAdapter = New InvestmentTracking.InvestTrackDataSetTableAdapters.PricesTableAdapter()
        CType(Me.dgvInvestmentList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvestTrackDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvestTrackDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvestTrackDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInvestmentList
        '
        Me.dgvInvestmentList.AllowUserToAddRows = False
        Me.dgvInvestmentList.AllowUserToDeleteRows = False
        Me.dgvInvestmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvestmentList.Location = New System.Drawing.Point(20, 17)
        Me.dgvInvestmentList.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dgvInvestmentList.Name = "dgvInvestmentList"
        Me.dgvInvestmentList.ReadOnly = True
        Me.dgvInvestmentList.RowHeadersWidth = 62
        Me.dgvInvestmentList.Size = New System.Drawing.Size(1005, 414)
        Me.dgvInvestmentList.TabIndex = 0
        '
        'InvestTrackDataSet
        '
        Me.InvestTrackDataSet.DataSetName = "InvestTrackDataSet"
        Me.InvestTrackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvestTrackDataSetBindingSource
        '
        Me.InvestTrackDataSetBindingSource.DataMember = "Investments"
        Me.InvestTrackDataSetBindingSource.DataSource = Me.InvestTrackDataSet
        '
        'InvestmentsTableAdapter
        '
        Me.InvestmentsTableAdapter.ClearBeforeFill = True
        '
        'InvestTrackDataSet1
        '
        Me.InvestTrackDataSet1.DataSetName = "InvestTrackDataSet"
        Me.InvestTrackDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PricesTableAdapter
        '
        Me.PricesTableAdapter.ClearBeforeFill = True
        '
        'frmInvestmentList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 454)
        Me.Controls.Add(Me.dgvInvestmentList)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmInvestmentList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Investment List"
        CType(Me.dgvInvestmentList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvestTrackDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvestTrackDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvestTrackDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvInvestmentList As DataGridView
    Friend WithEvents InvestTrackDataSetBindingSource As BindingSource
    Friend WithEvents InvestTrackDataSet As InvestTrackDataSet
    Friend WithEvents InvestmentsTableAdapter As InvestTrackDataSetTableAdapters.InvestmentsTableAdapter
    Friend WithEvents InvestTrackDataSet1 As InvestTrackDataSet
    Friend WithEvents PricesTableAdapter As InvestTrackDataSetTableAdapters.PricesTableAdapter
End Class
