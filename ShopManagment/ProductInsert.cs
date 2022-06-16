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
    public partial class ProductInsert : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ShopManagment;Integrated Security=True");
        SqlCommand com;
        int id;
        public ProductInsert()
        {
            InitializeComponent();
            DisplayProductGroup();
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            if (PInName.Text != "" || PInQuantity.Text != "" || PInPrice.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Insert into ProductInsertTbl values(@co,@ca,@n)", con
                        );
                    con.Open();
                    com.Parameters.AddWithValue("@co", PInName.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@ca", PInQuantity.Text);
                    com.Parameters.AddWithValue("@n", PInPrice.Text);
                    com.ExecuteNonQuery();
                    con.Close();
                    DisplayMessage("Ապրանքը հաջողությամբ մուտքագրվել է։");
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
        private void CleanAll()
        {
            PInName.Text = "";
            PInQuantity.Text = "";
            PInPrice.Text = "";


        }

        private void DisplayMessage(string txt)
        {
            MessageBox.Show(txt, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DisplayProductGroup()
        {

            con.Open();
            string Query = "Select * From ProductInserttbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void EditBt_Click(object sender, EventArgs e)
        {
            if (PInName.Text != "" || PInQuantity.Text != "" || PInPrice.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Update ProductInsertTbl set PInName=@c,PInQuantity=@pc, PInPrice=@n where PInId=@id", con
                        );
                    con.Open();
                    com.Parameters.AddWithValue("@c", PInName.Text);
                    com.Parameters.AddWithValue("@pc", PInQuantity.Text);
                    com.Parameters.AddWithValue("@n", PInPrice.Text);
                    com.Parameters.AddWithValue("@id", id);
                    com.ExecuteNonQuery();
                    con.Close();
                    CleanAll();
                    DisplayMessage("Ապրանքը թարմեցված է։");
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

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            if (PInName.Text != "" || PInQuantity.Text != "" || PInPrice.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Delete  from ProductInsertTbl where PInId=@id", con
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
                DisplayMessage("Խնդրում ենք ապրանք ընրել։");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                PInName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                PInQuantity.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                PInPrice.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            }
            else
            {
                DisplayMessage("Խնդրում ենք տող ընտրել։");
            }
        }
        private void fillcombo()
        {
            con.Open();
            com = new SqlCommand("Select PName from ProductTbl", con);
            SqlDataReader rdr;
            rdr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PName", typeof(string));
            dt.Load(rdr);
            PInName.ValueMember = "PName";
            PInName.DataSource = dt;
            con.Close();
        }

        private void ProductInsert_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

       
    }
}
