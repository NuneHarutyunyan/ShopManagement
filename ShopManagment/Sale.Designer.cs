
namespace ShopManagment
{
    partial class Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale));
            this.SBName = new System.Windows.Forms.ComboBox();
            this.DeleteBt = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.EditBt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SQuantity = new System.Windows.Forms.TextBox();
            this.PCat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SPName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SBName
            // 
            this.SBName.FormattingEnabled = true;
            this.SBName.Location = new System.Drawing.Point(12, 52);
            this.SBName.Name = "SBName";
            this.SBName.Size = new System.Drawing.Size(182, 23);
            this.SBName.TabIndex = 42;
            this.SBName.Text = "Ընտրել դաշտ";
            // 
            // DeleteBt
            // 
            this.DeleteBt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.DeleteBt.Location = new System.Drawing.Point(460, 123);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(75, 40);
            this.DeleteBt.TabIndex = 39;
            this.DeleteBt.Text = "Ջնջել";
            this.DeleteBt.UseVisualStyleBackColor = true;
            this.DeleteBt.Click += new System.EventHandler(this.DeleteBt_Click);
            // 
            // SaveBt
            // 
            this.SaveBt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SaveBt.Location = new System.Drawing.Point(161, 123);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(85, 43);
            this.SaveBt.TabIndex = 40;
            this.SaveBt.Text = "Գրանցել";
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // EditBt
            // 
            this.EditBt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.EditBt.Location = new System.Drawing.Point(298, 123);
            this.EditBt.Name = "EditBt";
            this.EditBt.Size = new System.Drawing.Size(95, 41);
            this.EditBt.TabIndex = 41;
            this.EditBt.Text = "Խմբագրել";
            this.EditBt.UseVisualStyleBackColor = true;
            this.EditBt.Click += new System.EventHandler(this.EditBt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(642, 254);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(414, 122);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(252, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // SQuantity
            // 
            this.SQuantity.Location = new System.Drawing.Point(515, 52);
            this.SQuantity.Name = "SQuantity";
            this.SQuantity.Size = new System.Drawing.Size(69, 23);
            this.SQuantity.TabIndex = 34;
            // 
            // PCat
            // 
            this.PCat.AutoSize = true;
            this.PCat.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PCat.Location = new System.Drawing.Point(12, 15);
            this.PCat.Name = "PCat";
            this.PCat.Size = new System.Drawing.Size(146, 25);
            this.PCat.TabIndex = 30;
            this.PCat.Text = "Գնորդի անուն";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(515, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Քանակ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(246, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ապրանքի անվանում";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(246, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 23);
            this.comboBox1.TabIndex = 42;
            this.comboBox1.Text = "Ընտրել դաշտ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(246, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ապրանքի անվանում";
            // 
            // SPName
            // 
            this.SPName.FormattingEnabled = true;
            this.SPName.Location = new System.Drawing.Point(246, 52);
            this.SPName.Name = "SPName";
            this.SPName.Size = new System.Drawing.Size(182, 23);
            this.SPName.TabIndex = 42;
            this.SPName.Text = "Ընտրել դաշտ";
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.SPName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SBName);
            this.Controls.Add(this.DeleteBt);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.EditBt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PCat);
            this.Controls.Add(this.label1);
            this.Name = "Sale";
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SBName;
        private System.Windows.Forms.Button DeleteBt;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Button EditBt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SQuantity;
        private System.Windows.Forms.Label PCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SPName;
    }
}