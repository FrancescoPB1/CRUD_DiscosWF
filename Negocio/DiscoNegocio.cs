using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using ConexionDB;
namespace Negocio
{
    public class DiscoNegocio
    {
        public List<Disco> listarDiscos()
        {
            
            ConexionDB1 con=new ConexionDB1();

            try
            {
                List<Disco> listar=new List<Disco>();
                con.instruccionSQL("select d.Id,d.Titulo,d.FechaLanzamiento,d.CantidadCanciones,d.UrlImagenTapa,e.Descripcion as Estilo,t.Descripcion  as Edicion,e.Id as IdEstilo,t.Id as IdEdicion from DISCOS d,ESTILOS e, TIPOSEDICION t where d.IdEstilo=e.Id and d.IdTipoEdicion=t.Id");
                con.lecturaSql();
                while (con.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)con.Lector["Id"];
                    if (!(con.Lector["Titulo"] is DBNull))
                        aux.Titulo = (string)con.Lector["Titulo"];
                    if (!(con.Lector["FechaLanzamiento"] is DBNull))
                        aux.FechaLanzamiento = (DateTime)con.Lector["FechaLanzamiento"];
                    if (!(con.Lector["CantidadCanciones"] is DBNull))
                        aux.CantidadCanciones = (int)con.Lector["CantidadCanciones"];
                    if (!(con.Lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)con.Lector["UrlImagenTapa"];
                    aux.Estilo = new Estilo();
                    aux.Estilo.Id = (int)con.Lector["IdEstilo"];
                    if (!(con.Lector["Estilo"] is DBNull))
                        aux.Estilo.Descripcion = (string)con.Lector["Estilo"];
                    aux.Edicion = new TiposEdicion();
                    aux.Edicion.Id = (int)con.Lector["IdEdicion"];
                    if (!(con.Lector["Edicion"] is DBNull))
                        aux.Edicion.Descripcion = (string)con.Lector["Edicion"];
                    listar.Add(aux);
                }
                return listar;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.cerrarConexion() ;
            }

        }
        public List<Disco> listarDiscos(Estilo estilo)
        {

            ConexionDB1 con = new ConexionDB1();

            try
            {
                List<Disco> listar = new List<Disco>();
                con.instruccionSQL("select d.Id,d.Titulo,d.FechaLanzamiento,d.CantidadCanciones,d.UrlImagenTapa,e.Descripcion as Estilo,t.Descripcion  as Edicion,e.Id as IdEstilo,t.Id as IdEdicion from DISCOS d,ESTILOS e, TIPOSEDICION t where d.IdEstilo=e.Id and d.IdTipoEdicion=t.Id and e.Id=@idEstilos");
                con.setearComando("@idEstilos",estilo.Id);
                con.lecturaSql();
                while (con.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)con.Lector["Id"];
                    if (!(con.Lector["Titulo"] is DBNull))
                        aux.Titulo = (string)con.Lector["Titulo"];
                    if (!(con.Lector["FechaLanzamiento"] is DBNull))
                        aux.FechaLanzamiento = (DateTime)con.Lector["FechaLanzamiento"];
                    if (!(con.Lector["CantidadCanciones"] is DBNull))
                        aux.CantidadCanciones = (int)con.Lector["CantidadCanciones"];
                    if (!(con.Lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)con.Lector["UrlImagenTapa"];
                    aux.Estilo = new Estilo();
                    aux.Estilo.Id = (int)con.Lector["IdEstilo"];
                    if (!(con.Lector["Estilo"] is DBNull))
                        aux.Estilo.Descripcion = (string)con.Lector["Estilo"];
                    aux.Edicion = new TiposEdicion();
                    aux.Edicion.Id = (int)con.Lector["IdEdicion"];
                    if (!(con.Lector["Edicion"] is DBNull))
                        aux.Edicion.Descripcion = (string)con.Lector["Edicion"];
                    listar.Add(aux);
                }
                return listar;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.cerrarConexion();
            }

        }

        public void agregar(Disco disco)
        {
            ConexionDB1 con=new ConexionDB1 ();
            try
            {
                con.instruccionSQL($"insert into DISCOS values('{disco.Titulo}','{disco.FechaLanzamiento}',{disco.CantidadCanciones},'{disco.UrlImagenTapa}',@IdEstilo,@IdTipoEdicion);");
                con.setearComando("@IdEstilo",disco.Estilo.Id);
                con.setearComando("@IdTipoEdicion",disco.Edicion.Id);
                con.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.cerrarConexion();
            }

        }
        public void modificar(Disco modificar)
        {
            ConexionDB1 conexion= new ConexionDB1 ();
            try
            {
                conexion.instruccionSQL("update DISCOS set Titulo=@titulo,FechaLanzamiento=@fecha,CantidadCanciones=@cantidad,UrlImagenTapa=@url,IdEstilo=@idEstilos,IdTipoEdicion=@IdEdicion where Id=@id");
                conexion.setearComando("@titulo", modificar.Titulo);
                conexion.setearComando("@fecha", modificar.FechaLanzamiento);
                conexion.setearComando("@cantidad", modificar.CantidadCanciones);
                conexion.setearComando("@url", modificar.UrlImagenTapa);
                conexion.setearComando("@idEstilos", modificar.Estilo.Id);
                conexion.setearComando("@IdEdicion", modificar.Edicion.Id);
                conexion.setearComando("@Id", modificar.Id);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }
            
        }
        public void eliminar(int id)
        {
            ConexionDB1 con = new ConexionDB1();
            try
            {
                con.instruccionSQL("delete from DISCOS where Id=@id");
                con.setearComando("@id",id);
                con.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
    }

}
