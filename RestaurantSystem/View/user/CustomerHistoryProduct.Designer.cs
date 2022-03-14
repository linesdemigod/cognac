namespace RestaurantSystem.View.user
{
    partial class CustomerHistoryProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerHistoryProduct));
            this.kryptonGroupBox3 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnPrint = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblvatttt = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.dataGridViewPrint = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.PrintID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).BeginInit();
            this.kryptonGroupBox3.Panel.SuspendLayout();
            this.kryptonGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroupBox3
            // 
            this.kryptonGroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonGroupBox3.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonGroupBox3.Location = new System.Drawing.Point(15, 46);
            this.kryptonGroupBox3.Name = "kryptonGroupBox3";
            // 
            // kryptonGroupBox3.Panel
            // 
            this.kryptonGroupBox3.Panel.Controls.Add(this.lblName);
            this.kryptonGroupBox3.Panel.Controls.Add(this.btnPrint);
            this.kryptonGroupBox3.Panel.Controls.Add(this.lblvatttt);
            this.kryptonGroupBox3.Panel.Controls.Add(this.lblSubTotal);
            this.kryptonGroupBox3.Panel.Controls.Add(this.label3);
            this.kryptonGroupBox3.Panel.Controls.Add(this.lblVat);
            this.kryptonGroupBox3.Panel.Controls.Add(this.label4);
            this.kryptonGroupBox3.Panel.Controls.Add(this.lblGrandTotal);
            this.kryptonGroupBox3.Panel.Controls.Add(this.label2);
            this.kryptonGroupBox3.Panel.Controls.Add(this.lblDiscount);
            this.kryptonGroupBox3.Panel.Controls.Add(this.dataGridViewPrint);
            this.kryptonGroupBox3.Size = new System.Drawing.Size(806, 414);
            this.kryptonGroupBox3.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonGroupBox3.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonGroupBox3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox3.TabIndex = 40;
            this.kryptonGroupBox3.Values.Heading = "History by Product";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Location = new System.Drawing.Point(551, 242);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnPrint.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnPrint.OverrideDefault.Back.ColorAngle = 45F;
            this.btnPrint.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnPrint.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnPrint.OverrideDefault.Border.ColorAngle = 45F;
            this.btnPrint.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPrint.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnPrint.OverrideDefault.Border.Rounding = 6;
            this.btnPrint.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnPrint.Size = new System.Drawing.Size(148, 32);
            this.btnPrint.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnPrint.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnPrint.StateCommon.Back.ColorAngle = 45F;
            this.btnPrint.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnPrint.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnPrint.StateCommon.Border.ColorAngle = 45F;
            this.btnPrint.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPrint.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnPrint.StateCommon.Border.Rounding = 6;
            this.btnPrint.StateCommon.Border.Width = 1;
            this.btnPrint.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnPrint.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnPrint.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnPrint.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnPrint.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnPrint.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(150)))));
            this.btnPrint.StatePressed.Back.ColorAngle = 135F;
            this.btnPrint.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnPrint.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnPrint.StatePressed.Border.ColorAngle = 135F;
            this.btnPrint.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPrint.StatePressed.Border.Rounding = 6;
            this.btnPrint.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnPrint.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnPrint.StateTracking.Back.ColorAngle = 45F;
            this.btnPrint.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnPrint.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnPrint.StateTracking.Border.ColorAngle = 45F;
            this.btnPrint.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPrint.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnPrint.StateTracking.Border.Rounding = 6;
            this.btnPrint.TabIndex = 59;
            this.btnPrint.Values.Text = "Reprint Receipt";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblvatttt
            // 
            this.lblvatttt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblvatttt.AutoSize = true;
            this.lblvatttt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvatttt.Location = new System.Drawing.Point(546, 97);
            this.lblvatttt.Name = "lblvatttt";
            this.lblvatttt.Size = new System.Drawing.Size(43, 19);
            this.lblvatttt.TabIndex = 51;
            this.lblvatttt.Text = "VAT:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(655, 157);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(19, 21);
            this.lblSubTotal.TabIndex = 57;
            this.lblSubTotal.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "SubTotal:";
            // 
            // lblVat
            // 
            this.lblVat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(655, 96);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(19, 21);
            this.lblVat.TabIndex = 55;
            this.lblVat.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(547, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 54;
            this.label4.Text = "Grand Total:";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(655, 187);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(19, 21);
            this.lblGrandTotal.TabIndex = 58;
            this.lblGrandTotal.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(547, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Discount:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(655, 128);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(19, 21);
            this.lblDiscount.TabIndex = 56;
            this.lblDiscount.Text = "0";
            // 
            // dataGridViewPrint
            // 
            this.dataGridViewPrint.AllowUserToAddRows = false;
            this.dataGridViewPrint.AllowUserToDeleteRows = false;
            this.dataGridViewPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrintID,
            this.PrintProduct,
            this.PrintPrice,
            this.PrintQty,
            this.PrintSubTotal});
            this.dataGridViewPrint.Location = new System.Drawing.Point(30, 56);
            this.dataGridViewPrint.Name = "dataGridViewPrint";
            this.dataGridViewPrint.ReadOnly = true;
            this.dataGridViewPrint.RowHeadersVisible = false;
            this.dataGridViewPrint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPrint.Size = new System.Drawing.Size(471, 268);
            this.dataGridViewPrint.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridViewPrint.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.dataGridViewPrint.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.dataGridViewPrint.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dataGridViewPrint.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dataGridViewPrint.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewPrint.TabIndex = 40;
            // 
            // PrintID
            // 
            this.PrintID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrintID.DataPropertyName = "ord_bill_number";
            this.PrintID.HeaderText = "Bill ID";
            this.PrintID.Name = "PrintID";
            this.PrintID.ReadOnly = true;
            // 
            // PrintProduct
            // 
            this.PrintProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PrintProduct.DataPropertyName = "pro_name";
            this.PrintProduct.HeaderText = "Product";
            this.PrintProduct.Name = "PrintProduct";
            this.PrintProduct.ReadOnly = true;
            this.PrintProduct.Width = 86;
            // 
            // PrintPrice
            // 
            this.PrintPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PrintPrice.DataPropertyName = "pro_price";
            this.PrintPrice.HeaderText = "Price";
            this.PrintPrice.Name = "PrintPrice";
            this.PrintPrice.ReadOnly = true;
            this.PrintPrice.Width = 69;
            // 
            // PrintQty
            // 
            this.PrintQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PrintQty.DataPropertyName = "ordit_quantity";
            this.PrintQty.HeaderText = "Qty";
            this.PrintQty.Name = "PrintQty";
            this.PrintQty.ReadOnly = true;
            this.PrintQty.Width = 60;
            // 
            // PrintSubTotal
            // 
            this.PrintSubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PrintSubTotal.DataPropertyName = "ordit_amount";
            this.PrintSubTotal.HeaderText = "SubTotal";
            this.PrintSubTotal.Name = "PrintSubTotal";
            this.PrintSubTotal.ReadOnly = true;
            this.PrintSubTotal.Width = 92;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Width = 0;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(558, 303);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(19, 21);
            this.lblName.TabIndex = 60;
            this.lblName.Text = "0";
            this.lblName.Visible = false;
            // 
            // CustomerHistoryProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 512);
            this.Controls.Add(this.kryptonGroupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerHistoryProduct";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerHistoryProduct";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).EndInit();
            this.kryptonGroupBox3.Panel.ResumeLayout(false);
            this.kryptonGroupBox3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).EndInit();
            this.kryptonGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPrint;
        private System.Windows.Forms.Label lblvatttt;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDiscount;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridViewPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrintID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrintProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrintPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrintQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrintSubTotal;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lblName;
    }
}