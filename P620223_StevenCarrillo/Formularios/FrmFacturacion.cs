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

            DtListaItems = MiFacturaLocal.CargarEsquemaListaDetalle();

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

            DgvLista.DataSource = DtListaItems;

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
                if (DtListaItems.Rows.Count > 0)
                {
                    DgvLista.DataSource = DtListaItems;
                    DgvLista.ClearSelection();

                    Totalizar();
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la fila", "Error Inesperado", MessageBoxButtons.OK);
                }              
            }

        }

        private void Totalizar()
        {
            decimal SubTotal = 0;
            decimal Descuentos = 0;
            decimal Impuestos = 0;
            decimal Total = 0;

            if (DtListaItems.Rows.Count > 0)
            {
                foreach (DataRow item in DtListaItems.Rows)
                {
                    //el += lo que hace es sumar al valor anterior un valor adicional
                    // sería lo mismo que hacer: SubTotal = Subtotal + algo
                    SubTotal += Convert.ToDecimal(item["SubTotal"]);
                    Descuentos += Convert.ToDecimal(item["DescuentoTotal"]);
                    Impuestos += Convert.ToDecimal(item["ImpuestosTotal"]);
                    Total += Convert.ToDecimal(item["TotalLinea"]);
                }
            }

            txtSubTotal.Text = string.Format("{0:N2}", SubTotal);
            txtDescuentos.Text = string.Format("{0:N2}", Descuentos);
            txtImpuestos.Text = string.Format("{0:N2}", Impuestos);
            txtTotal.Text = string.Format("{0:N2}", Total);
        }
        private bool ValidarFactura()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(lblClienteNombre.Text.Trim()) &&
                cboxTipoFactura.SelectedIndex > -1 &&
                DtListaItems.Rows.Count > 0)
            {
                R = true;
            }

            //TODO: validar casos contrarios con el else

            return R;

        }

        private void CargarDetalleFactura()
        {

            foreach (DataRow item in DtListaItems.Rows)
            {

                Logica.Models.FacturaInventario detalle = new Logica.Models.FacturaInventario();

                detalle.MiInventario.IDInventario = Convert.ToInt32(item["IDInventario"]);
                detalle.Costo = 0; //TODO: deberíamos agregar el valor del costo, se puede hacer por medio de una función
                detalle.PrecioVenta = Convert.ToDecimal(item["PrecioVenta"]);
                detalle.Cantidad = Convert.ToDecimal(item["Cantidad"]);
                detalle.PorcentajeImpuesto = Convert.ToDecimal(item["TasaImpuesto"]);

                detalle.PorcentajeDescuento = Convert.ToDecimal(item["PorcentajeDescuento"]);
                detalle.SubTotal = Convert.ToDecimal(item["SubTotal"]);
                detalle.DescuentoTotal = Convert.ToDecimal(item["DescuentoTotal"]);
                detalle.SubTotal2 = Convert.ToDecimal(item["SubTotal2"]);
                detalle.ImpuestosTotal = Convert.ToDecimal(item["ImpuestosTotal"]);
                detalle.TotalLinea = Convert.ToDecimal(item["TotalLinea"]);

                //una vez llenamos los datos del detalle se agrega a la factura local.

                MiFacturaLocal.Detalle.Add(detalle);

            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //validar requerimientos mínimos 
            if (ValidarFactura())
            {
                //cuando tenemos una estructura de encabezado-detalle 
                //como la factura, primero debemos agreagar el encabezado
                //en su tabla respectiva y obtener el ID que se genera 
                //en el PK. 
                //Luego usando ese ID se recorre la lista del detalle 
                //y se hace el insert en la tabla de detalle con FK = ID

                MiFacturaLocal.MiFacturaTipo.IDFacturaTipo = Convert.ToInt32(cboxTipoFactura.SelectedValue);
                MiFacturaLocal.MiCliente.IDCliente = Convert.ToInt32(txtClienteID.Text.Trim());
                //como el nombre del clientes o el nombre del tipo de factura no son necesarios para hacer el Insert
                //se pueden omitir en este punto. 

                MiFacturaLocal.MiUsuario.IDUsuario = Globales.MiUsuarioGlobal.IDUsuario;

                MiFacturaLocal.Notas = txtNotas.Text.Trim();

                CargarDetalleFactura();

                if (MiFacturaLocal.Agregar() > 0)
                {

                    MessageBox.Show("Factura procesada correctamente!", ":)", MessageBoxButtons.OK);

                    //TODO: Presentar gráficamente un reporte de la factura en formato POS (punto de venta) 

                    Limpiar();

                }



            }
        }
    }
}
