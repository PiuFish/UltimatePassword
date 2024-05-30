using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimatePassword3104S204
{
    public partial class Form1 : Form
    {
        int answer = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            answer = rnd.Next(1, 100);
            lblanswer.Text = answer.ToString();
        }

        private void bntok_Click(object sender, EventArgs e)
        {
            lblpassword.Text = txtpassword.Text;
            if (int.Parse(txtpassword.Text) > answer) lblmessage.Text = "小一點";
            else if (int.Parse(txtpassword.Text) < answer) lblmessage.Text = "大一點";
            else { lblmessage.Text = "正確答案"; }
        }

        private void btnshowanswer_Click(object sender, EventArgs e)
        {
            if (lblanswer.Visible == false)
            {
                lblanswer.Visible = true;
                btnshowanswer.Text = "隱藏答案";
            }
            else
            {
                lblanswer.Visible = false;
                btnshowanswer.Text = "顯示答案";
            }
        }
    }
}
