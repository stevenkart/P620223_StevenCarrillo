using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Empresa
    {

        //Primero Escribimos las Propiedades Simples
        public int IDEmpresa { get; set; }
        public string CedulaEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string DireccionEmpresa { get; set; }
        public string EmailEmpresa { get; set; }
        public string TelefonoEmpresa { get; set; }
        public bool Activo { get; set; }

        // constructor

        public Empresa()
        {
            Activo = true;
        }

        // Funciones
        public DataTable Listar()
        {
            DataTable R = new DataTable();


            Conexion MiCnn = new Conexion();

            // paso 2.3 y 2.4 
            //No es necesario documentar o explicar los pasos dentro de la ejecucion del proceso en la
            //programacion ya que como se va a usar tantas veces no se veria bien explicarlos

            R = MiCnn.EjecutarSelect("SPEmpresasListar");

            return R;
        }

    }
}
