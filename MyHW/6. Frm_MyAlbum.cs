using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class Frm_MyAlbum : Form
    {
        public Frm_MyAlbum()
        {
            InitializeComponent();

            categoryTableAdapter1.Fill(myAlbumDS1.Category);
            bindingSource1.DataSource = myAlbumDS1.Category;
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
            textBox1.DataBindings.Add("Text", bindingSource1, "CategoryID");
            textBox2.DataBindings.Add("Text", bindingSource1, "Category");

            photoTableAdapter1.Fill(myAlbumDS1.Photo);
            bindingSource2.DataSource = myAlbumDS1.Photo;
            bindingNavigator2.BindingSource = bindingSource2;
            dataGridView2.DataSource = bindingSource2;
            textBox4.DataBindings.Add("Text", bindingSource2, "PhotoID");
            textBox3.DataBindings.Add("Text", bindingSource2, "CategoryID");
            textBox5.DataBindings.Add("Text", bindingSource2, "Description");
            textBox6.DataBindings.Add("Text", bindingSource2, "PhotoName");
            dateTimePicker1.DataBindings.Add("Value", bindingSource2, "Date");
            //try
            //{
            //    pictureBox1.DataBindings.Add("Image", bindingSource2, "Photo");
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    pictureBox1.Image = pictureBox1.ErrorImage;
            //}

            //flowLayoutPanel1.DataBindings.Add("Image", bindingSource2, "Photo");
            //flowLayoutPanel2.DataBindings.Add("Image", bindingSource2, "Photo");

            DataTable dt = myAlbumDS1.Category;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LinkLabel lk = new LinkLabel();
                lk.Text = dt.Rows[i]["Category"].ToString();
                lk.Left = 5;
                lk.Top = 25 * i + 5;
                lk.Tag = dt.Rows[i]["CategoryID"];
                splitContainer1.Panel1.Controls.Add(lk);
                lk.Click += Lk_Click;
                comboBox1.Items.Add(dt.Rows[i]["Category"]);
            }

        }

        private void Lk_Click(object sender, EventArgs e)
        {
            photoTableAdapter1.FillByCategoryID(myAlbumDS1.Photo, (int)((LinkLabel)sender).Tag);
            DataTable dt = myAlbumDS1.Photo;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Image = (Image)dt.Rows[i]["Photo"];
                flowLayoutPanel1.Controls.Add(pb);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                string folder =  folderBrowserDialog1.SelectedPath;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            try
            {
                using(SqlConnection conn =new SqlConnection("Data Source=.;Initial Catalog=aa;Integrated Security=True"))
                {
                    SqlCommand com = new SqlCommand();
                    byte[] bytes = null;
                    
                    com.CommandText = $"insert myalbumpicture values ()";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
