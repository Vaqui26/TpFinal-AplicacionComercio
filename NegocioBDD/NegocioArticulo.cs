using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objetos;

namespace NegocioBDD
{
    public class NegocioArticulo
    {
        private List<Articulo> lista = new List<Articulo>();

        public List<Articulo> ListarArticulos()
        {   //Prop : retorna una lista con los articulos que posea la base de datos.

            ManejoBDD accesoDatos = new ManejoBDD();

            try
            {
                accesoDatos.setearConsulta("Select a.Id as ID,Codigo,Nombre,a.Descripcion as Desc_Articulo,IdMarca,m.descripcion as Desc_Marca,IdCategoria ,c.Descripcion as Desc_Categoria,ImagenUrl,Precio From ARTICULOS as a Join MARCAS as m On IdMarca = m.Id Join CATEGORIAS as c On IdCategoria = c.Id");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Articulo articuloAux = new Articulo();
                    articuloAux.Id = (int)accesoDatos.Lector["ID"];
                    articuloAux.Codigo = (string)accesoDatos.Lector["Codigo"];
                    articuloAux.Nombre = (string)accesoDatos.Lector["Nombre"];
                    articuloAux.Descripcion = (string)accesoDatos.Lector["Desc_Articulo"];
                    articuloAux.UrlImagen = (string)accesoDatos.Lector["ImagenUrl"];
                    articuloAux.Precio = (decimal)accesoDatos.Lector["Precio"];
                    articuloAux.Marca = new Marca();
                    articuloAux.Marca.Id = (int)accesoDatos.Lector["IdMarca"];
                    articuloAux.Marca.Descripcion = (string)accesoDatos.Lector["Desc_Marca"];
                    articuloAux.Categoria = new Categoria();
                    articuloAux.Categoria.Id = (int)accesoDatos.Lector["IdCategoria"];
                    articuloAux.Categoria.Descripcion = (string)accesoDatos.Lector["Desc_Categoria"];

                    lista.Add(articuloAux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
         
        }
        public void agregarNuevoArticulo(string Codigo, string Nombre, string Descripcion, int IdMarca, int IdCategoria, string Imagen, string Precio)
        {

        }
    }
}
