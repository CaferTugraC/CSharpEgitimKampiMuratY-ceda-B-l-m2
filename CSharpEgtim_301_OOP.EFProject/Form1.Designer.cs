namespace CSharpEgtim_301_OOP.EFProject
{
    partial class Form1
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
            this.lblGuideName = new System.Windows.Forms.Label();
            this.txtbGuideId = new System.Windows.Forms.TextBox();
            this.txtbGuideName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbGuideSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGuideName
            // 
            this.lblGuideName.AutoSize = true;
            this.lblGuideName.Location = new System.Drawing.Point(44, 44);
            this.lblGuideName.Name = "lblGuideName";
            this.lblGuideName.Size = new System.Drawing.Size(74, 16);
            this.lblGuideName.TabIndex = 0;
            this.lblGuideName.Text = "Rehber ID :";
            // 
            // txtbGuideId
            // 
            this.txtbGuideId.Location = new System.Drawing.Point(124, 44);
            this.txtbGuideId.Name = "txtbGuideId";
            this.txtbGuideId.Size = new System.Drawing.Size(202, 22);
            this.txtbGuideId.TabIndex = 1;
            this.txtbGuideId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbGuideName
            // 
            this.txtbGuideName.Location = new System.Drawing.Point(124, 89);
            this.txtbGuideName.Name = "txtbGuideName";
            this.txtbGuideName.Size = new System.Drawing.Size(202, 22);
            this.txtbGuideName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rehber Adı :";
            // 
            // txtbGuideSurname
            // 
            this.txtbGuideSurname.Location = new System.Drawing.Point(124, 137);
            this.txtbGuideSurname.Name = "txtbGuideSurname";
            this.txtbGuideSurname.Size = new System.Drawing.Size(202, 22);
            this.txtbGuideSurname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rehber Soyadı :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(124, 188);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(202, 38);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(124, 247);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(202, 38);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(357, 39);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(202, 38);
            this.btnList.TabIndex = 9;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSearchById
            // 
            this.btnSearchById.Location = new System.Drawing.Point(565, 39);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(202, 38);
            this.btnSearchById.TabIndex = 10;
            this.btnSearchById.Text = "ID ye göre ara";
            this.btnSearchById.UseVisualStyleBackColor = true;
            this.btnSearchById.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(357, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(608, 317);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(124, 303);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(202, 38);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearchById);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtbGuideSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbGuideName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbGuideId);
            this.Controls.Add(this.lblGuideName);
            this.Name = "Form1";
            this.Text = "TravelAPP - Database Güncelleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuideName;
        private System.Windows.Forms.TextBox txtbGuideId;
        private System.Windows.Forms.TextBox txtbGuideName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbGuideSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnSearchById;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
    }
}

