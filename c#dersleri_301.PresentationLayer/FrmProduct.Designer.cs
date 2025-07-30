namespace c_dersleri_301.PresentationLayer
{
    partial class FrmProduct
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(103, 407);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(204, 38);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(103, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(204, 38);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(103, 505);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(204, 38);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnGetById
            // 
            this.btnGetById.Location = new System.Drawing.Point(103, 549);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(204, 38);
            this.btnGetById.TabIndex = 22;
            this.btnGetById.Text = "ID\'ye Göre Getir";
            this.btnGetById.UseVisualStyleBackColor = true;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(103, 77);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(204, 22);
            this.txtProductName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ürün Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(331, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 573);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(103, 361);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(204, 38);
            this.btnList.TabIndex = 15;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(103, 40);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(204, 22);
            this.txtProductId.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ürün ID:";
            // 
            // txtProductStock
            // 
            this.txtProductStock.Location = new System.Drawing.Point(103, 112);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(204, 22);
            this.txtProductStock.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ürün Stoğu:";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(103, 150);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(204, 22);
            this.txtProductPrice.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ürün Fiyatı:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(103, 233);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(204, 98);
            this.txtDescription.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Açıklama:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Kategori:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(103, 192);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(204, 24);
            this.cmbCategory.TabIndex = 33;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1224, 623);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.label1);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCategory;
    }
}