using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace MyHW
{
    public partial class Frm_Logon : Form
    {
        public Frm_Logon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                memberTableAdapter1.FillByLogon(myMemberDS1.Member, txt_UserName.Text, txt_Password.Text);
                if (myMemberDS1.Member.Rows.Count == 0)
                {
                    MessageBox.Show("查無使用者");
                }
                else
                {
                    MessageBox.Show("使用者已註冊");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("確定要退出嗎?", "關閉", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                string password = txt_Password.Text;
                password = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");

                memberTableAdapter1.Insert(txt_UserName.Text, password);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
