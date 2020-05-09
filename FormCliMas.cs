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

namespace ENA.NET
{
    public partial class FormCliMas : System.Windows.Forms.Form
    {
        public FormCliMas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validar();
            limpiar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Llama al formulario  Ingresar Control/Servicio
            System.Windows.Forms.Form Formulario = new FormConSer();
            Formulario.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCliMas_Load(object sender, EventArgs e)
        {
            //Agrega Tipo de Mascota
            comboBox1.Items.Add("Perro");
            comboBox1.Items.Add("Gato");
            comboBox1.Items.Add("Otro");

            //Agrega Raza de Mascota
            comboBox2.Items.Add("Podle");
            comboBox2.Items.Add("DashsHund");
            comboBox2.Items.Add("Quiltro");
        }

        private void limpiar()

        //Procedimiento para limpiar datos

        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text="";
            comboBox2.Text = "";
            textBox7.Clear();
            textBox6.Clear();
            textBox8.Clear();

        }

        
        private void validar()

        //Procedimiento para validar datos

        
        {
            //Texbox Nombre
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Ingrese Nombre de Cliente");
                textBox1.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }

            //Texbox Rut
            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Ingrese Rut de Cliente");
                textBox2.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
            }

            //Texbox Direccion
            if (textBox3.Text == "")
            {
                errorProvider1.SetError(textBox3, "Ingrese Direccion de Cliente");
                textBox3.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(textBox3, "");
            }

            //Texbox Mail
            if (textBox4.Text == "")
            {
                errorProvider1.SetError(textBox4, "Ingrese Mail de Cliente");
                textBox4.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(textBox4, "");
            }

            //Texbox Fono
            if (textBox5.Text == "")
            {
                errorProvider1.SetError(textBox5, "Ingrese Fono de Cliente");
                textBox5.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(textBox5, "");
            }

            //Combobox Tipo de Macota
            if (comboBox1.Text == "")
            {
                errorProvider1.SetError(comboBox1, "Ingrese Tipo de Macota");
                comboBox1.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(comboBox1, "");
            }

            //Combobox Raza
            if (comboBox2.Text == "")
            {
                errorProvider1.SetError(comboBox2, "Ingrese Raza");
                comboBox2.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(comboBox2, "");
            }

            //Texbox Color
            if (textBox7.Text == "")
            {
                errorProvider1.SetError(textBox7, "Ingrese color de Mascota");
                textBox7.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(textBox7, "");
            }

            //Texbox Nombre
            if (textBox6.Text == "")
            {
                errorProvider1.SetError(textBox6, "Ingrese Nombre de Macota");
                textBox6.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(textBox6, "");
            }

            //Texbox Edad
            if (textBox8.Text == "")
            {
                errorProvider1.SetError(textBox8, "Ingrese Mail de Cliente");
                textBox8.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(textBox8, "");
            }

















        }




    }
}
