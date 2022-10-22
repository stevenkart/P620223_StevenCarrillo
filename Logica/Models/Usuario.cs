using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Logica.Models
{
    public class Usuario
    {
        // Propiedades Simples
        public int IDUsuario { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasennia { get; set; }
        public string CodigoRecuperacion { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }

        // Propiedades Complejas
        public Empresa MiEmpresa { get; set; }
        public UsuarioRol MiUsuarioRol { get; set; }

        //Constructor
        public Usuario()
        {
            MiEmpresa = new Empresa();
            MiUsuarioRol = new UsuarioRol();
            Activo = true;
        }

        //Funciones y metodos
        //Ahora se escribe las funciones y metodos(operaciones)

        public bool Agregar()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //INSERT correspondiente y retornar TRUE si 
            // TODO sale bien
            bool R = false;

            Conexion MiCnn = new Conexion();
            //debemos pasar la lista parametros para el insert

            MiCnn.ListaParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn.ListaParametros.Add(new SqlParameter("@NombreUsuario", this.NombreUsuario));

            //TODO: SE DEBE ENCRIPTAR CONTRASENNIA
            MiCnn.ListaParametros.Add(new SqlParameter("@Contrasennia", this.Contrasennia));
            MiCnn.ListaParametros.Add(new SqlParameter("@Email", this.Email));

            //PARAMETROS PARA LOS FK, NORMALMENTE SON DE OBJETOS COMPUESTOS DE LA CLASE
            MiCnn.ListaParametros.Add(new SqlParameter("@IDUsuarioRol", this.MiUsuarioRol.IDUsuarioRol));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDEmpresa", this.MiEmpresa.IDEmpresa));

            //ahora se llama el SP 

            int Resultado = MiCnn.EjecutarUpdateDeleteInsert("SPUsuarioAgregar");

            if (Resultado > 0)
            {
                R = true;
                MessageBox.Show("Usuario Creado Correctamente!", "Agregar Usuario");

            }
            else
            {
                MessageBox.Show("Usuario no se pudo crear!", "Agregar Usuario");
            }

            return R;

        }
        public bool Modificar()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //UPDATE correspondiente y retornar TRUE si 
            // TODO sale bien
            bool R = false;

            return R;

        }
        public bool Eliminar()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //DELETE -> UPDATE correspondiente y retornar TRUE si 
            // TODO sale bien
            // SE HACEN ELIMINACIONES LOGICAS, LO QUE HAREMOS SERA CAMBIAR EL VALOR DE CAMPO 
            //ACTIVO A FALSE
            bool R = false;

            return R;

        }

        public Usuario ConsultarPorID()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //SELECT correspondiente y retornar del mismo tipo de la clase
            // TODO sale bien entregue un select
            Usuario R = new Usuario();






            return R;

        }
        public bool ConsultarPorCedula()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //SELECT correspondiente y retornar TRUE si 
            // TODO sale bien

            //todo listo****


            bool R = false;

            Conexion MiCnn =  new Conexion();
            //debemos pasar 1 parametro al SP DE CONSULTA
            //en el sql parametro se adjunta el parametro de SP
            MiCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));

            //ahora se llama el SP 

            DataTable Consulta = MiCnn.EjecutarSelect("SPUsuarioConsultarPorCedula");

            if (Consulta != null && Consulta.Rows.Count > 0)
            {
                R = true;

            }

            return R;

        }
        public bool ConsultarPorNombreUsuario()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //SELECT correspondiente y retornar TRUE si 
            // TODO listo ****


            bool R = false;

            Conexion MiCnn = new Conexion();
            //debemos pasar 1 parametro al SP DE CONSULTA
            //en el sql parametro se adjunta el parametro de SP
            MiCnn.ListaParametros.Add(new SqlParameter("@NombreUsuario", this.NombreUsuario));

            //ahora se llama el SP 

            DataTable Consulta = MiCnn.EjecutarSelect("SPUsuarioConsultarPorNombreUsuario");

            if (Consulta != null && Consulta.Rows.Count > 0)
            {
                R = true;

            }

            return R;

        }


        public bool ConsultarPorEmail()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //SELECT correspondiente y retornar TRUE si 
            // TODO listo ****



            bool R = false;

            Conexion MiCnn = new Conexion();
            //debemos pasar 1 parametro al SP DE CONSULTA
            //en el sql parametro se adjunta el parametro de SP
            MiCnn.ListaParametros.Add(new SqlParameter("@Email", this.Email));

            //ahora se llama el SP 

            DataTable Consulta = MiCnn.EjecutarSelect("SPUsuarioConsultarPorEmail");

            if (Consulta != null && Consulta.Rows.Count > 0)
            {
                R = true;

            }

            return R;

        }

        //listar con el bool sin parametros
        public DataTable ListarActivos()
        {
            //TODO usar SP con parametros para ver proveedores eliminados o activos
            DataTable R = new DataTable();

            return R;
        }

        //listar con el bool sin parametros
        public DataTable ListarInactivos()
        {
            //TODO usar SP con parametros para ver proveedores eliminados o activos
            DataTable R = new DataTable();

            return R;
        }

        public bool ValidarLogin(string NombreUsuario, string Contrasennia)
        {
            //TODO: ejecutar SP que contenga la instruccion
            //SELECT correspondiente y retornar TRUE si 
            // TODO sale bien
            bool R = false;

            return R;

        }

        public bool EnviarCodigoRecuperacion(string Email)
        {
            //TODO: ejecutar SP que contenga la instruccion
            //SELECT correspondiente y retornar TRUE si 
            // TODO sale bien
            bool R = false;

            return R;

        }

        public bool ResetearContrasennia()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //SELECT correspondiente y retornar TRUE si 
            // TODO sale bien
            bool R = false;

            return R;

        }

    }
}
