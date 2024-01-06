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
    public partial class fmPrincipal : Form
    {
        public fmPrincipal()
        {
            InitializeComponent();
        }

        private void fmPrincipal_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void cargarGrilla()
        {
            NegocioArticulo articulos = new NegocioArticulo();
            dvgArticulos.DataSource = articulos.ListarArticulos();
            ocultarColumnas();
        }
        private void ocultarColumnas()
        {
            dvgArticulos.Columns["ID"].Visible = false;
            dvgArticulos.Columns["Codigo"].Visible = false;
            dvgArticulos.Columns["Descripcion"].Visible = false;
            dvgArticulos.Columns["UrlImagen"].Visible = false;
        }
        private void cargarImagen(string urlImagen)
        {
            try
            {
                pbxArticulo.Load(urlImagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://static.vecteezy.com/system/resources/previews/005/337/799/original/icon-image-not-found-free-vector.jpg");
            }
        }

        private void dvgArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dvgArticulos.CurrentRow != null)
                {
                    Articulo artActual = (Articulo)dvgArticulos.CurrentRow.DataBoundItem; // Aveces falla al agregar un articulo, nose aun porque.
                    cargarImagen(artActual.UrlImagen);
                    mostrarDescripcion(artActual);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void mostrarDescripcion(Articulo art)
        {   //Prop : muestra los datos completos del articulo recibido por parametro.
            string Id = art.Id.ToString();
            string Codigo = art.Codigo;
            string Nombre = art.Nombre;
            string Descripcion = art.Descripcion;
            string Marca = art.Marca.Descripcion;
            string Categoria = art.Categoria.Descripcion;
            string Precio = art.Precio.ToString();

            txtDescripcion.Text = "Descripcion Completa del Articulo : " + "\r\nID Articulo : " + Id + "\r\nCodigo Articulo : " + Codigo + "\r\nNombre Articulo : " + Nombre + "\r\nMarca : " + Marca + "\r\nCategoria : " + Categoria + "\r\nPrecio : " + Precio + "\r\nDescripcion Articulo : " + Descripcion;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {   //Prop : cargar la ventana para poder agregar un Articulo nuevo a nuesta grilla.
            FormAgregar agregar = new FormAgregar();
            agregar.ShowDialog();
            cargarGrilla();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {   // Prop : cargar la ventana para modificar los datos de un Articulo seleccionado de la grilla.

            if (dvgArticulos.CurrentRow != null)
            {
                Articulo articuloActual = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;
                FormAgregar ventanaModificar = new FormAgregar(articuloActual);
                ventanaModificar.ShowDialog();
                cargarGrilla();

            }
            else
            {
                MessageBox.Show("Seleccionar algun elemento de la tabla por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {   // Prop : elemina el articulo seleccionado de la grilla en caso de que el usuario le de 'okey'.
            NegocioArticulo negocio = new NegocioArticulo();
            try
            {
                Articulo articulo = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Seguro que quiere eliminar el Articulo?\r\n(se borrara de manera permanente)", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    negocio.borrarNegocio(articulo.Id);
                    cargarGrilla();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFiltrarRapido_TextChanged(object sender, EventArgs e)
        {
            NegocioArticulo articulos = new NegocioArticulo();
            List<Articulo> listaArticulos = articulos.ListarArticulos();
            string textFilrto = txtFiltrarRapido.Text;
            if(textFilrto != "")
            {
                listaArticulos = listaArticulos.FindAll(articulo => articulo.Nombre.ToUpper().Contains(textFilrto.ToUpper()));
            }
            dvgArticulos.DataSource = null;
            dvgArticulos.DataSource = listaArticulos;
            ocultarColumnas();


        }
    }
}
