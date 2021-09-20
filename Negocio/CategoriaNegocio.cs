using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos conexion = new AccesoDatos();
            conexion.setearConsulta("select id, Descripcion from CATEGORIAS");
            conexion.ejecutarLectura();
            while (conexion.Lector.Read())
            {
                lista.Add(new Categoria((int)conexion.Lector["id"], (string)conexion.Lector["Descripcion"]));
            }

            conexion.cerrarConexion();
            return lista;
        }
    }
}
