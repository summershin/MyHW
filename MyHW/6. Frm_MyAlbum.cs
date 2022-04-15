using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            cityTableAdapter1.Fill(myAlbumDataSet1.City);
            for(int i = 0; i < myAlbumDataSet1.City.Rows.Count; i++)
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
