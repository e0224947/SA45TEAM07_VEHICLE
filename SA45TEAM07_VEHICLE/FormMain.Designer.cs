namespace SA45TEAM07_VEHICLE
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.enquireStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enquireStatusToolStripMenuItem,
            this.rentVehicleToolStripMenuItem,
            this.returnVehicleToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1262, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // enquireStatusToolStripMenuItem
            // 
            this.enquireStatusToolStripMenuItem.Name = "enquireStatusToolStripMenuItem";
            this.enquireStatusToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.enquireStatusToolStripMenuItem.Text = "&Enquire Status";
            this.enquireStatusToolStripMenuItem.Click += new System.EventHandler(this.enquireStatusToolStripMenuItem_Click);
            // 
            // rentVehicleToolStripMenuItem
            // 
            this.rentVehicleToolStripMenuItem.Name = "rentVehicleToolStripMenuItem";
            this.rentVehicleToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.rentVehicleToolStripMenuItem.Text = "Rent Vehicle";
            this.rentVehicleToolStripMenuItem.Click += new System.EventHandler(this.rentVehicleToolStripMenuItem_Click);
            // 
            // returnVehicleToolStripMenuItem
            // 
            this.returnVehicleToolStripMenuItem.Name = "returnVehicleToolStripMenuItem";
            this.returnVehicleToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.returnVehicleToolStripMenuItem.Text = "Return Vehicle";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.PowderBlue;
            this.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(0, 28);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1262, 115);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to SA45TEAM07 Vehicle Management System";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 713);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblWelcome);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem enquireStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

