﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinal
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            Se necesita una aplicación para la gestión de artículos de un catálogo de un comercio. La aplicación debe ser genérica, es decir, 
            aplicar para cualquier tipo de comercio; y la información que en ella se cargue será consumida luego desde distintos servicios para ser mostradas 
            ya sea en webs, e-commerces, apps mobile, revistas, etc. Esto no es parte del desarrollo, pero sí del contexto en el cual se utilizará la aplicación a desarrollar.
            Deberá ser una aplicación de escritorio que contemple la administración de artículos. Las funcionalidades que deberá tener la aplicación serán:
                Listado de artículos.
                Búsqueda de artículos por distintos criterios.
                Agregar artículos.
                Modificar artículos.
                Eliminar artículos.
                Ver detalle de un artículo.
            Toda ésta información deberá ser persistida en una base de datos ya existente (la cual se adjunta).
            Los datos mínimos con los que deberá contar el artículo son los siguientes:
                Código de artículo.
                Nombre.
                Descripción.
                Marca (seleccionable de una lista desplegable).
                Categoría (seleccionable de una lista desplegable.
                Imagen.
                Precio.
             */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fmPrincipal());
        }
    }
}
