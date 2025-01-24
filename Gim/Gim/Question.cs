using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gim
{
    public partial class Question : UserControl
    {
        public Image image { get; set; }
        public String correctAnswer { get; set; }
        public String Queston { get; set; }
        public Boolean isInt {  get; set; }
        public Question()
        {
            InitializeComponent();
        }

        public void Question_Load(object sender, EventArgs e)
        {
            Picture.Image = image;
            Prompt.Text = Queston;
        }

        public Boolean checker()
        {
            if (!isInt)
            {
                if (Answer.Text.ToLower() == correctAnswer)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if ()
                {

                }
            }
        }
    }
}
