using Ny_master.Database;

namespace App_interface
{
    partial class Choose_shop
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.shoptableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p4_projektDataSet = new Ny_master.Database.p4_projektDataSet();
            this.shop_tableTableAdapter = new Ny_master.Database.p4_projektDataSetTableAdapters.shop_tableTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shoptableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4_projektDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.shoptableBindingSource;
            this.listBox1.DisplayMember = "Shop_name";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 37;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(482, 603);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // shoptableBindingSource
            // 
            this.shoptableBindingSource.DataMember = "shop_table";
            this.shoptableBindingSource.DataSource = this.p4_projektDataSet;
            // 
            // p4_projektDataSet
            // 
            this.p4_projektDataSet.DataSetName = "p4DataSet";
            this.p4_projektDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shop_tableTableAdapter
            // 
            this.shop_tableTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Din profil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Choose_shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 603);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Choose_shop";
            this.Text = "Vælg butik";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shoptableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4_projektDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private p4_projektDataSet p4_projektDataSet;
        private System.Windows.Forms.BindingSource shoptableBindingSource;
        private Ny_master.Database.p4_projektDataSetTableAdapters.shop_tableTableAdapter shop_tableTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}

