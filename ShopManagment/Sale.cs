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
    public partial class Sale : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ShopManagment;Integrated Security=True");
        SqlCommand com;
        int id;
        public Sale()
        {
            InitializeComponent();
            DisplayProductGroup();
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            if (SBName.Text != "" || SPName.Text != "" || SQuantity.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Insert into SaleTbl values(@co,@ca,@n)", con
                        );
                    con.Open();
                    com.Parameters.AddWithValue("@co", SBName.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@ca", SPName.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@n", SQuantity.Text);
                    com.ExecuteNonQuery();
                    con.Close();
                    DisplayMessage("Մուտքագրումը կատարվել է։");
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
            SBName.Text = "";
            SPName.Text = "";
            SQuantity.Text = "";


        }

        private void DisplayMessage(string txt)
        {
            MessageBox.Show(txt, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DisplayProductGroup()
        {

            con.Open();
            string Query = "Select * From SaleTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void EditBt_Click(object sender, EventArgs e)
        {
            if (SBName.Text != "" || SPName.Text != "" || SQuantity.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Update SaleTbl set SBName=@c,SPName=@pc, SQuantity=@n where SId=@id", con
                        );
                    con.Open();
                    com.Parameters.AddWithValue("@c", SBName.Text);
                    com.Parameters.AddWithValue("@pc", SPName.Text);
                    com.Parameters.AddWithValue("@n", SQuantity.Text);
                    com.Parameters.AddWithValue("@id", id);
                    com.ExecuteNonQuery();
                    con.Close();
                    CleanAll();
                    DisplayMessage("Մուտքագրումը խմբագրված է։");
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
            if (SBName.Text != "" || SPName.Text != "" || SQuantity.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Delete  from SaleTbl where SId=@id", con
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
                SBName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                SPName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                SQuantity.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
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
            com = new SqlCommand("Select BFName from BuyerTbl", con);
            SqlDataReader rdr;
            rdr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BFName", typeof(string));
            dt.Load(rdr);
            SBName.ValueMember = "BFName";
            SBName.DataSource = dt;
            con.Close();
        }
        private void fillcombo1()
        {
            con.Open();
            com = new SqlCommand("Select PName from ProductTbl", con);
            SqlDataReader rdr1;
            rdr1 = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PName", typeof(string));
            dt.Load(rdr1);
            SPName.ValueMember = "PName";
            SPName.DataSource = dt;
            con.Close();
        }
        private void Sale_Load(object sender, EventArgs e)
        {
            fillcombo();
            fillcombo1();
        }
    }
}
