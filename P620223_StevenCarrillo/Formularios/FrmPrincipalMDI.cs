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
    public partial class FrmPrincipalMDI : Form
    {
        public FrmPrincipalMDI()
        {
            InitializeComponent();
        }

        private void FrmPrincipalMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            //al cerrar el formulario principal se deberia de deterner por completo la App
            //en el caso de lo que cerramos es volver a mostrar ek form de login 
            // deberiamos agrecia un objeto global para dicho formulario
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //en el caso del form de gestión de usuarios es necesario establecerlo 
            // en variables globales

            //si queremos que un formulario se muestre solo una vez deberiamos 
            // de verificar que este visible o no, y en caso de que lo este se reinstancia de nuevo y se muestra

            // el simbolo ! indica negacion, niega una condicion logica
            if (!Globales.MiFormMantUsuarios.Visible)
            {
                Globales.MiFormMantUsuarios = new FrmUsuariosGestion();
                Globales.MiFormMantUsuarios.Show();
            }

            
        }

        private void FrmPrincipalMDI_Load(object sender, EventArgs e)
        {
            //mostrar usuario logueado
            string InfoUsuario = string.Format("{0} ({1})",
                Globales.MiUsuarioGlobal.Nombre,
                Globales.MiUsuarioGlobal.MiUsuarioRol.Rol);
            lblUsuarioLogueado.Text = InfoUsuario;

            //se debe filtrar las opciones de acceso a menu segun el rol que se tenga

            switch (Globales.MiUsuarioGlobal.MiUsuarioRol.IDUsuarioRol)
            {
                case 1:
                    //No hace falta ocultar opciones ya que es admin

                    break;
                case 2:
                    //seria tipo bodeguero
                    mnuProcesos.Visible = false;

                    mnuUsuariosGestion.Visible = false;
                    mnuClientesGestion.Visible = false;
                    mnuImpuestosGestion.Visible = false;

                    mnuListadoClientes.Visible = false;
                    mnuFacturacion.Visible = false;
                    mnuVentasCliente.Visible = false;
                    mnuVentasRangoFechas.Visible = false;
                    mnuVentasUsuario.Visible = false;
                  
                    mnuFacturasReimpresion.Visible = false; 

                    break;
                case 3:
                    //seria tipo facturador

                    mnuUsuariosGestion.Visible = false;
                    mnuImpuestosGestion.Visible = false;
                    mnuInventariosGestion.Visible = false;
                    mnuCategoriasGestion.Visible = false;
                    mnuProveedoresGestion.Visible = false;
                  
                    mnuListadoProveedores.Visible = false;

                    break;
            }

            tmrFechaHora.Enabled = true;

        }

        private void tmrFechaHora_Tick(object sender, EventArgs e)
        {
            //asignar al label de fecha y hora el valor en formato extendido de la fecha 
            // y ademas la hora

            string fecha = DateTime.Now.Date.ToLongDateString();
            string hora = DateTime.Now.ToLongTimeString();

            lblFechaHora.Text = fecha + " / " + hora;
        }

        private void mnuFacturacion_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormFacturas.Visible)
            {
                Globales.MiFormFacturas = new FrmFacturacion();
                Globales.MiFormFacturas.Show();
            }
        }
    }
}
