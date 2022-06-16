
namespace ShopManagment
{
    partial class ProductTbl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductTbl));
            this.DeleteBut = new System.Windows.Forms.Button();
            this.SaveBut = new System.Windows.Forms.Button();
            this.EditBut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PNameTbl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PCodeTbl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PCatCB = new System.Windows.Forms.ComboBox();
            this.PCat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteBut
            // 
            this.DeleteBut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.DeleteBut.Location = new System.Drawing.Point(479, 116);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(75, 40);
            this.DeleteBut.TabIndex = 13;
            this.DeleteBut.Text = "Ջնջել";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // SaveBut
            // 
            this.SaveBut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SaveBut.Location = new System.Drawing.Point(180, 116);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(85, 43);
            this.SaveBut.TabIndex = 14;
            this.SaveBut.Text = "Գրանցել";
            this.SaveBut.UseVisualStyleBackColor = true;
            this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click);
            // 
            // EditBut
            // 
            this.EditBut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.EditBut.Location = new System.Drawing.Point(317, 116);
            this.EditBut.Name = "EditBut";
            this.EditBut.Size = new System.Drawing.Size(95, 41);
            this.EditBut.TabIndex = 15;
            this.EditBut.Text = "Ավելացնել";
            this.EditBut.UseVisualStyleBackColor = true;
            this.EditBut.Click += new System.EventHandler(this.EditBut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 254);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(433, 115);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(271, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // PNameTbl
            // 
            this.PNameTbl.Location = new System.Drawing.Point(573, 55);
            this.PNameTbl.Name = "PNameTbl";
            this.PNameTbl.Size = new System.Drawing.Size(147, 23);
            this.PNameTbl.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(573, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Անվանում";
            // 
            // PCodeTbl
            // 
            this.PCodeTbl.Location = new System.Drawing.Point(17, 55);
            this.PCodeTbl.Name = "PCodeTbl";
            this.PCodeTbl.Size = new System.Drawing.Size(100, 23);
            this.PCodeTbl.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Կոդ";
            // 
            // PCatCB
            // 
            this.PCatCB.FormattingEnabled = true;
            this.PCatCB.Location = new System.Drawing.Point(230, 55);
            this.PCatCB.Name = "PCatCB";
            this.PCatCB.Size = new System.Drawing.Size(182, 23);
            this.PCatCB.TabIndex = 16;
            this.PCatCB.Text = "Ընտրել դաշտ";
            // 
            // PCat
            // 
            this.PCat.AutoSize = true;
            this.PCat.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PCat.Location = new System.Drawing.Point(230, 18);
            this.PCat.Name = "PCat";
            this.PCat.Size = new System.Drawing.Size(68, 25);
            this.PCat.TabIndex = 6;
            this.PCat.Text = "Խումբ";
            // 
            // ProductTbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PCatCB);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.SaveBut);
            this.Controls.Add(this.EditBut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PNameTbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PCodeTbl);
            this.Controls.Add(this.PCat);
            this.Controls.Add(this.label1);
            this.Name = "ProductTbl";
            this.Text = "ProductTbl";
            this.Load += new System.EventHandler(this.ProductTbl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Button SaveBut;
        private System.Windows.Forms.Button EditBut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PNameTbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PCodeTbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PCatCB;
        private System.Windows.Forms.Label PCat;
    }
}