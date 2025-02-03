namespace ProyectoDiscos
{
    partial class frmDiscos
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
            this.gbxDisco = new System.Windows.Forms.GroupBox();
            this.pbxImagenDatos = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboEdicion = new System.Windows.Forms.ComboBox();
            this.cboEstilo = new System.Windows.Forms.ComboBox();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.nudCantidadCanciones = new System.Windows.Forms.NumericUpDown();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxListaDiscos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDiscos = new System.Windows.Forms.DataGridView();
            this.pbxImagenDisco = new System.Windows.Forms.PictureBox();
            this.gbxDisco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadCanciones)).BeginInit();
            this.gbxListaDiscos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDisco
            // 
            this.gbxDisco.Controls.Add(this.pbxImagenDatos);
            this.gbxDisco.Controls.Add(this.pictureBox1);
            this.gbxDisco.Controls.Add(this.cboEdicion);
            this.gbxDisco.Controls.Add(this.cboEstilo);
            this.gbxDisco.Controls.Add(this.dtpFechaLanzamiento);
            this.gbxDisco.Controls.Add(this.btnNuevo);
            this.gbxDisco.Controls.Add(this.btnEditar);
            this.gbxDisco.Controls.Add(this.btnEliminar);
            this.gbxDisco.Controls.Add(this.btnAgregar);
            this.gbxDisco.Controls.Add(this.txtUrl);
            this.gbxDisco.Controls.Add(this.nudCantidadCanciones);
            this.gbxDisco.Controls.Add(this.txtTitulo);
            this.gbxDisco.Controls.Add(this.label7);
            this.gbxDisco.Controls.Add(this.label6);
            this.gbxDisco.Controls.Add(this.label5);
            this.gbxDisco.Controls.Add(this.label4);
            this.gbxDisco.Controls.Add(this.label3);
            this.gbxDisco.Controls.Add(this.label2);
            this.gbxDisco.Location = new System.Drawing.Point(239, 85);
            this.gbxDisco.Name = "gbxDisco";
            this.gbxDisco.Size = new System.Drawing.Size(1872, 467);
            this.gbxDisco.TabIndex = 1;
            this.gbxDisco.TabStop = false;
            this.gbxDisco.Text = "Datos del Disco";
            // 
            // pbxImagenDatos
            // 
            this.pbxImagenDatos.Location = new System.Drawing.Point(1293, 58);
            this.pbxImagenDatos.Name = "pbxImagenDatos";
            this.pbxImagenDatos.Size = new System.Drawing.Size(546, 379);
            this.pbxImagenDatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenDatos.TabIndex = 19;
            this.pbxImagenDatos.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 47);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // cboEdicion
            // 
            this.cboEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEdicion.FormattingEnabled = true;
            this.cboEdicion.Location = new System.Drawing.Point(601, 224);
            this.cboEdicion.Name = "cboEdicion";
            this.cboEdicion.Size = new System.Drawing.Size(350, 37);
            this.cboEdicion.TabIndex = 5;
            // 
            // cboEstilo
            // 
            this.cboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(134, 225);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(296, 37);
            this.cboEstilo.TabIndex = 4;
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(732, 76);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(473, 35);
            this.dtpFechaLanzamiento.TabIndex = 1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(703, 325);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(164, 80);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(243, 325);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(164, 80);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(468, 325);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(164, 80);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(38, 325);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(164, 80);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(601, 153);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(604, 35);
            this.txtUrl.TabIndex = 3;
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            // 
            // nudCantidadCanciones
            // 
            this.nudCantidadCanciones.Location = new System.Drawing.Point(342, 154);
            this.nudCantidadCanciones.Name = "nudCantidadCanciones";
            this.nudCantidadCanciones.Size = new System.Drawing.Size(88, 35);
            this.nudCantidadCanciones.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(134, 76);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(296, 35);
            this.txtTitulo.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "Edicion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Estilo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Url imagen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cantidad de canciones:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha de lanzamiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Titulo:";
            // 
            // gbxListaDiscos
            // 
            this.gbxListaDiscos.Controls.Add(this.label1);
            this.gbxListaDiscos.Controls.Add(this.dgvDiscos);
            this.gbxListaDiscos.Location = new System.Drawing.Point(239, 557);
            this.gbxListaDiscos.Name = "gbxListaDiscos";
            this.gbxListaDiscos.Size = new System.Drawing.Size(1177, 664);
            this.gbxListaDiscos.TabIndex = 2;
            this.gbxListaDiscos.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Discos";
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDiscos.Location = new System.Drawing.Point(24, 65);
            this.dgvDiscos.MultiSelect = false;
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.RowHeadersWidth = 102;
            this.dgvDiscos.RowTemplate.Height = 40;
            this.dgvDiscos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscos.Size = new System.Drawing.Size(1089, 577);
            this.dgvDiscos.TabIndex = 0;
            this.dgvDiscos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiscos_CellContentClick);
            this.dgvDiscos.SelectionChanged += new System.EventHandler(this.dgvDiscos_SelectionChanged);
            // 
            // pbxImagenDisco
            // 
            this.pbxImagenDisco.Location = new System.Drawing.Point(1499, 611);
            this.pbxImagenDisco.Name = "pbxImagenDisco";
            this.pbxImagenDisco.Size = new System.Drawing.Size(556, 588);
            this.pbxImagenDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenDisco.TabIndex = 3;
            this.pbxImagenDisco.TabStop = false;
            // 
            // frmDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2218, 1251);
            this.Controls.Add(this.pbxImagenDisco);
            this.Controls.Add(this.gbxListaDiscos);
            this.Controls.Add(this.gbxDisco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 748);
            this.Name = "frmDiscos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmDiscos";
            this.Activated += new System.EventHandler(this.frmDiscos_Activated);
            this.Load += new System.EventHandler(this.frmDiscos_Load);
            this.gbxDisco.ResumeLayout(false);
            this.gbxDisco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadCanciones)).EndInit();
            this.gbxListaDiscos.ResumeLayout(false);
            this.gbxListaDiscos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenDisco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxDisco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.NumericUpDown nudCantidadCanciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbxListaDiscos;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.PictureBox pbxImagenDisco;
        private System.Windows.Forms.ComboBox cboEdicion;
        private System.Windows.Forms.ComboBox cboEstilo;
        private System.Windows.Forms.PictureBox pbxImagenDatos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvDiscos;
    }
}