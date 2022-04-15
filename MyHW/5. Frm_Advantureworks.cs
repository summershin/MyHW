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
    public partial class Frm_Advantureworks : Form
    {
        public Frm_Advantureworks()
        {
            InitializeComponent();

            productPhotoTableAdapter1.Fill(adventureWorks2019DS1.ProductPhoto);
            bindingSource1.DataSource = adventureWorks2019DS1.ProductPhoto;
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
            label1.Text = $"{bindingSource1.Position + 1} / {bindingSource1.Count}";

            productPhotoTableAdapter2.FillByorderyear(adventureWorks2019DS2.ProductPhoto);
            DateTime dt = (DateTime)adventureWorks2019DS2.ProductPhoto[0][5];
            for (int i = 0; i < adventureWorks2019DS2.ProductPhoto.Rows.Count; i++)
            {
                if(dt.Year!= ((DateTime)adventureWorks2019DS2.ProductPhoto[i][5]).Year)
                {
                    comboBox1.Items.Add(dt.Year);
                    dt = (DateTime)adventureWorks2019DS2.ProductPhoto[i][5];
                }
                
            }
            comboBox1.Items.Add(dt.Year);
            
        }


        private void btn_Preview_Click(object sender, EventArgs e)
        {
            bindingSource1.Position -= 1;
            label1.Text = $"{bindingSource1.Position + 1} / {bindingSource1.Count}";
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            bindingSource1.Position = bindingSource1.Count-1;
            label1.Text = $"{bindingSource1.Position + 1} / {bindingSource1.Count}";
        }

        private void btn_FirstData_Click(object sender, EventArgs e)
        {
            bindingSource1.Position = 0;
            label1.Text = $"{bindingSource1.Position + 1} / {bindingSource1.Count}";
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            bindingSource1.Position += 1;
            label1.Text = $"{bindingSource1.Position + 1} / {bindingSource1.Count}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productPhotoTableAdapter1.FillByaModified(adventureWorks2019DS1.ProductPhoto, dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            productPhotoTableAdapter1.FillBycomYear(adventureWorks2019DS1.ProductPhoto, Convert.ToInt32(comboBox1.SelectedItem));
            bindingSource1.DataSource = adventureWorks2019DS1.ProductPhoto;
            bindingNavigator1.BindingSource = bindingSource1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource1.Sort = "modifieddate";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            productPhotoTableAdapter1.Fill(adventureWorks2019DS1.ProductPhoto);
            bindingSource1.DataSource = adventureWorks2019DS1.ProductPhoto;
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
            label1.Text = $"{bindingSource1.Position + 1} / {bindingSource1.Count}";
            bindingSource1.Sort = "ProductPhotoID";

        }
    }
}
