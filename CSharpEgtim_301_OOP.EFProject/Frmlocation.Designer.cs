namespace CSharpEgtim_301_OOP.EFProject
{
    partial class Frmlocation
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dttblLocation = new System.Windows.Forms.DataGridView();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtbCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtbCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtbLocationId = new System.Windows.Forms.TextBox();
            this.lblGuideName = new System.Windows.Forms.Label();
            this.txtbDayNight = new System.Windows.Forms.TextBox();
            this.lblDayNight = new System.Windows.Forms.Label();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblGuide = new System.Windows.Forms.Label();
            this.nmrCapacity = new System.Windows.Forms.NumericUpDown();
            this.cmbGuide = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dttblLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(143, 476);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(202, 38);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dttblLocation
            // 
            this.dttblLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dttblLocation.Location = new System.Drawing.Point(384, 88);
            this.dttblLocation.Name = "dttblLocation";
            this.dttblLocation.RowHeadersWidth = 51;
            this.dttblLocation.RowTemplate.Height = 24;
            this.dttblLocation.Size = new System.Drawing.Size(1142, 426);
            this.dttblLocation.TabIndex = 23;
            // 
            // btnSearchById
            // 
            this.btnSearchById.Location = new System.Drawing.Point(592, 43);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(202, 38);
            this.btnSearchById.TabIndex = 22;
            this.btnSearchById.Text = "ID ye göre ara";
            this.btnSearchById.UseVisualStyleBackColor = true;
            this.btnSearchById.Click += new System.EventHandler(this.btnSearchById_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(384, 43);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(202, 38);
            this.btnList.TabIndex = 21;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(143, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(202, 38);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(143, 361);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(202, 38);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtbCountry
            // 
            this.txtbCountry.Location = new System.Drawing.Point(143, 145);
            this.txtbCountry.Name = "txtbCountry";
            this.txtbCountry.Size = new System.Drawing.Size(202, 22);
            this.txtbCountry.TabIndex = 18;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(96, 148);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(41, 16);
            this.lblCountry.TabIndex = 17;
            this.lblCountry.Text = "Ülke :";
            // 
            // txtbCity
            // 
            this.txtbCity.Location = new System.Drawing.Point(143, 97);
            this.txtbCity.Name = "txtbCity";
            this.txtbCity.Size = new System.Drawing.Size(202, 22);
            this.txtbCity.TabIndex = 16;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(93, 100);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(44, 16);
            this.lblCity.TabIndex = 15;
            this.lblCity.Text = "Şehir :";
            // 
            // txtbLocationId
            // 
            this.txtbLocationId.Location = new System.Drawing.Point(143, 52);
            this.txtbLocationId.Name = "txtbLocationId";
            this.txtbLocationId.Size = new System.Drawing.Size(202, 22);
            this.txtbLocationId.TabIndex = 14;
            // 
            // lblGuideName
            // 
            this.lblGuideName.AutoSize = true;
            this.lblGuideName.Location = new System.Drawing.Point(57, 55);
            this.lblGuideName.Name = "lblGuideName";
            this.lblGuideName.Size = new System.Drawing.Size(80, 16);
            this.lblGuideName.TabIndex = 13;
            this.lblGuideName.Text = "Location ID :";
            // 
            // txtbDayNight
            // 
            this.txtbDayNight.Location = new System.Drawing.Point(143, 273);
            this.txtbDayNight.Name = "txtbDayNight";
            this.txtbDayNight.Size = new System.Drawing.Size(202, 22);
            this.txtbDayNight.TabIndex = 30;
            // 
            // lblDayNight
            // 
            this.lblDayNight.AutoSize = true;
            this.lblDayNight.Location = new System.Drawing.Point(12, 279);
            this.lblDayNight.Name = "lblDayNight";
            this.lblDayNight.Size = new System.Drawing.Size(125, 16);
            this.lblDayNight.TabIndex = 29;
            this.lblDayNight.Text = "Kaç Gece Kaç Gün :";
            // 
            // txtbPrice
            // 
            this.txtbPrice.Location = new System.Drawing.Point(143, 225);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(202, 22);
            this.txtbPrice.TabIndex = 28;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(101, 228);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 16);
            this.lblPrice.TabIndex = 27;
            this.lblPrice.Text = "Fiyat";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(71, 183);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(66, 16);
            this.lblCapacity.TabIndex = 25;
            this.lblCapacity.Text = "Kapasite :";
            // 
            // lblGuide
            // 
            this.lblGuide.AutoSize = true;
            this.lblGuide.Location = new System.Drawing.Point(79, 318);
            this.lblGuide.Name = "lblGuide";
            this.lblGuide.Size = new System.Drawing.Size(58, 16);
            this.lblGuide.TabIndex = 31;
            this.lblGuide.Text = "Rehber :";
            // 
            // nmrCapacity
            // 
            this.nmrCapacity.Location = new System.Drawing.Point(143, 183);
            this.nmrCapacity.Name = "nmrCapacity";
            this.nmrCapacity.Size = new System.Drawing.Size(202, 22);
            this.nmrCapacity.TabIndex = 33;
            // 
            // cmbGuide
            // 
            this.cmbGuide.FormattingEnabled = true;
            this.cmbGuide.Location = new System.Drawing.Point(143, 315);
            this.cmbGuide.Name = "cmbGuide";
            this.cmbGuide.Size = new System.Drawing.Size(202, 24);
            this.cmbGuide.TabIndex = 34;
            this.cmbGuide.SelectedIndexChanged += new System.EventHandler(this.cmbGuide_SelectedIndexChanged);
            // 
            // Frmlocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 547);
            this.Controls.Add(this.cmbGuide);
            this.Controls.Add(this.nmrCapacity);
            this.Controls.Add(this.lblGuide);
            this.Controls.Add(this.txtbDayNight);
            this.Controls.Add(this.lblDayNight);
            this.Controls.Add(this.txtbPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dttblLocation);
            this.Controls.Add(this.btnSearchById);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtbCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtbCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtbLocationId);
            this.Controls.Add(this.lblGuideName);
            this.Name = "Frmlocation";
            this.Text = "Frmlocation";
            this.Load += new System.EventHandler(this.Frmlocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dttblLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dttblLocation;
        private System.Windows.Forms.Button btnSearchById;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtbCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtbCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtbLocationId;
        private System.Windows.Forms.Label lblGuideName;
        private System.Windows.Forms.TextBox txtbDayNight;
        private System.Windows.Forms.Label lblDayNight;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblGuide;
        private System.Windows.Forms.NumericUpDown nmrCapacity;
        private System.Windows.Forms.ComboBox cmbGuide;
    }
}