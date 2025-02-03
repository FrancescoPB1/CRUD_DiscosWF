using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDiscos
{
    public partial class frmInicio : Form
    {
        
        public frmInicio()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(Type tipoFormulario)
        {
            
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == tipoFormulario)
                {
                    form.WindowState = FormWindowState.Normal; 
                    form.Activate();  
                    return;
                }
            }
            panelMenu.Visible = false;
            Form nuevoFormulario = (Form)Activator.CreateInstance(tipoFormulario);
            nuevoFormulario.MdiParent = this;
            nuevoFormulario.StartPosition = FormStartPosition.Manual;
            nuevoFormulario.Location = new Point(0, 0);  
            nuevoFormulario.Show();
        }

        private void discosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(frmDiscos));
                        
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            this.Size =new Size(985,1000);
            
        }

        private void estilosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(frmEstilos));

        }
        
        private void edicioónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AbrirFormulario(typeof(frmEdicion));

        }
    }
}
