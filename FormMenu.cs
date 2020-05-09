using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENA.NET
{
    public partial class FormMenu : System.Windows.Forms.Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form Formulario = new FormCliMas();
            Formulario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form Formulario = new FormConSer();
            Formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form Formulario = new FormConsultar();
            Formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form Formulario = new FormConsultar();
            Formulario.Show();
        }
    }
}
