namespace MegaDesk
{
    partial class MainMenu
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AddQuoteNavButton = new System.Windows.Forms.Button();
            this.ViewAllQuotesNavButton = new System.Windows.Forms.Button();
            this.SearchQuotesNavButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddQuoteNavButton
            // 
            this.AddQuoteNavButton.Location = new System.Drawing.Point(12, 12);
            this.AddQuoteNavButton.Name = "AddQuoteNavButton";
            this.AddQuoteNavButton.Size = new System.Drawing.Size(106, 52);
            this.AddQuoteNavButton.TabIndex = 0;
            this.AddQuoteNavButton.Text = "&Add New Quote";
            this.AddQuoteNavButton.UseVisualStyleBackColor = true;
            this.AddQuoteNavButton.Click += new System.EventHandler(this.AddQuoteNavButton_Click);
            // 
            // ViewAllQuotesNavButton
            // 
            this.ViewAllQuotesNavButton.Location = new System.Drawing.Point(12, 70);
            this.ViewAllQuotesNavButton.Name = "ViewAllQuotesNavButton";
            this.ViewAllQuotesNavButton.Size = new System.Drawing.Size(106, 52);
            this.ViewAllQuotesNavButton.TabIndex = 1;
            this.ViewAllQuotesNavButton.Text = "&View Quotes";
            this.ViewAllQuotesNavButton.UseVisualStyleBackColor = true;
            this.ViewAllQuotesNavButton.Click += new System.EventHandler(this.ViewAllQuotesNavButton_Click);
            // 
            // SearchQuotesNavButton
            // 
            this.SearchQuotesNavButton.Location = new System.Drawing.Point(12, 128);
            this.SearchQuotesNavButton.Name = "SearchQuotesNavButton";
            this.SearchQuotesNavButton.Size = new System.Drawing.Size(106, 52);
            this.SearchQuotesNavButton.TabIndex = 2;
            this.SearchQuotesNavButton.Text = "&Search Quotes";
            this.SearchQuotesNavButton.UseVisualStyleBackColor = true;
            this.SearchQuotesNavButton.Click += new System.EventHandler(this.SearchQuotesNavButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 186);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(106, 52);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 262);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchQuotesNavButton);
            this.Controls.Add(this.ViewAllQuotesNavButton);
            this.Controls.Add(this.AddQuoteNavButton);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button AddQuoteNavButton;
        private System.Windows.Forms.Button ViewAllQuotesNavButton;
        private System.Windows.Forms.Button SearchQuotesNavButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

