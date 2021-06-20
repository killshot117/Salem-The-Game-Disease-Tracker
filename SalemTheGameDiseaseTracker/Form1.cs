using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalemTheGameDiseaseTracker
{
    public partial class Form1 : Form
    {
        int cough = 0, vomit = 0, dizzy = 0, headache = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            cough = cough + 1;
            CoughCount.Text = Convert.ToString(cough);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dizzy = dizzy + 1;
            DizzinessCount.Text = Convert.ToString(dizzy);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vomit = vomit + 1;
            VomitingCount.Text = Convert.ToString(vomit);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            headache = headache + 1;
            HeadacheCount.Text = Convert.ToString(headache);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cough = cough - 1;
            CoughCount.Text = Convert.ToString(cough);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dizzy = dizzy - 1;
            DizzinessCount.Text = Convert.ToString(dizzy);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            vomit = vomit - 1;
            VomitingCount.Text = Convert.ToString(vomit);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            headache = headache - 1;
            HeadacheCount.Text = Convert.ToString(headache);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cough = 0;
            vomit = 0;
            dizzy = 0;
            headache = 0;
            HeadacheCount.Text = Convert.ToString(headache);
            VomitingCount.Text = Convert.ToString(vomit);
            DizzinessCount.Text = Convert.ToString(dizzy);
            CoughCount.Text = Convert.ToString(cough);
        }

        public Form1()
        {
            InitializeComponent();
            CoughCount.Text = Convert.ToString(0);
            VomitingCount.Text = Convert.ToString(0);
            DizzinessCount.Text = Convert.ToString(0);
            HeadacheCount.Text = Convert.ToString(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
