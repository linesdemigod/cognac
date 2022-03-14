namespace RestaurantSystem.View.user
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btnRemoveItem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblBillID = new System.Windows.Forms.Label();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dataGridViewBill = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrder = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtChange = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAmountPaid = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiscount = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewAutoComplete = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAutoComplete = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboSearchFilter = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.dataGridViewProduct = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProduct = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblBillToName = new System.Windows.Forms.Label();
            this.lblBillToID = new System.Windows.Forms.Label();
            this.panelBillTo = new System.Windows.Forms.Panel();
            this.lblClose = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.comboAuto = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.popupNotifierItem = new Tulpep.NotificationWindow.PopupNotifier();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutoComplete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboSearchFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.panelBillTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
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
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveItem.Location = new System.Drawing.Point(25, 383);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveItem.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveItem.OverrideDefault.Back.ColorAngle = 45F;
            this.btnRemoveItem.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnRemoveItem.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnRemoveItem.OverrideDefault.Border.ColorAngle = 45F;
            this.btnRemoveItem.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemoveItem.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnRemoveItem.OverrideDefault.Border.Rounding = 6;
            this.btnRemoveItem.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnRemoveItem.Size = new System.Drawing.Size(133, 32);
            this.btnRemoveItem.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveItem.StateCommon.Back.Color2 = System.Drawing.Color.Red;
            this.btnRemoveItem.StateCommon.Back.ColorAngle = 45F;
            this.btnRemoveItem.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnRemoveItem.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnRemoveItem.StateCommon.Border.ColorAngle = 45F;
            this.btnRemoveItem.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemoveItem.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnRemoveItem.StateCommon.Border.Rounding = 6;
            this.btnRemoveItem.StateCommon.Border.Width = 1;
            this.btnRemoveItem.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRemoveItem.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnRemoveItem.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveItem.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveItem.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveItem.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveItem.StatePressed.Back.ColorAngle = 135F;
            this.btnRemoveItem.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnRemoveItem.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnRemoveItem.StatePressed.Border.ColorAngle = 135F;
            this.btnRemoveItem.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemoveItem.StatePressed.Border.Rounding = 6;
            this.btnRemoveItem.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveItem.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveItem.StateTracking.Back.ColorAngle = 45F;
            this.btnRemoveItem.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnRemoveItem.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnRemoveItem.StateTracking.Border.ColorAngle = 45F;
            this.btnRemoveItem.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemoveItem.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnRemoveItem.StateTracking.Border.Rounding = 6;
            this.btnRemoveItem.TabIndex = 55;
            this.btnRemoveItem.Values.Text = "Remove Item";
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // lblBillID
            // 
            this.lblBillID.AutoSize = true;
            this.lblBillID.Location = new System.Drawing.Point(22, 11);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(41, 13);
            this.lblBillID.TabIndex = 53;
            this.lblBillID.Text = "label13";
            this.lblBillID.Visible = false;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonButton1.Location = new System.Drawing.Point(25, 486);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(133, 38);
            this.kryptonButton1.TabIndex = 54;
            this.kryptonButton1.Values.Text = "Preview";
            this.kryptonButton1.Visible = false;
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.AllowUserToAddRows = false;
            this.dataGridViewBill.AllowUserToDeleteRows = false;
            this.dataGridViewBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column12});
            this.dataGridViewBill.Location = new System.Drawing.Point(178, 383);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.RowHeadersWidth = 51;
            this.dataGridViewBill.Size = new System.Drawing.Size(735, 193);
            this.dataGridViewBill.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridViewBill.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.dataGridViewBill.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.dataGridViewBill.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dataGridViewBill.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dataGridViewBill.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewBill.TabIndex = 52;
            this.dataGridViewBill.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBill_CellEndEdit);
            this.dataGridViewBill.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewBill_CellValidating);
            this.dataGridViewBill.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Order_MouseClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Item #";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 73;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Product";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.HeaderText = "Qty";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 57;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 67;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Description";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.HeaderText = "Subtotal";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 83;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "ID";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            this.Column12.Width = 125;
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Location = new System.Drawing.Point(25, 437);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnOrder.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnOrder.OverrideDefault.Back.ColorAngle = 45F;
            this.btnOrder.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnOrder.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnOrder.OverrideDefault.Border.ColorAngle = 45F;
            this.btnOrder.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOrder.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnOrder.OverrideDefault.Border.Rounding = 6;
            this.btnOrder.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnOrder.Size = new System.Drawing.Size(133, 32);
            this.btnOrder.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnOrder.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnOrder.StateCommon.Back.ColorAngle = 45F;
            this.btnOrder.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnOrder.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnOrder.StateCommon.Border.ColorAngle = 45F;
            this.btnOrder.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOrder.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnOrder.StateCommon.Border.Rounding = 6;
            this.btnOrder.StateCommon.Border.Width = 1;
            this.btnOrder.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnOrder.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnOrder.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnOrder.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnOrder.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnOrder.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(150)))));
            this.btnOrder.StatePressed.Back.ColorAngle = 135F;
            this.btnOrder.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnOrder.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnOrder.StatePressed.Border.ColorAngle = 135F;
            this.btnOrder.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOrder.StatePressed.Border.Rounding = 6;
            this.btnOrder.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnOrder.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnOrder.StateTracking.Back.ColorAngle = 45F;
            this.btnOrder.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnOrder.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnOrder.StateTracking.Border.ColorAngle = 45F;
            this.btnOrder.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOrder.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnOrder.StateTracking.Border.Rounding = 6;
            this.btnOrder.TabIndex = 51;
            this.btnOrder.Values.Text = "Place Order";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(634, 27);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.label11);
            this.kryptonGroupBox2.Panel.Controls.Add(this.label4);
            this.kryptonGroupBox2.Panel.Controls.Add(this.label3);
            this.kryptonGroupBox2.Panel.Controls.Add(this.label2);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lblVat);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lblGrandTotal);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lblSubTotal);
            this.kryptonGroupBox2.Panel.Controls.Add(this.txtChange);
            this.kryptonGroupBox2.Panel.Controls.Add(this.label10);
            this.kryptonGroupBox2.Panel.Controls.Add(this.txtAmountPaid);
            this.kryptonGroupBox2.Panel.Controls.Add(this.label9);
            this.kryptonGroupBox2.Panel.Controls.Add(this.label8);
            this.kryptonGroupBox2.Panel.Controls.Add(this.label7);
            this.kryptonGroupBox2.Panel.Controls.Add(this.txtDiscount);
            this.kryptonGroupBox2.Panel.Controls.Add(this.label6);
            this.kryptonGroupBox2.Panel.Controls.Add(this.label5);
            this.kryptonGroupBox2.Panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Order_MouseClick);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(279, 310);
            this.kryptonGroupBox2.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonGroupBox2.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonGroupBox2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox2.StateCommon.Border.Rounding = 6;
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.TabIndex = 50;
            this.kryptonGroupBox2.Values.Heading = "Transaction Details";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(127, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "₵";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "₵";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "₵";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "₵";
            // 
            // lblVat
            // 
            this.lblVat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(143, 112);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(17, 20);
            this.lblVat.TabIndex = 48;
            this.lblVat.Text = "0";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(143, 151);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(18, 19);
            this.lblGrandTotal.TabIndex = 50;
            this.lblGrandTotal.Text = "0";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(143, 21);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(17, 20);
            this.lblSubTotal.TabIndex = 49;
            this.lblSubTotal.Text = "0";
            this.lblSubTotal.TextChanged += new System.EventHandler(this.lblSubTotal_TextChanged);
            // 
            // txtChange
            // 
            this.txtChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtChange.Location = new System.Drawing.Point(144, 240);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(98, 27);
            this.txtChange.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtChange.StateCommon.Border.Rounding = 6;
            this.txtChange.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "Change";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmountPaid.Location = new System.Drawing.Point(141, 190);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(94, 27);
            this.txtAmountPaid.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAmountPaid.StateCommon.Border.Rounding = 6;
            this.txtAmountPaid.TabIndex = 44;
            this.txtAmountPaid.TextChanged += new System.EventHandler(this.txtAmountPaid_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Amt Paid";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Grand Total";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "VAT(13%)";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiscount.Location = new System.Drawing.Point(147, 60);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(93, 27);
            this.txtDiscount.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDiscount.StateCommon.Border.Rounding = 6;
            this.txtDiscount.TabIndex = 38;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Discount";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Sub Total";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(25, 27);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.label12);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dataGridViewAutoComplete);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtAutoComplete);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label15);
            this.kryptonGroupBox1.Panel.Controls.Add(this.comboSearchFilter);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dataGridViewProduct);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtProduct);
            this.kryptonGroupBox1.Panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Order_MouseClick);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(593, 310);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonGroupBox1.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Border.Rounding = 6;
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.TabIndex = 49;
            this.kryptonGroupBox1.Values.Heading = "Product Details";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(399, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 20);
            this.label12.TabIndex = 52;
            this.label12.Text = "Bill To";
            // 
            // dataGridViewAutoComplete
            // 
            this.dataGridViewAutoComplete.AllowUserToAddRows = false;
            this.dataGridViewAutoComplete.AllowUserToDeleteRows = false;
            this.dataGridViewAutoComplete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewAutoComplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAutoComplete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewAutoComplete.Location = new System.Drawing.Point(375, 60);
            this.dataGridViewAutoComplete.Name = "dataGridViewAutoComplete";
            this.dataGridViewAutoComplete.ReadOnly = true;
            this.dataGridViewAutoComplete.RowHeadersVisible = false;
            this.dataGridViewAutoComplete.RowHeadersWidth = 51;
            this.dataGridViewAutoComplete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAutoComplete.Size = new System.Drawing.Size(187, 82);
            this.dataGridViewAutoComplete.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridViewAutoComplete.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Silver;
            this.dataGridViewAutoComplete.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Silver;
            this.dataGridViewAutoComplete.StateCommon.HeaderColumn.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dataGridViewAutoComplete.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dataGridViewAutoComplete.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dataGridViewAutoComplete.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewAutoComplete.TabIndex = 51;
            this.dataGridViewAutoComplete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAutoComplete_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 74;
            // 
            // txtAutoComplete
            // 
            this.txtAutoComplete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAutoComplete.Location = new System.Drawing.Point(393, 32);
            this.txtAutoComplete.Name = "txtAutoComplete";
            this.txtAutoComplete.Size = new System.Drawing.Size(166, 27);
            this.txtAutoComplete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAutoComplete.StateCommon.Border.Rounding = 6;
            this.txtAutoComplete.TabIndex = 50;
            this.txtAutoComplete.TextChanged += new System.EventHandler(this.txtAutoComplete_TextChanged);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(217, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 20);
            this.label15.TabIndex = 49;
            this.label15.Text = "Category";
            // 
            // comboSearchFilter
            // 
            this.comboSearchFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboSearchFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearchFilter.DropDownWidth = 148;
            this.comboSearchFilter.Location = new System.Drawing.Point(218, 32);
            this.comboSearchFilter.Name = "comboSearchFilter";
            this.comboSearchFilter.Size = new System.Drawing.Size(152, 25);
            this.comboSearchFilter.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboSearchFilter.StateCommon.ComboBox.Border.Rounding = 6;
            this.comboSearchFilter.TabIndex = 48;
            this.comboSearchFilter.SelectedIndexChanged += new System.EventHandler(this.comboSearchFilter_SelectedIndexChanged);
            this.comboSearchFilter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Order_MouseClick);
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column11,
            this.Column10,
            this.Column15});
            this.dataGridViewProduct.Location = new System.Drawing.Point(38, 78);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            this.dataGridViewProduct.RowHeadersVisible = false;
            this.dataGridViewProduct.RowHeadersWidth = 51;
            this.dataGridViewProduct.Size = new System.Drawing.Size(517, 186);
            this.dataGridViewProduct.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridViewProduct.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.dataGridViewProduct.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.dataGridViewProduct.StateCommon.HeaderColumn.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dataGridViewProduct.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dataGridViewProduct.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dataGridViewProduct.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewProduct.TabIndex = 41;
            this.dataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellClick);
            this.dataGridViewProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Order_MouseClick);
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column7.DataPropertyName = "ID";
            this.Column7.HeaderText = "ID";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "Food";
            this.Column8.HeaderText = "Product";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column9.DataPropertyName = "Price";
            this.Column9.HeaderText = "Price";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 67;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Stock";
            this.Column11.HeaderText = "Stock";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 125;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "Description";
            this.Column10.HeaderText = "Description";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "Cat";
            this.Column15.HeaderText = "Category";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Visible = false;
            this.Column15.Width = 125;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Search By Product Name";
            // 
            // txtProduct
            // 
            this.txtProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProduct.Location = new System.Drawing.Point(38, 32);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(166, 27);
            this.txtProduct.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProduct.StateCommon.Border.Rounding = 6;
            this.txtProduct.TabIndex = 27;
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            this.txtProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Order_MouseClick);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 18);
            this.label13.TabIndex = 56;
            this.label13.Text = "Bill To:";
            // 
            // lblBillToName
            // 
            this.lblBillToName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBillToName.AutoSize = true;
            this.lblBillToName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillToName.Location = new System.Drawing.Point(64, 8);
            this.lblBillToName.Name = "lblBillToName";
            this.lblBillToName.Size = new System.Drawing.Size(0, 20);
            this.lblBillToName.TabIndex = 57;
            // 
            // lblBillToID
            // 
            this.lblBillToID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBillToID.AutoSize = true;
            this.lblBillToID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillToID.Location = new System.Drawing.Point(269, 10);
            this.lblBillToID.Name = "lblBillToID";
            this.lblBillToID.Size = new System.Drawing.Size(17, 20);
            this.lblBillToID.TabIndex = 58;
            this.lblBillToID.Text = "0";
            this.lblBillToID.Visible = false;
            // 
            // panelBillTo
            // 
            this.panelBillTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBillTo.Controls.Add(this.lblClose);
            this.panelBillTo.Controls.Add(this.lblBillToName);
            this.panelBillTo.Controls.Add(this.lblBillToID);
            this.panelBillTo.Controls.Add(this.label13);
            this.panelBillTo.Location = new System.Drawing.Point(178, 342);
            this.panelBillTo.Name = "panelBillTo";
            this.panelBillTo.Size = new System.Drawing.Size(735, 36);
            this.panelBillTo.TabIndex = 59;
            // 
            // lblClose
            // 
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Location = new System.Drawing.Point(308, 11);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(22, 18);
            this.lblClose.TabIndex = 60;
            this.lblClose.Values.Image = global::RestaurantSystem.Properties.Resources.del;
            this.lblClose.Values.Text = "";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // comboAuto
            // 
            this.comboAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboAuto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboAuto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboAuto.DropDownWidth = 148;
            this.comboAuto.Location = new System.Drawing.Point(6, 540);
            this.comboAuto.Name = "comboAuto";
            this.comboAuto.Size = new System.Drawing.Size(152, 25);
            this.comboAuto.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboAuto.StateCommon.ComboBox.Border.Rounding = 6;
            this.comboAuto.TabIndex = 53;
            this.comboAuto.Visible = false;
            // 
            // popupNotifierItem
            // 
            this.popupNotifierItem.ContentFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popupNotifierItem.ContentText = null;
            this.popupNotifierItem.Image = null;
            this.popupNotifierItem.IsRightToLeft = false;
            this.popupNotifierItem.OptionsMenu = null;
            this.popupNotifierItem.Size = new System.Drawing.Size(400, 100);
            this.popupNotifierItem.TitleFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popupNotifierItem.TitleText = null;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(935, 588);
            this.Controls.Add(this.comboAuto);
            this.Controls.Add(this.panelBillTo);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.lblBillID);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.dataGridViewBill);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.kryptonGroupBox2);
            this.Controls.Add(this.kryptonGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Order";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Order_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutoComplete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboSearchFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.panelBillTo.ResumeLayout(false);
            this.panelBillTo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRemoveItem;
        private System.Windows.Forms.Label lblBillID;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridViewBill;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOrder;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtChange;
        private System.Windows.Forms.Label label10;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAmountPaid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private System.Windows.Forms.Label label15;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboSearchFilter;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridViewProduct;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProduct;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAutoComplete;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridViewAutoComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblBillToName;
        private System.Windows.Forms.Label lblBillToID;
        private System.Windows.Forms.Panel panelBillTo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboAuto;
        private Tulpep.NotificationWindow.PopupNotifier popupNotifierItem;
    }
}