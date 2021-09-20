using System;
using System.Collections.Generic;
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
                    Articulo aux = CompletarArticulo(datos);

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

        private static Articulo CompletarArticulo(AccesoDatos datos)
        {
            Articulo articulo = new Articulo();

            try
            {
                articulo.codigo = (string)datos.Lector["Codigo"]; 
                articulo.nombre = (string)datos.Lector["Nombre"];
                articulo.descripcion = (string)datos.Lector["Descripcion"];
                articulo.marca = new Marca((string)datos.Lector["Marca"]);
                articulo.categoria = new Categoria((string)datos.Lector["Categoria"]);
                articulo.imagen = !(datos.Lector["ImagenUrl"] is DBNull) ? (string)datos.Lector["ImagenUrl"] : string.Empty;
                articulo.precio = (decimal)datos.Lector["Precio"];
            }
            catch (Exception)
            {
            }

            return articulo;
        }

        public bool agregar(Articulo nuevo)
        {
            try
            {
                AccesoDatos conexion = new AccesoDatos();
                conexion.setearConsulta("insert into ARTICULOS( Codigo,Nombre, Descripcion, IdMarca,IdCategoria,Precio, ImagenUrl)values(@cod, @nombre,@des,@marca,@cat,@precio,@imagen) ");
                conexion.agregarParametro("@cod", nuevo.codigo);
                conexion.agregarParametro("@nombre", nuevo.nombre);
                conexion.agregarParametro("@des", nuevo.descripcion);
                conexion.agregarParametro("@marca", nuevo.marca.id);
                conexion.agregarParametro("@cat", nuevo.categoria.id);
                conexion.agregarParametro("@precio", nuevo.precio);
                conexion.agregarParametro("@imagen", nuevo.imagen);

                conexion.ejecutarAccion();

                return true;
            }
            catch
            {
                return false;
            }


        }

        public bool editar(Articulo arti)
        {
            try
            {
                AccesoDatos conexion = new AccesoDatos();
                conexion.setearConsulta("update ARTICULOS set codigo=@codigo,Nombre=@nombre,Descripcion=@des,idcategoria=@cat,idmarca=@marca,Precio=@precio, ImagenUrl=@imagen where Id=@id ");

                conexion.agregarParametro("@codigo", arti.codigo);
                conexion.agregarParametro("@nombre", arti.nombre);
                conexion.agregarParametro("@des", arti.descripcion);
                conexion.agregarParametro("@imagen", arti.imagen);
                conexion.agregarParametro("@marca", arti.marca.id);
                conexion.agregarParametro("@cat", arti.categoria.id);
                conexion.agregarParametro("@precio", arti.precio);
                conexion.agregarParametro("@id", arti.id);
                conexion.ejecutarAccion();

                return true;
            }
            catch
            {
                return false;
            }

        }
    }

    
}
