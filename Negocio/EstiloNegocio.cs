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
    public class EstiloNegocio
    {
        public List<Estilo> listar()
        {
            List<Estilo> listaEstilos=new List<Estilo>();
            ConexionDB1 datos= new ConexionDB1();
            try
            {
                datos.instruccionSQL("select Id, Descripcion as Estilos from ESTILOS");
                datos.lecturaSql();
                
                while (datos.Lector.Read())
                {
                    Estilo aux=new Estilo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion= (string)datos.Lector["Estilos"];
                    listaEstilos.Add(aux);
                }
                return listaEstilos;
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
        public void agregar(Estilo estilo)
        {
            ConexionDB1 con = new ConexionDB1();
            try
            {
                
                con.instruccionSQL("insert into ESTILOS(Descripcion) values(@descripcion);");
                con.setearComando("@descripcion",estilo.Descripcion);
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
        public void editar(Estilo estilo)
        {
            ConexionDB1 con=new ConexionDB1();
            try
            {
                con.instruccionSQL("update ESTILOS set Descripcion=@descripcion where id=@id");
                con.setearComando("@descripcion",estilo.Descripcion);
                con.setearComando("@id",estilo.Id);
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
        public void eliminar(Estilo estilo)
        {
            ConexionDB1 con=new ConexionDB1();
            try
            {
                con.instruccionSQL("delete from ESTILOS where Id=@id");
                con.setearComando("@id",estilo.Id);
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
        public bool existeEstiloEnDisco(Estilo estilo)
        {
            bool bandera=false;
            ConexionDB1 con=new ConexionDB1();
            List<Disco> listaDiscos= new List<Disco>();
            DiscoNegocio discoNegocio=new DiscoNegocio();
            try
            {
                
                listaDiscos=discoNegocio.listarDiscos(estilo);
                
                if (listaDiscos.Count>0)
                {
                    bandera=true;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return bandera;
        }
    }
}
