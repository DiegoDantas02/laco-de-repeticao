using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laco_de_repeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listarFor.Items.Add(1);
            listarFor.Items.Add(2);
            listarFor.Items.Add(3);
            listarFor.Items.Add(4);
            listarFor.Items.Add(5);
            listarFor.Items.Add(6);
            listarFor.Items.Add(7);
            listarFor.Items.Add(8);
            listarFor.Items.Add(9);
            listarFor.Items.Add(10);
        }
    }
}
