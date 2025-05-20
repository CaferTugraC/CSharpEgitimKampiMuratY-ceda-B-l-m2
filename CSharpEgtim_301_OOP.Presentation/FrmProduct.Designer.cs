namespace CSharpEgtim_301_OOP.Presentation
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.txtbId = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtbStock = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbProductCategoryId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbDescription = new System.Windows.Forms.TextBox();
            this.btnListProductOnSelectedCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(163, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "ÜRÜN YÖNEİCİSİ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(146, 539);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(262, 52);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(146, 481);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(262, 52);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(146, 423);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(262, 52);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGetById
            // 
            this.btnGetById.Location = new System.Drawing.Point(627, 41);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(145, 52);
            this.btnGetById.TabIndex = 24;
            this.btnGetById.Text = "ID ye göre listele";
            this.btnGetById.UseVisualStyleBackColor = true;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(467, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(984, 492);
            this.dataGridView1.TabIndex = 23;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(467, 41);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(145, 52);
            this.btnList.TabIndex = 22;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(76, 125);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 16);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Ürün Adı :";
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(146, 122);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(262, 22);
            this.txtbName.TabIndex = 19;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(83, 84);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(57, 16);
            this.lblProductId.TabIndex = 18;
            this.lblProductId.Text = "Ürün ID :";
            // 
            // txtbId
            // 
            this.txtbId.Location = new System.Drawing.Point(146, 81);
            this.txtbId.Name = "txtbId";
            this.txtbId.Size = new System.Drawing.Size(262, 22);
            this.txtbId.TabIndex = 17;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(60, 201);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(80, 16);
            this.lblStock.TabIndex = 32;
            this.lblStock.Text = "Stok Sayısı :";
            // 
            // txtbStock
            // 
            this.txtbStock.Location = new System.Drawing.Point(146, 198);
            this.txtbStock.Name = "txtbStock";
            this.txtbStock.Size = new System.Drawing.Size(262, 22);
            this.txtbStock.TabIndex = 31;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(64, 163);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(76, 16);
            this.lblPrice.TabIndex = 30;
            this.lblPrice.Text = "Ürün Fiyatı :";
            // 
            // txtbPrice
            // 
            this.txtbPrice.Location = new System.Drawing.Point(146, 157);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(262, 22);
            this.txtbPrice.TabIndex = 29;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(77, 240);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(63, 16);
            this.lblCategory.TabIndex = 34;
            this.lblCategory.Text = "Kategori :";
            // 
            // cmbProductCategoryId
            // 
            this.cmbProductCategoryId.FormattingEnabled = true;
            this.cmbProductCategoryId.Location = new System.Drawing.Point(146, 237);
            this.cmbProductCategoryId.Name = "cmbProductCategoryId";
            this.cmbProductCategoryId.Size = new System.Drawing.Size(262, 24);
            this.cmbProductCategoryId.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ürün Açıklaması";
            // 
            // txtbDescription
            // 
            this.txtbDescription.Location = new System.Drawing.Point(146, 276);
            this.txtbDescription.Multiline = true;
            this.txtbDescription.Name = "txtbDescription";
            this.txtbDescription.Size = new System.Drawing.Size(262, 112);
            this.txtbDescription.TabIndex = 36;
            // 
            // btnListProductOnSelectedCategory
            // 
            this.btnListProductOnSelectedCategory.Location = new System.Drawing.Point(789, 41);
            this.btnListProductOnSelectedCategory.Name = "btnListProductOnSelectedCategory";
            this.btnListProductOnSelectedCategory.Size = new System.Drawing.Size(145, 52);
            this.btnListProductOnSelectedCategory.TabIndex = 38;
            this.btnListProductOnSelectedCategory.Text = "Seçili Kategoriyi Listele";
            this.btnListProductOnSelectedCategory.UseVisualStyleBackColor = true;
            this.btnListProductOnSelectedCategory.Click += new System.EventHandler(this.btnListProductOnSelectedCategory_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 644);
            this.Controls.Add(this.btnListProductOnSelectedCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbDescription);
            this.Controls.Add(this.cmbProductCategoryId);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtbStock);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtbPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.txtbId);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox txtbId;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtbStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbProductCategoryId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbDescription;
        private System.Windows.Forms.Button btnListProductOnSelectedCategory;
    }
}