namespace CapaPresentacion
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ListaClientes = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenedor Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rut:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.Color.Red;
            this.lbl1.Location = new System.Drawing.Point(60, 213);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(10, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = ".";
            this.lbl1.Visible = false;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(132, 131);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(139, 20);
            this.txtRut.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(132, 169);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(63, 295);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(122, 23);
            this.btnInsertar.TabIndex = 6;
            this.btnInsertar.Text = "Insertar Cliente";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(233, 335);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar Cliente";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(63, 374);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar Cliente";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(63, 335);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(122, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar Cliente";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "---->";
            // 
            // ListaClientes
            // 
            this.ListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaClientes.Location = new System.Drawing.Point(387, 90);
            this.ListaClientes.Name = "ListaClientes";
            this.ListaClientes.Size = new System.Drawing.Size(364, 228);
            this.ListaClientes.TabIndex = 11;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(627, 335);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(124, 23);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar Tabla";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.ListaClientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ListaClientes;
        private System.Windows.Forms.Button btnActualizar;
    }
}

