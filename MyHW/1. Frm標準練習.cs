
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmHomeWork : Form
    {
        public FrmHomeWork()
        {
            InitializeComponent();
        }

        private void btn_threenums_Click(object sender, EventArgs e)
        {
            int a = 100;
            int b = 66;
            int c = 77;
            int max = a > b ? a : b;
            max = max > c ? max : c;
            lblResult.Text = max.ToString();
        }

        private void btn_OddAndEven_Click(object sender, EventArgs e)
        {

            int[] nums = { 33, 4, 5, 11, 222, 34 };
            int odd = 0, even = 0;
            foreach(int a in nums)
            {
                if (a % 2 == 0)
                {
                    even++;
                }
                else odd++;
            }
            lblResult.Text = $"奇數有: {odd}個，偶數有: {even}個";

        }

        private void btn_LongestName_Click(object sender, EventArgs e)
        {

            string[] names = { "aaa", "ksdkfjsdk"};


        }

        private void btn_OddOrEven_Click(object sender, EventArgs e)
        {

            bool a = int.TryParse(txt_keyin.Text, out int num);
            if (a)
            {
                lblResult.Text = num % 2 == 0 ? "偶數" : "奇數";
            }
            else MessageBox.Show("請輸入數字");

        }

        private void btn_MaxAndMin_Click(object sender, EventArgs e)
        {
            int[] scores = { 2, 3, 46, 33, 22, 100,150, 33,55};

            int max =  scores.Max();
            //MessageBox.Show("Max = " + max);

            //Array.Sort(scores);
            //MessageBox.Show("Max =" + scores[scores.Length - 1]);

            //================================

            //Point[] points = new Point[3];
            //points[0].X = 3;
            //points[0].Y = 4;
            ////System.InvalidOperationException: '無法比較陣列中的兩個元素。'

            //Array.Sort(points);

            //=================================

            
        }

        int MyMinScore(int[] nums)
        {
            return 10;
        }

        private void btn_for_Click(object sender, EventArgs e)
        {

        }

        private void btn_while_Click(object sender, EventArgs e)
        {

        }

        private void btn_do_Click(object sender, EventArgs e)
        {

        }

        private void btn_nine_Click(object sender, EventArgs e)
        {

        }

        private void btn_bin_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Cc_Click(object sender, EventArgs e)
        {

        }

        private void btn_params_Click(object sender, EventArgs e)
        {

        }
    }
}
