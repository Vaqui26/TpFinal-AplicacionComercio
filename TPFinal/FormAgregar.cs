using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NegocioBDD;
using Objetos;

namespace TPFinal
{
    public partial class FormAgregar : Form
    {
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            cargarComboBoxs();
        }
        private void cargarComboBoxs()
        {   
            // Prop : carga los comboBox de la ventana Agregar,y muestra por defecto items a seleccionar. 
            NegocioCategoria categorias = new NegocioCategoria();
            NegocioMarca marcas = new NegocioMarca();

            try
            {
                cboMarca.DataSource = marcas.listarMarca();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categorias.listarCategoria();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                cboMarca.SelectedValue = "Id";
                cboCategoria.SelectedValue = "Id";
                cboMarca.SelectedItem = cboMarca.Items[0];
                cboCategoria.SelectedItem = cboCategoria.Items[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {   //Prop : chequea de que todos los campos esten llenados para poder agregar un nuevo articulo.
            //En caso que no esten llenos algunos los pintara de rojo hasta que no sean completados.
            bool bandera = true;
            string Codigo = txtCodigo.Text;
            string Nombre = txtNombre.Text;
            string Descripcion = txtDescripcion.Text;
            Marca Marca = (Marca)cboMarca.SelectedItem;
            Categoria Categoria = (Categoria)cboCategoria.SelectedItem;
            string Imagen = txtImagen.Text;
            string Precio = txtPrecio.Text;
            
            if (Codigo == "")
            {
                txtCodigo.BackColor = Color.Red;
                bandera = false;
            }
            else
            {
                txtCodigo.BackColor = System.Drawing.SystemColors.Control;
            } 
            if (Nombre == "")
            {
                txtNombre.BackColor = Color.Red;
                bandera = false;
            }
            else
            {
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
            }
            if (Descripcion == "")
            {
                txtDescripcion.BackColor = Color.Red;
                bandera = false;
            }
            else
            {
                txtDescripcion.BackColor = System.Drawing.SystemColors.Control;
            }
            if (Precio == "")
            {
                txtPrecio.BackColor = Color.Red;
                bandera = false;
            }
            else
            {
                txtPrecio.BackColor = System.Drawing.SystemColors.Control;
            }
            if (bandera)
            {
                NegocioArticulo negocioArt = new NegocioArticulo();
                negocioArt.agregarNuevoArticulo(Codigo, Nombre, Descripcion, Marca.Id, Categoria.Id, Imagen, Precio);
                MessageBox.Show("Se agrego exitosamente!!");
                this.Close();

            }
            else
            {
                MessageBox.Show("Complete los espacios en rojo por favor.");
            }
                
        }

        private void btnCancelarAgregar_Click(object sender, EventArgs e)
        {   //Prop : cierra la ventana actual, que es la ventana 'Agregar'.
            this.Close();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {   //Prop : solo deja ingresar numeros a nuestra TextBox.
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
