namespace P620223_StevenCarrillo.Formularios
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnIngresar;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVerPassword = new System.Windows.Forms.Button();
            this.lblRecuperarContrasennia = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContrasennia = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIngresoDirecto = new System.Windows.Forms.Button();
            btnIngresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = System.Drawing.Color.Lime;
            btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnIngresar.ForeColor = System.Drawing.Color.White;
            btnIngresar.Location = new System.Drawing.Point(169, 219);
            btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(232, 40);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIngresoDirecto);
            this.panel1.Controls.Add(this.btnVerPassword);
            this.panel1.Controls.Add(this.lblRecuperarContrasennia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtContrasennia);
            this.panel1.Controls.Add(this.txtNombreUsuario);
            this.panel1.Controls.Add(btnIngresar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(10, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 281);
            this.panel1.TabIndex = 0;
            // 
            // btnVerPassword
            // 
            this.btnVerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPassword.Location = new System.Drawing.Point(408, 134);
            this.btnVerPassword.Name = "btnVerPassword";
            this.btnVerPassword.Size = new System.Drawing.Size(47, 26);
            this.btnVerPassword.TabIndex = 4;
            this.btnVerPassword.Text = "Ver";
            this.btnVerPassword.UseVisualStyleBackColor = true;
            this.btnVerPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVerPassword_MouseDown);
            this.btnVerPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnVerPassword_MouseUp);
            // 
            // lblRecuperarContrasennia
            // 
            this.lblRecuperarContrasennia.AutoSize = true;
            this.lblRecuperarContrasennia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperarContrasennia.LinkColor = System.Drawing.Color.Gold;
            this.lblRecuperarContrasennia.Location = new System.Drawing.Point(246, 164);
            this.lblRecuperarContrasennia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecuperarContrasennia.Name = "lblRecuperarContrasennia";
            this.lblRecuperarContrasennia.Size = new System.Drawing.Size(155, 16);
            this.lblRecuperarContrasennia.TabIndex = 5;
            this.lblRecuperarContrasennia.TabStop = true;
            this.lblRecuperarContrasennia.Text = "Olvidé mi Contraseña";
            this.lblRecuperarContrasennia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtContrasennia
            // 
            this.txtContrasennia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasennia.Location = new System.Drawing.Point(24, 134);
            this.txtContrasennia.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasennia.Name = "txtContrasennia";
            this.txtContrasennia.Size = new System.Drawing.Size(377, 26);
            this.txtContrasennia.TabIndex = 1;
            this.txtContrasennia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContrasennia.UseSystemPasswordChar = true;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtNombreUsuario.Location = new System.Drawing.Point(24, 54);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(377, 26);
            this.txtNombreUsuario.TabIndex = 0;
            this.txtNombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(24, 219);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(137, 40);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::P620223_StevenCarrillo.Properties.Resources.Factura;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(472, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 281);
            this.panel2.TabIndex = 1;
            // 
            // btnIngresoDirecto
            // 
            this.btnIngresoDirecto.Location = new System.Drawing.Point(24, 261);
            this.btnIngresoDirecto.Name = "btnIngresoDirecto";
            this.btnIngresoDirecto.Size = new System.Drawing.Size(75, 23);
            this.btnIngresoDirecto.TabIndex = 8;
            this.btnIngresoDirecto.Text = "Ingresar";
            this.btnIngresoDirecto.UseVisualStyleBackColor = true;
            this.btnIngresoDirecto.Visible = false;
            this.btnIngresoDirecto.Click += new System.EventHandler(this.btnIngresoDirecto_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(750, 305);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lblRecuperarContrasennia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContrasennia;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVerPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnIngresoDirecto;
    }
}