
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
            lblResult.Text = $"33, 4, 5, 11, 222, 34中\n奇數有: {odd}個，偶數有: {even}個";

        }

        private void btn_LongestName_Click(object sender, EventArgs e)
        {

            string[] names = { "aaa", "ksdkfjsdk", "aa", "cc", "ee", "Cat", "Coco", "shingeki", "rose", "maple" };
            int len = names[0].Length;
            int a = 0;
            for(int i = 0; i < names.Length; i++)
            {
                if (len < names[i].Length)
                {
                    len = names[i].Length;
                    a = i;
                }
            }
            lblResult.Text = $"aaa, ksdkfjsdk, aa, cc, ee, Cat, Coco, shingeki, rose, maple中\n" +
                $"最長的名字是: {names[a]}";

        }

        private void btn_OddOrEven_Click(object sender, EventArgs e)
        {

            bool a = int.TryParse(txt_keyin.Text, out int num);
            if (a)
            {
                lblResult.Text = num % 2 == 0 ? $"{num}是偶數" : $"{num}是奇數";
            }
            else MessageBox.Show("請輸入數字");

        }

        private void btn_MaxAndMin_Click(object sender, EventArgs e)
        {
            int[] scores = { 2, 3, 46, 33, 22, 100,150, 33,55};

            int max =  scores.Max();
            int min = MyMinScore(scores);
            lblResult.Text = $"2, 3, 46, 33, 22, 100,150, 33,55中\nMax/Min={max / min}";
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
            Array.Sort(nums);
            return nums[0];
        }

        private void btn_for_Click(object sender, EventArgs e)
        {

            int from, to, step, result = 0, flag;
            change(out from, out to, out step,out flag);
            if (flag == 0)
            {
                for (int i = from; i < to; i += step)
                {
                    result += i;
                }
            }
            lblResult.Text = result.ToString();
            
        }

        void change(out int from,out int to, out int step,out int flag)
        {

            bool a = int.TryParse(txt_from.Text, out from),
                b = int.TryParse(txt_to.Text, out to),
                c = int.TryParse(txt_step.Text, out step);
            if (!a||!b)
            {
                flag = 1;
                MessageBox.Show("請輸入數字");
                return;
            }
            else if (!c)
            {
                flag = 1;
                MessageBox.Show("請輸入數字");
                return;
            }
            flag = 0;

        }

        private void btn_while_Click(object sender, EventArgs e)
        {

            int from, to, step, flag, result = 0;
            change(out from, out to, out step, out flag);
            if (flag == 0)
            {
                while (from < to)
                {
                    result += from;
                    from += step;
                }
            }
            lblResult.Text = result.ToString();

        }

        private void btn_do_Click(object sender, EventArgs e)
        {

            int from, to, step, flag, result = 0;
            change(out from, out to, out step, out flag);
            if (flag == 0)
            {
                do
                {
                    result += from;
                    from += step;
                } while (from < to);
            }
            lblResult.Text = result.ToString();

        }

        private void btn_nine_Click(object sender, EventArgs e)
        {

            lblResult.Text = "";
            for(int i = 2; i <= 9; i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    lblResult.Text += $"{i} *{j} = {i * j}";
                    lblResult.Text += j != 9 ? ", " : "\n";
                }
            }

        }

        private void btn_binary_Click(object sender, EventArgs e)
        {

            int a=100;
            lblResult.Text = "";
            while (a!=0)
            {
                lblResult.Text = $"{a % 2}{lblResult.Text}";
                a /= 2;
            }

        }

        private void btn_Cc_Click(object sender, EventArgs e)
        {

            string[] name = { "aaa", "ksdkfjsdk", "aa", "cc", "ee", "Cat", "Coco", "shingeki", "rose", "maple" };
            int a = 0;
            foreach(string n in name)
            {
                a = n.Contains('C') || n.Contains('c') ? a+1 : a;
            }
            lblResult.Text = $"aaa, ksdkfjsdk, aa, cc, ee, Cat, Coco, shingeki, rose, maple中\n" +
                $"有C或c的有{a}個";

        }

        private void btn_params_Click(object sender, EventArgs e)
        {
            param(33, 4, 5, 11, 222, 34, 80);//2222222
        }
        void param(params int[] nums)
        {
            lblResult.Text = $"33, 4, 5, 11, 222, 34, 80中最大值為{ nums.Max()}";
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "結果";
        }

        private void btn_SixRan_Click(object sender, EventArgs e)
        {

            int flag = 0;
            int[] nums = new int[6];
            Random ran = new Random();
            while (flag != 6)
            {
                nums[flag] = ran.Next(1, 49);
                int a = 0;
                for(int i = 0; i < flag; i++)
                {
                    if (nums[flag] == nums[i])
                    {
                        a++;
                    }
                }
                if (a == 0)
                {
                    flag++;
                }
            }
            lblResult.Text = $"{nums[0]},{nums[1]},{nums[2]},{nums[3]},{nums[4]},{nums[5]}";
            
        }


    }
}
