using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            ProductGroup product = new ProductGroup();
            product.Show();
            this.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            ProductTbl tbl = new ProductTbl();
            tbl.Show();
            this.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            BuyerTbl buyer = new BuyerTbl();
            buyer.Show();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ProductInsert productInsert = new ProductInsert();
            productInsert.Show();
            this.Show();
                
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.Show();
            this.Show();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Մանրամասների համար խնդրում ենք զանգահարել նշված հեռախոսահամարով՝ 010111111","Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Պահեստի տվյալները հայտնի չեն։", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Խնդրում ենք ընրել որևէ բաժին։", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
