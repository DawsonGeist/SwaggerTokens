namespace SwaggerTokens
{
    partial class AddTokensForm
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
            this.trackBarTokenAmount = new System.Windows.Forms.TrackBar();
            this.lblAmount = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTokenAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTokenAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarTokenAmount
            // 
            this.trackBarTokenAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarTokenAmount.Location = new System.Drawing.Point(12, 291);
            this.trackBarTokenAmount.Minimum = 1;
            this.trackBarTokenAmount.Name = "trackBarTokenAmount";
            this.trackBarTokenAmount.Size = new System.Drawing.Size(776, 101);
            this.trackBarTokenAmount.TabIndex = 0;
            this.trackBarTokenAmount.Value = 1;
            this.trackBarTokenAmount.ValueChanged += new System.EventHandler(this.trackBarTokenAmount_ValueChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(12, 251);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(125, 37);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Amount: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 435);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 123);
            this.textBox1.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 395);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(165, 37);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 564);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(776, 52);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Tokens";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTokenAmount
            // 
            this.lblTokenAmount.AutoSize = true;
            this.lblTokenAmount.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTokenAmount.Location = new System.Drawing.Point(302, 9);
            this.lblTokenAmount.Name = "lblTokenAmount";
            this.lblTokenAmount.Size = new System.Drawing.Size(163, 191);
            this.lblTokenAmount.TabIndex = 5;
            this.lblTokenAmount.Text = "1";
            // 
            // AddTokensForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.lblTokenAmount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.trackBarTokenAmount);
            this.Name = "AddTokensForm";
            this.Text = "Add Tokens";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTokenAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarTokenAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTokenAmount;
    }
}