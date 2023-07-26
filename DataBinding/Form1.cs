using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBinding
{
    public partial class Form1 : Form
    {
        bool isBind = true;
        public Form1()
        {
            InitializeComponent();
            Controls.Add(textBox1);
            Controls.Add(label1);
           
        }

     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.DataBindings.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
                label1.DataBindings.Add(new Binding("Text", textBox1, "Text"));

        }
    }
}
