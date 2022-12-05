using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Cliente
    {
        public int IDCliente { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }
        //Eneste caso hay un atributo compuesto que une la clase cliente con la clase
        //empresa. Esto debido a la lectura de la relacion que existe desde el diagrama
        //entidad- relacion.
        public Empresa MiEmpresa { get; set; }

        //Cuando tratamos atributos complejos, estos se definen como  cualquier propiedad, 
        //pero no esta instanciada. por lo tanto se debe instancia en el contructor de la clase.
        //Constructor:
        public Cliente()
        {
            //este es el constructor de la clase
            MiEmpresa = new Empresa();
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
        public Cliente ConsultarPorID(int pIdCliente)
        {
            Cliente R = new Cliente();
            Conexion MyCnn = new Conexion();
            MyCnn.ListaParametros.Add(new SqlParameter("@ID", pIdCliente));
            DataTable dataCliente = new DataTable();
            dataCliente = MyCnn.EjecutarSelect("SPClienteConsultarPorID");

            //Una vez tewnemos un datatable con la data procedemos a llenar las propiedades del 
            //objeto retorno

            if (dataCliente != null && dataCliente.Rows.Count > 0)
            {
                DataRow Fila = dataCliente.Rows[0];
                R.IDCliente = Convert.ToInt32(Fila["IDCliente"]);
                R.Cedula = Convert.ToString(Fila["Cedula"]);
                R.Nombre = Convert.ToString(Fila["Nombre"]);
                R.CorreoElectronico = Convert.ToString(Fila["CorreoElectronico"]);
                R.Telefono = Convert.ToString(Fila["Telefono"]);
                R.Direccion = Convert.ToString(Fila["Direccion"]);
                R.Activo = Convert.ToBoolean(Fila["Activo"]);
                R.MiEmpresa.IDEmpresa = Convert.ToInt32(Fila["IDEmpresa"]);
            }
            return R;
        }
        public bool ConsultarPorCedula()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //SELECT correspondiente y retornar TRUE si 
            // TODO sale bien
            bool R = false;

            return R;

        }

        //Pendiente listar con el bool
        public DataTable Listar(bool VerActivos = true, string Filtro = "")
        {
            
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();
            MiCnn.ListaParametros.Add(new SqlParameter("@VerActivos", VerActivos));
            MiCnn.ListaParametros.Add(new SqlParameter("@FiltroBusqueda", Filtro));

            R = MiCnn.EjecutarSelect("SPClientesListar");


            return R;
        }

    }
}
