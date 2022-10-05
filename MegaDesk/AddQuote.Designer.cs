namespace MegaDesk
{
    partial class AddQuote
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
            this.ReturnButton = new System.Windows.Forms.Button();
            this.SurfaceMaterialCombobox = new System.Windows.Forms.ComboBox();
            this.DrawerCombobox = new System.Windows.Forms.ComboBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.DepthTextBox = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductionTimeLabel = new System.Windows.Forms.Label();
            this.DeskMaterialLabel = new System.Windows.Forms.Label();
            this.ProductionTimeCombobox = new System.Windows.Forms.ComboBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ReturnButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ReturnButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ReturnButton.Location = new System.Drawing.Point(12, 163);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 0;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // SurfaceMaterialCombobox
            // 
            this.SurfaceMaterialCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SurfaceMaterialCombobox.FormattingEnabled = true;
            this.SurfaceMaterialCombobox.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.SurfaceMaterialCombobox.Location = new System.Drawing.Point(262, 91);
            this.SurfaceMaterialCombobox.Name = "SurfaceMaterialCombobox";
            this.SurfaceMaterialCombobox.Size = new System.Drawing.Size(121, 21);
            this.SurfaceMaterialCombobox.TabIndex = 1;
            // 
            // DrawerCombobox
            // 
            this.DrawerCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrawerCombobox.FormattingEnabled = true;
            this.DrawerCombobox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.DrawerCombobox.Location = new System.Drawing.Point(64, 91);
            this.DrawerCombobox.Name = "DrawerCombobox";
            this.DrawerCombobox.Size = new System.Drawing.Size(60, 21);
            this.DrawerCombobox.TabIndex = 2;
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(64, 40);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(60, 20);
            this.WidthTextBox.TabIndex = 3;
            this.WidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // DepthTextBox
            // 
            this.DepthTextBox.Location = new System.Drawing.Point(64, 65);
            this.DepthTextBox.Name = "DepthTextBox";
            this.DepthTextBox.Size = new System.Drawing.Size(60, 20);
            this.DepthTextBox.TabIndex = 4;
            this.DepthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(13, 43);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(35, 13);
            this.WidthLabel.TabIndex = 5;
            this.WidthLabel.Text = "Width";
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Location = new System.Drawing.Point(13, 69);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(36, 13);
            this.DepthLabel.TabIndex = 6;
            this.DepthLabel.Text = "Depth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Drawers";
            // 
            // ProductionTimeLabel
            // 
            this.ProductionTimeLabel.AutoSize = true;
            this.ProductionTimeLabel.Location = new System.Drawing.Point(163, 68);
            this.ProductionTimeLabel.Name = "ProductionTimeLabel";
            this.ProductionTimeLabel.Size = new System.Drawing.Size(84, 13);
            this.ProductionTimeLabel.TabIndex = 8;
            this.ProductionTimeLabel.Text = "Production Time";
            // 
            // DeskMaterialLabel
            // 
            this.DeskMaterialLabel.AutoSize = true;
            this.DeskMaterialLabel.Location = new System.Drawing.Point(163, 94);
            this.DeskMaterialLabel.Name = "DeskMaterialLabel";
            this.DeskMaterialLabel.Size = new System.Drawing.Size(72, 13);
            this.DeskMaterialLabel.TabIndex = 9;
            this.DeskMaterialLabel.Text = "Desk Material";
            // 
            // ProductionTimeCombobox
            // 
            this.ProductionTimeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductionTimeCombobox.FormattingEnabled = true;
            this.ProductionTimeCombobox.Items.AddRange(new object[] {
            "3 days",
            "5 days",
            "7 days",
            "14 days"});
            this.ProductionTimeCombobox.Location = new System.Drawing.Point(262, 66);
            this.ProductionTimeCombobox.Name = "ProductionTimeCombobox";
            this.ProductionTimeCombobox.Size = new System.Drawing.Size(121, 21);
            this.ProductionTimeCombobox.TabIndex = 10;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(308, 118);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 11;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(13, 9);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(75, 13);
            this.ErrorMessageLabel.TabIndex = 12;
            this.ErrorMessageLabel.Text = "Error Message";
            this.ErrorMessageLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customer Name";
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(262, 42);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.CustomerNameTextBox.TabIndex = 14;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 198);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ProductionTimeCombobox);
            this.Controls.Add(this.DeskMaterialLabel);
            this.Controls.Add(this.ProductionTimeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.DepthTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.DrawerCombobox);
            this.Controls.Add(this.SurfaceMaterialCombobox);
            this.Controls.Add(this.ReturnButton);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.ComboBox SurfaceMaterialCombobox;
        private System.Windows.Forms.ComboBox DrawerCombobox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox DepthTextBox;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ProductionTimeLabel;
        private System.Windows.Forms.Label DeskMaterialLabel;
        private System.Windows.Forms.ComboBox ProductionTimeCombobox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
    }
}