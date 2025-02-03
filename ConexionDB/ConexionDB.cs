using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Linq.Expressions;
namespace ConexionDB
{
    public class ConexionDB1
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get
            {
                return lector;
            }
        }
        public ConexionDB1()
        {
            conexion= new SqlConnection("server=.\\SQLEXPRESS;database=DISCOS_DB;integrated security=true");
            comando = new SqlCommand();
        }
        public  void instruccionSQL(string sentencia)
        {
            comando.CommandText = sentencia;
            comando.Connection = conexion;
        }
        public void lecturaSql()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public void ejecutarAccion()
        {
            comando.Connection=conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void setearComando(string nombre,object objeto)
        {
            comando.Parameters.AddWithValue(nombre,objeto);
        }
        public void cerrarConexion()
        {
            if (lector != null) 
                lector.Close();
            conexion.Close();
        }

    }
}
