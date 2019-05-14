using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaDTO;
using CapaServicios;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtRut.Text) && String.IsNullOrEmpty(txtNombre.Text))
            {
                btnEditar.Text = "Buscar Primero!";
                btnEditar.Enabled = false;
            }
            else if (btnBuscar!=null)
            {
                btnEditar.Text = "Editar Cliente";
                btnEditar.Enabled = true;
            }

            this.ListaClientes.Refresh();
            this.ListaClientes.Update();

        }

        //INSERTAR CLIENTE
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            WebServiceConsultas servicio = new WebServiceConsultas();
            Cliente c = new Cliente();
            c.Rut = Convert.ToString(txtRut.Text);
            c.Nombre = Convert.ToString(txtNombre.Text);
            if (this.ProtecSqlInyeccion() == true)
            {
                lbl1.Text = "No esta permitidos los caracteres (',=) en el cuadro de texto";               
            }
            else
            {
                try
                {
                    if(String.IsNullOrEmpty(this.txtRut.Text.Trim()))
                    {
                        txtRut.Text = "Ingrese Rut!";
                    }
                    if (String.IsNullOrEmpty(this.txtRut.Text.Trim()))
                    {
                        txtNombre.Text = "Ingrese Nombre!";
                    }
                    if (c.Rut != Convert.ToString(servicio.ComprobarExistencia(txtRut.Text)) && this.validarRut(txtRut.Text))
                        {                    
                            servicio.insertarCl(c);
                            MessageBox.Show("Cliente Ingresado con Exito!");
                            this.limpiarCampos();
                            this.label1.Text = "*";
                        } else
                        {
                            MessageBox.Show("No se pudo ingresar el Usuario!, verifique el rut");
                        }   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la BD!: " + ex.Message);
                }
            }

        }

        //BUSCAR CLIENTE
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ProtecSqlInyeccion()==true)
                {
                    lbl1.Text = "No esta permitidos los caracteres (',=) en el cuadro de texto";
                }
                else
                {
                    if(this.validarRut(txtRut.Text))
                    {
                        WebServiceConsultas auxServicio = new WebServiceConsultas();
                        txtNombre.Text = auxServicio.buscarRut(txtRut.Text);
                        btnEditar.Enabled = true;
                    }                    
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //EDITAR CLIENTE
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Debe buscar al usuario por su rut antes de actualizarlo");
                }
                if (String.IsNullOrEmpty(txtRut.Text))
                {
                    MessageBox.Show("Debe ingresar un rut valido para buscar y luego actualizar al cliente");
                }
                if(this.ProtecSqlInyeccion()==true)
                {
                    lbl1.Text = "No esta permitidos los caracteres (',=) en el cuadro de texto";
                }
                else
                {
                    WebServiceConsultas auxWS = new WebServiceConsultas();
                    Cliente c = new Cliente();
                    c.Rut = txtRut.Text;
                    c.Nombre = txtNombre.Text;
                    auxWS.actualizarCli(c);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo actualizar el cliente, error: "+ ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtRut.Text)|| this.ProtecSqlInyeccion()==true)
            {
                lbl1.Text = "No esta permitidos los caracteres (',=) en el cuadro de texto";
                MessageBox.Show("Debe ingresar un Rut para poder eliminar el cliente ");
            }
            else
            {
                try
                {
                    WebServiceConsultas auxServicio = new WebServiceConsultas();
                    auxServicio.eliminarCli(txtRut.Text);
                    this.limpiarCampos();

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void limpiarCampos()
        {
            txtRut.Clear();
            txtNombre.Clear();
        }

        private bool ProtecSqlInyeccion()
        {
            if (txtNombre.Text.Contains("'") || txtNombre.Text.Contains("=") ||
               txtRut.Text.Contains("'") || txtRut.Text.Contains("="))
            {
                txtNombre.Clear();
                txtRut.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool validarRut(string rut)
        {

            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.ListaClientes.Refresh();
            this.ListaClientes.Update();
        }
    }
}
