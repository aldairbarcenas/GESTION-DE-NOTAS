using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Globalization;

namespace DAL
{
    public class Conexion
    {
        static string conexionstring = "server=sql.holamundodevs.com; database=AldairDouglasLizeth_NotasDB;" +
        "User Id=erickbarcerna; Password=Holamundo123*";
        SqlConnection conexion = new SqlConnection(conexionstring);



        public DataTable ConsultarEstudiantes()
        {

            conexion.Open();

            SqlCommand comando = new SqlCommand("SP_CrudEstudiantes", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@intProceso", 1);

            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conexion.Close();
            return tabla;
        }


        public void CrudEstudiante(int intProceso, string ID, string nombres, string apellidos, DateTime FechaNacimiento, string direccion, string telefono)
        
        {
            conexion.Open();
            try
            {
                
                SqlCommand comando = new SqlCommand("SP_CrudEstudiantes", conexion);
                comando.CommandType = CommandType.StoredProcedure; 
                
                comando.Parameters.AddWithValue("@intProceso", intProceso);
                comando.Parameters.AddWithValue("@intId", ID);
                comando.Parameters.AddWithValue("@strNombres", nombres);
                comando.Parameters.AddWithValue("@strApellidos", apellidos);
                comando.Parameters.AddWithValue("@dateFechaNacimiento", FechaNacimiento);
                comando.Parameters.AddWithValue("@strDireccion", direccion);
                comando.Parameters.AddWithValue("@strTelefono", telefono);

                comando.ExecuteNonQuery();
                
            }
            catch (Exception)
            {

               
            }
            conexion.Close();
        }


        public void EliminarEstudiante(int intProceso, string ID)

        {

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SP_CrudEstudiantes", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@intProceso", intProceso);
                comando.Parameters.AddWithValue("@intId", ID);                

                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
            }

        }   


    }
}
