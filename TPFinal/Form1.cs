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
                pbxArticulo.Load("https://upload.wikimedia.org/wikipedia/commons/a/a3/Image-not-found.png");
            }
        }

        private void dvgArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo artActual = (Articulo)dvgArticulos.CurrentRow.DataBoundItem;
            cargarImagen(artActual.UrlImagen);
            mostrarDescripcion(artActual);
        }
        private void mostrarDescripcion(Articulo art)
        {
            string Id = art.Id.ToString();
            string Codigo = art.Codigo;
            string Nombre = art.Nombre;
            string Marca = art.Marca.Descripcion;
            string Categoria = art.Categoria.Descripcion;
            string Precio = art.Precio.ToString();

            txtDescripcion.Text = "Descripcion Completa del Articulo : " + "\r\nID Articulo : " + Id + "\r\nCodigo Articulo : " + Codigo + "\r\nNombre Articulo : " + Nombre + "\r\nMarca : " + Marca + "\r\nCategoria : " + Categoria + "\r\nPrecio : " + Precio;

        }
    }
}
