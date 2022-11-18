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

            Crypto MiEncriptador = new Crypto();
            string ContrasenniaEncriptada = MiEncriptador.EncriptarEnUnSentido(this.Contrasennia);
            MiCnn.ListaParametros.Add(new SqlParameter("@Contrasennia", ContrasenniaEncriptada));

            MiCnn.ListaParametros.Add(new SqlParameter("@Email", this.Email));

            //PARAMETROS PARA LOS FK, NORMALMENTE SON DE OBJETOS COMPUESTOS DE LA CLASE
            MiCnn.ListaParametros.Add(new SqlParameter("@IDUsuarioRol", this.MiUsuarioRol.IDUsuarioRol));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDEmpresa", this.MiEmpresa.IDEmpresa));

            //ahora se llama el SP 

            int Resultado = MiCnn.EjecutarUpdateDeleteInsert("SPUsuarioAgregar");

            if (Resultado > 0)
            {
                R = true;
                

            }

            return R;

        }
        public bool Modificar()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //UPDATE correspondiente y retornar TRUE si 
            // TODO sale bien
            bool R = false;

            Conexion MiCnn = new Conexion();
            //debemos pasar la lista parametros para el insert

            MiCnn.ListaParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn.ListaParametros.Add(new SqlParameter("@NombreUsuario", this.NombreUsuario));

            Crypto MiEncriptador = new Crypto();
            string ContrasenniaEncriptada = MiEncriptador.EncriptarEnUnSentido(this.Contrasennia);
            MiCnn.ListaParametros.Add(new SqlParameter("@Contrasennia", ContrasenniaEncriptada));


            MiCnn.ListaParametros.Add(new SqlParameter("@Email", this.Email));

            //PARAMETROS PARA LOS FK, NORMALMENTE SON DE OBJETOS COMPUESTOS DE LA CLASE
            MiCnn.ListaParametros.Add(new SqlParameter("@IDUsuarioRol", this.MiUsuarioRol.IDUsuarioRol));
            MiCnn.ListaParametros.Add(new SqlParameter("@IDEmpresa", this.MiEmpresa.IDEmpresa));

            //ID USUARIO
            MiCnn.ListaParametros.Add(new SqlParameter("@IDUsuario", this.IDUsuario));

            //ahora se llama el SP 

            int Resultado = MiCnn.EjecutarUpdateDeleteInsert("SPUsuarioModificar");

            if (Resultado > 0)
            {
                R = true;


            }



            return R;

        }
        public bool Eliminar()
        {
   
            //DELETE -> UPDATE correspondiente y retornar TRUE si 
            // SE HACEN ELIMINACIONES LOGICAS, LO QUE HAREMOS SERA CAMBIAR EL VALOR DE CAMPO 
            //ACTIVO A FALSE
            bool R = false;

            Conexion MiCnn = new Conexion();
            //debemos pasar la lista parametros para el insert

            //ID USUARIO
            MiCnn.ListaParametros.Add(new SqlParameter("@IDUsuario", this.IDUsuario));

            //ahora se llama el SP 

            int Resultado = MiCnn.EjecutarUpdateDeleteInsert("SPUsuarioEliminar");

            if (Resultado > 0)
            {
                R = true;


            }

            return R;

        }

        public bool Activar()
        {

            //ACTIVATE -> UPDATE correspondiente y retornar TRUE si 
            // SE HACEN ACTIVACIONES LOGICAS, LO QUE HAREMOS SERA CAMBIAR EL VALOR DE CAMPO 
            //ACTIVO A TRUE
            bool R = false;

            Conexion MiCnn = new Conexion();
            //debemos pasar la lista parametros para el insert

            //ID USUARIO
            MiCnn.ListaParametros.Add(new SqlParameter("@IDUsuario", this.IDUsuario));

            //ahora se llama el SP 

            int Resultado = MiCnn.EjecutarUpdateDeleteInsert("SPUsuarioActivar");

            if (Resultado > 0)
            {
                R = true;


            }

            return R;

        }

        public Usuario ConsultarPorID()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //SELECT correspondiente y retornar del mismo tipo de la clase
            // TODO sale bien entregue un select
            Usuario R = new Usuario();


            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDUsuario));
            DataTable dataUsuario = new DataTable();
            dataUsuario = MyCnn.EjecutarSelect("SPUsuarioConsultarPorID");

            //Una vez tewnemos un datatable con la data procedemos a llenar las propiedades del 
            //objeto retorno

            if (dataUsuario != null && dataUsuario.Rows.Count > 0)
            {

                DataRow Fila = dataUsuario.Rows[0];

                R.IDUsuario = Convert.ToInt32(Fila["IDUsuario"]);
                R.Nombre = Convert.ToString(Fila["Nombre"]);
                R.Cedula = Convert.ToString(Fila["Cedula"]);
                R.NombreUsuario = Convert.ToString(Fila["NombreUsuario"]);
                R.Contrasennia = String.Empty;
                R.Email = Convert.ToString(Fila["Email"]);
                R.MiUsuarioRol.Rol = Convert.ToString(Fila["Rol"]);
                R.MiUsuarioRol.IDUsuarioRol = Convert.ToInt32(Fila["IDUsuarioRol"]);
                R.MiEmpresa.IDEmpresa = Convert.ToInt32(Fila["IDEmpresa"]);
                R.Activo = Convert.ToBoolean(Fila["Activo"]);


            }



            return R;

        }

        public bool ConsultarPorID(int pIDUsuario)
        {
            //TODO: ejecutar SP que contenga la instruccion
            //SELECT correspondiente y retornar del mismo tipo de la clase
            // TODO sale bien entregue un select
            bool R = false;


            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@ID", pIDUsuario));
            DataTable dataUsuario = new DataTable();
            dataUsuario = MyCnn.EjecutarSelect("SPUsuarioConsultarPorID");


            if (dataUsuario != null && dataUsuario.Rows.Count > 0)
            {
                R = true;

            }

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
        public DataTable Listar(bool VerActivos = true, string FiltroBusqueda = "")
        {
            
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaParametros.Add(new SqlParameter("@VerActivos", VerActivos)); 
            MiCnn.ListaParametros.Add(new SqlParameter("@FiltroBusqueda", FiltroBusqueda));

            R = MiCnn.EjecutarSelect("SPUsuariosListar");


            return R;
        }


        public int ValidarLogin(string pNombreUsuario, string pContrasennia)
        {
            //TODO: ejecutar SP que contenga la instruccion
            //SELECT correspondiente y retornar TRUE si 
            // TODO sale bien
            int R = 0;

            Conexion MyCnn = new Conexion();

            Crypto MiEnc = new Crypto();    
            string PassEncriptado = MiEnc.EncriptarEnUnSentido(pContrasennia);

            MyCnn.ListaParametros.Add(new SqlParameter("NombreUsuario", pNombreUsuario));
            MyCnn.ListaParametros.Add(new SqlParameter("Contrasennia", PassEncriptado));


            DataTable respuesta = MyCnn.EjecutarSelect("SPUsuarioValidarLogin");

            if (respuesta != null && respuesta.Rows.Count > 0)
            {
                DataRow mifila = respuesta.Rows[0];

                R = Convert.ToInt32(mifila["IDUsuario"]);
            }

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
