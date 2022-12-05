using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Factura
    {
        //simples
        public int IDFactura { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Notas { get; set; }

        //atributos compuestos
        public Cliente MiCliente { get; set; }
        public Usuario MiUsuario { get; set; }
        public FacturaTipo MiFacturaTipo { get; set; }
        public List<FacturaInventario> Detalle { get; set; }

        //constructor instanciar 
        public Factura()
        {
            MiCliente = new Cliente();
            MiUsuario = new Usuario();
            MiFacturaTipo = new FacturaTipo();
            Detalle = new List<FacturaInventario>();

            Fecha = DateTime.Now;
        }

        //fn & metodos
        //Funciones y metodos
        //Ahora se escribe las funciones y metodos(operaciones)
        public int Agregar()
        {
            //TODO: ejecutar SP que contenga la instruccion
            //INSERT correspondiente a retornar un int
 
            int R = 0;

            return R;

        }

        public bool Imprimir()
        {
            //TODO: ejecutar SP que contenga la instruccion
            // correspondiente y retornar TRUE si 
            // TODO sale bien
            bool R = false;

            return R;

        }

        public DataTable ListarPorFechas(DateTime FechaInicial, DateTime FechaFinal)
        {
            //TODO usar SP con parametros para ver las fechas de inicio y final
            DataTable R = new DataTable();

            return R;
        }
        public DataTable CargarEsquemaListaDetalle()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SPFacturaDetalleEsquema", true); //SOLO CARGA EL ESQUEMA, NO CARGA NINGUN DATO
            R.PrimaryKey = null;



            return R;

        }


    }
      
}
