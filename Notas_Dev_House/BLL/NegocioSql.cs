using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class NegocioSql
    {
        Conexion cn = new Conexion();

        public DataTable ConsultaDt()
        {

            return cn.consultarEstudiantes();
        }

        public int insertarEstudiante(string ID, string nombres, string apellidos, DateTime fechaNacimiento,
            string direccion, string telefono)

        {

            return cn.insertarEstudiante(ID, nombres, apellidos, fechaNacimiento, direccion, telefono);
        }

        public int eliminarEstudiante(string ID)
        {

            return cn.eliminarEstudiante(ID);
        }

        public int modificarEstudiante(string nombre, string apellido, string dni, string telefono,
            DateTime FechaNacimiento, string Direccion)
        {

            return cn.modificarEstudiante(nombre,apellido,dni,telefono,FechaNacimiento, Direccion);


        }








    }
}
