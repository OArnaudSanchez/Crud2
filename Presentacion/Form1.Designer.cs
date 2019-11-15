namespace Presentacion
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
			this.bGuardar = new System.Windows.Forms.Button();
			this.tNombre = new System.Windows.Forms.TextBox();
			this.tApellido = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tDireccion = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tCiudad = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.bEliminar = new System.Windows.Forms.Button();
			this.bModificar = new System.Windows.Forms.Button();
			this.bCancelar = new System.Windows.Forms.Button();
			this.datos = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.datos)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(49, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// bGuardar
			// 
			this.bGuardar.Location = new System.Drawing.Point(64, 223);
			this.bGuardar.Name = "bGuardar";
			this.bGuardar.Size = new System.Drawing.Size(75, 39);
			this.bGuardar.TabIndex = 1;
			this.bGuardar.Text = "Guardar";
			this.bGuardar.UseVisualStyleBackColor = true;
			this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
			// 
			// tNombre
			// 
			this.tNombre.Location = new System.Drawing.Point(109, 54);
			this.tNombre.Name = "tNombre";
			this.tNombre.Size = new System.Drawing.Size(214, 20);
			this.tNombre.TabIndex = 2;
			// 
			// tApellido
			// 
			this.tApellido.Location = new System.Drawing.Point(109, 80);
			this.tApellido.Name = "tApellido";
			this.tApellido.Size = new System.Drawing.Size(214, 20);
			this.tApellido.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(49, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Apellido";
			// 
			// tDireccion
			// 
			this.tDireccion.Location = new System.Drawing.Point(109, 159);
			this.tDireccion.Name = "tDireccion";
			this.tDireccion.Size = new System.Drawing.Size(214, 20);
			this.tDireccion.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(49, 159);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Direccion";
			// 
			// tCiudad
			// 
			this.tCiudad.Location = new System.Drawing.Point(109, 106);
			this.tCiudad.Name = "tCiudad";
			this.tCiudad.Size = new System.Drawing.Size(214, 20);
			this.tCiudad.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(49, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Ciudad";
			// 
			// bEliminar
			// 
			this.bEliminar.Location = new System.Drawing.Point(266, 223);
			this.bEliminar.Name = "bEliminar";
			this.bEliminar.Size = new System.Drawing.Size(75, 39);
			this.bEliminar.TabIndex = 10;
			this.bEliminar.Text = "Eliminar";
			this.bEliminar.UseVisualStyleBackColor = true;
			this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
			// 
			// bModificar
			// 
			this.bModificar.Location = new System.Drawing.Point(162, 223);
			this.bModificar.Name = "bModificar";
			this.bModificar.Size = new System.Drawing.Size(75, 39);
			this.bModificar.TabIndex = 11;
			this.bModificar.Text = "MOdificar";
			this.bModificar.UseVisualStyleBackColor = true;
			this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
			// 
			// bCancelar
			// 
			this.bCancelar.Location = new System.Drawing.Point(162, 293);
			this.bCancelar.Name = "bCancelar";
			this.bCancelar.Size = new System.Drawing.Size(75, 39);
			this.bCancelar.TabIndex = 12;
			this.bCancelar.Text = "Cancelar";
			this.bCancelar.UseVisualStyleBackColor = true;
			this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
			// 
			// datos
			// 
			this.datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.Ciudad,
            this.Direccion});
			this.datos.Location = new System.Drawing.Point(376, 54);
			this.datos.Name = "datos";
			this.datos.Size = new System.Drawing.Size(573, 249);
			this.datos.TabIndex = 13;
			this.datos.DoubleClick += new System.EventHandler(this.datos_DoubleClick);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			// 
			// Nombre
			// 
			this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Nombre.DataPropertyName = "Nombre";
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			// 
			// Apellido
			// 
			this.Apellido.DataPropertyName = "Apellido";
			this.Apellido.HeaderText = "Apellido";
			this.Apellido.Name = "Apellido";
			// 
			// Ciudad
			// 
			this.Ciudad.DataPropertyName = "Ciudad";
			this.Ciudad.HeaderText = "Ciudad";
			this.Ciudad.Name = "Ciudad";
			// 
			// Direccion
			// 
			this.Direccion.DataPropertyName = "Direccion";
			this.Direccion.HeaderText = "Direccion";
			this.Direccion.Name = "Direccion";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(961, 354);
			this.Controls.Add(this.datos);
			this.Controls.Add(this.bCancelar);
			this.Controls.Add(this.bModificar);
			this.Controls.Add(this.bEliminar);
			this.Controls.Add(this.tDireccion);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tCiudad);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tApellido);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tNombre);
			this.Controls.Add(this.bGuardar);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "ENtity";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button bGuardar;
		private System.Windows.Forms.TextBox tNombre;
		private System.Windows.Forms.TextBox tApellido;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tDireccion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tCiudad;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button bEliminar;
		private System.Windows.Forms.Button bModificar;
		private System.Windows.Forms.Button bCancelar;
		private System.Windows.Forms.DataGridView datos;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
	}
}

