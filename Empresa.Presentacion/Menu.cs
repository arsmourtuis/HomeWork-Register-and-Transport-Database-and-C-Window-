using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Empresa.Entidades;
using Empresa.LogicaNegocios;

namespace Empresa.Presentacion
{
    public partial class Menu : Form
    {
        //Constructor
        public Menu()
        {
            InitializeComponent();
        }

        // intancia de operaciones
        Empresa.LogicaNegocios.ClaseOperaciones operaciones = new Empresa.LogicaNegocios.ClaseOperaciones();

        //método Borrar
        private void Borrar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtCedula.Text = "";
            txtSalario.Text = "";
            txtCorreo.Text = "";
            txtCelular.Text = "";
            txtSeguro.Text = "";
            txtplaca.Text = "";
            txtmotor.Text = "";
            chkEmpD.Checked = false;
            chkEmpN.Checked = false;
            chkEmpV.Checked = false;
            chkT.Checked = false;
            chkEmpD.Enabled = true;
            chkEmpN.Enabled = true;
            chkEmpV.Enabled = true;
            chkT.Enabled = true;
        }

        //Validar que esté empleado diurno seleccionado
        private void ChkEmpD_CheckStateChanged(object sender, EventArgs e)
        {
            // validar si marcado
            if (chkEmpD.Checked)
            {
                chkEmpN.Enabled = false;    // deshabilita lo nocturno
                chkEmpV.Enabled = false;    // deshabilita lo vespertino
                chkT.Enabled = false;
            }
             else
            {
                chkEmpV.Enabled = true;     // habilita lo vespertino
                chkEmpN.Enabled = true;     // habilita lo nocturno
                chkT.Enabled = true;
            }
        }

        //validar que esté empleado nocturno seleccionado
        private void ChkEmpN_CheckStateChanged(object sender, EventArgs e)
        {
            // validar si marcado
            if (chkEmpN.Checked)
            {
                chkEmpD.Enabled = false;    // deshabilita lo diurno
                chkEmpV.Enabled = false;    // deshabilita lo vespertino
                chkT.Enabled = false;
            }
            else
            {
                chkEmpD.Enabled = true;     // habilita lo diurno
                chkEmpV.Enabled = true;     // habilita lo vespertino
                chkT.Enabled = true;
            }
        }

        //validar que esté empleado vespertino seleccionado
        private void ChkEmpV_CheckStateChanged(object sender, EventArgs e)
        {
            // validar si marcado
            if (chkEmpV.Checked)
            {
                chkEmpD.Enabled = false;    // deshabilita lo diurno
                chkEmpN.Enabled = false;    // deshabilita lo nocturno
                chkT.Enabled = false;
            }
            else
            {
                chkEmpD.Enabled = true;     // habilita lo diurno
                chkEmpN.Enabled = true;     // habilita lo nocturno
                chkT.Enabled = true;
            }


        }

        private void chkTemporal_CheckStateChanged(object sender, EventArgs e)
        {
            // validar si marcado
            if (chkT.Checked)
            {
                chkEmpD.Enabled = false;    // deshabilita lo diurno
                chkEmpN.Enabled = false;    // deshabilita lo nocturno
                chkEmpV.Enabled = false;
            }
            else
            {
                chkEmpD.Enabled = true;     // habilita lo diurno
                chkEmpN.Enabled = true;     // habilita lo nocturno
                chkEmpV.Enabled = true;
            }


        }

