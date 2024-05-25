using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Class1
    {
        static string conexionstring = "server=sql.holamundodevs.com; database=AldairDouglasLizeth_NotasDB;" +
      "User Id=erickbarcerna; Password=Holamundo123*";
        SqlConnection conexion = new SqlConnection(conexionstring);


        public DataTable consultarEstudiantes()
        {

            conexion.Open();
            string query = "select * from Estudiantes";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conexion.Close();
            return tabla;
        }


        public int insertarEstudiante(string ID, string nombres, string apellidos, string fechaNacimiento,
            string direccion, string telefono)

        {

            int flag = 0;
            conexion.Open();
            string query = "insert into Estudiantes values ('" + ID + "','" + nombres + "','" + apellidos + "'," +
                "'" + fechaNacimiento + "','" + direccion + "','" + telefono + "')";
            SqlCommand comando = new SqlCommand(query, conexion);
            flag = comando.ExecuteNonQuery();
            conexion.Close();
            return flag;

        }


        public int eliminarEstudiante(string ID)
        {
            int flag = 0;
            conexion.Open();
            string query = "Delete from Estudiantes where ID ='" + ID + "'";
            SqlCommand comando = new SqlCommand(query, conexion);
            flag = comando.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

        public int modificarEstudiante(string nombre, string apellido, string dni, string telefono,
            string FechaNacimiento, string Direccion)
        {
            int flag = 0;
            conexion.Open();
            string query = "Update Estudiantes set Nombres ='" + nombre + "',Apellidos='" + apellido + "',ID='" + dni + "',Telefono='" + telefono + "', FechaNacimiento='" + FechaNacimiento + "',Direccion='" + Direccion + "' where ID='" + dni + "'";
            SqlCommand comando = new SqlCommand(query, conexion);
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
