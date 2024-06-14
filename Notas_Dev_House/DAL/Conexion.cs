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
        //static string conexionstring = "server=sql.holamundodevs.com; database=AldairDouglasLizeth_NotasDB;" +
        //"User Id=erickbarcerna; Password=Holamundo123*";
        static string conexionstring = "server=sql.hmdevs.com; database=AldairDouglasLizeth_NotasDB;" +
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


        public void CrudEstudiante(int intProceso, string ID, string nombres, string apellidos, DateTime FechaNacimiento, string direccion, string telefono , int grado)
        
        {                   
                
                SqlCommand comando = new SqlCommand("SP_CrudEstudiantes", conexion);
                comando.CommandType = CommandType.StoredProcedure; 
                //parametros del procedimiento almacenado
                comando.Parameters.AddWithValue("@intProceso", intProceso);
                comando.Parameters.AddWithValue("@intId", ID);
                comando.Parameters.AddWithValue("@strNombres", nombres);
                comando.Parameters.AddWithValue("@strApellidos", apellidos);

                comando.Parameters.AddWithValue("@dateFechaNacimiento", FechaNacimiento);
                comando.Parameters.AddWithValue("@strDireccion", direccion);
                comando.Parameters.AddWithValue("@strTelefono", telefono);
                comando.Parameters.AddWithValue("@IntGrado", grado);

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


        /////////////////////////////////// MATERIAS //////////////////////////////////////
        ///

        public DataTable ConsultarMaterias(int intProceso, string ID)
        {

            try
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand("SP_CrudMaterias", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", intProceso);

               
                    
                
                
                
                    comando.Parameters.AddWithValue("@intId", ID);
                

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


        public void CrudMaterias(int intProceso, string ID, string nombre, string docenteId,string NombreDocente, int gradoId)

        {

            SqlCommand comando = new SqlCommand("SP_CrudMaterias", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            //parametros del procedimiento almacenado
            comando.Parameters.AddWithValue("@intProceso", intProceso);
            comando.Parameters.AddWithValue("@IntId", ID);
            comando.Parameters.AddWithValue("@strNombre", nombre);            
            comando.Parameters.AddWithValue("@strDocenteId ", docenteId);
            comando.Parameters.AddWithValue("@NombreDocente", NombreDocente);
            comando.Parameters.AddWithValue("@intGradoId", gradoId);



 
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


        public DataSet CargarDatosComboBox(string especialidad, string nombreDocente, int grado, int periodo, 
            string estudiante, string NombreMateria)
        {
            DataSet dataSet = new DataSet();

            try
            {
                conexion.Open();

                SqlCommand command = new SqlCommand("SP_CargarDatosComboBox", conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Especialidad", especialidad);
                command.Parameters.AddWithValue("@NombreDocente", nombreDocente);
                command.Parameters.AddWithValue("@Grado", grado);
                command.Parameters.AddWithValue("@IdPeriodo", periodo);
                command.Parameters.AddWithValue("@NombreEstudiante", estudiante);
                command.Parameters.AddWithValue("@NombreMateria", NombreMateria);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet);
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                Console.WriteLine("Error al cargar los datos en los ComboBoxes: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return dataSet;
        }

        public DataTable ConsultarNotas(int intProceso, string EstudianteId, int MateriaId)
        {

            try
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand("SP_CrudNotas", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", intProceso);

                if (string.IsNullOrEmpty(EstudianteId))
                {
                    comando.Parameters.AddWithValue("@strEstudianteId", DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@strEstudianteId", EstudianteId);
                }


                if (string.IsNullOrEmpty(Convert.ToString(MateriaId)))
                {
                    comando.Parameters.AddWithValue("@intMateriaId", DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@intMateriaId", MateriaId);
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



        public void CrudNotas(int intProceso, string EstudianteId, int MateriaId, double Nota1, double Nota2, double Nota3, string Observacion, int Periodo, int SuperUsuario)

        {

            SqlCommand comando = new SqlCommand("SP_CrudNotas", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            //parametros del procedimiento almacenado
            comando.Parameters.AddWithValue("@intProceso", intProceso);
            comando.Parameters.AddWithValue("@strEstudianteId", EstudianteId);
            comando.Parameters.AddWithValue("@intMateriaId", MateriaId);
            comando.Parameters.AddWithValue("@decNota1", Nota1);
            comando.Parameters.AddWithValue("@decNota2", Nota2);
            comando.Parameters.AddWithValue("@decNota3", Nota3);
            comando.Parameters.AddWithValue("@strObservacion", Observacion);
            comando.Parameters.AddWithValue("@intPeriodo", Periodo);
            comando.Parameters.AddWithValue("@bitSuperUsuario", SuperUsuario);




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

        /// USUARIOS
        public DataTable ConsultarUsuarios(int intProceso, string IdUsuario)
        {

            try
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand("SP_CrudUsuarios", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", intProceso);

                if (string.IsNullOrEmpty(IdUsuario))
                {
                    comando.Parameters.AddWithValue("@IdUsuario", DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);
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

        //public int CrudUsuarios(int intProceso, string IdUsuario, string NombreUsuario, string pass)
        //{
        //    try
        //    {
        //        int resultado = 0; // Variable para almacenar el resultado del procedimiento almacenado

        //        SqlCommand comando = new SqlCommand("SP_CrudUsuarios", conexion);
        //        comando.CommandType = CommandType.StoredProcedure;

        //        // Parámetros del procedimiento almacenado
        //        comando.Parameters.AddWithValue("@intProceso", intProceso);
        //        comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);
        //        comando.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
        //        comando.Parameters.AddWithValue("@Contrasena", pass);

        //        // Parámetro de salida para el resultado del procedimiento almacenado
        //        SqlParameter paramResultado = new SqlParameter("@resultado", SqlDbType.Int);
        //        paramResultado.Direction = ParameterDirection.Output;
        //        comando.Parameters.Add(paramResultado);

        //        conexion.Open();
        //        comando.ExecuteNonQuery();

        //        // Recuperar el valor de salida del procedimiento almacenado
        //        resultado = Convert.ToInt32(paramResultado.Value);

        //        // Retornar el resultado del procedimiento almacenado
        //        return resultado;
        //    }
        //    catch (SqlException ex)
        //    {
        //        // Manejar excepciones de SQL
        //        Console.WriteLine("Error: " + ex.Message);
        //        // Retornar un código de error                

        //    }
        //    finally
        //    {
        //        conexion.Close();
        //    }
        //}




    }
}
