using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class Frm_Custom : Form
    {
        public Frm_Custom()
        {
            InitializeComponent();

            listView1.View = View.Details;
            FillToComboBox();
            FillColumnToListView();
            FillGroupToListView();
        }

        private void FillGroupToListView()
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                using (conn)
                {
                    SqlConnectionStringBuilder build = new SqlConnectionStringBuilder();
                    build.DataSource = ".";
                    build.InitialCatalog = "Northwind";
                    build.IntegratedSecurity = true;
                    conn.ConnectionString = build.ConnectionString;
                    SqlCommand com = new SqlCommand();
                    com.CommandText = "select distinct region from customers";
                    com.Connection = conn;
                    conn.Open();
                    SqlDataReader read = com.ExecuteReader();
                    while (read.Read())
                    {
                        listView1.Groups.Add(read[0].ToString(), read[0].ToString());
                    }
                    listView1.Groups[0].Header = "無資料";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillToComboBox()
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                using (conn)
                {
                    SqlConnectionStringBuilder build = new SqlConnectionStringBuilder();
                    build.DataSource = ".";
                    build.InitialCatalog = "Northwind";
                    build.IntegratedSecurity = true;
                    conn.ConnectionString = build.ConnectionString;
                    SqlCommand com = new SqlCommand();
                    com.CommandText = "select distinct country from customers";
                    com.Connection = conn;
                    conn.Open();
                    SqlDataReader read = com.ExecuteReader();
                    comboBox1.Items.Add("所有國家");
                    while (read.Read())
                    {
                        comboBox1.Items.Add(read[0].ToString());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                using (conn)
                {
                    SqlConnectionStringBuilder build = new SqlConnectionStringBuilder();
                    build.DataSource = ".";
                    build.InitialCatalog = "Northwind";
                    build.IntegratedSecurity = true;
                    conn.ConnectionString = build.ConnectionString;
                    SqlCommand com = new SqlCommand();

                    string select =comboBox1.SelectedIndex == 0 ? "" : $"where country = '{comboBox1.SelectedItem}'";

                    com.CommandText = $"select  * from customers {select}";
                    com.Connection = conn;
                    conn.Open();
                    SqlDataReader read = com.ExecuteReader();

                    listView1.Items.Clear();
                    while (read.Read())
                    {
                        ListViewItem lvi = listView1.Items.Add(read[0].ToString());

                        for (int i = 1; i < read.FieldCount; i++)
                        {
                            string item = read[i].ToString();
                            if (i == 8)
                            {
                                int b;
                                InPutImage(item, out b);
                                lvi.ImageIndex = b;
                            }
                            if (item == "")
                            {
                                item = "無資料";
                            }
                            lvi.SubItems.Add(item);
                        }
                        lvi.Group = listView1.Groups[read[6].ToString()];
                    }
                    for(int i = 0; i < listView1.Groups.Count; i++)
                    {
                        if (i == 0)
                        {
                            listView1.Groups[i].Header = $"無資料 ({listView1.Groups[i].Items.Count})";
                        }
                        else
                        {
                        listView1.Groups[i].Header = $"{listView1.Groups[i].Name} ({listView1.Groups[i].Items.Count})";
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InPutImage(string a, out int b)
        {
            b = 0;
            switch (a)
            {
                case "Argentina":
                    b = 0;
                    break;
                case "Austria":
                    b = 1;
                    break;
                case "Belgium":
                    b = 2;
                    break;
                case "Brazil":
                    b = 3;
                    break;
                case "Canada":
                    b = 4;
                    break;
                case "Denmark":
                    b = 5;
                    break;
                case "Finland":
                    b = 6;
                    break;
                case "France":
                    b = 7;
                    break;
                case "Germany":
                    b = 8;
                    break;
                case "Ireland":
                    b = 9;
                    break;
                case "Italy":
                    b = 10;
                    break;
                case "Mexico":
                    b = 11;
                    break;
                case "Norway":
                    b = 12;
                    break;
                case "Poland":
                    b = 13;
                    break;
                case "Portugal":
                    b = 14;
                    break;
                case "Spain":
                    b = 15;
                    break;
                case "Sweden":
                    b = 16;
                    break;
                case "Switzerland":
                    b = 17;
                    break;
                case "UK":
                    b = 18;
                    break;
                case "USA":
                    b = 19;
                    break;
                case "Venezuela":
                    b = 20;
                    break;
            }
        }

        private void FillColumnToListView()
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                using (conn)
                {
                    SqlConnectionStringBuilder build = new SqlConnectionStringBuilder();
                    build.DataSource = ".";
                    build.InitialCatalog = "Northwind";
                    build.IntegratedSecurity = true;
                    conn.ConnectionString = build.ConnectionString;
                    SqlCommand com = new SqlCommand();
                    com.CommandText = "select  * from customers";
                    com.Connection = conn;
                    conn.Open();
                    SqlDataReader read = com.ExecuteReader();
                    DataTable table =  read.GetSchemaTable();

                    for(int i = 0; i < table.Rows.Count; i++)
                    {
                        listView1.Columns.Add(table.Rows[i][0].ToString());
                    }
                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void detialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orderby("city");
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orderby("country");
        }

        private void Orderby(string order)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                using (conn)
                {
                    SqlConnectionStringBuilder build = new SqlConnectionStringBuilder();
                    build.DataSource = ".";
                    build.InitialCatalog = "Northwind";
                    build.IntegratedSecurity = true;
                    conn.ConnectionString = build.ConnectionString;
                    SqlCommand com = new SqlCommand();
                    string select = "";

                    select = comboBox1.SelectedIndex == 0 ? "" : $"where country = '{comboBox1.SelectedItem}'";

                    com.CommandText = $"select  * from customers {select} order by {order}";
                    com.Connection = conn;
                    conn.Open();
                    SqlDataReader read = com.ExecuteReader();

                    listView1.Items.Clear();
                    while (read.Read())
                    {
                        ListViewItem lvi = listView1.Items.Add(read[0].ToString());

                        for (int i = 1; i < read.FieldCount; i++)
                        {
                            string item = read[i].ToString();
                            if (i == 8)
                            {
                                int b;
                                InPutImage(item, out b);
                                lvi.ImageIndex = b;
                            }
                            if (item == "")
                            {
                                item = "無資料";
                            }
                            lvi.SubItems.Add(item);
                        }
                        lvi.Group = listView1.Groups[read[6].ToString()];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void companyNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orderby("CompanyName");
        }
    }
}
