<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport1
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim StackedLineSeriesView1 As DevExpress.XtraCharts.StackedLineSeriesView = New DevExpress.XtraCharts.StackedLineSeriesView()
        Dim StackedLineSeriesView2 As DevExpress.XtraCharts.StackedLineSeriesView = New DevExpress.XtraCharts.StackedLineSeriesView()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.xrZipCode1 = New DevExpress.XtraReports.UI.XRZipCode()
        Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.xrChart1 = New DevExpress.XtraReports.UI.XRChart()
        Me.lbInvoice = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.xrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedLineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(StackedLineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrZipCode1, Me.xrTable1})
        Me.Detail.HeightF = 26.04167!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 58.66668!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPictureBox1})
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrChart1})
        Me.ReportFooter.HeightF = 128.125!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbInvoice, Me.xrPictureBox2, Me.xrPictureBox3})
        Me.PageHeader.HeightF = 87.5!
        Me.PageHeader.Name = "PageHeader"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel3, Me.xrLabel2, Me.xrLabel1})
        Me.GroupHeader1.HeightF = 23.95833!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'xrZipCode1
        '
        Me.xrZipCode1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Value3]")})
        Me.xrZipCode1.LocationFloat = New DevExpress.Utils.PointFloat(522.9167!, 0.1249949!)
        Me.xrZipCode1.Name = "xrZipCode1"
        Me.xrZipCode1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xrZipCode1.Text = ""
        '
        'xrTable1
        '
        Me.xrTable1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.xrTable1.BorderColor = System.Drawing.Color.White
        Me.xrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(161.4584!, 0!)
        Me.xrTable1.Name = "xrTable1"
        Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
        Me.xrTable1.SizeF = New System.Drawing.SizeF(325.0!, 25.0!)
        Me.xrTable1.StylePriority.UseBackColor = False
        Me.xrTable1.StylePriority.UseBorderColor = False
        Me.xrTable1.StylePriority.UseBorders = False
        '
        'xrTableRow1
        '
        Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
        Me.xrTableRow1.Name = "xrTableRow1"
        Me.xrTableRow1.Weight = 11.5R
        '
        'xrTableCell1
        '
        Me.xrTableCell1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Value1]")})
        Me.xrTableCell1.Name = "xrTableCell1"
        Me.xrTableCell1.Text = "xrTableCell1"
        Me.xrTableCell1.Weight = 0.29046741206609183R
        '
        'xrTableCell2
        '
        Me.xrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Value2]")})
        Me.xrTableCell2.Name = "xrTableCell2"
        Me.xrTableCell2.Text = "xrTableCell2"
        Me.xrTableCell2.Weight = 0.28096115936247956R
        '
        'xrTableCell3
        '
        Me.xrTableCell3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Value3]")})
        Me.xrTableCell3.Name = "xrTableCell3"
        Me.xrTableCell3.Text = "xrTableCell3"
        Me.xrTableCell3.Weight = 0.34131296754343626R
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox1.ImageSource"))
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(251.0418!, 9.999974!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(165.6249!, 35.00001!)
        '
        'xrChart1
        '
        Me.xrChart1.BorderColor = System.Drawing.Color.Black
        Me.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
        XyDiagram1.AxisX.Label.Visible = False
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        Me.xrChart1.Diagram = XyDiagram1
        Me.xrChart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.xrChart1.LocationFloat = New DevExpress.Utils.PointFloat(9.999974!, 10.00001!)
        Me.xrChart1.Name = "xrChart1"
        Series1.ArgumentDataMember = "Value1"
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series1.Name = "Series 2"
        Series1.ValueDataMembersSerializable = "Value2"
        StackedLineSeriesView1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        StackedLineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.View = StackedLineSeriesView1
        Me.xrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.xrChart1.SeriesTemplate.View = StackedLineSeriesView2
        Me.xrChart1.SizeF = New System.Drawing.SizeF(629.9999!, 117.7083!)
        '
        'lbInvoice
        '
        Me.lbInvoice.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbInvoice.ForeColor = System.Drawing.Color.Black
        Me.lbInvoice.LocationFloat = New DevExpress.Utils.PointFloat(433.9167!, 10.00001!)
        Me.lbInvoice.Name = "lbInvoice"
        Me.lbInvoice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbInvoice.SizeF = New System.Drawing.SizeF(206.0833!, 33.00001!)
        Me.lbInvoice.Text = "EMAIL DEMO"
        Me.lbInvoice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrPictureBox2
        '
        Me.xrPictureBox2.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox2.ImageSource"))
        Me.xrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(89.8852!, 22.50001!)
        Me.xrPictureBox2.Name = "xrPictureBox2"
        Me.xrPictureBox2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.xrPictureBox2.SizeF = New System.Drawing.SizeF(190.0!, 49.0!)
        Me.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'xrPictureBox3
        '
        Me.xrPictureBox3.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox3.ImageSource"))
        Me.xrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.xrPictureBox3.Name = "xrPictureBox3"
        Me.xrPictureBox3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.xrPictureBox3.SizeF = New System.Drawing.SizeF(87.5!, 87.5!)
        Me.xrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
        '
        'xrLabel3
        '
        Me.xrLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.xrLabel3.BorderColor = System.Drawing.Color.White
        Me.xrLabel3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.xrLabel3.ForeColor = System.Drawing.Color.White
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(364.9271!, 0!)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(121.5314!, 23.00002!)
        Me.xrLabel3.StylePriority.UseBackColor = False
        Me.xrLabel3.StylePriority.UseBorderColor = False
        Me.xrLabel3.StylePriority.UseBorders = False
        Me.xrLabel3.StylePriority.UseFont = False
        Me.xrLabel3.StylePriority.UseForeColor = False
        Me.xrLabel3.StylePriority.UsePadding = False
        Me.xrLabel3.StylePriority.UseTextAlignment = False
        Me.xrLabel3.Text = "Value 3"
        Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrLabel2
        '
        Me.xrLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.xrLabel2.BorderColor = System.Drawing.Color.White
        Me.xrLabel2.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.xrLabel2.ForeColor = System.Drawing.Color.White
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(264.8852!, 0!)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(100.0419!, 23.00002!)
        Me.xrLabel2.StylePriority.UseBackColor = False
        Me.xrLabel2.StylePriority.UseBorderColor = False
        Me.xrLabel2.StylePriority.UseBorders = False
        Me.xrLabel2.StylePriority.UseFont = False
        Me.xrLabel2.StylePriority.UseForeColor = False
        Me.xrLabel2.StylePriority.UsePadding = False
        Me.xrLabel2.StylePriority.UseTextAlignment = False
        Me.xrLabel2.Text = "Value 2"
        Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrLabel1
        '
        Me.xrLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.xrLabel1.BorderColor = System.Drawing.Color.White
        Me.xrLabel1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.xrLabel1.ForeColor = System.Drawing.Color.White
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(161.4584!, 0!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(103.4267!, 23.00002!)
        Me.xrLabel1.StylePriority.UseBackColor = False
        Me.xrLabel1.StylePriority.UseBorderColor = False
        Me.xrLabel1.StylePriority.UseBorders = False
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.StylePriority.UseForeColor = False
        Me.xrLabel1.StylePriority.UsePadding = False
        Me.xrLabel1.StylePriority.UseTextAlignment = False
        Me.xrLabel1.Text = "Value 1"
        Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XtraReport1
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportFooter, Me.PageHeader, Me.GroupHeader1})
        Me.ExportOptions.MailMessage.Title = "Document Email"
        Me.Margins = New System.Drawing.Printing.Margins(82, 100, 59, 100)
        Me.PageColor = System.Drawing.Color.Transparent
        Me.Version = "20.2"
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedLineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(StackedLineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents xrZipCode1 As DevExpress.XtraReports.UI.XRZipCode
    Friend WithEvents xrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents xrChart1 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents lbInvoice As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents xrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
End Class
