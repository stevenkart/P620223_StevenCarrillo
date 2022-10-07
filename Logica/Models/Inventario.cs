using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Inventario
    {

        public int IDInventario { get; set; }

        public string NombreItem { get; set; }
        public string CodigoBarras { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal CantidadEnStock { get; set; }
        public bool Activo { get; set; }

        //atributos compuesto

        public Empresa MiEmpresa { get; set; }
        public Categoria MiCategoria { get; set; }
        public Impuesto MiImpuesto { get; set; }
        //ya que se va a repetir N cantidad veces porque es de muchos a mucho
        //el atributo de la tabla inventario proveedor es multivaluado
        public List<InventarioProveedor> ListadoProveedores { get; set; }


        //constructor
        public Inventario()
        {
            MiEmpresa = new Empresa();
            MiCategoria = new Categoria();
            MiImpuesto = new Impuesto();
            ListadoProveedores = new List<InventarioProveedor>();
            Activo = true;
        }

        //fn & metodos
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

        public Inventario ConsultarPorID()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //SELECT correspondiente y retornar del mismo tipo de la clase
            // TODO sale bien entregue un select
            Inventario R = new Inventario();

            return R;

        }

        public bool ConsultarPorCodigoBarras( int IDEmpresa)
        {
            //TODO: ejecutar SP que contenga la instruccion
            //SELECT correspondiente y retornar el bool
            // TODO sale bien entregue un select
            bool R = false;

            return R;

        }

        public DataTable Listar(bool VerActivos = true)
        {
            //TODO usar SP con parametros para ver proveedores eliminados o activos
            DataTable R = new DataTable();

            return R;
        }

        public DataTable ListarProveedores()
        {
            //TODO usar SP con parametros para ver proveedores eliminados o activos
            DataTable R = new DataTable();

            return R;
        }

        public bool AgregarProveedor()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //INSERT correspondiente y retornar TRUE si 
            // TODO sale bien
            bool R = false;

            return R;

        }
        public bool ModificarPrecioProveedor()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //UPDATE correspondiente y retornar TRUE si 
            // TODO sale bien
            bool R = false;

            return R;

        }
        public bool EliminarProveedor()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //DELETE -> UPDATE correspondiente y retornar TRUE si 
            // TODO sale bien
            // SE HACEN ELIMINACIONES LOGICAS, LO QUE HAREMOS SERA CAMBIAR EL VALOR DE CAMPO 
            //ACTIVO A FALSE
            bool R = false;

            return R;

        }

    }
}
