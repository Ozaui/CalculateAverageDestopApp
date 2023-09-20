using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateAvarageDestopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double result = (Convert.ToDouble(txt_firstExam.Text) * 0.4) + (Convert.ToDouble(txt_finalExam.Text) * 0.6);
            lbl_result.Text = Convert.ToString(result);
        }
    }
}
