namespace FrmPrincipal
{
    partial class FrmActualizarDepartamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblCodigoDepto = new System.Windows.Forms.Label();
            this.lblNombreDepto = new System.Windows.Forms.Label();
            this.lblDescripcionDepto = new System.Windows.Forms.Label();
            this.lblFechaDepto = new System.Windows.Forms.Label();
            this.txtCodigoDepto = new System.Windows.Forms.TextBox();
            this.txtNombreDepto = new System.Windows.Forms.TextBox();
            this.txtDecripcionDepto = new System.Windows.Forms.TextBox();
            this.dtpFechaDepto = new System.Windows.Forms.DateTimePicker();
            this.lblTituloUD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(56, 281);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(131, 44);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(360, 281);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(144, 44);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblCodigoDepto
            // 
            this.lblCodigoDepto.AutoSize = true;
            this.lblCodigoDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDepto.Location = new System.Drawing.Point(56, 75);
            this.lblCodigoDepto.Name = "lblCodigoDepto";
            this.lblCodigoDepto.Size = new System.Drawing.Size(86, 25);
            this.lblCodigoDepto.TabIndex = 2;
            this.lblCodigoDepto.Text = "Código: ";
            // 
            // lblNombreDepto
            // 
            this.lblNombreDepto.AutoSize = true;
            this.lblNombreDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDepto.Location = new System.Drawing.Point(59, 126);
            this.lblNombreDepto.Name = "lblNombreDepto";
            this.lblNombreDepto.Size = new System.Drawing.Size(87, 25);
            this.lblNombreDepto.TabIndex = 3;
            this.lblNombreDepto.Text = "Nombre:";
            // 
            // lblDescripcionDepto
            // 
            this.lblDescripcionDepto.AutoSize = true;
            this.lblDescripcionDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionDepto.Location = new System.Drawing.Point(62, 171);
            this.lblDescripcionDepto.Name = "lblDescripcionDepto";
            this.lblDescripcionDepto.Size = new System.Drawing.Size(125, 25);
            this.lblDescripcionDepto.TabIndex = 4;
            this.lblDescripcionDepto.Text = "Descripción: ";
            // 
            // lblFechaDepto
            // 
            this.lblFechaDepto.AutoSize = true;
            this.lblFechaDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDepto.Location = new System.Drawing.Point(65, 216);
            this.lblFechaDepto.Name = "lblFechaDepto";
            this.lblFechaDepto.Size = new System.Drawing.Size(78, 25);
            this.lblFechaDepto.TabIndex = 5;
            this.lblFechaDepto.Text = "Fecha: ";
            // 
            // txtCodigoDepto
            // 
            this.txtCodigoDepto.Location = new System.Drawing.Point(193, 78);
            this.txtCodigoDepto.Name = "txtCodigoDepto";
            this.txtCodigoDepto.Size = new System.Drawing.Size(169, 22);
            this.txtCodigoDepto.TabIndex = 6;
            // 
            // txtNombreDepto
            // 
            this.txtNombreDepto.Location = new System.Drawing.Point(193, 126);
            this.txtNombreDepto.Name = "txtNombreDepto";
            this.txtNombreDepto.Size = new System.Drawing.Size(291, 22);
            this.txtNombreDepto.TabIndex = 7;
            // 
            // txtDecripcionDepto
            // 
            this.txtDecripcionDepto.Location = new System.Drawing.Point(193, 171);
            this.txtDecripcionDepto.Name = "txtDecripcionDepto";
            this.txtDecripcionDepto.Size = new System.Drawing.Size(291, 22);
            this.txtDecripcionDepto.TabIndex = 8;
            // 
            // dtpFechaDepto
            // 
            this.dtpFechaDepto.Location = new System.Drawing.Point(193, 218);
            this.dtpFechaDepto.Name = "dtpFechaDepto";
            this.dtpFechaDepto.Size = new System.Drawing.Size(291, 22);
            this.dtpFechaDepto.TabIndex = 9;
            // 
            // lblTituloUD
            // 
            this.lblTituloUD.AutoSize = true;
            this.lblTituloUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloUD.Location = new System.Drawing.Point(161, 20);
            this.lblTituloUD.Name = "lblTituloUD";
            this.lblTituloUD.Size = new System.Drawing.Size(292, 29);
            this.lblTituloUD.TabIndex = 10;
            this.lblTituloUD.Text = "Actualizar Departamento";
            // 
            // FrmActualizarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 350);
            this.Controls.Add(this.lblTituloUD);
            this.Controls.Add(this.dtpFechaDepto);
            this.Controls.Add(this.txtDecripcionDepto);
            this.Controls.Add(this.txtNombreDepto);
            this.Controls.Add(this.txtCodigoDepto);
            this.Controls.Add(this.lblFechaDepto);
            this.Controls.Add(this.lblDescripcionDepto);
            this.Controls.Add(this.lblNombreDepto);
            this.Controls.Add(this.lblCodigoDepto);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnActualizar);
            this.Name = "FrmActualizarDepartamento";
            this.Text = "Actualizar Departamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblCodigoDepto;
        private System.Windows.Forms.Label lblNombreDepto;
        private System.Windows.Forms.Label lblDescripcionDepto;
        private System.Windows.Forms.Label lblFechaDepto;
        private System.Windows.Forms.TextBox txtCodigoDepto;
        private System.Windows.Forms.TextBox txtNombreDepto;
        private System.Windows.Forms.TextBox txtDecripcionDepto;
        private System.Windows.Forms.DateTimePicker dtpFechaDepto;
        private System.Windows.Forms.Label lblTituloUD;
    }
}