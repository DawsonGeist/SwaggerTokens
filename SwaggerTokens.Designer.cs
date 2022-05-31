namespace SwaggerTokens
{
    partial class SwaggerTokens
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblSwaggerTokens = new System.Windows.Forms.Label();
            this.btnAddTokens = new System.Windows.Forms.Button();
            this.btnTokenHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(308, 37);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Current Swagger Tokens:";
            // 
            // lblSwaggerTokens
            // 
            this.lblSwaggerTokens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSwaggerTokens.AutoSize = true;
            this.lblSwaggerTokens.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSwaggerTokens.Location = new System.Drawing.Point(12, 46);
            this.lblSwaggerTokens.Name = "lblSwaggerTokens";
            this.lblSwaggerTokens.Size = new System.Drawing.Size(246, 191);
            this.lblSwaggerTokens.TabIndex = 1;
            this.lblSwaggerTokens.Text = "80";
            this.lblSwaggerTokens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddTokens
            // 
            this.btnAddTokens.Location = new System.Drawing.Point(12, 265);
            this.btnAddTokens.Name = "btnAddTokens";
            this.btnAddTokens.Size = new System.Drawing.Size(284, 52);
            this.btnAddTokens.TabIndex = 2;
            this.btnAddTokens.Text = "Add Tokens";
            this.btnAddTokens.UseVisualStyleBackColor = true;
            this.btnAddTokens.Click += new System.EventHandler(this.btnAddTokens_Click);
            // 
            // btnTokenHistory
            // 
            this.btnTokenHistory.Location = new System.Drawing.Point(302, 265);
            this.btnTokenHistory.Name = "btnTokenHistory";
            this.btnTokenHistory.Size = new System.Drawing.Size(284, 52);
            this.btnTokenHistory.TabIndex = 3;
            this.btnTokenHistory.Text = "History";
            this.btnTokenHistory.UseVisualStyleBackColor = true;
            this.btnTokenHistory.Click += new System.EventHandler(this.btnTokenHistory_Click);
            // 
            // SwaggerTokens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(597, 329);
            this.Controls.Add(this.btnTokenHistory);
            this.Controls.Add(this.btnAddTokens);
            this.Controls.Add(this.lblSwaggerTokens);
            this.Controls.Add(this.lblDescription);
            this.Name = "SwaggerTokens";
            this.Text = "Swagger Tokens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSwaggerTokens;
        private System.Windows.Forms.Button btnAddTokens;
        private System.Windows.Forms.Button btnTokenHistory;
    }
}
