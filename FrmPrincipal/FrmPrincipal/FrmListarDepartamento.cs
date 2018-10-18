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
    public partial class FrmListarDepartamento : Form
    {
        public FrmListarDepartamento()
        {
            InitializeComponent();
        }

        private void FrmListarDepartamento_Load(object sender, EventArgs e)
        {
            // Establecer Conexión
            SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress;
                                    integrated security = true; database = AdventureWorks2014;");
            // Creación del Query
            string sql = "SELECT * FROM HumanResources.Department;";

            // Creación del comando
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                // Abrimos la conexión
                conn.Open();

                // Ejecutamos el query mediante Datareader
                SqlDataReader rdr = cmd.ExecuteReader();

                //Llenamos con los datos
                while (rdr.Read())
                {
                    lstbListarDepto.Items.Add(rdr[0]);
                    lstbListarDepto.Items.Add(rdr[1]);
                    lstbListarDepto.Items.Add(rdr[2]);
                    lstbListarDepto.Items.Add(rdr[3]);
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
