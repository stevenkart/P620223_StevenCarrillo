using Logica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace P620223_StevenCarrillo.Formularios
{
    public partial class FrmUsuariosGestion : Form
    {
        private Logica.Models.Usuario MiUsuarioLocal { get; set; }
        private DataTable ListaUsuarios { get; set; }

        public FrmUsuariosGestion()
        {
            InitializeComponent();
            MiUsuarioLocal = new Logica.Models.Usuario();
            ListaUsuarios = new DataTable();

        }
        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            //pre carga codigo una vez se inicia el formulario
            //establecer como padre el formulario principal de forma de que se anide dentro del mismo
            MdiParent = Globales.MiformPrincipal;
            //llamamos los roles al combo
            CargarRolesDeUsuario();
            CargarEmpresas();
            LlenarListaUsuarios();


        }

        private void LlenarListaUsuarios()
        {
            ListaUsuarios = new DataTable();
            ListaUsuarios = MiUsuarioLocal.Listar(chActivos.Checked, txtBuscar.Text.Trim());

            dgvLista.DataSource = ListaUsuarios;
        }

        private void CargarRolesDeUsuario()
        {
            //Paso 1 y 1.1 de Seq Usuario Rol Lista
            Logica.Models.UsuarioRol MiRolUsuario = new Logica.Models.UsuarioRol();
            // paso 2, 2.5
            DataTable dt = new DataTable();
            dt = MiRolUsuario.Listar();

            //PASO 3
            if (dt != null && dt.Rows.Count > 0)
            {
                cboxIDUsuarioRol.ValueMember = "IDUsuarioRol"; // lo que selecciona
                cboxIDUsuarioRol.DisplayMember = "Rol"; // lo que se muestra
                cboxIDUsuarioRol.DataSource = dt;
                cboxIDUsuarioRol.SelectedIndex = -1;
            }
        }
        private void CargarEmpresas()
        {
            //Paso de instanciar
            Logica.Models.Empresa MiEmpresa = new Logica.Models.Empresa();

            DataTable dt = new DataTable();
            dt = MiEmpresa.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                cboxEmpresa.ValueMember = "Id"; // lo que selecciona
                cboxEmpresa.DisplayMember = "D"; // lo que se muestra
                cboxEmpresa.DataSource = dt;
                cboxEmpresa.SelectedIndex = -1;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            //lo primero que se debe hacer es validar que los datos minimos necesario estan compeltos

            //luego, se procede a realizar las 3 validaciones que se indican por medio de los include (uses) en el
            //diagrama en el caso de uso extendido
            //y si las 3 validaciones son NEGATIVAS se tiene permiso para agregar el usuario

            if (validarCamposRequeridos())//los campos estan completos if its TRUE
            {
                //se crear un usuario local y se agrega los valos de los atributos
                MiUsuarioLocal = new Logica.Models.Usuario();

                MiUsuarioLocal.Nombre = txtNombre.Text.Trim();
                MiUsuarioLocal.Cedula = txtCedula.Text.Trim();
                MiUsuarioLocal.NombreUsuario = txtNombreUsuario.Text.Trim();
                MiUsuarioLocal.Email = txtCorreo.Text.Trim();
                MiUsuarioLocal.Contrasennia = txtContrasennia.Text.Trim();
                /* Una forma rapida de conversion del cbox
                MiUsuarioLocal.MiUsuarioRol.IDUsuarioRol = (int)cboxIDUsuarioRol.SelectedValue;
                MiUsuarioLocal.MiEmpresa.IDEmpresa = (int)cboxEmpresa.SelectedValue;
                */
                MiUsuarioLocal.MiUsuarioRol.IDUsuarioRol = Convert.ToInt32(cboxIDUsuarioRol.SelectedValue);
                MiUsuarioLocal.MiEmpresa.IDEmpresa = Convert.ToInt32(cboxEmpresa.SelectedValue);

                //si las 3 validaciones son NEGATIVAS se tiene permiso para agregar el usuario
                bool CPorCedula = MiUsuarioLocal.ConsultarPorCedula();
                bool CPorNombreUsuario = MiUsuarioLocal.ConsultarPorNombreUsuario();
                bool CPorCorreo = MiUsuarioLocal.ConsultarPorEmail();


                if (!CPorCedula && !CPorNombreUsuario && !CPorCorreo)
                {
                    string Msg = string.Format("¿Esta Seguro de agregar al usuario: {0} ?", MiUsuarioLocal.NombreUsuario);
                    DialogResult respuesta = MessageBox.Show(Msg, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        //si las tres validaciones son negativas agregamos el usuario
                        bool ok = MiUsuarioLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Usuario Agregado Correctamente!!!", " :", MessageBoxButtons.OK);

                            LimpiarForm();
                        }
                        else
                        {
                            MessageBox.Show("Usuario No agregado", " :(", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    if (CPorCedula)
                    {
                        MessageBox.Show("Ya existe un usuario con la cédula digitada en el sistema", "Error de Validación", MessageBoxButtons.OK);
                        return;
                    }
                    if (CPorNombreUsuario)
                    {
                        MessageBox.Show("Ya existe un usuario con el Nombre de Usuario digitado en el sistema", "Error de Validación", MessageBoxButtons.OK);
                        return;
                    }
                    if (CPorCorreo)
                    {
                        MessageBox.Show("Ya existe un usuario con el Email digitado en el sistema", "Error de Validación", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
        }

        //metodo que valida los campos requerido
        private bool validarCamposRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(txtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(txtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(txtNombreUsuario.Text.Trim()) &&
                !string.IsNullOrEmpty(txtCorreo.Text.Trim()) &&
                !string.IsNullOrEmpty(txtContrasennia.Text.Trim()) &&
                !string.IsNullOrEmpty(txtConfirmContrasennia.Text.Trim()) &&
                cboxIDUsuarioRol.SelectedIndex > -1 &&
                cboxEmpresa.SelectedIndex > -1)
            {
                R = true;
            }
            else
            {
                //se le informa al usuario qu validacion esta fallando
                //estas validaciones deben ser puntuales para informar al usuario que falla 

                if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el nombre", "Error de Validación!", MessageBoxButtons.OK);
                    txtNombre.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la cédula", "Error de Validación!", MessageBoxButtons.OK);
                    txtCedula.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtNombreUsuario.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el Nombre de Usuario", "Error de Validación!", MessageBoxButtons.OK);
                    txtNombreUsuario.Focus();
                    return false;

                }
                if (string.IsNullOrEmpty(txtCorreo.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el Correo", "Error de Validación!", MessageBoxButtons.OK);
                    txtCorreo.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtContrasennia.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la contraseñia", "Error de Validación!", MessageBoxButtons.OK);
                    txtContrasennia.Focus();
                    return false;
                }
                //validaciones combo box
                if (cboxIDUsuarioRol.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un Rol al Usuario", "Error de Validación!", MessageBoxButtons.OK);
                    cboxIDUsuarioRol.Focus();
                    return false;
                }
                if (cboxEmpresa.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una Empresa", "Error de Validación!", MessageBoxButtons.OK);
                    cboxEmpresa.Focus();
                    return false;
                }
            }
            return R;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void LimpiarForm()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCedula.Clear();
            txtNombreUsuario.Clear();
            txtCorreo.Clear();
            txtContrasennia.Clear();
            txtConfirmContrasennia.Clear();

            cboxIDUsuarioRol.SelectedIndex = -1;
            cboxEmpresa.SelectedIndex = -1;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true, false);
        }
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);
        }
        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, false, true);
        }
        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, false, true);
        }

        

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscar.Text.Trim()) && txtBuscar.Text.Count() > 2)
            {
                LlenarListaUsuarios();
            }
            else if (string.IsNullOrEmpty(txtBuscar.Text.Trim()))
            {
                LlenarListaUsuarios();
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCorreo.Text.Trim()))
            {
                if (!Validaciones.IsValidEmail(txtCorreo.Text.Trim()))
                {
                    MessageBox.Show("Email ingresado no posee un formato correcto, debe llevar @ y el dominio correspondiente");
                    txtCorreo.Focus();
                }
            }
       
        }

        private void txtContrasennia_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtContrasennia.Text.Trim()))
            {
                Validaciones.IsValidPass(txtContrasennia.Text.Trim());
                txtContrasennia.Focus();
            }
            
   
        }
    }
}
