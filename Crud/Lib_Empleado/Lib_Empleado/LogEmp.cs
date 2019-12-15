using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using LibLlenarCombos;
using LibLlenarGrids;
using LibConexionBD;

namespace Lib_Empleado
{
    public class LogEmp
    {
        #region Atributos
        private int cedula;
        private string nombre;
        private string apellido;
        private string telefono;
        private double salario;
        private string error;
        SqlDataReader objReader;
        #endregion

        #region Metodo Contructor
        public LogEmp()
        {
            cedula = 0;
            nombre = "";
            apellido = "";
            telefono = "";
            salario = 0;
            error = "";
        }
        #endregion

        #region Propiedades
        public int gsCedula { get => cedula; set => cedula = value; }
        public string gsNombre { get => nombre; set => nombre = value; }
        public string gsApellido { get => apellido; set => apellido = value; }
        public string gsTelefono { get => telefono; set => telefono = value; }
        public double gsSalario { get => salario; set => salario = value; }
        public string gsError { get => error; set => error = value; }
        public SqlDataReader ObjReader { get => objReader; set => objReader = value; }
        #endregion

        #region Metodos Publicos
        public bool listarEmpleado(DataGridView dgv1)
        {
            ClsLLenarGrids objg = new ClsLLenarGrids();
            objg.NombreTabla = "empleado";
            objg.SQL = "SP_LISTAR";
            if (!objg.LlenarGrid(dgv1))
            {
                error = objg.ERROR;
                objg = null;
                return false;
            }
            objg = null;
            return true;
        }

        public bool seleccionarEmpleado(ComboBox cmb1)
        {
            ClsLlenarCombos objc = new ClsLlenarCombos();
            objc.NombreTabla = "empleado";
            objc.SQL = "SP_SELECCIONAR";
            objc.ColumnaValor = "cedula";
            objc.ColumnaTexto = "nombre";
            if (!objc.LlenarCombo(cmb1))
            {
                error = objc.Error;
                objc = null;
                return false;
            }
            objc = null;
            return true;
        }

        public bool InsertarEmpleado()
        {
            string sentencia = "execute SP_INSERTAR '" + cedula + "','" + nombre + "','" + apellido + "','" + telefono + "'," + salario;
            ClsConexion objcon = new ClsConexion();
            if (!objcon.EjecutarSentencia(sentencia, false))
            {
                error = objcon.Error;
                objcon = null;
                return false;
            }
            else
            {
                objcon = null;
                return true;
            }
        }

        public bool ModificarEmpleado()
        {
            string sentencia = "execute SP_ACTUALIZAR '" + cedula + "','" + nombre + "','" + apellido + "','" + telefono + "'," + salario;
            ClsConexion objcon = new ClsConexion();
            if (!objcon.EjecutarSentencia(sentencia, false))
            {
                error = objcon.Error;
                objcon = null;
                return false;
            }
            else
            {
                objcon = null;
                return true;
            }
        }

        public bool ConsultarEmpleado()
        {
            string sentencia = "execute SP_CONSULTAR '" + cedula + "'";
            ClsConexion objcon = new ClsConexion();
            if (objcon.Consultar(sentencia, false))
            {
                objReader = objcon.Reader;
                objcon = null;
                return true;
            }
            else
            {
                error = objcon.Error;
                objcon = null;
                return false;
            }
        }

        public bool EliminarEmpleado()
        {
            string sentencia = "execute SP_BORRAR '" + cedula + "'";
            ClsConexion objcon = new ClsConexion();
            if (objcon.Consultar(sentencia, false))
            {
                objReader = objcon.Reader;
                objcon = null;
                return true;
            }
            else
            {
                error = objcon.Error;
                objcon = null;
                return false;
            }
        }
        #endregion
    }
}
