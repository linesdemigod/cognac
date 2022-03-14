namespace RestaurantSystem.View.user
{
    partial class Manageuser
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
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.dataGridViewMagUser = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMagUser)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel1.Location = new System.Drawing.Point(411, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(174, 35);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Manage User";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(935, 63);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.kryptonPanel3.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.kryptonPanel3.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(32, 77);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 25);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Values.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            // dataGridViewMagUser
            // 
            this.dataGridViewMagUser.AllowUserToAddRows = false;
            this.dataGridViewMagUser.AllowUserToDeleteRows = false;
            this.dataGridViewMagUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMagUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMagUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMagUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.FirstnameColumn,
            this.LastnameColumn,
            this.PhoneColumn,
            this.GenderColumn,
            this.UsernameColumn,
            this.PasswordColumn,
            this.RoleColumn,
            this.UpdateColumn,
            this.DeleteColumn});
            this.dataGridViewMagUser.Location = new System.Drawing.Point(32, 115);
            this.dataGridViewMagUser.Name = "dataGridViewMagUser";
            this.dataGridViewMagUser.ReadOnly = true;
            this.dataGridViewMagUser.Size = new System.Drawing.Size(876, 461);
            this.dataGridViewMagUser.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridViewMagUser.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.dataGridViewMagUser.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.dataGridViewMagUser.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dataGridViewMagUser.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.dataGridViewMagUser.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewMagUser.TabIndex = 7;
            this.dataGridViewMagUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMagUser_CellClick);
            this.dataGridViewMagUser.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewMagUser_CellFormatting);
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "users_id";
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            // 
            // FirstnameColumn
            // 
            this.FirstnameColumn.DataPropertyName = "users_fname";
            this.FirstnameColumn.HeaderText = "Firstname";
            this.FirstnameColumn.Name = "FirstnameColumn";
            this.FirstnameColumn.ReadOnly = true;
            // 
            // LastnameColumn
            // 
            this.LastnameColumn.DataPropertyName = "users_lname";
            this.LastnameColumn.HeaderText = "Lastname";
            this.LastnameColumn.Name = "LastnameColumn";
            this.LastnameColumn.ReadOnly = true;
            // 
            // PhoneColumn
            // 
            this.PhoneColumn.DataPropertyName = "users_phone";
            this.PhoneColumn.HeaderText = "Phone";
            this.PhoneColumn.Name = "PhoneColumn";
            this.PhoneColumn.ReadOnly = true;
            // 
            // GenderColumn
            // 
            this.GenderColumn.DataPropertyName = "users_gender";
            this.GenderColumn.HeaderText = "Gender";
            this.GenderColumn.Name = "GenderColumn";
            this.GenderColumn.ReadOnly = true;
            // 
            // UsernameColumn
            // 
            this.UsernameColumn.DataPropertyName = "users_uid";
            this.UsernameColumn.HeaderText = "Username";
            this.UsernameColumn.Name = "UsernameColumn";
            this.UsernameColumn.ReadOnly = true;
            // 
            // PasswordColumn
            // 
            this.PasswordColumn.DataPropertyName = "users_password";
            this.PasswordColumn.HeaderText = "Password";
            this.PasswordColumn.Name = "PasswordColumn";
            this.PasswordColumn.ReadOnly = true;
            // 
            // RoleColumn
            // 
            this.RoleColumn.DataPropertyName = "role";
            this.RoleColumn.HeaderText = "Role";
            this.RoleColumn.Name = "RoleColumn";
            this.RoleColumn.ReadOnly = true;
            // 
            // UpdateColumn
            // 
            this.UpdateColumn.HeaderText = "Update";
            this.UpdateColumn.Name = "UpdateColumn";
            this.UpdateColumn.ReadOnly = true;
            this.UpdateColumn.Text = "Update";
            this.UpdateColumn.UseColumnTextForButtonValue = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Text = "Delete";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            // 
            // Manageuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(935, 588);
            this.Controls.Add(this.dataGridViewMagUser);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.kryptonPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Manageuser";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manageuser";
            this.Activated += new System.EventHandler(this.Manageuser_Activated);
            this.Load += new System.EventHandler(this.Manageuser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMagUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRefresh;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridViewMagUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleColumn;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
    }
}