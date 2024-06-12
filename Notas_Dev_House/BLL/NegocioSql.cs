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
        

        public void CrudEstudiante(int intProceso, string ID, string nombres, string apellidos, DateTime FechaNacimiento, string direccion, string telefono, int grado)

        {
            cn.CrudEstudiante(intProceso, ID, nombres, apellidos, FechaNacimiento, direccion, telefono, grado);


        }


        public DataTable ConsultaDt(string nombres)
        {

            return cn.ConsultarEstudiantes(nombres);
        }



        public void EliminarEstudiante(int intProceso, string ID)

        {
            cn.EliminarEstudiante(4, ID);

        }
        /////////////////////////////////////////// GRADOS
        public DataTable ConsultarGrados(int IntProceso, int ID)
        {
            return cn.ConsultarGrados(IntProceso, ID);

        }


        public void CrudGrados(int intProceso, string Nombre, string ID)
        {

            cn.CrudGrados(intProceso, Nombre, ID);

        }


        /////////////////////////////////////////// MATERIAS

        public DataTable ConsultarMaterias(int IntProceso, int ID)
        {
            return cn.ConsultarMaterias(IntProceso, ID);

        }

        public DataSet CargarDatosComboBox(string especialidad, string nombreDocente, int grado, int periodo, string estudiante, string materia)
        {
            return cn.CargarDatosComboBox(especialidad, nombreDocente, grado, periodo, estudiante, materia);


        }

        public void CrudMaterias(int intProceso, int ID, string nombre, string docenteId, int gradoId)

        {
            cn.CrudMaterias(intProceso, ID, nombre, docenteId, gradoId);

        }

        public DataTable ConsultarNotas(int intProceso, string EstudianteId, int MateriaId)
        {

            return cn.ConsultarNotas(intProceso, EstudianteId, MateriaId);
        }



        public void CrudNotas(int intProceso, string EstudianteId, int MateriaId, double Nota1, double Nota2, double Nota3, string Observacion, int Periodo, int SuperUsuario)

        {

            cn.CrudNotas(intProceso, EstudianteId, MateriaId, Nota1, Nota2, Nota3, Observacion, Periodo, SuperUsuario);


        }

        public DataTable ConsultarUsuarios(int intProceso, string IdUsuario)
        {
            return cn.ConsultarUsuarios(intProceso, IdUsuario);
        }
        //public int CrudUsuarios(int intProceso, string IdUsuario, string NombreUsuario, string pass)
        //{
        //    return cn.CrudUsuarios(intProceso, IdUsuario, NombreUsuario, pass);
        //}
    }
}