        //Al seleccionar el gridEmpleados diurno, envía la información a las cajas de texto
        private void GridEmpleadosD_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = gridEmpleadosD.SelectedRows[0].Cells[1].Value.ToString();
            txtNombre.Text = gridEmpleadosD.SelectedRows[0].Cells[2].Value.ToString();
            txtApellido1.Text = gridEmpleadosD.SelectedRows[0].Cells[3].Value.ToString();
            txtApellido2.Text = gridEmpleadosD.SelectedRows[0].Cells[4].Value.ToString();
            txtCedula.Text = gridEmpleadosD.SelectedRows[0].Cells[5].Value.ToString();
            txtSalario.Text = gridEmpleadosD.SelectedRows[0].Cells[6].Value.ToString();
            txtTurno.Text = gridEmpleadosD.SelectedRows[0].Cells[0].Value.ToString();
            txtCorreo.Text = gridEmpleadosD.SelectedRows[0].Cells[7].Value.ToString();
            txtCelular.Text = gridEmpleadosD.SelectedRows[0].Cells[8].Value.ToString();
            txtSeguro.Text = gridEmpleadosD.SelectedRows[0].Cells[9].Value.ToString();
            txtplaca.Text = gridEmpleadosD.SelectedRows[0].Cells[10].Value.ToString();
            txtmotor.Text = gridEmpleadosD.SelectedRows[0].Cells[11].Value.ToString();
        }

        //Al seleccionar el gridEmpleados nocturno, envía la información a las cajas de texto
        private void GridEmpleadosN_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = gridEmpleadosN.SelectedRows[0].Cells[1].Value.ToString();
            txtNombre.Text = gridEmpleadosN.SelectedRows[0].Cells[2].Value.ToString();
            txtApellido1.Text = gridEmpleadosN.SelectedRows[0].Cells[3].Value.ToString();
            txtApellido2.Text = gridEmpleadosN.SelectedRows[0].Cells[4].Value.ToString();
            txtCedula.Text = gridEmpleadosN.SelectedRows[0].Cells[5].Value.ToString();
            txtSalario.Text = gridEmpleadosN.SelectedRows[0].Cells[6].Value.ToString();
            txtTurno.Text = gridEmpleadosN.SelectedRows[0].Cells[0].Value.ToString();
            txtCorreo.Text = gridEmpleadosN.SelectedRows[0].Cells[7].Value.ToString();
            txtCelular.Text = gridEmpleadosN.SelectedRows[0].Cells[8].Value.ToString();
            txtSeguro.Text = gridEmpleadosN.SelectedRows[0].Cells[9].Value.ToString();
            txtplaca.Text = gridEmpleadosD.SelectedRows[0].Cells[10].Value.ToString();
            txtmotor.Text = gridEmpleadosD.SelectedRows[0].Cells[11].Value.ToString();
        }

        //Al seleccionar el gridEmpleados vespertino, envía la información a las cajas de texto
        private void GridEmpleadosV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = gridEmpleadosV.SelectedRows[0].Cells[1].Value.ToString();
            txtNombre.Text = gridEmpleadosV.SelectedRows[0].Cells[2].Value.ToString();
            txtApellido1.Text = gridEmpleadosV.SelectedRows[0].Cells[3].Value.ToString();
            txtApellido2.Text = gridEmpleadosV.SelectedRows[0].Cells[4].Value.ToString();
            txtCedula.Text = gridEmpleadosV.SelectedRows[0].Cells[5].Value.ToString();
            txtSalario.Text = gridEmpleadosV.SelectedRows[0].Cells[6].Value.ToString();
            txtTurno.Text = gridEmpleadosV.SelectedRows[0].Cells[0].Value.ToString();
            txtCorreo.Text = gridEmpleadosV.SelectedRows[0].Cells[7].Value.ToString();
            txtCelular.Text = gridEmpleadosV.SelectedRows[0].Cells[8].Value.ToString();
            txtSeguro.Text = gridEmpleadosV.SelectedRows[0].Cells[9].Value.ToString();
            txtplaca.Text = gridEmpleadosD.SelectedRows[0].Cells[10].Value.ToString();
            txtmotor.Text = gridEmpleadosD.SelectedRows[0].Cells[11].Value.ToString();
        }

        //Al seleccionar el gridEmpleados temporales, envía la información a las cajas de texto
        private void GridEmpleadosT_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = gridEmpleadosT.SelectedRows[0].Cells[1].Value.ToString();
            txtNombre.Text = gridEmpleadosT.SelectedRows[0].Cells[2].Value.ToString();
            txtApellido1.Text = gridEmpleadosT.SelectedRows[0].Cells[3].Value.ToString();
            txtApellido2.Text = gridEmpleadosT.SelectedRows[0].Cells[4].Value.ToString();
            txtCedula.Text = gridEmpleadosT.SelectedRows[0].Cells[5].Value.ToString();
            txtSalario.Text = gridEmpleadosT.SelectedRows[0].Cells[6].Value.ToString();
            txtTurno.Text = gridEmpleadosT.SelectedRows[0].Cells[0].Value.ToString();
            txtCorreo.Text = gridEmpleadosT.SelectedRows[0].Cells[7].Value.ToString();
            txtCelular.Text = gridEmpleadosT.SelectedRows[0].Cells[8].Value.ToString();
            txtSeguro.Text = gridEmpleadosT.SelectedRows[0].Cells[9].Value.ToString();
            txtplaca.Text = gridEmpleadosD.SelectedRows[0].Cells[10].Value.ToString();
            txtmotor.Text = gridEmpleadosD.SelectedRows[0].Cells[11].Value.ToString();
        }
        //Para Agregar empleado
        private void btnAgregarEmp_Click(object sender, EventArgs e)
        {
            //asigna el tipo de empleado diurno/nocturno seleccionado
            if (chkEmpD.Checked)
            {
                txtTurno.Text = "Diurno";
            }
            else if (chkEmpN.Checked)
            {
                txtTurno.Text = "Nocturno";
            }
            else if (chkEmpV.Checked)
            {
                txtTurno.Text = "Vespertino";
            } else
            {
                txtTurno.Text = "Temporal";
            }

                // validamos chkEmpD de empleado diurno marcado
                if (chkEmpD.Checked)
            {
                // valida si los textBox estan llenos
                if (txtID.Text.Equals("") || txtNombre.Text.Equals("")
                    || txtApellido1.Text.Equals("") || txtApellido2.Text.Equals("")
                    || txtCedula.Text.Equals("") || txtSalario.Text.Equals("")
                    || txtCorreo.Text.Equals("") || txtCelular.Text.Equals("")
                    || txtSeguro.Text.Equals(""))
                {
                    MessageBox.Show("Debe llenar todos los campos requeridos");
                }
                else
                {
                    // crea un nuevo empleado y lo insertamos
                    operaciones.InsertarEmpleadoDiurno(new Entidades.DiurnoE(txtTurno.Text, int.Parse(txtID.Text),
                        txtNombre.Text, txtApellido1.Text, txtApellido2.Text, int.Parse(txtCedula.Text),
                        double.Parse(txtSalario.Text), txtCorreo.Text, int.Parse(txtCelular.Text), int.Parse(txtSeguro.Text), txtmotor.Text, txtplaca.Text));

                    MessageBox.Show("Vehículo insertado correctamente");

                    gridEmpleadosD.DataSource = null;
                    gridEmpleadosD.DataSource = operaciones.RetornarEmpleadosDiurno();
                    gridEmpleadosD.Refresh();
                }
            }
            else if (chkEmpN.Checked)
            {
                // valida si los textBox estan llenos
                if (txtID.Text.Equals("") || txtNombre.Text.Equals("")
                    || txtApellido1.Text.Equals("") || txtApellido2.Text.Equals("")
                    || txtCedula.Text.Equals("") || txtSalario.Text.Equals("")
                    || txtCorreo.Text.Equals("") || txtCelular.Text.Equals("")
                    || txtSeguro.Text.Equals(""))

                {
                    MessageBox.Show("Debe llenar todos los campos requeridos");
                }
                else
                {
                    // crea un nuevo empleado nocturno y lo insertamos
                    operaciones.InsertarEmpleadoNocturno(new Entidades.NocturnoE(txtTurno.Text, int.Parse(txtID.Text),
                        txtNombre.Text, txtApellido1.Text, txtApellido2.Text, int.Parse(txtCedula.Text),
                        double.Parse(txtSalario.Text), txtCorreo.Text, int.Parse(txtCelular.Text), int.Parse(txtSeguro.Text), txtmotor.Text, txtplaca.Text));

                    MessageBox.Show("Vehículo insertado correctamente");

                    gridEmpleadosN.DataSource = null;
                    gridEmpleadosN.DataSource = operaciones.RetornarEmpleadosNocturno();
                    gridEmpleadosN.Refresh();
                }
            }
            else if (chkEmpV.Checked)
            {
                // valida si los textBox estan llenos
                if (txtID.Text.Equals("") || txtNombre.Text.Equals("")
                    || txtApellido1.Text.Equals("") || txtApellido2.Text.Equals("")
                    || txtCedula.Text.Equals("") || txtSalario.Text.Equals("")
                    || txtCorreo.Text.Equals("") || txtCelular.Text.Equals("")
                    || txtSeguro.Text.Equals(""))

                {
                    MessageBox.Show("Debe llenar todos los campos requeridos");
                }
                else
                {
                    // crea un nuevo empleado vespertino y lo insertamos
                    operaciones.InsertarEmpleadoVespertino(new Entidades.VespertinoE(txtTurno.Text, int.Parse(txtID.Text),
                        txtNombre.Text, txtApellido1.Text, txtApellido2.Text, int.Parse(txtCedula.Text),
                        double.Parse(txtSalario.Text), txtCorreo.Text, int.Parse(txtCelular.Text), int.Parse(txtSeguro.Text), txtmotor.Text, txtplaca.Text));

                    MessageBox.Show("Vehículo insertado correctamente");

                    gridEmpleadosV.DataSource = null;
                    gridEmpleadosV.DataSource = operaciones.RetornarEmpleadosVespertino();
                    gridEmpleadosV.Refresh();
                }

            }
            else if (chkT.Checked)
            {
                // valida si los textBox estan llenos
                if (txtID.Text.Equals("") || txtNombre.Text.Equals("")
                    || txtApellido1.Text.Equals("") || txtApellido2.Text.Equals("")
                    || txtCedula.Text.Equals("") || txtSalario.Text.Equals("")
                    || txtCorreo.Text.Equals("") || txtCelular.Text.Equals("")
                    || txtSeguro.Text.Equals(""))

                {
                    MessageBox.Show("Debe llenar todos los campos requeridos");
                }
                else
                {
                    // crea un nuevo empleado vespertino y lo insertamos
                    operaciones.InsertarEmpleadoTemporal(new Entidades.TemporalE(txtTurno.Text, int.Parse(txtID.Text),
                        txtNombre.Text, txtApellido1.Text, txtApellido2.Text, int.Parse(txtCedula.Text),
                        double.Parse(txtSalario.Text), txtCorreo.Text, int.Parse(txtCelular.Text), int.Parse(txtSeguro.Text), txtmotor.Text, txtplaca.Text));

                    MessageBox.Show("Vehículo insertado correctamente");

                    gridEmpleadosT.DataSource = null;
                    gridEmpleadosT.DataSource = operaciones.RetornarEmpleadosTemporal();
                    gridEmpleadosT.Refresh();
                }
            }
            else
            {
                MessageBox.Show("No selecciono ningún tipo de vehiculo");
            }
            Borrar();//limpia los campos después de ingresar a un empleado ingresado o no.
        }

        //Variables
        double mayor, menor; String nombreEmpMa, nombreEmpMe, nombreEmpMa2, nombreEmpMe2;

        //Cerrar la aplicación
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Salario mayor y menor diurno
        private void btnSalarioMD_Click_1(object sender, EventArgs e)
        {
            double num1; string nombreEmp1;
            for (int i = 0; i < gridEmpleadosD.Rows.Count; ++i)
            {
                num1 = Convert.ToDouble(gridEmpleadosD.Rows[i].Cells[6].Value);
                nombreEmp1 = Convert.ToString(gridEmpleadosD.Rows[i].Cells[2].Value);
                if (i == 0)
                {
                    mayor = Convert.ToDouble(num1);
                    menor = Convert.ToDouble(num1);
                    nombreEmpMa = Convert.ToString(nombreEmp1);
                    nombreEmpMe = Convert.ToString(nombreEmp1);
                }
                else
                {
                    if (Convert.ToDouble(num1) > mayor)
                    {
                        mayor = Convert.ToDouble(num1);
                        nombreEmpMa2 = Convert.ToString(nombreEmp1);
                    }
                    if (Convert.ToDouble(num1) < menor)
                    {
                        menor = Convert.ToDouble(num1);
                        nombreEmpMe2 = Convert.ToString(nombreEmp1);
                    }
                }
            }
            txtInfo.Text = "El Salario máximo para el turno diurno es: " + mayor + " y le corresponde a: " + nombreEmpMa2 +
                "\r\nEl Salario mínimo para el turno diurno es: " + menor + " y le corresponde a: " + nombreEmpMe2;
        }

        //Salario mayor y menor nocturno
        private void btnSalarioMN_Click_1(object sender, EventArgs e)
        {
            double num; string nombreEmp;
            for (int i = 0; i < gridEmpleadosN.Rows.Count; ++i)
            {
                num = Convert.ToDouble(gridEmpleadosN.Rows[i].Cells[6].Value);
                nombreEmp = Convert.ToString(gridEmpleadosN.Rows[i].Cells[2].Value);
                if (i == 0)
                {
                    mayor = Convert.ToDouble(num);
                    menor = Convert.ToDouble(num);
                    nombreEmpMa = Convert.ToString(nombreEmp);
                    nombreEmpMe = Convert.ToString(nombreEmp);
                }
                else
                {
                    if (Convert.ToDouble(num) > mayor)
                    {
                        mayor = Convert.ToDouble(num);
                        nombreEmpMa = Convert.ToString(nombreEmp);
                    }
                    if (Convert.ToDouble(num) < menor)
                    {
                        menor = Convert.ToDouble(num);
                        nombreEmpMe = Convert.ToString(nombreEmp);
                    }
                }
            }
            txtInfo.Text = "El Salario máximo para el turno nocturno es: " + mayor + " y le corresponde a: " + nombreEmpMa +
                "\r\nEl Salario mínimo para el turno nocturno es: " + menor + " y le corresponde a: " + nombreEmpMe;
        }

        //Gastos generales
        private void btnGastos_Click_1(object sender, EventArgs e)
        {
            double suma = 0, suma2 = 0, suma3 = 0, suma4=0, total;
            for (int i = 0; i < gridEmpleadosD.Rows.Count; ++i)
            {
                suma += Convert.ToDouble(gridEmpleadosD.Rows[i].Cells[6].Value);
            }
            for (int i = 0; i < gridEmpleadosN.Rows.Count; ++i)
            {
                suma2 += Convert.ToDouble(gridEmpleadosN.Rows[i].Cells[6].Value);
            }
            for (int i = 0; i < gridEmpleadosV.Rows.Count; ++i)
            {
                suma3 += Convert.ToDouble(gridEmpleadosV.Rows[i].Cells[6].Value);
            }
            for (int i = 0; i < gridEmpleadosT.Rows.Count; ++i)
            {
                suma4 += Convert.ToDouble(gridEmpleadosT.Rows[i].Cells[6].Value);
            }

            total = suma + suma2 + suma3;
            txtInfo.Text = "Los gastos en sueldos para los empleados del turno Diurno corresponden a:  " + suma +
                "\r\nLos gastos en sueldos para los empleados del turno Nocturno corresponden a:  " + suma2 +
                "\r\nLos gastos en sueldos para los empleados del turno Vespertino corresponden a:  " + suma3 +
                "\r\nLos gastos en sueldos para los empleados del turno Temporal corresponden a:  " + suma4 +
                "\r\nLos gastos generalesen sueldos para los empleados de la empresa son:  " + total;
        }

        //Elimina empleado nocturno
        private void btnEliminarEmpN_Click_1(object sender, EventArgs e)
        {
            try
            {
                operaciones.EliminarEmpleadoNocturno(new Empresa.Entidades.NocturnoE(txtTurno.Text, int.Parse(txtID.Text),
                            txtNombre.Text, txtApellido1.Text, txtApellido2.Text, int.Parse(txtCedula.Text),
                            double.Parse(txtSalario.Text), txtCorreo.Text, int.Parse(txtCelular.Text), int.Parse(txtSeguro.Text), txtmotor.Text, txtplaca.Text));

                gridEmpleadosN.DataSource = null;
                gridEmpleadosN.DataSource = operaciones.RetornarEmpleadosNocturno();
                gridEmpleadosN.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("No hay empleado que eliminar");
            }
            Borrar();
        }

        //Elimina empleado vespertino
        private void btnEliminarEmpV_Click(object sender, EventArgs e)
        {
            try
            {
                operaciones.EliminarEmpleadoVespertino(new Empresa.Entidades.VespertinoE(txtTurno.Text, int.Parse(txtID.Text),
                            txtNombre.Text, txtApellido1.Text, txtApellido2.Text, int.Parse(txtCedula.Text),
                            double.Parse(txtSalario.Text), txtCorreo.Text, int.Parse(txtCelular.Text), int.Parse(txtSeguro.Text), txtmotor.Text, txtplaca.Text));

                gridEmpleadosV.DataSource = null;
                gridEmpleadosV.DataSource = operaciones.RetornarEmpleadosVespertino();
                gridEmpleadosV.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("No hay empleado que eliminar");
            }
            Borrar();
        }

        //Salario mayor y menor vespertino
        private void btnSalarioMV_Click(object sender, EventArgs e)
        {
            double num; string nombreEmp;
            for (int i = 0; i < gridEmpleadosV.Rows.Count; ++i)
            {
                num = Convert.ToDouble(gridEmpleadosV.Rows[i].Cells[6].Value);
                nombreEmp = Convert.ToString(gridEmpleadosV.Rows[i].Cells[2].Value);
                if (i == 0)
                {
                    mayor = Convert.ToDouble(num);
                    menor = Convert.ToDouble(num);
                    nombreEmpMa = Convert.ToString(nombreEmp);
                    nombreEmpMe = Convert.ToString(nombreEmp);
                }
                else
                {
                    if (Convert.ToDouble(num) > mayor)
                    {
                        mayor = Convert.ToDouble(num);
                        nombreEmpMa = Convert.ToString(nombreEmp);
                    }
                    if (Convert.ToDouble(num) < menor)
                    {
                        menor = Convert.ToDouble(num);
                        nombreEmpMe = Convert.ToString(nombreEmp);
                    }
                }
            }
            txtInfo.Text = "El Salario máximo para el turno vespertino es: " + mayor + " y le corresponde a: " + nombreEmpMa +
                "\r\nEl Salario mínimo para el turno vespertino es: " + menor + " y le corresponde a: " + nombreEmpMe;
        }



        private void btnSalarioMT_Click(object sender, EventArgs e)
        {
            double num; string nombreEmp;
            for (int i = 0; i < gridEmpleadosT.Rows.Count; ++i)
            {
                num = Convert.ToDouble(gridEmpleadosT.Rows[i].Cells[6].Value);
                nombreEmp = Convert.ToString(gridEmpleadosT.Rows[i].Cells[2].Value);
                if (i == 0)
                {
                    mayor = Convert.ToDouble(num);
                    menor = Convert.ToDouble(num);
                    nombreEmpMa = Convert.ToString(nombreEmp);
                    nombreEmpMe = Convert.ToString(nombreEmp);
                }
                else
                {
                    if (Convert.ToDouble(num) > mayor)
                    {
                        mayor = Convert.ToDouble(num);
                        nombreEmpMa = Convert.ToString(nombreEmp);
                    }
                    if (Convert.ToDouble(num) < menor)
                    {
                        menor = Convert.ToDouble(num);
                        nombreEmpMe = Convert.ToString(nombreEmp);
                    }
                }
            }
            txtInfo.Text = "El Salario máximo para el turno temporal es: " + mayor + " y le corresponde a: " + nombreEmpMa +
                "\r\nEl Salario mínimo para el turno temporal es: " + menor + " y le corresponde a: " + nombreEmpMe;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            AccesoDatos.CConexion objConexion = new AccesoDatos.CConexion();
            objConexion.estableConexion();
        }

        private void btnCerrarCon_Click(object sender, EventArgs e)
        {
            AccesoDatos.CConexion conex = new AccesoDatos.CConexion();
            conex.cerrarConexion();
        }

        private void chkEmpD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gridEmpleadosD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void gridEmpleadosN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Elimina empleado diurno
        private void btnEliminarEmpD_Click_1(object sender, EventArgs e)
        {
            try
            {
                operaciones.EliminarEmpleadoDiurno(new Empresa.Entidades.DiurnoE(txtTurno.Text, int.Parse(txtID.Text),
                            txtNombre.Text, txtApellido1.Text, txtApellido2.Text, int.Parse(txtCedula.Text),
                            double.Parse(txtSalario.Text), txtCorreo.Text, int.Parse(txtCelular.Text),int.Parse(txtSeguro.Text), txtmotor.Text, txtplaca.Text));

                gridEmpleadosD.DataSource = null;
                gridEmpleadosD.DataSource = operaciones.RetornarEmpleadosDiurno();
                gridEmpleadosD.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("No hay empleado que eliminar");
            }
            Borrar();
        }

        //Para el reporte de la cantidad de empleados diurnos, nocturnos y total de la empresa.
        private void btnTotalE_Click_1(object sender, EventArgs e)
        {
            String Diurno = gridEmpleadosD.RowCount.ToString();
            String Nocturno = gridEmpleadosN.RowCount.ToString();
            String Vespertino = gridEmpleadosV.RowCount.ToString();
            txtInfo.Text = "La cantidad empleados según se detalla: " +
                "\r\nTotal de empleados del turno diurno: " + Diurno + "," +
                "\r\nTotal de empleados del turno nocturno: " + Nocturno + "," +
                "\r\nTotal de empleados del turno vespertino: " + Vespertino + "," +
                "\r\nTotal de empleados de la empresa:  " + (int.Parse(Diurno) + int.Parse(Nocturno) + int.Parse(Vespertino));
        }


        //Para los promedios salariales diurno, nocturno y general de la empresa.
        private void btnPromedios_Click_1(object sender, EventArgs e)
        {
            double suma = 0, suma2 = 0, suma3=0;
            int contador = 0, contador2 = 0, contador3 = 0;
            for (int i = 0; i < gridEmpleadosD.Rows.Count; ++i)
            {
                suma += Convert.ToDouble(gridEmpleadosD.Rows[i].Cells[6].Value);
                contador++;
            }
            for (int i = 0; i < gridEmpleadosN.Rows.Count; ++i)
            {
                suma2 += Convert.ToDouble(gridEmpleadosN.Rows[i].Cells[6].Value);
                contador2++;
            }
            for (int i = 0; i < gridEmpleadosV.Rows.Count; ++i)
            {
                suma3 += Convert.ToDouble(gridEmpleadosV.Rows[i].Cells[6].Value);
                contador3++;
            }

            double promedio1 = (suma / contador);
            // Math.Round(promedio1,2);
            double promedio2 = (suma2 / contador2);
            double promedio3 = (suma3 / contador3);

            double promedioGeneral = (promedio1 + promedio2 + promedio3) / (contador + contador2 + contador3);
            txtInfo.Text = "El promedio de los sueldos para los empleados del turno Diurno es:  " + Math.Round(promedio1, 2) +
                "\r\nEl promedio de los sueldos para los empleados del turno Nocturno es:  " + Math.Round(promedio2, 2) +
                "\r\nEl promedio de los sueldos para los empleados del turno Vespertino es:  " + Math.Round(promedio3, 2) +
                "\r\nEl promedio general de los sueldos para los empleados de la empresa es:  " + Math.Round(promedioGeneral, 2);
        }

        //Para aplicar método borrar y limpiar los campos de datos
        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            Borrar();
        }    

    }
}
