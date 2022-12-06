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
    public partial class FrmInventarioBuscar : Form
    {

        public DataTable DtLista { get; set; }
        public Logica.Models.Inventario MyLocalItem { get; set; }


        #region PropiedadesDeTotalizacion
        public decimal SubTotal { get; set; }
        public decimal TotalDescuento { get; set; }
        public decimal SubTotal2 { get; set; }
        public decimal TotalImpuesto { get; set; }
        public decimal Total { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal TasaImpuesto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        #endregion


        public FrmInventarioBuscar()
        {
            InitializeComponent();

            DtLista = new DataTable();
            MyLocalItem = new Logica.Models.Inventario();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmInventarioBuscar_Load(object sender, EventArgs e)
        {
            CargarItems();
        }

        private void CargarItems()
        {
            DtLista = MyLocalItem.Listar();

            dgvLista.DataSource = DtLista;
            dgvLista.ClearSelection();
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Limpiar();

            if (dgvLista.SelectedRows.Count == 1)
            {
                DataGridViewRow fila = dgvLista.SelectedRows[0];

                decimal Precio = Convert.ToDecimal(fila.Cells["CPrecioVenta"].Value);
                decimal IVA = Convert.ToDecimal(fila.Cells["CTasaImpuesto"].Value);

                txtIVA.Text = IVA.ToString();
                txtPrecioUnitario.Text = Precio.ToString();

                Calcular();
            }
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescuento.Text.Trim()))
            {
                txtDescuento.Text = "0";
                txtDescuento.SelectAll();
            }
        }

        private void txtDescuento_Leave(object sender, EventArgs e)
        {
            if (ValidarDescuento())
            {
                Calcular();
            }
            
        }

        private void nudCantidad_Leave(object sender, EventArgs e)
        {
            if (ValidarDescuento())
            {
                Calcular();
            }
        }

        private void Calcular()
        {
            //este metodo calcula los valores de subtotal, descuento, impuesto y total para la linea
            // en este caso particular se debe validar que el descuento no syupere el; 100 %

            if (ValidarDescuento())
            {
           

                Cantidad = Convert.ToDecimal(nudCantidad.Value);
                PorcentajeDescuento = Convert.ToDecimal(txtDescuento.Text.Trim());

                PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text.Trim());
                TasaImpuesto = Convert.ToDecimal(txtIVA.Text.Trim());

                //1. Calculo de subtotal
                SubTotal = Cantidad * PrecioUnitario;
                if (PorcentajeDescuento > 0)
                {
                    TotalDescuento = (SubTotal * PorcentajeDescuento) / 100;
                }

                SubTotal2 = SubTotal - TotalDescuento;
                if (TasaImpuesto > 0)
                {
                    TotalImpuesto = (SubTotal2 * TasaImpuesto) / 100;
                }

                Total = SubTotal2 + TotalImpuesto;

                txtTotal.Text = String.Format("{0:N2}", Total);//SUSTITUYE POR un formato de currency 2 decimales

            }

        }

        private void Limpiar()
        {
            SubTotal = 0;
            TotalDescuento = 0;
            SubTotal2 = 0;
            TotalImpuesto = 0;
            Total = 0;
            PrecioUnitario = 0;
            TasaImpuesto = 0;
            Cantidad = 0;
            PorcentajeDescuento = 0;

            nudCantidad.Value = 1;
            txtPrecioUnitario.Text = "0";
            txtDescuento.Text = "0";
            txtIVA.Text = "0";
            txtTotal.Text = "0";    

        }

        private bool ValidarDescuento()
        {
            bool R = false;

            try
            {
                if (!string.IsNullOrEmpty(txtDescuento.Text.Trim()) &&
                    Convert.ToDecimal(txtDescuento.Text.Trim()) >= 0 &&
                    Convert.ToDecimal(txtDescuento.Text.Trim()) <= 100)
                {
                    R = true;
                }
                else
                {
                    if (Convert.ToDecimal(txtDescuento.Text.Trim()) > 100)
                    {
                        MessageBox.Show("Los Descuentos No pueden ser superiores a 100",
                            "Error de Validacion", MessageBoxButtons.OK);
                        return false;
                    }

                    if (Convert.ToDecimal(txtDescuento.Text.Trim()) < 0)
                    {
                        MessageBox.Show("Los Descuentos No pueden ser Inferiores a 0",
                            "Error de Validacion", MessageBoxButtons.OK);
                        return false;
                    }
                }
       
                
            }
            catch (Exception)
            {

                txtDescuento.Text = "0";
                txtDescuento.SelectAll();
            }

            return R;
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, false);
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count == 1 &&
                !string.IsNullOrEmpty(txtTotal.Text.Trim()) &&
                Convert.ToDecimal(txtTotal.Text.Trim()) > 0)
            {
                DataGridViewRow r = dgvLista.SelectedRows[0];

                //estos dos valores se leen directamente de la selección del dgvLista
                //los demás ya los teníamos calculados en la props locales de totalización 

                int IdItem = Convert.ToInt32(r.Cells["CIDInventario"].Value);
                string NombreItem = Convert.ToString(r.Cells["CNombreItem"].Value);

                DataRow NuevaFilaEnFacturacion = Globales.MiFormFacturas.DtListaItems.NewRow();


                NuevaFilaEnFacturacion["IDInventario"] = IdItem;
                NuevaFilaEnFacturacion["NombreItem"] = NombreItem;
                NuevaFilaEnFacturacion["PrecioVenta"] = PrecioUnitario;

                NuevaFilaEnFacturacion["Cantidad"] = Cantidad;
                NuevaFilaEnFacturacion["TasaImpuesto"] = TasaImpuesto;
                NuevaFilaEnFacturacion["PorcentajeDescuento"] = PorcentajeDescuento;
                NuevaFilaEnFacturacion["SubTotal"] = SubTotal;
                NuevaFilaEnFacturacion["SubTotal2"] = SubTotal2;
                NuevaFilaEnFacturacion["ImpuestosTotal"] = TotalImpuesto;
                NuevaFilaEnFacturacion["TotalLinea"] = Total;
                NuevaFilaEnFacturacion["DescuentoTotal"] = TotalDescuento;

                Globales.MiFormFacturas.DtListaItems.Rows.Add(NuevaFilaEnFacturacion);
                                          
                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
