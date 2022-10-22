﻿using System;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //TODO: se debe validar el ingreso del usuario
            //si la validacion es correcta permitiria dejar ingresar al usuario al sistema principal 
            Globales.MiformPrincipal.Show();
            this.Hide();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //cierra completamente la app
            Application.Exit();
        }

        private void btnVerPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtContrasennia.UseSystemPasswordChar = false;   
        }

        private void btnVerPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtContrasennia.UseSystemPasswordChar = true;
        }

 
    }
}
