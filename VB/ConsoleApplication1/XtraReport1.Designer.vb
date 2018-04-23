Namespace ConsoleApplication1
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim stackedLineSeriesView1 As New DevExpress.XtraCharts.StackedLineSeriesView()
            Dim stackedLineSeriesView2 As New DevExpress.XtraCharts.StackedLineSeriesView()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrZipCode1 = New DevExpress.XtraReports.UI.XRZipCode()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.xrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrChart1 = New DevExpress.XtraReports.UI.XRChart()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.lbInvoice = New DevExpress.XtraReports.UI.XRLabel()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(stackedLineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(stackedLineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrZipCode1, Me.xrTable1})
            Me.Detail.HeightF = 26.04167F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrZipCode1
            ' 
            Me.xrZipCode1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Value3")})
            Me.xrZipCode1.LocationFloat = New DevExpress.Utils.PointFloat(522.9167F, 0.1249949F)
            Me.xrZipCode1.Name = "xrZipCode1"
            Me.xrZipCode1.SizeF = New System.Drawing.SizeF(100F, 23F)
            Me.xrZipCode1.Text = ""
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(238)))), (CInt((CByte(238)))), (CInt((CByte(238)))))
            Me.xrTable1.BorderColor = System.Drawing.Color.White
            Me.xrTable1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(161.4584F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(325F, 25F)
            Me.xrTable1.StylePriority.UseBackColor = False
            Me.xrTable1.StylePriority.UseBorderColor = False
            Me.xrTable1.StylePriority.UseBorders = False
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 11.5R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Value1")})
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.Weight = 0.29046741206609183R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Value2")})
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.Weight = 0.28096115936247956R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Value3")})
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Text = "xrTableCell3"
            Me.xrTableCell3.Weight = 0.34131296754343626R
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.Image = (DirectCast(resources.GetObject("xrPictureBox1.Image"), System.Drawing.Image))
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(251.0418F, 9.999974F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(165.6249F, 35.00001F)
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 58.66668F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox2
            ' 
            Me.xrPictureBox2.Image = (DirectCast(resources.GetObject("xrPictureBox2.Image"), System.Drawing.Image))
            Me.xrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(89.8852F, 22.50001F)
            Me.xrPictureBox2.Name = "xrPictureBox2"
            Me.xrPictureBox2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox2.SizeF = New System.Drawing.SizeF(190F, 49F)
            Me.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
            ' 
            ' xrPictureBox3
            ' 
            Me.xrPictureBox3.Image = (DirectCast(resources.GetObject("xrPictureBox3.Image"), System.Drawing.Image))
            Me.xrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrPictureBox3.Name = "xrPictureBox3"
            Me.xrPictureBox3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox3.SizeF = New System.Drawing.SizeF(87.5F, 87.5F)
            Me.xrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            ' 
            ' xrChart1
            ' 
            Me.xrChart1.BorderColor = System.Drawing.Color.Black
            Me.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
            xyDiagram1.AxisX.Label.Visible = False
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.False
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.False
            xyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.False
            xyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.False
            xyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.False
            Me.xrChart1.Diagram = xyDiagram1
            Me.xrChart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.xrChart1.LocationFloat = New DevExpress.Utils.PointFloat(9.999974F, 10.00001F)
            Me.xrChart1.Name = "xrChart1"
            series1.ArgumentDataMember = "Value1"
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
            series1.Name = "Series 2"
            series1.ValueDataMembersSerializable = "Value2"
            stackedLineSeriesView1.Color = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(192)))), (CInt((CByte(0)))))
            stackedLineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
            series1.View = stackedLineSeriesView1
            Me.xrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.xrChart1.SeriesTemplate.View = stackedLineSeriesView2
            Me.xrChart1.SizeF = New System.Drawing.SizeF(629.9999F, 117.7083F)
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox1})
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' bindingSource1
            ' 
            Me.bindingSource1.DataSource = GetType(ConsoleApplication1.ReportData)
            ' 
            ' ReportFooter
            ' 
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrChart1})
            Me.ReportFooter.HeightF = 128.125F
            Me.ReportFooter.Name = "ReportFooter"
            ' 
            ' lbInvoice
            ' 
            Me.lbInvoice.Font = New System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold)
            Me.lbInvoice.ForeColor = System.Drawing.Color.Black
            Me.lbInvoice.LocationFloat = New DevExpress.Utils.PointFloat(433.9167F, 10.00001F)
            Me.lbInvoice.Name = "lbInvoice"
            Me.lbInvoice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbInvoice.SizeF = New System.Drawing.SizeF(206.0833F, 33.00001F)
            Me.lbInvoice.Text = "EMAIL DEMO"
            Me.lbInvoice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbInvoice, Me.xrPictureBox2, Me.xrPictureBox3})
            Me.PageHeader.HeightF = 87.5F
            Me.PageHeader.Name = "PageHeader"
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3, Me.xrLabel2, Me.xrLabel1})
            Me.GroupHeader1.HeightF = 23.95833F
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(167)))), (CInt((CByte(73)))))
            Me.xrLabel3.BorderColor = System.Drawing.Color.White
            Me.xrLabel3.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrLabel3.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.xrLabel3.ForeColor = System.Drawing.Color.White
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(364.9271F, 0F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(121.5314F, 23.00002F)
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
            ' xrLabel2
            ' 
            Me.xrLabel2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(167)))), (CInt((CByte(73)))))
            Me.xrLabel2.BorderColor = System.Drawing.Color.White
            Me.xrLabel2.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrLabel2.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.xrLabel2.ForeColor = System.Drawing.Color.White
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(264.8852F, 0F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(100.0419F, 23.00002F)
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
            ' xrLabel1
            ' 
            Me.xrLabel1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(167)))), (CInt((CByte(73)))))
            Me.xrLabel1.BorderColor = System.Drawing.Color.White
            Me.xrLabel1.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.xrLabel1.ForeColor = System.Drawing.Color.White
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(161.4584F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(103.4267F, 23.00002F)
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
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportFooter, Me.PageHeader, Me.GroupHeader1})
            Me.DataSource = Me.bindingSource1
            Me.ExportOptions.MailMessage.Title = "Document Email"
            Me.Margins = New System.Drawing.Printing.Margins(82, 100, 59, 100)
            Me.PageColor = System.Drawing.Color.Transparent
            Me.Version = "15.2"
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(stackedLineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(stackedLineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xrChart1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private bindingSource1 As System.Windows.Forms.BindingSource
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
        Private xrChart1 As DevExpress.XtraReports.UI.XRChart
        Private xrZipCode1 As DevExpress.XtraReports.UI.XRZipCode
        Private xrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
        Private xrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
        Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
        Private lbInvoice As DevExpress.XtraReports.UI.XRLabel
        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    End Class
End Namespace
