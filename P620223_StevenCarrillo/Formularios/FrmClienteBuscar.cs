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
    public partial class FrmClienteBuscar : Form
    {

        DataTable DtLista { get; set; }
        Logica.Models.Cliente MiClienteLocal { get; set; }  

        public FrmClienteBuscar()
        {
            InitializeComponent();
            DtLista = new DataTable();

            MiClienteLocal = new Logica.Models.Cliente();
        }

        private void FrmClienteBuscar_Load(object sender, EventArgs e)
        {

            LlenarLista();

        }

        private void LlenarLista()
        {
            DtLista = new DataTable();
            DtLista = MiClienteLocal.Listar(true, txtBuscar.Text.Trim());

            dgvLista.DataSource = DtLista;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Count() > 2 || string.IsNullOrEmpty(txtBuscar.Text.Trim()))
            {
                LlenarLista();
            }
         
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count == 1)
            {
                DataGridViewRow FilaSelected = dgvLista.SelectedRows[0];

                int IdCliente = Convert.ToInt32(FilaSelected.Cells["CIDCliente"].Value);

                Globales.MiFormFacturas.txtClienteID.Text = Convert.ToString(IdCliente);

                this.DialogResult = DialogResult.OK;

            }
        }
    }
}
