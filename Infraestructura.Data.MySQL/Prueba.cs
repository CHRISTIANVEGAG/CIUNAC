using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using Dominio.Core.Entities;

namespace Infraestructura.Data.MySQL
{
    public class Prueba
    {
        Conexion objCon = new Conexion();
        MySqlConnection cn = new MySqlConnection();

        public IEnumerable<Pruebas> listaPrueba()
        {
            cn = objCon.getConecta();
            cn.Open();
            List<Pruebas> aAtraccion = new List<Pruebas>();
            MySqlCommand cmd = new MySqlCommand("sp_listafrutas", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                Pruebas objA = new Pruebas()
                {
                    
                    codigo = int.Parse(dr[0].ToString()),
                    nombre = dr[1].ToString(),
                };
                aAtraccion.Add(objA);
            }
            dr.Close();
            cn.Close();
            return aAtraccion;
        }

    }
}
