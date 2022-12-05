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
        #endregion


        public FrmInventarioBuscar()
        {
            InitializeComponent();

            DtLista = new DataTable();
            MyLocalItem = new Logica.Models.Inventario();

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

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
            if (dgvLista.SelectedRows.Count == 1)
            {
                DataGridViewRow fila = dgvLista.SelectedRows[0];

                decimal Precio = Convert.ToDecimal(fila.Cells["CPrecioVenta"]);
                decimal IVA = Convert.ToDecimal(fila.Cells["CTasaImpuesto"]);

                txtIVA.Text = IVA.ToString();
                txtPrecioUnitario.Text = Precio.ToString();

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

        }

        private void Calcular()
        {
            //este metodo calcula los valores de subtotal, descuento, impuesto y total para la linea
            // en este caso particular se debe validar que el descuento no syupere el; 100 %

            if (ValidarDescuento())
            {




            }

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
    }
}
