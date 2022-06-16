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
    public partial class ProductTbl : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ShopManagment;Integrated Security=True");
        SqlCommand com;
        int id;

        public ProductTbl()
        {
            InitializeComponent();
            DisplayProductGroup();
        }
        private void fillcombo()
        {
            con.Open();
            com = new SqlCommand("Select PGName from ProductGroupTbl",con);
            SqlDataReader rdr;
            rdr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PGName", typeof(string));
            dt.Load(rdr);
            PCatCB.ValueMember = "PGName";
            PCatCB.DataSource = dt;
            con.Close();
        }

        private void ProductTbl_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            if (PCodeTbl.Text != "" || PNameTbl.Text != "" || PCatCB.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Insert into ProductTbl values(@co,@ca,@n)", con
                        );
                    con.Open();
                    com.Parameters.AddWithValue("@co", PCodeTbl.Text);
                    com.Parameters.AddWithValue("@ca", PCatCB.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@n", PNameTbl.Text);
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
            PCodeTbl.Text = "";
            PCatCB.Text = "";
            PNameTbl.Text = "";


        }

        private void DisplayMessage(string txt)
        {
            MessageBox.Show(txt, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DisplayProductGroup()
        {

            con.Open();
            string Query = "Select * From ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void EditBut_Click(object sender, EventArgs e)
        {
            if (PCodeTbl.Text != "" || PCatCB.Text != "" || PNameTbl.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Update ProductTbl set PCode=@c,PCat=@pc, PName=@n where Id=@id", con
                        );
                    con.Open();
                    com.Parameters.AddWithValue("@c", PCodeTbl.Text);
                    com.Parameters.AddWithValue("@pc", PCatCB.Text);
                    com.Parameters.AddWithValue("@n", PNameTbl.Text);
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

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            if (PCodeTbl.Text != ""  || PNameTbl.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Delete  from ProductTbl where Id=@id", con
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
                PCodeTbl.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                PCatCB.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                PNameTbl.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            }
            else
            {
                DisplayMessage("Խնդրում ենք տող ընտրել։");
            }
        }

       
    }
}
