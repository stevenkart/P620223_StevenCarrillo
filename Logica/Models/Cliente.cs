using System;
using System.Collections.Generic;
using System.Data;
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
        public Cliente ConsultarPorID()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //SELECT correspondiente y retornar del mismo tipo de la clase
            // TODO sale bien entregue un select
            Cliente R = new Cliente();

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
        public DataTable Listar(bool VerActivos = true)
        {
            //TODO usar SP con parametros para ver proveedores eliminados o activos
            DataTable R = new DataTable();

            return R;
        }

    }
}
