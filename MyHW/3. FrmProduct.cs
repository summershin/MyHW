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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();

            productsTableAdapter1.Fill(this.dataSet11.Products);
            bindingSource1.DataSource = dataSet11.Products;
            dataGridView1.DataSource = bindingSource1;
            //label4.DataBindings.Add("Text", bindingSource1, $"{bindingSource1.Position + 1} / {bindingSource1.Count}");

        }

        private void btn_Lastone_Click(object sender, EventArgs e)
        {

            bindingSource1.Position -= 1;
            //bindingSource1.MovePrevious();

        }

        private void btn_ToFirst_Click(object sender, EventArgs e)
        {

            bindingSource1.MoveFirst();

        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void btn_Nextone_Click(object sender, EventArgs e)
        {
            bindingSource1.Position += 1;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            label4.Text = $"{bindingSource1.Position + 1} / {bindingSource1.Count}";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a = 0, b = 0;
            bool x = int.TryParse(txt_pricehigh.Text, out b),
                y = int.TryParse(txt_pricelow.Text, out a);
            if (!x || !y)
            {
                MessageBox.Show("請輸入數字!!");
            }

            productsTableAdapter1.searchprice(dataSet11.Products, a, b);
            //this.bindingSource1.DataSource = this.dataSet11.Products;
            //this.dataGridView2.DataSource = this.dataSet11.Products;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            productsTableAdapter1.FillBysearchW(dataSet11.Products, txt_productname.Text);
        }
    }
}
