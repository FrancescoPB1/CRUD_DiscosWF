namespace ProyectoDiscos
{
    partial class frmInicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.discosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estilosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edicioónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.discosToolStripMenuItem,
            this.estilosToolStripMenuItem,
            this.edicioónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2581, 60);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // discosToolStripMenuItem
            // 
            this.discosToolStripMenuItem.Name = "discosToolStripMenuItem";
            this.discosToolStripMenuItem.Size = new System.Drawing.Size(128, 56);
            this.discosToolStripMenuItem.Text = "Discos";
            this.discosToolStripMenuItem.Click += new System.EventHandler(this.discosToolStripMenuItem_Click);
            // 
            // estilosToolStripMenuItem
            // 
            this.estilosToolStripMenuItem.Name = "estilosToolStripMenuItem";
            this.estilosToolStripMenuItem.Size = new System.Drawing.Size(125, 56);
            this.estilosToolStripMenuItem.Text = "Estilos";
            this.estilosToolStripMenuItem.Click += new System.EventHandler(this.estilosToolStripMenuItem_Click);
            // 
            // edicioónToolStripMenuItem
            // 
            this.edicioónToolStripMenuItem.Name = "edicioónToolStripMenuItem";
            this.edicioónToolStripMenuItem.Size = new System.Drawing.Size(138, 56);
            this.edicioónToolStripMenuItem.Text = "Edición";
            this.edicioónToolStripMenuItem.Click += new System.EventHandler(this.edicioónToolStripMenuItem_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Berlin Sans FB", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(480, 608);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(1557, 94);
            this.lblBienvenida.TabIndex = 2;
            this.lblBienvenida.Text = "BIENVENIDO A NUESTRA DISCOGRAFIA!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1696, 94);
            this.label1.TabIndex = 3;
            this.label1.Text = "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 742);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1696, 94);
            this.label2.TabIndex = 4;
            this.label2.Text = "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.lblBienvenida);
            this.panelMenu.Location = new System.Drawing.Point(-7, 37);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(2645, 1761);
            this.panelMenu.TabIndex = 5;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2581, 1331);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2613, 1547);
            this.MinimizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discografia";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem discosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estilosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edicioónToolStripMenuItem;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMenu;
    }
}

