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
            cargarCboCampo();
            
        }
        private void cargarCboCampo()
        { //Prop : carga los campos de cboCampo.
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Precio");

        }
        private void cargarGrilla()
        {   //Prop : carga la grilla con los datos traidos del NegocioArticulos.
            NegocioArticulo articulos = new NegocioArticulo();
            dvgArticulos.DataSource = articulos.ListarArticulos();
            ocultarColumnas();
        }
        private void ocultarColumnas()
        {   //Prop : oculta columnas de la grilla.
            dvgArticulos.Columns["ID"].Visible = false;
            dvgArticulos.Columns["Codigo"].Visible = false;
            dvgArticulos.Columns["Descripcion"].Visible = false;
            dvgArticulos.Columns["UrlImagen"].Visible = false;
        }
        private void cargarImagen(string urlImagen)
        {   //Prop : carga la imagen del parametro, en caso que no pueda, carga una imagen predeterminada.
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
        {   //Prop : dependiendo del articulo selleccionado muestra sus datos con la subtarea 'mostrarDescripcion'.
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
        {   // Prop : muestra en la grilla los articulos que contenga escrito lo que ingrese el usuario en el txtFiltradoRapido.
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

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campo = cboCampo.SelectedItem.ToString();
            if(campo == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual ");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Empieza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contenga");
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            NegocioArticulo articulos = new NegocioArticulo();

            try
            {
                if (validarFiltros())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroBDD.Text;

                dvgArticulos.DataSource = articulos.filtrarArticulos(campo, criterio, filtro);
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
  
        }
        private bool validarFiltros()
        {   //Prop : retorn true si algunos de los filtros no estan seleccionados, o el texto si tiene el campo 'Precio' tiene letras.
            if(cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Elejir un campo por favor!", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;

            }
            if(cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Elejir un criterio por favor!", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            if(cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (!(soloNumeros(txtFiltroBDD.Text)) || txtFiltroBDD.Text == "")
                {
                    MessageBox.Show("Ingresar solo numeros por favor!", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }
            }

            return false;
        }
        private bool soloNumeros(string texto)
        {   //Prop : valida si la string ingresado solo contiene numeros.
            foreach (char caracter in texto)
            {
                if (!(char.IsNumber(caracter))){
                    return false;
                }
            }
            return true;
        }
       
    }
}
