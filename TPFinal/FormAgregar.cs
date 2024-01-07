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
using System.IO;
using System.Configuration;

namespace TPFinal
{
    public partial class FormAgregar : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;

        public FormAgregar()
        {
            InitializeComponent();
        }
        public FormAgregar(Articulo art)
        {
            InitializeComponent();
            articulo = art;
            Text = "Modificar Articulo";
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            cargarComboBoxs();
            if(articulo != null)
            {
                txtCodigo.Text = articulo.Codigo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                cboMarca.SelectedValue = articulo.Marca.Id;
                cboCategoria.SelectedValue = articulo.Categoria.Id;
                txtImagen.Text = articulo.UrlImagen;
                cargarImagen(articulo.UrlImagen);
                txtPrecio.Text = articulo.Precio.ToString();

            }
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
            try { 
            if (articulo == null)
                articulo = new Articulo();
                       
            articulo.Codigo = txtCodigo.Text;
            articulo.Nombre = txtNombre.Text;
            articulo.Descripcion = txtDescripcion.Text;
            articulo.Marca = (Marca)cboMarca.SelectedItem;
            articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
            articulo.UrlImagen= txtImagen.Text;
            
            
            if (articulo.Codigo == "")
            {
                txtCodigo.BackColor = Color.Red;
                bandera = false;
            }
            else
            {
                txtCodigo.BackColor = System.Drawing.SystemColors.Control;
            } 
            if (articulo.Nombre == "")
            {
                txtNombre.BackColor = Color.Red;
                bandera = false;
            }
            else
            {
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
            }
            if (articulo.Descripcion == "")
            {
                txtDescripcion.BackColor = Color.Red;
                bandera = false;
            }
            else
            {
                txtDescripcion.BackColor = System.Drawing.SystemColors.Control;
            }
            if (txtPrecio.Text == "" )
            {
                txtPrecio.BackColor = Color.Red;
                bandera = false;
            }
            else
            {
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                txtPrecio.BackColor = System.Drawing.SystemColors.Control;
            }
            if (bandera)
            {
                NegocioArticulo negocioArt = new NegocioArticulo();
                if(articulo.Id != 0)
                {
                    negocioArt.modificar(articulo);
                    MessageBox.Show("Modificacion Exitosa!!","Hecho",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    negocioArt.agregarNuevoArticulo(articulo);
                    MessageBox.Show("Se agrego exitosamente!!","Completado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

                if(archivo != null && !(txtImagen.Text.ToLower().Contains("http"))) 
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["urlImagen"] + archivo.SafeFileName);

                    this.Close();

            }
            else
            {
                MessageBox.Show("Complete los espacios en rojo por favor.","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }
        private void cargarImagen(string urlImagen)
        {
            try
            {
                pbxAgregar.Load(urlImagen);
            }
            catch (Exception)
            {
                pbxAgregar.Load("https://static.vecteezy.com/system/resources/previews/005/337/799/non_2x/icon-image-not-found-free-vector.jpg");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {   //Prop : permite al usuario ingrear una imagen de manera local.
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagen.Text = archivo.FileName;
                cargarImagen(txtImagen.Text);

            }
        }
    }
}
