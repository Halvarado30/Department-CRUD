using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCrearDepartamento_Click(object sender, EventArgs e)
        {
            FrmAgregarDepartamento crear = new FrmAgregarDepartamento();
            crear.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarDepartamento_Click(object sender, EventArgs e)
        {
            FrmActualizarDepartamento actualizar = new FrmActualizarDepartamento();
            actualizar.ShowDialog();
        }

        private void btnListarDepartamento_Click(object sender, EventArgs e)
        {
            FrmListarDepartamento listar = new FrmListarDepartamento();
            listar.ShowDialog();
        }

        private void btnEliminarDepartamento_Click(object sender, EventArgs e)
        {
            FrmEliminarDepartamento eliminar = new FrmEliminarDepartamento();
            eliminar.ShowDialog();
        }
    }
}
