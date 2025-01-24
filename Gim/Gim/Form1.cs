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
        Question[] Easyquestion = new Question[4];
        public Form1()
        {
            InitializeComponent();
        }

        private void Checker_Click(object sender, EventArgs e)
        {
            if (question1.checker())
            {
                score++;
            }
            textBox1.Text = score.ToString();
        }
    }
}
