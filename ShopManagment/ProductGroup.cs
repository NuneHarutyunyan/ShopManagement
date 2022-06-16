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
    public partial class ProductGroup : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ShopManagment;Integrated Security=True");
        SqlCommand com;
        int id;
        public ProductGroup()
        {
            InitializeComponent();
            DisplayProductGroup();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (PGCodeTbl.Text != "" || PGNameTbl.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Insert into ProductGroupTbl values(@c,@n)", con
                        );
                    con.Open();
                    com.Parameters.AddWithValue("@c", PGCodeTbl.Text);
                    com.Parameters.AddWithValue("@n", PGNameTbl.Text);
                    com.ExecuteNonQuery();
                    con.Close();
                    DisplayMessage("Ապրանքի խումբը հաջողությամբ մուտքագրվել է։");
                    CleanAll();
                    DisplayProductGroup();
                }
                catch(Exception ex)
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
            string Query = "Select * From ProductGroupTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void DisplayMessage(string txt)
        {
            MessageBox.Show(txt, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CleanAll()
        {
            PGCodeTbl.Text = "";
            PGNameTbl.Text = "";

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (PGCodeTbl.Text != "" || PGNameTbl.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Update ProductGroupTbl set PGCode=@c, PgName=@pn where PGId=@id", con
                        );
                    con.Open();
                    com.Parameters.AddWithValue("@c", PGCodeTbl.Text);
                    com.Parameters.AddWithValue("@pn", PGNameTbl.Text);
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
                DisplayMessage("Խնդրում ենք  տող ընրել։");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (PGCodeTbl.Text != "" || PGNameTbl.Text != "")
            {
                try
                {
                    com = new SqlCommand(
                        "Delete  from ProductGroupTbl where PGId=@id", con
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
                PGCodeTbl.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                PGNameTbl.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            }
            else
            {
                DisplayMessage("Խնդրում ենք տող ընտրել։");
            }
        }
    }
}
