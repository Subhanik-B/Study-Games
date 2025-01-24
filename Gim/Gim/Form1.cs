using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gim
{
    public partial class Form1 : Form
    {
        int score = 0;
        int Diff = 0;

        Question[] Easyquestion = new Question[4];
        public Form1()
        {
            InitializeComponent();
        }

        private void Checker_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Easyquestion.Length; i++)
            {
                if (Easyquestion[i].checker())
                {
                    score++;
                }
            }
            textBox1.Text = score.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Easyquestion[0] = question1;
            Easyquestion[1] = question2;
            Easyquestion[2] = question3;
            Easyquestion[3] = question4;
        }
    }
}
