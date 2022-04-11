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
        }

        private void _2_Load(object sender, EventArgs e)
        {

            SqlConnection conn;
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
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //SqlConnection conn;

            //try
            //{

            //    conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            //    SqlDataAdapter adapter = new SqlDataAdapter("select categoryname from categories",conn);
            //    DataSet ds = new DataSet();
            //    adapter.Fill(ds);
            //    comboBox1.DataSource = ds.Tables[0];


            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int ch = comboBox1.SelectedIndex + 1;
            SqlConnection conn;
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

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
