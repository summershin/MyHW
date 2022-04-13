using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class Frm_DataSet__結構 : Form
    {
        public Frm_DataSet__結構()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            categoriesTableAdapter1.Fill(dataSet11.Categories);
            productsTableAdapter1.Fill(dataSet11.Products);
            customersTableAdapter1.Fill(dataSet11.Customers);

            dataGridView1.DataSource = dataSet11.Categories;
            dataGridView2.DataSource = dataSet11.Products;
            dataGridView3.DataSource = dataSet11.Customers;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < dataSet11.Tables.Count; i++)
            {
                listBox1.Items.Add(dataSet11.Tables[i].TableName);

                string columns = "";
                for(int j = 0; j < dataSet11.Tables[i].Columns.Count; j++)
                {
                    columns += $"{dataSet11.Tables[i].Columns[j].ColumnName,-40}";
                    
                }
                listBox1.Items.Add(columns);

                for(int k = 0; k < dataSet11.Tables[i].Rows.Count; k++)
                {
                    string rowcolumn = "";
                    for(int l = 0; l < dataSet11.Tables[i].Columns.Count; l++)
                    {
                        rowcolumn += $"{dataSet11.Tables[i].Rows[k][l],-40}";
                    }
                    listBox1.Items.Add(rowcolumn);
                }
                
                listBox1.Items.Add("= = = = = = = = = = = = = = = = = = = =");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataSet11.Categories.WriteXml("categories.xml", XmlWriteMode.WriteSchema);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataSet11.Categories.Clear();
            dataSet11.Categories.ReadXml("categories.xml");
            dataGridView1.DataSource = dataSet11.Categories;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel1Collapsed = !splitContainer2.Panel1Collapsed;
        }
    }
}
