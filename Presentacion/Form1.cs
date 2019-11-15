using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Presentacion
{
	public partial class Form1 : Form
	{
		Cliente modelo = new Cliente();
		public Form1()
		{
			InitializeComponent();
		}

		void clear() {
			tNombre.Clear();
			tApellido.Clear();
			tCiudad.Clear();
			tDireccion.Clear();
			bEliminar.Enabled = false;
			bModificar.Enabled = false;
			modelo.ID = 0;
		}

		private void bCancelar_Click(object sender, EventArgs e)
		{
			clear();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			clear();
			dataGrid();
		}

		private void bGuardar_Click(object sender, EventArgs e)
		{
			modelo.Nombre = tNombre.Text.Trim();
			modelo.Apellido = tApellido.Text.Trim();
			modelo.Ciudad = tCiudad.Text.Trim();
			modelo.Direccion = tDireccion.Text.Trim();
			DBEntities db = new DBEntities();

			if (modelo.ID == 0)
			{
				db.Clientes.Add(modelo);
			}
			else {
				db.Entry(modelo).State = EntityState.Modified;
			}
			
			db.SaveChanges();
			clear();
			dataGrid();
			MessageBox.Show("Guardado Correctamente");
		}

		void dataGrid() {

			datos.AutoGenerateColumns = false;

			DBEntities db = new DBEntities();
			datos.DataSource = db.Clientes.ToList<Cliente>();
		}

		private void datos_DoubleClick(object sender, EventArgs e)
		{
			if (datos.CurrentRow.Index != -1) {
				modelo.ID = Convert.ToInt32(datos.CurrentRow.Cells["ID"].Value);
				DBEntities db = new DBEntities();

				modelo = db.Clientes.Where(x => x.ID == modelo.ID).FirstOrDefault();
				tNombre.Text = modelo.Nombre;
				tApellido.Text = modelo.Apellido;
				tCiudad.Text = modelo.Ciudad;
				tDireccion.Text = modelo.Direccion;

				
				bEliminar.Enabled = true;
				bModificar.Enabled = true;
			}
		}

		private void bEliminar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Desea Borrar este registro","OPcion Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes) {
				DBEntities db = new DBEntities();
				var opcion = db.Entry(modelo);

				if (opcion.State == EntityState.Detached) {
					db.Clientes.Attach(modelo);
					db.Clientes.Remove(modelo);
					db.SaveChanges();
					dataGrid();
					clear();
					MessageBox.Show("Eliminado Correctamente");
				}
			}
		}

		private void bModificar_Click(object sender, EventArgs e)
		{
			modelo.Nombre = tNombre.Text.Trim();
			modelo.Apellido = tApellido.Text.Trim();
			modelo.Ciudad = tCiudad.Text.Trim();
			modelo.Direccion = tDireccion.Text.Trim();
			DBEntities db = new DBEntities();

			if (modelo.ID != 0)
			{
				db.Entry(modelo).State = EntityState.Modified;
			}
			else
			{
				MessageBox.Show("No se puede actualizar");
			}

			db.SaveChanges();
			clear();
			dataGrid();
			MessageBox.Show("Modificado Correctamente");
		}
	}
}
