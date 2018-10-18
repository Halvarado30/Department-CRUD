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
    public partial class FrmEliminarDepartamento : Form
    {
        // Establecer conexión
        SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress;
                             integrated security = true; database = AdventureWorks2014;");
        public FrmEliminarDepartamento()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cierra el formulario actual y regresa al principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEliminarDepartamento_Load(object sender, EventArgs e)
        {
            // Creación del query
            string sql = "SELECT DepartmentID, Name FROM HumanResources.Department";

            // Creación del comando
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                // Abrimos la conexión
                conn.Open();

                // Ejecutamos el query mediante un Datareader
                SqlDataReader rdr = cmd.ExecuteReader();

                // Llenamos con los datos
                while (rdr.Read())
                {
                    lstbDepartamentos.Items.Add(rdr[0]);
                    lstbDepartamentos.Items.Add(rdr[1]);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");

            }
            finally
            {
                // Cerrar la conexión
                conn.Close();
            }
        }

        /// <summary>
        /// Ejecuta un stored procedure que elimina el departamento seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Creación el comando para el stored procedure
            SqlCommand cmd = new SqlCommand("sp_EliminarDepartamento", conn);

            // Se especifica el tipo de comando
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                // Parámetros
                cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.SmallInt));
                cmd.Parameters["@codigo"].Value = lstbDepartamentos.SelectedItem.ToString();

                // Abrir conexión
                conn.Open();

                // Eliminar el departamento
                if (lstbDepartamentos.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor debe seleccionar un departamento", "Departamentos", MessageBoxButtons.OK);
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Departamento elimando correctamente", "Departamentos", MessageBoxButtons.OK);
                    lstbDepartamentos.SelectedIndex = -1;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la excepción");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("recargue el valor de los departamentos" + ex.StackTrace, "detalles de la excepción");
            }
            finally
            {
                // Cerrar conexión
                conn.Close();
            }
        }
    }
}
