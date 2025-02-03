namespace ProyectoDiscos
{
    partial class frmEdicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdicion));
            this.gbxListaEdicion = new System.Windows.Forms.GroupBox();
            this.dgvEdicion = new System.Windows.Forms.DataGridView();
            this.gbxEdicion = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbxListaEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdicion)).BeginInit();
            this.gbxEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxListaEdicion
            // 
            this.gbxListaEdicion.Controls.Add(this.dgvEdicion);
            this.gbxListaEdicion.Location = new System.Drawing.Point(1391, 238);
            this.gbxListaEdicion.Name = "gbxListaEdicion";
            this.gbxListaEdicion.Size = new System.Drawing.Size(349, 864);
            this.gbxListaEdicion.TabIndex = 6;
            this.gbxListaEdicion.TabStop = false;
            this.gbxListaEdicion.Text = "Lista de Edición";
            // 
            // dgvEdicion
            // 
            this.dgvEdicion.AllowUserToResizeColumns = false;
            this.dgvEdicion.AllowUserToResizeRows = false;
            this.dgvEdicion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEdicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdicion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEdicion.Location = new System.Drawing.Point(45, 94);
            this.dgvEdicion.MultiSelect = false;
            this.dgvEdicion.Name = "dgvEdicion";
            this.dgvEdicion.RowHeadersWidth = 102;
            this.dgvEdicion.RowTemplate.Height = 40;
            this.dgvEdicion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEdicion.Size = new System.Drawing.Size(265, 679);
            this.dgvEdicion.TabIndex = 0;
            this.dgvEdicion.SelectionChanged += new System.EventHandler(this.dgvEdicion_SelectionChanged);
            // 
            // gbxEdicion
            // 
            this.gbxEdicion.Controls.Add(this.btnNuevo);
            this.gbxEdicion.Controls.Add(this.btnEditar);
            this.gbxEdicion.Controls.Add(this.btnEliminar);
            this.gbxEdicion.Controls.Add(this.btnAgregar);
            this.gbxEdicion.Controls.Add(this.txtDescripcion);
            this.gbxEdicion.Controls.Add(this.label2);
            this.gbxEdicion.Location = new System.Drawing.Point(381, 228);
            this.gbxEdicion.Name = "gbxEdicion";
            this.gbxEdicion.Size = new System.Drawing.Size(627, 568);
            this.gbxEdicion.TabIndex = 5;
            this.gbxEdicion.TabStop = false;
            this.gbxEdicion.Text = "Datos de Edición";
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(375, 388);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(164, 80);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(62, 388);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(164, 80);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(375, 225);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(164, 80);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(62, 225);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(164, 80);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(243, 105);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(296, 35);
            this.txtDescripcion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Edición:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helonia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edición";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(604, 894);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-5, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2223, 1309);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // frmEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(2263, 1389);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxListaEdicion);
            this.Controls.Add(this.gbxEdicion);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEdicion";
            this.Text = "frmEdicion";
            this.Load += new System.EventHandler(this.frmEdicion_Load);
            this.gbxListaEdicion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdicion)).EndInit();
            this.gbxEdicion.ResumeLayout(false);
            this.gbxEdicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxListaEdicion;
        private System.Windows.Forms.GroupBox gbxEdicion;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvEdicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}