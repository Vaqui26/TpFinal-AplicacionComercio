
namespace TPFinal
{
    partial class fmPrincipal
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
            this.lblFiltroRapido = new System.Windows.Forms.Label();
            this.txtFiltrarRapido = new System.Windows.Forms.TextBox();
            this.dvgArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltroBDD = new System.Windows.Forms.Label();
            this.txtFiltroBDD = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblTextoFiltro = new System.Windows.Forms.Label();
            this.cboFiltroMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.btnFiltrarCampos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltroRapido
            // 
            this.lblFiltroRapido.AutoSize = true;
            this.lblFiltroRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroRapido.Location = new System.Drawing.Point(11, 23);
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            this.lblFiltroRapido.Size = new System.Drawing.Size(44, 15);
            this.lblFiltroRapido.TabIndex = 0;
            this.lblFiltroRapido.Text = "Filtrar :";
            // 
            // txtFiltrarRapido
            // 
            this.txtFiltrarRapido.BackColor = System.Drawing.Color.Azure;
            this.txtFiltrarRapido.Location = new System.Drawing.Point(70, 22);
            this.txtFiltrarRapido.Name = "txtFiltrarRapido";
            this.txtFiltrarRapido.Size = new System.Drawing.Size(172, 20);
            this.txtFiltrarRapido.TabIndex = 0;
            this.txtFiltrarRapido.TextChanged += new System.EventHandler(this.txtFiltrarRapido_TextChanged);
            // 
            // dvgArticulos
            // 
            this.dvgArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dvgArticulos.BackgroundColor = System.Drawing.Color.MintCream;
            this.dvgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgArticulos.Location = new System.Drawing.Point(29, 59);
            this.dvgArticulos.MultiSelect = false;
            this.dvgArticulos.Name = "dvgArticulos";
            this.dvgArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgArticulos.Size = new System.Drawing.Size(444, 281);
            this.dvgArticulos.TabIndex = 2;
            this.dvgArticulos.SelectionChanged += new System.EventHandler(this.dvgArticulos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.Color.Honeydew;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(29, 357);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Location = new System.Drawing.Point(123, 357);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(213, 357);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArticulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxArticulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbxArticulo.Location = new System.Drawing.Point(492, 59);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(254, 205);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 6;
            this.pbxArticulo.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.BackColor = System.Drawing.Color.Azure;
            this.txtDescripcion.Location = new System.Drawing.Point(492, 270);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(214, 127);
            this.txtDescripcion.TabIndex = 11;
            // 
            // lblCampo
            // 
            this.lblCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCampo.Location = new System.Drawing.Point(10, 435);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(58, 16);
            this.lblCampo.TabIndex = 8;
            this.lblCampo.Text = "Campo :";
            // 
            // cboCampo
            // 
            this.cboCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboCampo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(70, 433);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(86, 21);
            this.cboCampo.TabIndex = 7;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboCriterio.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(225, 433);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(86, 21);
            this.cboCriterio.TabIndex = 8;
            // 
            // lblCriterio
            // 
            this.lblCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCriterio.Location = new System.Drawing.Point(162, 435);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(59, 16);
            this.lblCriterio.TabIndex = 10;
            this.lblCriterio.Text = "Criterio : ";
            // 
            // lblFiltroBDD
            // 
            this.lblFiltroBDD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFiltroBDD.AutoSize = true;
            this.lblFiltroBDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblFiltroBDD.Location = new System.Drawing.Point(322, 435);
            this.lblFiltroBDD.Name = "lblFiltroBDD";
            this.lblFiltroBDD.Size = new System.Drawing.Size(43, 16);
            this.lblFiltroBDD.TabIndex = 12;
            this.lblFiltroBDD.Text = "Filtro :";
            // 
            // txtFiltroBDD
            // 
            this.txtFiltroBDD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFiltroBDD.BackColor = System.Drawing.Color.Azure;
            this.txtFiltroBDD.Location = new System.Drawing.Point(371, 434);
            this.txtFiltroBDD.Name = "txtFiltroBDD";
            this.txtFiltroBDD.Size = new System.Drawing.Size(113, 20);
            this.txtFiltroBDD.TabIndex = 9;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFiltrar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btnFiltrar.FlatAppearance.BorderSize = 2;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar.Location = new System.Drawing.Point(503, 433);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 10;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblTextoFiltro
            // 
            this.lblTextoFiltro.AutoSize = true;
            this.lblTextoFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblTextoFiltro.Location = new System.Drawing.Point(248, 25);
            this.lblTextoFiltro.Name = "lblTextoFiltro";
            this.lblTextoFiltro.Size = new System.Drawing.Size(143, 16);
            this.lblTextoFiltro.TabIndex = 15;
            this.lblTextoFiltro.Text = "= (Filtrado por nombre)";
            // 
            // cboFiltroMarca
            // 
            this.cboFiltroMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboFiltroMarca.BackColor = System.Drawing.Color.LightYellow;
            this.cboFiltroMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroMarca.FormattingEnabled = true;
            this.cboFiltroMarca.Location = new System.Drawing.Point(70, 400);
            this.cboFiltroMarca.Name = "cboFiltroMarca";
            this.cboFiltroMarca.Size = new System.Drawing.Size(101, 21);
            this.cboFiltroMarca.TabIndex = 4;
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblMarca.Location = new System.Drawing.Point(16, 399);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(52, 16);
            this.lblMarca.TabIndex = 17;
            this.lblMarca.Text = "Marca :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(177, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Categoria :";
            // 
            // cboFiltroCategoria
            // 
            this.cboFiltroCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboFiltroCategoria.BackColor = System.Drawing.Color.LightYellow;
            this.cboFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroCategoria.FormattingEnabled = true;
            this.cboFiltroCategoria.Location = new System.Drawing.Point(251, 399);
            this.cboFiltroCategoria.Name = "cboFiltroCategoria";
            this.cboFiltroCategoria.Size = new System.Drawing.Size(104, 21);
            this.cboFiltroCategoria.TabIndex = 5;
            // 
            // btnFiltrarCampos
            // 
            this.btnFiltrarCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFiltrarCampos.BackColor = System.Drawing.Color.LightYellow;
            this.btnFiltrarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrarCampos.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnFiltrarCampos.FlatAppearance.BorderSize = 2;
            this.btnFiltrarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrarCampos.Location = new System.Drawing.Point(383, 397);
            this.btnFiltrarCampos.Name = "btnFiltrarCampos";
            this.btnFiltrarCampos.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrarCampos.TabIndex = 6;
            this.btnFiltrarCampos.Text = "Filtrar";
            this.btnFiltrarCampos.UseVisualStyleBackColor = false;
            this.btnFiltrarCampos.Click += new System.EventHandler(this.btnFiltrarCampos_Click);
            // 
            // fmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(754, 466);
            this.Controls.Add(this.btnFiltrarCampos);
            this.Controls.Add(this.cboFiltroCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cboFiltroMarca);
            this.Controls.Add(this.lblTextoFiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtFiltroBDD);
            this.Controls.Add(this.lblFiltroBDD);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dvgArticulos);
            this.Controls.Add(this.txtFiltrarRapido);
            this.Controls.Add(this.lblFiltroRapido);
            this.MaximumSize = new System.Drawing.Size(857, 562);
            this.MinimumSize = new System.Drawing.Size(770, 480);
            this.Name = "fmPrincipal";
            this.Text = "Gestion de Articulos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.fmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltroRapido;
        private System.Windows.Forms.TextBox txtFiltrarRapido;
        private System.Windows.Forms.DataGridView dvgArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltroBDD;
        private System.Windows.Forms.TextBox txtFiltroBDD;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblTextoFiltro;
        private System.Windows.Forms.ComboBox cboFiltroMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFiltroCategoria;
        private System.Windows.Forms.Button btnFiltrarCampos;
    }
}

