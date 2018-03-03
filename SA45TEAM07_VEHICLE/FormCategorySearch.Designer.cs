namespace SA45TEAM07_VEHICLE
{
    partial class FormCategorySearch
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lbxCategory = new System.Windows.Forms.ListBox();
            this.btnRetreive = new System.Windows.Forms.Button();
            this.dataGridViewAvailableVehicles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.btnRent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableVehicles)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(377, 491);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 31);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbxCategory
            // 
            this.lbxCategory.FormattingEnabled = true;
            this.lbxCategory.ItemHeight = 15;
            this.lbxCategory.Location = new System.Drawing.Point(166, 26);
            this.lbxCategory.Name = "lbxCategory";
            this.lbxCategory.Size = new System.Drawing.Size(236, 64);
            this.lbxCategory.TabIndex = 13;
            // 
            // btnRetreive
            // 
            this.btnRetreive.Location = new System.Drawing.Point(453, 40);
            this.btnRetreive.Name = "btnRetreive";
            this.btnRetreive.Size = new System.Drawing.Size(106, 31);
            this.btnRetreive.TabIndex = 14;
            this.btnRetreive.Text = "Retreive";
            this.btnRetreive.UseVisualStyleBackColor = true;
            this.btnRetreive.Click += new System.EventHandler(this.btnRetreive_Click);
            // 
            // dataGridViewAvailableVehicles
            // 
            this.dataGridViewAvailableVehicles.AllowUserToAddRows = false;
            this.dataGridViewAvailableVehicles.AllowUserToDeleteRows = false;
            this.dataGridViewAvailableVehicles.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAvailableVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableVehicles.Location = new System.Drawing.Point(32, 141);
            this.dataGridViewAvailableVehicles.Name = "dataGridViewAvailableVehicles";
            this.dataGridViewAvailableVehicles.ReadOnly = true;
            this.dataGridViewAvailableVehicles.RowHeadersWidth = 4;
            this.dataGridViewAvailableVehicles.RowTemplate.Height = 23;
            this.dataGridViewAvailableVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAvailableVehicles.Size = new System.Drawing.Size(584, 321);
            this.dataGridViewAvailableVehicles.TabIndex = 16;
            this.dataGridViewAvailableVehicles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAvailableVehicles_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select category:";
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.label1);
            this.gbxCategory.Controls.Add(this.btnRetreive);
            this.gbxCategory.Controls.Add(this.lbxCategory);
            this.gbxCategory.Location = new System.Drawing.Point(31, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(585, 113);
            this.gbxCategory.TabIndex = 18;
            this.gbxCategory.TabStop = false;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(154, 491);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(106, 31);
            this.btnRent.TabIndex = 19;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // FormCategorySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 543);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dataGridViewAvailableVehicles);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormCategorySearch";
            this.Text = "Find Available Vehicles";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCategorySearch_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableVehicles)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbxCategory;
        private System.Windows.Forms.Button btnRetreive;
        private System.Windows.Forms.DataGridView dataGridViewAvailableVehicles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.Button btnRent;
    }
}