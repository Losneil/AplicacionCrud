using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Lib_Empleado;

namespace Awf_Empleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenarEmpleado();
            escogerEmpleado();
        }

        private void llenarEmpleado()
        {
            LogEmp obje = new LogEmp();
            if (!obje.listarEmpleado(dvgEmpleado))
            {
                MessageBox.Show(obje.gsError);
                return;
            }
        }

        private void escogerEmpleado()
        {
            LogEmp obje = new LogEmp();
            if (!obje.seleccionarEmpleado(cmbEmpleado))
            {
                MessageBox.Show(obje.gsError);
                return;
            }
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            Guardar();
            llenarEmpleado();
            escogerEmpleado();
        }

        private void Guardar()
        {
            LogEmp obje = new LogEmp();
            try
            {
                obje.gsCedula = Convert.ToInt32(txtID.Text);
                obje.gsNombre = txtNAME.Text;
                obje.gsApellido = txtLASTNAME.Text;
                obje.gsTelefono = txtPHONE.Text;
                obje.gsSalario = Convert.ToDouble(txtSALARY.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Se requieren llenar todos los campos");
                return;
            }
            if (!obje.InsertarEmpleado())
            {
                MessageBox.Show(obje.gsError);
                return;
            }
            else
            {
                MessageBox.Show("Registro completado correctamente");
                txtID.Clear();
                txtNAME.Clear();
                txtLASTNAME.Clear();
                txtPHONE.Clear();
                txtSALARY.Clear();
            }  
        }

        private void btnCONSULT_Click(object sender, EventArgs e)
        {
            Consultar(txtID.Text);   
        }

        private void Consultar(string cc)
        {
            LogEmp obje = new LogEmp();
            try
            {
                obje.gsCedula = Convert.ToInt32(txtID.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("No hay id existente para la consulta");
                return;
            }
            if (!obje.ConsultarEmpleado())
            {
                MessageBox.Show(obje.gsError);
                obje = null;
                return;
            }
            SqlDataReader dataReader;
            dataReader = obje.ObjReader;
            if (dataReader.HasRows)
            {
                dataReader.Read();
                txtNAME.Text = dataReader.GetString(1);
                txtLASTNAME.Text = dataReader.GetString(2);
                txtPHONE.Text = dataReader.GetString(3);
                txtSALARY.Text = dataReader.GetDecimal(4).ToString();
                dataReader.Close();
            }
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            Modificar();
            llenarEmpleado();
            escogerEmpleado();
        }

        private void Modificar()
        {
            LogEmp obje = new LogEmp();
            try
            {
                obje.gsCedula = Convert.ToInt32(txtID.Text);
                obje.gsNombre = txtNAME.Text;
                obje.gsApellido = txtLASTNAME.Text;
                obje.gsTelefono = txtPHONE.Text;
                obje.gsSalario = Convert.ToDouble(txtSALARY.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("No hay datos para modificar");
                return;
            }
            if (!obje.ModificarEmpleado())
            {
                MessageBox.Show(obje.gsError);
                return;
            }
            MessageBox.Show("Datos actualizados correctamente");
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            Eliminar(txtID.Text);
            llenarEmpleado();
            escogerEmpleado();
        }

        private void Eliminar(string cc)
        {
            LogEmp obje = new LogEmp();
            try
            {
                obje.gsCedula = Convert.ToInt32(txtID.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione primero un registro a eliminar");
                return;
            }
            if (!obje.EliminarEmpleado())
            {
                MessageBox.Show(obje.gsError);
                obje = null;
                return;
            }
            else
            {
                MessageBox.Show("Datos eliminados correctamente");
                txtID.Clear();
                txtNAME.Clear();
                txtLASTNAME.Clear();
                txtPHONE.Clear();
                txtSALARY.Clear();
            }
            SqlDataReader dataReader;
            dataReader = obje.ObjReader;
            if (dataReader.HasRows)
            {
                dataReader.Read();
                txtNAME.Text = dataReader.GetString(1);
                txtLASTNAME.Text = dataReader.GetString(2);
                txtPHONE.Text = dataReader.GetString(3);
                txtSALARY.Text = dataReader.GetDecimal(4).ToString();
                dataReader.Close();
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNAME.Clear();
            txtLASTNAME.Clear();
            txtPHONE.Clear();
            txtSALARY.Clear();
        }

        public void soloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public void soloLetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void txtLASTNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void txtPHONE_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtSALARY_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void dvgEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dvgEmpleado.Rows[e.RowIndex];
                txtID.Text = row.Cells["cedula"].Value.ToString();
                txtNAME.Text = row.Cells["nombre"].Value.ToString();
                txtLASTNAME.Text = row.Cells["apellido"].Value.ToString();
                txtPHONE.Text = row.Cells["telefono"].Value.ToString();
                txtSALARY.Text = row.Cells["salario"].Value.ToString();
            }
        }

        private void FechaHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
