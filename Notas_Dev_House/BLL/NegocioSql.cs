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

     

        public void CrudEstudiante(int intProceso, string ID, string nombres, string apellidos, DateTime FechaNacimiento, string direccion, string telefono)

        {
            cn.CrudEstudiante(intProceso, ID, nombres, apellidos, FechaNacimiento, direccion, telefono);


        }


        public DataTable ConsultaDt()
        {

            return cn.ConsultarEstudiantes();
        }

      

        public void EliminarEstudiante(int intProceso, string ID)

        {
            cn.EliminarEstudiante(4, ID);

        }
    }
}
