using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
namespace ProyectoDiscos
{
    public partial class frmEdicion : Form
    {
        private TiposEdicion edicion = null;
        private EdicionNegocio negocio=new EdicionNegocio();
        public frmEdicion()
        {
            InitializeComponent();
        }
        
        private void frmEdicion_Load(object sender, EventArgs e)
        {
            
            this.Size = new Size(960, 600);
            EdicionNegocio edicionNegocio = new EdicionNegocio();
            dgvEdicion.DataSource = edicionNegocio.listarEdicion();
            
            dgvEdicion.Columns["Id"].Visible = false;
            dgvEdicion.Rows[0].Selected = false;
            dgvEdicion.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEdicion.RowHeadersVisible = false;

            // Verificar que haya filas antes de seleccionar
            //if (dgvEdicion.Rows.Count > 0)
            //{
            //    dgvEdicion.Rows[0].Selected = true;

            //}
            dgvEdicion.ClearSelection();
            dgvEdicion.CurrentCell = null;
        }
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                
                edicion = new TiposEdicion();
                edicion.Descripcion=txtDescripcion.Text;
                negocio.agregar(edicion);
                MessageBox.Show("Edición agregado correctamente", "Guardado",MessageBoxButtons.OK);
                dgvEdicion.DataSource = negocio.listarEdicion();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()) ;
            }
            
        }

        private void dgvEdicion_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgvEdicion.CurrentRow != null && dgvEdicion.CurrentRow.DataBoundItem != null)
            {
                edicion = (TiposEdicion)dgvEdicion.CurrentRow.DataBoundItem;
                txtDescripcion.Text = edicion.Descripcion;
                btnAgregar.Enabled=false;
                btnEditar.Enabled=true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            
            dgvEdicion.ClearSelection();
            txtDescripcion.Text = "";
            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text==edicion.Descripcion)
            {
                MessageBox.Show($"No se puede editar porque la edición '{edicion.Descripcion}' no ha sufrido cambios...","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                return;
            }
            try
            {
                DialogResult respuesta = MessageBox.Show($"Deseas editar la edición {edicion.Descripcion}?","Editar",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (respuesta==DialogResult.Yes)
                {
                    edicion.Descripcion = txtDescripcion.Text;
                    negocio.editar(edicion);
                    MessageBox.Show("Se ha editado correctamente!");
                    dgvEdicion.DataSource = negocio.listarEdicion();
                }
                else
                {
                    txtDescripcion.Text=edicion.Descripcion;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta = MessageBox.Show($"Esta seguro de eliminar '{edicion.Descripcion}'?","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (respuesta==DialogResult.Yes)
                {
                    negocio.eliminar(edicion);
                    MessageBox.Show("Eliminado correctamente!");
                    txtDescripcion.Text = "";
                    dgvEdicion.DataSource=negocio.listarEdicion();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
