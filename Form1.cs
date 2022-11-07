using AiLaTrieuPhu.BLL;
using AiLaTrieuPhu.DAL;
using AiLaTrieuPhu.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiLaTrieuPhu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataAccess dataAccess = new DataAccess();
            dataAccess.OpenConnection();
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            try
            {
                QuestionsAccessBLL access = new QuestionsAccessBLL();
                foreach(Questions questions in access.GetAllQuestions())
                {
                    if(pnlMark1.BackColor == Color.Transparent)
                    {
                        int qid = 1;
                        lblQuestions.Text = access.GetAllQuestions()[1].ques;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if(pnlMark1.BackColor == Color.Transparent)
            {
                lblQuestions.Text = "Anh Hiếu Thái có đẹp trai không ?";
                lblNoQues.Text = "Câu 1";
                btnAnswer1.Text = "Có";
                btnAnswer2.Text = "Có";
                btnAnswer3.Text = "A";
                btnAnswer4.Text = "B";
            }

            if(lblNoQues.Text == "Câu 1")
            {
                pnlMark1.BackColor = Color.DarkOrange;
            }
            if (lblNoQues.Text == "2")
            {
                pnlMark2.BackColor = Color.DarkOrange;
            }
            if (lblNoQues.Text == "3")
            {
                pnlMark3.BackColor = Color.DarkOrange;
            }
            if (lblNoQues.Text == "4")
            {
                pnlMark4.BackColor = Color.DarkOrange;
            }
            if (lblNoQues.Text == "5")
            {
                pnlMark5.BackColor = Color.DarkOrange;
            }
            if (lblNoQues.Text == "6")
            {
                pnlMark6.BackColor = Color.DarkOrange;
            }
            if (lblNoQues.Text == "7")
            {
                pnlMark7.BackColor = Color.DarkOrange;
            }
            if (lblNoQues.Text == "8")
            {
                pnlMark8.BackColor = Color.DarkOrange;
            }
            if (lblNoQues.Text == "9")
            {
                pnlMark9.BackColor = Color.DarkOrange;
            }
            if (lblNoQues.Text == "10")
            {
                pnlMark10.BackColor = Color.DarkOrange;
            }
            if (lblNoQues.Text == "11")
            {
                pnlMark11.BackColor = Color.DarkOrange;
            }
            if (lblNoQues.Text == "12")
            {
                pnlMark12.BackColor = Color.DarkOrange;
            }
            if (lblNoQues.Text == "13")
            {
                pnlMark13.BackColor = Color.DarkOrange;
            }
            if (lblNoQues.Text == "14")
            {
                pnlMark14.BackColor = Color.DarkOrange;
            }
            if (lblNoQues.Text == "15")
            {
                pnlMark15.BackColor = Color.DarkOrange;
            }
        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            if(lblNoQues.Text == "Câu 1")
            {
                btnAnswer1.FillColor = Color.DarkGreen;
            }
            else
            {
                btnAnswer1.FillColor = Color.DarkRed;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pnlListPhone.Visible = true;
        }
    }
}
