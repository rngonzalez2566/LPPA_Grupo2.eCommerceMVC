using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace eCommerce.DAL
{
    public class Acceso
    {
        SqlConnection CN = new SqlConnection();
        string conexion = @"Data Source = DESKTOP-M0TF3H1\SQLEXPRESS; Initial Catalog = restaurante_mvc; Integrated Security = True"; // cadena de conexión JOAQUIN
        //string conexion = @""; // cadena de conexión RODRI
        //string conexion = @""; // cadena de conexión CASTA
        //string conexion = @""; // cadena de conexión RAMI


        void Conectar()
        {
            CN.ConnectionString = conexion;
            CN.Open();
        }

        void Desconectar()
        {
            CN.Close();
            CN.Dispose();
        }

        public int Escribir(string st, SqlParameter[] parametros)
        {
            int fa = 0;
            Conectar();

            SqlTransaction TR;
            TR = CN.BeginTransaction();

            try
            {
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.CommandText = st;
                CMD.Connection = CN;
                CMD.Parameters.AddRange(parametros);
                CMD.Transaction = TR;
                fa = CMD.ExecuteNonQuery();
                TR.Commit();
            }
            catch (Exception Ex)
            {
                TR.Rollback();
            }

            Desconectar();
            return fa;
        }

        public DataTable Leer(string st, SqlParameter[] parametros)
        {
            Conectar();
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = new SqlCommand();
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            adaptador.SelectCommand.CommandText = st;
            if (parametros != null)
            {
                adaptador.SelectCommand.Parameters.AddRange(parametros);
            }
            adaptador.SelectCommand.Connection = CN;
            adaptador.Fill(tabla);

            Desconectar();

            return tabla;
        }

        public DataTable GenerarConsulta(string Consulta)
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            Conectar();
            SqlTransaction TR;
            SqlCommand Comando = new SqlCommand(Consulta, CN);
            TR = CN.BeginTransaction();

            try
            {
                Comando.Transaction = TR;
                dr = Comando.ExecuteReader();
                dt.Load(dr);
                TR.Commit();
            }
            catch (Exception Ex)
            {
                TR.Rollback();
            }

            Desconectar();
            return dt;
        }

        public DataTable GenerarConsultaSinTransaccion(string Consulta)
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            Conectar();
            SqlCommand Comando = new SqlCommand(Consulta, CN);

            try
            {
                dr = Comando.ExecuteReader();
                dt.Load(dr);
            }
            catch (Exception Ex)
            {
            }

            Desconectar();
            return dt;
        }

        public SqlConnection LeerConexion()
        {
            if (CN.State == ConnectionState.Open)
            {
                CN.Close();
                CN.Dispose();
            }
            else
            {
                CN.ConnectionString = conexion;
                CN.Open();
            }
            return CN;
        }

        public void GenerarXML(string consulta, string tipo, string path, string nombre)
        {
            DataSet DS = new DataSet();
            Conectar();
            SqlDataAdapter DA = new SqlDataAdapter(consulta, CN);
            DA.Fill(DS, tipo);
            Desconectar();
            DS.WriteXml(path + nombre);
        }
    }
}
