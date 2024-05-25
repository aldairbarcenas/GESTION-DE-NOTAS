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


        public DataTable consultarEstudiantes()
        {

            conexion.Open();

            SqlCommand comando = new SqlCommand("ConsultarEstudiantes", conexion);
            comando.CommandType = CommandType.StoredProcedure; //aplicamos el comando del procedimiento
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conexion.Close();
            return tabla;
        }


        public int insertarEstudiante(string ID, string nombres, string apellidos, DateTime fechaNacimiento,
            string direccion, string telefono)

        {

            int flag = 0;
            conexion.Open();
            SqlCommand comando = new SqlCommand("InsertarEstudiante", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            string fecha_nacimiento = fechaNacimiento.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            // Agregar parámetros
            comando.Parameters.AddWithValue("@ID", ID);
            comando.Parameters.AddWithValue("@Nombres", nombres);
            comando.Parameters.AddWithValue("@Apellidos", apellidos);
            comando.Parameters.AddWithValue("@FechaNacimiento", fecha_nacimiento);
            comando.Parameters.AddWithValue("@Direccion", direccion);
            comando.Parameters.AddWithValue("@Telefono", telefono);

            // Ejecutar el comando
            flag = comando.ExecuteNonQuery();
            conexion.Close();
            return flag;

        }


        public int eliminarEstudiante(string ID)
        {
            int flag = 0;
            conexion.Open();
            SqlCommand comando = new SqlCommand("EliminarEstudiante", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            // Agregar parámetro
            comando.Parameters.AddWithValue("@ID", ID);

            // Ejecutar el comando
            flag = comando.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

        public int modificarEstudiante(string nombre, string apellido, string dni, string telefono,
            DateTime FechaNacimiento2, string Direccion)
        {
            int flag = 0;
            conexion.Open();
            SqlCommand comando = new SqlCommand("ModificarEstudiante", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            string fecha_nacimiento = FechaNacimiento2.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            // Agregar parámetros
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Apellido", apellido);
            comando.Parameters.AddWithValue("@DNI", dni);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@FechaNacimiento", fecha_nacimiento);
            comando.Parameters.AddWithValue("@Direccion", Direccion);

            // Ejecutar el comando
            flag = comando.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }

        //public SqlDataReader ConsultarEstudiante(string ID)
        //{
        //    int flag = 0;
        //    conexion.Open();
        //    string query = "SELECT Nombres, Apellidos, FechaNacimiento, Direccion, Telefono " +
        //                   "FROM Estudiantes " +
        //                   "WHERE ID = @ID";
        //    SqlCommand comando = new SqlCommand(query, conexion);
        //    SqlDataReader reg =comando.ExecuteReader();
        //    flag = comando.ExecuteNonQuery();
        //    conexion.Close();
        //    return flag;


        //}










    }
}
