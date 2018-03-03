namespace SA45TEAM07_VEHICLE
{
    partial class FormVehicleDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbModel = new System.Windows.Forms.TextBox();
            this.txbPlateNum = new System.Windows.Forms.TextBox();
            this.txbColor = new System.Windows.Forms.TextBox();
            this.txbEngineSerialNo = new System.Windows.Forms.TextBox();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plate Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Engine Serial No.:";
            // 
            // txbModel
            // 
            this.txbModel.Location = new System.Drawing.Point(166, 35);
            this.txbModel.Name = "txbModel";
            this.txbModel.ReadOnly = true;
            this.txbModel.Size = new System.Drawing.Size(206, 23);
            this.txbModel.TabIndex = 4;
            // 
            // txbPlateNum
            // 
            this.txbPlateNum.Location = new System.Drawing.Point(166, 85);
            this.txbPlateNum.Name = "txbPlateNum";
            this.txbPlateNum.ReadOnly = true;
            this.txbPlateNum.Size = new System.Drawing.Size(206, 23);
            this.txbPlateNum.TabIndex = 5;
            // 
            // txbColor
            // 
            this.txbColor.Location = new System.Drawing.Point(166, 129);
            this.txbColor.Name = "txbColor";
            this.txbColor.ReadOnly = true;
            this.txbColor.Size = new System.Drawing.Size(206, 23);
            this.txbColor.TabIndex = 6;
            // 
            // txbEngineSerialNo
            // 
            this.txbEngineSerialNo.Location = new System.Drawing.Point(166, 175);
            this.txbEngineSerialNo.Name = "txbEngineSerialNo";
            this.txbEngineSerialNo.ReadOnly = true;
            this.txbEngineSerialNo.Size = new System.Drawing.Size(206, 23);
            this.txbEngineSerialNo.TabIndex = 7;
            // 
            // txbStatus
            // 
            this.txbStatus.Location = new System.Drawing.Point(165, 35);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.ReadOnly = true;
            this.txbStatus.Size = new System.Drawing.Size(206, 23);
            this.txbStatus.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Status:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbEngineSerialNo);
            this.groupBox1.Controls.Add(this.txbColor);
            this.groupBox1.Controls.Add(this.txbPlateNum);
            this.groupBox1.Controls.Add(this.txbModel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 230);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbStatus);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(46, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 86);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(184, 383);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 31);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormVehicleDetails
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(496, 449);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVehicleDetails";
            this.Text = "Vehicle Information";
            this.Load += new System.EventHandler(this.FormVehicleDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbModel;
        private System.Windows.Forms.TextBox txbPlateNum;
        private System.Windows.Forms.TextBox txbColor;
        private System.Windows.Forms.TextBox txbEngineSerialNo;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
    }
}