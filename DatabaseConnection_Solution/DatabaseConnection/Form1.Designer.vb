<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvestmentDBDataSet = New DatabaseConnection.investmentDBDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.InvestmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvestmentsTableAdapter = New DatabaseConnection.investmentDBDataSetTableAdapters.InvestmentsTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TickerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvestmentTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PricePerShareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumSharesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvestmentDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvestmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.InvestmentDBDataSet
        Me.BindingSource1.Position = 0
        '
        'InvestmentDBDataSet
        '
        Me.InvestmentDBDataSet.DataSetName = "investmentDBDataSet"
        Me.InvestmentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.TickerDataGridViewTextBoxColumn, Me.InvestmentTypeDataGridViewTextBoxColumn, Me.PricePerShareDataGridViewTextBoxColumn, Me.PurchaseDateDataGridViewTextBoxColumn, Me.NumSharesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InvestmentsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.Size = New System.Drawing.Size(959, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'InvestmentsBindingSource
        '
        Me.InvestmentsBindingSource.DataMember = "Investments"
        Me.InvestmentsBindingSource.DataSource = Me.BindingSource1
        '
        'InvestmentsTableAdapter
        '
        Me.InvestmentsTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 150
        '
        'TickerDataGridViewTextBoxColumn
        '
        Me.TickerDataGridViewTextBoxColumn.DataPropertyName = "Ticker"
        Me.TickerDataGridViewTextBoxColumn.HeaderText = "Ticker"
        Me.TickerDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TickerDataGridViewTextBoxColumn.Name = "TickerDataGridViewTextBoxColumn"
        Me.TickerDataGridViewTextBoxColumn.Width = 150
        '
        'InvestmentTypeDataGridViewTextBoxColumn
        '
        Me.InvestmentTypeDataGridViewTextBoxColumn.DataPropertyName = "InvestmentType"
        Me.InvestmentTypeDataGridViewTextBoxColumn.HeaderText = "InvestmentType"
        Me.InvestmentTypeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.InvestmentTypeDataGridViewTextBoxColumn.Name = "InvestmentTypeDataGridViewTextBoxColumn"
        Me.InvestmentTypeDataGridViewTextBoxColumn.Width = 150
        '
        'PricePerShareDataGridViewTextBoxColumn
        '
        Me.PricePerShareDataGridViewTextBoxColumn.DataPropertyName = "PricePerShare"
        Me.PricePerShareDataGridViewTextBoxColumn.HeaderText = "PricePerShare"
        Me.PricePerShareDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PricePerShareDataGridViewTextBoxColumn.Name = "PricePerShareDataGridViewTextBoxColumn"
        Me.PricePerShareDataGridViewTextBoxColumn.Width = 150
        '
        'PurchaseDateDataGridViewTextBoxColumn
        '
        Me.PurchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate"
        Me.PurchaseDateDataGridViewTextBoxColumn.HeaderText = "PurchaseDate"
        Me.PurchaseDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PurchaseDateDataGridViewTextBoxColumn.Name = "PurchaseDateDataGridViewTextBoxColumn"
        Me.PurchaseDateDataGridViewTextBoxColumn.Width = 150
        '
        'NumSharesDataGridViewTextBoxColumn
        '
        Me.NumSharesDataGridViewTextBoxColumn.DataPropertyName = "NumShares"
        Me.NumSharesDataGridViewTextBoxColumn.HeaderText = "NumShares"
        Me.NumSharesDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NumSharesDataGridViewTextBoxColumn.Name = "NumSharesDataGridViewTextBoxColumn"
        Me.NumSharesDataGridViewTextBoxColumn.Width = 150
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1528, 715)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvestmentDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvestmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents InvestmentDBDataSet As investmentDBDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents InvestmentsBindingSource As BindingSource
    Friend WithEvents InvestmentsTableAdapter As investmentDBDataSetTableAdapters.InvestmentsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TickerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InvestmentTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PricePerShareDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumSharesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
