Imports Microsoft.VisualBasic
Imports System
Namespace ParametersPanel
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.dataSet11 = New ParametersPanel.DataSet1()
			Me.invoicesTableAdapter = New ParametersPanel.DataSet1TableAdapters.InvoicesTableAdapter()
			Me.parameter1 = New DevExpress.XtraReports.Parameters.Parameter()
			Me.parameter2 = New DevExpress.XtraReports.Parameters.Parameter()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel4, Me.xrLabel9, Me.xrLabel10, Me.xrLabel11, Me.xrLabel8, Me.xrLabel3})
			Me.Detail.HeightF = 114.4583F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel3
			' 
			Me.xrLabel3.BackColor = System.Drawing.Color.BurlyWood
			Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.ProductName")})
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(172.9167F, 81.22918F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(247.9166F, 23F)
			Me.xrLabel3.StylePriority.UseBackColor = False
			Me.xrLabel3.Text = "xrLabel3"
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1})
			Me.BottomMargin.HeightF = 61.45833F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' invoicesTableAdapter
			' 
			Me.invoicesTableAdapter.ClearBeforeFill = True
			' 
			' parameter1
			' 
			Me.parameter1.Description = "OrderDate"
			Me.parameter1.Name = "parameter1"
			Me.parameter1.Type = GetType(System.DateTime)
			Me.parameter1.ValueInfo = "01/01/1995 15:12:00"
			' 
			' parameter2
			' 
			Me.parameter2.Description = "RequredDate"
			Me.parameter2.Name = "parameter2"
			Me.parameter2.Type = GetType(System.DateTime)
			Me.parameter2.ValueInfo = "12/14/1995 15:13:00"
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel7})
			Me.ReportHeader.HeightF = 87.5F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrLabel7
			' 
			Me.xrLabel7.Font = New System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(211.9792F, 10.00001F)
			Me.xrLabel7.Name = "xrLabel7"
			Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel7.SizeF = New System.Drawing.SizeF(143.75F, 67.79166F)
			Me.xrLabel7.StylePriority.UseFont = False
			Me.xrLabel7.Text = "Invoices"
			' 
			' xrPageInfo1
			' 
			Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(550F, 0F)
			Me.xrPageInfo1.Name = "xrPageInfo1"
			Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(100F, 23F)
			' 
			' xrLabel8
			' 
			Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(72.91666F, 81.22918F)
			Me.xrLabel8.Name = "xrLabel8"
			Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel8.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel8.Text = "Product Name:"
			' 
			' xrLabel4
			' 
			Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 47.87502F)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel4.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel4.Text = "RequredDate"
			' 
			' xrLabel9
			' 
			Me.xrLabel9.BackColor = System.Drawing.Color.Coral
			Me.xrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.RequiredDate")})
			Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(110F, 47.87502F)
			Me.xrLabel9.Name = "xrLabel9"
			Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel9.SizeF = New System.Drawing.SizeF(188.5417F, 23F)
			Me.xrLabel9.StylePriority.UseBackColor = False
			Me.xrLabel9.Text = "xrLabel2"
			' 
			' xrLabel10
			' 
			Me.xrLabel10.BackColor = System.Drawing.Color.Coral
			Me.xrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.OrderDate")})
			Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(110.0001F, 10.00001F)
			Me.xrLabel10.Name = "xrLabel10"
			Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel10.SizeF = New System.Drawing.SizeF(188.5417F, 23F)
			Me.xrLabel10.StylePriority.UseBackColor = False
			Me.xrLabel10.Text = "xrLabel1"
			' 
			' xrLabel11
			' 
			Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.xrLabel11.Name = "xrLabel11"
			Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel11.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel11.Text = "OrderDate:"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
			Me.DataAdapter = Me.invoicesTableAdapter
			Me.DataMember = "Invoices"
			Me.DataSource = Me.dataSet11
			Me.FilterString = "[OrderDate] > ?parameter1 And [RequiredDate] < ?parameter2"
			Me.Margins = New System.Drawing.Printing.Margins(100, 100, 100, 61)
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.parameter1, Me.parameter2})
			Me.Version = "12.2"
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private dataSet11 As DataSet1
		Private invoicesTableAdapter As DataSet1TableAdapters.InvoicesTableAdapter
		Private parameter1 As DevExpress.XtraReports.Parameters.Parameter
		Private parameter2 As DevExpress.XtraReports.Parameters.Parameter
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel9 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel10 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel11 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel8 As DevExpress.XtraReports.UI.XRLabel
		Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
