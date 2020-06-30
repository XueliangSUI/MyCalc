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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOP1.Text); 
            var y = int.Parse(this.textBoxOP2.Text);
            var z = x + y;
            this.labelResult.Text = z.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOP1.Text);
            var y = int.Parse(this.textBoxOP2.Text);
            var z = x - y;
            this.labelResult.Text = z.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOP1.Text);
            var y = int.Parse(this.textBoxOP2.Text);
            var z = x * y;
            this.labelResult.Text = z.ToString();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOP1.Text);
            var y = int.Parse(this.textBoxOP2.Text);
            var z = x + y;
            if(y == 0)
            {
                this.labelResult.Text = "除数不能为0";
            }
            else
            {
                this.labelResult.Text = z.ToString();
            }
            
        }

        
    }
}
