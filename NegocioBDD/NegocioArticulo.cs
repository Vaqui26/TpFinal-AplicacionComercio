﻿using System;
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
                    if(!(accesoDatos.Lector["Codigo"] is DBNull))
                        articuloAux.Codigo = (string)accesoDatos.Lector["Codigo"];
                    if (!(accesoDatos.Lector["Nombre"] is DBNull))
                        articuloAux.Nombre = (string)accesoDatos.Lector["Nombre"];
                    if (!(accesoDatos.Lector["Desc_Articulo"] is DBNull)) 
                        articuloAux.Descripcion = (string)accesoDatos.Lector["Desc_Articulo"];
                    if (!(accesoDatos.Lector["ImagenUrl"] is DBNull))
                        articuloAux.UrlImagen = (string)accesoDatos.Lector["ImagenUrl"];
                    if (!(accesoDatos.Lector["Precio"] is DBNull)) 
                        articuloAux.Precio = (decimal)accesoDatos.Lector["Precio"];
                    articuloAux.Marca = new Marca();
                    if (!(accesoDatos.Lector["IdMarca"] is DBNull))
                        articuloAux.Marca.Id = (int)accesoDatos.Lector["IdMarca"];
                    articuloAux.Marca.Descripcion = (string)accesoDatos.Lector["Desc_Marca"];
                    articuloAux.Categoria = new Categoria();
                    if (!(accesoDatos.Lector["IdCategoria"] is DBNull))
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
        public void agregarNuevoArticulo(Articulo articulo)
        {
            ManejoBDD accesoDatos = new ManejoBDD();

            try
            {
                accesoDatos.setearConsulta("Insert into ARTICULOS values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Imagen, @Precio)");
                accesoDatos.setearParametros("@Codigo", articulo.Codigo);
                accesoDatos.setearParametros("@Nombre", articulo.Nombre);
                accesoDatos.setearParametros("@Descripcion", articulo.Descripcion);
                accesoDatos.setearParametros("@IdMarca", articulo.Marca.Id);
                accesoDatos.setearParametros("@IdCategoria", articulo.Categoria.Id);
                accesoDatos.setearParametros("@Imagen", articulo.UrlImagen);
                accesoDatos.setearParametros("@Precio", articulo.Precio);
                accesoDatos.ejecutarAccion();
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
        public void modificar(Articulo articulo)
        {
            ManejoBDD accesoDatos = new ManejoBDD();
            try
            {
                accesoDatos.setearConsulta("Update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenURL = @ImagenURL, Precio = @Precio where Id = @Id");
                accesoDatos.setearParametros("@Id", articulo.Id);
                accesoDatos.setearParametros("@Codigo",articulo.Codigo);
                accesoDatos.setearParametros("@Nombre",articulo.Nombre);
                accesoDatos.setearParametros("@Descripcion",articulo.Descripcion);
                accesoDatos.setearParametros("@IdMarca",articulo.Marca.Id);
                accesoDatos.setearParametros("@IdCategoria",articulo.Categoria.Id);
                accesoDatos.setearParametros("@ImagenURL",articulo.UrlImagen);
                accesoDatos.setearParametros("@Precio",articulo.Precio);
                accesoDatos.ejecutarAccion();
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
        public void borrarNegocio(int id)
        {
            ManejoBDD accesoDatos = new ManejoBDD();
            try
            {
                accesoDatos.setearConsulta("Delete From ARTICULOS where Id = @Id");
                accesoDatos.setearParametros("@Id", id);
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
