using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace FrmPrincipal
{
    public partial class FrmActualizarDepartamento : Form
    {
        public FrmActualizarDepartamento()
        {
            InitializeComponent();
        }

        /// <summary>
        /// El btnActualizar se encargará de ejecutar el stored Procedure encargado
        /// de modificar los datos de un dato almacenado en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Verificar si el campo del código está vacío
            if (txtCodigoDepto.Text == "")
            {
                MessageBox.Show("Es necesario el código del departamento", "Departamentos", MessageBoxButtons.OK);

            }
            else
            {
                // Se crea la conexión
                SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress;
                                    integrated security = true; database = AdventureWorks2014;");

                // Creación del comando
                SqlCommand cmd = new SqlCommand("sp_EditarDepartamento", conn);

                // Especificación del tipo de comando
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    // Definición de los parámetros SP
                    cmd.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.SmallInt, 10));
                    cmd.Parameters["@Codigo"].Value = txtCodigoDepto.Text;

                    cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@Nombre"].Value = txtNombreDepto.Text;

                    cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@Descripcion"].Value = txtDecripcionDepto.Text;

                    cmd.Parameters.Add(new SqlParameter("@FechaM", SqlDbType.DateTime));
                    cmd.Parameters["@FechaM"].Value = dtpFechaDepto.Value;

                    // Abrir conexión
                    conn.Open();

                    // Se ejecuta el comando
                    cmd.ExecuteNonQuery();

                    // Mensaje de confirmación
                    MessageBox.Show("Departamento actualizado correctacmente", "Departamentos", MessageBoxButtons.OK);
                    txtCodigoDepto.Text = "";
                    txtNombreDepto.Text = "";
                    txtDecripcionDepto.Text = "";
                    txtCodigoDepto.Focus();
                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");

                }
                finally
                {
                    // Cerrar conexión
                    conn.Close();
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
