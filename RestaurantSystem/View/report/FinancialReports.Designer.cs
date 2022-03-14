namespace RestaurantSystem.View.report
{
    partial class FinancialReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialReports));
            this.GrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetFinancialReport = new RestaurantSystem.View.report.DataSetFinancialReport();
            this.SalariesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MaintenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MiscellaneousBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OtherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TaxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UtilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GrandTableAdapter = new RestaurantSystem.View.report.DataSetFinancialReportTableAdapters.GrandTableAdapter();
            this.SalariesTableAdapter = new RestaurantSystem.View.report.DataSetFinancialReportTableAdapters.SalariesTableAdapter();
            this.RentTableAdapter = new RestaurantSystem.View.report.DataSetFinancialReportTableAdapters.RentTableAdapter();
            this.MaintenanceTableAdapter = new RestaurantSystem.View.report.DataSetFinancialReportTableAdapters.MaintenanceTableAdapter();
            this.MiscellaneousTableAdapter = new RestaurantSystem.View.report.DataSetFinancialReportTableAdapters.MiscellaneousTableAdapter();
            this.OtherTableAdapter = new RestaurantSystem.View.report.DataSetFinancialReportTableAdapters.OtherTableAdapter();
            this.TaxTableAdapter = new RestaurantSystem.View.report.DataSetFinancialReportTableAdapters.TaxTableAdapter();
            this.ItemTableAdapter = new RestaurantSystem.View.report.DataSetFinancialReportTableAdapters.ItemTableAdapter();
            this.UtilityTableAdapter = new RestaurantSystem.View.report.DataSetFinancialReportTableAdapters.UtilityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GrandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFinancialReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalariesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaintenanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiscellaneousBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UtilityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GrandBindingSource
            // 
            this.GrandBindingSource.DataMember = "Grand";
            this.GrandBindingSource.DataSource = this.DataSetFinancialReport;
            // 
            // DataSetFinancialReport
            // 
            this.DataSetFinancialReport.DataSetName = "DataSetFinancialReport";
            this.DataSetFinancialReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SalariesBindingSource
            // 
            this.SalariesBindingSource.DataMember = "Salaries";
            this.SalariesBindingSource.DataSource = this.DataSetFinancialReport;
            // 
            // RentBindingSource
            // 
            this.RentBindingSource.DataMember = "Rent";
            this.RentBindingSource.DataSource = this.DataSetFinancialReport;
            // 
            // MaintenanceBindingSource
            // 
            this.MaintenanceBindingSource.DataMember = "Maintenance";
            this.MaintenanceBindingSource.DataSource = this.DataSetFinancialReport;
            // 
            // MiscellaneousBindingSource
            // 
            this.MiscellaneousBindingSource.DataMember = "Miscellaneous";
            this.MiscellaneousBindingSource.DataSource = this.DataSetFinancialReport;
            // 
            // OtherBindingSource
            // 
            this.OtherBindingSource.DataMember = "Other";
            this.OtherBindingSource.DataSource = this.DataSetFinancialReport;
            // 
            // TaxBindingSource
            // 
            this.TaxBindingSource.DataMember = "Tax";
            this.TaxBindingSource.DataSource = this.DataSetFinancialReport;
            // 
            // ItemBindingSource
            // 
            this.ItemBindingSource.DataMember = "Item";
            this.ItemBindingSource.DataSource = this.DataSetFinancialReport;
            // 
            // UtilityBindingSource
            // 
            this.UtilityBindingSource.DataMember = "Utility";
            this.UtilityBindingSource.DataSource = this.DataSetFinancialReport;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.SystemColors.ControlLight;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.SystemColors.ControlLight;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.SystemColors.ControlLight;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.SystemColors.ControlLight;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Width = 0;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.SystemColors.ControlLight;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.SystemColors.ControlLight;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.SystemColors.ControlLight;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.SystemColors.ControlLight;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Grand";
            reportDataSource1.Value = this.GrandBindingSource;
            reportDataSource2.Name = "Salary";
            reportDataSource2.Value = this.SalariesBindingSource;
            reportDataSource3.Name = "Rent";
            reportDataSource3.Value = this.RentBindingSource;
            reportDataSource4.Name = "Maintenance";
            reportDataSource4.Value = this.MaintenanceBindingSource;
            reportDataSource5.Name = "Misce";
            reportDataSource5.Value = this.MiscellaneousBindingSource;
            reportDataSource6.Name = "Other";
            reportDataSource6.Value = this.OtherBindingSource;
            reportDataSource7.Name = "Tax";
            reportDataSource7.Value = this.TaxBindingSource;
            reportDataSource8.Name = "Item";
            reportDataSource8.Value = this.ItemBindingSource;
            reportDataSource9.Name = "Utility";
            reportDataSource9.Value = this.UtilityBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RestaurantSystem.View.report.FinancialReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 541);
            this.reportViewer1.TabIndex = 0;
            // 
            // GrandTableAdapter
            // 
            this.GrandTableAdapter.ClearBeforeFill = true;
            // 
            // SalariesTableAdapter
            // 
            this.SalariesTableAdapter.ClearBeforeFill = true;
            // 
            // RentTableAdapter
            // 
            this.RentTableAdapter.ClearBeforeFill = true;
            // 
            // MaintenanceTableAdapter
            // 
            this.MaintenanceTableAdapter.ClearBeforeFill = true;
            // 
            // MiscellaneousTableAdapter
            // 
            this.MiscellaneousTableAdapter.ClearBeforeFill = true;
            // 
            // OtherTableAdapter
            // 
            this.OtherTableAdapter.ClearBeforeFill = true;
            // 
            // TaxTableAdapter
            // 
            this.TaxTableAdapter.ClearBeforeFill = true;
            // 
            // ItemTableAdapter
            // 
            this.ItemTableAdapter.ClearBeforeFill = true;
            // 
            // UtilityTableAdapter
            // 
            this.UtilityTableAdapter.ClearBeforeFill = true;
            // 
            // FinancialReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FinancialReports";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinancialReports";
            this.Load += new System.EventHandler(this.FinancialReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFinancialReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalariesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaintenanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiscellaneousBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UtilityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GrandBindingSource;
        private DataSetFinancialReport DataSetFinancialReport;
        private System.Windows.Forms.BindingSource SalariesBindingSource;
        private System.Windows.Forms.BindingSource RentBindingSource;
        private System.Windows.Forms.BindingSource MaintenanceBindingSource;
        private System.Windows.Forms.BindingSource MiscellaneousBindingSource;
        private System.Windows.Forms.BindingSource OtherBindingSource;
        private System.Windows.Forms.BindingSource TaxBindingSource;
        private System.Windows.Forms.BindingSource ItemBindingSource;
        private System.Windows.Forms.BindingSource UtilityBindingSource;
        private DataSetFinancialReportTableAdapters.GrandTableAdapter GrandTableAdapter;
        private DataSetFinancialReportTableAdapters.SalariesTableAdapter SalariesTableAdapter;
        private DataSetFinancialReportTableAdapters.RentTableAdapter RentTableAdapter;
        private DataSetFinancialReportTableAdapters.MaintenanceTableAdapter MaintenanceTableAdapter;
        private DataSetFinancialReportTableAdapters.MiscellaneousTableAdapter MiscellaneousTableAdapter;
        private DataSetFinancialReportTableAdapters.OtherTableAdapter OtherTableAdapter;
        private DataSetFinancialReportTableAdapters.TaxTableAdapter TaxTableAdapter;
        private DataSetFinancialReportTableAdapters.ItemTableAdapter ItemTableAdapter;
        private DataSetFinancialReportTableAdapters.UtilityTableAdapter UtilityTableAdapter;
    }
}