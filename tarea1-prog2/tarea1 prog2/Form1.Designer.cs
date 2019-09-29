namespace tarea1_prog2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.Edad = new System.Windows.Forms.Label();
            this.Nacimiento = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.Label();
            this.Pais = new System.Windows.Forms.Label();
            this.Provincia = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.textBoxNacimiento = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.textBoxProvincia = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Telefono = new System.Windows.Forms.Label();
            this.Celular = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxCelular = new System.Windows.Forms.TextBox();
            this.dtgvAgenda = new System.Windows.Forms.DataGridView();
            this.TxtNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblInformacion);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.textBoxCelular);
            this.panel1.Controls.Add(this.textBoxTelefono);
            this.panel1.Controls.Add(this.Celular);
            this.panel1.Controls.Add(this.Telefono);
            this.panel1.Controls.Add(this.textBoxProvincia);
            this.panel1.Controls.Add(this.textBoxPais);
            this.panel1.Controls.Add(this.textBoxDireccion);
            this.panel1.Controls.Add(this.textBoxNacimiento);
            this.panel1.Controls.Add(this.textBoxEdad);
            this.panel1.Controls.Add(this.textBoxApellido);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Controls.Add(this.Provincia);
            this.panel1.Controls.Add(this.Pais);
            this.panel1.Controls.Add(this.Direccion);
            this.panel1.Controls.Add(this.Nacimiento);
            this.panel1.Controls.Add(this.Edad);
            this.panel1.Controls.Add(this.Apellido);
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 295);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agenda ";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(93, 62);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(81, 25);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            this.Nombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido.Location = new System.Drawing.Point(93, 95);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(82, 25);
            this.Apellido.TabIndex = 2;
            this.Apellido.Text = "Apellido";
            this.Apellido.Click += new System.EventHandler(this.label3_Click);
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edad.Location = new System.Drawing.Point(93, 123);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(58, 25);
            this.Edad.TabIndex = 3;
            this.Edad.Text = "Edad";
            // 
            // Nacimiento
            // 
            this.Nacimiento.AutoSize = true;
            this.Nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nacimiento.Location = new System.Drawing.Point(93, 154);
            this.Nacimiento.Name = "Nacimiento";
            this.Nacimiento.Size = new System.Drawing.Size(196, 25);
            this.Nacimiento.TabIndex = 4;
            this.Nacimiento.Text = "Fecha de Nacimiento";
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion.Location = new System.Drawing.Point(93, 182);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(93, 25);
            this.Direccion.TabIndex = 5;
            this.Direccion.Text = "Direccion";
            // 
            // Pais
            // 
            this.Pais.AutoSize = true;
            this.Pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pais.Location = new System.Drawing.Point(441, 62);
            this.Pais.Name = "Pais";
            this.Pais.Size = new System.Drawing.Size(50, 25);
            this.Pais.TabIndex = 6;
            this.Pais.Text = "Pais";
            // 
            // Provincia
            // 
            this.Provincia.AutoSize = true;
            this.Provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Provincia.Location = new System.Drawing.Point(441, 94);
            this.Provincia.Name = "Provincia";
            this.Provincia.Size = new System.Drawing.Size(92, 25);
            this.Provincia.TabIndex = 7;
            this.Provincia.Text = "Provincia";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(314, 62);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 8;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(314, 95);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellido.TabIndex = 9;
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(314, 123);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(100, 20);
            this.textBoxEdad.TabIndex = 10;
            // 
            // textBoxNacimiento
            // 
            this.textBoxNacimiento.Location = new System.Drawing.Point(314, 154);
            this.textBoxNacimiento.Name = "textBoxNacimiento";
            this.textBoxNacimiento.Size = new System.Drawing.Size(100, 20);
            this.textBoxNacimiento.TabIndex = 11;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(314, 187);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDireccion.TabIndex = 12;
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(587, 68);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(100, 20);
            this.textBoxPais.TabIndex = 13;
            // 
            // textBoxProvincia
            // 
            this.textBoxProvincia.Location = new System.Drawing.Point(587, 100);
            this.textBoxProvincia.Name = "textBoxProvincia";
            this.textBoxProvincia.Size = new System.Drawing.Size(100, 20);
            this.textBoxProvincia.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvAgenda);
            this.panel2.Location = new System.Drawing.Point(12, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 221);
            this.panel2.TabIndex = 1;
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono.Location = new System.Drawing.Point(441, 129);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(89, 25);
            this.Telefono.TabIndex = 15;
            this.Telefono.Text = "Telefono";
            this.Telefono.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Celular
            // 
            this.Celular.AutoSize = true;
            this.Celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Celular.Location = new System.Drawing.Point(441, 163);
            this.Celular.Name = "Celular";
            this.Celular.Size = new System.Drawing.Size(74, 25);
            this.Celular.TabIndex = 16;
            this.Celular.Text = "Celular";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(587, 134);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefono.TabIndex = 17;
            // 
            // textBoxCelular
            // 
            this.textBoxCelular.Location = new System.Drawing.Point(587, 163);
            this.textBoxCelular.Name = "textBoxCelular";
            this.textBoxCelular.Size = new System.Drawing.Size(100, 20);
            this.textBoxCelular.TabIndex = 18;
            // 
            // dtgvAgenda
            // 
            this.dtgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TxtNombre,
            this.TxtApellido,
            this.TxtEdad,
            this.TxtNacimiento,
            this.TxtDireccion,
            this.TxtPais,
            this.TxtProvincia,
            this.TxtTelefono,
            this.TxtCelular});
            this.dtgvAgenda.Location = new System.Drawing.Point(6, 12);
            this.dtgvAgenda.Name = "dtgvAgenda";
            this.dtgvAgenda.Size = new System.Drawing.Size(823, 202);
            this.dtgvAgenda.TabIndex = 0;
            this.dtgvAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAgenda_CellClick);
            // 
            // TxtNombre
            // 
            this.TxtNombre.HeaderText = "Nombre";
            this.TxtNombre.Name = "TxtNombre";
            // 
            // TxtApellido
            // 
            this.TxtApellido.HeaderText = "Apellido";
            this.TxtApellido.Name = "TxtApellido";
            // 
            // TxtEdad
            // 
            this.TxtEdad.HeaderText = "Edad";
            this.TxtEdad.Name = "TxtEdad";
            // 
            // TxtNacimiento
            // 
            this.TxtNacimiento.HeaderText = "Fecha de Nacimiento";
            this.TxtNacimiento.Name = "TxtNacimiento";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.HeaderText = "Direccion";
            this.TxtDireccion.Name = "TxtDireccion";
            // 
            // TxtPais
            // 
            this.TxtPais.HeaderText = "Pais";
            this.TxtPais.Name = "TxtPais";
            // 
            // TxtProvincia
            // 
            this.TxtProvincia.HeaderText = "Provincia";
            this.TxtProvincia.Name = "TxtProvincia";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.HeaderText = "Telefono";
            this.TxtTelefono.Name = "TxtTelefono";
            // 
            // TxtCelular
            // 
            this.TxtCelular.HeaderText = "Celular";
            this.TxtCelular.Name = "TxtCelular";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(286, 243);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 31);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(446, 243);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 31);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Location = new System.Drawing.Point(64, 260);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(0, 13);
            this.lblInformacion.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 539);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAgenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProvincia;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNacimiento;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label Provincia;
        private System.Windows.Forms.Label Pais;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label Nacimiento;
        private System.Windows.Forms.Label Edad;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Celular;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.TextBox textBoxCelular;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtgvAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtCelular;
        private System.Windows.Forms.Label lblInformacion;
    }
}

