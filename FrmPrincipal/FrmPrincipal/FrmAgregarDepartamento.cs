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
    public partial class FrmAgregarDepartamento : Form
    {
        public FrmAgregarDepartamento()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Al seleccionar el btnGuardar se ejecuta un stored Procedure
        /// que se encarga de guardar los datos ingresados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreDepto.Text == "" || txtDescripcionDepto.Text == "")
            {
                MessageBox.Show("Hay datos vacios", "Error!", MessageBoxButtons.OK);
            }
            else
            {
                // Creación de la conexión
                SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress;
                                integrated security = true; database = AdventureWorks2014;");

                // Creación del comando sql
                SqlCommand cmd = new SqlCommand("sp_AgregarDepartamento", conn);

                // Definimos el comando como un StoredProcedure
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    // Se definen los parámetros necesarios para el storedProcedure 
                    cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@Nombre"].Value = txtNombreDepto.Text;

                    cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@Descripcion"].Value = txtDescripcionDepto.Text;

                    cmd.Parameters.Add(new SqlParameter("@FechaM", SqlDbType.DateTime));
                    cmd.Parameters["@FechaM"].Value = dtpFechaDepto.Value;

                    // Se Abre la conexión
                    conn.Open();

                    // Se procede a ejecutar el query
                    cmd.ExecuteNonQuery();

                    // Mensaje de ejecución exitosa
                    MessageBox.Show("Departamento Agregado de manera exitosa", "Departamentos", MessageBoxButtons.OK);

                    // Se procede a limpiar los textbox
                    txtNombreDepto.Text = "";
                    txtDescripcionDepto.Text = "";
                    txtNombreDepto.Focus();
                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de excepción");
                }
                finally
                {
                    // Se cierra la conexión
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
