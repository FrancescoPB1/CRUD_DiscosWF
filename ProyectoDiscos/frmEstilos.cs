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
using ConexionDB;
namespace ProyectoDiscos
{
    public partial class frmEstilos : Form
    {
        private Estilo estilo = null;

        public frmEstilos()
        {
            InitializeComponent();

        }

        private void frmEstilos_Load(object sender, EventArgs e)
        {
            this.Size = new Size(960, 600);
            this.Location = new Point(0,0);
            dgvEstilos.RowHeadersWidth = 30;
            EstiloNegocio estilo = new EstiloNegocio();
            dgvEstilos.DataSource = estilo.listar();
            dgvEstilos.Columns["Id"].Visible = false;
            this.dgvEstilos.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEstilos.AutoResizeColumns();
            dgvEstilos.RowHeadersVisible = false;


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EstiloNegocio estiloNegocio = new EstiloNegocio();
            estilo=new Estilo();
            estilo.Descripcion=txtDescripcion.Text;
            estiloNegocio.agregar(estilo);
            MessageBox.Show("Nuevo elemento agregado!");
            txtDescripcion.Text = "";
            dgvEstilos.DataSource=estiloNegocio.listar();
        }

        private void dgvEstilos_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgvEstilos.CurrentRow != null && dgvEstilos.CurrentRow.DataBoundItem != null)
            {
                btnAgregar.Enabled = false;
                btnEditar.Enabled = true;
                estilo = (Estilo)dgvEstilos.CurrentRow.DataBoundItem;
                txtDescripcion.Text = estilo.Descripcion;
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvEstilos.ClearSelection();
            btnAgregar.Enabled=true;
            btnEditar.Enabled=false;
            txtDescripcion.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (estilo.Descripcion==txtDescripcion.Text)
            {
                MessageBox.Show("No se puede editar porque el estilo es el mismo");
                return;
            }
            EstiloNegocio estiloNegocio=new EstiloNegocio();
            
            DialogResult resultado = MessageBox.Show($"Estas seguro de editar '{estilo.Descripcion}'?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    estilo.Descripcion = txtDescripcion.Text;
                    estiloNegocio.editar(estilo);
                    MessageBox.Show("Estilo editado correctamente!");
                    txtDescripcion.Text = "";
                    frmEstilos_Load(sender, e);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString()) ;
                }
                
            }
            else
            {
                txtDescripcion.Text=estilo.Descripcion;
            }
            
            
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EstiloNegocio estiloNegocio =new EstiloNegocio();

            if (estiloNegocio.existeEstiloEnDisco(estilo)==true)
            {
                MessageBox.Show("Existe ya un disco vinculado a este estilo!\n" +
                    "Tiene que eliminar los discos que esten vinculados a este estilo...","Error");
                return;
            }
            estiloNegocio.eliminar(estilo);
            MessageBox.Show("Elemento eliminado correctamente!");
            txtDescripcion.Text = "";
            frmEstilos_Load(sender,e);

        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            
        }
    }
}
