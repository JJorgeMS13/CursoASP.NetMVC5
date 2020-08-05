using Ejemplo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo
{
    public partial class Form2 : Form
    {
        public int id = 0;
        public Form1 form;
        private Alumno model = new Alumno();
        public Form2(int id, Form1 form1)
        {
            this.id = id;
            this.form = form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtB_Id.Text = this.id.ToString();

            if (this.id > 0)
            {
                btn_Eliminar.Visible = true;
                var alumno = model.Obtener(this.id);

                txtB_Nombre.Text = alumno.Nombre;
                txtB_Apellido.Text = alumno.Apellido;
                txtB_FechaNacimiento.Text = alumno.FechaNacimiento;

                if (alumno.Sexo == 1)
                {
                    rdB_Masculino.Checked = true;
                    rdB_Femenino.Checked = false;
                }
                else
                {
                    rdB_Masculino.Checked = false;
                    rdB_Femenino.Checked = true;
                }
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            model.Eliminar(id);
            this.form.CargarDatos();
            this.Close();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            var alunmo = new Alumno { 
            Id =  Convert.ToInt32(txtB_Id.Text),
            Nombre = txtB_Nombre.Text,
            Apellido = txtB_Apellido.Text,
            FechaNacimiento = txtB_FechaNacimiento.Text,
            Sexo = rdB_Masculino.Checked ? 1: 0
            };

           model.Guardar(alunmo);
            this.form.CargarDatos();
            this.Close();
        }
    }
}
