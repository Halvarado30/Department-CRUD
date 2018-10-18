namespace FrmPrincipal
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.btnEliminarDepartamento = new System.Windows.Forms.Button();
            this.btnActualizarDepartamento = new System.Windows.Forms.Button();
            this.btnCrearDepartamento = new System.Windows.Forms.Button();
            this.btnListarDepartamento = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.btnEliminarDepartamento);
            this.gbPrincipal.Controls.Add(this.btnActualizarDepartamento);
            this.gbPrincipal.Controls.Add(this.btnCrearDepartamento);
            this.gbPrincipal.Controls.Add(this.btnListarDepartamento);
            this.gbPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrincipal.Location = new System.Drawing.Point(43, 29);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(611, 297);
            this.gbPrincipal.TabIndex = 0;
            this.gbPrincipal.TabStop = false;
            this.gbPrincipal.Text = "Opciones disponibles para departamentos";
            // 
            // btnEliminarDepartamento
            // 
            this.btnEliminarDepartamento.Location = new System.Drawing.Point(336, 184);
            this.btnEliminarDepartamento.Name = "btnEliminarDepartamento";
            this.btnEliminarDepartamento.Size = new System.Drawing.Size(235, 47);
            this.btnEliminarDepartamento.TabIndex = 3;
            this.btnEliminarDepartamento.Text = "Eliminar Departamento";
            this.btnEliminarDepartamento.UseVisualStyleBackColor = true;
            // 
            // btnActualizarDepartamento
            // 
            this.btnActualizarDepartamento.Location = new System.Drawing.Point(44, 184);
            this.btnActualizarDepartamento.Name = "btnActualizarDepartamento";
            this.btnActualizarDepartamento.Size = new System.Drawing.Size(235, 47);
            this.btnActualizarDepartamento.TabIndex = 2;
            this.btnActualizarDepartamento.Text = "Actualizar";
            this.btnActualizarDepartamento.UseVisualStyleBackColor = true;
            this.btnActualizarDepartamento.Click += new System.EventHandler(this.btnActualizarDepartamento_Click);
            // 
            // btnCrearDepartamento
            // 
            this.btnCrearDepartamento.Location = new System.Drawing.Point(336, 73);
            this.btnCrearDepartamento.Name = "btnCrearDepartamento";
            this.btnCrearDepartamento.Size = new System.Drawing.Size(235, 47);
            this.btnCrearDepartamento.TabIndex = 1;
            this.btnCrearDepartamento.Text = "Crear Departamento";
            this.btnCrearDepartamento.UseVisualStyleBackColor = true;
            this.btnCrearDepartamento.Click += new System.EventHandler(this.btnCrearDepartamento_Click);
            // 
            // btnListarDepartamento
            // 
            this.btnListarDepartamento.Location = new System.Drawing.Point(44, 73);
            this.btnListarDepartamento.Name = "btnListarDepartamento";
            this.btnListarDepartamento.Size = new System.Drawing.Size(235, 47);
            this.btnListarDepartamento.TabIndex = 0;
            this.btnListarDepartamento.Text = "Listar Departamentos";
            this.btnListarDepartamento.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(501, 341);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(153, 47);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 410);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbPrincipal);
            this.Name = "FrmPrincipal";
            this.Text = "Operaciones CRUD con departamentos Adventure Works";
            this.gbPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.Button btnEliminarDepartamento;
        private System.Windows.Forms.Button btnActualizarDepartamento;
        private System.Windows.Forms.Button btnCrearDepartamento;
        private System.Windows.Forms.Button btnListarDepartamento;
        private System.Windows.Forms.Button btnSalir;
    }
}

