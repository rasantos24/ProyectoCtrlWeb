using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CtrlWebT
{
    public class ConexionBD
    {
        private SqlConnection sqlc;

        public ConexionBD()
        {
            //string cadena_conexion = "server=(local)host;userid=sa;password=1234;database=Ctrl_Test";
            string cadena_conexion = "Data Source=(local);Initial Catalog=Ctrl_Test;Persist Security " +
                "Info=True;User ID=sa;Password=1234"; 
            sqlc = new SqlConnection(cadena_conexion);
        }

        public void abrir()
        {
            if (sqlc.State != ConnectionState.Open)
                sqlc.Open();
        }

        public void cerrar()
        {
            if (sqlc.State != ConnectionState.Closed)
                sqlc.Close();
        }

        public List<Inventario> getGrupos()
        {
            List<Inventario> grupos = new List<Inventario>();
            try
            {
                abrir();
                string sql = "select NuId, NoInventario, IdBin, IdProducto, Costo, Cantidad," +
                    "Conteo, Diferencia, TotalCantidad, TotalConteo, TotalDiferencia from icInventarioFisicoDetalle";
                SqlCommand cmd = new SqlCommand(sql, sqlc);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int ni = dr.GetInt32(0);
                    int noiv = dr.GetInt32(1);
                    string ib = dr.GetString(2);
                    string ip = dr.GetString(3);
                    double cost = dr.GetDouble(4);
                    double cant = dr.GetDouble(5);
                    double cont = dr.GetDouble(6);
                    double dife = dr.GetDouble(7);
                    double toca = dr.GetDouble(8);
                    double toco = dr.GetDouble(9);
                    double todi = dr.GetDouble(10);

                    grupos.Add(new Inventario(ni, noiv, ib, ip, cost, cant, dife, toca, toco, todi));
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cerrar();
            }
            return grupos;
        }
    }
}