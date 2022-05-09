using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_ordinario_Primera_vuelta_1._2
{
    public partial class inicio_frm : Form
    {
        public inicio_frm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idioma;
            idioma = comboBox1.SelectedIndex;
            switch (idioma)
            {
                case 0:
                    MessageBox.Show("Hi", "Inglés", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 1:
                    MessageBox.Show("Ciao", "Italiano", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 2:
                    MessageBox.Show("Bonjour", "Francés", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 3:
                    MessageBox.Show("Konichiwa", "Japonés", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 4:
                    MessageBox.Show("Aloha", "Hawaiiano", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if(respuesta==DialogResult.Yes)
            { 
                this.Close(); 
            }

        }
    }
}
