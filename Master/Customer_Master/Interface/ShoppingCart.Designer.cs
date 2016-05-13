namespace Customer_Master.Interface
{
    partial class ShoppingCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingCart));
            this.Content = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Remove = new System.Windows.Forms.PictureBox();
            this.BrowseProducts = new System.Windows.Forms.Button();
            this.Payment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Remove)).BeginInit();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(37, 56);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(103, 20);
            this.Content.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "XX";
            // 
            // Remove
            // 
            this.Remove.Image = ((System.Drawing.Image)(resources.GetObject("Remove.Image")));
            this.Remove.Location = new System.Drawing.Point(146, 56);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(19, 20);
            this.Remove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Remove.TabIndex = 2;
            this.Remove.TabStop = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // BrowseProducts
            // 
            this.BrowseProducts.Location = new System.Drawing.Point(13, 190);
            this.BrowseProducts.Name = "BrowseProducts";
            this.BrowseProducts.Size = new System.Drawing.Size(89, 23);
            this.BrowseProducts.TabIndex = 3;
            this.BrowseProducts.Text = "Tilbage til menu";
            this.BrowseProducts.UseVisualStyleBackColor = true;
            this.BrowseProducts.Click += new System.EventHandler(this.BrowseProducts_Click);
            // 
            // Payment
            // 
            this.Payment.Location = new System.Drawing.Point(197, 190);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(75, 23);
            this.Payment.TabIndex = 4;
            this.Payment.Text = "Til betaling";
            this.Payment.UseVisualStyleBackColor = true;
            // 
            // ShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.BrowseProducts);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Content);
            this.Name = "ShoppingCart";
            this.Text = "ShoppingCart";
            ((System.ComponentModel.ISupportInitialize)(this.Remove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Content;
        private System.Windows.Forms.Button BrowseProducts;
        private System.Windows.Forms.Button Payment;
    }
}