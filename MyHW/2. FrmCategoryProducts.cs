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

namespace MyHW
{
    public partial class _2 : Form
    {
        public _2()
        {
            InitializeComponent();


            try
            {

                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                adapter = new SqlDataAdapter("select DISTINCT categoryname, productname from categories c join products p " +
                    "on c.categoryID = p.categoryID", conn); // group by categoryname
                ds = new DataSet();
                adapter.Fill(ds);
                adapter.SelectCommand.CommandText = "select categoryname from categories c join products p " +
                    "on c.categoryID = p.categoryID";
                dt = new DataTable();
                adapter.Fill(dt);
                int i = 0;
                while (i < ds.Tables[0].Rows.Count)
                {
                    var sCategoryName = ds.Tables[0].Rows[i]["CategoryName"];
                    if (!comboBox2.Items.Contains(sCategoryName))
                    {
                        comboBox2.Items.Add(ds.Tables[0].Rows[i]["CategoryName"]);
                    }
                    i++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        private void _2_Load(object sender, EventArgs e)
        {

            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();
                SqlCommand com = new SqlCommand("select categoryname from categories", conn);
                SqlDataReader read = com.ExecuteReader();

                while (read.Read() != false)
                {
                    comboBox1.Items.Add(read.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int ch = comboBox1.SelectedIndex + 1;

            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();
                SqlCommand com = new SqlCommand($"select productname from categories c join products p " +
                    "on c.categoryid = p.categoryid where c.categoryid = " + ch, conn);
                SqlDataReader read = com.ExecuteReader();

                listBox1.Items.Clear();
                while (read.Read() != false)
                {
                    listBox1.Items.Add(read.GetString(0).ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            var a = ds.Tables[0].Select($"categoryname = '{comboBox2.SelectedItem}'");
            foreach (DataRow row in a) {
                listBox2.Items.Add(row.Field<string>("productname"));
            } ;

            
            //listBox2.DataSource = dt.Select($"categoryname = '{comboBox2.SelectedItem}'");
            
        }
    }
}
