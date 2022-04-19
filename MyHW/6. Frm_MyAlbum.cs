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
            try
            {
                pictureBox1.DataBindings.Add("Image", bindingSource2, "Photo", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                pictureBox1.Image = pictureBox1.ErrorImage;
            }

            //flowLayoutPanel1.DataBindings.Add("Image", bindingSource2, "Photo");
            //flowLayoutPanel2.DataBindings.Add("Image", bindingSource2, "Photo");

            DataTable dt = myAlbumDS1.Category;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LinkLabel c = new LinkLabel();
                splitContainer1.Panel1.Controls.Add(c);
                c.Left = 5;
                c.Top = 5 + 30 * i;
                c.Text = myAlbumDataSet1.City[i][1].ToString();
                c.Tag = myAlbumDataSet1.City[i][0];
                c.LinkClicked += C_LinkClicked;

            }
        }

        private void Pb_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.White;
        }

        private void C_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel lab = sender as LinkLabel;
            photoTableAdapter1.FillByCityId(myAlbumDataSet1.Photo, (int)lab.Tag);
            dataGridView1.DataSource = myAlbumDataSet1.Photo;
        }

        private void btn_ShowPhoto_Click(object sender, EventArgs e)
        {
            photoTableAdapter1.Fill(myAlbumDataSet1.Photo);
            dataGridView1.DataSource = myAlbumDataSet1.Photo;
        }

        private void btn_ShowCity_Click(object sender, EventArgs e)
        {
            cityTableAdapter1.Fill(myAlbumDataSet1.City);
            dataGridView1.DataSource = myAlbumDataSet1.City;
        }

        private void btn_SaveCity_Click(object sender, EventArgs e)
        {
            cityTableAdapter1.Update(myAlbumDataSet1.City);
        }


        private void btn_SavePhoto_Click(object sender, EventArgs e)
        {
            photoTableAdapter1.Update(myAlbumDataSet1.Photo);
        }
    }
}
