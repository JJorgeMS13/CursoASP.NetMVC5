using Ejemplo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo
{
    public partial class Form1 : Form
    {
        private Alumno model = new Alumno();
        public Form1()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            dtG_Alumono.DataSource = model.Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dtG_Alumono_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            new Form2(Convert.ToInt32(dtG_Alumono.Rows[e.RowIndex].Cells[0].Value), this).ShowDialog();
        }

        private void btn_NuevoAlumno_Click(object sender, EventArgs e)
        {
            new Form2(0, this).ShowDialog();
        }
    }
}
