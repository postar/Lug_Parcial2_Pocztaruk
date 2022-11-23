using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lug_Parcial2_Pocztaruk
{
    public partial class Form1 : Form
    {
        BE.EMPLEADO empleado;
        BLL.EMPLEADO gestorEmpleado = new BLL.EMPLEADO();

        public Form1()
        {
            InitializeComponent();
        }

        public void EnlazarEmpleados()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestorEmpleado.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Complete los campos correctamente");

            }
            else
            {
                empleado = new BE.EMPLEADO();
                empleado.Nombre = textBox1.Text;
                empleado.Apellido = textBox2.Text;
                empleado.SueldoBruto = float.Parse(textBox3.Text);
                gestorEmpleado.Alta(empleado);
                EnlazarEmpleados();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnlazarEmpleados();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Complete los campos correctamente");

            }
            else
            {
                empleado = new BE.EMPLEADO();
                empleado.Id = int.Parse(textBox4.Text);
                empleado.Nombre = textBox1.Text;
                empleado.Apellido = textBox2.Text;
                empleado.SueldoBruto = float.Parse(textBox3.Text);
                gestorEmpleado.Modificacion(empleado);
                EnlazarEmpleados();
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Complete los campos correctamente");

            }
            empleado = new BE.EMPLEADO();
            empleado.Id = int.Parse(textBox4.Text);
            gestorEmpleado.Borrar(empleado);
            EnlazarEmpleados();
        }
    }
}
