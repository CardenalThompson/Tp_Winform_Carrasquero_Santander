using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos conexion = new AccesoDatos();

            conexion.setearConsulta("select id, Descripcion from Marcas");
            conexion.ejecutarLectura();
            while (conexion.Lector.Read())
            {
                lista.Add(new Marca((int)conexion.Lector["id"], (string)conexion.Lector["Descripcion"]));
            }

            conexion.cerrarConexion();
            return lista;
        }
    }
}

