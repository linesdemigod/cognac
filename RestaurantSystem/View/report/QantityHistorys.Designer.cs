namespace RestaurantSystem.View.report
{
    partial class QantityHistorys
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
            this.quantityhistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetQuantityHistory = new RestaurantSystem.View.report.DataSetQuantityHistory();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quantityhistoryTableAdapter = new RestaurantSystem.View.report.DataSetQuantityHistoryTableAdapters.quantityhistoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quantityhistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetQuantityHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // quantityhistoryBindingSource
            // 
            this.quantityhistoryBindingSource.DataMember = "quantityhistory";
            this.quantityhistoryBindingSource.DataSource = this.DataSetQuantityHistory;
            // 
            // DataSetQuantityHistory
            // 
            this.DataSetQuantityHistory.DataSetName = "DataSetQuantityHistory";
            this.DataSetQuantityHistory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.quantityhistoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RestaurantSystem.View.report.QuantityHistoryReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // quantityhistoryTableAdapter
            // 
            this.quantityhistoryTableAdapter.ClearBeforeFill = true;
            // 
            // QantityHistorys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "QantityHistorys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QantityHistorys";
            this.Load += new System.EventHandler(this.QantityHistorys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantityhistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetQuantityHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource quantityhistoryBindingSource;
        private DataSetQuantityHistory DataSetQuantityHistory;
        private DataSetQuantityHistoryTableAdapters.quantityhistoryTableAdapter quantityhistoryTableAdapter;
    }
}