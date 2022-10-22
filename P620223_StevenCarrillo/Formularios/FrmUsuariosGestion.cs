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

namespace P620223_StevenCarrillo.Formularios
{
    public partial class FrmUsuariosGestion : Form
    {
        private Logica.Models.Usuario MiUsuarioLocal { get; set; }
        private Logica.Models.Empresa MiEmpresaLocal { get; set; }


        public FrmUsuariosGestion()
        {
            InitializeComponent();
            MiUsuarioLocal = new Logica.Models.Usuario();   
            MiEmpresaLocal = new Logica.Models.Empresa();

        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            //pre carga codigo una vez se inicia el formulario
            //establecer como padre el formulario principal de forma de que se anide dentro del mismo
            MdiParent = Globales.MiformPrincipal;

            CargarRolesDeUsuario();//llamamos los roles al combo
            CargarEmpresas();
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
            Logica.Models.Usuario MiUsuario = new Logica.Models.Usuario();

            MiUsuario.Nombre = txtNombre.Text.Trim();
            MiUsuario.Cedula = txtCedula.Text.Trim();
            MiUsuario.NombreUsuario = txtNombreUsuario.Text.Trim();
            MiUsuario.Email = txtCorreo.Text.Trim();
            MiUsuario.Contrasennia = txtContrasennia.Text.Trim();
            MiUsuario.MiUsuarioRol.IDUsuarioRol = (int)cboxIDUsuarioRol.SelectedValue;
            MiUsuario.MiEmpresa.IDEmpresa = (int)cboxEmpresa.SelectedValue;

            if (MiUsuario.Agregar())
            {
                txtNombre.Text = null; 
                txtCedula.Text = null;
                txtNombreUsuario.Text = null;
                txtCorreo.Text = null;
                txtContrasennia.Text = null;
            }
        }
    }
}
