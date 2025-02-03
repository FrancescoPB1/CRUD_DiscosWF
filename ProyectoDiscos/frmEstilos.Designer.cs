namespace ProyectoDiscos
{
    partial class frmEstilos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstilos));
            this.gbxListaEstilos = new System.Windows.Forms.GroupBox();
            this.dgvEstilos = new System.Windows.Forms.DataGridView();
            this.gbxEstilo = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.gbxListaEstilos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstilos)).BeginInit();
            this.gbxEstilo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxListaEstilos
            // 
            this.gbxListaEstilos.Controls.Add(this.dgvEstilos);
            this.gbxListaEstilos.Location = new System.Drawing.Point(1294, 222);
            this.gbxListaEstilos.Name = "gbxListaEstilos";
            this.gbxListaEstilos.Size = new System.Drawing.Size(490, 864);
            this.gbxListaEstilos.TabIndex = 4;
            this.gbxListaEstilos.TabStop = false;
            this.gbxListaEstilos.Text = "Lista de Estilos";
            // 
            // dgvEstilos
            // 
            this.dgvEstilos.AllowUserToResizeColumns = false;
            this.dgvEstilos.AllowUserToResizeRows = false;
            this.dgvEstilos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEstilos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstilos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEstilos.Location = new System.Drawing.Point(122, 135);
            this.dgvEstilos.MultiSelect = false;
            this.dgvEstilos.Name = "dgvEstilos";
            this.dgvEstilos.RowHeadersWidth = 102;
            this.dgvEstilos.RowTemplate.Height = 40;
            this.dgvEstilos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstilos.Size = new System.Drawing.Size(271, 679);
            this.dgvEstilos.TabIndex = 0;
            this.dgvEstilos.SelectionChanged += new System.EventHandler(this.dgvEstilos_SelectionChanged);
            // 
            // gbxEstilo
            // 
            this.gbxEstilo.Controls.Add(this.btnNuevo);
            this.gbxEstilo.Controls.Add(this.btnEditar);
            this.gbxEstilo.Controls.Add(this.btnEliminar);
            this.gbxEstilo.Controls.Add(this.btnAgregar);
            this.gbxEstilo.Controls.Add(this.txtDescripcion);
            this.gbxEstilo.Controls.Add(this.label2);
            this.gbxEstilo.Location = new System.Drawing.Point(359, 228);
            this.gbxEstilo.Name = "gbxEstilo";
            this.gbxEstilo.Size = new System.Drawing.Size(627, 568);
            this.gbxEstilo.TabIndex = 3;
            this.gbxEstilo.TabStop = false;
            this.gbxEstilo.Text = "Datos de Estilo";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.CadetBlue;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(375, 388);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(164, 80);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(62, 388);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(164, 80);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(375, 225);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(164, 80);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(62, 225);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(164, 80);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(234, 105);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(296, 35);
            this.txtDescripcion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Estilo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helonia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estilos";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1007, 210);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(260, 876);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(2, -2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(2125, 1224);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // frmEstilos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(2123, 1224);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxListaEstilos);
            this.Controls.Add(this.gbxEstilo);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstilos";
            this.Text = "frmEstilos";
            this.Load += new System.EventHandler(this.frmEstilos_Load);
            this.gbxListaEstilos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstilos)).EndInit();
            this.gbxEstilo.ResumeLayout(false);
            this.gbxEstilo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxListaEstilos;
        private System.Windows.Forms.GroupBox gbxEstilo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvEstilos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}