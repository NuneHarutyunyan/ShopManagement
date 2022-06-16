
namespace ShopManagment
{
    partial class ProductInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInsert));
            this.PInName = new System.Windows.Forms.ComboBox();
            this.DeleteBt = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.EditBt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PInQuantity = new System.Windows.Forms.TextBox();
            this.PCat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PInPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PInName
            // 
            this.PInName.FormattingEnabled = true;
            this.PInName.Location = new System.Drawing.Point(19, 47);
            this.PInName.Name = "PInName";
            this.PInName.Size = new System.Drawing.Size(182, 23);
            this.PInName.TabIndex = 29;
            this.PInName.Text = "Ընտրել դաշտ";
            // 
            // DeleteBt
            // 
            this.DeleteBt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.DeleteBt.Location = new System.Drawing.Point(432, 116);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(75, 40);
            this.DeleteBt.TabIndex = 26;
            this.DeleteBt.Text = "Ջնջել";
            this.DeleteBt.UseVisualStyleBackColor = true;
            this.DeleteBt.Click += new System.EventHandler(this.DeleteBt_Click);
            // 
            // SaveBt
            // 
            this.SaveBt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SaveBt.Location = new System.Drawing.Point(133, 116);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(85, 43);
            this.SaveBt.TabIndex = 27;
            this.SaveBt.Text = "Գրանցել";
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // EditBt
            // 
            this.EditBt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.EditBt.Location = new System.Drawing.Point(270, 116);
            this.EditBt.Name = "EditBt";
            this.EditBt.Size = new System.Drawing.Size(95, 41);
            this.EditBt.TabIndex = 28;
            this.EditBt.Text = "Ավելացնել";
            this.EditBt.UseVisualStyleBackColor = true;
            this.EditBt.Click += new System.EventHandler(this.EditBt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(579, 254);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(386, 115);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(224, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // PInQuantity
            // 
            this.PInQuantity.Location = new System.Drawing.Point(249, 47);
            this.PInQuantity.Name = "PInQuantity";
            this.PInQuantity.Size = new System.Drawing.Size(69, 23);
            this.PInQuantity.TabIndex = 21;
            // 
            // PCat
            // 
            this.PCat.AutoSize = true;
            this.PCat.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PCat.Location = new System.Drawing.Point(19, 10);
            this.PCat.Name = "PCat";
            this.PCat.Size = new System.Drawing.Size(211, 25);
            this.PCat.TabIndex = 18;
            this.PCat.Text = "Ապրանքի անվանում";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(249, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Քանակ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(406, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Գին";
            // 
            // PInPrice
            // 
            this.PInPrice.Location = new System.Drawing.Point(406, 47);
            this.PInPrice.Name = "PInPrice";
            this.PInPrice.Size = new System.Drawing.Size(120, 23);
            this.PInPrice.TabIndex = 21;
            // 
            // ProductInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(636, 440);
            this.Controls.Add(this.PInName);
            this.Controls.Add(this.DeleteBt);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.EditBt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PInPrice);
            this.Controls.Add(this.PInQuantity);
            this.Controls.Add(this.PCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ProductInsert";
            this.Text = "ProductInsert";
            this.Load += new System.EventHandler(this.ProductInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PInName;
        private System.Windows.Forms.Button DeleteBt;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Button EditBt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PInQuantity;
        private System.Windows.Forms.Label PCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PInPrice;
    }
}