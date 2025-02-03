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
    public class EdicionNegocio
    {
        private ConexionDB1 conexionDB1=new ConexionDB1();
        public List<TiposEdicion> listarEdicion()
        {
            List<TiposEdicion> listaEdicion=new List<TiposEdicion>();
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector ;
            SqlCommand comando = new SqlCommand();

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                comando.CommandType=System.Data.CommandType.Text;
                comando.CommandText = "select Id, Descripcion as Edicion from TIPOSEDICION";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    TiposEdicion aux=new TiposEdicion();
                    aux.Id = (int)lector["Id"];
                    aux.Descripcion = (string)lector["Edicion"];
                    listaEdicion.Add(aux);
                }

                return listaEdicion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
        public void agregar(TiposEdicion edicion)
        {
            
            try
            {
                conexionDB1.instruccionSQL("insert into TIPOSEDICION(Descripcion) values(@descripcion);");
                conexionDB1.setearComando("@descripcion", edicion.Descripcion);
                conexionDB1.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexionDB1.cerrarConexion();
            }
            
        }
        public void editar(TiposEdicion edicion)
        {
            try
            {
                conexionDB1.instruccionSQL("update TIPOSEDICION set Descripcion=@descripcion where id=@id");
                conexionDB1.setearComando("@descripcion",edicion.Descripcion);
                conexionDB1.setearComando("@id",edicion.Id);
                conexionDB1.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexionDB1.cerrarConexion();
            }
        }
        public void eliminar(TiposEdicion edicion)
        {
            try
            {
                conexionDB1.instruccionSQL("delete from TIPOSEDICION where id=@id");
                conexionDB1.setearComando("@id",edicion.Id);
                conexionDB1.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexionDB1.cerrarConexion();
            }
        }
    }
}
