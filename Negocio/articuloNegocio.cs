using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> ArmarLista()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.descripcion Categoria,ImagenUrl, Precio from Articulos A left join Marcas M ON A.IdMarca=M.Id left join Categorias C on A.IdCategoria=C.Id");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.codigo = (string)datos.Lector["Codigo"];
                    aux.nombre = (string)datos.Lector["Nombre"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];
                    aux.marca = new Marca((string)datos.Lector["Marca"]);
                    aux.categoria = new Categoria((string)datos.Lector["Categoria"]);
                    aux.imagen = (string)datos.Lector["ImagenUrl"];
                    aux.precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }

    
}
