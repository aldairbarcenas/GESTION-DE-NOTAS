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



        public DataTable ConsultarEstudiantes(string nombres)
        {

            try
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand("SP_CrudEstudiantes", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 1);

                if (string.IsNullOrEmpty(nombres))
                {
                    comando.Parameters.AddWithValue("@strNombres", DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@strNombres", nombres);
                }

               

                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                conexion.Close();
                return tabla;

            }
            catch (Exception)
            {

                throw;
            }
           

        }


        public void CrudEstudiante(int intProceso, string ID, string nombres, string apellidos, DateTime FechaNacimiento, string direccion, string telefono)
        
        {                   
                
                SqlCommand comando = new SqlCommand("SP_CrudEstudiantes", conexion);
                comando.CommandType = CommandType.StoredProcedure; 
                //parametros del procedimiento almacenado
                comando.Parameters.AddWithValue("@intProceso", intProceso);
                comando.Parameters.AddWithValue("@intId", ID);
                comando.Parameters.AddWithValue("@strNombres", nombres);
                comando.Parameters.AddWithValue("@strApellidos", apellidos);

                comando.Parameters.AddWithValue("@dateFechaNacimiento", FechaNacimiento.Date);
                comando.Parameters.AddWithValue("@strDireccion", direccion);
                comando.Parameters.AddWithValue("@strTelefono", telefono);             

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                // Manejar excepciones de SQL
                Console.WriteLine("Error : " + ex.Message);
            }

            finally
            {
                conexion.Close();
            }
        }


        public void EliminarEstudiante(int intProceso, string ID)

        {            
            SqlCommand comando = new SqlCommand("SP_CrudEstudiantes", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@intProceso", intProceso);
            comando.Parameters.AddWithValue("@intId", ID);          

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();

            }

            catch (SqlException ex)
            {
                // Manejar excepciones de SQL
                Console.WriteLine("Error al eliminar estudiante: " + ex.Message);
            }

            finally
            {
                conexion.Close();
            }

        }

        ///////////////////////// grados///////////////////////////////////
        ///
        public DataTable ConsultarGrados(int intProceso, int ID)
        {

            try
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand("SP_CrudGrados", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", intProceso);

                if (string.IsNullOrEmpty(ID.ToString()))
                {
                    comando.Parameters.AddWithValue("@intId", DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@intId", ID);
                }

                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                conexion.Close();
                return tabla;

            }
            catch (Exception)
            {

                throw;
            }


        }


        public void CrudGrados(int intProceso, string Nombre, string ID)

        {

            SqlCommand comando = new SqlCommand("SP_CrudGrados", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            //parametros del procedimiento almacenado
            comando.Parameters.AddWithValue("@intProceso", intProceso);           
            comando.Parameters.AddWithValue("@strNombre", Nombre);
            comando.Parameters.AddWithValue("@intId", ID);

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                // Manejar excepciones de SQL
                Console.WriteLine("Error : " + ex.Message);
            }

            finally
            {
                conexion.Close();
            }
        }





    }
}
