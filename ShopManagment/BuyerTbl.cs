using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShopManagment
{
    public partial class BuyerTbl : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ShopManagment;Integrated Security=True");
        SqlCommand com;
        int id;
        public BuyerTbl()
        {
            InitializeComponent();
        }

        private void BuyerTbl_Load(object sender, EventArgs e)
        {
            DisplayProductGroup();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (BCodeTbl.Text != "" || BFNameTbl.Text != "" || BLNameTbl.Text != "" || BPhoneTbl.Text != "" || BDiscountTbl.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Insert into BuyerTbl values(@Bc,@Bfn,@Bln,@Bp,@Bd)", con
                        );
                    con.Open();
                    com.Parameters.AddWithValue("@Bc", BCodeTbl.Text);
                    com.Parameters.AddWithValue("@Bfn", BFNameTbl.Text);
                    com.Parameters.AddWithValue("@Bln", BLNameTbl.Text);
                    com.Parameters.AddWithValue("@Bp", BPhoneTbl.Text);
                    com.Parameters.AddWithValue("@Bd", BDiscountTbl.Text);

                    com.ExecuteNonQuery();
                    con.Close();
                    DisplayMessage("Գնորդը հաջողությամբ մուտքագրվել է։");
                    CleanAll();
                    DisplayProductGroup();


                }
                catch (Exception ex)
                {

                    DisplayMessage(ex.Message);
                }
            }
            else
            {
                DisplayMessage("Խնդրում ենք լրացնել բոլոր դաշտերը։");
            }
        }
        private void DisplayProductGroup()
        {
            con.Open();
            string Query = "Select * From BuyerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void CleanAll()
        {
            BCodeTbl.Text = "";
            BFNameTbl.Text = "";
            BLNameTbl.Text = "";
            BPhoneTbl.Text = "";
            BDiscountTbl.Text = "";
        }

        private void DisplayMessage(string txt)
        {
            MessageBox.Show(txt, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (BCodeTbl.Text != "" || BFNameTbl.Text != "" || BLNameTbl.Text != "" || BPhoneTbl.Text != "" || BDiscountTbl.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Update BuyerTbl set BCode=@bc, BFName=@fn, BLName=@bln, BPhone=@bf, BDiscount=@bd where BId=@id ", con
                        );
                    con.Open();
                    com.Parameters.AddWithValue("@bc", BCodeTbl.Text);
                    com.Parameters.AddWithValue("@fn", BFNameTbl.Text);
                    com.Parameters.AddWithValue("@bln", BLNameTbl.Text);
                    com.Parameters.AddWithValue("@bf", BPhoneTbl.Text);
                    com.Parameters.AddWithValue("@bd", BDiscountTbl.Text);
                    com.Parameters.AddWithValue("@id", id);
                    com.ExecuteNonQuery();
                    con.Close();
                    CleanAll();
                    DisplayMessage("Գնորդը թարմեցված է։");
                    DisplayProductGroup();

                }
                catch (Exception ex)
                {

                    DisplayMessage(ex.Message);
                }

            }
            else
            {
                DisplayMessage("Խնդրում ենք լրացնել տող ընրել։");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (BCodeTbl.Text != "" || BFNameTbl.Text != "" || BLNameTbl.Text != "" || BPhoneTbl.Text != "" || BDiscountTbl.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Delete  from BuyerTbl where BId=@id", con
                        );
                    con.Open();
                    com.Parameters.AddWithValue("@id", id);
                    com.ExecuteNonQuery();
                    con.Close();
                    CleanAll();
                    DisplayMessage("Տվյալը հաջողությամբ ջնջվել է։");
                    DisplayProductGroup();

                }
                catch (Exception ex)
                {

                    DisplayMessage(ex.Message);
                }
            }
            else
            {
                DisplayMessage("Խնդրում ենք տող ընրել։");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                BCodeTbl.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                BFNameTbl.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                BLNameTbl.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                BPhoneTbl.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                BDiscountTbl.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            }
            else
            {
                DisplayMessage("Խնդրում ենք տող ընտրել։");
            }
        }

       
    }
}
