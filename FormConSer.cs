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
    public partial class FormConSer : System.Windows.Forms.Form
    {
        public FormConSer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Llama al formularion Consultar Control/Servicio
            System.Windows.Forms.Form Formulario = new FormConsultar();
            Formulario.Show();
        }

        private void FormConSer_Load(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}
