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
    public partial class FrmFacturacion : Form
    {

        //Objetos locales
        public Logica.Models.Factura MiFacturaLocal { get; set; }

        public DataTable DtListaItems { get; set; }



        public FrmFacturacion()
        {
            InitializeComponent();
            MiFacturaLocal = new Logica.Models.Factura();

            DtListaItems = new DataTable();

        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {

            MdiParent = Globales.MiformPrincipal;
            LlenarComBoTiposFactura();

            Limpiar();
        }

        private void Limpiar()
        {
            txtClienteID.Clear();
            lblClienteNombre.Text = String.Empty;
            txtNotas.Clear();
            cboxTipoFactura.SelectedIndex = -1;
            txtSubTotal.Text = "0";
            txtDescuentos.Text = "0";
            txtImpuestos.Text = "0";
            txtTotal.Text = "0";

            DtListaItems = MiFacturaLocal.CargarEsquemaListaDetalle();

            dgvLista.DataSource = DtListaItems;

        }

        private void LlenarComBoTiposFactura()
        {
            DataTable dt = new DataTable();

            dt = MiFacturaLocal.MiFacturaTipo.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                cboxTipoFactura.ValueMember = "ID";
                cboxTipoFactura.DisplayMember = "D";

                cboxTipoFactura.DataSource = dt;

                cboxTipoFactura.SelectedIndex = -1;
            }


        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            //se crea una nueva instancia del form de busqueda de cliente
            //y se espera una respuesta del mismo

            Form FormBusquedaCliente = new FrmClienteBuscar();

            DialogResult resp = FormBusquedaCliente.ShowDialog();

            if (resp == DialogResult.OK)
            {
                //cargar la info del cliente en la composicion de
                //factura local y mostrar el nombre del usuario en el label 

                if (!string.IsNullOrEmpty(txtClienteID.Text.Trim()))
                {
                    int IdCliente = Convert.ToInt32(txtClienteID.Text.Trim());

                    //se incluye los datos en la composicion del cliente 
                    MiFacturaLocal.MiCliente = MiFacturaLocal.MiCliente.ConsultarPorID(IdCliente);

                    if (MiFacturaLocal.MiCliente != null && MiFacturaLocal.MiCliente.IDCliente > 0)
                    {
                        lblClienteNombre.Text = MiFacturaLocal.MiCliente.Nombre.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el dato del cliente", "Error", MessageBoxButtons.OK);
                }

            }
        }

        private void mnuAgregarProducto_Click(object sender, EventArgs e)
        {
            Form FormBuscarItem = new FrmInventarioBuscar();

            DialogResult resp = FormBuscarItem.ShowDialog();

            if (resp == DialogResult.OK)
            {
                //TODO totalizar
                dgvLista.DataSource = DtListaItems;
            }

        }
    }
}
