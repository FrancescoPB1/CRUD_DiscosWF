using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using Dominio;
using Negocio;
using ConexionDB;
using System.Runtime.CompilerServices;
namespace ProyectoDiscos
{
    public partial class frmDiscos : Form
    {
        private Disco discoFrm=null;
        public frmDiscos()
        {
            InitializeComponent();
        }
        private List<Disco> discoList;
        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiscos.CurrentRow != null && dgvDiscos.CurrentRow.DataBoundItem != null)
            {
                Disco seleccion = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                //pbxImagenDisco.Image = Image.FromFile(txtUrl.Text);
                
                cargarImagen(seleccion.UrlImagenTapa,pbxImagenDisco);
                txtTitulo.Text = seleccion.Titulo;
                dtpFechaLanzamiento.Text=seleccion.FechaLanzamiento.ToString();
                nudCantidadCanciones.Value=seleccion.CantidadCanciones;
                txtUrl.Text = seleccion.UrlImagenTapa;
                cboEstilo.SelectedValue = seleccion.Estilo.Id;
                cboEdicion.SelectedValue = seleccion.Edicion.Id;
                
                discoFrm = seleccion;
                btnEditar.Enabled = true;

                btnAgregar.Visible = false;

            }
        }
        
        private void cargarImagen(string imagen,PictureBox pbx)
        {
            try
            {
                pbx.Load(imagen);
            }
            catch (Exception ex)
            {
                pbx.Load("https://i.pinimg.com/736x/c6/5f/3d/c65f3d20cd2f134daca21323a5da134b.jpg");
            }
        }
        public void cargar()
        {
            try
            {
                Disco imagenDisco = new Disco();
                string urlImagen;
                DiscoNegocio discoNegocio = new DiscoNegocio();
                discoList = discoNegocio.listarDiscos();
                dgvDiscos.DataSource = discoList;
                ocultarColumnas();
                dgvDiscos.AutoResizeColumns();
                
                dgvDiscos.RowHeadersWidth = 30;
                urlImagen = imagenDisco.UrlImagenTapa;
                //cargarImagen(urlImagen, pbxImagenDisco);
                
            }
            catch (Exception es)
            {

                throw es;
            }
        }
        private void ocultarColumnas()
        {
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
            dgvDiscos.Columns["Id"].Visible = false;
        }
        private void frmDiscos_Load(object sender, EventArgs e)
        {

            this.Size = new Size(960,600);

            cargar();
            dgvDiscos.RowHeadersVisible = false;
            actualizarCmb();
            //permite ajustar el dgv con el formulario
            this.dgvDiscos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        private void actualizarCmb()
        {
            EstiloNegocio estiloNegocio = new EstiloNegocio();
            EdicionNegocio edicionNegocio = new EdicionNegocio();
            cboEdicion.DataSource = edicionNegocio.listarEdicion();
            cboEstilo.DataSource = estiloNegocio.listar();
            // Configurar el DataSource y las propiedades DisplayMember y ValueMember
            cboEstilo.DataSource = estiloNegocio.listar();
            cboEstilo.DisplayMember = "Descripcion"; // Lo que se muestra al usuario
            cboEstilo.ValueMember = "Id";            // El valor interno que se usará

            cboEdicion.DataSource = edicionNegocio.listarEdicion();
            cboEdicion.DisplayMember = "Descripcion"; // Lo que se muestra al usuario
            cboEdicion.ValueMember = "Id";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Disco disco = new Disco();
            DiscoNegocio discoNegocio= new DiscoNegocio();
            try
            {
                if (txtTitulo.Text==""||txtUrl.Text==""||nudCantidadCanciones.Value==0
                    ||dtpFechaLanzamiento.Value==null||cboEdicion.SelectedItem==null||cboEstilo.SelectedItem==null)
                {
                    MessageBox.Show("Debes ingresar todos los campos del Disco!");
                    return;
                }
                cargaComponentesFrmDisco(disco);
                discoNegocio.agregar(disco);
                cargar();
                MessageBox.Show("Disco agregado exitosamente!");
                limpiezaComponentesDisco();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }
        private void cargaComponentesFrmDisco(Disco disco)
        {
            disco.Titulo = txtTitulo.Text;
            disco.FechaLanzamiento = DateTime.Parse(dtpFechaLanzamiento.Text);
            disco.CantidadCanciones = (int)nudCantidadCanciones.Value;
            disco.UrlImagenTapa = txtUrl.Text;
            disco.Estilo = (Estilo)cboEstilo.SelectedItem;
            disco.Edicion = (TiposEdicion)cboEdicion.SelectedItem;
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(txtUrl.Text,pbxImagenDatos);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiezaComponentesDisco();
            btnAgregar.Visible = true;
            
        }
        private void limpiezaComponentesDisco()
        {
            dgvDiscos.ClearSelection();
            txtTitulo.Text = "";
            dtpFechaLanzamiento.Text = "";
            nudCantidadCanciones.Value = 0;
            txtUrl.Text = "";
            cboEstilo.SelectedIndex = 0;
            cboEdicion.SelectedIndex = 0;
            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
            cboEdicion.SelectedItem = null;
            cboEstilo.SelectedItem = null;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            cargaComponentesFrmDisco(discoFrm);
            negocio.modificar(discoFrm);
            cargar();
            cargarImagen(txtUrl.Text,pbxImagenDisco);
            MessageBox.Show("Disco editado correctamente!");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DiscoNegocio discoNegocio = new DiscoNegocio();
            Disco disc;
            try
            {
                DialogResult respuesta = MessageBox.Show("Deseas eliminarlo?","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    disc = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                    discoNegocio.eliminar(disc.Id);
                    cargar();
                }
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvDiscos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDiscos_Activated(object sender, EventArgs e)
        {
            cargar();
            actualizarCmb();
        }
    }
}
