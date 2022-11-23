using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Acceso
    {
        private SqlConnection conexion;
        public void Abrir()
        {
            conexion = new SqlConnection(@"Data Source=RYZEN-DESKTOP;Initial Catalog=BASE;Integrated Security=SSPI");
            conexion.Open();

        }
        public void Cerrar()
        {
            conexion.Close();
            conexion = null;
            GC.Collect();
        }
        private SqlCommand CrearComando(string sp, List<SqlParameter> parametros = null)
        {
            SqlCommand cmd = new SqlCommand(sp, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            if (parametros != null)
            {
                cmd.Parameters.AddRange(parametros.ToArray());
            }
            return cmd;
        }

        public DataTable Leer(string sp, List<SqlParameter> parametros = null)
        {
            DataTable tabla = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = CrearComando(sp, parametros);
                da.Fill(tabla);
                da.Dispose();
            }
            return tabla;
        }

        public int LeerEscalar(string sp, List<SqlParameter> parametros = null)
        {
            int resultado;
            SqlCommand cmd = CrearComando(sp, parametros);
            try
            {
                resultado = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch
            { resultado = -1; }
            return resultado;

        }


        public int Escribir(string sp, List<SqlParameter> parametros = null)
        {
            int resultado;
            SqlCommand cmd = CrearComando(sp, parametros);
            try
            {
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            { 
                
                resultado = -1; 
            }
            return resultado;

        }

        public SqlParameter CrearParametro(string nombre, string valor)
        {
            SqlParameter parametro = new SqlParameter(nombre, valor);
            parametro.DbType = DbType.String;
            return parametro;
        }

        public SqlParameter CrearParametro(string nombre, int valor)
        {
            SqlParameter parametro = new SqlParameter(nombre, valor);
            parametro.DbType = DbType.Int32;
            return parametro;
        }

        public SqlParameter CrearParametro(string nombre, float valor)
        {
            SqlParameter parametro = new SqlParameter(nombre, valor);
            parametro.DbType = DbType.Single;
            return parametro;
        }
    }
}
