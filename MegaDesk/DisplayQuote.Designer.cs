namespace MegaDesk
{
    partial class DisplayQuote
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
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.OrderDateLabel = new System.Windows.Forms.Label();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.DrawerLabel = new System.Windows.Forms.Label();
            this.SurfaceMaterialLabel = new System.Windows.Forms.Label();
            this.RushOrderLabel = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(218, 9);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.CustomerNameLabel.TabIndex = 0;
            this.CustomerNameLabel.Text = "Customer Name";
            // 
            // OrderDateLabel
            // 
            this.OrderDateLabel.AutoSize = true;
            this.OrderDateLabel.Location = new System.Drawing.Point(218, 35);
            this.OrderDateLabel.Name = "OrderDateLabel";
            this.OrderDateLabel.Size = new System.Drawing.Size(59, 13);
            this.OrderDateLabel.TabIndex = 1;
            this.OrderDateLabel.Text = "Order Date";
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Location = new System.Drawing.Point(11, 35);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(36, 13);
            this.DepthLabel.TabIndex = 3;
            this.DepthLabel.Text = "Depth";
            // 
            // DrawerLabel
            // 
            this.DrawerLabel.AutoSize = true;
            this.DrawerLabel.Location = new System.Drawing.Point(11, 60);
            this.DrawerLabel.Name = "DrawerLabel";
            this.DrawerLabel.Size = new System.Drawing.Size(46, 13);
            this.DrawerLabel.TabIndex = 4;
            this.DrawerLabel.Text = "Drawers";
            // 
            // SurfaceMaterialLabel
            // 
            this.SurfaceMaterialLabel.AutoSize = true;
            this.SurfaceMaterialLabel.Location = new System.Drawing.Point(11, 85);
            this.SurfaceMaterialLabel.Name = "SurfaceMaterialLabel";
            this.SurfaceMaterialLabel.Size = new System.Drawing.Size(84, 13);
            this.SurfaceMaterialLabel.TabIndex = 5;
            this.SurfaceMaterialLabel.Text = "Surface Material";
            // 
            // RushOrderLabel
            // 
            this.RushOrderLabel.AutoSize = true;
            this.RushOrderLabel.Location = new System.Drawing.Point(11, 110);
            this.RushOrderLabel.Name = "RushOrderLabel";
            this.RushOrderLabel.Size = new System.Drawing.Size(88, 13);
            this.RushOrderLabel.TabIndex = 6;
            this.RushOrderLabel.Text = "Rush Order Days";
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Location = new System.Drawing.Point(11, 135);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(55, 13);
            this.TotalCostLabel.TabIndex = 7;
            this.TotalCostLabel.Text = "Total Cost";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(11, 10);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(35, 13);
            this.WidthLabel.TabIndex = 2;
            this.WidthLabel.Text = "Width";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 159);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.RushOrderLabel);
            this.Controls.Add(this.SurfaceMaterialLabel);
            this.Controls.Add(this.DrawerLabel);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.OrderDateLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label OrderDateLabel;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.Label DrawerLabel;
        private System.Windows.Forms.Label SurfaceMaterialLabel;
        private System.Windows.Forms.Label RushOrderLabel;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Label WidthLabel;
    }
}